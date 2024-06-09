using System;
using System.Linq;
using System.Windows.Forms;

namespace CourseWork
{
    internal static class MainProgram
    {
        /// <summary>
        /// Главная точка входа для приложения
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        /// <summary>
        /// Функция проверки ввода на формат Double
        /// </summary>
        public static void DoubleInputCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверка, является ли нажатая клавиша цифрой, запятой или знаком минус
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '-')
            {
                e.Handled = true; // Предотвращение ввода символа
            }

            // Проверка, что знак минуса стоит только в начале строки
            if (e.KeyChar == '-' && (sender as TextBox).SelectionStart != 0)
            {
                e.Handled = true; // Предотвращение ввода дополнительного знака минуса
            }

            // Проверка наличия только одной запятой
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
            {
                e.Handled = true; // Предотвращение ввода дополнительной точки
            }
        }

        /// <summary>
        /// Функция проверки ввода на формат положительный Double
        /// </summary>
        public static void PositiveDoubleInputCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверка, является ли нажатая клавиша цифрой или запятой
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Предотвращение ввода символа
            }

            // Проверка наличия только одной запятой
            if (e.KeyChar == ',' && (sender as TextBox).Text.Contains(','))
            {
                e.Handled = true; // Предотвращение ввода дополнительной точки
            }
        }
        /// <summary>
        /// Функция проверки ввода на формат Int
        /// </summary>
        public static void IntInputCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Проверка, является ли нажатая клавиша цифрой или знаком минус
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '-')
            {
                e.Handled = true; // Предотвращение ввода символа
            }

            // Проверка, что знак минуса стоит только в начале строки
            if (e.KeyChar == '-' && (sender as TextBox).SelectionStart != 0)
            {
                e.Handled = true; // Предотвращение ввода дополнительного знака минуса
            }
        }
    }
}
