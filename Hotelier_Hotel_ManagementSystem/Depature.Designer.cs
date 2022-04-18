
namespace Hotelier_Hotel_ManagementSystem
{
    partial class Depature
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Depature));
            this.DepatureDataGrid = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkoutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acompanyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adultsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.childrenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inhouseguestsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inhouseguest = new Hotelier_Hotel_ManagementSystem.inhouseguest();
            this.inhouseguestsTableAdapter = new Hotelier_Hotel_ManagementSystem.inhouseguestTableAdapters.inhouseguestsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label19 = new System.Windows.Forms.Label();
            this.TotalInhouseLB = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TotalChildrenLB = new System.Windows.Forms.Label();
            this.TotalAdultLB = new System.Windows.Forms.Label();
            this.errorLB = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.TitleTB = new System.Windows.Forms.TextBox();
            this.CheckOutDTP = new System.Windows.Forms.DateTimePicker();
            this.CheckINDTP = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.ChildrenTB = new System.Windows.Forms.TextBox();
            this.AdultsTB = new System.Windows.Forms.TextBox();
            this.AcompanyTB = new System.Windows.Forms.TextBox();
            this.DurationTB = new System.Windows.Forms.TextBox();
            this.RoomTypeTB = new System.Windows.Forms.TextBox();
            this.RoomNoTB = new System.Windows.Forms.TextBox();
            this.LnameTB = new System.Windows.Forms.TextBox();
            this.FnameTB = new System.Windows.Forms.TextBox();
            this.IdTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DepatureDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inhouseguestsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inhouseguest)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DepatureDataGrid
            // 
            this.DepatureDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DepatureDataGrid.AutoGenerateColumns = false;
            this.DepatureDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DepatureDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.DepatureDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DepatureDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.roomnoDataGridViewTextBoxColumn,
            this.roomtypeDataGridViewTextBoxColumn,
            this.checkinDataGridViewTextBoxColumn,
            this.checkoutDataGridViewTextBoxColumn,
            this.durationDataGridViewTextBoxColumn,
            this.acompanyDataGridViewTextBoxColumn,
            this.adultsDataGridViewTextBoxColumn,
            this.childrenDataGridViewTextBoxColumn});
            this.DepatureDataGrid.DataSource = this.inhouseguestsBindingSource;
            this.DepatureDataGrid.Location = new System.Drawing.Point(0, 218);
            this.DepatureDataGrid.Name = "DepatureDataGrid";
            this.DepatureDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DepatureDataGrid.Size = new System.Drawing.Size(1184, 273);
            this.DepatureDataGrid.TabIndex = 0;
            this.DepatureDataGrid.Click += new System.EventHandler(this.DepatureDataGrid_Click);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.FillWeight = 60F;
            this.idDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "title";
            this.titleDataGridViewTextBoxColumn.FillWeight = 40F;
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "firstname";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "First Name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Last Name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // roomnoDataGridViewTextBoxColumn
            // 
            this.roomnoDataGridViewTextBoxColumn.DataPropertyName = "roomno";
            this.roomnoDataGridViewTextBoxColumn.FillWeight = 60F;
            this.roomnoDataGridViewTextBoxColumn.HeaderText = "Room No";
            this.roomnoDataGridViewTextBoxColumn.Name = "roomnoDataGridViewTextBoxColumn";
            // 
            // roomtypeDataGridViewTextBoxColumn
            // 
            this.roomtypeDataGridViewTextBoxColumn.DataPropertyName = "roomtype";
            this.roomtypeDataGridViewTextBoxColumn.HeaderText = "Room Type";
            this.roomtypeDataGridViewTextBoxColumn.Name = "roomtypeDataGridViewTextBoxColumn";
            // 
            // checkinDataGridViewTextBoxColumn
            // 
            this.checkinDataGridViewTextBoxColumn.DataPropertyName = "checkin";
            this.checkinDataGridViewTextBoxColumn.HeaderText = "Check In ";
            this.checkinDataGridViewTextBoxColumn.Name = "checkinDataGridViewTextBoxColumn";
            // 
            // checkoutDataGridViewTextBoxColumn
            // 
            this.checkoutDataGridViewTextBoxColumn.DataPropertyName = "checkout";
            this.checkoutDataGridViewTextBoxColumn.HeaderText = "Check Out";
            this.checkoutDataGridViewTextBoxColumn.Name = "checkoutDataGridViewTextBoxColumn";
            // 
            // durationDataGridViewTextBoxColumn
            // 
            this.durationDataGridViewTextBoxColumn.DataPropertyName = "duration";
            this.durationDataGridViewTextBoxColumn.HeaderText = "Duration";
            this.durationDataGridViewTextBoxColumn.Name = "durationDataGridViewTextBoxColumn";
            // 
            // acompanyDataGridViewTextBoxColumn
            // 
            this.acompanyDataGridViewTextBoxColumn.DataPropertyName = "acompany";
            this.acompanyDataGridViewTextBoxColumn.HeaderText = "Acompany";
            this.acompanyDataGridViewTextBoxColumn.Name = "acompanyDataGridViewTextBoxColumn";
            // 
            // adultsDataGridViewTextBoxColumn
            // 
            this.adultsDataGridViewTextBoxColumn.DataPropertyName = "adults";
            this.adultsDataGridViewTextBoxColumn.FillWeight = 50F;
            this.adultsDataGridViewTextBoxColumn.HeaderText = "Adults";
            this.adultsDataGridViewTextBoxColumn.Name = "adultsDataGridViewTextBoxColumn";
            // 
            // childrenDataGridViewTextBoxColumn
            // 
            this.childrenDataGridViewTextBoxColumn.DataPropertyName = "children";
            this.childrenDataGridViewTextBoxColumn.FillWeight = 50F;
            this.childrenDataGridViewTextBoxColumn.HeaderText = "Children";
            this.childrenDataGridViewTextBoxColumn.Name = "childrenDataGridViewTextBoxColumn";
            // 
            // inhouseguestsBindingSource
            // 
            this.inhouseguestsBindingSource.DataMember = "inhouseguests";
            this.inhouseguestsBindingSource.DataSource = this.inhouseguest;
            // 
            // inhouseguest
            // 
            this.inhouseguest.DataSetName = "inhouseguest";
            this.inhouseguest.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inhouseguestsTableAdapter
            // 
            this.inhouseguestsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Aquamarine;
            this.panel1.Controls.Add(this.UpdateBtn);
            this.panel1.Controls.Add(this.EditBtn);
            this.panel1.Controls.Add(this.ClearBtn);
            this.panel1.Controls.Add(this.DeleteBtn);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.errorLB);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.TitleTB);
            this.panel1.Controls.Add(this.CheckOutDTP);
            this.panel1.Controls.Add(this.CheckINDTP);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.ChildrenTB);
            this.panel1.Controls.Add(this.AdultsTB);
            this.panel1.Controls.Add(this.AcompanyTB);
            this.panel1.Controls.Add(this.DurationTB);
            this.panel1.Controls.Add(this.RoomTypeTB);
            this.panel1.Controls.Add(this.RoomNoTB);
            this.panel1.Controls.Add(this.LnameTB);
            this.panel1.Controls.Add(this.FnameTB);
            this.panel1.Controls.Add(this.IdTB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 229);
            this.panel1.TabIndex = 26;
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UpdateBtn.Location = new System.Drawing.Point(1072, 144);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(100, 23);
            this.UpdateBtn.TabIndex = 74;
            this.UpdateBtn.Text = "SAVE CHANGES";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EditBtn.Location = new System.Drawing.Point(1097, 115);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 73;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ClearBtn.Location = new System.Drawing.Point(1097, 86);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 72;
            this.ClearBtn.Text = "CLEAR";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteBtn.Location = new System.Drawing.Point(1097, 57);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 71;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "MR",
            "MRS",
            "MISS"});
            this.comboBox1.Location = new System.Drawing.Point(204, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(58, 21);
            this.comboBox1.TabIndex = 70;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(991, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 69;
            this.button1.Text = "REFRESH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.DarkGreen;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.TotalInhouseLB);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.TotalChildrenLB);
            this.panel2.Controls.Add(this.TotalAdultLB);
            this.panel2.Location = new System.Drawing.Point(312, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(860, 39);
            this.panel2.TabIndex = 68;
            // 
            // label19
            // 
            this.label19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(236, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(135, 16);
            this.label19.TabIndex = 36;
            this.label19.Text = "Total Dep.People:";
            // 
            // TotalInhouseLB
            // 
            this.TotalInhouseLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalInhouseLB.AutoSize = true;
            this.TotalInhouseLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalInhouseLB.ForeColor = System.Drawing.Color.White;
            this.TotalInhouseLB.Location = new System.Drawing.Point(365, 9);
            this.TotalInhouseLB.Name = "TotalInhouseLB";
            this.TotalInhouseLB.Size = new System.Drawing.Size(89, 25);
            this.TotalInhouseLB.TabIndex = 37;
            this.TotalInhouseLB.Text = "label20";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(142, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 29);
            this.label14.TabIndex = 31;
            this.label14.Text = "label14";
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(454, 13);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 16);
            this.label15.TabIndex = 33;
            this.label15.Text = "Total Adults:";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(18, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 16);
            this.label13.TabIndex = 30;
            this.label13.Text = "Total Depatures";
            // 
            // label17
            // 
            this.label17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(638, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(109, 16);
            this.label17.TabIndex = 33;
            this.label17.Text = "Total Children:";
            // 
            // TotalChildrenLB
            // 
            this.TotalChildrenLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalChildrenLB.AutoSize = true;
            this.TotalChildrenLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalChildrenLB.ForeColor = System.Drawing.Color.White;
            this.TotalChildrenLB.Location = new System.Drawing.Point(747, 9);
            this.TotalChildrenLB.Name = "TotalChildrenLB";
            this.TotalChildrenLB.Size = new System.Drawing.Size(89, 25);
            this.TotalChildrenLB.TabIndex = 35;
            this.TotalChildrenLB.Text = "label18";
            // 
            // TotalAdultLB
            // 
            this.TotalAdultLB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TotalAdultLB.AutoSize = true;
            this.TotalAdultLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAdultLB.ForeColor = System.Drawing.Color.White;
            this.TotalAdultLB.Location = new System.Drawing.Point(549, 9);
            this.TotalAdultLB.Name = "TotalAdultLB";
            this.TotalAdultLB.Size = new System.Drawing.Size(89, 25);
            this.TotalAdultLB.TabIndex = 34;
            this.TotalAdultLB.Text = "label16";
            // 
            // errorLB
            // 
            this.errorLB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.errorLB.AutoSize = true;
            this.errorLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLB.ForeColor = System.Drawing.Color.Red;
            this.errorLB.Location = new System.Drawing.Point(759, 14);
            this.errorLB.Name = "errorLB";
            this.errorLB.Size = new System.Drawing.Size(59, 16);
            this.errorLB.TabIndex = 67;
            this.errorLB.Text = "label15";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 190);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(303, 20);
            this.textBox1.TabIndex = 65;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TitleTB
            // 
            this.TitleTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TitleTB.Location = new System.Drawing.Point(204, 32);
            this.TitleTB.Name = "TitleTB";
            this.TitleTB.Size = new System.Drawing.Size(58, 20);
            this.TitleTB.TabIndex = 64;
            // 
            // CheckOutDTP
            // 
            this.CheckOutDTP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckOutDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CheckOutDTP.Location = new System.Drawing.Point(272, 83);
            this.CheckOutDTP.Name = "CheckOutDTP";
            this.CheckOutDTP.Size = new System.Drawing.Size(97, 20);
            this.CheckOutDTP.TabIndex = 63;
            this.CheckOutDTP.ValueChanged += new System.EventHandler(this.CheckOutDTP_ValueChanged_1);
            // 
            // CheckINDTP
            // 
            this.CheckINDTP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.CheckINDTP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CheckINDTP.Location = new System.Drawing.Point(85, 83);
            this.CheckINDTP.Name = "CheckINDTP";
            this.CheckINDTP.Size = new System.Drawing.Size(97, 20);
            this.CheckINDTP.TabIndex = 62;
            this.CheckINDTP.ValueChanged += new System.EventHandler(this.CheckINDTP_ValueChanged_1);
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(190, 136);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 15);
            this.label11.TabIndex = 61;
            this.label11.Text = "Children";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 136);
            this.label10.Name = "label10";
            this.label10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label10.Size = new System.Drawing.Size(46, 15);
            this.label10.TabIndex = 60;
            this.label10.Text = "Adults";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(582, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 15);
            this.label9.TabIndex = 59;
            this.label9.Text = "Acompany";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 15);
            this.label8.TabIndex = 58;
            this.label8.Text = "Check IN";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(191, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 57;
            this.label7.Text = "Check Out";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 56;
            this.label6.Text = "Duration";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(870, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 55;
            this.label5.Text = "Room Type";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(675, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 15);
            this.label4.TabIndex = 54;
            this.label4.Text = "Room No.";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(475, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 53;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 15);
            this.label2.TabIndex = 52;
            this.label2.Text = "First Name";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(157, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 15);
            this.label12.TabIndex = 51;
            this.label12.Text = "Title";
            // 
            // label16
            // 
            this.label16.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 15);
            this.label16.TabIndex = 50;
            this.label16.Text = "ID";
            // 
            // ChildrenTB
            // 
            this.ChildrenTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.ChildrenTB.Location = new System.Drawing.Point(267, 133);
            this.ChildrenTB.Name = "ChildrenTB";
            this.ChildrenTB.Size = new System.Drawing.Size(100, 20);
            this.ChildrenTB.TabIndex = 49;
            this.ChildrenTB.Text = "0";
            // 
            // AdultsTB
            // 
            this.AdultsTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AdultsTB.Location = new System.Drawing.Point(74, 133);
            this.AdultsTB.Name = "AdultsTB";
            this.AdultsTB.Size = new System.Drawing.Size(100, 20);
            this.AdultsTB.TabIndex = 48;
            this.AdultsTB.Text = "0";
            // 
            // AcompanyTB
            // 
            this.AcompanyTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AcompanyTB.Location = new System.Drawing.Point(669, 83);
            this.AcompanyTB.Multiline = true;
            this.AcompanyTB.Name = "AcompanyTB";
            this.AcompanyTB.Size = new System.Drawing.Size(303, 68);
            this.AcompanyTB.TabIndex = 47;
            // 
            // DurationTB
            // 
            this.DurationTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.DurationTB.Location = new System.Drawing.Point(466, 83);
            this.DurationTB.Name = "DurationTB";
            this.DurationTB.Size = new System.Drawing.Size(100, 20);
            this.DurationTB.TabIndex = 46;
            this.DurationTB.Text = "0";
            // 
            // RoomTypeTB
            // 
            this.RoomTypeTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RoomTypeTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.RoomTypeTB.Location = new System.Drawing.Point(961, 32);
            this.RoomTypeTB.Name = "RoomTypeTB";
            this.RoomTypeTB.Size = new System.Drawing.Size(100, 20);
            this.RoomTypeTB.TabIndex = 45;
            // 
            // RoomNoTB
            // 
            this.RoomNoTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.RoomNoTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.RoomNoTB.Location = new System.Drawing.Point(758, 32);
            this.RoomNoTB.Name = "RoomNoTB";
            this.RoomNoTB.Size = new System.Drawing.Size(100, 20);
            this.RoomNoTB.TabIndex = 44;
            this.RoomNoTB.TextChanged += new System.EventHandler(this.RoomNoTB_TextChanged);
            // 
            // LnameTB
            // 
            this.LnameTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LnameTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.LnameTB.Location = new System.Drawing.Point(563, 32);
            this.LnameTB.Name = "LnameTB";
            this.LnameTB.Size = new System.Drawing.Size(100, 20);
            this.LnameTB.TabIndex = 43;
            // 
            // FnameTB
            // 
            this.FnameTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.FnameTB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.FnameTB.Location = new System.Drawing.Point(363, 32);
            this.FnameTB.Name = "FnameTB";
            this.FnameTB.Size = new System.Drawing.Size(100, 20);
            this.FnameTB.TabIndex = 42;
            // 
            // IdTB
            // 
            this.IdTB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.IdTB.Location = new System.Drawing.Point(45, 32);
            this.IdTB.Name = "IdTB";
            this.IdTB.Size = new System.Drawing.Size(100, 20);
            this.IdTB.TabIndex = 41;
            this.IdTB.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(385, 376);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 37);
            this.label1.TabIndex = 27;
            this.label1.Text = "label1";
            // 
            // Depature
            // 
            this.AcceptButton = this.UpdateBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 491);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DepatureDataGrid);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "Depature";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Depature";
            this.Load += new System.EventHandler(this.Depature_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DepatureDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inhouseguestsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inhouseguest)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DepatureDataGrid;
        private inhouseguest inhouseguest;
        private System.Windows.Forms.BindingSource inhouseguestsBindingSource;
        private inhouseguestTableAdapters.inhouseguestsTableAdapter inhouseguestsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkoutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn acompanyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adultsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn childrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label TotalInhouseLB;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label TotalChildrenLB;
        private System.Windows.Forms.Label TotalAdultLB;
        private System.Windows.Forms.Label errorLB;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox TitleTB;
        private System.Windows.Forms.DateTimePicker CheckOutDTP;
        private System.Windows.Forms.DateTimePicker CheckINDTP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ChildrenTB;
        private System.Windows.Forms.TextBox AdultsTB;
        private System.Windows.Forms.TextBox AcompanyTB;
        private System.Windows.Forms.TextBox DurationTB;
        private System.Windows.Forms.TextBox RoomTypeTB;
        private System.Windows.Forms.TextBox RoomNoTB;
        private System.Windows.Forms.TextBox LnameTB;
        private System.Windows.Forms.TextBox FnameTB;
        private System.Windows.Forms.TextBox IdTB;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}