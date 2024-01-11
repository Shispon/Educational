using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using Course;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Course.DownloadFromDb
{
   
    public class Product
    {
        
        private readonly Npgsql.NpgsqlConnection _connectionProduction = new Npgsql.NpgsqlConnection("Server=localhost;Port=5432;Database=EducationalDB;User Id = postgres;Password=8457");
        
        private  Dictionary<int, string> idTitleDictionaryPr ; 
        public void DownProduction(DataGridView dataGridView1, System.Windows.Forms.ComboBox comboBox1)
        {
            idTitleDictionaryPr = new Dictionary<int, string>();
            _connectionProduction.Open();

            DataSet dataSet = new DataSet();
            Npgsql.NpgsqlDataAdapter npgsqlDataAdapter = new Npgsql.NpgsqlDataAdapter("SELECT id, title, complexity, datecreated FROM production.product", _connectionProduction);
            npgsqlDataAdapter.Fill(dataSet);

            _connectionProduction.Close();

            // Отображаем только нужные поля в DataGridView
            dataGridView1.DataSource = dataSet.Tables[0].DefaultView.ToTable(false, "title", "complexity", "datecreated");

            // Создаем словарь <id, title>
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string title = row["title"].ToString();
                idTitleDictionaryPr.Add(id, title);
            }
            comboBox1.DataSource = new BindingSource(idTitleDictionaryPr, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        public void DelProduction(DataGridView dataGridView1)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            string value = dataGridViewRow.Cells["title"].Value.ToString();
            int targetValue = 0;

            foreach (var row in idTitleDictionaryPr.Keys)
            {
                if (value == idTitleDictionaryPr[row])
                    targetValue = row;
            }
            
            _connectionProduction.Open();
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("delete from production.product where id = @id", _connectionProduction);
            command.Parameters.AddWithValue("@id",targetValue);
            command.ExecuteNonQuery();
            command.Dispose();
            _connectionProduction.Close();
        }

        public void UpdProduct (DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox textBox2, DateTimePicker dateTimePicker1)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            string value = dataGridViewRow.Cells["title"].Value.ToString();
            int targetValue = 0;

            foreach (var row in idTitleDictionaryPr.Keys)
            {
                if (value == idTitleDictionaryPr[row])
                    targetValue = row;
            }
            _connectionProduction.Open();
            if (DateTime.TryParse(dataGridViewRow.Cells["datecreated"].Value.ToString(), out DateTime dateCreated))
            {
                dateTimePicker1.Value = dateCreated;
            }
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("update production.product set title = @title, complexity = @complexity, datecreated = @datecreated where id = @id", _connectionProduction);
            command.Parameters.AddWithValue("@id", targetValue);
            command.Parameters.AddWithValue("@title", textBox1.Text);
            command.Parameters.AddWithValue("@complexity", int.Parse(textBox2.Text));
            command.Parameters.AddWithValue("@datecreated", dateCreated);
            
            command.ExecuteNonQuery();
            command.Dispose();
            _connectionProduction.Close();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
           
        }
        
        public void InsProduct (DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox textBox2, DateTimePicker dateTimePicker1)
        {
            _connectionProduction.Open();
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("insert into production.product(title, complexity, datecreated) values(@title, @complexity, @datecreated)", _connectionProduction);

            command.Parameters.AddWithValue("@title", textBox1.Text);
            command.Parameters.AddWithValue("@complexity", int.Parse(textBox2.Text));
            command.Parameters.AddWithValue("@datecreated", dateTimePicker1.Value);
            command.ExecuteNonQuery();
            command.Dispose();
            _connectionProduction.Close();
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        public void DoubleClick (DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox textBox2, DateTimePicker dateTimePicker1)
        {
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            textBox1.Text = dataGridViewRow.Cells["title"].Value.ToString();
            textBox2.Text = dataGridViewRow.Cells["complexity"].Value.ToString();
            if (DateTime.TryParse(dataGridViewRow.Cells["datecreated"].Value.ToString(), out DateTime dateCreated))
            {
                dateTimePicker1.Value = dateCreated;
            }
            else
            {
                // Обработка случая, если значение в ячейке "datecreated" не удалось преобразовать в DateTime
                // Можно установить значение по умолчанию или предпринять другие действия
                dateTimePicker1.Value = DateTime.Now;
            }
        }
    }
}
