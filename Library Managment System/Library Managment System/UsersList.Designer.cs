
namespace Library_Managment_System
{
    partial class UsersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsersForm));
            this.deleteTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.loginsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryBooksDatabaseDataSet4 = new Library_Managment_System.LibraryBooksDatabaseDataSet4();
            this.loginsTableAdapter = new Library_Managment_System.LibraryBooksDatabaseDataSet4TableAdapters.loginsTableAdapter();
            this.UsersDataGride = new System.Windows.Forms.DataGridView();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooksDatabaseDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGride)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteTB
            // 
            this.deleteTB.Location = new System.Drawing.Point(48, 81);
            this.deleteTB.Name = "deleteTB";
            this.deleteTB.Size = new System.Drawing.Size(100, 20);
            this.deleteTB.TabIndex = 1;
            this.deleteTB.TextChanged += new System.EventHandler(this.deleteTB_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(154, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.Location = new System.Drawing.Point(384, 12);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(48, 23);
            this.ExitBtn.TabIndex = 3;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // loginsBindingSource
            // 
            this.loginsBindingSource.DataMember = "logins";
            this.loginsBindingSource.DataSource = this.libraryBooksDatabaseDataSet4;
            // 
            // libraryBooksDatabaseDataSet4
            // 
            this.libraryBooksDatabaseDataSet4.DataSetName = "LibraryBooksDatabaseDataSet4";
            this.libraryBooksDatabaseDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // loginsTableAdapter
            // 
            this.loginsTableAdapter.ClearBeforeFill = true;
            // 
            // UsersDataGride
            // 
            this.UsersDataGride.AutoGenerateColumns = false;
            this.UsersDataGride.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.UsersDataGride.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIDDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn});
            this.UsersDataGride.DataSource = this.loginsBindingSource1;
            this.UsersDataGride.Location = new System.Drawing.Point(48, 107);
            this.UsersDataGride.Name = "UsersDataGride";
            this.UsersDataGride.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UsersDataGride.Size = new System.Drawing.Size(345, 150);
            this.UsersDataGride.TabIndex = 4;
            this.UsersDataGride.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UsersDataGride_CellContentClick);
            this.UsersDataGride.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UsersDataGride_MouseClick);
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "UserID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "UserID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // loginsBindingSource1
            // 
            this.loginsBindingSource1.DataMember = "logins";
            this.loginsBindingSource1.DataSource = this.libraryBooksDatabaseDataSet4;
            // 
            // UsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 348);
            this.ControlBox = false;
            this.Controls.Add(this.UsersDataGride);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deleteTB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Users";
            this.Load += new System.EventHandler(this.UsersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryBooksDatabaseDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersDataGride)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginsBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private LibraryBooksDatabaseDataSet4 libraryBooksDatabaseDataSet4;
        private System.Windows.Forms.BindingSource loginsBindingSource;
        private LibraryBooksDatabaseDataSet4TableAdapters.loginsTableAdapter loginsTableAdapter;
        private System.Windows.Forms.TextBox deleteTB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.DataGridView UsersDataGride;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource loginsBindingSource1;
    }
}