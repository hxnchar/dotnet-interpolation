namespace Interpolation
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelAvailablePoints = new System.Windows.Forms.Label();
            this.ListBoxAvailablePoints = new System.Windows.Forms.ListBox();
            this.TextBoxAddCoords = new System.Windows.Forms.TextBox();
            this.ButtonAddPoint = new System.Windows.Forms.Button();
            this.LabelError = new System.Windows.Forms.Label();
            this.GroupBoxSettings = new System.Windows.Forms.GroupBox();
            this.ButtonStatistic = new System.Windows.Forms.Button();
            this.CalculateError = new System.Windows.Forms.Label();
            this.ButtonExport = new System.Windows.Forms.Button();
            this.RadioButtonNewton = new System.Windows.Forms.RadioButton();
            this.RadioButtonLinear = new System.Windows.Forms.RadioButton();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.LabelResult = new System.Windows.Forms.Label();
            this.TextBoxSoughtX = new System.Windows.Forms.TextBox();
            this.LabelSoughtX = new System.Windows.Forms.Label();
            this.ButtonRemovePoint = new System.Windows.Forms.Button();
            this.DragAndDropPanel = new System.Windows.Forms.PictureBox();
            this.LabelDragAndDropCaption = new System.Windows.Forms.Label();
            this.LabelDragAndDropHint = new System.Windows.Forms.Label();
            this.GroupBoxPoints = new System.Windows.Forms.GroupBox();
            this.ButtonClearList = new System.Windows.Forms.Button();
            this.ChartVisualization = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.GroupBoxSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DragAndDropPanel)).BeginInit();
            this.GroupBoxPoints.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVisualization)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAvailablePoints
            // 
            this.labelAvailablePoints.AutoSize = true;
            this.labelAvailablePoints.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelAvailablePoints.Location = new System.Drawing.Point(8, 25);
            this.labelAvailablePoints.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelAvailablePoints.Name = "labelAvailablePoints";
            this.labelAvailablePoints.Size = new System.Drawing.Size(119, 21);
            this.labelAvailablePoints.TabIndex = 1;
            this.labelAvailablePoints.Text = "Наявні точки:";
            // 
            // ListBoxAvailablePoints
            // 
            this.ListBoxAvailablePoints.FormattingEnabled = true;
            this.ListBoxAvailablePoints.ItemHeight = 21;
            this.ListBoxAvailablePoints.Location = new System.Drawing.Point(162, 52);
            this.ListBoxAvailablePoints.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.ListBoxAvailablePoints.Name = "ListBoxAvailablePoints";
            this.ListBoxAvailablePoints.Size = new System.Drawing.Size(142, 109);
            this.ListBoxAvailablePoints.TabIndex = 0;
            // 
            // TextBoxAddCoords
            // 
            this.TextBoxAddCoords.Location = new System.Drawing.Point(162, 168);
            this.TextBoxAddCoords.Name = "TextBoxAddCoords";
            this.TextBoxAddCoords.Size = new System.Drawing.Size(142, 29);
            this.TextBoxAddCoords.TabIndex = 2;
            // 
            // ButtonAddPoint
            // 
            this.ButtonAddPoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonAddPoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonAddPoint.FlatAppearance.BorderSize = 0;
            this.ButtonAddPoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAddPoint.Location = new System.Drawing.Point(6, 162);
            this.ButtonAddPoint.Name = "ButtonAddPoint";
            this.ButtonAddPoint.Size = new System.Drawing.Size(142, 39);
            this.ButtonAddPoint.TabIndex = 3;
            this.ButtonAddPoint.Text = "Додати точку";
            this.ButtonAddPoint.UseVisualStyleBackColor = false;
            this.ButtonAddPoint.Click += new System.EventHandler(this.ButtonAddPoint_Click);
            this.ButtonAddPoint.MouseLeave += new System.EventHandler(this.ButtonAddPoint_MouseLeave);
            this.ButtonAddPoint.MouseHover += new System.EventHandler(this.ButtonAddPoint_MouseHover);
            // 
            // LabelError
            // 
            this.LabelError.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelError.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelError.Location = new System.Drawing.Point(8, 216);
            this.LabelError.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelError.Name = "LabelError";
            this.LabelError.Size = new System.Drawing.Size(296, 45);
            this.LabelError.TabIndex = 4;
            this.LabelError.Text = "Помилка Помилка Помилка Помилка Помилка Помилка ";
            this.LabelError.Visible = false;
            // 
            // GroupBoxSettings
            // 
            this.GroupBoxSettings.Controls.Add(this.ButtonStatistic);
            this.GroupBoxSettings.Controls.Add(this.CalculateError);
            this.GroupBoxSettings.Controls.Add(this.ButtonExport);
            this.GroupBoxSettings.Controls.Add(this.RadioButtonNewton);
            this.GroupBoxSettings.Controls.Add(this.RadioButtonLinear);
            this.GroupBoxSettings.Controls.Add(this.TextBoxResult);
            this.GroupBoxSettings.Controls.Add(this.ButtonCalculate);
            this.GroupBoxSettings.Controls.Add(this.LabelResult);
            this.GroupBoxSettings.Controls.Add(this.TextBoxSoughtX);
            this.GroupBoxSettings.Controls.Add(this.LabelSoughtX);
            this.GroupBoxSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.GroupBoxSettings.Location = new System.Drawing.Point(12, 289);
            this.GroupBoxSettings.Name = "GroupBoxSettings";
            this.GroupBoxSettings.Size = new System.Drawing.Size(317, 280);
            this.GroupBoxSettings.TabIndex = 5;
            this.GroupBoxSettings.TabStop = false;
            this.GroupBoxSettings.Text = "Налаштування";
            // 
            // ButtonStatistic
            // 
            this.ButtonStatistic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonStatistic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonStatistic.FlatAppearance.BorderSize = 0;
            this.ButtonStatistic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonStatistic.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonStatistic.Location = new System.Drawing.Point(225, 244);
            this.ButtonStatistic.Name = "ButtonStatistic";
            this.ButtonStatistic.Size = new System.Drawing.Size(79, 25);
            this.ButtonStatistic.TabIndex = 13;
            this.ButtonStatistic.Text = "Статистика";
            this.ButtonStatistic.UseVisualStyleBackColor = false;
            this.ButtonStatistic.Click += new System.EventHandler(this.StatisticButton_Click);
            // 
            // CalculateError
            // 
            this.CalculateError.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculateError.ForeColor = System.Drawing.Color.Gainsboro;
            this.CalculateError.Location = new System.Drawing.Point(8, 143);
            this.CalculateError.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.CalculateError.Name = "CalculateError";
            this.CalculateError.Size = new System.Drawing.Size(287, 45);
            this.CalculateError.TabIndex = 7;
            this.CalculateError.Text = "Помилка Помилка Помилка Помилка Помилка Помилка ";
            this.CalculateError.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CalculateError.Visible = false;
            // 
            // ButtonExport
            // 
            this.ButtonExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonExport.FlatAppearance.BorderSize = 0;
            this.ButtonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExport.Location = new System.Drawing.Point(162, 194);
            this.ButtonExport.Name = "ButtonExport";
            this.ButtonExport.Size = new System.Drawing.Size(142, 39);
            this.ButtonExport.TabIndex = 12;
            this.ButtonExport.Text = "Експорт";
            this.ButtonExport.UseVisualStyleBackColor = false;
            this.ButtonExport.Click += new System.EventHandler(this.ButtonExport_Click);
            this.ButtonExport.MouseLeave += new System.EventHandler(this.ButtonExport_MouseLeave);
            this.ButtonExport.MouseHover += new System.EventHandler(this.ButtonExport_MouseHover);
            // 
            // RadioButtonNewton
            // 
            this.RadioButtonNewton.AutoSize = true;
            this.RadioButtonNewton.Checked = true;
            this.RadioButtonNewton.ForeColor = System.Drawing.Color.Gainsboro;
            this.RadioButtonNewton.Location = new System.Drawing.Point(12, 113);
            this.RadioButtonNewton.Name = "RadioButtonNewton";
            this.RadioButtonNewton.Size = new System.Drawing.Size(282, 25);
            this.RadioButtonNewton.TabIndex = 11;
            this.RadioButtonNewton.TabStop = true;
            this.RadioButtonNewton.Text = "Інтерполяція методом Ньютона";
            this.RadioButtonNewton.UseVisualStyleBackColor = true;
            this.RadioButtonNewton.MouseLeave += new System.EventHandler(this.RadioButtonNewton_MouseLeave);
            this.RadioButtonNewton.MouseHover += new System.EventHandler(this.RadioButtonNewton_MouseHover);
            // 
            // RadioButtonLinear
            // 
            this.RadioButtonLinear.AutoSize = true;
            this.RadioButtonLinear.ForeColor = System.Drawing.Color.Gainsboro;
            this.RadioButtonLinear.Location = new System.Drawing.Point(12, 82);
            this.RadioButtonLinear.Name = "RadioButtonLinear";
            this.RadioButtonLinear.Size = new System.Drawing.Size(193, 25);
            this.RadioButtonLinear.TabIndex = 10;
            this.RadioButtonLinear.TabStop = true;
            this.RadioButtonLinear.Text = "Лінійна інтерполяція";
            this.RadioButtonLinear.UseVisualStyleBackColor = true;
            this.RadioButtonLinear.MouseLeave += new System.EventHandler(this.RadioButtonLinear_MouseLeave);
            this.RadioButtonLinear.MouseHover += new System.EventHandler(this.RadioButtonLinear_MouseHover);
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxResult.Location = new System.Drawing.Point(100, 242);
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.ReadOnly = true;
            this.TextBoxResult.Size = new System.Drawing.Size(119, 29);
            this.TextBoxResult.TabIndex = 9;
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCalculate.FlatAppearance.BorderSize = 0;
            this.ButtonCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCalculate.Location = new System.Drawing.Point(12, 194);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(142, 39);
            this.ButtonCalculate.TabIndex = 7;
            this.ButtonCalculate.Text = "Підрахувати";
            this.ButtonCalculate.UseVisualStyleBackColor = false;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            this.ButtonCalculate.MouseLeave += new System.EventHandler(this.ButtonCalculate_MouseLeave);
            this.ButtonCalculate.MouseHover += new System.EventHandler(this.ButtonCalculate_MouseHover);
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelResult.Location = new System.Drawing.Point(8, 246);
            this.LabelResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(90, 21);
            this.LabelResult.TabIndex = 8;
            this.LabelResult.Text = "Результат:";
            // 
            // TextBoxSoughtX
            // 
            this.TextBoxSoughtX.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSoughtX.Location = new System.Drawing.Point(264, 37);
            this.TextBoxSoughtX.Name = "TextBoxSoughtX";
            this.TextBoxSoughtX.Size = new System.Drawing.Size(40, 29);
            this.TextBoxSoughtX.TabIndex = 6;
            // 
            // LabelSoughtX
            // 
            this.LabelSoughtX.ForeColor = System.Drawing.Color.Gainsboro;
            this.LabelSoughtX.Location = new System.Drawing.Point(8, 28);
            this.LabelSoughtX.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelSoughtX.Name = "LabelSoughtX";
            this.LabelSoughtX.Size = new System.Drawing.Size(248, 46);
            this.LabelSoughtX.TabIndex = 6;
            this.LabelSoughtX.Text = "Значення функції у якій точці необхідно визначити?";
            // 
            // ButtonRemovePoint
            // 
            this.ButtonRemovePoint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonRemovePoint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonRemovePoint.FlatAppearance.BorderSize = 0;
            this.ButtonRemovePoint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemovePoint.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonRemovePoint.Location = new System.Drawing.Point(6, 56);
            this.ButtonRemovePoint.Name = "ButtonRemovePoint";
            this.ButtonRemovePoint.Size = new System.Drawing.Size(142, 39);
            this.ButtonRemovePoint.TabIndex = 6;
            this.ButtonRemovePoint.Text = "Вилучити точку";
            this.ButtonRemovePoint.UseVisualStyleBackColor = false;
            this.ButtonRemovePoint.Click += new System.EventHandler(this.ButtonRemovePoint_Click);
            // 
            // DragAndDropPanel
            // 
            this.DragAndDropPanel.BackColor = System.Drawing.Color.Teal;
            this.DragAndDropPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DragAndDropPanel.Location = new System.Drawing.Point(2009, 9);
            this.DragAndDropPanel.Margin = new System.Windows.Forms.Padding(0);
            this.DragAndDropPanel.Name = "DragAndDropPanel";
            this.DragAndDropPanel.Size = new System.Drawing.Size(1026, 560);
            this.DragAndDropPanel.TabIndex = 8;
            this.DragAndDropPanel.TabStop = false;
            // 
            // LabelDragAndDropCaption
            // 
            this.LabelDragAndDropCaption.BackColor = System.Drawing.Color.Transparent;
            this.LabelDragAndDropCaption.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDragAndDropCaption.ForeColor = System.Drawing.Color.White;
            this.LabelDragAndDropCaption.Location = new System.Drawing.Point(2009, 230);
            this.LabelDragAndDropCaption.Name = "LabelDragAndDropCaption";
            this.LabelDragAndDropCaption.Size = new System.Drawing.Size(1026, 68);
            this.LabelDragAndDropCaption.TabIndex = 9;
            this.LabelDragAndDropCaption.Text = "Перетягніть сюди файли";
            this.LabelDragAndDropCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelDragAndDropHint
            // 
            this.LabelDragAndDropHint.BackColor = System.Drawing.Color.Transparent;
            this.LabelDragAndDropHint.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelDragAndDropHint.ForeColor = System.Drawing.Color.White;
            this.LabelDragAndDropHint.Location = new System.Drawing.Point(2009, 293);
            this.LabelDragAndDropHint.Name = "LabelDragAndDropHint";
            this.LabelDragAndDropHint.Size = new System.Drawing.Size(1026, 40);
            this.LabelDragAndDropHint.TabIndex = 10;
            this.LabelDragAndDropHint.Text = "Перетягніть файли формату .txt, щоб додати координати  точок до списку";
            this.LabelDragAndDropHint.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupBoxPoints
            // 
            this.GroupBoxPoints.Controls.Add(this.ButtonClearList);
            this.GroupBoxPoints.Controls.Add(this.labelAvailablePoints);
            this.GroupBoxPoints.Controls.Add(this.ListBoxAvailablePoints);
            this.GroupBoxPoints.Controls.Add(this.TextBoxAddCoords);
            this.GroupBoxPoints.Controls.Add(this.ButtonRemovePoint);
            this.GroupBoxPoints.Controls.Add(this.LabelError);
            this.GroupBoxPoints.Controls.Add(this.ButtonAddPoint);
            this.GroupBoxPoints.ForeColor = System.Drawing.Color.Gainsboro;
            this.GroupBoxPoints.Location = new System.Drawing.Point(12, 12);
            this.GroupBoxPoints.Name = "GroupBoxPoints";
            this.GroupBoxPoints.Size = new System.Drawing.Size(318, 271);
            this.GroupBoxPoints.TabIndex = 11;
            this.GroupBoxPoints.TabStop = false;
            this.GroupBoxPoints.Text = "Точки даних";
            // 
            // ButtonClearList
            // 
            this.ButtonClearList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ButtonClearList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClearList.FlatAppearance.BorderSize = 0;
            this.ButtonClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearList.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonClearList.Location = new System.Drawing.Point(6, 113);
            this.ButtonClearList.Name = "ButtonClearList";
            this.ButtonClearList.Size = new System.Drawing.Size(142, 39);
            this.ButtonClearList.TabIndex = 7;
            this.ButtonClearList.Text = "Очистити список";
            this.ButtonClearList.UseVisualStyleBackColor = false;
            this.ButtonClearList.Click += new System.EventHandler(this.ButtonClearList_Click);
            // 
            // ChartVisualization
            // 
            this.ChartVisualization.BackColor = System.Drawing.Color.Transparent;
            chartArea1.AlignmentOrientation = ((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations)((System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Vertical | System.Windows.Forms.DataVisualization.Charting.AreaAlignmentOrientations.Horizontal)));
            chartArea1.AxisX.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.MaximumAutoSize = 90F;
            chartArea1.AxisX.MinorGrid.LineColor = System.Drawing.Color.WhiteSmoke;
            chartArea1.AxisX.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisX.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Times New Roman", 8F);
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea1.AxisX2.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX2.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX2.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX2.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.White;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MaximumAutoSize = 90F;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.MinorTickMark.LineColor = System.Drawing.Color.Gainsboro;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.Gainsboro;
            chartArea1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.IsSameFontSizeForAllAxes = true;
            chartArea1.Name = "ChartArea1";
            this.ChartVisualization.ChartAreas.Add(chartArea1);
            legend1.Alignment = System.Drawing.StringAlignment.Center;
            legend1.BackColor = System.Drawing.Color.Gainsboro;
            legend1.Enabled = false;
            legend1.ForeColor = System.Drawing.Color.Gainsboro;
            legend1.HeaderSeparatorColor = System.Drawing.Color.Gainsboro;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.Gainsboro;
            legend1.Name = "Legend1";
            legend1.TitleForeColor = System.Drawing.Color.Gainsboro;
            legend1.TitleSeparatorColor = System.Drawing.Color.Gainsboro;
            this.ChartVisualization.Legends.Add(legend1);
            this.ChartVisualization.Location = new System.Drawing.Point(342, 21);
            this.ChartVisualization.Name = "ChartVisualization";
            this.ChartVisualization.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Color = System.Drawing.Color.Gainsboro;
            series1.Legend = "Legend1";
            series1.MarkerColor = System.Drawing.Color.Gainsboro;
            series1.Name = "calculatedValues";
            series2.BorderColor = System.Drawing.Color.LightSeaGreen;
            series2.BorderWidth = 20;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.Color = System.Drawing.Color.LightSeaGreen;
            series2.Legend = "Legend1";
            series2.MarkerColor = System.Drawing.Color.Gainsboro;
            series2.MarkerSize = 7;
            series2.Name = "availablePoints";
            series3.BorderColor = System.Drawing.Color.Red;
            series3.BorderWidth = 10;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series3.Color = System.Drawing.Color.Red;
            series3.IsVisibleInLegend = false;
            series3.Legend = "Legend1";
            series3.MarkerColor = System.Drawing.Color.Gainsboro;
            series3.MarkerSize = 7;
            series3.Name = "soughtValue";
            series3.SmartLabelStyle.CalloutLineColor = System.Drawing.Color.White;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Series4";
            this.ChartVisualization.Series.Add(series1);
            this.ChartVisualization.Series.Add(series2);
            this.ChartVisualization.Series.Add(series3);
            this.ChartVisualization.Series.Add(series4);
            this.ChartVisualization.Size = new System.Drawing.Size(690, 548);
            this.ChartVisualization.TabIndex = 12;
            this.ChartVisualization.Text = "chart1";
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(1044, 581);
            this.Controls.Add(this.LabelDragAndDropHint);
            this.Controls.Add(this.LabelDragAndDropCaption);
            this.Controls.Add(this.DragAndDropPanel);
            this.Controls.Add(this.GroupBoxSettings);
            this.Controls.Add(this.GroupBoxPoints);
            this.Controls.Add(this.ChartVisualization);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Інтерполяція";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.DragLeave += new System.EventHandler(this.MainForm_DragLeave);
            this.GroupBoxSettings.ResumeLayout(false);
            this.GroupBoxSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DragAndDropPanel)).EndInit();
            this.GroupBoxPoints.ResumeLayout(false);
            this.GroupBoxPoints.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartVisualization)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelAvailablePoints;
        private System.Windows.Forms.ListBox ListBoxAvailablePoints;
        private System.Windows.Forms.TextBox TextBoxAddCoords;
        private System.Windows.Forms.Button ButtonAddPoint;
        private System.Windows.Forms.Label LabelError;
        private System.Windows.Forms.GroupBox GroupBoxSettings;
        private System.Windows.Forms.TextBox TextBoxSoughtX;
        private System.Windows.Forms.Label LabelSoughtX;
        private System.Windows.Forms.Button ButtonRemovePoint;
        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Label LabelResult;
        private System.Windows.Forms.PictureBox DragAndDropPanel;
        private System.Windows.Forms.Label LabelDragAndDropCaption;
        private System.Windows.Forms.Label LabelDragAndDropHint;
        private System.Windows.Forms.Button ButtonExport;
        private System.Windows.Forms.RadioButton RadioButtonNewton;
        private System.Windows.Forms.RadioButton RadioButtonLinear;
        private System.Windows.Forms.GroupBox GroupBoxPoints;
        private System.Windows.Forms.Label CalculateError;
        private System.Windows.Forms.Button ButtonClearList;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChartVisualization;
        private System.Windows.Forms.Button ButtonStatistic;
    }
}

