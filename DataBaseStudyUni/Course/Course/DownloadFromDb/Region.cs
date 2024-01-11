using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.DownloadFromDb
{
    public class Region
    {
        private readonly Npgsql.NpgsqlConnection _connectionRegion = new Npgsql.NpgsqlConnection("Server=localhost;Port=5432;Database=EducationalDB;User Id = postgres;Password=8457");

        public  Dictionary<int, string> idTitleDictionaryReg;

        public void DownReg(DataGridView dataGridView1, ComboBox comboBox1)
        {
            idTitleDictionaryReg = new Dictionary<int, string>();
           _connectionRegion.Open();

            DataSet dataSet = new DataSet();
            Npgsql.NpgsqlDataAdapter npgsqlDataAdapter = new Npgsql.NpgsqlDataAdapter("SELECT id, title FROM production.region",_connectionRegion);
            npgsqlDataAdapter.Fill(dataSet);

           _connectionRegion.Close();

            // Отображаем только нужные поля в DataGridView
            dataGridView1.DataSource = dataSet.Tables[0].DefaultView.ToTable(false, "title");

            // Создаем словарь <id, title>
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string title = row["title"].ToString();
                idTitleDictionaryReg.Add(id, title);
            }
            comboBox1.DataSource = new BindingSource(idTitleDictionaryReg, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

        }

        public void DelReg(DataGridView dataGridView1)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            string value = dataGridViewRow.Cells["title"].Value.ToString();
            int targetValue = 0;

            foreach (var row in idTitleDictionaryReg.Keys)
            {
                if (value == idTitleDictionaryReg[row])
                    targetValue = row;
            }

            _connectionRegion.Open();
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("delete from production.region where id = @id", _connectionRegion);
            command.Parameters.AddWithValue("@id", targetValue);
            command.ExecuteNonQuery();
            command.Dispose();
            _connectionRegion.Close();
        }

        public void UpdReg(DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            string value = dataGridViewRow.Cells["title"].Value.ToString();
            int targetValue = 0;

            foreach (var row in idTitleDictionaryReg.Keys)
            {
                if (value == idTitleDictionaryReg[row])
                    targetValue = row;
            }
            _connectionRegion.Open();
           
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("update production.region set title = @title where id = @id", _connectionRegion);
            command.Parameters.AddWithValue("@id", targetValue);
            command.Parameters.AddWithValue("@title", textBox1.Text);

            command.ExecuteNonQuery();
            command.Dispose();
            _connectionRegion.Close();
            textBox1.Text = string.Empty;
           

        }

        public void InsReg(DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1)
        {
            _connectionRegion.Open();
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("insert into production.region(title) values(@title)", _connectionRegion);

            command.Parameters.AddWithValue("@title", textBox1.Text);
            command.ExecuteNonQuery();
            command.Dispose();
            _connectionRegion.Close();
            textBox1.Text = string.Empty;
           
        }

        public void DoubleClick(DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            textBox1.Text = dataGridViewRow.Cells["title"].Value.ToString();
           
        }
    }
}
