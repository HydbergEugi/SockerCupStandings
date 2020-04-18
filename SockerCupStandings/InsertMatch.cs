using System;

using System.Data;

using System.Windows.Forms;

using System.Data.SqlClient;

namespace SockerCupStandings
{
    public partial class InsertMatch : Form
    {
        Standings GMatchs;
        public InsertMatch(Standings Matchs)
        {
            GMatchs = Matchs;
            InitializeComponent();
            string datasource = @"LAPTOP-CP8KRCNS";
            string database = "SockerCup";
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" +
            database + ";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string query1 = "select id, name from Standings;";
            SqlCommand command = new SqlCommand(query1, conn);
            SqlDataAdapter adapt = new SqlDataAdapter(command);
            DataSet dt1 = new DataSet();
            DataSet dt2 = new DataSet();
            adapt.Fill(dt1);
            adapt.Fill(dt2);

            comboBox1.DataSource = dt1.Tables[0].DefaultView;
            comboBox1.Name = "teamOne";
            comboBox1.DisplayMember = "name";
            comboBox1.ValueMember = "id";

            comboBox2.DataSource = dt2.Tables[0].DefaultView;
            comboBox2.Name = "teamTwo";
            comboBox2.DisplayMember = "name";
            comboBox2.ValueMember = "id";

        }

        private void insertValues_Click(object sender, EventArgs e)
        {
            string datasource = @"LAPTOP-CP8KRCNS";
            string database = "SockerCup";
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" +
            database + ";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            int selected_type = Convert.ToInt32(comboBox1.SelectedValue);

            string query = "INSERT INTO Match(firstTeam, secondTeam, FTGoals, STGoals, matchDate) VALUES (" + Convert.ToInt32(comboBox1.SelectedValue) + "," + Convert.ToInt32(comboBox2.SelectedValue) + 
                            "," + numericUpDown1.Value + "," + numericUpDown2.Value + "," + "'" + dateTimePicker1.Value + "'" + ");";
            SqlCommand command = new SqlCommand(query, conn);
            command.ExecuteNonQuery();

            GMatchs.updateMatchs();
            MessageBox.Show("Запись успешно добавлена");
        }
    }
}
