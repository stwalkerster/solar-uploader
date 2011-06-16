namespace SolarDataUploader
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonDbTest = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBoxSchema = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonDatafileBrowse = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.chartDataVisualiser = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataVisualiser)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Host:Port";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = ":";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.buttonDbTest);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.comboBoxSchema);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 186);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MySQL Database Server settings";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = global::SolarDataUploader.Properties.Settings.Default.settingsLocked;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::SolarDataUploader.Properties.Settings.Default, "settingsLocked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(220, 163);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(104, 17);
            this.checkBox1.TabIndex = 13;
            this.checkBox1.Text = "Lock Settings";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonDbTest
            // 
            this.buttonDbTest.Location = new System.Drawing.Point(9, 97);
            this.buttonDbTest.Name = "buttonDbTest";
            this.buttonDbTest.Size = new System.Drawing.Size(315, 23);
            this.buttonDbTest.TabIndex = 12;
            this.buttonDbTest.Text = "Test settings";
            this.buttonDbTest.UseVisualStyleBackColor = true;
            this.buttonDbTest.Click += new System.EventHandler(this.buttonDbTest_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SolarDataUploader.Properties.Settings.Default, "dbHost", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", global::SolarDataUploader.Properties.Settings.Default, "settingsLocked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox1.Location = new System.Drawing.Point(68, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = global::SolarDataUploader.Properties.Settings.Default.settingsLocked;
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = global::SolarDataUploader.Properties.Settings.Default.dbHost;
            // 
            // comboBoxSchema
            // 
            this.comboBoxSchema.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SolarDataUploader.Properties.Settings.Default, "dbSchema", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.comboBoxSchema.FormattingEnabled = true;
            this.comboBoxSchema.Location = new System.Drawing.Point(68, 126);
            this.comboBoxSchema.Name = "comboBoxSchema";
            this.comboBoxSchema.Size = new System.Drawing.Size(256, 21);
            this.comboBoxSchema.TabIndex = 11;
            this.comboBoxSchema.Text = global::SolarDataUploader.Properties.Settings.Default.dbSchema;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SolarDataUploader.Properties.Settings.Default, "dbUsername", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", global::SolarDataUploader.Properties.Settings.Default, "settingsLocked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox2.Location = new System.Drawing.Point(68, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = global::SolarDataUploader.Properties.Settings.Default.settingsLocked;
            this.textBox2.Size = new System.Drawing.Size(256, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = global::SolarDataUploader.Properties.Settings.Default.dbUsername;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Schema";
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::SolarDataUploader.Properties.Settings.Default, "dbPassword", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", global::SolarDataUploader.Properties.Settings.Default, "settingsLocked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBox3.Location = new System.Drawing.Point(68, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = global::SolarDataUploader.Properties.Settings.Default.settingsLocked;
            this.textBox3.Size = new System.Drawing.Size(256, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = global::SolarDataUploader.Properties.Settings.Default.dbPassword;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::SolarDataUploader.Properties.Settings.Default, "dbPort", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown1.DataBindings.Add(new System.Windows.Forms.Binding("ReadOnly", global::SolarDataUploader.Properties.Settings.Default, "settingsLocked", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.numericUpDown1.Location = new System.Drawing.Point(271, 20);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            65536,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = global::SolarDataUploader.Properties.Settings.Default.settingsLocked;
            this.numericUpDown1.Size = new System.Drawing.Size(53, 20);
            this.numericUpDown1.TabIndex = 7;
            this.numericUpDown1.Value = global::SolarDataUploader.Properties.Settings.Default.dbPort;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "csv";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "CSV Files|*.csv";
            this.openFileDialog1.Title = "Open SunnyBeam Data File";
            // 
            // buttonDatafileBrowse
            // 
            this.buttonDatafileBrowse.Location = new System.Drawing.Point(401, 17);
            this.buttonDatafileBrowse.Name = "buttonDatafileBrowse";
            this.buttonDatafileBrowse.Size = new System.Drawing.Size(75, 23);
            this.buttonDatafileBrowse.TabIndex = 9;
            this.buttonDatafileBrowse.Text = "Browse";
            this.buttonDatafileBrowse.UseVisualStyleBackColor = true;
            this.buttonDatafileBrowse.Click += new System.EventHandler(this.buttonDatafileBrowse_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelFileName);
            this.groupBox2.Controls.Add(this.buttonDatafileBrowse);
            this.groupBox2.Location = new System.Drawing.Point(351, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(482, 49);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data File";
            // 
            // labelFileName
            // 
            this.labelFileName.Location = new System.Drawing.Point(6, 22);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(389, 17);
            this.labelFileName.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonSave);
            this.groupBox3.Controls.Add(this.chartDataVisualiser);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(351, 67);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(482, 254);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistics";
            this.groupBox3.Visible = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(305, 19);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(171, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Write Data";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // chartDataVisualiser
            // 
            chartArea1.AxisX.Title = "Time of Day";
            chartArea1.AxisY.Title = "Generated";
            chartArea1.Name = "ChartArea1";
            this.chartDataVisualiser.ChartAreas.Add(chartArea1);
            this.chartDataVisualiser.Location = new System.Drawing.Point(6, 35);
            this.chartDataVisualiser.Name = "chartDataVisualiser";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Time;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartDataVisualiser.Series.Add(series1);
            this.chartDataVisualiser.Size = new System.Drawing.Size(470, 213);
            this.chartDataVisualiser.TabIndex = 2;
            this.chartDataVisualiser.Text = "chart1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Total Generation (kWh)";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(333, 123);
            this.label7.TabIndex = 12;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 333);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Solar Data Uploader";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDataVisualiser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxSchema;
        private System.Windows.Forms.Button buttonDbTest;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonDatafileBrowse;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDataVisualiser;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label7;
    }
}

