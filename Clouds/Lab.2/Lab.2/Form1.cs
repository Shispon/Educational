using System.Text;

namespace Lab._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBoxWithResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxInput.Text, out int number) && number > 1)
            {
                // Отображаем результат в ListView
                DisplayPrimeFactors(number);
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное натуральное число больше 1.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayPrimeFactors(int n)
        {
            listViewOutput.Items.Clear();

            StringBuilder result = new StringBuilder();

            while (n % 2 == 0)
            {
                AddFactorToListView(2, ref n, result);
            }

            int b = 3;
            int c = (int)Math.Sqrt(n) + 1;

            while (b < c)
            {
                if (n % b == 0)
                {
                    if (n / b * b - n == 0)
                    {
                        AddFactorToListView(b, ref n, result);

                        while (n % b == 0)
                        {
                            n /= b;
                        }
                        c = (int)Math.Sqrt(n) + 1;
                    }
                    else
                    {
                        b += 2;
                    }
                }
                else
                {
                    b += 2;
                }
            }

            if (n > 1)
            {
                AddFactorToListView(n, ref n, result);
            }

            textBoxOutput.Text = result.ToString();
        }

        private void AddFactorToListView(int factor, ref int n, StringBuilder result)
        {
            int exponent = 0;
            while (n % factor == 0)
            {
                n /= factor;
                exponent++;
            }

            if (result.Length > 0)
                result.Append(" * ");

            result.Append(factor);

            if (exponent > 1)
                result.Append($"^{exponent}");
        }

    }
}
