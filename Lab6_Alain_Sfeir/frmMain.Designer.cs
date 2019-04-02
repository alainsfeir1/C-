namespace Lab6_Alain_Sfeir
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea10 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend10 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.lblC = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.lblA = new System.Windows.Forms.Label();
            this.lblEqn = new System.Windows.Forms.Label();
            this.lblParabola = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtXmin = new System.Windows.Forms.TextBox();
            this.txtXmax = new System.Windows.Forms.TextBox();
            this.txtYmin = new System.Windows.Forms.TextBox();
            this.txtYmax = new System.Windows.Forms.TextBox();
            this.txtnumPoints = new System.Windows.Forms.TextBox();
            this.chtMain = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGraph = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chtMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 555);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtC);
            this.tabPage1.Controls.Add(this.txtB);
            this.tabPage1.Controls.Add(this.txtA);
            this.tabPage1.Controls.Add(this.lblC);
            this.tabPage1.Controls.Add(this.lblB);
            this.tabPage1.Controls.Add(this.lblA);
            this.tabPage1.Controls.Add(this.lblEqn);
            this.tabPage1.Controls.Add(this.lblParabola);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(827, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Y=";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(147, 311);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 22);
            this.txtC.TabIndex = 7;
            this.txtC.TextChanged += new System.EventHandler(this.txtC_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(147, 277);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 22);
            this.txtB.TabIndex = 6;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(147, 240);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 22);
            this.txtA.TabIndex = 5;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC.Location = new System.Drawing.Point(80, 311);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(18, 20);
            this.lblC.TabIndex = 4;
            this.lblC.Text = "c";
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB.Location = new System.Drawing.Point(80, 277);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(18, 20);
            this.lblB.TabIndex = 3;
            this.lblB.Text = "b";
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA.Location = new System.Drawing.Point(77, 240);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(18, 20);
            this.lblA.TabIndex = 2;
            this.lblA.Text = "a";
            // 
            // lblEqn
            // 
            this.lblEqn.AutoSize = true;
            this.lblEqn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEqn.Location = new System.Drawing.Point(74, 121);
            this.lblEqn.Name = "lblEqn";
            this.lblEqn.Size = new System.Drawing.Size(258, 32);
            this.lblEqn.TabIndex = 1;
            this.lblEqn.Text = "y = (a)x^2 + (b)x + c";
            // 
            // lblParabola
            // 
            this.lblParabola.AutoSize = true;
            this.lblParabola.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblParabola.Location = new System.Drawing.Point(74, 58);
            this.lblParabola.Name = "lblParabola";
            this.lblParabola.Size = new System.Drawing.Size(134, 36);
            this.lblParabola.TabIndex = 0;
            this.lblParabola.Text = "Parabola";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtnumPoints);
            this.tabPage2.Controls.Add(this.txtYmax);
            this.tabPage2.Controls.Add(this.txtYmin);
            this.tabPage2.Controls.Add(this.txtXmax);
            this.tabPage2.Controls.Add(this.txtXmin);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(827, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Window";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnGraph);
            this.tabPage3.Controls.Add(this.chtMain);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(827, 526);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Graph";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(120, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Xmin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(120, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Xmax";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(120, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ymin";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(120, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ymax";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(120, 286);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "# Points";
            // 
            // txtXmin
            // 
            this.txtXmin.Location = new System.Drawing.Point(236, 99);
            this.txtXmin.Name = "txtXmin";
            this.txtXmin.Size = new System.Drawing.Size(100, 22);
            this.txtXmin.TabIndex = 5;
            this.txtXmin.TextChanged += new System.EventHandler(this.txtXmin_TextChanged);
            // 
            // txtXmax
            // 
            this.txtXmax.Location = new System.Drawing.Point(236, 150);
            this.txtXmax.Name = "txtXmax";
            this.txtXmax.Size = new System.Drawing.Size(100, 22);
            this.txtXmax.TabIndex = 6;
            this.txtXmax.TextChanged += new System.EventHandler(this.txtXmax_TextChanged);
            // 
            // txtYmin
            // 
            this.txtYmin.Location = new System.Drawing.Point(236, 195);
            this.txtYmin.Name = "txtYmin";
            this.txtYmin.Size = new System.Drawing.Size(100, 22);
            this.txtYmin.TabIndex = 7;
            this.txtYmin.TextChanged += new System.EventHandler(this.txtYmin_TextChanged);
            // 
            // txtYmax
            // 
            this.txtYmax.Location = new System.Drawing.Point(236, 244);
            this.txtYmax.Name = "txtYmax";
            this.txtYmax.Size = new System.Drawing.Size(100, 22);
            this.txtYmax.TabIndex = 8;
            this.txtYmax.TextChanged += new System.EventHandler(this.txtYmax_TextChanged);
            // 
            // txtnumPoints
            // 
            this.txtnumPoints.Location = new System.Drawing.Point(236, 292);
            this.txtnumPoints.Name = "txtnumPoints";
            this.txtnumPoints.Size = new System.Drawing.Size(100, 22);
            this.txtnumPoints.TabIndex = 9;
            this.txtnumPoints.TextChanged += new System.EventHandler(this.txtnumPoints_TextChanged);
            // 
            // chtMain
            // 
            chartArea10.Name = "ChartArea1";
            this.chtMain.ChartAreas.Add(chartArea10);
            this.chtMain.Cursor = System.Windows.Forms.Cursors.Default;
            legend10.Name = "Legend1";
            this.chtMain.Legends.Add(legend10);
            this.chtMain.Location = new System.Drawing.Point(71, 63);
            this.chtMain.Name = "chtMain";
            series10.ChartArea = "ChartArea1";
            series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series10.Legend = "Legend1";
            series10.Name = "Graph";
            this.chtMain.Series.Add(series10);
            this.chtMain.Size = new System.Drawing.Size(687, 407);
            this.chtMain.TabIndex = 0;
            this.chtMain.Text = "chtGraph";
            // 
            // btnGraph
            // 
            this.btnGraph.Location = new System.Drawing.Point(680, 477);
            this.btnGraph.Name = "btnGraph";
            this.btnGraph.Size = new System.Drawing.Size(75, 23);
            this.btnGraph.TabIndex = 1;
            this.btnGraph.Text = "Graph";
            this.btnGraph.UseVisualStyleBackColor = true;
            this.btnGraph.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 558);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmMain";
            this.Text = "Grapher";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chtMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.Label lblEqn;
        private System.Windows.Forms.Label lblParabola;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumPoints;
        private System.Windows.Forms.TextBox txtYmax;
        private System.Windows.Forms.TextBox txtYmin;
        private System.Windows.Forms.TextBox txtXmax;
        private System.Windows.Forms.TextBox txtXmin;
        private System.Windows.Forms.DataVisualization.Charting.Chart chtMain;
        private System.Windows.Forms.Button btnGraph;
    }
}

