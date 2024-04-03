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
            this.rtxtShowAll = new System.Windows.Forms.RichTextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.gboxSort = new System.Windows.Forms.GroupBox();
            this.rbtnGoal = new System.Windows.Forms.RadioButton();
            this.rbtnJersey = new System.Windows.Forms.RadioButton();
            this.rbtnName = new System.Windows.Forms.RadioButton();
            this.gboxSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(12, 12);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.PlaceholderText = "Player Name";
            this.txtPlayerName.Size = new System.Drawing.Size(204, 23);
            this.txtPlayerName.TabIndex = 1;
            // 
            // txtJerseryNo
            // 
            this.txtJerseryNo.Location = new System.Drawing.Point(222, 12);
            this.txtJerseryNo.Name = "txtJerseryNo";
            this.txtJerseryNo.PlaceholderText = "Jersey #";
            this.txtJerseryNo.Size = new System.Drawing.Size(100, 23);
            this.txtJerseryNo.TabIndex = 2;
            // 
            // txtGoals
            // 
            this.txtGoals.Location = new System.Drawing.Point(328, 12);
            this.txtGoals.Name = "txtGoals";
            this.txtGoals.PlaceholderText = "Goals";
            this.txtGoals.Size = new System.Drawing.Size(100, 23);
            this.txtGoals.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(434, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 4;
            this.btnAdd.Text = "Add Player";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // rtxtShowAll
            // 
            this.rtxtShowAll.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtxtShowAll.Location = new System.Drawing.Point(11, 145);
            this.rtxtShowAll.Name = "rtxtShowAll";
            this.rtxtShowAll.ReadOnly = true;
            this.rtxtShowAll.Size = new System.Drawing.Size(497, 257);
            this.rtxtShowAll.TabIndex = 0;
            this.rtxtShowAll.Text = "";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(377, 116);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(132, 23);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.Text = "Show All Players";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // gboxSort
            // 
            this.gboxSort.Controls.Add(this.rbtnGoal);
            this.gboxSort.Controls.Add(this.rbtnJersey);
            this.gboxSort.Controls.Add(this.rbtnName);
            this.gboxSort.Location = new System.Drawing.Point(13, 93);
            this.gboxSort.Name = "gboxSort";
            this.gboxSort.Size = new System.Drawing.Size(358, 46);
            this.gboxSort.TabIndex = 6;
            this.gboxSort.TabStop = false;
            this.gboxSort.Text = "Sort by";
            // 
            // rbtnGoal
            // 
            this.rbtnGoal.AutoSize = true;
            this.rbtnGoal.Location = new System.Drawing.Point(258, 21);
            this.rbtnGoal.Name = "rbtnGoal";
            this.rbtnGoal.Size = new System.Drawing.Size(54, 19);
            this.rbtnGoal.TabIndex = 2;
            this.rbtnGoal.TabStop = true;
            this.rbtnGoal.Text = "Goals";
            this.rbtnGoal.UseVisualStyleBackColor = true;
            this.rbtnGoal.CheckedChanged += new System.EventHandler(this.rbtnGoal_CheckedChanged);
            // 
            // rbtnJersey
            // 
            this.rbtnJersey.AutoSize = true;
            this.rbtnJersey.Location = new System.Drawing.Point(111, 21);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 414);
            this.Controls.Add(this.gboxSort);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.rtxtShowAll);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtGoals);
            this.Controls.Add(this.txtJerseryNo);
            this.Controls.Add(this.txtPlayerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gboxSort.ResumeLayout(false);
            this.gboxSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPlayerName;
        private TextBox txtJerseryNo;
        private TextBox txtGoals;
        private Button btnAdd;
        private RichTextBox rtxtShowAll;
        private Button btnShowAll;
        private GroupBox gboxSort;
        private RadioButton rbtnGoal;
        private RadioButton rbtnJersey;
        private RadioButton rbtnName;
    }
}