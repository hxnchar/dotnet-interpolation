using MathNet.Symbolics;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Interpolation.Classes
{
    class Interpolate
    {
        private static readonly double step = 0.1;

        #region Лінійна інтерполяція

        private static double Linear(List<MyPoint> pointsList, double soughtX, ref string converted)
        {
            MyPoint point1 = new MyPoint();
            MyPoint point2 = new MyPoint();

            for (int i = 1; i < pointsList.Count; i++)
            {
                if(PointsUtilities.PointIsBetween(pointsList[i-1], pointsList[i], soughtX))
                {
                    point1 = pointsList[i - 1];
                    point2 = pointsList[i];
                    break;
                }
            }

            double soughtY = (soughtX - point1.X) * (point2.Y - point1.Y) / (point2.X - point1.X) + point1.Y;
            converted = $"{point2.Y - point1.Y}*(x-{point1.X})/{point2.X-point1.X}+{point1.Y}";
            converted = converted.Replace(',', '.');
            converted = "y = " + Infix.Format(Algebraic.Expand(Infix.ParseOrThrow(converted)));

            return soughtY;
        }

        private static double Linear(List<MyPoint> pointsList, double soughtX)
        {
            MyPoint point1 = new MyPoint();
            MyPoint point2 = new MyPoint();

            for (int i = 1; i < pointsList.Count; i++)
            {
                if (PointsUtilities.PointIsBetween(pointsList[i - 1], pointsList[i], soughtX))
                {
                    point1 = pointsList[i - 1];
                    point2 = pointsList[i];
                    break;
                }
            }

            double soughtY = (soughtX - point1.X) * (point2.Y - point1.Y) / (point2.X - point1.X) + point1.Y;

            return soughtY;
        }

        private static void DrawLinear(List<MyPoint> pointsList, double soughtX, Chart myChart)
        {
            myChart.Series[0].Points.Clear();
            myChart.Series[1].Points.Clear();
            myChart.Series[2].Points.Clear();
            myChart.Series[3].Points.Clear();
            myChart.Series[3].Points.AddXY(pointsList[0].X, pointsList[0].Y);
            for (int i = 1; i < pointsList.Count; i++)
            {
                myChart.Series[3].Points.AddXY(pointsList[i].X, pointsList[i].Y);
                myChart.Series[1].Points.AddXY(pointsList[i - 1].X, pointsList[i - 1].Y);
                myChart.Series[1].Points.AddXY(pointsList[i].X, pointsList[i].Y);
            }
            myChart.Series[2].Points.AddXY(soughtX, Linear(pointsList, soughtX));
        }

        #endregion

        #region Інтерполяція методом Ньютона

        //Метод інтерполяції методом Ньютона для побудови графіку
        private static double NewtonInterpolation(List<MyPoint> pointsList, double soughtX, ref int countIterations)
        {
            double soughtY = 0;
            List<double> finiteDifference = new List<double>();
            CalcCoefficients(pointsList, ref finiteDifference);
            for (int i = 1; i < pointsList.Count; i++)
            {
                double tempSoughtY = finiteDifference[i];
                for (int k = 0; k < i; k++)
                {
                    tempSoughtY *= (soughtX - pointsList[k].X);
                }
                soughtY += tempSoughtY;
                countIterations += 1;
            }
            soughtY += finiteDifference[0];
            countIterations += 1;
            return soughtY;
        }

        //Метод інтерполяції методом Ньютона для підрахування значення та зведеного поліному Ньютона
        private static double NewtonInterpolation(List<MyPoint> pointsList, double soughtX, ref int countIterations, ref List<double> finiteDifference, ref string converted)
        {
            double soughtY = 0, tempSoughtY;
            CalcCoefficients(pointsList, ref finiteDifference);
            for (int i = 0; i < finiteDifference.Count; i++)
            {
                if (i == 0)
                {
                    soughtY += finiteDifference[i];
                    converted += $"{finiteDifference[i]}";
                }
                else
                {
                    tempSoughtY = finiteDifference[i];
                    if (finiteDifference[i] >= 0) converted += $"+{Math.Round(finiteDifference[i], 4)}";
                    else converted += $"-{Math.Round(Math.Abs(finiteDifference[i]), 4)}";
                    for (int k = 0; k < i; k++)
                    {
                        converted += $"*(x-{pointsList[k].X})";
                        tempSoughtY *= (soughtX - pointsList[k].X);
                    }
                    soughtY += tempSoughtY;
                }
                countIterations += 1;
            }
            converted = converted.Replace(',', '.');
            converted = Infix.Format(Algebraic.Expand(Infix.ParseOrThrow(converted)));
            converted = $"P{pointsList.Count}(x) = " + converted;
            return soughtY;
        }

        //Виведення графіку поліному Ньютона
        private static void DrawNewton(List<MyPoint> pointsList, double soughtX, Chart myChart, ref int countIterations)
        {
            myChart.Series[0].Points.Clear();
            myChart.Series[1].Points.Clear();
            myChart.Series[2].Points.Clear();
            myChart.Series[3].Points.Clear();

            double tempX = pointsList[0].X;
            double lastX = pointsList[pointsList.Count - 1].X;

            while (Math.Round(tempX, 5) <= lastX)
            {
                myChart.Series[0].Points.AddXY(tempX, NewtonInterpolation(pointsList, tempX, ref countIterations));
                tempX += step;
            }

            foreach (var point in pointsList)
            {
                myChart.Series[1].Points.AddXY(point.X, point.Y);
            }

            myChart.Series[2].Points.AddXY(soughtX, NewtonInterpolation(pointsList, soughtX, ref countIterations));
        }

        //Підрахунок біноміальних коефіцієнтів
        private static void CalcCoefficients(List<MyPoint> pointsList, ref List<double> coefs)
        {
            if (pointsList.Count >= 1)
            {
                List<double> finiteDifference = new List<double>();
                for (int i = 0; i < pointsList.Count - 1; i++)
                {
                    finiteDifference.Add((pointsList[i + 1].Y - pointsList[i].Y) / (pointsList[i + coefs.Count + 1].X - pointsList[i].X));
                }
                coefs.Add(pointsList[0].Y);
                CalcCoefficients(pointsList, finiteDifference, ref coefs);
            }
        }

        //Підрахунок біноміальних коефіцієнтів
        private static void CalcCoefficients(List<MyPoint> pointsList, List<double> finiteDifference, ref List<double> coefs)
        {
            if (finiteDifference.Count >= 1)
            {
                List<double> newFiniteDifference = new List<double>();
                for (int i = 0; i < finiteDifference.Count - 1; i++)
                {
                    newFiniteDifference.Add((finiteDifference[i + 1] - finiteDifference[i]) / (pointsList[i + coefs.Count + 1].X - pointsList[i].X));
                }
                coefs.Add(finiteDifference[0]);
                CalcCoefficients(pointsList, newFiniteDifference, ref coefs);
            }
        }

        #endregion

        public static void Calculate(List<MyPoint> pointsList, double soughtX, ref double soughtY, ref int countIterations, ref int countStepsChart, ref string converted, List<double> finiteDifference, Label CalculateError, RadioButton RadioButtonLinear, RadioButton RadioButtonNewton, TextBox TextBoxResult, ref bool linearMethod, Chart ChartVisualization)
        {
            if (CalculateError.Visible == false)
            {
                try
                {
                    if (RadioButtonLinear.Checked && PointsUtilities.PointIsBetween(pointsList, soughtX))
                    {
                        soughtY = Linear(pointsList, soughtX, ref converted);
                        DrawLinear(pointsList, soughtX, ChartVisualization);
                        TextBoxResult.Text = Math.Round(soughtY, 4).ToString();
                        linearMethod = true;
                    }
                    else if (RadioButtonLinear.Checked && pointsList.Count != 2)
                    {
                        CalculateError.Text = "Лінійна інтерполяція може бути застосована тільки для 2 точок.";
                        CalculateError.Visible = true;
                    }
                    else if (!PointsUtilities.PointIsBetween(pointsList, soughtX))
                    {
                        CalculateError.Text = "Вузол інтерполяції має лежати між іншими точками.";
                        CalculateError.Visible = true;
                    }
                    else if (RadioButtonNewton.Checked && pointsList.Count < 2)
                    {
                        CalculateError.Text = "Необхідно ввести не менше 2 точок даних.";
                        CalculateError.Visible = true;
                    }
                    else if (RadioButtonNewton.Checked && PointsUtilities.PointIsBetween(pointsList, soughtX))
                    {
                        soughtY = NewtonInterpolation(pointsList, soughtX, ref countIterations, ref finiteDifference, ref converted);
                        DrawNewton(pointsList, soughtX, ChartVisualization, ref countStepsChart);
                        linearMethod = false;
                        TextBoxResult.Text = Math.Round(soughtY, 4).ToString();
                    }
                }
                catch (Exception)
                {
                    CalculateError.Text = "Помилка.";
                    CalculateError.Visible = true;
                }
            }
        }

    }
}
