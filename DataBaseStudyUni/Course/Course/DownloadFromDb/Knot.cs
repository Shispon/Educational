using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.DownloadFromDb
{
    

    public class Knot
    {
        private readonly Npgsql.NpgsqlConnection _connectionKnot = new Npgsql.NpgsqlConnection("Server=localhost;Port=5432;Database=EducationalDB;User Id = postgres;Password=8457");

        private Dictionary<int, string> idTitleDictionary;
       
        public void DownKnot(DataGridView dataGridView1)
        {

            //Region region = new Region();
            idTitleDictionary = new Dictionary<int, string>();
            _connectionKnot.Open();

            DataSet dataSet = new DataSet();
            Npgsql.NpgsqlDataAdapter npgsqlDataAdapter = new Npgsql.NpgsqlDataAdapter("SELECT id, title, cost, region_id FROM production.knot", _connectionKnot);
            npgsqlDataAdapter.Fill(dataSet);

            _connectionKnot.Close();

            // Отображаем только нужные поля в DataGridView
            dataGridView1.DataSource = dataSet.Tables[0].DefaultView.ToTable(false, "title", "cost", "region_id");

            // Создаем словарь <id, title>
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string title = row["title"].ToString();
                idTitleDictionary.Add(id, title);
            }
            //comboBox1.DataSource = new BindingSource( idTitleDictionaryReg, null);
            //comboBox1.DisplayMember = "Value";
            //comboBox1.ValueMember = "Key";
        }

        public void DelKnot(DataGridView dataGridView1)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            string value = dataGridViewRow.Cells["title"].Value.ToString();
            int targetValue = 0;

            foreach (var row in idTitleDictionary.Keys)
            {
                if (value == idTitleDictionary[row])
                    targetValue = row;
            }
            int id = int.Parse(value);
            _connectionKnot.Open();
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("delete from production.knot where id = @id", _connectionKnot);
            command.Parameters.AddWithValue("@id", targetValue);
            command.ExecuteNonQuery();
            command.Dispose();
            _connectionKnot.Close();
        }

        public void UpdKnot(DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox textBox2, ComboBox comboBox1)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            string value = dataGridViewRow.Cells["title"].Value.ToString();
            int targetValue = 0;

            foreach (var row in idTitleDictionary.Keys)
            {
                if (value == idTitleDictionary[row])
                    targetValue = row;
            }
            _connectionKnot.Open();
           
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("update production.knot set title = @title, cost = @cost, region_id = @region_id where id = @id", _connectionKnot);
            command.Parameters.AddWithValue("@id", targetValue);
            command.Parameters.AddWithValue("@title", textBox1.Text);
            command.Parameters.AddWithValue("@cost", int.Parse(textBox2.Text));
            command.Parameters.AddWithValue("@region_id",int.Parse(comboBox1.Text));

            command.ExecuteNonQuery();
            command.Dispose();
            _connectionKnot.Close();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            comboBox1.Text = string.Empty;

        }

        public void InsKnot(DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox textBox2, ComboBox comboBox1)
        {
            _connectionKnot.Open();
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("insert into production.knot(title, cost, region_id) values(@title, @cost, @region_id)", _connectionKnot);

            command.Parameters.AddWithValue("@title", textBox1.Text);
            command.Parameters.AddWithValue("@cost", int.Parse(textBox2.Text));
            command.Parameters.AddWithValue("@region_id",(int)comboBox1.SelectedValue);
            command.ExecuteNonQuery();
            command.Dispose();
            _connectionKnot.Close();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            comboBox1.Text = string.Empty;
        }

        public void DoubleClick(DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox textBox2, ComboBox comboBox1)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            textBox1.Text = dataGridViewRow.Cells["title"].Value.ToString();
            textBox2.Text = dataGridViewRow.Cells["cost"].Value.ToString();
            comboBox1.Text = dataGridViewRow.Cells["region_id"].Value.ToString();
        }
    }
}
