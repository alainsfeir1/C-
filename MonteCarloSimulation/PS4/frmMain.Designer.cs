namespace PS4
{
    partial class frmMain
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
            this.Chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPVstddev_maximum = new System.Windows.Forms.TextBox();
            this.txtPVmean_minimum = new System.Windows.Forms.TextBox();
            this.lblPVstddev_maximum = new System.Windows.Forms.Label();
            this.lblPVmean_minimum = new System.Windows.Forms.Label();
            this.rdoPVNormal = new System.Windows.Forms.RadioButton();
            this.rdoPVuniform = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNstddev_maximum = new System.Windows.Forms.TextBox();
            this.txtNmean_minimum = new System.Windows.Forms.TextBox();
            this.lblNstddev_maximum = new System.Windows.Forms.Label();
            this.lblNmean_minimum = new System.Windows.Forms.Label();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoNuniform = new System.Windows.Forms.RadioButton();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtNumBins = new System.Windows.Forms.TextBox();
            this.txtNumIterations = new System.Windows.Forms.TextBox();
            this.txtTotAvgProp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chart
            // 
            chartArea1.Name = "ChartArea1";
            this.Chart.ChartAreas.Add(chartArea1);
            this.Chart.Location = new System.Drawing.Point(38, 2);
            this.Chart.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Chart.Name = "Chart";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.Chart.Series.Add(series1);
            this.Chart.Size = new System.Drawing.Size(380, 221);
            this.Chart.TabIndex = 0;
            this.Chart.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Average Total Profit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 246);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Number of Bins";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 245);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Number of Iterations";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPVstddev_maximum);
            this.groupBox1.Controls.Add(this.txtPVmean_minimum);
            this.groupBox1.Controls.Add(this.lblPVstddev_maximum);
            this.groupBox1.Controls.Add(this.lblPVmean_minimum);
            this.groupBox1.Controls.Add(this.rdoPVNormal);
            this.groupBox1.Controls.Add(this.rdoPVuniform);
            this.groupBox1.Location = new System.Drawing.Point(38, 277);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(187, 154);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pv";
            // 
            // txtPVstddev_maximum
            // 
            this.txtPVstddev_maximum.Location = new System.Drawing.Point(109, 104);
            this.txtPVstddev_maximum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPVstddev_maximum.Name = "txtPVstddev_maximum";
            this.txtPVstddev_maximum.Size = new System.Drawing.Size(74, 20);
            this.txtPVstddev_maximum.TabIndex = 5;
            // 
            // txtPVmean_minimum
            // 
            this.txtPVmean_minimum.Location = new System.Drawing.Point(109, 76);
            this.txtPVmean_minimum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPVmean_minimum.Name = "txtPVmean_minimum";
            this.txtPVmean_minimum.Size = new System.Drawing.Size(74, 20);
            this.txtPVmean_minimum.TabIndex = 4;
            // 
            // lblPVstddev_maximum
            // 
            this.lblPVstddev_maximum.AutoSize = true;
            this.lblPVstddev_maximum.Location = new System.Drawing.Point(8, 106);
            this.lblPVstddev_maximum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPVstddev_maximum.Name = "lblPVstddev_maximum";
            this.lblPVstddev_maximum.Size = new System.Drawing.Size(98, 13);
            this.lblPVstddev_maximum.TabIndex = 3;
            this.lblPVstddev_maximum.Text = "Standard Deviation";
            // 
            // lblPVmean_minimum
            // 
            this.lblPVmean_minimum.AutoSize = true;
            this.lblPVmean_minimum.Location = new System.Drawing.Point(8, 79);
            this.lblPVmean_minimum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPVmean_minimum.Name = "lblPVmean_minimum";
            this.lblPVmean_minimum.Size = new System.Drawing.Size(34, 13);
            this.lblPVmean_minimum.TabIndex = 2;
            this.lblPVmean_minimum.Text = "Mean";
            // 
            // rdoPVNormal
            // 
            this.rdoPVNormal.AutoSize = true;
            this.rdoPVNormal.Checked = true;
            this.rdoPVNormal.Location = new System.Drawing.Point(49, 40);
            this.rdoPVNormal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoPVNormal.Name = "rdoPVNormal";
            this.rdoPVNormal.Size = new System.Drawing.Size(58, 17);
            this.rdoPVNormal.TabIndex = 1;
            this.rdoPVNormal.TabStop = true;
            this.rdoPVNormal.Text = "Normal";
            this.rdoPVNormal.UseVisualStyleBackColor = true;
            // 
            // rdoPVuniform
            // 
            this.rdoPVuniform.AutoSize = true;
            this.rdoPVuniform.Location = new System.Drawing.Point(49, 17);
            this.rdoPVuniform.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoPVuniform.Name = "rdoPVuniform";
            this.rdoPVuniform.Size = new System.Drawing.Size(61, 17);
            this.rdoPVuniform.TabIndex = 0;
            this.rdoPVuniform.Text = "Uniform";
            this.rdoPVuniform.UseVisualStyleBackColor = true;
            this.rdoPVuniform.CheckedChanged += new System.EventHandler(this.rdoPVuniform_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNstddev_maximum);
            this.groupBox2.Controls.Add(this.txtNmean_minimum);
            this.groupBox2.Controls.Add(this.lblNstddev_maximum);
            this.groupBox2.Controls.Add(this.lblNmean_minimum);
            this.groupBox2.Controls.Add(this.rdoNormal);
            this.groupBox2.Controls.Add(this.rdoNuniform);
            this.groupBox2.Location = new System.Drawing.Point(229, 277);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(188, 154);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "N";
            // 
            // txtNstddev_maximum
            // 
            this.txtNstddev_maximum.Location = new System.Drawing.Point(109, 106);
            this.txtNstddev_maximum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNstddev_maximum.Name = "txtNstddev_maximum";
            this.txtNstddev_maximum.Size = new System.Drawing.Size(76, 20);
            this.txtNstddev_maximum.TabIndex = 5;
            // 
            // txtNmean_minimum
            // 
            this.txtNmean_minimum.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNmean_minimum.Location = new System.Drawing.Point(109, 76);
            this.txtNmean_minimum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNmean_minimum.Name = "txtNmean_minimum";
            this.txtNmean_minimum.Size = new System.Drawing.Size(76, 20);
            this.txtNmean_minimum.TabIndex = 4;
            // 
            // lblNstddev_maximum
            // 
            this.lblNstddev_maximum.AutoSize = true;
            this.lblNstddev_maximum.Location = new System.Drawing.Point(4, 109);
            this.lblNstddev_maximum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNstddev_maximum.Name = "lblNstddev_maximum";
            this.lblNstddev_maximum.Size = new System.Drawing.Size(51, 13);
            this.lblNstddev_maximum.TabIndex = 3;
            this.lblNstddev_maximum.Text = "Maximum";
            // 
            // lblNmean_minimum
            // 
            this.lblNmean_minimum.AutoSize = true;
            this.lblNmean_minimum.Location = new System.Drawing.Point(7, 76);
            this.lblNmean_minimum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNmean_minimum.Name = "lblNmean_minimum";
            this.lblNmean_minimum.Size = new System.Drawing.Size(48, 13);
            this.lblNmean_minimum.TabIndex = 2;
            this.lblNmean_minimum.Text = "Minimum";
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Location = new System.Drawing.Point(61, 40);
            this.rdoNormal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(58, 17);
            this.rdoNormal.TabIndex = 1;
            this.rdoNormal.Text = "Normal";
            this.rdoNormal.UseVisualStyleBackColor = true;
            // 
            // rdoNuniform
            // 
            this.rdoNuniform.AutoSize = true;
            this.rdoNuniform.Checked = true;
            this.rdoNuniform.Location = new System.Drawing.Point(61, 19);
            this.rdoNuniform.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoNuniform.Name = "rdoNuniform";
            this.rdoNuniform.Size = new System.Drawing.Size(61, 17);
            this.rdoNuniform.TabIndex = 0;
            this.rdoNuniform.TabStop = true;
            this.rdoNuniform.Text = "Uniform";
            this.rdoNuniform.UseVisualStyleBackColor = true;
            this.rdoNuniform.CheckedChanged += new System.EventHandler(this.rdoNuniform_CheckedChanged);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(491, 210);
            this.btnRun.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(65, 49);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtNumBins
            // 
            this.txtNumBins.Location = new System.Drawing.Point(118, 246);
            this.txtNumBins.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumBins.Name = "txtNumBins";
            this.txtNumBins.Size = new System.Drawing.Size(76, 20);
            this.txtNumBins.TabIndex = 7;
            // 
            // txtNumIterations
            // 
            this.txtNumIterations.Location = new System.Drawing.Point(333, 245);
            this.txtNumIterations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNumIterations.Name = "txtNumIterations";
            this.txtNumIterations.Size = new System.Drawing.Size(76, 20);
            this.txtNumIterations.TabIndex = 8;
            // 
            // txtTotAvgProp
            // 
            this.txtTotAvgProp.Location = new System.Drawing.Point(491, 119);
            this.txtTotAvgProp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotAvgProp.Name = "txtTotAvgProp";
            this.txtTotAvgProp.Size = new System.Drawing.Size(76, 20);
            this.txtTotAvgProp.TabIndex = 9;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 440);
            this.Controls.Add(this.txtTotAvgProp);
            this.Controls.Add(this.txtNumIterations);
            this.Controls.Add(this.txtNumBins);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Chart);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Chart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Chart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtPVstddev_maximum;
        private System.Windows.Forms.TextBox txtPVmean_minimum;
        private System.Windows.Forms.Label lblPVstddev_maximum;
        private System.Windows.Forms.Label lblPVmean_minimum;
        private System.Windows.Forms.RadioButton rdoPVNormal;
        private System.Windows.Forms.RadioButton rdoPVuniform;
        private System.Windows.Forms.TextBox txtNstddev_maximum;
        private System.Windows.Forms.TextBox txtNmean_minimum;
        private System.Windows.Forms.Label lblNstddev_maximum;
        private System.Windows.Forms.Label lblNmean_minimum;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoNuniform;
        private System.Windows.Forms.TextBox txtNumBins;
        private System.Windows.Forms.TextBox txtNumIterations;
        private System.Windows.Forms.TextBox txtTotAvgProp;
    }
}

