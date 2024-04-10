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
            txtPlayerName = new TextBox();
            txtJerseryNo = new TextBox();
            txtGoals = new TextBox();
            btnAdd = new Button();
            gboxSort = new GroupBox();
            chkDesc = new CheckBox();
            rbtnGoal = new RadioButton();
            rbtnJersey = new RadioButton();
            rbtnName = new RadioButton();
            listBoxPlayers = new ListBox();
            btnUpdate = new Button();
            menuFile = new MenuStrip();
            loadFileToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            gboxSort.SuspendLayout();
            menuFile.SuspendLayout();
            SuspendLayout();
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(12, 38);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.PlaceholderText = "Player Name";
            txtPlayerName.Size = new Size(204, 23);
            txtPlayerName.TabIndex = 4;
            // 
            // txtJerseryNo
            // 
            txtJerseryNo.Location = new Point(222, 38);
            txtJerseryNo.Name = "txtJerseryNo";
            txtJerseryNo.PlaceholderText = "Jersey Number";
            txtJerseryNo.Size = new Size(91, 23);
            txtJerseryNo.TabIndex = 2;
            // 
            // txtGoals
            // 
            txtGoals.Location = new Point(319, 38);
            txtGoals.Name = "txtGoals";
            txtGoals.PlaceholderText = "Goals Scored";
            txtGoals.Size = new Size(80, 23);
            txtGoals.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(405, 37);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add Player";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // gboxSort
            // 
            gboxSort.Controls.Add(chkDesc);
            gboxSort.Controls.Add(rbtnGoal);
            gboxSort.Controls.Add(rbtnJersey);
            gboxSort.Controls.Add(rbtnName);
            gboxSort.Location = new Point(12, 95);
            gboxSort.Name = "gboxSort";
            gboxSort.Size = new Size(483, 46);
            gboxSort.TabIndex = 6;
            gboxSort.TabStop = false;
            gboxSort.Text = "Sort by";
            // 
            // chkDesc
            // 
            chkDesc.AutoSize = true;
            chkDesc.Location = new Point(356, 21);
            chkDesc.Name = "chkDesc";
            chkDesc.Size = new Size(121, 19);
            chkDesc.TabIndex = 3;
            chkDesc.Text = "Descending Order";
            chkDesc.UseVisualStyleBackColor = true;
            chkDesc.CheckedChanged += chkDesc_CheckedChanged;
            // 
            // rbtnGoal
            // 
            rbtnGoal.AutoSize = true;
            rbtnGoal.Location = new Point(178, 21);
            rbtnGoal.Name = "rbtnGoal";
            rbtnGoal.Size = new Size(93, 19);
            rbtnGoal.TabIndex = 2;
            rbtnGoal.TabStop = true;
            rbtnGoal.Text = "Goals Scored";
            rbtnGoal.UseVisualStyleBackColor = true;
            rbtnGoal.CheckedChanged += rbtnGoal_CheckedChanged;
            // 
            // rbtnJersey
            // 
            rbtnJersey.AutoSize = true;
            rbtnJersey.Location = new Point(69, 21);
            rbtnJersey.Name = "rbtnJersey";
            rbtnJersey.Size = new Size(103, 19);
            rbtnJersey.TabIndex = 1;
            rbtnJersey.TabStop = true;
            rbtnJersey.Text = "Jersey Number";
            rbtnJersey.UseVisualStyleBackColor = true;
            rbtnJersey.CheckedChanged += rbtnJersey_CheckedChanged;
            // 
            // rbtnName
            // 
            rbtnName.AutoSize = true;
            rbtnName.Location = new Point(6, 21);
            rbtnName.Name = "rbtnName";
            rbtnName.Size = new Size(57, 19);
            rbtnName.TabIndex = 0;
            rbtnName.TabStop = true;
            rbtnName.Text = "Name";
            rbtnName.UseVisualStyleBackColor = true;
            rbtnName.CheckedChanged += rbtnName_CheckedChanged;
            // 
            // listBoxPlayers
            // 
            listBoxPlayers.Font = new Font("Courier New", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBoxPlayers.FormattingEnabled = true;
            listBoxPlayers.ItemHeight = 15;
            listBoxPlayers.Location = new Point(12, 147);
            listBoxPlayers.Name = "listBoxPlayers";
            listBoxPlayers.Size = new Size(483, 259);
            listBoxPlayers.TabIndex = 7;
            listBoxPlayers.DoubleClick += listBoxPlayers_DoubleClick;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(405, 66);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(90, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update Player";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // menuFile
            // 
            menuFile.Items.AddRange(new ToolStripItem[] { loadFileToolStripMenuItem, saveFileToolStripMenuItem, closeToolStripMenuItem });
            menuFile.Location = new Point(0, 0);
            menuFile.Name = "menuFile";
            menuFile.Size = new Size(508, 24);
            menuFile.TabIndex = 9;
            menuFile.Text = "menuStrip1";
            // 
            // loadFileToolStripMenuItem
            // 
            loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            loadFileToolStripMenuItem.Size = new Size(66, 20);
            loadFileToolStripMenuItem.Text = "Load File";
            loadFileToolStripMenuItem.Click += loadFileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(64, 20);
            saveFileToolStripMenuItem.Text = "Save File";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(48, 20);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 423);
            Controls.Add(btnUpdate);
            Controls.Add(listBoxPlayers);
            Controls.Add(gboxSort);
            Controls.Add(btnAdd);
            Controls.Add(txtGoals);
            Controls.Add(txtJerseryNo);
            Controls.Add(txtPlayerName);
            Controls.Add(menuFile);
            MainMenuStrip = menuFile;
            Name = "Form1";
            Text = "Form1";
            gboxSort.ResumeLayout(false);
            gboxSort.PerformLayout();
            menuFile.ResumeLayout(false);
            menuFile.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;
    }
}