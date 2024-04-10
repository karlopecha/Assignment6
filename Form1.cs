using System.Numerics;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        HockeyPlayer[] players;
        //int counter;
        public Form1()
        {
            InitializeComponent();

            //players = new HockeyPlayer[30];
            //counter = 30;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HockeyPlayer player = new HockeyPlayer(txtPlayerName.Text, txtJerseryNo.Text) { GoalsScored = int.TryParse(txtGoals.Text, out int gInt) ? gInt : 0 };
            listBoxPlayers.Items.Add(player);
            CleartTextBoxes();

            //if (counter >= 0)
            //{
            //    players[counter - 1] = player;
            //    counter--;

            //    MessageBox.Show($"{player.Name} added.");
            //    CleartTextBoxes();
            //}
        }

        private void CleartTextBoxes()
        {
            txtPlayerName.Text = txtJerseryNo.Text = txtGoals.Text = string.Empty;
        }

        //private void btnShowAll_Click(object sender, EventArgs e)
        //{
        //    rtxtShowAll.Text = $"{"PLAYER",-40}{"JERSEY #",8}{"GOALS",6}{Environment.NewLine}";

        //    Array.Sort(players);
        //    foreach (var player in players)
        //    {
        //        if (player != null)
        //        {
        //            rtxtShowAll.Text += $"{player.Name, -40}{player.JerseyNumber, 8}{player.GoalsScored, 6}{Environment.NewLine}";
        //        }
        //    }
        //}

        private void rbtnName_CheckedChanged(object sender, EventArgs e)
        {
            SortBy("A", chkDesc.Checked);
        }

        private void rbtnJersey_CheckedChanged(object sender, EventArgs e)
        {
            SortBy("J", chkDesc.Checked);
        }

        private void rbtnGoal_CheckedChanged(object sender, EventArgs e)
        {
            SortBy("G", chkDesc.Checked);
        }

        private void SortBy(string sortBy, bool isDesc)
        {
            HockeyPlayer.SortBy = sortBy;

            players = new HockeyPlayer[listBoxPlayers.Items.Count];
            listBoxPlayers.Items.CopyTo(players, 0);
            Array.Sort(players);

            if (isDesc) Array.Reverse(players);

            listBoxPlayers.Items.Clear();
            listBoxPlayers.Items.AddRange(players);
        }

        private void chkDesc_CheckedChanged(object sender, EventArgs e)
        {
            SortBy(HockeyPlayer.SortBy, chkDesc.Checked);
        }

        private void listBoxPlayers_DoubleClick(object sender, EventArgs e)
        {
            HockeyPlayer player = (HockeyPlayer)listBoxPlayers.SelectedItem;

            txtPlayerName.Text = player.Name;
            txtJerseryNo.Text = player.JerseyNumber.ToString();
            txtGoals.Text = player.GoalsScored.ToString();

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            HockeyPlayer player = new HockeyPlayer(txtPlayerName.Text, txtJerseryNo.Text) { GoalsScored = int.TryParse(txtGoals.Text, out int gInt) ? gInt : 0 };
            int index = listBoxPlayers.SelectedIndex;

            listBoxPlayers.Items.RemoveAt(index);
            listBoxPlayers.Items.Insert(index, player);

            CleartTextBoxes();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
        }
    }
}