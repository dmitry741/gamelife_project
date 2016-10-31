namespace ConwaysGameLife
{
    partial class frmSettings
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
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbNewCellSign1 = new System.Windows.Forms.ComboBox();
            this.cmbNewCellNumber1 = new System.Windows.Forms.ComboBox();
            this.cmbNewCellSign2 = new System.Windows.Forms.ComboBox();
            this.cmbNewCellNumber2 = new System.Windows.Forms.ComboBox();
            this.checkBoxOR1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNewCellOr = new System.Windows.Forms.Label();
            this.lblCellGoOnOr = new System.Windows.Forms.Label();
            this.checkBoxOR2 = new System.Windows.Forms.CheckBox();
            this.cmbCellGoOnSign2 = new System.Windows.Forms.ComboBox();
            this.cmbCellGoOnNumber2 = new System.Windows.Forms.ComboBox();
            this.cmbCellGoOnNumber1 = new System.Windows.Forms.ComboBox();
            this.cmbCellGoOnSign1 = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(477, 360);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(101, 33);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(370, 360);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 33);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.lblCellGoOnOr);
            this.groupBox1.Controls.Add(this.checkBoxOR2);
            this.groupBox1.Controls.Add(this.cmbCellGoOnSign2);
            this.groupBox1.Controls.Add(this.cmbCellGoOnNumber2);
            this.groupBox1.Controls.Add(this.cmbCellGoOnNumber1);
            this.groupBox1.Controls.Add(this.cmbCellGoOnSign1);
            this.groupBox1.Controls.Add(this.lblNewCellOr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBoxOR1);
            this.groupBox1.Controls.Add(this.cmbNewCellSign2);
            this.groupBox1.Controls.Add(this.cmbNewCellNumber2);
            this.groupBox1.Controls.Add(this.cmbNewCellNumber1);
            this.groupBox1.Controls.Add(this.cmbNewCellSign1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(569, 337);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Life rules";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(465, 160);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "New cell: Neighbors is";
            // 
            // cmbNewCellSign1
            // 
            this.cmbNewCellSign1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewCellSign1.FormattingEnabled = true;
            this.cmbNewCellSign1.Location = new System.Drawing.Point(163, 185);
            this.cmbNewCellSign1.Name = "cmbNewCellSign1";
            this.cmbNewCellSign1.Size = new System.Drawing.Size(43, 21);
            this.cmbNewCellSign1.TabIndex = 4;
            // 
            // cmbNewCellNumber1
            // 
            this.cmbNewCellNumber1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewCellNumber1.FormattingEnabled = true;
            this.cmbNewCellNumber1.Location = new System.Drawing.Point(212, 185);
            this.cmbNewCellNumber1.Name = "cmbNewCellNumber1";
            this.cmbNewCellNumber1.Size = new System.Drawing.Size(43, 21);
            this.cmbNewCellNumber1.TabIndex = 5;
            // 
            // cmbNewCellSign2
            // 
            this.cmbNewCellSign2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewCellSign2.FormattingEnabled = true;
            this.cmbNewCellSign2.Location = new System.Drawing.Point(290, 185);
            this.cmbNewCellSign2.Name = "cmbNewCellSign2";
            this.cmbNewCellSign2.Size = new System.Drawing.Size(43, 21);
            this.cmbNewCellSign2.TabIndex = 7;
            // 
            // cmbNewCellNumber2
            // 
            this.cmbNewCellNumber2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNewCellNumber2.FormattingEnabled = true;
            this.cmbNewCellNumber2.Location = new System.Drawing.Point(339, 185);
            this.cmbNewCellNumber2.Name = "cmbNewCellNumber2";
            this.cmbNewCellNumber2.Size = new System.Drawing.Size(43, 21);
            this.cmbNewCellNumber2.TabIndex = 6;
            // 
            // checkBoxOR1
            // 
            this.checkBoxOR1.AutoSize = true;
            this.checkBoxOR1.Checked = true;
            this.checkBoxOR1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOR1.Location = new System.Drawing.Point(393, 187);
            this.checkBoxOR1.Name = "checkBoxOR1";
            this.checkBoxOR1.Size = new System.Drawing.Size(78, 17);
            this.checkBoxOR1.TabIndex = 9;
            this.checkBoxOR1.Text = "Enable OR";
            this.checkBoxOR1.UseVisualStyleBackColor = true;
            this.checkBoxOR1.CheckedChanged += new System.EventHandler(this.checkBoxOR1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cell go on to live: Neighbors is";
            // 
            // lblNewCellOr
            // 
            this.lblNewCellOr.AutoSize = true;
            this.lblNewCellOr.Location = new System.Drawing.Point(261, 188);
            this.lblNewCellOr.Name = "lblNewCellOr";
            this.lblNewCellOr.Size = new System.Drawing.Size(23, 13);
            this.lblNewCellOr.TabIndex = 11;
            this.lblNewCellOr.Text = "OR";
            // 
            // lblCellGoOnOr
            // 
            this.lblCellGoOnOr.AutoSize = true;
            this.lblCellGoOnOr.Location = new System.Drawing.Point(261, 215);
            this.lblCellGoOnOr.Name = "lblCellGoOnOr";
            this.lblCellGoOnOr.Size = new System.Drawing.Size(23, 13);
            this.lblCellGoOnOr.TabIndex = 17;
            this.lblCellGoOnOr.Text = "OR";
            // 
            // checkBoxOR2
            // 
            this.checkBoxOR2.AutoSize = true;
            this.checkBoxOR2.Checked = true;
            this.checkBoxOR2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOR2.Location = new System.Drawing.Point(393, 214);
            this.checkBoxOR2.Name = "checkBoxOR2";
            this.checkBoxOR2.Size = new System.Drawing.Size(78, 17);
            this.checkBoxOR2.TabIndex = 16;
            this.checkBoxOR2.Text = "Enable OR";
            this.checkBoxOR2.UseVisualStyleBackColor = true;
            // 
            // cmbCellGoOnSign2
            // 
            this.cmbCellGoOnSign2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCellGoOnSign2.FormattingEnabled = true;
            this.cmbCellGoOnSign2.Location = new System.Drawing.Point(290, 212);
            this.cmbCellGoOnSign2.Name = "cmbCellGoOnSign2";
            this.cmbCellGoOnSign2.Size = new System.Drawing.Size(43, 21);
            this.cmbCellGoOnSign2.TabIndex = 15;
            // 
            // cmbCellGoOnNumber2
            // 
            this.cmbCellGoOnNumber2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCellGoOnNumber2.FormattingEnabled = true;
            this.cmbCellGoOnNumber2.Location = new System.Drawing.Point(339, 212);
            this.cmbCellGoOnNumber2.Name = "cmbCellGoOnNumber2";
            this.cmbCellGoOnNumber2.Size = new System.Drawing.Size(43, 21);
            this.cmbCellGoOnNumber2.TabIndex = 14;
            // 
            // cmbCellGoOnNumber1
            // 
            this.cmbCellGoOnNumber1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCellGoOnNumber1.FormattingEnabled = true;
            this.cmbCellGoOnNumber1.Location = new System.Drawing.Point(212, 212);
            this.cmbCellGoOnNumber1.Name = "cmbCellGoOnNumber1";
            this.cmbCellGoOnNumber1.Size = new System.Drawing.Size(43, 21);
            this.cmbCellGoOnNumber1.TabIndex = 13;
            // 
            // cmbCellGoOnSign1
            // 
            this.cmbCellGoOnSign1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCellGoOnSign1.FormattingEnabled = true;
            this.cmbCellGoOnSign1.Location = new System.Drawing.Point(163, 212);
            this.cmbCellGoOnSign1.Name = "cmbCellGoOnSign1";
            this.cmbCellGoOnSign1.Size = new System.Drawing.Size(43, 21);
            this.cmbCellGoOnSign1.TabIndex = 12;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(477, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 32);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(477, 57);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 32);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Remove";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 260);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 32);
            this.btnSave.TabIndex = 20;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(11, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "* Press Save button to save life rules.";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 405);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.frmSettings_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbNewCellNumber1;
        private System.Windows.Forms.ComboBox cmbNewCellSign1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckBox checkBoxOR1;
        private System.Windows.Forms.ComboBox cmbNewCellSign2;
        private System.Windows.Forms.ComboBox cmbNewCellNumber2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNewCellOr;
        private System.Windows.Forms.Label lblCellGoOnOr;
        private System.Windows.Forms.CheckBox checkBoxOR2;
        private System.Windows.Forms.ComboBox cmbCellGoOnSign2;
        private System.Windows.Forms.ComboBox cmbCellGoOnNumber2;
        private System.Windows.Forms.ComboBox cmbCellGoOnNumber1;
        private System.Windows.Forms.ComboBox cmbCellGoOnSign1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
    }
}