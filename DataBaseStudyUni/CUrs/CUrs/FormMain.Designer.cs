namespace Program
{
    partial class FormMain
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            loadToolStripMenuItem = new ToolStripMenuItem();
            загрузитьToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            addDepartmentToolStripMenuItem = new ToolStripMenuItem();
            addFacultyToolStripMenuItem = new ToolStripMenuItem();
            updateToolStripMenuItem = new ToolStripMenuItem();
            updateDepartmentToolStripMenuItem = new ToolStripMenuItem();
            updateFacultyToolStripMenuItem = new ToolStripMenuItem();
            removeToolStripMenuItem = new ToolStripMenuItem();
            removeDepartmentToolStripMenuItem = new ToolStripMenuItem();
            removeFacultyToolStripMenuItem = new ToolStripMenuItem();
            photoToolStripMenuItem = new ToolStripMenuItem();
            loadToolStripMenuItem1 = new ToolStripMenuItem();
            saveToolStripMenuItem = new ToolStripMenuItem();
            propertyToolStripMenuItem = new ToolStripMenuItem();
            printToolStripMenuItem = new ToolStripMenuItem();
            previewToolStripMenuItem = new ToolStripMenuItem();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            splitContainer1 = new SplitContainer();
            dataGridView1 = new DataGridView();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            numericUpDown1 = new NumericUpDown();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            tabPage2 = new TabPage();
            splitContainer2 = new SplitContainer();
            dataGridView2 = new DataGridView();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            numericUpDown2 = new NumericUpDown();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            menuStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { loadToolStripMenuItem, addToolStripMenuItem, updateToolStripMenuItem, removeToolStripMenuItem, photoToolStripMenuItem, printToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(897, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { загрузитьToolStripMenuItem });
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(73, 20);
            loadToolStripMenuItem.Text = "Загрузить";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // загрузитьToolStripMenuItem
            // 
            загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            загрузитьToolStripMenuItem.Size = new Size(180, 22);
            загрузитьToolStripMenuItem.Text = "Загрузить";
            загрузитьToolStripMenuItem.Click += загрузитьToolStripMenuItem_Click;
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addDepartmentToolStripMenuItem, addFacultyToolStripMenuItem });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(71, 20);
            addToolStripMenuItem.Text = "Добавить";
            // 
            // addDepartmentToolStripMenuItem
            // 
            addDepartmentToolStripMenuItem.Name = "addDepartmentToolStripMenuItem";
            addDepartmentToolStripMenuItem.Size = new Size(186, 22);
            addDepartmentToolStripMenuItem.Text = "Добавить страну";
            addDepartmentToolStripMenuItem.Click += addDepartmentToolStripMenuItem_Click;
            // 
            // addFacultyToolStripMenuItem
            // 
            addFacultyToolStripMenuItem.Name = "addFacultyToolStripMenuItem";
            addFacultyToolStripMenuItem.Size = new Size(186, 22);
            addFacultyToolStripMenuItem.Text = "Добавить континент";
            addFacultyToolStripMenuItem.Click += addFacultyToolStripMenuItem_Click;
            // 
            // updateToolStripMenuItem
            // 
            updateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { updateDepartmentToolStripMenuItem, updateFacultyToolStripMenuItem });
            updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            updateToolStripMenuItem.Size = new Size(73, 20);
            updateToolStripMenuItem.Text = "Обновить";
            // 
            // updateDepartmentToolStripMenuItem
            // 
            updateDepartmentToolStripMenuItem.Name = "updateDepartmentToolStripMenuItem";
            updateDepartmentToolStripMenuItem.Size = new Size(188, 22);
            updateDepartmentToolStripMenuItem.Text = "Обновить страну";
            updateDepartmentToolStripMenuItem.Click += updateDepartmentToolStripMenuItem_Click;
            // 
            // updateFacultyToolStripMenuItem
            // 
            updateFacultyToolStripMenuItem.Name = "updateFacultyToolStripMenuItem";
            updateFacultyToolStripMenuItem.Size = new Size(188, 22);
            updateFacultyToolStripMenuItem.Text = "Обновить континент";
            updateFacultyToolStripMenuItem.Click += updateFacultyToolStripMenuItem_Click;
            // 
            // removeToolStripMenuItem
            // 
            removeToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { removeDepartmentToolStripMenuItem, removeFacultyToolStripMenuItem });
            removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            removeToolStripMenuItem.Size = new Size(63, 20);
            removeToolStripMenuItem.Text = "Удалить";
            // 
            // removeDepartmentToolStripMenuItem
            // 
            removeDepartmentToolStripMenuItem.Name = "removeDepartmentToolStripMenuItem";
            removeDepartmentToolStripMenuItem.Size = new Size(178, 22);
            removeDepartmentToolStripMenuItem.Text = "Удалить страну";
            removeDepartmentToolStripMenuItem.Click += removeDepartmentToolStripMenuItem_Click;
            // 
            // removeFacultyToolStripMenuItem
            // 
            removeFacultyToolStripMenuItem.Name = "removeFacultyToolStripMenuItem";
            removeFacultyToolStripMenuItem.Size = new Size(178, 22);
            removeFacultyToolStripMenuItem.Text = "Удалить континент";
            removeFacultyToolStripMenuItem.Click += removeFacultyToolStripMenuItem_Click;
            // 
            // photoToolStripMenuItem
            // 
            photoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem1, saveToolStripMenuItem, propertyToolStripMenuItem });
            photoToolStripMenuItem.Name = "photoToolStripMenuItem";
            photoToolStripMenuItem.Size = new Size(47, 20);
            photoToolStripMenuItem.Text = "Фото";
            // 
            // loadToolStripMenuItem1
            // 
            loadToolStripMenuItem1.Name = "loadToolStripMenuItem1";
            loadToolStripMenuItem1.Size = new Size(133, 22);
            loadToolStripMenuItem1.Text = "Загрузить";
            loadToolStripMenuItem1.Click += loadToolStripMenuItem1_Click;
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(133, 22);
            saveToolStripMenuItem.Text = "Сохранить";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // propertyToolStripMenuItem
            // 
            propertyToolStripMenuItem.Name = "propertyToolStripMenuItem";
            propertyToolStripMenuItem.Size = new Size(133, 22);
            propertyToolStripMenuItem.Text = "Свойство";
            propertyToolStripMenuItem.Click += propertyToolStripMenuItem_Click;
            // 
            // printToolStripMenuItem
            // 
            printToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { previewToolStripMenuItem });
            printToolStripMenuItem.Name = "printToolStripMenuItem";
            printToolStripMenuItem.Size = new Size(58, 20);
            printToolStripMenuItem.Text = "Печать";
            printToolStripMenuItem.Click += printToolStripMenuItem_Click;
            // 
            // previewToolStripMenuItem
            // 
            previewToolStripMenuItem.Name = "previewToolStripMenuItem";
            previewToolStripMenuItem.Size = new Size(157, 22);
            previewToolStripMenuItem.Text = "Предпросмотр";
            previewToolStripMenuItem.Click += previewToolStripMenuItem_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 505);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(897, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(22, 17);
            toolStripStatusLabel1.Text = "Ok";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(12, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(873, 475);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(splitContainer1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(865, 447);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Страны";
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
            splitContainer1.Panel2.Controls.Add(button1);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(label1);
            splitContainer1.Panel2.Controls.Add(comboBox1);
            splitContainer1.Panel2.Controls.Add(numericUpDown1);
            splitContainer1.Panel2.Controls.Add(textBox2);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Size = new Size(859, 441);
            splitContainer1.SplitterDistance = 442;
            splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(436, 435);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // button1
            // 
            button1.Location = new Point(182, 398);
            button1.Name = "button1";
            button1.Size = new Size(152, 23);
            button1.TabIndex = 9;
            button1.Text = "Печать";
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(52, 225);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(282, 167);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 190);
            label4.Name = "label4";
            label4.Size = new Size(84, 15);
            label4.TabIndex = 7;
            label4.Text = "ID континента";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 143);
            label3.Name = "label3";
            label3.Size = new Size(127, 15);
            label3.TabIndex = 6;
            label3.Text = "Количество регионов";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 5;
            label2.Text = "Наименование";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(59, 15);
            label1.TabIndex = 4;
            label1.Text = "Название";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(182, 182);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(152, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(182, 135);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(152, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(182, 84);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(182, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 23);
            textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(splitContainer2);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(865, 447);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Континенты";
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
            splitContainer2.Panel2.Controls.Add(label7);
            splitContainer2.Panel2.Controls.Add(label6);
            splitContainer2.Panel2.Controls.Add(label5);
            splitContainer2.Panel2.Controls.Add(numericUpDown2);
            splitContainer2.Panel2.Controls.Add(textBox4);
            splitContainer2.Panel2.Controls.Add(textBox3);
            splitContainer2.Size = new Size(859, 441);
            splitContainer2.SplitterDistance = 421;
            splitContainer2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(3, 3);
            dataGridView2.MultiSelect = false;
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.RowTemplate.Height = 25;
            dataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView2.Size = new Size(415, 435);
            dataGridView2.TabIndex = 0;
            dataGridView2.CellMouseDoubleClick += dataGridView2_CellMouseDoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 196);
            label7.Name = "label7";
            label7.Size = new Size(111, 15);
            label7.TabIndex = 5;
            label7.Text = "Количество людей";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 123);
            label6.Name = "label6";
            label6.Size = new Size(90, 15);
            label6.TabIndex = 4;
            label6.Text = "Наименование";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 53);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 3;
            label5.Text = "Континент";
            label5.Click += label5_Click;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(195, 188);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(153, 23);
            numericUpDown2.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(195, 115);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(153, 23);
            textBox4.TabIndex = 1;
            textBox4.Validating += textBox4_Validating;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(195, 45);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(153, 23);
            textBox3.TabIndex = 0;
            textBox3.Validating += textBox3_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 527);
            Controls.Add(tabControl1);
            Controls.Add(statusStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FormMain";
            Text = "FormMain";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            tabPage2.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem removeToolStripMenuItem;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private SplitContainer splitContainer1;
        private DataGridView dataGridView1;
        private SplitContainer splitContainer2;
        private DataGridView dataGridView2;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label7;
        private Label label6;
        private Label label5;
        private NumericUpDown numericUpDown2;
        private TextBox textBox4;
        private TextBox textBox3;
        private ToolStripMenuItem addDepartmentToolStripMenuItem;
        private ToolStripMenuItem addFacultyToolStripMenuItem;
        private ToolStripMenuItem updateDepartmentToolStripMenuItem;
        private ToolStripMenuItem updateFacultyToolStripMenuItem;
        private ToolStripMenuItem removeDepartmentToolStripMenuItem;
        private ToolStripMenuItem removeFacultyToolStripMenuItem;
        private ToolStripMenuItem photoToolStripMenuItem;
        private ToolStripMenuItem loadToolStripMenuItem1;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem propertyToolStripMenuItem;
        private ToolStripMenuItem printToolStripMenuItem;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ToolStripMenuItem previewToolStripMenuItem;
        private ToolStripMenuItem загрузитьToolStripMenuItem;
    }
}