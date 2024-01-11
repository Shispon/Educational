using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.DownloadFromDb
{
    public class Production
    {
        private readonly Npgsql.NpgsqlConnection _connectionProduction = new Npgsql.NpgsqlConnection("Server=localhost;Port=5432;Database=EducationalDB;User Id = postgres;Password=8457");

        private Dictionary<int, string> idTitleDictionary;

        public void DownProduction(DataGridView dataGridView1)
        {

            //Region region = new Region();
            idTitleDictionary = new Dictionary<int, string>();
            _connectionProduction.Open();

            DataSet dataSet = new DataSet();
            Npgsql.NpgsqlDataAdapter npgsqlDataAdapter = new Npgsql.NpgsqlDataAdapter("SELECT id, title, datecreated, datedelete, product_id,workshop_id,staff_id FROM production.production", _connectionProduction);
            npgsqlDataAdapter.Fill(dataSet);

            _connectionProduction.Close();

            // Отображаем только нужные поля в DataGridView
            dataGridView1.DataSource = dataSet.Tables[0].DefaultView.ToTable(false, "title", "datecreated", "datedelete", "product_id","workshop_id","staff_id");

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

        public void DelProduction(DataGridView dataGridView1)
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
            _connectionProduction.Open();
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("delete from production.production where id = @id", _connectionProduction);
            command.Parameters.AddWithValue("@id", targetValue);
            command.ExecuteNonQuery();
            command.Dispose();
            _connectionProduction.Close();
        }

        public void UpdProduction(DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1, DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker2, ComboBox comboBox1, ComboBox comboBox2, ComboBox comboBox3)
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
            _connectionProduction.Open();
            if (DateTime.TryParse(dataGridViewRow.Cells["datecreated"].Value.ToString(), out DateTime dateCreated))
            {
                dateTimePicker1.Value = dateCreated;
            }

            if (DateTime.TryParse(dataGridViewRow.Cells["datedelete"].Value.ToString(), out DateTime dateEnd))
            {
                dateTimePicker2.Value = dateEnd;
            }
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("update production.production set title = @title, datecreated = @datecreated,datedelete = @datedelete, product_id = @product_id,workshop_id = @workshop_id,staff_id = @staff_id where id = @id", _connectionProduction);

            command.Parameters.AddWithValue("@id", targetValue);
            command.Parameters.AddWithValue("@title", textBox1.Text);
            command.Parameters.AddWithValue("@datecreated", dateCreated);
            command.Parameters.AddWithValue("@datedelete", dateEnd);
            command.Parameters.AddWithValue("@product_id", int.Parse(comboBox1.Text));
            command.Parameters.AddWithValue("@workshop_id", int.Parse(comboBox2.Text));
            command.Parameters.AddWithValue("@staff_id", int.Parse(comboBox3.Text));

            command.ExecuteNonQuery();
            command.Dispose();
            _connectionProduction.Close();
            textBox1.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;

        }

        public void InsProduction(DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1, DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker2, ComboBox comboBox1, ComboBox comboBox2, ComboBox comboBox3)
        {
            _connectionProduction.Open();
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("insert into production.production(title, datecreated,  product_id,workshop_id,staff_id) values(@title, @datecreated,  @product_id,@workshop_id,@staff_id)", _connectionProduction);

            command.Parameters.AddWithValue("@title", textBox1.Text);
            command.Parameters.AddWithValue("@datecreated", dateTimePicker1.Value);
            //command.Parameters.AddWithValue("@datedelete", );
            command.Parameters.AddWithValue("@product_id", (int)comboBox1.SelectedValue);
            command.Parameters.AddWithValue("@workshop_id", (int)comboBox2.SelectedValue);
            command.Parameters.AddWithValue("@staff_id", (int)comboBox3.SelectedValue);
            command.ExecuteNonQuery();
            command.Dispose();
            _connectionProduction.Close();
            textBox1.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
        }

        public void DoubleProduction(DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1, DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker2, ComboBox comboBox1, ComboBox comboBox2, ComboBox comboBox3)
        {
            textBox1.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            dateTimePicker2.Text = string.Empty;
            comboBox1.Text = string.Empty;
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            textBox1.Text = dataGridViewRow.Cells["title"].Value.ToString();
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
            if (DateTime.TryParse(dataGridViewRow.Cells["datedelete"].Value.ToString(), out DateTime dateEnd))
            {
                dateTimePicker2.Value = dateEnd;
            }
            else
            {
                // Обработка случая, если значение в ячейке "datecreated" не удалось преобразовать в DateTime
                // Можно установить значение по умолчанию или предпринять другие действия
                dateTimePicker2.Value = DateTime.Now;
            }
            comboBox1.Text = dataGridViewRow.Cells["product_id"].Value.ToString();
            comboBox2.Text = dataGridViewRow.Cells["workshop_id"].Value.ToString();
            comboBox3.Text = dataGridViewRow.Cells["staff_id"].Value.ToString();
        }
    }
}
