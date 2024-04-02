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
            rtxtShowAll.Text = $"PLAYER\t\t\t\tJERSEY #\t\tGOALS{Environment.NewLine}";

            Array.Sort(players);
            foreach (var player in players)
            {
                if (player != null)
                {
                    rtxtShowAll.Text += $"{player.Name}\t\t\t\t{player.JerseyNumber}\t\t{player.GoalsScored}{Environment.NewLine}";
                }
            }
        }
    }
}