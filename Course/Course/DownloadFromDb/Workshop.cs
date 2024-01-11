using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.DownloadFromDb
{
    public class Workshop
    {
        private readonly Npgsql.NpgsqlConnection _connectionWorkshop = new Npgsql.NpgsqlConnection("Server=localhost;Port=5432;Database=EducationalDB;User Id = postgres;Password=8457");

        public Dictionary<int, string> idTitleDictionaryWork;

        public void DownWork(DataGridView dataGridView1)
        {
            idTitleDictionaryWork = new Dictionary<int, string>();
            _connectionWorkshop.Open();

            DataSet dataSet = new DataSet();
            Npgsql.NpgsqlDataAdapter npgsqlDataAdapter = new Npgsql.NpgsqlDataAdapter("SELECT id, title, chef_name FROM production.workshop", _connectionWorkshop);
            npgsqlDataAdapter.Fill(dataSet);

            _connectionWorkshop.Close();

            // Отображаем только нужные поля в DataGridView
            dataGridView1.DataSource = dataSet.Tables[0].DefaultView.ToTable(false, "title", "chef_name");

            // Создаем словарь <id, title>
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string title = row["title"].ToString();
                idTitleDictionaryWork.Add(id, title);
            }
            //comboBox1.DataSource = new BindingSource(idTitleDictionaryReg, null);
            //comboBox1.DisplayMember = "Value";
            //comboBox1.ValueMember = "Key";

        }

        public void DelWork(DataGridView dataGridView1)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            string value = dataGridViewRow.Cells["title"].Value.ToString();
            int targetValue = 0;

            foreach (var row in idTitleDictionaryWork.Keys)
            {
                if (value == idTitleDictionaryWork[row])
                    targetValue = row;
            }

            _connectionWorkshop.Open();
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("delete from production.workshop where id = @id", _connectionWorkshop);
            command.Parameters.AddWithValue("@id", targetValue);
            command.ExecuteNonQuery();
            command.Dispose();
            _connectionWorkshop.Close();
        }

        public void UpdWork(DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox textBox2)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            string value = dataGridViewRow.Cells["title"].Value.ToString();
            int targetValue = 0;

            foreach (var row in idTitleDictionaryWork.Keys)
            {
                if (value == idTitleDictionaryWork[row])
                    targetValue = row;
            }
            _connectionWorkshop.Open();

            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("update production.workshop set title = @title, chef_name = @chef_name where id = @id", _connectionWorkshop);
            command.Parameters.AddWithValue("@id", targetValue);
            command.Parameters.AddWithValue("@title", textBox1.Text);
            command.Parameters.AddWithValue("@chef_name", textBox2.Text);
            command.ExecuteNonQuery();
            command.Dispose();
            _connectionWorkshop.Close();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;


        }

        public void InsWork(DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox textBox2)
        {
            _connectionWorkshop.Open();
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("insert into production.workshop(title, chef_name) values(@title, @chef_name)", _connectionWorkshop);

            command.Parameters.AddWithValue("@title", textBox1.Text);
            command.Parameters.AddWithValue("@chef_name", textBox2.Text);
            command.ExecuteNonQuery();
            command.Dispose();
            _connectionWorkshop.Close();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        public void DoubleClick(DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox textBox2)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            textBox1.Text = dataGridViewRow.Cells["title"].Value.ToString();
            textBox2.Text = dataGridViewRow.Cells["chef_name"].Value.ToString();

        }
    }
}
