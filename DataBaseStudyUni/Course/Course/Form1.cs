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
        private readonly Stuff stuff = new Stuff();
        private readonly Working_Shift shift = new Working_Shift();
        private readonly Production production = new Production();
        public Form1()
        {
            InitializeComponent();
            _connection = new Npgsql.NpgsqlConnection("Server=localhost;Port=5432;Database=EducationalDB;User Id = postgres;Password=8457");

        }

        private void Á‡„ÛÁËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            region.DownReg(dataGridView3, comboBox1);
            product.DownProduction(dataGridView1,comboBox3);
            knot.DownKnot(dataGridView2);
            workshop.DownWork(dataGridView4,comboBox4);
            stuff.DownStuff(dataGridView5, comboBox2,comboBox5);
            shift.DownShift(dataGridView6, dateTimePicker2, dateTimePicker3);
            production.DownProduction(dataGridView7);
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
        private void dataGridView5_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            stuff.DoubleClick(dataGridView5, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14, textBox15);

        }
        private void dataGridView6_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            shift.DoubleClick(dataGridView6, textBox16, dateTimePicker2, dateTimePicker3, comboBox2);

        }
        private void dataGridView7_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            production.DoubleProduction(dataGridView7, textBox17, dateTimePicker4, dateTimePicker5, comboBox3, comboBox4, comboBox5);

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

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void ‰Ó·‡‚ËÚ¸StaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stuff.InsStuff(dataGridView5, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14, textBox15);
        }

        private void Ó·ÌÓ‚‡ËÚ¸StaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stuff.UpdStuff(dataGridView5, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14, textBox15);
        }

        private void Û‰‡ÎËÚ¸StaffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            stuff.DelStuff(dataGridView5);
        }

        private void ‰Ó·‡‚ËÚ¸WorkingShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shift.InsShift(dataGridView6, textBox16, dateTimePicker2, dateTimePicker3, comboBox2);
        }

        private void Ó·ÌÓ‚ËÚ¸WorkingShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shift.UpdShift(dataGridView6, textBox16, dateTimePicker2, dateTimePicker3, comboBox2);
        }

        private void Û‰‡ÎËÚ¸WorkingShiftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shift.DelShift(dataGridView6);
        }

        private void ‰Ó·‡‚ËÚ¸ProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            production.InsProduction(dataGridView7, textBox17, dateTimePicker4, dateTimePicker5, comboBox3, comboBox4, comboBox5);
        }

        private void Ó·ÌÓ‚ËÚ¸ProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            production.UpdProduction(dataGridView7, textBox17, dateTimePicker4, dateTimePicker5, comboBox3, comboBox4, comboBox5);
        }

        private void Û‰‡ÎËÚ¸ProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            production.DelProduction(dataGridView7);
        }
    }
}
