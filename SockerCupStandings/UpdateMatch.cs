using System;

using System.Data;

using System.Windows.Forms;

using System.Data.SqlClient;

namespace SockerCupStandings
{
    public partial class UpdateMatch : Form
    {
        public DataGridViewRow d1;
        public Standings GMatches;
        public UpdateMatch(DataGridViewRow d, Standings Matches)
        {
            InitializeComponent();
            d1 = d;
            GMatches = Matches;
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

            comboBox1.SelectedValue = Convert.ToInt32( d.Cells["firstTeam"].Value );
            comboBox2.SelectedValue = Convert.ToInt32( d.Cells["secondTeam"].Value );
            numericUpDown1.Value = Convert.ToInt32(d.Cells["FTGoals"].Value);
            numericUpDown2.Value = Convert.ToInt32(d.Cells["STGoals"].Value);
            dateTimePicker1.Value = Convert.ToDateTime(d.Cells["matchDate"].Value);
        }

        private void insertChanges_Click(object sender, EventArgs e)
        {
            string datasource = @"LAPTOP-CP8KRCNS";
            string database = "SockerCup";
            string connString = @"Data Source=" + datasource + ";Initial Catalog=" +
            database + ";Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();

            string query1 = "update Match set firstTeam = " + comboBox1.SelectedValue + " where id = " + Convert.ToInt32(d1.Cells["id"].Value);
            string query2 = "update Match set secondTeam = " + comboBox2.SelectedValue + " where id = " + Convert.ToInt32(d1.Cells["id"].Value);
            string query3 = "update Match set FTGoals = " + numericUpDown1.Value + " where id = " + Convert.ToInt32(d1.Cells["id"].Value);
            string query4 = "update Match set STGoals = " + numericUpDown2.Value + " where id = " + Convert.ToInt32(d1.Cells["id"].Value);
            string query5 = "update Match set matchDate = '" + dateTimePicker1.Value + "' where id = " + Convert.ToInt32(d1.Cells["id"].Value);


            SqlCommand command = new SqlCommand(query1, conn);
            command.ExecuteNonQuery();
            command = new SqlCommand(query2, conn);
            command.ExecuteNonQuery();
            command = new SqlCommand(query3, conn);
            command.ExecuteNonQuery();
            command = new SqlCommand(query4, conn);
            command.ExecuteNonQuery();
            command = new SqlCommand(query5, conn);
            command.ExecuteNonQuery();

            GMatches.updateMatchs();
            MessageBox.Show("Запись успешно изменена");
            conn.Close();
        }
    }
}
