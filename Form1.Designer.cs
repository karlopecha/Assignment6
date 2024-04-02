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
            rtxtShowAll = new RichTextBox();
            btnShowAll = new Button();
            SuspendLayout();
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(12, 12);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.PlaceholderText = "Player Name";
            txtPlayerName.Size = new Size(204, 23);
            txtPlayerName.TabIndex = 0;
            // 
            // txtJerseryNo
            // 
            txtJerseryNo.Location = new Point(222, 12);
            txtJerseryNo.Name = "txtJerseryNo";
            txtJerseryNo.PlaceholderText = "Jersey #";
            txtJerseryNo.Size = new Size(100, 23);
            txtJerseryNo.TabIndex = 1;
            // 
            // txtGoals
            // 
            txtGoals.Location = new Point(328, 12);
            txtGoals.Name = "txtGoals";
            txtGoals.PlaceholderText = "Goals";
            txtGoals.Size = new Size(100, 23);
            txtGoals.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(434, 12);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add Player";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // rtxtShowAll
            // 
            rtxtShowAll.Location = new Point(12, 107);
            rtxtShowAll.Name = "rtxtShowAll";
            rtxtShowAll.Size = new Size(497, 257);
            rtxtShowAll.TabIndex = 4;
            rtxtShowAll.Text = "";
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(12, 78);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(132, 23);
            btnShowAll.TabIndex = 5;
            btnShowAll.Text = "Show All Players";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(520, 376);
            Controls.Add(btnShowAll);
            Controls.Add(rtxtShowAll);
            Controls.Add(btnAdd);
            Controls.Add(txtGoals);
            Controls.Add(txtJerseryNo);
            Controls.Add(txtPlayerName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPlayerName;
        private TextBox txtJerseryNo;
        private TextBox txtGoals;
        private Button btnAdd;
        private RichTextBox rtxtShowAll;
        private Button btnShowAll;
    }
}