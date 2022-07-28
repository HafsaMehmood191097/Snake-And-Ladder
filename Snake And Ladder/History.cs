using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Snake_And_Ladder
{
    public partial class History : Form
    {
        public History()
        {
            InitializeComponent();
        }

        private void History_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-B1KA2US;Initial Catalog=snake_and_ladder;Integrated Security=True");
            con.Open();
            SqlDataAdapter da = new SqlDataAdapter("select *from players_data;select *from winner_data", con);
           
            DataSet ds = new DataSet();
            
            da.Fill(ds, "players_data");
            da.Fill(ds, "winner_data");
            dataGridView1.DataSource = ds.Tables["players_data"].DefaultView;

            dataGridView1.DataSource = ds.Tables["winner_data"].DefaultView;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Players p = new Players();
            p.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
