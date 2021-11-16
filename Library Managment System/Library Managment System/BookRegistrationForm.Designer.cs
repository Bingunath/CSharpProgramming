
namespace Library_Managment_System
{
    partial class BookRegistration
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookRegistration));
            this.label1 = new System.Windows.Forms.Label();
            this.BookId = new System.Windows.Forms.Label();
            this.BookName = new System.Windows.Forms.Label();
            this.BookAuthour = new System.Windows.Forms.Label();
            this.PublisheDate = new System.Windows.Forms.Label();
            this.BookCategory = new System.Windows.Forms.Label();
            this.Quantity = new System.Windows.Forms.Label();
            this.BookIdTb = new System.Windows.Forms.TextBox();
            this.BookNameTb = new System.Windows.Forms.TextBox();
            this.BookauthourTb = new System.Windows.Forms.TextBox();
            this.PublishDateDtp = new System.Windows.Forms.DateTimePicker();
            this.BookcategoryCb = new System.Windows.Forms.ComboBox();
            this.QuantityCb = new System.Windows.Forms.ComboBox();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.libraryBooksDatabaseDataSet = new Library_Managment_System.LibraryBooksDatabaseDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new Library_Managment_System.LibraryBooksDatabaseDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new Library_Managment_System.LibraryBooksDatabaseDataSetTableAdapters.TableAdapterManager();
            this.tableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.libraryBooksDatabaseDataSet1 = new Library_Managment_System.LibraryBooksDatabaseDataSet();
            this.UserLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooksDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooksDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(396, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "BOOK REGISTRATION";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BookId
            // 
            this.BookId.AutoSize = true;
            this.BookId.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookId.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookId.Location = new System.Drawing.Point(664, 80);
            this.BookId.Name = "BookId";
            this.BookId.Size = new System.Drawing.Size(75, 14);
            this.BookId.TabIndex = 1;
            this.BookId.Text = "BOOK ID :";
            // 
            // BookName
            // 
            this.BookName.AutoSize = true;
            this.BookName.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookName.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookName.Location = new System.Drawing.Point(664, 123);
            this.BookName.Name = "BookName";
            this.BookName.Size = new System.Drawing.Size(102, 14);
            this.BookName.TabIndex = 2;
            this.BookName.Text = "BOOK NAME :";
            // 
            // BookAuthour
            // 
            this.BookAuthour.AutoSize = true;
            this.BookAuthour.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookAuthour.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookAuthour.Location = new System.Drawing.Point(664, 167);
            this.BookAuthour.Name = "BookAuthour";
            this.BookAuthour.Size = new System.Drawing.Size(129, 14);
            this.BookAuthour.TabIndex = 3;
            this.BookAuthour.Text = "BOOK AUTHOUR :";
            // 
            // PublisheDate
            // 
            this.PublisheDate.AutoSize = true;
            this.PublisheDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PublisheDate.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublisheDate.Location = new System.Drawing.Point(664, 214);
            this.PublisheDate.Name = "PublisheDate";
            this.PublisheDate.Size = new System.Drawing.Size(141, 14);
            this.PublisheDate.TabIndex = 4;
            this.PublisheDate.Text = "PUBLISHED DATE : ";
            // 
            // BookCategory
            // 
            this.BookCategory.AutoSize = true;
            this.BookCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BookCategory.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookCategory.Location = new System.Drawing.Point(664, 273);
            this.BookCategory.Name = "BookCategory";
            this.BookCategory.Size = new System.Drawing.Size(138, 14);
            this.BookCategory.TabIndex = 5;
            this.BookCategory.Text = "BOOK CATEGORY :";
            // 
            // Quantity
            // 
            this.Quantity.AutoSize = true;
            this.Quantity.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Quantity.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.Location = new System.Drawing.Point(664, 332);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(89, 14);
            this.Quantity.TabIndex = 6;
            this.Quantity.Text = "QUANTITY :";
            // 
            // BookIdTb
            // 
            this.BookIdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookIdTb.Location = new System.Drawing.Point(897, 74);
            this.BookIdTb.Name = "BookIdTb";
            this.BookIdTb.Size = new System.Drawing.Size(200, 23);
            this.BookIdTb.TabIndex = 7;
            this.BookIdTb.TextChanged += new System.EventHandler(this.BookIdTb_TextChanged);
            // 
            // BookNameTb
            // 
            this.BookNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookNameTb.Location = new System.Drawing.Point(897, 117);
            this.BookNameTb.Name = "BookNameTb";
            this.BookNameTb.Size = new System.Drawing.Size(200, 23);
            this.BookNameTb.TabIndex = 8;
            // 
            // BookauthourTb
            // 
            this.BookauthourTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookauthourTb.Location = new System.Drawing.Point(897, 161);
            this.BookauthourTb.Name = "BookauthourTb";
            this.BookauthourTb.Size = new System.Drawing.Size(200, 23);
            this.BookauthourTb.TabIndex = 9;
            // 
            // PublishDateDtp
            // 
            this.PublishDateDtp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PublishDateDtp.CustomFormat = " ";
            this.PublishDateDtp.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PublishDateDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.PublishDateDtp.Location = new System.Drawing.Point(897, 208);
            this.PublishDateDtp.Name = "PublishDateDtp";
            this.PublishDateDtp.Size = new System.Drawing.Size(200, 21);
            this.PublishDateDtp.TabIndex = 10;
            this.PublishDateDtp.ValueChanged += new System.EventHandler(this.PublishDateDtp_ValueChanged);
            // 
            // BookcategoryCb
            // 
            this.BookcategoryCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookcategoryCb.FormattingEnabled = true;
            this.BookcategoryCb.Items.AddRange(new object[] {
            "",
            "Novel",
            "News Paper",
            "Sports",
            "Romance",
            "Educational",
            "Science",
            "Astronomy",
            "Mathematics",
            "Histroy",
            "Other"});
            this.BookcategoryCb.Location = new System.Drawing.Point(897, 266);
            this.BookcategoryCb.Name = "BookcategoryCb";
            this.BookcategoryCb.Size = new System.Drawing.Size(200, 24);
            this.BookcategoryCb.TabIndex = 11;
            // 
            // QuantityCb
            // 
            this.QuantityCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityCb.FormattingEnabled = true;
            this.QuantityCb.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "9",
            "10"});
            this.QuantityCb.Location = new System.Drawing.Point(897, 329);
            this.QuantityCb.Name = "QuantityCb";
            this.QuantityCb.Size = new System.Drawing.Size(200, 24);
            this.QuantityCb.TabIndex = 12;
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.BackColor = System.Drawing.Color.Lime;
            this.RegisterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterBtn.FlatAppearance.BorderSize = 0;
            this.RegisterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Location = new System.Drawing.Point(785, 408);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(100, 30);
            this.RegisterBtn.TabIndex = 13;
            this.RegisterBtn.Text = "REGISTER";
            this.RegisterBtn.UseVisualStyleBackColor = false;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.BackColor = System.Drawing.Color.Orange;
            this.ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearBtn.FlatAppearance.BorderSize = 0;
            this.ClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(891, 408);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(100, 30);
            this.ClearBtn.TabIndex = 14;
            this.ClearBtn.Text = "CLEAR ALL";
            this.ClearBtn.UseVisualStyleBackColor = false;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.BackColor = System.Drawing.Color.Red;
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.FlatAppearance.BorderSize = 0;
            this.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkRed;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(997, 408);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(100, 30);
            this.DeleteBtn.TabIndex = 15;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitBtn.FlatAppearance.BorderSize = 0;
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(1074, 9);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(23, 23);
            this.ExitBtn.TabIndex = 16;
            this.ExitBtn.Text = "X";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // libraryBooksDatabaseDataSet
            // 
            this.libraryBooksDatabaseDataSet.DataSetName = "LibraryBooksDatabaseDataSet";
            this.libraryBooksDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.libraryBooksDatabaseDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = Library_Managment_System.LibraryBooksDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tableDataGridView
            // 
            this.tableDataGridView.AutoGenerateColumns = false;
            this.tableDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.tableDataGridView.DataSource = this.tableBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            this.tableDataGridView.GridColor = System.Drawing.Color.Tomato;
            this.tableDataGridView.Location = new System.Drawing.Point(12, 80);
            this.tableDataGridView.Margin = new System.Windows.Forms.Padding(5);
            this.tableDataGridView.Name = "tableDataGridView";
            this.tableDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tableDataGridView.Size = new System.Drawing.Size(648, 366);
            this.tableDataGridView.TabIndex = 17;
            this.tableDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Book_Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Book_Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Book_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Book_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Book_Authour";
            this.dataGridViewTextBoxColumn3.HeaderText = "Book_Authour";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Published_Date";
            this.dataGridViewTextBoxColumn4.HeaderText = "Published_Date";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Category";
            this.dataGridViewTextBoxColumn5.HeaderText = "Category";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Quantity";
            this.dataGridViewTextBoxColumn6.HeaderText = "Quantity";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // libraryBooksDatabaseDataSet1
            // 
            this.libraryBooksDatabaseDataSet1.DataSetName = "LibraryBooksDatabaseDataSet";
            this.libraryBooksDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.Font = new System.Drawing.Font("Georgia", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLabel.Location = new System.Drawing.Point(12, 9);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(0, 27);
            this.UserLabel.TabIndex = 19;
            // 
            // BookRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1117, 458);
            this.Controls.Add(this.UserLabel);
            this.Controls.Add(this.tableDataGridView);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.RegisterBtn);
            this.Controls.Add(this.QuantityCb);
            this.Controls.Add(this.BookcategoryCb);
            this.Controls.Add(this.PublishDateDtp);
            this.Controls.Add(this.BookauthourTb);
            this.Controls.Add(this.BookNameTb);
            this.Controls.Add(this.BookIdTb);
            this.Controls.Add(this.Quantity);
            this.Controls.Add(this.BookCategory);
            this.Controls.Add(this.PublisheDate);
            this.Controls.Add(this.BookAuthour);
            this.Controls.Add(this.BookName);
            this.Controls.Add(this.BookId);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BookRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookRegistration";
            this.Load += new System.EventHandler(this.BookRegistration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooksDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooksDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label BookId;
        private System.Windows.Forms.Label BookName;
        private System.Windows.Forms.Label BookAuthour;
        private System.Windows.Forms.Label PublisheDate;
        private System.Windows.Forms.Label BookCategory;
        private System.Windows.Forms.Label Quantity;
        private System.Windows.Forms.TextBox BookIdTb;
        private System.Windows.Forms.TextBox BookNameTb;
        private System.Windows.Forms.TextBox BookauthourTb;
        private System.Windows.Forms.DateTimePicker PublishDateDtp;
        private System.Windows.Forms.ComboBox BookcategoryCb;
        private System.Windows.Forms.ComboBox QuantityCb;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ExitBtn;
        private LibraryBooksDatabaseDataSet libraryBooksDatabaseDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private LibraryBooksDatabaseDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private LibraryBooksDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView tableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private LibraryBooksDatabaseDataSet libraryBooksDatabaseDataSet1;
        private System.Windows.Forms.Label UserLabel;
    }
}

