namespace Assignment6
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.txtJerseryNo = new System.Windows.Forms.TextBox();
            this.txtGoals = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.gboxSort = new System.Windows.Forms.GroupBox();
            this.chkDesc = new System.Windows.Forms.CheckBox();
            this.rbtnGoal = new System.Windows.Forms.RadioButton();
            this.rbtnJersey = new System.Windows.Forms.RadioButton();
            this.rbtnName = new System.Windows.Forms.RadioButton();
            this.listBoxPlayers = new System.Windows.Forms.ListBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.menuFile = new System.Windows.Forms.MenuStrip();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gboxSort.SuspendLayout();
            this.menuFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(12, 38);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.PlaceholderText = "Player Name";
            this.txtPlayerName.Size = new System.Drawing.Size(204, 23);
            this.txtPlayerName.TabIndex = 1;
            // 
            // txtJerseryNo
            // 
            this.txtJerseryNo.Location = new System.Drawing.Point(222, 38);
            this.txtJerseryNo.Name = "txtJerseryNo";
            this.txtJerseryNo.PlaceholderText = "Jersey Number";
            this.txtJerseryNo.Size = new System.Drawing.Size(91, 23);
            this.txtJerseryNo.TabIndex = 2;
            // 
            // txtGoals
            // 
            this.txtGoals.Location = new System.Drawing.Point(319, 38);
            this.txtGoals.Name = "txtGoals";
            this.txtGoals.PlaceholderText = "Goals Scored";
            this.txtGoals.Size = new System.Drawing.Size(80, 23);
            this.txtGoals.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(405, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(90, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Player";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // gboxSort
            // 
            this.gboxSort.Controls.Add(this.chkDesc);
            this.gboxSort.Controls.Add(this.rbtnGoal);
            this.gboxSort.Controls.Add(this.rbtnJersey);
            this.gboxSort.Controls.Add(this.rbtnName);
            this.gboxSort.Location = new System.Drawing.Point(12, 95);
            this.gboxSort.Name = "gboxSort";
            this.gboxSort.Size = new System.Drawing.Size(483, 46);
            this.gboxSort.TabIndex = 6;
            this.gboxSort.TabStop = false;
            this.gboxSort.Text = "Sort by";
            // 
            // chkDesc
            // 
            this.chkDesc.AutoSize = true;
            this.chkDesc.Location = new System.Drawing.Point(356, 21);
            this.chkDesc.Name = "chkDesc";
            this.chkDesc.Size = new System.Drawing.Size(121, 19);
            this.chkDesc.TabIndex = 3;
            this.chkDesc.Text = "Descending Order";
            this.chkDesc.UseVisualStyleBackColor = true;
            this.chkDesc.CheckedChanged += new System.EventHandler(this.chkDesc_CheckedChanged);
            // 
            // rbtnGoal
            // 
            this.rbtnGoal.AutoSize = true;
            this.rbtnGoal.Location = new System.Drawing.Point(178, 21);
            this.rbtnGoal.Name = "rbtnGoal";
            this.rbtnGoal.Size = new System.Drawing.Size(93, 19);
            this.rbtnGoal.TabIndex = 2;
            this.rbtnGoal.TabStop = true;
            this.rbtnGoal.Text = "Goals Scored";
            this.rbtnGoal.UseVisualStyleBackColor = true;
            this.rbtnGoal.CheckedChanged += new System.EventHandler(this.rbtnGoal_CheckedChanged);
            // 
            // rbtnJersey
            // 
            this.rbtnJersey.AutoSize = true;
            this.rbtnJersey.Location = new System.Drawing.Point(69, 21);
            this.rbtnJersey.Name = "rbtnJersey";
            this.rbtnJersey.Size = new System.Drawing.Size(103, 19);
            this.rbtnJersey.TabIndex = 1;
            this.rbtnJersey.TabStop = true;
            this.rbtnJersey.Text = "Jersey Number";
            this.rbtnJersey.UseVisualStyleBackColor = true;
            this.rbtnJersey.CheckedChanged += new System.EventHandler(this.rbtnJersey_CheckedChanged);
            // 
            // rbtnName
            // 
            this.rbtnName.AutoSize = true;
            this.rbtnName.Location = new System.Drawing.Point(6, 21);
            this.rbtnName.Name = "rbtnName";
            this.rbtnName.Size = new System.Drawing.Size(57, 19);
            this.rbtnName.TabIndex = 0;
            this.rbtnName.TabStop = true;
            this.rbtnName.Text = "Name";
            this.rbtnName.UseVisualStyleBackColor = true;
            this.rbtnName.CheckedChanged += new System.EventHandler(this.rbtnName_CheckedChanged);
            // 
            // listBoxPlayers
            // 
            this.listBoxPlayers.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBoxPlayers.FormattingEnabled = true;
            this.listBoxPlayers.ItemHeight = 15;
            this.listBoxPlayers.Location = new System.Drawing.Point(12, 147);
            this.listBoxPlayers.Name = "listBoxPlayers";
            this.listBoxPlayers.Size = new System.Drawing.Size(483, 259);
            this.listBoxPlayers.TabIndex = 7;
            this.listBoxPlayers.DoubleClick += new System.EventHandler(this.listBoxPlayers_DoubleClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(405, 66);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 23);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update Player";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // menuFile
            // 
            this.menuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.menuFile.Location = new System.Drawing.Point(0, 0);
            this.menuFile.Name = "menuFile";
            this.menuFile.Size = new System.Drawing.Size(508, 24);
            this.menuFile.TabIndex = 9;
            this.menuFile.Text = "menuStrip1";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.loadFileToolStripMenuItem.Text = "Load File";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.saveFileToolStripMenuItem.Text = "Save File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.closeToolStripMenuItem.Text = "Close";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 423);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.listBoxPlayers);
            this.Controls.Add(this.gboxSort);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGoals);
            this.Controls.Add(this.txtJerseryNo);
            this.Controls.Add(this.txtPlayerName);
            this.Controls.Add(this.menuFile);
            this.MainMenuStrip = this.menuFile;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gboxSort.ResumeLayout(false);
            this.gboxSort.PerformLayout();
            this.menuFile.ResumeLayout(false);
            this.menuFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPlayerName;
        private TextBox txtJerseryNo;
        private TextBox txtGoals;
        private Button btnAdd;
        private GroupBox gboxSort;
        private RadioButton rbtnGoal;
        private RadioButton rbtnJersey;
        private RadioButton rbtnName;
        private ListBox listBoxPlayers;
        private CheckBox chkDesc;
        private Button btnUpdate;
        private MenuStrip menuFile;
        private ToolStripMenuItem loadFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
    }
}