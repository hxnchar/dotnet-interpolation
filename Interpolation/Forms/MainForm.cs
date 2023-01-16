using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Interpolation.Classes;

namespace Interpolation
{
    public partial class MainForm : Form
    {
        #region Кольори
        private const string redColor = "#ff2950";
        private const string lightBlueColor = "#4287f5";
        private const string darkBlueColor = "#325ca8";
        #endregion

        #region Змінні 
        private List<MyPoint> pointsList = new List<MyPoint>();
        private List<double> finiteDifference = new List<double>();
        private bool linearMethod = false;
        private int countIterations = 0, countStepsChart = 0;
        private double soughtX, soughtY;
        private string converted = "";
        #endregion

        #region Головна форма

        //Ініціалізує компоненти форми
        public MainForm()
        {
            InitializeComponent();
        }

        //Викликається при завантаженні форми
        //Змінює координати та колір панелі для перетягнення файлів та основної форми
        private void MainForm_Load(object sender, EventArgs e)
        {
            #region Початкові координати та кольори елементів
            #region Панель для перетягнення файлів
            DragAndDropPanel.BackColor = ColorTranslator.FromHtml(lightBlueColor);
            LabelDragAndDropCaption.BackColor = ColorTranslator.FromHtml(lightBlueColor);
            LabelDragAndDropHint.BackColor = ColorTranslator.FromHtml(lightBlueColor);
            DragAndDropPanel.Location = new Point(9, 9);
            LabelDragAndDropCaption.Location = new Point(9, 230);
            LabelDragAndDropHint.Location = new Point(9, 293);
            ShowDragAndDropPanel(false);
            #endregion
            #region Основна форма
            this.ActiveControl = TextBoxAddCoords;
            this.BackColor = ColorTranslator.FromHtml(darkBlueColor);
            #endregion
            #endregion
        }

        //Викликається при наведенні файлом на форму
        //Отримує розширення перетягненного файлу та показує відповідну панель
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
            string filePath = ((string[])e.Data.GetData(DataFormats.FileDrop))[0];
            string fileExtension = filePath.Split('.')[filePath.Split('.').Length - 1];
            if (fileExtension == "txt")
                ShowDragAndDropPanel();
            else ShowDragAndDropPanel(true, true);
        }

