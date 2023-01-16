using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace Interpolation.Classes
{
    class FormUtilities
    {
        #region Відображення повідомлень

        //Відображає помилку при імпорті точок
        public static string ImportErrorMessage(int countPoints)
        {
            if (countPoints == 1 || countPoints % 10 == 1 && countPoints != 11)
                return $"{countPoints} точка не була імпортована";
            else if (countPoints >= 2 && countPoints <= 4 || countPoints % 10 >= 2 && countPoints % 10 <= 4 && !(countPoints >= 12 && countPoints <= 14))
                return $"{countPoints} точки не були імпортовані";
            else
                return $"{countPoints} точок не були імпортовані";
        }

        //Відображає кількість кроків
        public static string StatisticMessage(int countPoints)
        {
            if (countPoints == 1 || countPoints % 10 == 1 && countPoints != 11)
                return $"{countPoints} крок";
            else if (countPoints >= 2 && countPoints <= 4 || countPoints % 10 >= 2 && countPoints % 10 <= 4 && !(countPoints >= 12 && countPoints <= 14))
                return $"{countPoints} кроки";
            else
                return $"{countPoints} кроків";
        }

        #endregion

        #region Експорт результатів

        //Виводить рядок із заданої кількості символів «=»
        private static string OutLine(int count = 30)
        {
            string line = "";
            for (int i = 0; i < count; i++)
            {
                line += '=';
            }
            return line;
        }

        //Повертає число у вигляді 2 цифр
        private static string GetFormattedNum(int inputInt)
        {
            if (inputInt <= 9)
                return "0" + inputInt.ToString();
            else
                return inputInt.ToString();
        }

        //Повертає поточний час
        private static string GetTime() => $"{GetFormattedNum(DateTime.Now.Hour)}-{GetFormattedNum(DateTime.Now.Minute)}-{GetFormattedNum(DateTime.Now.Second)}";

        //Повертає поточну дату
        private static string GetDate() => $"{GetFormattedNum(DateTime.Now.Day)}.{GetFormattedNum(DateTime.Now.Month)}.{GetFormattedNum(DateTime.Now.Year)}";

        //Генерує звіт, якщо було використано метод лінійної інтерполяції
        public static string LinearReport(List<MyPoint> pointsList, string converted)
        {
            return $"Кількість вузлів інтерполяції: {pointsList.Count};\n" +
                $"Метод: лінійна інтерполяція;\n" +
                $"Отримана функція: {converted}.";
        }

        //Генерує звіт, якщо було використано інтерполяцію методом Ньютона
        public static string NewtonReport(List<MyPoint> pointsList, int countIterations, int countStepsChart, string converted)
        {
            return $"Кількість вузлів інтерполяції: {pointsList.Count};\n" +
                $"Метод: інтерполяція методом Ньютона;\n" +
                $"Побудова біному: {StatisticMessage(countIterations)};\n" +
                $"Біном Ньютона: {converted};\n" +
                $"Побудова біному: {StatisticMessage(countStepsChart)}.";
        }

        //Генерує документ із отриманими результатами
        public static void ExportInfromation(TextBox TextBoxSoughtX, TextBox TextBoxResult, List<MyPoint> pointsList, bool linearMethod, string converted, Label CalculateError)
        {
            try
            {
                double soughtX = double.Parse(TextBoxSoughtX.Text);
                double soughtY = double.Parse(TextBoxResult.Text);
                string path = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\Interpolation results";
                string fileName = $"Інтерполяція — {FormUtilities.GetDate()}, {FormUtilities.GetTime()}";

                using (SaveFileDialog file = new SaveFileDialog())
                {
                    file.Filter = "Текстові документи|*.txt";
                    file.Title = "Збереження результатів інтерполяції";
                    file.FileName = fileName;
                    if (!Directory.Exists(path)) Directory.CreateDirectory(path);
                    file.InitialDirectory = path;
                    file.RestoreDirectory = true;
                    if (file.ShowDialog() == DialogResult.OK)
                    {
                        using (StreamWriter sw = new StreamWriter($"{file.FileName}.txt"))
                        {
                            sw.WriteLine($"{fileName}");
                            sw.WriteLine(FormUtilities.OutLine());
                            sw.WriteLine($"Наявні точки даних ({pointsList.Count} шт.):");
                            foreach (var point in pointsList)
                            {
                                sw.WriteLine(point.ToString());
                            }
                            sw.WriteLine(FormUtilities.OutLine());
                            sw.Write("Було використано ");
                            if (linearMethod)
                            {
                                sw.WriteLine("метод лінійної інтерполяції.");
                                sw.WriteLine("Отримана функція:");
                                sw.WriteLine($"{converted}");
                            }
                            else
                            {
                                sw.WriteLine("інтерполяцію методом Ньютона.");
                                sw.WriteLine("Отриманий біном:");
                                sw.WriteLine($"{converted}");
                            }
                            sw.WriteLine(FormUtilities.OutLine());
                            sw.WriteLine($"Значення функції у точці {soughtX} = {soughtY}");
                            sw.Close();
                        }
                    }
                }
                CalculateError.Visible = false;
            }
            catch (Exception)
            {
                CalculateError.Text = "Необхідно інтерполювати функцію";
                CalculateError.Visible = true;
            }
        }

        #endregion
    }
}
