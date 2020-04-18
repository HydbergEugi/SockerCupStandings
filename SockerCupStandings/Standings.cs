using System;

using System.Data;

using System.Windows.Forms;

using System.Data.SqlClient;

namespace SockerCupStandings
{
    public partial class Standings : Form
    {
        public Autorization GAutoForm;
        public Standings(Autorization AutoForm)
        {
            InitializeComponent();
            GAutoForm = AutoForm;
            this.FormClosing += AppClose;
            updateMatchs();
        }

        public void updateMatchs()
        {
            string datasource = @"LAPTOP-CP8KRCNS";
            string database = "SockerCup";
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" +
            database + ";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string query1 = "select M.id, M.firstTeam,  S1.name as T1, M.FTGoals, M.STGoals, M.secondTeam, S2.name as T2, M.matchDate from Match M inner join Standings" +
            " as S1 on M.firstTeam = S1.id inner join Standings as S2 on M.secondTeam = S2.id ";
            SqlCommand command = new SqlCommand(query1, conn);
            SqlDataReader dr = command.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["id"].Visible = false;
            dataGridView1.Columns["firstTeam"].Visible = false;
            dataGridView1.Columns["secondTeam"].Visible = false;
            dataGridView1.Columns["T1"].HeaderText = "Команда 1";
            dataGridView1.Columns["T2"].HeaderText = "Команда 2";
            dataGridView1.Columns["FTGoals"].HeaderText = "Голы 1-й команды";
            dataGridView1.Columns["STGoals"].HeaderText = "Голы 2-й команды";
            dataGridView1.Columns["matchDate"].HeaderText = "Дата встречи";

            query1 = "select * from Standings order by score desc, goals desc";
            command = new SqlCommand(query1, conn);
            dr = command.ExecuteReader();
            dt = new DataTable();
            dt.Load(dr);
            dataGridView2.DataSource = dt;
            dataGridView2.Columns["name"].HeaderText = "Команда";
            dataGridView2.Columns["playCount"].HeaderText = "Игры";
            dataGridView2.Columns["wins"].HeaderText = "Победы";
            dataGridView2.Columns["draws"].HeaderText = "Ничьи";
            dataGridView2.Columns["defeats"].HeaderText = "Проигрыши";
            dataGridView2.Columns["goals"].HeaderText = "Забито";
            dataGridView2.Columns["missed"].HeaderText = "Пропущено";
            dataGridView2.Columns["difference"].HeaderText = "Разница";
            dataGridView2.Columns["score"].HeaderText = "Очки";
            dataGridView2.Columns["id"].Visible = false;
        }
        private void insertMatch_Click(object sender, EventArgs e)
        {
            InsertMatch insertMatch = new InsertMatch(this);
            insertMatch.Show();
        }

        private void UpdateMatch_Click(object sender, EventArgs e)
        {
            UpdateMatch change_match = new UpdateMatch(dataGridView1.CurrentRow, this);
            change_match.Show();
        }

        private void DeleteMatch_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно желаете удалить данную запись?", "Удаление записи",
               MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string datasource = @"LAPTOP-CP8KRCNS";
                string database = "SockerCup";
                string connString = @"Data Source=" + datasource + ";Initial Catalog=" +
                database + ";Integrated Security=True";


                SqlConnection conn = new SqlConnection(connString);
                conn.Open();
                string query = "DELETE FROM Match WHERE id = " + dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["id"].Value.ToString();

                SqlCommand command = new SqlCommand(query, conn);
                command.ExecuteNonQuery();
                conn.Close();
                updateMatchs();
                MessageBox.Show("Запись успешно удалена");
            }
        }

        private void AppClose(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Выход",
               MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                GAutoForm.Close();
            }
        }

    }
}
