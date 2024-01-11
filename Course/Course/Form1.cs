using System.Data;
using Course.DownloadFromDb;
using System.Windows.Forms;
using Course.DownloadFromDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Course
{
    public partial class Form1 : Form
    {
        private readonly Npgsql.NpgsqlConnection _connection;
        private readonly Product product = new Product();
        private readonly Knot knot = new Knot();
        private readonly Course.DownloadFromDb.Region region = new Course.DownloadFromDb.Region();
        private readonly Workshop workshop = new Workshop();
        public Form1()
        {
            InitializeComponent();
            _connection = new Npgsql.NpgsqlConnection("Server=localhost;Port=5432;Database=EducationalDB;User Id = postgres;Password=8457");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void çàãðóçèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            region.DownReg(dataGridView3, comboBox1);
            product.DownProduction(dataGridView1);
            knot.DownKnot(dataGridView2);
            workshop.DownWork(dataGridView4);



        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            product.InsProduct(dataGridView1, textBox1, textBox2, dateTimePicker1);

        }



        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            product.DoubleClick(dataGridView1, textBox1, textBox2, dateTimePicker1);


        }
        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            knot.DoubleClick(dataGridView2, textBox4, textBox3, comboBox1);


        }

        private void dataGridView3_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            region.DoubleClick(dataGridView3, textBox5);

        }
        private void dataGridView4_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            workshop.DoubleClick(dataGridView4, textBox6, textBox7);

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

            product.DelProduction(dataGridView1);


        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            product.UpdProduct(dataGridView1, textBox1, textBox2, dateTimePicker1);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemInsKnot_Click(object sender, EventArgs e)
        {
            knot.InsKnot(dataGridView2, textBox4, textBox3, comboBox1);
        }

        private void toolStripMenuItemInsRegion_Click(object sender, EventArgs e)
        {
            region.InsReg(dataGridView3, textBox5);
        }

        private void toolStripMenuItemUpdKnot_Click(object sender, EventArgs e)
        {
            knot.UpdKnot(dataGridView2, textBox4, textBox3, comboBox1);
        }

        private void toolStripMenuItemRegionUpd_Click(object sender, EventArgs e)
        {
            region.UpdReg(dataGridView3, textBox5);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            knot.DelKnot(dataGridView2);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            region.DelReg(dataGridView3);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItemInsWorkshop_Click(object sender, EventArgs e)
        {
            workshop.InsWork(dataGridView4, textBox6, textBox7);
        }

        private void toolStripMenuItemUpWokshop_Click(object sender, EventArgs e)
        {
            workshop.UpdWork(dataGridView4, textBox6, textBox7);
        }

        private void toolStripMenuItemDelWorkshop_Click(object sender, EventArgs e)
        {
            workshop.DelWork(dataGridView4);
        }
    }
}
