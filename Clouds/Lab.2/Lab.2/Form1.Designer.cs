namespace Lab._2
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
            textBoxInput = new TextBox();
            buttonStart = new Button();
            textBoxOutput = new TextBox();
            Ввод = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(152, 104);
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(100, 23);
            textBoxInput.TabIndex = 0;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = SystemColors.ButtonFace;
            buttonStart.ForeColor = SystemColors.MenuHighlight;
            buttonStart.Location = new Point(299, 211);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(68, 38);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "Jsut do it";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(491, 104);
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(100, 23);
            textBoxOutput.TabIndex = 4;
            // 
            // Ввод
            // 
            Ввод.AutoSize = true;
            Ввод.Location = new Point(152, 72);
            Ввод.Name = "Ввод";
            Ввод.Size = new Size(33, 15);
            Ввод.TabIndex = 5;
            Ввод.Text = "Ввод";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(491, 72);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 6;
            label1.Text = "Вывод";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Ввод);
            Controls.Add(textBoxOutput);
            Controls.Add(buttonStart);
            Controls.Add(textBoxInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxInput;
        private Button buttonStart;
        private TextBox textBoxOutput;
        private Label Ввод;
        private Label label1;
    }
}
