namespace Lab9_Alain_Sfeir
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.medicalRecordsDataSet = new Lab9_Alain_Sfeir.MedicalRecordsDataSet();
            this.medicalRecordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.medicalRecordsTableAdapter = new Lab9_Alain_Sfeir.MedicalRecordsDataSetTableAdapters.MedicalRecordsTableAdapter();
            this.tableAdapterManager = new Lab9_Alain_Sfeir.MedicalRecordsDataSetTableAdapters.TableAdapterManager();
            this.medicalRecordsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.medicalRecordsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnAnalyze = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl66 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl78 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.lblavgBil_L = new System.Windows.Forms.Label();
            this.lblstdBill_L = new System.Windows.Forms.Label();
            this.lblavgBil_D = new System.Windows.Forms.Label();
            this.lblstdBill_D = new System.Windows.Forms.Label();
            this.lblavgAlk_L = new System.Windows.Forms.Label();
            this.lblstdAlk_L = new System.Windows.Forms.Label();
            this.lblavgAlk_D = new System.Windows.Forms.Label();
            this.lblstdAlk_D = new System.Windows.Forms.Label();
            this.lblavgSGot_L = new System.Windows.Forms.Label();
            this.lblstdSGot_L = new System.Windows.Forms.Label();
            this.lblavgSGot_D = new System.Windows.Forms.Label();
            this.lblstdSGot_D = new System.Windows.Forms.Label();
            this.lblavgAl_L = new System.Windows.Forms.Label();
            this.lblstdAL_L = new System.Windows.Forms.Label();
            this.lblavgAL_D = new System.Windows.Forms.Label();
            this.lblstdAL_D = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordsBindingNavigator)).BeginInit();
            this.medicalRecordsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // medicalRecordsDataSet
            // 
            this.medicalRecordsDataSet.DataSetName = "MedicalRecordsDataSet";
            this.medicalRecordsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // medicalRecordsBindingSource
            // 
            this.medicalRecordsBindingSource.DataMember = "MedicalRecords";
            this.medicalRecordsBindingSource.DataSource = this.medicalRecordsDataSet;
            // 
            // medicalRecordsTableAdapter
            // 
            this.medicalRecordsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.MedicalRecordsTableAdapter = this.medicalRecordsTableAdapter;
            this.tableAdapterManager.UpdateOrder = Lab9_Alain_Sfeir.MedicalRecordsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // medicalRecordsBindingNavigator
            // 
            this.medicalRecordsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.medicalRecordsBindingNavigator.BindingSource = this.medicalRecordsBindingSource;
            this.medicalRecordsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.medicalRecordsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.medicalRecordsBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.medicalRecordsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.medicalRecordsBindingNavigatorSaveItem});
            this.medicalRecordsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.medicalRecordsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.medicalRecordsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.medicalRecordsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.medicalRecordsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.medicalRecordsBindingNavigator.Name = "medicalRecordsBindingNavigator";
            this.medicalRecordsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.medicalRecordsBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.medicalRecordsBindingNavigator.TabIndex = 0;
            this.medicalRecordsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(24, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // medicalRecordsBindingNavigatorSaveItem
            // 
            this.medicalRecordsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.medicalRecordsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("medicalRecordsBindingNavigatorSaveItem.Image")));
            this.medicalRecordsBindingNavigatorSaveItem.Name = "medicalRecordsBindingNavigatorSaveItem";
            this.medicalRecordsBindingNavigatorSaveItem.Size = new System.Drawing.Size(24, 24);
            this.medicalRecordsBindingNavigatorSaveItem.Text = "Save Data";
            this.medicalRecordsBindingNavigatorSaveItem.Click += new System.EventHandler(this.medicalRecordsBindingNavigatorSaveItem_Click);
            // 
            // btnAnalyze
            // 
            this.btnAnalyze.Location = new System.Drawing.Point(621, 341);
            this.btnAnalyze.Name = "btnAnalyze";
            this.btnAnalyze.Size = new System.Drawing.Size(126, 56);
            this.btnAnalyze.TabIndex = 1;
            this.btnAnalyze.Text = "Analyze";
            this.btnAnalyze.UseVisualStyleBackColor = true;
            this.btnAnalyze.Click += new System.EventHandler(this.btnAnalyze_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Average Bilrubin (Lived): ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Std. Dev Bilrubin (Lived): ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Average Bilrubin (Died): ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Std. Dev Bilrubin (Died): ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(60, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(204, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Average AlkPhosphate(Lived): ";
            // 
            // lbl66
            // 
            this.lbl66.AutoSize = true;
            this.lbl66.Location = new System.Drawing.Point(60, 250);
            this.lbl66.Name = "lbl66";
            this.lbl66.Size = new System.Drawing.Size(205, 17);
            this.lbl66.TabIndex = 7;
            this.lbl66.Text = "Std. Dev AlkPhosphate(Lived): ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(149, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Average SGot(Lived): ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 267);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 17);
            this.label8.TabIndex = 9;
            // 
            // lbl78
            // 
            this.lbl78.AutoSize = true;
            this.lbl78.Location = new System.Drawing.Point(60, 284);
            this.lbl78.Name = "lbl78";
            this.lbl78.Size = new System.Drawing.Size(199, 17);
            this.lbl78.TabIndex = 10;
            this.lbl78.Text = "Average AlkPhosphate(Died): ";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(456, 138);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(144, 17);
            this.lbl2.TabIndex = 11;
            this.lbl2.Text = "Average SGot(Died): ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(456, 224);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(167, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Average Albumin(Lived): ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(456, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Average Albumin(Died): ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(63, 314);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(200, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = "Std. Dev AlkPhosphate(Died): ";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(459, 111);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(150, 17);
            this.lbl1.TabIndex = 15;
            this.lbl1.Text = "Std. Dev SGot(Lived): ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(455, 165);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(145, 17);
            this.label15.TabIndex = 16;
            this.label15.Text = "Std. Dev SGot(Died): ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(459, 250);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(168, 17);
            this.label16.TabIndex = 17;
            this.label16.Text = "Std. Dev Albumin(Lived): ";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(459, 313);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(163, 17);
            this.label17.TabIndex = 18;
            this.label17.Text = "Std. Dev Albumin(Died): ";
            // 
            // lblavgBil_L
            // 
            this.lblavgBil_L.AutoSize = true;
            this.lblavgBil_L.Location = new System.Drawing.Point(248, 79);
            this.lblavgBil_L.Name = "lblavgBil_L";
            this.lblavgBil_L.Size = new System.Drawing.Size(16, 17);
            this.lblavgBil_L.TabIndex = 19;
            this.lblavgBil_L.Text = "0";
            // 
            // lblstdBill_L
            // 
            this.lblstdBill_L.AutoSize = true;
            this.lblstdBill_L.Location = new System.Drawing.Point(248, 111);
            this.lblstdBill_L.Name = "lblstdBill_L";
            this.lblstdBill_L.Size = new System.Drawing.Size(16, 17);
            this.lblstdBill_L.TabIndex = 20;
            this.lblstdBill_L.Text = "0";
            // 
            // lblavgBil_D
            // 
            this.lblavgBil_D.AutoSize = true;
            this.lblavgBil_D.Location = new System.Drawing.Point(248, 138);
            this.lblavgBil_D.Name = "lblavgBil_D";
            this.lblavgBil_D.Size = new System.Drawing.Size(16, 17);
            this.lblavgBil_D.TabIndex = 21;
            this.lblavgBil_D.Text = "0";
            // 
            // lblstdBill_D
            // 
            this.lblstdBill_D.AutoSize = true;
            this.lblstdBill_D.Location = new System.Drawing.Point(251, 165);
            this.lblstdBill_D.Name = "lblstdBill_D";
            this.lblstdBill_D.Size = new System.Drawing.Size(16, 17);
            this.lblstdBill_D.TabIndex = 22;
            this.lblstdBill_D.Text = "0";
            // 
            // lblavgAlk_L
            // 
            this.lblavgAlk_L.AutoSize = true;
            this.lblavgAlk_L.Location = new System.Drawing.Point(271, 224);
            this.lblavgAlk_L.Name = "lblavgAlk_L";
            this.lblavgAlk_L.Size = new System.Drawing.Size(16, 17);
            this.lblavgAlk_L.TabIndex = 23;
            this.lblavgAlk_L.Text = "0";
            // 
            // lblstdAlk_L
            // 
            this.lblstdAlk_L.AutoSize = true;
            this.lblstdAlk_L.Location = new System.Drawing.Point(272, 250);
            this.lblstdAlk_L.Name = "lblstdAlk_L";
            this.lblstdAlk_L.Size = new System.Drawing.Size(16, 17);
            this.lblstdAlk_L.TabIndex = 24;
            this.lblstdAlk_L.Text = "0";
            // 
            // lblavgAlk_D
            // 
            this.lblavgAlk_D.AutoSize = true;
            this.lblavgAlk_D.Location = new System.Drawing.Point(274, 283);
            this.lblavgAlk_D.Name = "lblavgAlk_D";
            this.lblavgAlk_D.Size = new System.Drawing.Size(16, 17);
            this.lblavgAlk_D.TabIndex = 25;
            this.lblavgAlk_D.Text = "0";
            // 
            // lblstdAlk_D
            // 
            this.lblstdAlk_D.AutoSize = true;
            this.lblstdAlk_D.Location = new System.Drawing.Point(274, 314);
            this.lblstdAlk_D.Name = "lblstdAlk_D";
            this.lblstdAlk_D.Size = new System.Drawing.Size(16, 17);
            this.lblstdAlk_D.TabIndex = 26;
            this.lblstdAlk_D.Text = "0";
            // 
            // lblavgSGot_L
            // 
            this.lblavgSGot_L.AutoSize = true;
            this.lblavgSGot_L.Location = new System.Drawing.Point(612, 79);
            this.lblavgSGot_L.Name = "lblavgSGot_L";
            this.lblavgSGot_L.Size = new System.Drawing.Size(16, 17);
            this.lblavgSGot_L.TabIndex = 27;
            this.lblavgSGot_L.Text = "0";
            // 
            // lblstdSGot_L
            // 
            this.lblstdSGot_L.AutoSize = true;
            this.lblstdSGot_L.Location = new System.Drawing.Point(615, 112);
            this.lblstdSGot_L.Name = "lblstdSGot_L";
            this.lblstdSGot_L.Size = new System.Drawing.Size(16, 17);
            this.lblstdSGot_L.TabIndex = 28;
            this.lblstdSGot_L.Text = "0";
            // 
            // lblavgSGot_D
            // 
            this.lblavgSGot_D.AutoSize = true;
            this.lblavgSGot_D.Location = new System.Drawing.Point(615, 138);
            this.lblavgSGot_D.Name = "lblavgSGot_D";
            this.lblavgSGot_D.Size = new System.Drawing.Size(16, 17);
            this.lblavgSGot_D.TabIndex = 29;
            this.lblavgSGot_D.Text = "0";
            // 
            // lblstdSGot_D
            // 
            this.lblstdSGot_D.AutoSize = true;
            this.lblstdSGot_D.Location = new System.Drawing.Point(615, 165);
            this.lblstdSGot_D.Name = "lblstdSGot_D";
            this.lblstdSGot_D.Size = new System.Drawing.Size(16, 17);
            this.lblstdSGot_D.TabIndex = 30;
            this.lblstdSGot_D.Text = "0";
            // 
            // lblavgAl_L
            // 
            this.lblavgAl_L.AutoSize = true;
            this.lblavgAl_L.Location = new System.Drawing.Point(630, 224);
            this.lblavgAl_L.Name = "lblavgAl_L";
            this.lblavgAl_L.Size = new System.Drawing.Size(16, 17);
            this.lblavgAl_L.TabIndex = 31;
            this.lblavgAl_L.Text = "0";
            // 
            // lblstdAL_L
            // 
            this.lblstdAL_L.AutoSize = true;
            this.lblstdAL_L.Location = new System.Drawing.Point(634, 250);
            this.lblstdAL_L.Name = "lblstdAL_L";
            this.lblstdAL_L.Size = new System.Drawing.Size(16, 17);
            this.lblstdAL_L.TabIndex = 32;
            this.lblstdAL_L.Text = "0";
            // 
            // lblavgAL_D
            // 
            this.lblavgAL_D.AutoSize = true;
            this.lblavgAL_D.Location = new System.Drawing.Point(633, 284);
            this.lblavgAL_D.Name = "lblavgAL_D";
            this.lblavgAL_D.Size = new System.Drawing.Size(16, 17);
            this.lblavgAL_D.TabIndex = 33;
            this.lblavgAL_D.Text = "0";
            // 
            // lblstdAL_D
            // 
            this.lblstdAL_D.AutoSize = true;
            this.lblstdAL_D.Location = new System.Drawing.Point(636, 318);
            this.lblstdAL_D.Name = "lblstdAL_D";
            this.lblstdAL_D.Size = new System.Drawing.Size(16, 17);
            this.lblstdAL_D.TabIndex = 34;
            this.lblstdAL_D.Text = "0";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblstdAL_D);
            this.Controls.Add(this.lblavgAL_D);
            this.Controls.Add(this.lblstdAL_L);
            this.Controls.Add(this.lblavgAl_L);
            this.Controls.Add(this.lblstdSGot_D);
            this.Controls.Add(this.lblavgSGot_D);
            this.Controls.Add(this.lblstdSGot_L);
            this.Controls.Add(this.lblavgSGot_L);
            this.Controls.Add(this.lblstdAlk_D);
            this.Controls.Add(this.lblavgAlk_D);
            this.Controls.Add(this.lblstdAlk_L);
            this.Controls.Add(this.lblavgAlk_L);
            this.Controls.Add(this.lblstdBill_D);
            this.Controls.Add(this.lblavgBil_D);
            this.Controls.Add(this.lblstdBill_L);
            this.Controls.Add(this.lblavgBil_L);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl78);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl66);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnalyze);
            this.Controls.Add(this.medicalRecordsBindingNavigator);
            this.Name = "frmMain";
            this.Text = "Analyzer";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicalRecordsBindingNavigator)).EndInit();
            this.medicalRecordsBindingNavigator.ResumeLayout(false);
            this.medicalRecordsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MedicalRecordsDataSet medicalRecordsDataSet;
        private System.Windows.Forms.BindingSource medicalRecordsBindingSource;
        private MedicalRecordsDataSetTableAdapters.MedicalRecordsTableAdapter medicalRecordsTableAdapter;
        private MedicalRecordsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator medicalRecordsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton medicalRecordsBindingNavigatorSaveItem;
        private System.Windows.Forms.Button btnAnalyze;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl66;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl78;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblavgBil_L;
        private System.Windows.Forms.Label lblstdBill_L;
        private System.Windows.Forms.Label lblavgBil_D;
        private System.Windows.Forms.Label lblstdBill_D;
        private System.Windows.Forms.Label lblavgAlk_L;
        private System.Windows.Forms.Label lblstdAlk_L;
        private System.Windows.Forms.Label lblavgAlk_D;
        private System.Windows.Forms.Label lblstdAlk_D;
        private System.Windows.Forms.Label lblavgSGot_L;
        private System.Windows.Forms.Label lblstdSGot_L;
        private System.Windows.Forms.Label lblavgSGot_D;
        private System.Windows.Forms.Label lblstdSGot_D;
        private System.Windows.Forms.Label lblavgAl_L;
        private System.Windows.Forms.Label lblstdAL_L;
        private System.Windows.Forms.Label lblavgAL_D;
        private System.Windows.Forms.Label lblstdAL_D;
    }
}

