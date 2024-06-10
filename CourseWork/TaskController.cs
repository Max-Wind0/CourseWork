using OxyPlot;
using OxyPlot.Series;
using System;

namespace CourseWork
{
    internal class TaskController
    {
        /// <summary>
        /// Функция численное решение уравнения и получение точек графика
        /// </summary>
        public static Solution SolveEquation(Task task)
        {
            // Создание новой серии точек
            FunctionSeries functionSeriesPoints = new FunctionSeries();
            FunctionSeries predictedSeriesPoints = new FunctionSeries();

            // Задание количества точек графика и интервала по оси t. Расчёт шага дискретизации графика
            int NumberOfPoints = int.Parse(task.NumberOfPointsText);
            double IntervalT = double.Parse(task.IntervalTText);
            double StepOfX = IntervalT / NumberOfPoints;

            // Задание параметра альфа и расчёт оператора регуляризации
            double Alpha = 0.000001;
            double Zeta = Alpha / (StepOfX * StepOfX);

            // Задание множителя x0 в ядре интегрального уравнения и количества элементов суммы
            double ParameterX0 = double.Parse(task.ParameterX0Text);
            int NumberOfElements = int.Parse(task.NumberOfElementsText);

            // Создание массивов для хранения координат точек графика
            double[] ArrayOfX = new double[NumberOfPoints];
            double[] ArrayOfFunctionPoints = new double[NumberOfPoints];
            double[] ArrayOfPredictedPoints = new double[NumberOfPoints];

            // Заполнение массивов точек графика
            switch (task.Function)
            {
                case "y = x * sin(PI * x)":
                    for (int i = 0; i < NumberOfPoints; i++)
                    {
                        double x = StepOfX * i;
                        ArrayOfX[i] = x;
                        ArrayOfFunctionPoints[i] = x * Math.Sin(Math.PI * x);
                        ArrayOfPredictedPoints[i] = (1 / ParameterX0) * 2 * Math.PI * Math.Cos(Math.PI * x)
                            - Math.Pow(Math.PI, 2) * x * Math.Sin(Math.PI * x);
                    }
                    break;

                case "y = x^2 * cos(x)":
                    for (int i = 0; i < NumberOfPoints; i++)
                    {
                        double x = StepOfX * i;
                        ArrayOfX[i] = x;
                        ArrayOfFunctionPoints[i] = Math.Pow(x, 2) * Math.Cos(x);
                        ArrayOfPredictedPoints[i] = (1 / ParameterX0) * 2 * Math.Cos(x) -
                            4 * x * Math.Sin(x) - Math.Pow(x, 2) * Math.Cos(x);
                    }
                    break;

                case "y = x^2 * exp(-x)":
                    for (int i = 0; i < NumberOfPoints; i++)
                    {
                        double x = StepOfX * i;
                        ArrayOfX[i] = x;
                        ArrayOfFunctionPoints[i] = Math.Pow(x, 2) * Math.Exp(-x);
                        ArrayOfPredictedPoints[i] = (1 / ParameterX0) * Math.Exp(-x) *
                            (2 - 4 * x + Math.Pow(x, 2));
                    }
                    break;

                default:
                    break;
            }

            // Создание матрицы для хранения значений ядра интегрального оператора
            double[,] CoreMatrix = new double[NumberOfPoints, NumberOfPoints];

            // Заполнение матрицы 
            for (int i = 0; i < NumberOfPoints; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    CoreMatrix[i, j] = CoreController.Core((i + 1) * StepOfX, (j + 1) * StepOfX,
                        ParameterX0, NumberOfElements);
                }
            }

            // Создание матрицы коэффициентов системы линейных уравнений и матрицы регуляризующего оператора
            double[,] A = new double[NumberOfPoints, NumberOfPoints];
            double[,] S = new double[NumberOfPoints, NumberOfPoints];

            // Заполнение матрицы коэффициентов СЛАУ
            for (int kp = 0; kp < NumberOfPoints; kp++)
            {
                for (int ip = 0; ip < NumberOfPoints; ip++)
                {
                    double sum = 0.0;
                    for (int jp = 0; jp < NumberOfPoints; jp++)
                    {
                        sum += CoreMatrix[jp, ip] * CoreMatrix[jp, kp];
                    }
                    A[kp, ip] = sum;
                }
            }

            // Заполнение матрицы регуляризующим оператором
            S[0, 0] = Zeta;
            S[0, 1] = -Zeta;
            for (int ix = 1; ix < NumberOfPoints - 1; ix++)
            {
                S[ix, ix - 1] -= Zeta;
                S[ix, ix + 0] += 2 * Zeta;
                S[ix, ix + 1] -= Zeta;
            }
            S[NumberOfPoints - 1, NumberOfPoints - 2] = Zeta;
            S[NumberOfPoints - 1, NumberOfPoints - 1] = -Zeta;

            // Создание дополнения к матрице А для дальнейшего решения СЛАУ
            double[] B = new double[NumberOfPoints];

            // Заполнение дополнения к матрице А
            for (int i = 0; i < NumberOfPoints; i++)
            {
                double sum = 0.0;
                for (int j = 0; j < NumberOfPoints; j++)
                {
                    sum += CoreMatrix[j, i] * ArrayOfFunctionPoints[j] / StepOfX;
                }
                B[i] = sum;
            }

            // Сложение матриц A и S (метод регуляризации Тихонова)
            for (int i = 0; i < NumberOfPoints; i++)
            {
                for (int j = 0; j < NumberOfPoints; j++)
                {
                    A[i, j] += S[i, j];
                }
            }

            // Вызов функции для решения СЛАУ
            double[] ArrayOfY = MatrixController.SolveMatrix(A, B);

            // Создание нового экземпляра класса решения интегрального уравнения
            Solution solution = new Solution();

            // Расчёт ошибки при решение обратной задачи теплообмена (отличие идеального от полученного)
            double error = CalculateError(ArrayOfY, ArrayOfPredictedPoints);
            solution.error = error;

            // Добавление точек графика в серию 
            for (int i = 0; i < ArrayOfY.Length; i++)
            {
                functionSeriesPoints.Points.Add(new DataPoint(ArrayOfX[i], ArrayOfY[i]));
                predictedSeriesPoints.Points.Add(new DataPoint(ArrayOfX[i], ArrayOfPredictedPoints[i]));
            }
            solution.RealSeries = functionSeriesPoints;
            solution.PredictedSeries = predictedSeriesPoints;

            // Возращение серии точек для дальнейшего построения графика
            return solution;
        }

        /// <summary>
        /// Метод для подсчёта ошибки (различие между ожидаемым значением и полученным)
        /// </summary>
        static double CalculateError(double[] res, double[] expected)
        {
            double error = 0.0;
            for (int i = 0; i < res.Length; i++)
            {
                error += Math.Pow(res[i] - expected[i], 2);
            }
            return Math.Sqrt(error);
        }
    }
}
