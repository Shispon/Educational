using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Course.DownloadFromDb
{
    public class Working_Shift
    {
        private readonly Npgsql.NpgsqlConnection _connectionShift = new Npgsql.NpgsqlConnection("Server=localhost;Port=5432;Database=EducationalDB;User Id = postgres;Password=8457");

        private Dictionary<int, string> idTitleDictionary;

        public void DownShift(DataGridView dataGridView1, DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker2)
        {

            //Region region = new Region();
            idTitleDictionary = new Dictionary<int, string>();
            _connectionShift.Open();

            DataSet dataSet = new DataSet();
            Npgsql.NpgsqlDataAdapter npgsqlDataAdapter = new Npgsql.NpgsqlDataAdapter("SELECT id, title, shift_start_date, shift_end_date, staff_id FROM production.working_shift", _connectionShift);
            npgsqlDataAdapter.Fill(dataSet);

            _connectionShift.Close();

            // Отображаем только нужные поля в DataGridView
            dataGridView1.DataSource = dataSet.Tables[0].DefaultView.ToTable(false, "title", "shift_start_date", "shift_end_date", "staff_id");

            // Создаем словарь <id, title>
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                int id = Convert.ToInt32(row["id"]);
                string title = row["title"].ToString();
                idTitleDictionary.Add(id, title);
            }
            dateTimePicker1.Checked = false;
            dateTimePicker2.Checked = false;
            //comboBox1.DataSource = new BindingSource( idTitleDictionaryReg, null);
            //comboBox1.DisplayMember = "Value";
            //comboBox1.ValueMember = "Key";
        }

        public void DelShift(DataGridView dataGridView1)
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
            _connectionShift.Open();
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("delete from production.working_shift where id = @id", _connectionShift);
            command.Parameters.AddWithValue("@id", targetValue);
            command.ExecuteNonQuery();
            command.Dispose();
            _connectionShift.Close();
        }

        public void UpdShift(DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1, DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker2, ComboBox comboBox1)
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
            _connectionShift.Open();
            if (DateTime.TryParse(dataGridViewRow.Cells["shift_start_date"].Value.ToString(), out DateTime dateCreated))
            {
                dateTimePicker1.Value = dateCreated;
            }

            if (DateTime.TryParse(dataGridViewRow.Cells["shift_end_date"].Value.ToString(), out DateTime dateEnd))
            {
                dateTimePicker2.Value = dateEnd;
            }
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("update production.working_shift set title = @title, shift_start_date = @shift_start_date,shift_end_date = @shift_end_date, staff_id = @staff_id where id = @id", _connectionShift);
           
            command.Parameters.AddWithValue("@id", targetValue);
            command.Parameters.AddWithValue("@title", textBox1.Text);
            command.Parameters.AddWithValue("@shift_start_date",dateCreated);
            command.Parameters.AddWithValue("@shift_end_date",dateEnd);
            command.Parameters.AddWithValue("@region_id", int.Parse(comboBox1.Text));

            command.ExecuteNonQuery();
            command.Dispose();
            _connectionShift.Close();
            textBox1.Text = string.Empty;
            dateTimePicker1.Checked = false;
            dateTimePicker2.Checked = false;
            comboBox1.Text = string.Empty;

        }

        public void InsShift(DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1, DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker2, ComboBox comboBox1)
        {
            _connectionShift.Open();
            Npgsql.NpgsqlCommand command = new Npgsql.NpgsqlCommand("insert into production.working_shift(title, shift_start_date,shift_end_date, staff_id) values(@title, @shift_start_date,@shift_end_date, @staff_id)", _connectionShift);

            command.Parameters.AddWithValue("@title", textBox1.Text);
            command.Parameters.AddWithValue("@shift_start_date", dateTimePicker1.Value);
            command.Parameters.AddWithValue("@shift_end_date", dateTimePicker2.Value);
            command.Parameters.AddWithValue("@staff_id", (int)comboBox1.SelectedValue);
            command.ExecuteNonQuery();
            command.Dispose();
            _connectionShift.Close();
            textBox1.Text = string.Empty;
            dateTimePicker1.Checked = false;
            dateTimePicker2.Checked = false;
            comboBox1.Text = string.Empty;
        }

        public void DoubleClick(DataGridView dataGridView1, System.Windows.Forms.TextBox textBox1, DateTimePicker dateTimePicker1, DateTimePicker dateTimePicker2, ComboBox comboBox1)
        {
            textBox1.Text = string.Empty;
            dateTimePicker1.Checked = false;
            dateTimePicker2.Checked = false;
            comboBox1.Text = string.Empty;
            int index = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow dataGridViewRow = dataGridView1.Rows[index];
            textBox1.Text = dataGridViewRow.Cells["title"].Value.ToString();
            if (DateTime.TryParse(dataGridViewRow.Cells["shift_start_date"].Value.ToString(), out DateTime dateCreated))
            {
                dateTimePicker1.Value = dateCreated;
            }
            else
            {
                // Обработка случая, если значение в ячейке "datecreated" не удалось преобразовать в DateTime
                // Можно установить значение по умолчанию или предпринять другие действия
                dateTimePicker1.Value = DateTime.Now;
            }
            if (DateTime.TryParse(dataGridViewRow.Cells["shift_end_date"].Value.ToString(), out DateTime dateEnd))
            {
                dateTimePicker2.Value = dateEnd;
            }
            else
            {
                // Обработка случая, если значение в ячейке "datecreated" не удалось преобразовать в DateTime
                // Можно установить значение по умолчанию или предпринять другие действия
                dateTimePicker2.Value = DateTime.Now;
            }
            comboBox1.Text = dataGridViewRow.Cells["staff_id"].Value.ToString();
        }
    }
}
