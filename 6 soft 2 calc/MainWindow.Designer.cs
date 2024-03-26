namespace _6_soft_2_calc
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            tabControl = new TabControl();
            tab1 = new TabPage();
            tableMain = new TableLayoutPanel();
            tableCalculatorButtons = new TableLayoutPanel();
            buttonSqrt = new Button();
            buttonEqual = new Button();
            buttonClearEdit = new Button();
            buttonClear = new Button();
            buttonM = new Button();
            buttonMC = new Button();
            buttonMR = new Button();
            buttonMS = new Button();
            buttonMPlus = new Button();
            button3 = new Button();
            button6 = new Button();
            button9 = new Button();
            buttonC = new Button();
            buttonF = new Button();
            buttonD = new Button();
            buttonE = new Button();
            buttonA = new Button();
            buttonB = new Button();
            button8 = new Button();
            button5 = new Button();
            button2 = new Button();
            buttonChangeSign = new Button();
            button4 = new Button();
            button7 = new Button();
            buttonDelimeter = new Button();
            buttonSquare = new Button();
            buttonReverse = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonMultiply = new Button();
            buttonDivision = new Button();
            button0 = new Button();
            button1 = new Button();
            buttonBackSpace = new Button();
            buttonPI = new Button();
            tableChangeNotation = new TableLayoutPanel();
            trackBarNotation = new TrackBar();
            tableNotation = new TableLayoutPanel();
            labelNotationValue = new Label();
            labelNotationText = new Label();
            tableResult = new TableLayoutPanel();
            labelResult = new Label();
            textBoxFormula = new TextBox();
            tab2 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            labelHistoryText = new Label();
            listBoxHistoryRecords = new ListBox();
            buttonClearHistory = new Button();
            tab3 = new TabPage();
            tableLayoutPanelOptions = new TableLayoutPanel();
            tableLayoutPanelCalculationModeOption = new TableLayoutPanel();
            labelCalculationModeOption = new Label();
            tableLayoutPanelCurrentCalculationMode = new TableLayoutPanel();
            labelCurrentCalculationModeText = new Label();
            labelCurrentCalculationModeValue = new Label();
            buttonChangeCurrentCalculationMode = new Button();
            tab4 = new TabPage();
            labelInfo = new Label();
            toolTip = new ToolTip(components);
            tabControl.SuspendLayout();
            tab1.SuspendLayout();
            tableMain.SuspendLayout();
            tableCalculatorButtons.SuspendLayout();
            tableChangeNotation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarNotation).BeginInit();
            tableNotation.SuspendLayout();
            tableResult.SuspendLayout();
            tab2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tab3.SuspendLayout();
            tableLayoutPanelOptions.SuspendLayout();
            tableLayoutPanelCalculationModeOption.SuspendLayout();
            tableLayoutPanelCurrentCalculationMode.SuspendLayout();
            tab4.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControl.Controls.Add(tab1);
            tabControl.Controls.Add(tab2);
            tabControl.Controls.Add(tab3);
            tabControl.Controls.Add(tab4);
            tabControl.ItemSize = new Size(70, 20);
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(285, 463);
            tabControl.SizeMode = TabSizeMode.FillToRight;
            tabControl.TabIndex = 0;
            // 
            // tab1
            // 
            tab1.Controls.Add(tableMain);
            tab1.Location = new Point(4, 24);
            tab1.Name = "tab1";
            tab1.Padding = new Padding(3);
            tab1.Size = new Size(277, 435);
            tab1.TabIndex = 0;
            tab1.Text = "Калькулятор";
            tab1.UseVisualStyleBackColor = true;
            // 
            // tableMain
            // 
            tableMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableMain.ColumnCount = 1;
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableMain.Controls.Add(tableCalculatorButtons, 0, 1);
            tableMain.Controls.Add(tableChangeNotation, 0, 2);
            tableMain.Controls.Add(tableResult, 0, 0);
            tableMain.Location = new Point(0, 0);
            tableMain.Name = "tableMain";
            tableMain.RowCount = 3;
            tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableMain.Size = new Size(277, 435);
            tableMain.TabIndex = 0;
            // 
            // tableCalculatorButtons
            // 
            tableCalculatorButtons.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableCalculatorButtons.ColumnCount = 5;
            tableCalculatorButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666679F));
            tableCalculatorButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableCalculatorButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableCalculatorButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableCalculatorButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 16.6666641F));
            tableCalculatorButtons.Controls.Add(buttonSqrt, 0, 6);
            tableCalculatorButtons.Controls.Add(buttonEqual, 4, 6);
            tableCalculatorButtons.Controls.Add(buttonClearEdit, 0, 2);
            tableCalculatorButtons.Controls.Add(buttonClear, 0, 1);
            tableCalculatorButtons.Controls.Add(buttonM, 0, 0);
            tableCalculatorButtons.Controls.Add(buttonMC, 1, 0);
            tableCalculatorButtons.Controls.Add(buttonMR, 2, 0);
            tableCalculatorButtons.Controls.Add(buttonMS, 3, 0);
            tableCalculatorButtons.Controls.Add(buttonMPlus, 4, 0);
            tableCalculatorButtons.Controls.Add(button3, 3, 5);
            tableCalculatorButtons.Controls.Add(button6, 3, 4);
            tableCalculatorButtons.Controls.Add(button9, 3, 3);
            tableCalculatorButtons.Controls.Add(buttonC, 3, 2);
            tableCalculatorButtons.Controls.Add(buttonF, 3, 1);
            tableCalculatorButtons.Controls.Add(buttonD, 1, 1);
            tableCalculatorButtons.Controls.Add(buttonE, 2, 1);
            tableCalculatorButtons.Controls.Add(buttonA, 1, 2);
            tableCalculatorButtons.Controls.Add(buttonB, 2, 2);
            tableCalculatorButtons.Controls.Add(button8, 2, 3);
            tableCalculatorButtons.Controls.Add(button5, 2, 4);
            tableCalculatorButtons.Controls.Add(button2, 2, 5);
            tableCalculatorButtons.Controls.Add(buttonChangeSign, 2, 6);
            tableCalculatorButtons.Controls.Add(button4, 1, 4);
            tableCalculatorButtons.Controls.Add(button7, 1, 3);
            tableCalculatorButtons.Controls.Add(buttonDelimeter, 3, 6);
            tableCalculatorButtons.Controls.Add(buttonSquare, 0, 4);
            tableCalculatorButtons.Controls.Add(buttonReverse, 0, 5);
            tableCalculatorButtons.Controls.Add(buttonPlus, 4, 5);
            tableCalculatorButtons.Controls.Add(buttonMinus, 4, 4);
            tableCalculatorButtons.Controls.Add(buttonMultiply, 4, 3);
            tableCalculatorButtons.Controls.Add(buttonDivision, 4, 2);
            tableCalculatorButtons.Controls.Add(button0, 1, 6);
            tableCalculatorButtons.Controls.Add(button1, 1, 5);
            tableCalculatorButtons.Controls.Add(buttonBackSpace, 0, 3);
            tableCalculatorButtons.Controls.Add(buttonPI, 4, 1);
            tableCalculatorButtons.Location = new Point(0, 65);
            tableCalculatorButtons.Margin = new Padding(0);
            tableCalculatorButtons.Name = "tableCalculatorButtons";
            tableCalculatorButtons.RowCount = 7;
            tableCalculatorButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableCalculatorButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableCalculatorButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableCalculatorButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableCalculatorButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableCalculatorButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableCalculatorButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2857141F));
            tableCalculatorButtons.Size = new Size(277, 304);
            tableCalculatorButtons.TabIndex = 0;
            // 
            // buttonSqrt
            // 
            buttonSqrt.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSqrt.Location = new Point(3, 261);
            buttonSqrt.Name = "buttonSqrt";
            buttonSqrt.Size = new Size(49, 40);
            buttonSqrt.TabIndex = 35;
            buttonSqrt.Tag = "29";
            buttonSqrt.Text = "sqrt(x)";
            toolTip.SetToolTip(buttonSqrt, "Найти корень текущего числа");
            buttonSqrt.UseVisualStyleBackColor = true;
            // 
            // buttonEqual
            // 
            buttonEqual.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonEqual.Location = new Point(223, 261);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(51, 40);
            buttonEqual.TabIndex = 21;
            buttonEqual.Tag = "22";
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            // 
            // buttonClearEdit
            // 
            buttonClearEdit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonClearEdit.Location = new Point(3, 89);
            buttonClearEdit.Name = "buttonClearEdit";
            buttonClearEdit.Size = new Size(49, 37);
            buttonClearEdit.TabIndex = 32;
            buttonClearEdit.Tag = "19";
            buttonClearEdit.Text = "CE";
            toolTip.SetToolTip(buttonClearEdit, "Удалить текущее число");
            buttonClearEdit.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            buttonClear.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonClear.Location = new Point(3, 46);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(49, 37);
            buttonClear.TabIndex = 31;
            buttonClear.Tag = "18";
            buttonClear.Text = "Clear";
            toolTip.SetToolTip(buttonClear, "Удалить выражение");
            buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonM
            // 
            buttonM.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonM.Location = new Point(3, 3);
            buttonM.Name = "buttonM";
            buttonM.Size = new Size(49, 37);
            buttonM.TabIndex = 0;
            buttonM.Tag = "30";
            buttonM.Text = "M";
            toolTip.SetToolTip(buttonM, "Узнать текущее значение памяти");
            buttonM.UseVisualStyleBackColor = true;
            // 
            // buttonMC
            // 
            buttonMC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonMC.Location = new Point(58, 3);
            buttonMC.Name = "buttonMC";
            buttonMC.Size = new Size(49, 37);
            buttonMC.TabIndex = 1;
            buttonMC.Tag = "31";
            buttonMC.Text = "MC";
            toolTip.SetToolTip(buttonMC, "Очистить память");
            buttonMC.UseVisualStyleBackColor = true;
            // 
            // buttonMR
            // 
            buttonMR.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonMR.Location = new Point(113, 3);
            buttonMR.Name = "buttonMR";
            buttonMR.Size = new Size(49, 37);
            buttonMR.TabIndex = 2;
            buttonMR.Tag = "32";
            buttonMR.Text = "MR";
            toolTip.SetToolTip(buttonMR, "Сделать текущее число равным значению памяти");
            buttonMR.UseVisualStyleBackColor = true;
            // 
            // buttonMS
            // 
            buttonMS.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonMS.Location = new Point(168, 3);
            buttonMS.Name = "buttonMS";
            buttonMS.Size = new Size(49, 37);
            buttonMS.TabIndex = 3;
            buttonMS.Tag = "33";
            buttonMS.Text = "MS";
            toolTip.SetToolTip(buttonMS, "Сохранить текущее значение в память");
            buttonMS.UseVisualStyleBackColor = true;
            // 
            // buttonMPlus
            // 
            buttonMPlus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonMPlus.Location = new Point(223, 3);
            buttonMPlus.Name = "buttonMPlus";
            buttonMPlus.Size = new Size(51, 37);
            buttonMPlus.TabIndex = 4;
            buttonMPlus.Tag = "34";
            buttonMPlus.Text = "M+";
            toolTip.SetToolTip(buttonMPlus, "Добавить текущее значение к памяти");
            buttonMPlus.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button3.Location = new Point(168, 218);
            button3.Name = "button3";
            button3.Size = new Size(49, 37);
            button3.TabIndex = 8;
            button3.Tag = "3";
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button6.Location = new Point(168, 175);
            button6.Name = "button6";
            button6.Size = new Size(49, 37);
            button6.TabIndex = 11;
            button6.Tag = "6";
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button9.Location = new Point(168, 132);
            button9.Name = "button9";
            button9.Size = new Size(49, 37);
            button9.TabIndex = 14;
            button9.Tag = "9";
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            // 
            // buttonC
            // 
            buttonC.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonC.Location = new Point(168, 89);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(49, 37);
            buttonC.TabIndex = 17;
            buttonC.Tag = "12";
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            // 
            // buttonF
            // 
            buttonF.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonF.Location = new Point(168, 46);
            buttonF.Name = "buttonF";
            buttonF.Size = new Size(49, 37);
            buttonF.TabIndex = 20;
            buttonF.Tag = "15";
            buttonF.Text = "F";
            buttonF.UseVisualStyleBackColor = true;
            // 
            // buttonD
            // 
            buttonD.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonD.Location = new Point(58, 46);
            buttonD.Name = "buttonD";
            buttonD.Size = new Size(49, 37);
            buttonD.TabIndex = 18;
            buttonD.Tag = "13";
            buttonD.Text = "D";
            buttonD.UseVisualStyleBackColor = true;
            // 
            // buttonE
            // 
            buttonE.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonE.Location = new Point(113, 46);
            buttonE.Name = "buttonE";
            buttonE.Size = new Size(49, 37);
            buttonE.TabIndex = 19;
            buttonE.Tag = "14";
            buttonE.Text = "E";
            buttonE.UseVisualStyleBackColor = true;
            // 
            // buttonA
            // 
            buttonA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonA.Location = new Point(58, 89);
            buttonA.Name = "buttonA";
            buttonA.Size = new Size(49, 37);
            buttonA.TabIndex = 15;
            buttonA.Tag = "10";
            buttonA.Text = "A";
            buttonA.UseVisualStyleBackColor = true;
            // 
            // buttonB
            // 
            buttonB.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonB.Location = new Point(113, 89);
            buttonB.Name = "buttonB";
            buttonB.Size = new Size(49, 37);
            buttonB.TabIndex = 16;
            buttonB.Tag = "11";
            buttonB.Text = "B";
            buttonB.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button8.Location = new Point(113, 132);
            button8.Name = "button8";
            button8.Size = new Size(49, 37);
            button8.TabIndex = 13;
            button8.Tag = "8";
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button5.Location = new Point(113, 175);
            button5.Name = "button5";
            button5.Size = new Size(49, 37);
            button5.TabIndex = 10;
            button5.Tag = "5";
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button2.Location = new Point(113, 218);
            button2.Name = "button2";
            button2.Size = new Size(49, 37);
            button2.TabIndex = 7;
            button2.Tag = "2";
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            // 
            // buttonChangeSign
            // 
            buttonChangeSign.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonChangeSign.Location = new Point(113, 261);
            buttonChangeSign.Name = "buttonChangeSign";
            buttonChangeSign.Size = new Size(49, 40);
            buttonChangeSign.TabIndex = 29;
            buttonChangeSign.Tag = "17";
            buttonChangeSign.Text = "+/-";
            toolTip.SetToolTip(buttonChangeSign, "Поменять знак текущего числа");
            buttonChangeSign.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button4.Location = new Point(58, 175);
            button4.Name = "button4";
            button4.Size = new Size(49, 37);
            button4.TabIndex = 9;
            button4.Tag = "4";
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button7.Location = new Point(58, 132);
            button7.Name = "button7";
            button7.Size = new Size(49, 37);
            button7.TabIndex = 12;
            button7.Tag = "7";
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            // 
            // buttonDelimeter
            // 
            buttonDelimeter.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDelimeter.Location = new Point(168, 261);
            buttonDelimeter.Name = "buttonDelimeter";
            buttonDelimeter.Size = new Size(49, 40);
            buttonDelimeter.TabIndex = 30;
            buttonDelimeter.Tag = "16";
            buttonDelimeter.Text = ".";
            toolTip.SetToolTip(buttonDelimeter, "Разделитель целой и дробной части");
            buttonDelimeter.UseVisualStyleBackColor = true;
            // 
            // buttonSquare
            // 
            buttonSquare.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonSquare.Location = new Point(3, 175);
            buttonSquare.Name = "buttonSquare";
            buttonSquare.Size = new Size(49, 37);
            buttonSquare.TabIndex = 26;
            buttonSquare.Tag = "27";
            buttonSquare.Text = "x^2";
            toolTip.SetToolTip(buttonSquare, "Возвести текущее число в квадрат");
            buttonSquare.UseVisualStyleBackColor = true;
            // 
            // buttonReverse
            // 
            buttonReverse.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonReverse.Location = new Point(3, 218);
            buttonReverse.Name = "buttonReverse";
            buttonReverse.Size = new Size(49, 37);
            buttonReverse.TabIndex = 27;
            buttonReverse.Tag = "28";
            buttonReverse.Text = "1/x";
            toolTip.SetToolTip(buttonReverse, "Найти число, обратное текущему");
            buttonReverse.UseVisualStyleBackColor = true;
            // 
            // buttonPlus
            // 
            buttonPlus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonPlus.Location = new Point(223, 218);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(51, 37);
            buttonPlus.TabIndex = 22;
            buttonPlus.Tag = "23";
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            // 
            // buttonMinus
            // 
            buttonMinus.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonMinus.Location = new Point(223, 175);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(51, 37);
            buttonMinus.TabIndex = 23;
            buttonMinus.Tag = "24";
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonMultiply.Location = new Point(223, 132);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(51, 37);
            buttonMultiply.TabIndex = 24;
            buttonMultiply.Tag = "25";
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            // 
            // buttonDivision
            // 
            buttonDivision.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonDivision.Location = new Point(223, 89);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(51, 37);
            buttonDivision.TabIndex = 25;
            buttonDivision.Tag = "26";
            buttonDivision.Text = "/";
            buttonDivision.UseVisualStyleBackColor = true;
            // 
            // button0
            // 
            button0.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button0.Location = new Point(58, 261);
            button0.Name = "button0";
            button0.Size = new Size(49, 40);
            button0.TabIndex = 6;
            button0.Tag = "0";
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(58, 218);
            button1.Name = "button1";
            button1.Size = new Size(49, 37);
            button1.TabIndex = 5;
            button1.Tag = "1";
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonBackSpace
            // 
            buttonBackSpace.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonBackSpace.Location = new Point(3, 132);
            buttonBackSpace.Name = "buttonBackSpace";
            buttonBackSpace.Size = new Size(49, 37);
            buttonBackSpace.TabIndex = 33;
            buttonBackSpace.Tag = "20";
            buttonBackSpace.Text = "BS";
            toolTip.SetToolTip(buttonBackSpace, "Удалить крайнюю правую цифру");
            buttonBackSpace.UseVisualStyleBackColor = true;
            // 
            // buttonPI
            // 
            buttonPI.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonPI.Location = new Point(223, 46);
            buttonPI.Name = "buttonPI";
            buttonPI.Size = new Size(51, 37);
            buttonPI.TabIndex = 34;
            buttonPI.Tag = "21";
            buttonPI.Text = "π";
            toolTip.SetToolTip(buttonPI, "Число ПИ");
            buttonPI.UseVisualStyleBackColor = true;
            // 
            // tableChangeNotation
            // 
            tableChangeNotation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableChangeNotation.ColumnCount = 1;
            tableChangeNotation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableChangeNotation.Controls.Add(trackBarNotation, 0, 0);
            tableChangeNotation.Controls.Add(tableNotation, 0, 1);
            tableChangeNotation.Location = new Point(0, 369);
            tableChangeNotation.Margin = new Padding(0);
            tableChangeNotation.Name = "tableChangeNotation";
            tableChangeNotation.RowCount = 2;
            tableChangeNotation.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableChangeNotation.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableChangeNotation.Size = new Size(277, 66);
            tableChangeNotation.TabIndex = 1;
            // 
            // trackBarNotation
            // 
            trackBarNotation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            trackBarNotation.Location = new Point(3, 3);
            trackBarNotation.Maximum = 16;
            trackBarNotation.Minimum = 2;
            trackBarNotation.Name = "trackBarNotation";
            trackBarNotation.Size = new Size(271, 27);
            trackBarNotation.TabIndex = 1;
            toolTip.SetToolTip(trackBarNotation, "Сдвиньте ползунок для изменения системы счисления");
            trackBarNotation.Value = 2;
            // 
            // tableNotation
            // 
            tableNotation.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableNotation.ColumnCount = 2;
            tableNotation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableNotation.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableNotation.Controls.Add(labelNotationValue, 1, 0);
            tableNotation.Controls.Add(labelNotationText, 0, 0);
            tableNotation.Location = new Point(0, 33);
            tableNotation.Margin = new Padding(0);
            tableNotation.Name = "tableNotation";
            tableNotation.RowCount = 1;
            tableNotation.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableNotation.Size = new Size(277, 33);
            tableNotation.TabIndex = 2;
            // 
            // labelNotationValue
            // 
            labelNotationValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNotationValue.AutoSize = true;
            labelNotationValue.BackColor = SystemColors.Control;
            labelNotationValue.Location = new Point(141, 3);
            labelNotationValue.Margin = new Padding(3);
            labelNotationValue.Name = "labelNotationValue";
            labelNotationValue.Size = new Size(133, 27);
            labelNotationValue.TabIndex = 1;
            labelNotationValue.TextAlign = ContentAlignment.MiddleCenter;
            toolTip.SetToolTip(labelNotationValue, "Текущая система счисления");
            // 
            // labelNotationText
            // 
            labelNotationText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelNotationText.AutoSize = true;
            labelNotationText.BackColor = SystemColors.Control;
            labelNotationText.Location = new Point(3, 3);
            labelNotationText.Margin = new Padding(3);
            labelNotationText.Name = "labelNotationText";
            labelNotationText.Size = new Size(132, 27);
            labelNotationText.TabIndex = 0;
            labelNotationText.Text = "Система счисления:";
            labelNotationText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableResult
            // 
            tableResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableResult.ColumnCount = 1;
            tableResult.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableResult.Controls.Add(labelResult, 0, 1);
            tableResult.Controls.Add(textBoxFormula, 0, 0);
            tableResult.Location = new Point(0, 0);
            tableResult.Margin = new Padding(0);
            tableResult.Name = "tableResult";
            tableResult.RowCount = 2;
            tableResult.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableResult.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableResult.Size = new Size(277, 65);
            tableResult.TabIndex = 2;
            // 
            // labelResult
            // 
            labelResult.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelResult.AutoSize = true;
            labelResult.Location = new Point(3, 35);
            labelResult.Margin = new Padding(3);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(271, 27);
            labelResult.TabIndex = 0;
            labelResult.Text = "0";
            labelResult.TextAlign = ContentAlignment.MiddleRight;
            toolTip.SetToolTip(labelResult, "Текущее значение калькулятора");
            // 
            // textBoxFormula
            // 
            textBoxFormula.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFormula.BorderStyle = BorderStyle.None;
            textBoxFormula.Location = new Point(3, 3);
            textBoxFormula.Name = "textBoxFormula";
            textBoxFormula.ScrollBars = ScrollBars.Horizontal;
            textBoxFormula.Size = new Size(271, 16);
            textBoxFormula.TabIndex = 1;
            textBoxFormula.TextAlign = HorizontalAlignment.Right;
            toolTip.SetToolTip(textBoxFormula, "Формула текущего выражения");
            // 
            // tab2
            // 
            tab2.Controls.Add(tableLayoutPanel1);
            tab2.Location = new Point(4, 24);
            tab2.Name = "tab2";
            tab2.Padding = new Padding(3);
            tab2.Size = new Size(277, 435);
            tab2.TabIndex = 1;
            tab2.Text = "История";
            tab2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(labelHistoryText, 0, 0);
            tableLayoutPanel1.Controls.Add(listBoxHistoryRecords, 0, 1);
            tableLayoutPanel1.Controls.Add(buttonClearHistory, 0, 2);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(277, 435);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // labelHistoryText
            // 
            labelHistoryText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelHistoryText.AutoSize = true;
            labelHistoryText.BackColor = SystemColors.Control;
            labelHistoryText.Location = new Point(3, 3);
            labelHistoryText.Margin = new Padding(3);
            labelHistoryText.Name = "labelHistoryText";
            labelHistoryText.Size = new Size(271, 37);
            labelHistoryText.TabIndex = 0;
            labelHistoryText.Text = "История калькулятора";
            labelHistoryText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listBoxHistoryRecords
            // 
            listBoxHistoryRecords.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBoxHistoryRecords.BorderStyle = BorderStyle.None;
            listBoxHistoryRecords.FormattingEnabled = true;
            listBoxHistoryRecords.HorizontalScrollbar = true;
            listBoxHistoryRecords.ItemHeight = 15;
            listBoxHistoryRecords.Location = new Point(3, 46);
            listBoxHistoryRecords.Name = "listBoxHistoryRecords";
            listBoxHistoryRecords.Size = new Size(271, 330);
            listBoxHistoryRecords.TabIndex = 1;
            // 
            // buttonClearHistory
            // 
            buttonClearHistory.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonClearHistory.Location = new Point(3, 394);
            buttonClearHistory.Name = "buttonClearHistory";
            buttonClearHistory.Size = new Size(271, 38);
            buttonClearHistory.TabIndex = 2;
            buttonClearHistory.Text = "История";
            toolTip.SetToolTip(buttonClearHistory, "Нажмите, чтобы очистить историю");
            buttonClearHistory.UseVisualStyleBackColor = true;
            // 
            // tab3
            // 
            tab3.Controls.Add(tableLayoutPanelOptions);
            tab3.Location = new Point(4, 24);
            tab3.Name = "tab3";
            tab3.Padding = new Padding(3);
            tab3.Size = new Size(277, 435);
            tab3.TabIndex = 2;
            tab3.Text = "Настройки";
            tab3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanelOptions
            // 
            tableLayoutPanelOptions.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelOptions.ColumnCount = 1;
            tableLayoutPanelOptions.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanelOptions.Controls.Add(tableLayoutPanelCalculationModeOption, 0, 0);
            tableLayoutPanelOptions.Location = new Point(0, 0);
            tableLayoutPanelOptions.Margin = new Padding(0);
            tableLayoutPanelOptions.Name = "tableLayoutPanelOptions";
            tableLayoutPanelOptions.RowCount = 2;
            tableLayoutPanelOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tableLayoutPanelOptions.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tableLayoutPanelOptions.Size = new Size(277, 435);
            tableLayoutPanelOptions.TabIndex = 0;
            // 
            // tableLayoutPanelCalculationModeOption
            // 
            tableLayoutPanelCalculationModeOption.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelCalculationModeOption.ColumnCount = 1;
            tableLayoutPanelCalculationModeOption.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanelCalculationModeOption.Controls.Add(labelCalculationModeOption, 0, 0);
            tableLayoutPanelCalculationModeOption.Controls.Add(tableLayoutPanelCurrentCalculationMode, 0, 1);
            tableLayoutPanelCalculationModeOption.Location = new Point(0, 0);
            tableLayoutPanelCalculationModeOption.Margin = new Padding(0);
            tableLayoutPanelCalculationModeOption.Name = "tableLayoutPanelCalculationModeOption";
            tableLayoutPanelCalculationModeOption.RowCount = 2;
            tableLayoutPanelCalculationModeOption.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelCalculationModeOption.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanelCalculationModeOption.Size = new Size(277, 130);
            tableLayoutPanelCalculationModeOption.TabIndex = 0;
            // 
            // labelCalculationModeOption
            // 
            labelCalculationModeOption.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCalculationModeOption.AutoSize = true;
            labelCalculationModeOption.BackColor = SystemColors.Control;
            labelCalculationModeOption.Location = new Point(3, 3);
            labelCalculationModeOption.Margin = new Padding(3);
            labelCalculationModeOption.Name = "labelCalculationModeOption";
            labelCalculationModeOption.Size = new Size(271, 59);
            labelCalculationModeOption.TabIndex = 0;
            labelCalculationModeOption.Text = "Режим работы калькулятора (Действительные числа/целые числа).";
            labelCalculationModeOption.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanelCurrentCalculationMode
            // 
            tableLayoutPanelCurrentCalculationMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanelCurrentCalculationMode.ColumnCount = 3;
            tableLayoutPanelCurrentCalculationMode.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelCurrentCalculationMode.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelCurrentCalculationMode.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanelCurrentCalculationMode.Controls.Add(labelCurrentCalculationModeText, 0, 0);
            tableLayoutPanelCurrentCalculationMode.Controls.Add(labelCurrentCalculationModeValue, 1, 0);
            tableLayoutPanelCurrentCalculationMode.Controls.Add(buttonChangeCurrentCalculationMode, 2, 0);
            tableLayoutPanelCurrentCalculationMode.Location = new Point(0, 65);
            tableLayoutPanelCurrentCalculationMode.Margin = new Padding(0);
            tableLayoutPanelCurrentCalculationMode.Name = "tableLayoutPanelCurrentCalculationMode";
            tableLayoutPanelCurrentCalculationMode.RowCount = 1;
            tableLayoutPanelCurrentCalculationMode.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanelCurrentCalculationMode.Size = new Size(277, 65);
            tableLayoutPanelCurrentCalculationMode.TabIndex = 1;
            // 
            // labelCurrentCalculationModeText
            // 
            labelCurrentCalculationModeText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCurrentCalculationModeText.AutoSize = true;
            labelCurrentCalculationModeText.BackColor = SystemColors.Control;
            labelCurrentCalculationModeText.Location = new Point(3, 3);
            labelCurrentCalculationModeText.Margin = new Padding(3);
            labelCurrentCalculationModeText.Name = "labelCurrentCalculationModeText";
            labelCurrentCalculationModeText.Size = new Size(86, 59);
            labelCurrentCalculationModeText.TabIndex = 0;
            labelCurrentCalculationModeText.Text = "Текущий режим:";
            labelCurrentCalculationModeText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelCurrentCalculationModeValue
            // 
            labelCurrentCalculationModeValue.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelCurrentCalculationModeValue.AutoSize = true;
            labelCurrentCalculationModeValue.BackColor = SystemColors.Control;
            labelCurrentCalculationModeValue.Location = new Point(95, 3);
            labelCurrentCalculationModeValue.Margin = new Padding(3);
            labelCurrentCalculationModeValue.Name = "labelCurrentCalculationModeValue";
            labelCurrentCalculationModeValue.Size = new Size(86, 59);
            labelCurrentCalculationModeValue.TabIndex = 1;
            labelCurrentCalculationModeValue.Text = "Действительные числа";
            labelCurrentCalculationModeValue.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // buttonChangeCurrentCalculationMode
            // 
            buttonChangeCurrentCalculationMode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            buttonChangeCurrentCalculationMode.Location = new Point(187, 3);
            buttonChangeCurrentCalculationMode.Name = "buttonChangeCurrentCalculationMode";
            buttonChangeCurrentCalculationMode.Size = new Size(87, 59);
            buttonChangeCurrentCalculationMode.TabIndex = 2;
            buttonChangeCurrentCalculationMode.Text = "Поменять на целые числа";
            toolTip.SetToolTip(buttonChangeCurrentCalculationMode, "Нажмите, чтобы поменять режим работы калькулятора");
            buttonChangeCurrentCalculationMode.UseVisualStyleBackColor = true;
            // 
            // tab4
            // 
            tab4.Controls.Add(labelInfo);
            tab4.Location = new Point(4, 24);
            tab4.Name = "tab4";
            tab4.Padding = new Padding(3);
            tab4.Size = new Size(277, 435);
            tab4.TabIndex = 3;
            tab4.Text = "Справка";
            tab4.UseVisualStyleBackColor = true;
            // 
            // labelInfo
            // 
            labelInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            labelInfo.BackColor = SystemColors.Control;
            labelInfo.Location = new Point(0, 0);
            labelInfo.Margin = new Padding(3);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(277, 435);
            labelInfo.TabIndex = 0;
            labelInfo.Text = resources.GetString("labelInfo.Text");
            labelInfo.TextAlign = ContentAlignment.TopCenter;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(284, 461);
            Controls.Add(tabControl);
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(300, 500);
            Name = "MainWindow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "P-ичный калькулятор";
            tabControl.ResumeLayout(false);
            tab1.ResumeLayout(false);
            tableMain.ResumeLayout(false);
            tableCalculatorButtons.ResumeLayout(false);
            tableChangeNotation.ResumeLayout(false);
            tableChangeNotation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBarNotation).EndInit();
            tableNotation.ResumeLayout(false);
            tableNotation.PerformLayout();
            tableResult.ResumeLayout(false);
            tableResult.PerformLayout();
            tab2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tab3.ResumeLayout(false);
            tableLayoutPanelOptions.ResumeLayout(false);
            tableLayoutPanelCalculationModeOption.ResumeLayout(false);
            tableLayoutPanelCalculationModeOption.PerformLayout();
            tableLayoutPanelCurrentCalculationMode.ResumeLayout(false);
            tableLayoutPanelCurrentCalculationMode.PerformLayout();
            tab4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage tab1;
        private TabPage tab2;
        private TabPage tab3;
        private TabPage tab4;
        private TableLayoutPanel tableMain;
        private TableLayoutPanel tableCalculatorButtons;
        private Button buttonM;
        private Button buttonMPlus;
        private Button buttonMC;
        private Button buttonMR;
        private Button buttonMS;
        private Button button0;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button buttonA;
        private Button buttonB;
        private Button buttonC;
        private Button buttonD;
        private Button buttonE;
        private Button buttonF;
        private Button buttonEqual;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMultiply;
        private Button buttonDivision;
        private Button buttonReverse;
        private Button buttonSquare;
        private Button buttonChangeSign;
        private Button buttonDelimeter;
        private Button buttonBackSpace;
        private Button buttonClearEdit;
        private Button buttonClear;
        private Button buttonSqrt;
        private Button buttonPI;
        private TableLayoutPanel tableChangeNotation;
        private Label labelNotationText;
        private Label labelNotationValue;
        private TrackBar trackBarNotation;
        private TableLayoutPanel tableResult;
        private Label labelResult;
        private TableLayoutPanel tableNotation;
        private TextBox textBoxFormula;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelHistoryText;
        private ListBox listBoxHistoryRecords;
        private Button buttonClearHistory;
        private Label labelInfo;
        private ToolTip toolTip;
        private TableLayoutPanel tableLayoutPanelOptions;
        private TableLayoutPanel tableLayoutPanelCalculationModeOption;
        private Label labelCalculationModeOption;
        private TableLayoutPanel tableLayoutPanelCurrentCalculationMode;
        private Label labelCurrentCalculationModeText;
        private Label labelCurrentCalculationModeValue;
        private Button buttonChangeCurrentCalculationMode;
    }
}
