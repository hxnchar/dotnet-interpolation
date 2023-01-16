using System.Collections.Generic;
using System.Windows.Forms;

namespace Interpolation.Classes
{
    class PointsUtilities
    {
        #region Робота зі списком точок

        //Повертає список без заданої точки
        public static void RemovePointFromTheList(ref List<MyPoint> oldPointsList, MyPoint pointToBeRemoved)
        {
            List<MyPoint> newPointsList = new List<MyPoint>();
            foreach (var currentPoint in oldPointsList)
            {
                if (!PointsAreSame(currentPoint, pointToBeRemoved))
                {
                    newPointsList.Add(currentPoint);
                }
            }
            oldPointsList = newPointsList;
        }

        //Сортує список точок за їх аргументом
        public static void SortListOfPoints(List<MyPoint> pointsList)
        {
            for (int i = 0; i < pointsList.Count - 1; i++)
            {
                int j = i + 1;
                while (j > 0 && pointsList[j].X < pointsList[j - 1].X)
                {
                    MyPoint tempPoint = pointsList[j];
                    pointsList[j] = pointsList[j - 1];
                    pointsList[j - 1] = tempPoint;
                    j--;
                }
            }
        }

        //Виводить список точок на форму
        public static void ListToListBox(ListBox listBox, List<MyPoint> pointsList)
        {
            foreach (var point in pointsList)
            {
                listBox.Items.Add(point.ToString());
            }
        }

        //Перевіряє, чи є точка із таким самим аргументом у списку
        public static bool PointIsAlreadyInList(List<MyPoint> pointsList, double soughtX)
        {
            foreach (var point in pointsList)
            {
                if (point.X == soughtX) return true;
            }
            return false;
        }

        //Перевіряє належність точки до проміжку між крайніми точками даних
        public static bool PointIsBetween(List<MyPoint> pointsList, double soughtX)
        {
            MyPoint point1 = pointsList[0];
            MyPoint point2 = pointsList[pointsList.Count - 1];

            return soughtX > point1.X && soughtX < point2.X;
        }
        public static bool PointIsBetween(MyPoint point1, MyPoint point2, double soughtX)
        {
            return soughtX > point1.X && soughtX < point2.X;
        }

        #endregion

        #region Робота із рядками

        //Переводить строку у точку
        public static MyPoint StringToPoint(string inputString)
        {
            inputString = inputString.Replace(' ', ';');
            inputString = inputString.Replace(";;", ";");
            string[] cords = inputString.Split(';');
            return new MyPoint(cords[0], cords[1]);
        }

        //Переводить строку у вузол інтерполяції
        public static string StringToSoughtX(string inputString)
        {
            if (inputString.Contains("?"))
            {
                inputString = inputString.Replace("?", " ?");
                string[] str = inputString.Split(' ');
                return str[0];
            }
            return "Помилка";
        }

        #endregion

        //Перевіряє рівність аргументів та значень 2 точок
        private static bool PointsAreSame(MyPoint point1, MyPoint point2)
        {
            return point1.X == point2.X && point1.Y == point2.Y;
        }
    }
}
