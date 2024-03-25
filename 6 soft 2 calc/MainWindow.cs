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
						controller.Clear();
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
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
				controller.Clear();

				ClearLabels();
			}
		}

		private void TrackBarNotation_Scroll(object? sender, EventArgs e)
		{
			int number = trackBarNotation.Value;

			labelNotationValue.Text = number.ToString();
			
			controller.ChangeNotation(number);
			controller.Clear();

			ClearLabels();

			DisableHigherNotationButtons(number);
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
	}
}
