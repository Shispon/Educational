namespace Course
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            загрузитьToolStripMenuItem = new ToolStripMenuItem();
            добавитьToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItemInsKnot = new ToolStripMenuItem();
            toolStripMenuItemInsRegion = new ToolStripMenuItem();
            toolStripMenuItemInsWorkshop = new ToolStripMenuItem();
            обноваитьToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItemUpdKnot = new ToolStripMenuItem();
            toolStripMenuItemRegionUpd = new ToolStripMenuItem();
            toolStripMenuItemUpWokshop = new ToolStripMenuItem();
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem5 = new ToolStripMenuItem();
            toolStripMenuItemDelWorkshop = new ToolStripMenuItem();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            splitContainer2 = new SplitContainer();
            dataGridView2 = new DataGridView();
            comboBox1 = new ComboBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            label5 = new Label();
            tabPage3 = new TabPage();
            dataGridView3 = new DataGridView();
            splitContainer3 = new SplitContainer();
            textBox5 = new TextBox();
            label7 = new Label();
            tabPage4 = new TabPage();
            splitContainer4 = new SplitContainer();
            dataGridView4 = new DataGridView();
            textBox7 = new TextBox();
            label9 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            npgsqlDataAdapter1 = new Npgsql.NpgsqlDataAdapter();
            tabPage5 = new TabPage();
            splitContainer5 = new SplitContainer();
            dataGridView5 = new DataGridView();
            textBox8 = new TextBox();
            label10 = new Label();
            textBox9 = new TextBox();
            label11 = new Label();
            textBox10 = new TextBox();
            label12 = new Label();
            textBox11 = new TextBox();
            label13 = new Label();
            textBox12 = new TextBox();
            label14 = new Label();
            textBox13 = new TextBox();
            label15 = new Label();
            textBox14 = new TextBox();
            label16 = new Label();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView4).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView5).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { загрузитьToolStripMenuItem, добавитьToolStripMenuItem, обноваитьToolStripMenuItem, удалитьToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1046, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // загрузитьToolStripMenuItem
            // 
            загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            загрузитьToolStripMenuItem.Size = new Size(73, 20);
            загрузитьToolStripMenuItem.Text = "Загрузить";
            загрузитьToolStripMenuItem.Click += загрузитьToolStripMenuItem_Click;
            // 
            // добавитьToolStripMenuItem
            // 
            добавитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItemInsKnot, toolStripMenuItemInsRegion, toolStripMenuItemInsWorkshop });
            добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            добавитьToolStripMenuItem.Size = new Size(71, 20);
            добавитьToolStripMenuItem.Text = "Добавить";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(188, 22);
            toolStripMenuItem1.Text = "Добавить Production";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItemInsKnot
            // 
            toolStripMenuItemInsKnot.Name = "toolStripMenuItemInsKnot";
            toolStripMenuItemInsKnot.Size = new Size(188, 22);
            toolStripMenuItemInsKnot.Text = "Добавить Knot";
            toolStripMenuItemInsKnot.Click += toolStripMenuItemInsKnot_Click;
            // 
            // toolStripMenuItemInsRegion
            // 
            toolStripMenuItemInsRegion.Name = "toolStripMenuItemInsRegion";
            toolStripMenuItemInsRegion.Size = new Size(188, 22);
            toolStripMenuItemInsRegion.Text = "Добавить Region";
            toolStripMenuItemInsRegion.Click += toolStripMenuItemInsRegion_Click;
            // 
            // toolStripMenuItemInsWorkshop
            // 
            toolStripMenuItemInsWorkshop.Name = "toolStripMenuItemInsWorkshop";
            toolStripMenuItemInsWorkshop.Size = new Size(188, 22);
            toolStripMenuItemInsWorkshop.Text = "Добавить Workshop";
            toolStripMenuItemInsWorkshop.Click += toolStripMenuItemInsWorkshop_Click;
            // 
            // обноваитьToolStripMenuItem
            // 
            обноваитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2, toolStripMenuItemUpdKnot, toolStripMenuItemRegionUpd, toolStripMenuItemUpWokshop });
            обноваитьToolStripMenuItem.Name = "обноваитьToolStripMenuItem";
            обноваитьToolStripMenuItem.Size = new Size(73, 20);
            обноваитьToolStripMenuItem.Text = "Обновить";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(196, 22);
            toolStripMenuItem2.Text = "Обноваить Production";
            toolStripMenuItem2.Click += toolStripMenuItem2_Click;
            // 
            // toolStripMenuItemUpdKnot
            // 
            toolStripMenuItemUpdKnot.Name = "toolStripMenuItemUpdKnot";
            toolStripMenuItemUpdKnot.Size = new Size(196, 22);
            toolStripMenuItemUpdKnot.Text = "Обновить Knot";
            toolStripMenuItemUpdKnot.Click += toolStripMenuItemUpdKnot_Click;
            // 
            // toolStripMenuItemRegionUpd
            // 
            toolStripMenuItemRegionUpd.Name = "toolStripMenuItemRegionUpd";
            toolStripMenuItemRegionUpd.Size = new Size(196, 22);
            toolStripMenuItemRegionUpd.Text = "Обновить Region";
            toolStripMenuItemRegionUpd.Click += toolStripMenuItemRegionUpd_Click;
            // 
            // toolStripMenuItemUpWokshop
            // 
            toolStripMenuItemUpWokshop.Name = "toolStripMenuItemUpWokshop";
            toolStripMenuItemUpWokshop.Size = new Size(196, 22);
            toolStripMenuItemUpWokshop.Text = "Обновить Workshop";
            toolStripMenuItemUpWokshop.Click += toolStripMenuItemUpWokshop_Click;
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, toolStripMenuItem4, toolStripMenuItem5, toolStripMenuItemDelWorkshop });
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(63, 20);
            удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(180, 22);
            toolStripMenuItem3.Text = "Удалить Production";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // toolStripMenuItem4
            // 
            toolStripMenuItem4.Name = "toolStripMenuItem4";
            toolStripMenuItem4.Size = new Size(180, 22);
            toolStripMenuItem4.Text = "Удалить Knot";
            toolStripMenuItem4.Click += toolStripMenuItem4_Click;
            // 
            // toolStripMenuItem5
            // 
            toolStripMenuItem5.Name = "toolStripMenuItem5";
            toolStripMenuItem5.Size = new Size(180, 22);
            toolStripMenuItem5.Text = "Удалить Region";
            toolStripMenuItem5.Click += toolStripMenuItem5_Click;
            // 
            // toolStripMenuItemDelWorkshop
            // 
            toolStripMenuItemDelWorkshop.Name = "toolStripMenuItemDelWorkshop";
            toolStripMenuItemDelWorkshop.Size = new Size(180, 22);
            toolStripMenuItemDelWorkshop.Text = "Удалить Workshop";
            toolStripMenuItemDelWorkshop.Click += toolStripMenuItemDelWorkshop_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Location = new Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(776, 420);
            tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(768, 392);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Product";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dateTimePicker1);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(textBox2);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Size = new Size(762, 386);
            splitContainer1.SplitterDistance = 468;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(465, 380);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(127, 142);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(123, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 148);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 4;
            label3.Text = "DateCreated";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(127, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(104, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 97);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 2;
            label2.Text = "Complexity";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(127, 46);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(104, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 49);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(768, 392);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Knot";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(3, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(dataGridView2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(comboBox1);
            splitContainer2.Panel2.Controls.Add(label6);
            splitContainer2.Panel2.Controls.Add(textBox3);
            splitContainer2.Panel2.Controls.Add(label4);
            splitContainer2.Panel2.Controls.Add(textBox4);
            splitContainer2.Panel2.Controls.Add(label5);
            splitContainer2.Size = new Size(762, 386);
            splitContainer2.SplitterDistance = 497;
            splitContainer2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.Size = new Size(491, 380);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellDoubleClick += dataGridView2_CellMouseDoubleClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(121, 132);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(104, 23);
            comboBox1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 140);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 10;
            label6.Text = "Region_id";
            label6.Click += label6_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(121, 89);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(104, 23);
            textBox3.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 92);
            label4.Name = "label4";
            label4.Size = new Size(31, 15);
            label4.TabIndex = 6;
            label4.Text = "Cost";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(121, 41);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(104, 23);
            textBox4.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 44);
            label5.Name = "label5";
            label5.Size = new Size(29, 15);
            label5.TabIndex = 4;
            label5.Text = "Title";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dataGridView3);
            tabPage3.Controls.Add(splitContainer3);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(768, 392);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Region";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(6, 6);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(465, 380);
            dataGridView3.TabIndex = 1;
            dataGridView3.CellDoubleClick += dataGridView3_CellMouseDoubleClick;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(3, 3);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(textBox5);
            splitContainer3.Panel2.Controls.Add(label7);
            splitContainer3.Size = new Size(762, 386);
            splitContainer3.SplitterDistance = 471;
            splitContainer3.TabIndex = 0;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(139, 64);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(104, 23);
            textBox5.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(40, 67);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 6;
            label7.Text = "Title";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(splitContainer4);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(768, 392);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Workshop";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(3, 3);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(dataGridView4);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(textBox7);
            splitContainer4.Panel2.Controls.Add(label9);
            splitContainer4.Panel2.Controls.Add(textBox6);
            splitContainer4.Panel2.Controls.Add(label8);
            splitContainer4.Size = new Size(762, 386);
            splitContainer4.SplitterDistance = 501;
            splitContainer4.TabIndex = 0;
            // 
            // dataGridView4
            // 
            dataGridView4.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView4.Location = new Point(0, 3);
            dataGridView4.Name = "dataGridView4";
            dataGridView4.RowTemplate.Height = 25;
            dataGridView4.Size = new Size(498, 380);
            dataGridView4.TabIndex = 0;
            dataGridView4.CellDoubleClick += dataGridView4_CellMouseDoubleClick;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(120, 168);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(104, 23);
            textBox7.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(29, 176);
            label9.Name = "label9";
            label9.Size = new Size(69, 15);
            label9.TabIndex = 10;
            label9.Text = "Chef_Name";
            label9.Click += label9_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(120, 77);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(104, 23);
            textBox6.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(29, 85);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 8;
            label8.Text = "Title";
            // 
            // npgsqlDataAdapter1
            // 
            npgsqlDataAdapter1.DeleteCommand = null;
            npgsqlDataAdapter1.InsertCommand = null;
            npgsqlDataAdapter1.SelectCommand = null;
            npgsqlDataAdapter1.UpdateCommand = null;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(splitContainer5);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(768, 392);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Stuff";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.Location = new Point(3, 3);
            splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(dataGridView5);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(textBox14);
            splitContainer5.Panel2.Controls.Add(label16);
            splitContainer5.Panel2.Controls.Add(textBox13);
            splitContainer5.Panel2.Controls.Add(label15);
            splitContainer5.Panel2.Controls.Add(textBox12);
            splitContainer5.Panel2.Controls.Add(label14);
            splitContainer5.Panel2.Controls.Add(textBox11);
            splitContainer5.Panel2.Controls.Add(label13);
            splitContainer5.Panel2.Controls.Add(textBox10);
            splitContainer5.Panel2.Controls.Add(label12);
            splitContainer5.Panel2.Controls.Add(textBox9);
            splitContainer5.Panel2.Controls.Add(label11);
            splitContainer5.Panel2.Controls.Add(textBox8);
            splitContainer5.Panel2.Controls.Add(label10);
            splitContainer5.Size = new Size(762, 386);
            splitContainer5.SplitterDistance = 471;
            splitContainer5.TabIndex = 0;
            // 
            // dataGridView5
            // 
            dataGridView5.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView5.Location = new Point(3, 0);
            dataGridView5.Name = "dataGridView5";
            dataGridView5.RowTemplate.Height = 25;
            dataGridView5.Size = new Size(465, 383);
            dataGridView5.TabIndex = 0;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(132, 35);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(104, 23);
            textBox8.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 43);
            label10.Name = "label10";
            label10.Size = new Size(29, 15);
            label10.TabIndex = 10;
            label10.Text = "Title";
            // 
            // textBox9
            // 
            textBox9.Location = new Point(132, 82);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(104, 23);
            textBox9.TabIndex = 13;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(41, 90);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 12;
            label11.Text = "First_Name";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(132, 121);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(104, 23);
            textBox10.TabIndex = 15;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(41, 129);
            label12.Name = "label12";
            label12.Size = new Size(83, 15);
            label12.TabIndex = 14;
            label12.Text = "Second_Name";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(132, 160);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(104, 23);
            textBox11.TabIndex = 17;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(41, 168);
            label13.Name = "label13";
            label13.Size = new Size(65, 15);
            label13.TabIndex = 16;
            label13.Text = "Last_Name";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(132, 206);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(104, 23);
            textBox12.TabIndex = 19;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(41, 214);
            label14.Name = "label14";
            label14.Size = new Size(90, 15);
            label14.TabIndex = 18;
            label14.Text = "Phone_Number";
            // 
            // textBox13
            // 
            textBox13.Location = new Point(132, 253);
            textBox13.Name = "textBox13";
            textBox13.Size = new Size(104, 23);
            textBox13.TabIndex = 21;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(41, 261);
            label15.Name = "label15";
            label15.Size = new Size(42, 15);
            label15.TabIndex = 20;
            label15.Text = "Adress";
            // 
            // textBox14
            // 
            textBox14.Location = new Point(132, 305);
            textBox14.Name = "textBox14";
            textBox14.Size = new Size(104, 23);
            textBox14.TabIndex = 23;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(41, 313);
            label16.Name = "label16";
            label16.Size = new Size(30, 15);
            label16.TabIndex = 22;
            label16.Text = "Post";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1046, 602);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPage2.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            splitContainer3.Panel2.ResumeLayout(false);
            splitContainer3.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView4).EndInit();
            tabPage5.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel2.ResumeLayout(false);
            splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem обноваитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox1;
        private Label label1;
        private ToolStripMenuItem toolStripMenuItem1;
        private DateTimePicker dateTimePicker1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private SplitContainer splitContainer2;
        private Npgsql.NpgsqlDataAdapter npgsqlDataAdapter1;
        private DataGridView dataGridView2;
        private Label label6;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
        private Label label5;
        private ComboBox comboBox1;
        private TabPage tabPage3;
        private DataGridView dataGridView3;
        private SplitContainer splitContainer3;
        private TextBox textBox5;
        private Label label7;
        private ToolStripMenuItem toolStripMenuItemInsKnot;
        private ToolStripMenuItem toolStripMenuItemInsRegion;
        private ToolStripMenuItem toolStripMenuItemUpdKnot;
        private ToolStripMenuItem toolStripMenuItemRegionUpd;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem toolStripMenuItem5;
        private TabPage tabPage4;
        private SplitContainer splitContainer4;
        private DataGridView dataGridView4;
        private TextBox textBox7;
        private Label label9;
        private TextBox textBox6;
        private Label label8;
        private ToolStripMenuItem toolStripMenuItemInsWorkshop;
        private ToolStripMenuItem toolStripMenuItemUpWokshop;
        private ToolStripMenuItem toolStripMenuItemDelWorkshop;
        private TabPage tabPage5;
        private SplitContainer splitContainer5;
        private DataGridView dataGridView5;
        private TextBox textBox14;
        private Label label16;
        private TextBox textBox13;
        private Label label15;
        private TextBox textBox12;
        private Label label14;
        private TextBox textBox11;
        private Label label13;
        private TextBox textBox10;
        private Label label12;
        private TextBox textBox9;
        private Label label11;
        private TextBox textBox8;
        private Label label10;
    }
}
