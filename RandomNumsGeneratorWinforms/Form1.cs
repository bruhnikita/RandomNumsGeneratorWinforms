using System;
using System.Windows.Forms;

namespace RandomNumsGeneratorWinforms
{
    public partial class MainForm : Form
    {
        private static Random random = new Random();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            resultListBox.Items.Clear();

            if (!long.TryParse(minTextBox.Text, out long min) ||
                !long.TryParse(maxTextBox.Text, out long max) ||
                !int.TryParse(countTextBox.Text, out int count))
            {
                MessageBox.Show("Введите корректные числа для минимума, максимума и количества.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (min >= max)
            {
                MessageBox.Show("Минимум должен быть меньше максимума.",
                                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            for (int i = 0; i < count; i++)
            {
                long number = GetRandomLong(min, max);
                resultListBox.Items.Add(number);
            }
        }

        private long GetRandomLong(long min, long max)
        {
            double range = (double)(max - min + 1);
            double sample = random.NextDouble();
            long result = (long)(sample * range) + min;
            return result;
        }
    }
}
