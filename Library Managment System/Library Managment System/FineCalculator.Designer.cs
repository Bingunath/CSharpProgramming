
namespace Library_Managment_System
{
    partial class FineCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FineCalculator));
            this.DisplayTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DelayDaysTB = new System.Windows.Forms.TextBox();
            this.CalculatorPanel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.Finepanel1 = new System.Windows.Forms.Panel();
            this.BookListCB = new System.Windows.Forms.ComboBox();
            this.MemberListCB = new System.Windows.Forms.ComboBox();
            this.UserIDList = new System.Windows.Forms.ComboBox();
            this.ClearAllBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.CollectorID = new System.Windows.Forms.TextBox();
            this.BalanceTB = new System.Windows.Forms.TextBox();
            this.CashTB = new System.Windows.Forms.TextBox();
            this.Fine2TB = new System.Windows.Forms.TextBox();
            this.ReturnedDateTB = new System.Windows.Forms.TextBox();
            this.ReturnDateTB = new System.Windows.Forms.TextBox();
            this.BookNameTB = new System.Windows.Forms.TextBox();
            this.BookIDTB = new System.Windows.Forms.TextBox();
            this.DelayedDaysTB2 = new System.Windows.Forms.TextBox();
            this.MemberNameTB = new System.Windows.Forms.TextBox();
            this.MemberTB = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.FineGridView = new System.Windows.Forms.DataGridView();
            this.memberIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.memberNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnedDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delayedDaysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.balanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collectedUserIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fines = new Library_Managment_System.fines();
            this.DeleteBoxTB = new System.Windows.Forms.TextBox();
            this.finesTableAdapter = new Library_Managment_System.finesTableAdapters.finesTableAdapter();
            this.CalculatorPanel1.SuspendLayout();
            this.Finepanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FineGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fines)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayTB
            // 
            this.DisplayTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DisplayTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DisplayTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayTB.Location = new System.Drawing.Point(69, 51);
            this.DisplayTB.Multiline = true;
            this.DisplayTB.Name = "DisplayTB";
            this.DisplayTB.Size = new System.Drawing.Size(219, 50);
            this.DisplayTB.TabIndex = 0;
            this.DisplayTB.TextChanged += new System.EventHandler(this.DisplayTB_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1160, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(173, 175);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(115, 23);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(173, 141);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(115, 23);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "RETURN DATE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "RETURNED DATE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "DELAYED DAYS ";
            // 
            // DelayDaysTB
            // 
            this.DelayDaysTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelayDaysTB.Location = new System.Drawing.Point(173, 204);
            this.DelayDaysTB.Name = "DelayDaysTB";
            this.DelayDaysTB.Size = new System.Drawing.Size(96, 23);
            this.DelayDaysTB.TabIndex = 7;
            this.DelayDaysTB.TextChanged += new System.EventHandler(this.DelayDaysTB_TextChanged);
            // 
            // CalculatorPanel1
            // 
            this.CalculatorPanel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.CalculatorPanel1.Controls.Add(this.DelayDaysTB);
            this.CalculatorPanel1.Controls.Add(this.DisplayTB);
            this.CalculatorPanel1.Controls.Add(this.label3);
            this.CalculatorPanel1.Controls.Add(this.dateTimePicker1);
            this.CalculatorPanel1.Controls.Add(this.label2);
            this.CalculatorPanel1.Controls.Add(this.dateTimePicker2);
            this.CalculatorPanel1.Controls.Add(this.label15);
            this.CalculatorPanel1.Controls.Add(this.label1);
            this.CalculatorPanel1.Location = new System.Drawing.Point(12, 12);
            this.CalculatorPanel1.Name = "CalculatorPanel1";
            this.CalculatorPanel1.Size = new System.Drawing.Size(312, 279);
            this.CalculatorPanel1.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(9, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 39);
            this.label15.TabIndex = 4;
            this.label15.Text = "Rs.";
            // 
            // Finepanel1
            // 
            this.Finepanel1.BackColor = System.Drawing.Color.GreenYellow;
            this.Finepanel1.Controls.Add(this.BookListCB);
            this.Finepanel1.Controls.Add(this.MemberListCB);
            this.Finepanel1.Controls.Add(this.UserIDList);
            this.Finepanel1.Controls.Add(this.ClearAllBtn);
            this.Finepanel1.Controls.Add(this.SaveBtn);
            this.Finepanel1.Controls.Add(this.CollectorID);
            this.Finepanel1.Controls.Add(this.BalanceTB);
            this.Finepanel1.Controls.Add(this.CashTB);
            this.Finepanel1.Controls.Add(this.Fine2TB);
            this.Finepanel1.Controls.Add(this.ReturnedDateTB);
            this.Finepanel1.Controls.Add(this.ReturnDateTB);
            this.Finepanel1.Controls.Add(this.BookNameTB);
            this.Finepanel1.Controls.Add(this.BookIDTB);
            this.Finepanel1.Controls.Add(this.DelayedDaysTB2);
            this.Finepanel1.Controls.Add(this.MemberNameTB);
            this.Finepanel1.Controls.Add(this.MemberTB);
            this.Finepanel1.Controls.Add(this.label12);
            this.Finepanel1.Controls.Add(this.label14);
            this.Finepanel1.Controls.Add(this.label11);
            this.Finepanel1.Controls.Add(this.label10);
            this.Finepanel1.Controls.Add(this.label13);
            this.Finepanel1.Controls.Add(this.label9);
            this.Finepanel1.Controls.Add(this.label8);
            this.Finepanel1.Controls.Add(this.label7);
            this.Finepanel1.Controls.Add(this.label6);
            this.Finepanel1.Controls.Add(this.label5);
            this.Finepanel1.Controls.Add(this.label4);
            this.Finepanel1.Location = new System.Drawing.Point(345, 12);
            this.Finepanel1.Name = "Finepanel1";
            this.Finepanel1.Size = new System.Drawing.Size(545, 279);
            this.Finepanel1.TabIndex = 9;
            // 
            // BookListCB
            // 
            this.BookListCB.FormattingEnabled = true;
            this.BookListCB.Location = new System.Drawing.Point(239, 66);
            this.BookListCB.Name = "BookListCB";
            this.BookListCB.Size = new System.Drawing.Size(93, 21);
            this.BookListCB.TabIndex = 24;
            this.BookListCB.SelectedIndexChanged += new System.EventHandler(this.BookListCB_SelectedIndexChanged);
            // 
            // MemberListCB
            // 
            this.MemberListCB.FormattingEnabled = true;
            this.MemberListCB.Location = new System.Drawing.Point(239, 4);
            this.MemberListCB.Name = "MemberListCB";
            this.MemberListCB.Size = new System.Drawing.Size(93, 21);
            this.MemberListCB.TabIndex = 23;
            this.MemberListCB.SelectedIndexChanged += new System.EventHandler(this.MemberListCB_SelectedIndexChanged);
            // 
            // UserIDList
            // 
            this.UserIDList.DropDownHeight = 150;
            this.UserIDList.FormattingEnabled = true;
            this.UserIDList.IntegralHeight = false;
            this.UserIDList.ItemHeight = 13;
            this.UserIDList.Items.AddRange(new object[] {
            ""});
            this.UserIDList.Location = new System.Drawing.Point(448, 215);
            this.UserIDList.Name = "UserIDList";
            this.UserIDList.Size = new System.Drawing.Size(75, 21);
            this.UserIDList.TabIndex = 22;
            this.UserIDList.SelectedIndexChanged += new System.EventHandler(this.UserIDList_SelectedIndexChanged);
            // 
            // ClearAllBtn
            // 
            this.ClearAllBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.ClearAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearAllBtn.Location = new System.Drawing.Point(457, 36);
            this.ClearAllBtn.Name = "ClearAllBtn";
            this.ClearAllBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearAllBtn.TabIndex = 21;
            this.ClearAllBtn.Text = "CLEAR ALL";
            this.ClearAllBtn.UseVisualStyleBackColor = true;
            this.ClearAllBtn.Click += new System.EventHandler(this.ClearAllBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.SaveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveBtn.Location = new System.Drawing.Point(457, 6);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 20;
            this.SaveBtn.Text = "SAVE";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // CollectorID
            // 
            this.CollectorID.Location = new System.Drawing.Point(376, 216);
            this.CollectorID.Name = "CollectorID";
            this.CollectorID.Size = new System.Drawing.Size(66, 20);
            this.CollectorID.TabIndex = 19;
            // 
            // BalanceTB
            // 
            this.BalanceTB.Location = new System.Drawing.Point(132, 241);
            this.BalanceTB.Name = "BalanceTB";
            this.BalanceTB.Size = new System.Drawing.Size(100, 20);
            this.BalanceTB.TabIndex = 18;
            // 
            // CashTB
            // 
            this.CashTB.Location = new System.Drawing.Point(132, 211);
            this.CashTB.Name = "CashTB";
            this.CashTB.Size = new System.Drawing.Size(100, 20);
            this.CashTB.TabIndex = 17;
            this.CashTB.TextChanged += new System.EventHandler(this.CashTB_TextChanged);
            // 
            // Fine2TB
            // 
            this.Fine2TB.Location = new System.Drawing.Point(132, 181);
            this.Fine2TB.Name = "Fine2TB";
            this.Fine2TB.Size = new System.Drawing.Size(100, 20);
            this.Fine2TB.TabIndex = 16;
            // 
            // ReturnedDateTB
            // 
            this.ReturnedDateTB.Location = new System.Drawing.Point(132, 151);
            this.ReturnedDateTB.Name = "ReturnedDateTB";
            this.ReturnedDateTB.Size = new System.Drawing.Size(100, 20);
            this.ReturnedDateTB.TabIndex = 15;
            // 
            // ReturnDateTB
            // 
            this.ReturnDateTB.Location = new System.Drawing.Point(132, 121);
            this.ReturnDateTB.Name = "ReturnDateTB";
            this.ReturnDateTB.Size = new System.Drawing.Size(100, 20);
            this.ReturnDateTB.TabIndex = 14;
            // 
            // BookNameTB
            // 
            this.BookNameTB.Location = new System.Drawing.Point(132, 91);
            this.BookNameTB.Name = "BookNameTB";
            this.BookNameTB.Size = new System.Drawing.Size(100, 20);
            this.BookNameTB.TabIndex = 13;
            // 
            // BookIDTB
            // 
            this.BookIDTB.Location = new System.Drawing.Point(132, 62);
            this.BookIDTB.Name = "BookIDTB";
            this.BookIDTB.Size = new System.Drawing.Size(100, 20);
            this.BookIDTB.TabIndex = 12;
            this.BookIDTB.TextChanged += new System.EventHandler(this.BookIDTB_TextChanged);
            // 
            // DelayedDaysTB2
            // 
            this.DelayedDaysTB2.Location = new System.Drawing.Point(376, 151);
            this.DelayedDaysTB2.Name = "DelayedDaysTB2";
            this.DelayedDaysTB2.Size = new System.Drawing.Size(66, 20);
            this.DelayedDaysTB2.TabIndex = 11;
            // 
            // MemberNameTB
            // 
            this.MemberNameTB.Location = new System.Drawing.Point(132, 36);
            this.MemberNameTB.Name = "MemberNameTB";
            this.MemberNameTB.Size = new System.Drawing.Size(100, 20);
            this.MemberNameTB.TabIndex = 10;
            this.MemberNameTB.TextChanged += new System.EventHandler(this.MemberNameTB_TextChanged);
            // 
            // MemberTB
            // 
            this.MemberTB.Location = new System.Drawing.Point(132, 6);
            this.MemberTB.Name = "MemberTB";
            this.MemberTB.Size = new System.Drawing.Size(100, 20);
            this.MemberTB.TabIndex = 9;
            this.MemberTB.TextChanged += new System.EventHandler(this.MemberTB_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 15);
            this.label12.TabIndex = 8;
            this.label12.Text = "Balance(Rs.)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 216);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 15);
            this.label14.TabIndex = 7;
            this.label14.Text = "Cash(Rs.)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(238, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 15);
            this.label11.TabIndex = 7;
            this.label11.Text = "Collected User";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 15);
            this.label10.TabIndex = 6;
            this.label10.Text = "Fine(Rs.)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(238, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 15);
            this.label13.TabIndex = 5;
            this.label13.Text = "Delayed Days";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(17, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 15);
            this.label9.TabIndex = 5;
            this.label9.Text = "Returned Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 15);
            this.label8.TabIndex = 4;
            this.label8.Text = "Return Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Book Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 15);
            this.label6.TabIndex = 2;
            this.label6.Text = "Book ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Member Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Member ID";
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Location = new System.Drawing.Point(1091, 278);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 22;
            this.DeleteBtn.Text = "DELETE ";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // FineGridView
            // 
            this.FineGridView.AutoGenerateColumns = false;
            this.FineGridView.BackgroundColor = System.Drawing.Color.White;
            this.FineGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FineGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.memberIDDataGridViewTextBoxColumn,
            this.memberNameDataGridViewTextBoxColumn,
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn,
            this.returnedDateDataGridViewTextBoxColumn,
            this.delayedDaysDataGridViewTextBoxColumn,
            this.finesDataGridViewTextBoxColumn,
            this.cashDataGridViewTextBoxColumn,
            this.balanceDataGridViewTextBoxColumn,
            this.collectedUserIDDataGridViewTextBoxColumn});
            this.FineGridView.DataSource = this.finesBindingSource;
            this.FineGridView.Location = new System.Drawing.Point(12, 307);
            this.FineGridView.Name = "FineGridView";
            this.FineGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FineGridView.Size = new System.Drawing.Size(1154, 183);
            this.FineGridView.TabIndex = 10;
            this.FineGridView.Click += new System.EventHandler(this.FineGridView_Click);
            // 
            // memberIDDataGridViewTextBoxColumn
            // 
            this.memberIDDataGridViewTextBoxColumn.DataPropertyName = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.HeaderText = "MemberID";
            this.memberIDDataGridViewTextBoxColumn.Name = "memberIDDataGridViewTextBoxColumn";
            // 
            // memberNameDataGridViewTextBoxColumn
            // 
            this.memberNameDataGridViewTextBoxColumn.DataPropertyName = "MemberName";
            this.memberNameDataGridViewTextBoxColumn.HeaderText = "MemberName";
            this.memberNameDataGridViewTextBoxColumn.Name = "memberNameDataGridViewTextBoxColumn";
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            // 
            // returnedDateDataGridViewTextBoxColumn
            // 
            this.returnedDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnedDate";
            this.returnedDateDataGridViewTextBoxColumn.HeaderText = "ReturnedDate";
            this.returnedDateDataGridViewTextBoxColumn.Name = "returnedDateDataGridViewTextBoxColumn";
            // 
            // delayedDaysDataGridViewTextBoxColumn
            // 
            this.delayedDaysDataGridViewTextBoxColumn.DataPropertyName = "DelayedDays";
            this.delayedDaysDataGridViewTextBoxColumn.HeaderText = "DelayedDays";
            this.delayedDaysDataGridViewTextBoxColumn.Name = "delayedDaysDataGridViewTextBoxColumn";
            // 
            // finesDataGridViewTextBoxColumn
            // 
            this.finesDataGridViewTextBoxColumn.DataPropertyName = "Fines";
            this.finesDataGridViewTextBoxColumn.HeaderText = "Fines(RS.)";
            this.finesDataGridViewTextBoxColumn.Name = "finesDataGridViewTextBoxColumn";
            // 
            // cashDataGridViewTextBoxColumn
            // 
            this.cashDataGridViewTextBoxColumn.DataPropertyName = "Cash";
            this.cashDataGridViewTextBoxColumn.HeaderText = "Cash(RS.)";
            this.cashDataGridViewTextBoxColumn.Name = "cashDataGridViewTextBoxColumn";
            // 
            // balanceDataGridViewTextBoxColumn
            // 
            this.balanceDataGridViewTextBoxColumn.DataPropertyName = "Balance";
            this.balanceDataGridViewTextBoxColumn.HeaderText = "Balance(RS.)";
            this.balanceDataGridViewTextBoxColumn.Name = "balanceDataGridViewTextBoxColumn";
            // 
            // collectedUserIDDataGridViewTextBoxColumn
            // 
            this.collectedUserIDDataGridViewTextBoxColumn.DataPropertyName = "Collected_UserID";
            this.collectedUserIDDataGridViewTextBoxColumn.HeaderText = "Collected_UserID";
            this.collectedUserIDDataGridViewTextBoxColumn.Name = "collectedUserIDDataGridViewTextBoxColumn";
            // 
            // finesBindingSource
            // 
            this.finesBindingSource.DataMember = "fines";
            this.finesBindingSource.DataSource = this.fines;
            // 
            // fines
            // 
            this.fines.DataSetName = "fines";
            this.fines.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DeleteBoxTB
            // 
            this.DeleteBoxTB.Location = new System.Drawing.Point(985, 280);
            this.DeleteBoxTB.Name = "DeleteBoxTB";
            this.DeleteBoxTB.Size = new System.Drawing.Size(100, 20);
            this.DeleteBoxTB.TabIndex = 23;
            // 
            // finesTableAdapter
            // 
            this.finesTableAdapter.ClearBeforeFill = true;
            // 
            // FineCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1186, 482);
            this.ControlBox = false;
            this.Controls.Add(this.DeleteBoxTB);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.FineGridView);
            this.Controls.Add(this.Finepanel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CalculatorPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FineCalculator";
            this.ShowIcon = false;
            this.Text = "FineCalculator";
            this.Load += new System.EventHandler(this.FineCalculator_Load);
            this.CalculatorPanel1.ResumeLayout(false);
            this.CalculatorPanel1.PerformLayout();
            this.Finepanel1.ResumeLayout(false);
            this.Finepanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FineGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox DisplayTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox DelayDaysTB;
        private System.Windows.Forms.Panel CalculatorPanel1;
        private System.Windows.Forms.Panel Finepanel1;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ClearAllBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.TextBox CollectorID;
        private System.Windows.Forms.TextBox BalanceTB;
        private System.Windows.Forms.TextBox CashTB;
        private System.Windows.Forms.TextBox Fine2TB;
        private System.Windows.Forms.TextBox ReturnedDateTB;
        private System.Windows.Forms.TextBox ReturnDateTB;
        private System.Windows.Forms.TextBox BookNameTB;
        private System.Windows.Forms.TextBox BookIDTB;
        private System.Windows.Forms.TextBox DelayedDaysTB2;
        private System.Windows.Forms.TextBox MemberNameTB;
        private System.Windows.Forms.TextBox MemberTB;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView FineGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn finesRsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashRsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceRsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox DeleteBoxTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private fines fines;
        private System.Windows.Forms.BindingSource finesBindingSource;
        private finesTableAdapters.finesTableAdapter finesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn memberNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnedDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn delayedDaysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn balanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn collectedUserIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox UserIDList;
        private System.Windows.Forms.ComboBox BookListCB;
        private System.Windows.Forms.ComboBox MemberListCB;
    }
}