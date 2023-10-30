namespace WinFormdop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHighlightBirthday_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.TryParse(txtBirthday.Text, out DateTime birthday))
                {
                    monthCalendar1.SetDate(birthday);
                }
                else
                {
                    MessageBox.Show("Некорректный формат даты рождения. Введите дату в формате ДД.ММ.ГГГГ.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Произошла ошибка при вводе даты: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}