        //Викликається при перенесенні файлу на форму
        //Отримує шлях до перетягненного на форму файлу та
        //якщо файл розширення .txt додає точки
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string filePath = ((string[])(e.Data.GetData(DataFormats.FileDrop)))[0];
            string fileExtension = filePath.Split('.')[filePath.Split('.').Length - 1];
            if (fileExtension == "txt")
            {
                try
                {
                    List<MyPoint> samePoints = new List<MyPoint>();
                    int countSought = 0;
                    using (StreamReader sr = new StreamReader(filePath))
                    {
                        string currentString;
                        while ((currentString = sr.ReadLine()) != null)
                        {
                            try
                            {
                                MyPoint tempPoint = PointsUtilities.StringToPoint(currentString);
                                if (!PointsUtilities.PointIsAlreadyInList(pointsList, tempPoint.X)) pointsList.Add(tempPoint);
                                else samePoints.Add(tempPoint);
                            }
                            catch (Exception)
                            {
                                countSought++;
                                if (countSought == 1) TextBoxSoughtX.Text = PointsUtilities.StringToSoughtX(currentString);
                            }
                        }
                    }
                    ListBoxAvailablePoints.Items.Clear();
                    PointsUtilities.SortListOfPoints(pointsList);
                    PointsUtilities.ListToListBox(ListBoxAvailablePoints, pointsList);
                    ShowDragAndDropPanel(false);
                    LabelError.Visible = false;
                    if (samePoints.Count != 0) MessageBox.Show($"{FormUtilities.ImportErrorMessage(samePoints.Count)}, оскільки аргументи мають бути унікальними.", "Помилка");
                    if (countSought >= 2) MessageBox.Show($"Ви можете ввести не більше 1 точки для інтерполяції.", "Попередження");
                }
                catch (Exception)
                {
                    LabelError.Text = "Кожна точка має починатися з нового рядку; координати розділені символом «;».";
                    LabelError.Visible = true;
                    ShowDragAndDropPanel(false);
                }
            }
            else
            {
                ShowDragAndDropPanel(false);
                MessageBox.Show("Необхідно перетягнути файл формату .txt", "Помилка");
            }
        }

        //Викликається при прибиранні файлу з форми
        //Панель перестає показуватися користувачу до наступного
        //перетягнення файлу
        private void MainForm_DragLeave(object sender, EventArgs e)
        {
            ShowDragAndDropPanel(false);
        }

        #endregion

        #region Панель для перетаскування файлів

        //Метод, який показує панель для перетягнення файлу
        private void ShowDragAndDropPanel(bool show = true, bool error = false)
        {
            if (show)
            {
                if (!error)
                {
                    DragAndDropPanel.BackColor = ColorTranslator.FromHtml(lightBlueColor);

                    LabelDragAndDropCaption.BackColor = ColorTranslator.FromHtml(lightBlueColor);
                    LabelDragAndDropCaption.Text = "Перетягніть сюди файли";

                    LabelDragAndDropHint.BackColor = ColorTranslator.FromHtml(lightBlueColor);
                    LabelDragAndDropHint.Text = "Перетягніть файли формату .txt, щоб додати координати  точок до списку";
                }
                else
                {
                    DragAndDropPanel.BackColor = ColorTranslator.FromHtml(redColor);

                    LabelDragAndDropCaption.BackColor = ColorTranslator.FromHtml(redColor);
                    LabelDragAndDropCaption.Text = "Файли мають бути формату .txt";

                    LabelDragAndDropHint.BackColor = ColorTranslator.FromHtml(redColor);
                    LabelDragAndDropHint.Text = "";
                }
                DragAndDropPanel.Visible = true;
                LabelDragAndDropCaption.Visible = true;
                LabelDragAndDropHint.Visible = true;
            }
            else
            {
                DragAndDropPanel.Visible = false;
                LabelDragAndDropCaption.Visible = false;
                LabelDragAndDropHint.Visible = false;
            }
        }

        #endregion

        #region Додати точку

        //Викликається при натисненні на кнопку
        //Перевіряє правильність форматування та додає точку даних
        private void ButtonAddPoint_Click(object sender, EventArgs e)
        {
            try
            {
                MyPoint tempPoint = PointsUtilities.StringToPoint(TextBoxAddCoords.Text);

                if(!PointsUtilities.PointIsAlreadyInList(pointsList, tempPoint.X)) pointsList.Add(tempPoint);
                else throw new Exception();

                PointsUtilities.SortListOfPoints(pointsList);
                ListBoxAvailablePoints.Items.Clear();
                PointsUtilities.ListToListBox(ListBoxAvailablePoints, pointsList);

                LabelError.Visible = false;
                TextBoxAddCoords.Text = "";
            }
            catch (IndexOutOfRangeException)
            {
                LabelError.Text = "Необхідно коректно ввести координати точки, використвуючи «;».";
                LabelError.Visible = true;
            }
            catch (Exception)
            {
                LabelError.Text = "Аргументи не мають повторюватися.";
                LabelError.Visible = true;
            }
        }

        //Викликається при наведенні мишкою на кнопку
        //Перевіряє поле з координатами на те, щоб воно не було порожнім
        private void ButtonAddPoint_MouseHover(object sender, EventArgs e)
        {
            if (TextBoxAddCoords.Text == "")
            {
                LabelError.Text = "Необхідно ввести координати у поле праворуч";
                LabelError.Visible = true;
            }
        }

        //Викликається при відведенні мишки від кнопки
        //Перевіряє поле з координатами на те, щоб воно не було порожнім
        private void ButtonAddPoint_MouseLeave(object sender, EventArgs e)
        {
            LabelError.Visible = false;
        }

        #endregion

        #region Видалити точку

        //Викликається при натисненні на кнопку
        //Вилучає точку за списку
        private void ButtonRemovePoint_Click(object sender, EventArgs e)
        {
            try
            {
                PointsUtilities.RemovePointFromTheList(ref pointsList, PointsUtilities.StringToPoint(ListBoxAvailablePoints.SelectedItem.ToString()));
                ListBoxAvailablePoints.Items.Clear();
                PointsUtilities.ListToListBox(ListBoxAvailablePoints, pointsList);
                LabelError.Visible = false;
            }
            catch (System.NullReferenceException)
            {
                LabelError.Text = "Для вилучення точки зі списку, її необхідно обрати.";
                LabelError.Visible = true;
            }
            
        }

        #endregion

        #region Очистити список

        //Викликається при натисненні на кнопку
        //Очищає список точок
        private void ButtonClearList_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Ви впевненні, що хочете видалити всі точки зі списку?", "Очистити список", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                TextBoxResult.Text = "";
                TextBoxSoughtX.Text = "";
                ChartVisualization.Series[0].Points.Clear();
                ChartVisualization.Series[1].Points.Clear();
                ChartVisualization.Series[2].Points.Clear();
                ChartVisualization.Series[3].Points.Clear();
                pointsList.Clear();
                ListBoxAvailablePoints.Items.Clear();
            }
        }

        #endregion

        #region Лінійна інтерполяція

        //Викликається при наведенні на кнопку
        //Перевіряє умови для лінійної інтерполяції та
        //за необхідності виводить помилку
        private void RadioButtonLinear_MouseHover(object sender, EventArgs e)
        {
            if (pointsList.Count < 2)
            {
                CalculateError.Text = "Для інтерполяції необхідно ввести, як мінімум, 2 точки";
                CalculateError.Visible = true;
            }
            else if (pointsList.Count > 2)
            {
                CalculateError.Text = "Лінійна інтерполяція доступна лише для 2 точок";
                CalculateError.Visible = true;
            }
        }

        //Викликається при відведені курсору від кнопки
        //Прибирає помилку 
        private void RadioButtonLinear_MouseLeave(object sender, EventArgs e)
        {
            CalculateError.Visible = false;
        }

        #endregion

        #region Інтерполяція методом Ньютона

        //Викликається при наведенні на кнопку
        //Перевіряє умови для лінійної інтерполяції та
        //за необхідності виводить помилку 
        private void RadioButtonNewton_MouseHover(object sender, EventArgs e)
        {
            if (pointsList.Count < 2)
            {
                CalculateError.Text = "Для інтерполяції необхідно ввести, як мінімум, 2 точки.";
                CalculateError.Visible = true;
            }
        }

        //Викликається при відведені курсору від кнопки
        //Прибирає помилку 
        private void RadioButtonNewton_MouseLeave(object sender, EventArgs e)
        {
            CalculateError.Visible = false;
        }

        #endregion

        #region Підрахунки

        //Викликається при наведенні на кнопку
        //Перевіряє умови для інтерполяції та
        //виводить помилки
        private void ButtonCalculate_MouseHover(object sender, EventArgs e)
        {
            if (pointsList.Count < 2)
            {
                CalculateError.Text = "Для інтерполяції необхідно ввести, як мінімум, 2 точки.";
                CalculateError.Visible = true;
            }
            else if (TextBoxSoughtX.Text == "")
            {
                CalculateError.Text = "Необхідно ввести вузол інтерполяції.";
                CalculateError.Visible = true;
            }
        }

        //Викликається при натисненні на кнопку
        //Перевіряє умови для інтерполяції та
        //виводить помилки
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                soughtX = double.Parse(TextBoxSoughtX.Text);
                soughtY = 0;
                countIterations = 0;
                countStepsChart = 0;
                converted = "";
                finiteDifference.Clear();
                CalculateError.Visible = false;
                linearMethod = false;

                Interpolate.Calculate(pointsList, soughtX, ref soughtY, ref countIterations, ref countStepsChart, ref converted, finiteDifference, CalculateError, RadioButtonLinear, RadioButtonNewton, TextBoxResult, ref linearMethod, ChartVisualization);
            }
            catch (Exception)
            {
                CalculateError.Text = "Введіть вузол інтерполяції";
                CalculateError.Visible = true;
            }
        }

        //Викликається при відведені курсору від кнопки
        //Прибирає помилку
        private void ButtonCalculate_MouseLeave(object sender, EventArgs e)
        {
            CalculateError.Visible = false;
        }

        #endregion

        #region Експорт

        //Викликається при наведенні на кнопку
        //Перевіряє умови для лінійної інтерполяції та
        //за необхідності виводить помилку
        private void ButtonExport_MouseHover(object sender, EventArgs e)
        {
            if (TextBoxResult.Text == "")
            {
                CalculateError.Text = "Ви не можете експортувати, доки не отримаєте значення функції.";
                CalculateError.Visible = true;
            }
            else
                CalculateError.Visible = false;
        }

        //Викликається при натисненні на кнопку
        //Виводить інформацію у текстовий документ
        private void ButtonExport_Click(object sender, EventArgs e)
        {
            FormUtilities.ExportInfromation(TextBoxSoughtX, TextBoxResult, pointsList, linearMethod, converted, CalculateError);
        }

        //ВикликаєтьсяВикликається при відведені курсору від кнопки
        //Прибирає помилку
        private void ButtonExport_MouseLeave(object sender, EventArgs e)
        {
            CalculateError.Visible = false;
        }

        #endregion

        #region Статистика

        //Викликається при наведенні на кнопку
        //Отримує статистику у вигляді строки та
        //виводить її у діаологове вікно
        private void StatisticButton_Click(object sender, EventArgs e)
        {
            string report = linearMethod ? FormUtilities.LinearReport(pointsList, converted) : FormUtilities.NewtonReport(pointsList, countIterations, countStepsChart, converted);
            MessageBox.Show(report, "Статистика");
        }

        #endregion
    }
}