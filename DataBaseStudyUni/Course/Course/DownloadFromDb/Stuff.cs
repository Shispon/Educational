using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Course.DownloadFromDb
{
    public class Stuff
    {
        private readonly Npgsql.NpgsqlConnection _connectionStuff = new Npgsql.NpgsqlConnection("Server=localhost;Port=5432;Database=EducationalDB;User Id = postgres;Password=8457");

        public Dictionary<int, string> idTitleDictionaryStuff;

        public void DownStuff(DataGridView dataGridView1, System.Windows.Forms.ComboBox comboBox1, System.Windows.Forms.ComboBox comboBox2)
        {
            idTitleDictionaryStuff = new Dictionary<int, string>();
            _connectionStuff.Open();

            DataSet dataSet = new DataSet();
            Npgsql.NpgsqlDataAdapter npgsqlDataAdapter = new Npgsql.NpgsqlDataAdapter("SELECT id, title, first_name,second_name,last_name,phone_number,address,post,full_name FROM production.staff", _connectionStuff);
            npgsqlDataAdapter.Fill(dataSet);

            _connectionStuff.Close();

            // Отображаем только нужные поля в DataGridView
            dataGridView1.DataSource = dataSet.Tables[0].DefaultView.ToTable(false, "title", "first_name", "second_name", "last_name", "phone_number", "address", "post", "full_name");

            // Создаем словарь <id, title>
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string title = row["title"].ToString();
                idTitleDictionaryStuff.Add(id, title);
            }
            comboBox1.DataSource = new BindingSource(idTitleDictionaryStuff, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            comboBox2.DataSource = new BindingSource(idTitleDictionaryStuff, null);
            comboBox2.DisplayMember = "Value";
            comboBox2.ValueMember = "Key";
        }

        public void DelStuff(DataGridView dataGridView1)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            string value = dataGridViewRow.Cells["title"].Value.ToString();
            int targetValue = 0;

            foreach (var row in idTitleDictionaryStuff.Keys)
            {
                if (value == idTitleDictionaryStuff[row])
                    targetValue = row;
            }

            _connectionStuff.Open();
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("delete from production.staff where id = @id", _connectionStuff);
            command.Parameters.AddWithValue("@id", targetValue);
            command.ExecuteNonQuery();
            command.Dispose();
            _connectionStuff.Close();
        }

        public void UpdStuff(DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox textBox2, System.Windows.Forms.TextBox textBox3, System.Windows.Forms.TextBox textBox4, System.Windows.Forms.TextBox textBox5, System.Windows.Forms.TextBox textBox6, System.Windows.Forms.TextBox textBox7, System.Windows.Forms.TextBox textBox8)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            string value = dataGridViewRow.Cells["title"].Value.ToString();
            int targetValue = 0;

            foreach (var row in idTitleDictionaryStuff.Keys)
            {
                if (value == idTitleDictionaryStuff[row])
                    targetValue = row;
            }
            _connectionStuff.Open();

            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("update production.staff set title = @title, first_name = @first_name, second_name = @second_name, last_name = @last_name, phone_number = @phone_number, address = @address,post = @post  where id = @id", _connectionStuff);
            command.Parameters.AddWithValue("@id", targetValue);
            command.Parameters.AddWithValue("@title", textBox1.Text);
            command.Parameters.AddWithValue("@first_name", textBox2.Text);
            command.Parameters.AddWithValue("@second_name", textBox3.Text);
            command.Parameters.AddWithValue("@last_name", textBox4.Text);
            textBox8.Text = textBox2.Text + textBox3.Text + textBox4.Text;
            command.Parameters.AddWithValue("@phone_number", textBox5.Text);
            command.Parameters.AddWithValue("@address", textBox6.Text);
            command.Parameters.AddWithValue("@post", textBox7.Text);
            //command.Parameters.AddWithValue("@full_name", textBox8.Text);
            command.ExecuteNonQuery();
            command.Dispose();
            _connectionStuff.Close();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
        }

        public void InsStuff(DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox textBox2,System.Windows.Forms.TextBox textBox3, System.Windows.Forms.TextBox textBox4, System.Windows.Forms.TextBox textBox5, System.Windows.Forms.TextBox textBox6, System.Windows.Forms.TextBox textBox7, System.Windows.Forms.TextBox textBox8)
        {
            _connectionStuff.Open();
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("insert into production.staff( title, first_name,second_name,last_name,phone_number,address,post) values(@title, @first_name,@second_name,@last_name,@phone_number,@address,@post)", _connectionStuff);

            command.Parameters.AddWithValue("@title", textBox1.Text);
            command.Parameters.AddWithValue("@first_name", textBox2.Text);
            command.Parameters.AddWithValue("@second_name", textBox3.Text);
            command.Parameters.AddWithValue("@last_name", textBox4.Text);
            command.Parameters.AddWithValue("@phone_number", textBox5.Text);
            command.Parameters.AddWithValue("@address", textBox6.Text);
            command.Parameters.AddWithValue("@post", textBox7.Text);
            //command.Parameters.AddWithValue("@full_name", textBox8.Text);
            command.ExecuteNonQuery();
            command.Dispose();
            _connectionStuff.Close();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;
            textBox7.Text = string.Empty;
            textBox8.Text = string.Empty;
        }

        public void DoubleClick(DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox textBox2,System.Windows.Forms.TextBox textBox3, System.Windows.Forms.TextBox textBox4, System.Windows.Forms.TextBox textBox5, System.Windows.Forms.TextBox textBox6, System.Windows.Forms.TextBox textBox7, System.Windows.Forms.TextBox textBox8)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            textBox1.Text = dataGridViewRow.Cells["title"].Value.ToString();
            textBox2.Text = dataGridViewRow.Cells["first_name"].Value.ToString();
            textBox3.Text = dataGridViewRow.Cells["second_name"].Value.ToString();
            textBox4.Text = dataGridViewRow.Cells["last_name"].Value.ToString();
            textBox5.Text = dataGridViewRow.Cells["phone_number"].Value.ToString();
            textBox6.Text = dataGridViewRow.Cells["address"].Value.ToString();
            textBox7.Text = dataGridViewRow.Cells["post"].Value.ToString();
            textBox8.Text = dataGridViewRow.Cells["full_name"].Value.ToString();

        }
    }
}
