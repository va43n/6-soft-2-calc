namespace _6_soft_2_calc
{
	public partial class MainWindow : Form
	{
		List<Button> buttons = new List<Button>();
		Controller controller;

		public MainWindow()
		{
			int number;

			InitializeComponent();

			buttons.AddRange([
				button0, button1, button2,
				button3, button4, button5,
				button6, button7, button8,
				button9, buttonA, buttonB,
				buttonC, buttonD, buttonE,
				buttonF, buttonDelimeter, buttonClear,
				buttonClearEdit, buttonBackSpace, buttonEqual,
				buttonPlus, buttonMinus, buttonMultiply,
				buttonDivision, buttonPI, buttonChangeSign,
				buttonSquare, buttonReverse, buttonSqrt,
				buttonM, buttonMC, buttonMR,
				buttonMS, buttonMPlus,
			]);

			for (int i = 0; i < buttons.Count; i++)
				buttons[i].Click += ButtonClick;

			trackBarNotation.Scroll += TrackBarNotation_Scroll;

			number = trackBarNotation.Value;
			labelNotationValue.Text = number.ToString();
			DisableHigherNotationButtons(number);

			ClearLabels();

            DisableUselessMemoryButtons();

            controller = new Controller(number);

            tabControl.Selecting += TabControl_Selecting;

            buttonClearHistory.Click += ButtonClearHistory_Click;
			DisableClearHistoryButton();

            buttonChangeCurrentCalculationMode.Click += ButtonChangeCurrentCalculationMode_Click;
        }

        private void ButtonClick(object? sender, EventArgs e)
		{
			Button button = (Button)sender;
			DoCommandInController(Convert.ToInt32(button.Tag.ToString()));
		}

		private void DoCommandInController(int tag)
		{
			try
			{
				string result = controller.ButtonClicked(tag);

				//всё кроме памяти
				if (tag <= 29)
				{
					labelResult.Text = result;

					//"Clear"
					if (tag == 18)
					{
						controller.ClearEdit();
						ClearLabels();
					}

					textBoxFormula.Text = controller.GetFormulaFromEditor();
				}

				//M
				else if (tag == 30)
					MessageBox.Show(result);

				//MC
				else if (tag == 31)
				{
					DisableUselessMemoryButtons();
				}

				//MR
				else if (tag == 32)
				{
					labelResult.Text = result;
				}

				//MS || M+
				else if (tag == 33 || tag == 34)
				{
                    if (result == "0")
                        DisableUselessMemoryButtons();
                    else
                        EnableMemoryButtons();
                }
			}
			catch (CalculatorException e)
			{
				MessageBox.Show(e.Message);
				controller.ClearController();

				ClearLabels();
			}
		}

		private void TrackBarNotation_Scroll(object? sender, EventArgs e)
		{
			int number = trackBarNotation.Value;

			labelNotationValue.Text = number.ToString();
            DisableHigherNotationButtons(number);

            ClearLabels();

            labelResult.Text = controller.ChangeNotation(number);
		}

		private void DisableHigherNotationButtons(int notation)
		{
			for (int i = 2; i < notation; i++)
				buttons[i].Enabled = true;

			for (int i = notation; i < 16; i++)
				buttons[i].Enabled = false;
		}

        private void EnableMemoryButtons()
        {
            buttonMC.Enabled = true;
            buttonMR.Enabled = true;
        }

        private void DisableUselessMemoryButtons()
		{
			buttonMC.Enabled = false;
			buttonMR.Enabled = false;
		}

		private void ClearLabels()
		{
			labelResult.Text = "0";
			textBoxFormula.Text = "";
		}

        private void ButtonClearHistory_Click(object? sender, EventArgs e)
        {
			controller.ClearRecordsFromHistory();

			listBoxHistoryRecords.Items.Clear();

			DisableClearHistoryButton();
        }

		private void EnableClearHistoryButton()
		{
			buttonClearHistory.Enabled = true;
			buttonClearHistory.Text = "Очистить историю";
		}

        private void DisableClearHistoryButton()
        {
            buttonClearHistory.Enabled = false;
            buttonClearHistory.Text = "История пуста";
        }

        private void TabControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
			List<string> records = new List<string>();

			//history
            if (tabControl.SelectedIndex == 1)
            {
				records.AddRange(controller.GetRecordsFromHistory());
				if (records.Count != 0)
				{
					EnableClearHistoryButton();

					for (int i = records.Count - 1; i >= 0; i--)
						listBoxHistoryRecords.Items.Add(records[i]);
				}
				else
					DisableClearHistoryButton();
            }
            else
                listBoxHistoryRecords.Items.Clear();
        }

        private void ButtonChangeCurrentCalculationMode_Click(object? sender, EventArgs e)
        {
			string result;

            if (controller.GetCalculationMode() == CalculationMode.Double)
			{
				result = controller.ChangeCalculationMode(CalculationMode.Int);

				ClearLabels();
				labelResult.Text = result;

				buttonChangeCurrentCalculationMode.Text = "Поменять на действительные числа";
				labelCurrentCalculationModeValue.Text = "Целые числа";

				buttonDelimeter.Enabled = false;
				buttonReverse.Enabled = false;
			}
			else
			{
                result = controller.ChangeCalculationMode(CalculationMode.Double);

                ClearLabels();
                labelResult.Text = result;

                buttonChangeCurrentCalculationMode.Text = "Поменять на целые числа";
                labelCurrentCalculationModeValue.Text = "Действительные числа";

                buttonDelimeter.Enabled = true;
                buttonReverse.Enabled = true;
            }
        }
    }
}
