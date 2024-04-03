using System.Numerics;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        HockeyPlayer[] players;
        int counter;
        public Form1()
        {
            InitializeComponent();

            players = new HockeyPlayer[30];
            counter = 30;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HockeyPlayer player = new HockeyPlayer(txtPlayerName.Text, txtJerseryNo.Text) { GoalsScored = txtGoals.Text };
            if (counter >= 0)
            {
                players[counter - 1] = player;
                counter--;

                MessageBox.Show($"{player.Name} added.");
                CleartTextBoxes();
            }
        }

        private void CleartTextBoxes()
        {
            txtPlayerName.Text = txtJerseryNo.Text = txtGoals.Text = string.Empty;
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            rtxtShowAll.Text = $"{"PLAYER",-40}{"JERSEY #",8}{"GOALS",6}{Environment.NewLine}";

            Array.Sort(players);
            foreach (var player in players)
            {
                if (player != null)
                {
                    rtxtShowAll.Text += $"{player.Name, -40}{player.JerseyNumber, 8}{player.GoalsScored, 6}{Environment.NewLine}";
                }
            }
        }

        private void rbtnName_CheckedChanged(object sender, EventArgs e)
        {
            HockeyPlayer.SortBy = "A";
        }

        private void rbtnJersey_CheckedChanged(object sender, EventArgs e)
        {
            HockeyPlayer.SortBy = "J";
        }

        private void rbtnGoal_CheckedChanged(object sender, EventArgs e)
        {
            HockeyPlayer.SortBy = "G";
        }
    }
}