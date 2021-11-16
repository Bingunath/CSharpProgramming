
namespace DITECH_FINAL_PROJECT
{
    partial class ManageCourses
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CourseDataGrid = new System.Windows.Forms.DataGridView();
            this.courseIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursenameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursefeesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursefaciliatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coursesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.courses = new DITECH_FINAL_PROJECT.courses();
            this.coursesTableAdapter = new DITECH_FINAL_PROJECT.coursesTableAdapters.coursesTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TitleBox = new System.Windows.Forms.ComboBox();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.RegisterBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FaciliatorTB = new System.Windows.Forms.TextBox();
            this.CourseFeesTB = new System.Windows.Forms.TextBox();
            this.CourseNameTB = new System.Windows.Forms.TextBox();
            this.CourseIDTB = new System.Windows.Forms.TextBox();
            this.database1DataSet1 = new DITECH_FINAL_PROJECT.Database1DataSet();
            this.coursesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.courses)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ExitBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 35);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Manage Courses";
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Red;
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Location = new System.Drawing.Point(979, 6);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "EXIT";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CourseDataGrid
            // 
            this.CourseDataGrid.AutoGenerateColumns = false;
            this.CourseDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.CourseDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.courseIDDataGridViewTextBoxColumn,
            this.coursenameDataGridViewTextBoxColumn,
            this.coursefeesDataGridViewTextBoxColumn,
            this.coursefaciliatorDataGridViewTextBoxColumn});
            this.CourseDataGrid.DataSource = this.coursesBindingSource;
            this.CourseDataGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.CourseDataGrid.Location = new System.Drawing.Point(602, 35);
            this.CourseDataGrid.Name = "CourseDataGrid";
            this.CourseDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CourseDataGrid.Size = new System.Drawing.Size(464, 415);
            this.CourseDataGrid.TabIndex = 2;
            this.CourseDataGrid.Click += new System.EventHandler(this.CourseDataGrid_Click);
            // 
            // courseIDDataGridViewTextBoxColumn
            // 
            this.courseIDDataGridViewTextBoxColumn.DataPropertyName = "courseID";
            this.courseIDDataGridViewTextBoxColumn.HeaderText = "courseID";
            this.courseIDDataGridViewTextBoxColumn.Name = "courseIDDataGridViewTextBoxColumn";
            // 
            // coursenameDataGridViewTextBoxColumn
            // 
            this.coursenameDataGridViewTextBoxColumn.DataPropertyName = "coursename";
            this.coursenameDataGridViewTextBoxColumn.HeaderText = "coursename";
            this.coursenameDataGridViewTextBoxColumn.Name = "coursenameDataGridViewTextBoxColumn";
            // 
            // coursefeesDataGridViewTextBoxColumn
            // 
            this.coursefeesDataGridViewTextBoxColumn.DataPropertyName = "coursefees";
            this.coursefeesDataGridViewTextBoxColumn.HeaderText = "coursefees";
            this.coursefeesDataGridViewTextBoxColumn.Name = "coursefeesDataGridViewTextBoxColumn";
            // 
            // coursefaciliatorDataGridViewTextBoxColumn
            // 
            this.coursefaciliatorDataGridViewTextBoxColumn.DataPropertyName = "coursefaciliator";
            this.coursefaciliatorDataGridViewTextBoxColumn.HeaderText = "coursefaciliator";
            this.coursefaciliatorDataGridViewTextBoxColumn.Name = "coursefaciliatorDataGridViewTextBoxColumn";
            // 
            // coursesBindingSource
            // 
            this.coursesBindingSource.DataMember = "courses";
            this.coursesBindingSource.DataSource = this.courses;
            // 
            // courses
            // 
            this.courses.DataSetName = "courses";
            this.courses.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesTableAdapter
            // 
            this.coursesTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.panel2.Controls.Add(this.TitleBox);
            this.panel2.Controls.Add(this.ClearBtn);
            this.panel2.Controls.Add(this.DeleteBtn);
            this.panel2.Controls.Add(this.EditBtn);
            this.panel2.Controls.Add(this.RegisterBtn);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.FaciliatorTB);
            this.panel2.Controls.Add(this.CourseFeesTB);
            this.panel2.Controls.Add(this.CourseNameTB);
            this.panel2.Controls.Add(this.CourseIDTB);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 35);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 415);
            this.panel2.TabIndex = 3;
            // 
            // TitleBox
            // 
            this.TitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleBox.FormattingEnabled = true;
            this.TitleBox.Items.AddRange(new object[] {
            "",
            "Mr.",
            "Mrs.",
            "Miss."});
            this.TitleBox.Location = new System.Drawing.Point(212, 200);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(62, 28);
            this.TitleBox.TabIndex = 3;
            this.TitleBox.SelectedIndexChanged += new System.EventHandler(this.TitleBox_SelectedIndexChanged);
            // 
            // ClearBtn
            // 
            this.ClearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.ClearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearBtn.Font = new System.Drawing.Font("Adobe Devanagari", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(364, 267);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(95, 33);
            this.ClearBtn.TabIndex = 8;
            this.ClearBtn.Text = "CLEAR";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.DeleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteBtn.Font = new System.Drawing.Font("Adobe Devanagari", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(248, 267);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(95, 33);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Adobe Devanagari", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(132, 267);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(95, 33);
            this.EditBtn.TabIndex = 6;
            this.EditBtn.Text = "UPDATE";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // RegisterBtn
            // 
            this.RegisterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.RegisterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterBtn.Font = new System.Drawing.Font("Adobe Devanagari", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterBtn.Location = new System.Drawing.Point(16, 267);
            this.RegisterBtn.Name = "RegisterBtn";
            this.RegisterBtn.Size = new System.Drawing.Size(95, 33);
            this.RegisterBtn.TabIndex = 5;
            this.RegisterBtn.Text = "REGISTER";
            this.RegisterBtn.UseVisualStyleBackColor = true;
            this.RegisterBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "COURSE FACILIATOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "COURSE FEES(LKR)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "COURSE NAME";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "COURSE ID";
            // 
            // FaciliatorTB
            // 
            this.FaciliatorTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FaciliatorTB.Location = new System.Drawing.Point(280, 200);
            this.FaciliatorTB.Name = "FaciliatorTB";
            this.FaciliatorTB.Size = new System.Drawing.Size(157, 26);
            this.FaciliatorTB.TabIndex = 4;
            // 
            // CourseFeesTB
            // 
            this.CourseFeesTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseFeesTB.Location = new System.Drawing.Point(212, 140);
            this.CourseFeesTB.Name = "CourseFeesTB";
            this.CourseFeesTB.Size = new System.Drawing.Size(225, 26);
            this.CourseFeesTB.TabIndex = 2;
            // 
            // CourseNameTB
            // 
            this.CourseNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseNameTB.Location = new System.Drawing.Point(212, 80);
            this.CourseNameTB.Name = "CourseNameTB";
            this.CourseNameTB.Size = new System.Drawing.Size(225, 26);
            this.CourseNameTB.TabIndex = 1;
            this.CourseNameTB.TextChanged += new System.EventHandler(this.CourseNameTB_TextChanged);
            // 
            // CourseIDTB
            // 
            this.CourseIDTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CourseIDTB.Location = new System.Drawing.Point(212, 20);
            this.CourseIDTB.Name = "CourseIDTB";
            this.CourseIDTB.Size = new System.Drawing.Size(225, 26);
            this.CourseIDTB.TabIndex = 0;
            this.CourseIDTB.TextChanged += new System.EventHandler(this.CourseIDTB_TextChanged);
            // 
            // database1DataSet1
            // 
            this.database1DataSet1.DataSetName = "Database1DataSet";
            this.database1DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coursesBindingSource1
            // 
            this.coursesBindingSource1.DataMember = "courses";
            this.coursesBindingSource1.DataSource = this.courses;
            // 
            // ManageCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.CourseDataGrid);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageCourses";
            this.Text = "ManageCourses";
            this.Load += new System.EventHandler(this.ManageCourses_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.courses)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coursesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.DataGridView CourseDataGrid;
        private courses courses;
        private System.Windows.Forms.BindingSource coursesBindingSource;
        private coursesTableAdapters.coursesTableAdapter coursesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursenameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursefeesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coursefaciliatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FaciliatorTB;
        private System.Windows.Forms.TextBox CourseFeesTB;
        private System.Windows.Forms.TextBox CourseNameTB;
        private System.Windows.Forms.TextBox CourseIDTB;
        private Database1DataSet database1DataSet1;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button RegisterBtn;
        private System.Windows.Forms.ComboBox TitleBox;
        private System.Windows.Forms.BindingSource coursesBindingSource1;
    }
}