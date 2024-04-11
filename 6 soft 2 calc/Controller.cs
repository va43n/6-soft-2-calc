namespace _6_soft_2_calc
{
	public class Controller
	{
		private Editor editor;
		private Processor processor;
		private Memory memory;
		private History history;

		private int p;
		private int lastInput;

		private string[] formulaSymbols = { "=", "+", "-", "*", "/",
											"^2", "^(-1)", "^(1/2)" };

		private CalculationMode calculationMode;


		public Controller(int p)
		{
			this.p = p;

			editor = new Editor();
			processor = new Processor(p);
			memory = new Memory();
			history = new History();

			lastInput = 0;

			calculationMode = CalculationMode.Double;
		}

		~Controller()
		{
			ClearController();
		}

		public string ButtonClicked(int tag)
		{
			string result = "";

			//всё кроме памяти и PI
			if (tag <= 20 || (tag >= 22 && tag <= 29))
			{
				//tag: 0123456789ABCDEF
				//lastInput: PI || MR
				if (tag <= 15 && (lastInput == 21 || lastInput == 32))
					editor.ChangeCurrentNumber(PNumber.zero);

                //tag: 0123456789ABCDEF
                //lastInput: "="
                else if (tag <= 15 && lastInput == 22)
                    ClearEdit();

				result = DoEditorCommand(tag);

				//"="
				if (tag == 22)
				{
					if (processor.CheckOperation() == Operation.None)
					{
						throw new CalculatorException("Чтобы узнать результат необходимо поставить хотя бы один оператор.");
					}

					//"="
					if (lastInput == 22)
					{
						result = DoProcessorCommand(tag);

						editor.UpgradeFormula(formulaSymbols[tag - 22] + result);
					}

                    //"+", "-", "*", "/"
					else if (lastInput >= 23 && lastInput <= 26)
					{
						result = processor.SetSameOperand();
						editor.UpgradeFormula(result);

                        result = DoProcessorCommand(tag);
                        editor.UpgradeFormula(formulaSymbols[tag - 22] + result);
                    }

                    else
                    {
						PNumber number = new PNumber(result, p);
                        if (calculationMode == CalculationMode.Int)
                            number.ChangeCalculationMode(CalculationMode.Int);

                        processor.SetOperand(number);

                        //"^2", "^(-1)", "^(1/2)"
                        if (lastInput >= 27 && lastInput <= 29)
							editor.UpgradeFormula(formulaSymbols[tag - 22]);
						else
							editor.UpgradeFormula(result + formulaSymbols[tag - 22]);

						result = DoProcessorCommand(tag);

						editor.UpgradeFormula(result);
					}

					editor.ChangeCurrentNumber(result);
				
					history.Add(string.Format("{0} ({1}, {2})", editor.GetFormula(), p, calculationMode));
				}

				//"+", "-", "*", "/"
				else if (tag >= 23 && tag <= 26)
				{
                    //"+", "-", "*", "/"
                    if (lastInput >= 23 && lastInput <= 26)
					{
						editor.ChangeSignInFormula(formulaSymbols[tag - 22]);
					}

					//"="
					else if (lastInput == 22) {
						processor.SetOperation(tag);
						editor.UpgradeFormula(formulaSymbols[tag - 22]);
					}

					else
					{
						PNumber number = new PNumber(result, p);
                        if (calculationMode == CalculationMode.Int)
                            number.ChangeCalculationMode(CalculationMode.Int);

                        processor.SetOperand(number);

                        //"^2", "^(-1)", "^(1/2)" || "="
                        if (lastInput >= 27 && lastInput <= 29 || lastInput == 22)
							editor.UpgradeFormula(formulaSymbols[tag - 22]);
						else
							editor.UpgradeFormula(result + formulaSymbols[tag - 22]);

						result = DoProcessorCommand(tag);
					}

					processor.SetOperation(tag);
				}

				//"^2", "^(-1)", "^(1/2)"
				else if (tag >= 27 && tag <= 29)
				{
                    //"^2", "^(-1)", "^(1/2)"
                    if (lastInput >= 27 && lastInput <= 29)
					{
						editor.UpgradeFormula(formulaSymbols[tag - 22]);
					}

                    //"+", "-", "*", "/"
                    else if (lastInput >= 23 && lastInput <= 26)
					{
						result = processor.SetSameOperand();

                        editor.UpgradeFormula(result + formulaSymbols[tag - 22]);
                    }

					else
					{
						PNumber number = new PNumber(result, p);
                        if (calculationMode == CalculationMode.Int)
                            number.ChangeCalculationMode(CalculationMode.Int);

                        processor.SetOperand(number);


                        //"="
                        if (lastInput == 22)
						{
                            editor.UpgradeFormula(formulaSymbols[tag - 22]);
							processor.SetOperation(-1);
                        }
						else
							editor.UpgradeFormula(result + formulaSymbols[tag - 22]);
					}

					result = DoProcessorCommand(tag);

					editor.ChangeCurrentNumber(result);
				}
			}

			//PI
			else if (tag == 21)
			{
				PNumber number = new PNumber();
				if (calculationMode == CalculationMode.Int)
					number.ChangeCalculationMode(CalculationMode.Int);

				number.ChangeP(p);
				number.CreatePI();

				result = number.ConvertToP();
				editor.ChangeCurrentNumber(result);
			}

			//M
			else if (tag == 30)
			{
				result = string.Format("Значение в памяти: {0}", memory.CheckMemoryValue());
			}

			//MC
			else if (tag == 31)
			{
				memory.ClearMemory();
				result = memory.CheckMemoryValue();
			}

			//MR
			else if (tag == 32)
			{
				if (memory.CheckMemoryState() == Memory.MemoryState.Off)
					throw new CalculatorException("В памяти лежит нулевое значение.");

				result = memory.CheckMemoryValue();
				editor.ChangeCurrentNumber(result);
            }

			//MS
			else if (tag == 33)
			{
				PNumber number;

				result = editor.GetCurrentNumber();
				number = new PNumber(result, p);

				memory.SaveValueInMemory(number);
			}

			//M+
			else if (tag == 34)
			{
				PNumber number;

				result = editor.GetCurrentNumber();
				number = new PNumber(result, p);

				result = memory.AddValueToMemory(number);
			}

			lastInput = tag;

			return result;
		}

		public string ChangeNotation(int newP)
		{
			string result = processor.SetNotation(newP);

			p = newP;

			memory.SetNotation(p);

			editor.ClearEditor();
			editor.ChangeCurrentNumber(result);
			if (result != PNumber.zero)
				editor.UpgradeFormula(result);

			return result;
        }

		public string GetFormulaFromEditor()
		{
			return editor.GetFormula();
		}

		private string DoEditorCommand(int tag)
		{
			return editor.EditSomething(tag);
		}

		private string DoProcessorCommand(int tag)
		{
			return processor.CalculateSomething(tag);
		}

		public void ClearController()
		{
			processor.ClearProcessor();
			editor.ClearEditor();
			history.ClearHistory();
		}

		public void ClearEdit()
		{
            processor.ClearProcessor();
            editor.ClearEditor();
        }

		public void ClearRecordsFromHistory()
		{
			history.ClearHistory();
		}

		public List<string> GetRecordsFromHistory()
		{
			return history.GetHistory();
		}

		public string ChangeCalculationMode(CalculationMode newMode)
		{
			string result;

			calculationMode = newMode;

			result = processor.ChangeCalculationModeInOperands(newMode);
			editor.ClearEditor();
			editor.ChangeCurrentNumber(result);
			editor.UpgradeFormula(result);

            memory.ChangeCalculationModeInMemory(newMode);

			return result;
		}

		public CalculationMode GetCalculationMode()
		{
			return calculationMode;
		}
	}
}
