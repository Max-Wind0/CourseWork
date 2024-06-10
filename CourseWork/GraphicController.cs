using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot;
using System.Drawing;
using System.Windows.Forms;

namespace CourseWork
{
    internal class GraphicController
    {
        /// <summary>
        /// Функция создания нового графика
        /// </summary>
        public static void CreatePlot(PictureBox PlotBox, FunctionSeries functionSeries, FunctionSeries predictedSeries)
        {
            // Создание нового графика
            OxyPlot.WindowsForms.PlotView plotView = new PlotView();

            // Задание расположения левого верхнего угла графика
            plotView.Location = new Point(0, 0);

            // Задание размеров графика
            plotView.Size = new Size(650, 400);

            // Задание места, относительно котого будет построен график
            PlotBox.Controls.Add(plotView);

            // Задание названия графика
            plotView.Model = new PlotModel { Title = "График численного решения" };

            // Создание осей
            var xAxis = new LinearAxis { Position = AxisPosition.Bottom, Title = "t", FontSize = 14 };
            var yAxis = new LinearAxis { Position = AxisPosition.Left, Title = "y ( t )", FontSize = 14 };

            // Добавление осей к графику
            plotView.Model.Axes.Add(xAxis);
            plotView.Model.Axes.Add(yAxis);

            // Добавление данных графика
            functionSeries.Color = OxyColors.Red;
            plotView.Model.Series.Add(functionSeries);
            predictedSeries.Color = OxyColors.Black;
            predictedSeries.LineStyle = LineStyle.Dash;
            plotView.Model.Series.Add(predictedSeries);
        }
    }
}
