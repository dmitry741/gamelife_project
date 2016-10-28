namespace ConwaysGameLife
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSceneMode = new System.Windows.Forms.ComboBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRandom = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbNext = new System.Windows.Forms.ComboBox();
            this.cmbAnimateMode = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext10 = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbGridView = new System.Windows.Forms.CheckBox();
            this.btnSettings = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(706, 706);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.SizeChanged += new System.EventHandler(this.pictureBox1_SizeChanged);
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(9, 19);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 33);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(724, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Scene mode";
            // 
            // cmbSceneMode
            // 
            this.cmbSceneMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSceneMode.FormattingEnabled = true;
            this.cmbSceneMode.Location = new System.Drawing.Point(730, 28);
            this.cmbSceneMode.Name = "cmbSceneMode";
            this.cmbSceneMode.Size = new System.Drawing.Size(101, 21);
            this.cmbSceneMode.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(733, 685);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(101, 33);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(6, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(101, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save map...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(6, 58);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(101, 33);
            this.btnLoad.TabIndex = 7;
            this.btnLoad.Text = "Load map...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btnLoad);
            this.groupBox1.Controls.Add(this.btnRandom);
            this.groupBox1.Location = new System.Drawing.Point(724, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 182);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Map";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(6, 136);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(101, 33);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(6, 97);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(101, 33);
            this.btnRandom.TabIndex = 6;
            this.btnRandom.Text = "Preset maps...";
            this.btnRandom.UseVisualStyleBackColor = true;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbNext);
            this.groupBox2.Controls.Add(this.cmbAnimateMode);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnNext10);
            this.groupBox2.Controls.Add(this.btnNext);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.Location = new System.Drawing.Point(724, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 190);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Game";
            // 
            // cmbNext
            // 
            this.cmbNext.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNext.FormattingEnabled = true;
            this.cmbNext.Location = new System.Drawing.Point(73, 154);
            this.cmbNext.Name = "cmbNext";
            this.cmbNext.Size = new System.Drawing.Size(37, 21);
            this.cmbNext.TabIndex = 6;
            // 
            // cmbAnimateMode
            // 
            this.cmbAnimateMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimateMode.FormattingEnabled = true;
            this.cmbAnimateMode.Location = new System.Drawing.Point(9, 81);
            this.cmbAnimateMode.Name = "cmbAnimateMode";
            this.cmbAnimateMode.Size = new System.Drawing.Size(101, 21);
            this.cmbAnimateMode.TabIndex = 5;
            this.cmbAnimateMode.SelectedIndexChanged += new System.EventHandler(this.cmbAnimateMode_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Animate mode";
            // 
            // btnNext10
            // 
            this.btnNext10.Location = new System.Drawing.Point(9, 147);
            this.btnNext10.Name = "btnNext10";
            this.btnNext10.Size = new System.Drawing.Size(58, 33);
            this.btnNext10.TabIndex = 3;
            this.btnNext10.Text = "Next +=";
            this.btnNext10.UseVisualStyleBackColor = true;
            this.btnNext10.Click += new System.EventHandler(this.btnNext10_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(9, 108);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(101, 33);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next++";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(733, 646);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(101, 33);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "About...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbGridView);
            this.groupBox3.Location = new System.Drawing.Point(727, 454);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(121, 49);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "View";
            // 
            // cbGridView
            // 
            this.cbGridView.AutoSize = true;
            this.cbGridView.Checked = true;
            this.cbGridView.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbGridView.Location = new System.Drawing.Point(6, 19);
            this.cbGridView.Name = "cbGridView";
            this.cbGridView.Size = new System.Drawing.Size(45, 17);
            this.cbGridView.TabIndex = 0;
            this.cbGridView.Text = "Grid";
            this.cbGridView.UseVisualStyleBackColor = true;
            this.cbGridView.CheckedChanged += new System.EventHandler(this.cbGridView_CheckedChanged);
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(733, 607);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(101, 33);
            this.btnSettings.TabIndex = 12;
            this.btnSettings.Text = "Settings...";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 730);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.cmbSceneMode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = " Conway\'s Game of Life";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmMain_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSceneMode;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnNext10;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.ComboBox cmbAnimateMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbGridView;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ComboBox cmbNext;
        private System.Windows.Forms.Button btnSettings;
    }
}

