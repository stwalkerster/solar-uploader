using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SolarDataUploader
{
    public partial class Form1 : Form
    {
        private MySqlConnection _conn;

        public Form1()
        {
            InitializeComponent();
            comboBox1.Enabled = !checkBox1.Checked;
            button1.Enabled = !checkBox1.Checked;
            reopenDatabase();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            reopenDatabase();
            comboBox1.Items.Clear();
            MySqlDataReader dr = new MySqlCommand("SHOW DATABASES;", _conn).ExecuteReader();
            while(dr.Read())
            {
                comboBox1.Items.Add(dr.GetString(0));
            }
            dr.Close();
        }

        private void reopenDatabase()
        {
            MySqlConnectionStringBuilder mycsb = new MySqlConnectionStringBuilder
                                                     {
                                                         Password = textBox3.Text,
                                                         Port = (uint) numericUpDown1.Value,
                                                         Server = textBox1.Text,
                                                         UserID = textBox2.Text
                                                     };

            if (_conn != null)
                if (_conn.State == ConnectionState.Open)
                    _conn.Close();

            _conn = new MySqlConnection(mycsb.GetConnectionString(true));
            _conn.Open();


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = !checkBox1.Checked;
            button1.Enabled = !checkBox1.Checked;
        }
        Dictionary<DateTime, float> data = new Dictionary<DateTime, float>();
        float gen = 0;
        DateTime date = DateTime.MinValue;
        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            label6.Text = openFileDialog1.FileName;
            
            try
            {
                data = analyseFile(openFileDialog1.FileName, out date, out gen);
            }
            catch (IOException ex)
            {
                MessageBox.Show("IO error encountered reading file. Please try again.\n\n" + ex.Message);
            }

            label8.Text = string.Format("On {0}, {1} kWh was generated.", date, gen);
            

            chart1.Series[0].Points.Clear();
            foreach (KeyValuePair<DateTime, float> keyValuePair in data)
            {
                chart1.Series[0].Points.AddXY(keyValuePair.Key, keyValuePair.Value);
            }
            groupBox3.Visible = true;

        }

        private static Dictionary<DateTime, float> analyseFile(string path, out DateTime fileDate, out float totalGeneration)
        {
            StreamReader sr = new StreamReader(path);
            sr.ReadLine(); // sep=;
            string data = sr.ReadLine();
            Regex r = new Regex(@"\|(?<date>[0-9]{2}/[0-9]{2}/[0-9]{4})$");
            string date = r.Match(data).Groups["date"].Value;
            Dictionary<DateTime, float> dataDict = new Dictionary<DateTime, float>();

            r = new Regex(@"^(?<time>[0-2][0-9]:[0-5]0);(?<kwh>[0-9.]+)$");

            Regex rtotal = new Regex(@"^E-Today kWh;(?<kwh>[0-9.]+)$");
            totalGeneration = 0;
            while (!sr.EndOfStream)
            {
                data = sr.ReadLine();
                Match m = r.Match(data);
                if (m.Success)
                {
                    float gen = float.Parse(m.Groups["kwh"].Value);
                    dataDict.Add(DateTime.Parse(date + " " + m.Groups["time"].Value), gen);
                }
                m = rtotal.Match(data);
                if (m.Success)
                {
                    totalGeneration = float.Parse(m.Groups["kwh"].Value);
                }

            }
            fileDate = DateTime.Parse(date);
            return dataDict;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            _conn.ChangeDatabase(comboBox1.Text);

            MySqlTransaction t =  _conn.BeginTransaction(IsolationLevel.Serializable);
            try
            {
                MySqlCommand cmd;
                foreach (KeyValuePair<DateTime, float> keyValuePair in data)
                {
                    cmd = new MySqlCommand(
                        string.Format("INSERT INTO hourlydata VALUES ('{0}','{1}');",
                                      keyValuePair.Key.ToString("yyyy'-'MM'-'dd HH':'mm':'ss"),
                                      keyValuePair.Value), _conn);
                    cmd.ExecuteNonQuery();
                }

                cmd = new MySqlCommand(
                    string.Format("INSERT INTO dailydata VALUES ('{0}','{1}');",
                                  date.ToString("yyyy'-'MM'-'dd HH':'mm':'ss"),
                                  gen), _conn);
                cmd.ExecuteNonQuery();

                t.Commit();
            }
            catch(MySqlException)
            {
                t.Rollback();
            }
        }
    }
}
