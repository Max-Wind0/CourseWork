using System;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitializeComboBox();
            IntervalTText.Text = "1";
            NumberOfElementsText.Text = "100";
            NumberOfPointsText.Text = "100";
            ParameterX0Text.Text = "1";
            ErrorLabel.Text = "Ошибка: NaN";
        }

        private void InitializeComboBox()
        {
            // Добавление вариантов выбора функций в комбобокс
            FunctionChoice.Items.Add("y = x * sin(PI * x)");
            FunctionChoice.Items.Add("y = x^2 * cos(x)");
            FunctionChoice.Items.Add("y = x^2 * exp(-x)");

            // Выбор первого элемента по умолчанию
            FunctionChoice.SelectedIndex = 0;
        }

        private void CreatePlotButton_Click(object sender, EventArgs e)
        {
            // Создание новой задачи
            Task task = new Task();
            task.Function = FunctionChoice.SelectedItem.ToString();
            task.IntervalTText = IntervalTText.Text;
            task.NumberOfElementsText = NumberOfElementsText.Text;
            task.NumberOfPointsText = NumberOfPointsText.Text;
            task.ParameterX0Text = ParameterX0Text.Text;

            // Очистка места для нового графика
            PlotBox.Controls.Clear();

            // Создание решения для дальнейшего построения графика
            var solution = TaskController.SolveEquation(task);

            // Построение графика по полученному решению
            GraphicController.CreatePlot(PlotBox,solution.RealSeries, solution.PredictedSeries);

            // Вывод в специальное поле ошибки полученного решения
            ErrorLabel.Text = $"Ошибка: {solution.error}";
        }

        private void IntervalTText_Leave(object sender, EventArgs e)
        {
            // Проверка введенного пользователем интервала на формат Double
            CreatePlotButton.Enabled = true;
            errorProviderIntervalT.Clear();
            if (!double.TryParse(IntervalTText.Text, out double canBeParsed) || canBeParsed == 0)
            {
                CreatePlotButton.Enabled = false;
                IntervalTText.Text = "1";
                errorProviderIntervalT.SetError(IntervalTText, "Неправильный формат ввода." +
                    "Необходимо ввести действительное число больше 0");
            }
        }

        private void NumberOfElementsText_Leave(object sender, EventArgs e)
        {
            // Проверка введенного пользователем числа элементов на формат Int
            CreatePlotButton.Enabled = true;
            errorProviderNumberOfElements.Clear();
            if (!int.TryParse(NumberOfElementsText.Text, out int canBeParsed)
                || canBeParsed == 0)
            {
                CreatePlotButton.Enabled = false;
                NumberOfElementsText.Text = "100";
                errorProviderNumberOfElements.SetError(NumberOfElementsText, 
                    "Неправильный формат ввода. Необходимо ввести целое число больше 0");
            }
        }

        private void NumberOfPointsText_Leave(object sender, EventArgs e)
        {
            // Проверка введенного пользователем количества точек на формат Int
            CreatePlotButton.Enabled = true;
            errorProviderNumberOfPoints.Clear();
            if (!int.TryParse(NumberOfPointsText.Text, out int canBeParsed) || canBeParsed < 3)
            {
                CreatePlotButton.Enabled = false;
                NumberOfPointsText.Text = "100";
                errorProviderNumberOfPoints.SetError(NumberOfPointsText,
                    "Неправильный формат ввода. Необходимо ввести целое число больше 2");
            }
        }

        private void ParameterX0Text_Leave(object sender, EventArgs e)
        {
            // Проверка введенного пользователем параметра x0 на формат Double
            CreatePlotButton.Enabled = true;
            errorProviderParameterX0.Clear();
            if (!double.TryParse(ParameterX0Text.Text, out double canBeParsed))
            {
                CreatePlotButton.Enabled = false;
                ParameterX0Text.Text = "1";
                errorProviderParameterX0.SetError(ParameterX0Text, "Неправильный формат ввода.");
            }
        }

        private void DoubleInputCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Вызов функции проверки ввода на формат Double
            MainProgram.DoubleInputCheck_KeyPress(sender, e);
        }

        private void PositiveDoubleInputCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Вызов функции проверки ввода на формат Double
            MainProgram.PositiveDoubleInputCheck_KeyPress(sender, e);
        }

        private void IntInputCheck_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Вызов функции проверки ввода на формат Int
            MainProgram.IntInputCheck_KeyPress(sender, e);
        }
    }
}
