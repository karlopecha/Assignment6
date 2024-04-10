using System.Numerics;
using System.Runtime.Serialization.Formatters.Binary;

namespace Assignment6
{
    public partial class Form1 : Form
    {
        HockeyPlayer[] players;
        //int counter;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            HockeyPlayer player = new HockeyPlayer(txtPlayerName.Text, txtJerseryNo.Text) { GoalsScored = int.TryParse(txtGoals.Text, out int gInt) ? gInt : 0 };
            listBoxPlayers.Items.Add(player);
            CleartTextBoxes();
        }

        private void CleartTextBoxes()
        {
            txtPlayerName.Text = txtJerseryNo.Text = txtGoals.Text = string.Empty;
        }

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
            if (listBoxPlayers.SelectedItem != null)
            {
                HockeyPlayer player = (HockeyPlayer)listBoxPlayers.SelectedItem;

                txtPlayerName.Text = player.Name;
                txtJerseryNo.Text = player.JerseyNumber.ToString();
                txtGoals.Text = player.GoalsScored.ToString();

                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;
            }
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
            openFileDialog1.ShowDialog(this);
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog(this);
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string file = openFileDialog1.FileName;

            using (FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read))
            {
                BinaryFormatter bf = new BinaryFormatter();
                listBoxPlayers.Items.Clear();
                while (fs.Position < fs.Length)
                {
                    listBoxPlayers.Items.Add(bf.Deserialize(fs));
                }
            }
        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            string file = saveFileDialog1.FileName;
            using (FileStream fs = new FileStream(file, FileMode.Create, FileAccess.Write))
            {
                BinaryFormatter bf = new BinaryFormatter();
                foreach (var item in listBoxPlayers.Items)
                {
                    bf.Serialize(fs, item);
                }
            }
        }
    }
}