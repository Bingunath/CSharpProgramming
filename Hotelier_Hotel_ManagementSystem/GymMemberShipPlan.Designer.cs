
namespace Hotelier_Hotel_ManagementSystem
{
    partial class GymMemberShipPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GymMemberShipPlan));
            this.PlanTB = new System.Windows.Forms.TextBox();
            this.ValidTB = new System.Windows.Forms.TextBox();
            this.PrivilageTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PlanGrid = new System.Windows.Forms.DataGridView();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipplanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.privilagesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.membershipplanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membershipplans = new Hotelier_Hotel_ManagementSystem.membershipplans();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AutoNumbersBtn = new System.Windows.Forms.Button();
            this.NoTB = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.PriceTB = new System.Windows.Forms.TextBox();
            this.EditBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.membershipplanTableAdapter = new Hotelier_Hotel_ManagementSystem.membershipplansTableAdapters.membershipplanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PlanGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipplanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipplans)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlanTB
            // 
            this.PlanTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlanTB.Location = new System.Drawing.Point(140, 60);
            this.PlanTB.Name = "PlanTB";
            this.PlanTB.Size = new System.Drawing.Size(180, 22);
            this.PlanTB.TabIndex = 0;
            // 
            // ValidTB
            // 
            this.ValidTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidTB.Location = new System.Drawing.Point(139, 95);
            this.ValidTB.Name = "ValidTB";
            this.ValidTB.Size = new System.Drawing.Size(180, 22);
            this.ValidTB.TabIndex = 1;
            // 
            // PrivilageTB
            // 
            this.PrivilageTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrivilageTB.Location = new System.Drawing.Point(139, 130);
            this.PrivilageTB.Name = "PrivilageTB";
            this.PrivilageTB.Size = new System.Drawing.Size(180, 22);
            this.PrivilageTB.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Membership Plans";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valid Months";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Privilages";
            // 
            // PlanGrid
            // 
            this.PlanGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PlanGrid.AutoGenerateColumns = false;
            this.PlanGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PlanGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PlanGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.no,
            this.membershipplanDataGridViewTextBoxColumn,
            this.validDataGridViewTextBoxColumn,
            this.privilagesDataGridViewTextBoxColumn,
            this.price});
            this.PlanGrid.DataSource = this.membershipplanBindingSource;
            this.PlanGrid.Location = new System.Drawing.Point(487, 0);
            this.PlanGrid.Name = "PlanGrid";
            this.PlanGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PlanGrid.Size = new System.Drawing.Size(513, 451);
            this.PlanGrid.TabIndex = 7;
            this.PlanGrid.DoubleClick += new System.EventHandler(this.EditBtn_Click);
            // 
            // no
            // 
            this.no.DataPropertyName = "no";
            this.no.HeaderText = "No";
            this.no.Name = "no";
            // 
            // membershipplanDataGridViewTextBoxColumn
            // 
            this.membershipplanDataGridViewTextBoxColumn.DataPropertyName = "membershipplan";
            this.membershipplanDataGridViewTextBoxColumn.HeaderText = "Membership Plan";
            this.membershipplanDataGridViewTextBoxColumn.Name = "membershipplanDataGridViewTextBoxColumn";
            // 
            // validDataGridViewTextBoxColumn
            // 
            this.validDataGridViewTextBoxColumn.DataPropertyName = "valid";
            this.validDataGridViewTextBoxColumn.HeaderText = "Valid";
            this.validDataGridViewTextBoxColumn.Name = "validDataGridViewTextBoxColumn";
            // 
            // privilagesDataGridViewTextBoxColumn
            // 
            this.privilagesDataGridViewTextBoxColumn.DataPropertyName = "privilages";
            this.privilagesDataGridViewTextBoxColumn.HeaderText = "Privilages";
            this.privilagesDataGridViewTextBoxColumn.Name = "privilagesDataGridViewTextBoxColumn";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            // 
            // membershipplanBindingSource
            // 
            this.membershipplanBindingSource.DataMember = "membershipplan";
            this.membershipplanBindingSource.DataSource = this.membershipplans;
            // 
            // membershipplans
            // 
            this.membershipplans.DataSetName = "membershipplans";
            this.membershipplans.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.groupBox1.Controls.Add(this.AutoNumbersBtn);
            this.groupBox1.Controls.Add(this.NoTB);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.PriceTB);
            this.groupBox1.Controls.Add(this.EditBtn);
            this.groupBox1.Controls.Add(this.UpdateBtn);
            this.groupBox1.Controls.Add(this.ClearBtn);
            this.groupBox1.Controls.Add(this.DeleteBtn);
            this.groupBox1.Controls.Add(this.SaveBtn);
            this.groupBox1.Controls.Add(this.PlanTB);
            this.groupBox1.Controls.Add(this.PrivilageTB);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ValidTB);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(445, 265);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Plans";
            // 
            // AutoNumbersBtn
            // 
            this.AutoNumbersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoNumbersBtn.Location = new System.Drawing.Point(247, 27);
            this.AutoNumbersBtn.Name = "AutoNumbersBtn";
            this.AutoNumbersBtn.Size = new System.Drawing.Size(75, 23);
            this.AutoNumbersBtn.TabIndex = 14;
            this.AutoNumbersBtn.Text = "AUTO NO";
            this.AutoNumbersBtn.UseVisualStyleBackColor = true;
            this.AutoNumbersBtn.Click += new System.EventHandler(this.AutoNumbersBtn_Click);
            // 
            // NoTB
            // 
            this.NoTB.Location = new System.Drawing.Point(140, 27);
            this.NoTB.Name = "NoTB";
            this.NoTB.Size = new System.Drawing.Size(100, 22);
            this.NoTB.TabIndex = 13;
            this.NoTB.TextChanged += new System.EventHandler(this.NoTB_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "1",
            "3",
            "6",
            "12"});
            this.comboBox1.Location = new System.Drawing.Point(318, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(18, 24);
            this.comboBox1.TabIndex = 12;
            // 
            // PriceTB
            // 
            this.PriceTB.Location = new System.Drawing.Point(139, 165);
            this.PriceTB.Name = "PriceTB";
            this.PriceTB.Size = new System.Drawing.Size(180, 22);
            this.PriceTB.TabIndex = 11;
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.Location = new System.Drawing.Point(351, 208);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 10;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(265, 207);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(75, 23);
            this.UpdateBtn.TabIndex = 9;
            this.UpdateBtn.Text = "UPDATE";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(179, 208);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(75, 23);
            this.ClearBtn.TabIndex = 8;
            this.ClearBtn.Text = "CLEAR";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.Location = new System.Drawing.Point(93, 208);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "DELETE";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.Location = new System.Drawing.Point(7, 208);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.Text = "SAVE";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "NO.";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 451);
            this.panel1.TabIndex = 9;
            // 
            // membershipplanTableAdapter
            // 
            this.membershipplanTableAdapter.ClearBeforeFill = true;
            // 
            // GymMemberShipPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 451);
            this.Controls.Add(this.PlanGrid);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GymMemberShipPlan";
            this.Text = "GymMemberShipPlan";
            this.Load += new System.EventHandler(this.GymMemberShipPlan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PlanGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipplanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membershipplans)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox PlanTB;
        private System.Windows.Forms.TextBox ValidTB;
        private System.Windows.Forms.TextBox PrivilageTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView PlanGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Panel panel1;
        private membershipplans membershipplans;
        private System.Windows.Forms.BindingSource membershipplanBindingSource;
        private membershipplansTableAdapters.membershipplanTableAdapter membershipplanTableAdapter;
        private System.Windows.Forms.TextBox PriceTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox NoTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipplanDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn privilagesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.Button AutoNumbersBtn;
    }
}