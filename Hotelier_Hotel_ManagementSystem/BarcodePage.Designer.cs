
namespace Hotelier_Hotel_ManagementSystem
{
    partial class BarcodePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BarcodePage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BarcodeTB = new System.Windows.Forms.TextBox();
            this.MemberIDCB = new System.Windows.Forms.ComboBox();
            this.GenerateBtn = new System.Windows.Forms.Button();
            this.printBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.GymMembersGrid = new System.Windows.Forms.DataGridView();
            this.snnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gymmembersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gymMembers = new Hotelier_Hotel_ManagementSystem.gymMembers();
            this.gymmembersTableAdapter = new Hotelier_Hotel_ManagementSystem.gymMembersTableAdapters.gymmembersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GymMembersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymmembersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(658, 145);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BarcodeTB
            // 
            this.BarcodeTB.Location = new System.Drawing.Point(13, 152);
            this.BarcodeTB.Name = "BarcodeTB";
            this.BarcodeTB.ReadOnly = true;
            this.BarcodeTB.Size = new System.Drawing.Size(178, 20);
            this.BarcodeTB.TabIndex = 1;
            // 
            // MemberIDCB
            // 
            this.MemberIDCB.FormattingEnabled = true;
            this.MemberIDCB.Location = new System.Drawing.Point(347, 151);
            this.MemberIDCB.Name = "MemberIDCB";
            this.MemberIDCB.Size = new System.Drawing.Size(121, 21);
            this.MemberIDCB.TabIndex = 2;
            this.MemberIDCB.SelectedIndexChanged += new System.EventHandler(this.MemberIDCB_SelectedIndexChanged);
            // 
            // GenerateBtn
            // 
            this.GenerateBtn.Location = new System.Drawing.Point(13, 179);
            this.GenerateBtn.Name = "GenerateBtn";
            this.GenerateBtn.Size = new System.Drawing.Size(75, 23);
            this.GenerateBtn.TabIndex = 3;
            this.GenerateBtn.Text = "Generate";
            this.GenerateBtn.UseVisualStyleBackColor = true;
            this.GenerateBtn.Click += new System.EventHandler(this.GenerateBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(95, 178);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(75, 23);
            this.printBtn.TabIndex = 4;
            this.printBtn.Text = "Print";
            this.printBtn.UseVisualStyleBackColor = true;
            // 
            // SearchBox
            // 
            this.SearchBox.Location = new System.Drawing.Point(197, 151);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(144, 20);
            this.SearchBox.TabIndex = 5;
            this.SearchBox.Text = "MPMHG";
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            // 
            // GymMembersGrid
            // 
            this.GymMembersGrid.AutoGenerateColumns = false;
            this.GymMembersGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GymMembersGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GymMembersGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snnoDataGridViewTextBoxColumn,
            this.membershipidDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.contactDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.GymMembersGrid.DataSource = this.gymmembersBindingSource;
            this.GymMembersGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GymMembersGrid.Location = new System.Drawing.Point(0, 208);
            this.GymMembersGrid.Name = "GymMembersGrid";
            this.GymMembersGrid.Size = new System.Drawing.Size(658, 174);
            this.GymMembersGrid.TabIndex = 6;
            // 
            // snnoDataGridViewTextBoxColumn
            // 
            this.snnoDataGridViewTextBoxColumn.DataPropertyName = "snno";
            this.snnoDataGridViewTextBoxColumn.HeaderText = "S/N";
            this.snnoDataGridViewTextBoxColumn.Name = "snnoDataGridViewTextBoxColumn";
            // 
            // membershipidDataGridViewTextBoxColumn
            // 
            this.membershipidDataGridViewTextBoxColumn.DataPropertyName = "membershipid";
            this.membershipidDataGridViewTextBoxColumn.HeaderText = "Membership ID";
            this.membershipidDataGridViewTextBoxColumn.Name = "membershipidDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // contactDataGridViewTextBoxColumn
            // 
            this.contactDataGridViewTextBoxColumn.DataPropertyName = "contact";
            this.contactDataGridViewTextBoxColumn.HeaderText = "Contact";
            this.contactDataGridViewTextBoxColumn.Name = "contactDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // gymmembersBindingSource
            // 
            this.gymmembersBindingSource.DataMember = "gymmembers";
            this.gymmembersBindingSource.DataSource = this.gymMembers;
            // 
            // gymMembers
            // 
            this.gymMembers.DataSetName = "gymMembers";
            this.gymMembers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gymmembersTableAdapter
            // 
            this.gymmembersTableAdapter.ClearBeforeFill = true;
            // 
            // BarcodePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 382);
            this.Controls.Add(this.GymMembersGrid);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.GenerateBtn);
            this.Controls.Add(this.MemberIDCB);
            this.Controls.Add(this.BarcodeTB);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(674, 421);
            this.Name = "BarcodePage";
            this.Text = "Barcode";
            this.Load += new System.EventHandler(this.Barcode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GymMembersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymmembersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gymMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox BarcodeTB;
        private System.Windows.Forms.ComboBox MemberIDCB;
        private System.Windows.Forms.Button GenerateBtn;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.DataGridView GymMembersGrid;
        private gymMembers gymMembers;
        private System.Windows.Forms.BindingSource gymmembersBindingSource;
        private gymMembersTableAdapters.gymmembersTableAdapter gymmembersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn snnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}