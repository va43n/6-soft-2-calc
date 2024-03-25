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

		public Controller(int p)
		{
			this.p = p;

			editor = new Editor();

			processor = new Processor(p);

			memory = new Memory();

			history = new History();

			lastInput = 0;
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
					editor.ChangeCurrentNumber("0");

                //tag: 0123456789ABCDEF
                //lastInput: "="
                else if (tag <= 15 && lastInput == 22)
				{
					//Clear
                    DoEditorCommand(18);
					Clear();
                }

				result = DoEditorCommand(tag);

				//"="
				if (tag == 22)
				{
					if (processor.CheckOperation() == Operation.None)
					{
						throw new Exception("Чтобы узнать результат необходимо поставить хотя бы один оператор.");
					}

					if (lastInput == 22)
					{
						result = DoProcessorCommand(tag);

						editor.UpgradeFormula(formulaSymbols[tag - 22] + result);
					}
					else
					{
						PNumber number = new PNumber(result, p);
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
				
					history.Add(editor.GetFormula());
				}

				//"+", "-", "*", "/"
				else if (tag >= 23 && tag <= 26)
				{
					if (lastInput >= 23 && lastInput <= 26)
					{
						editor.ChangeSignInFormula(formulaSymbols[tag - 22]);
					}
					else
					{
						PNumber number = new PNumber(result, p);
						processor.SetOperand(number);

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
					if (lastInput >= 27 && lastInput <= 29)
					{
						editor.UpgradeFormula(formulaSymbols[tag - 22]);
					}
					else
					{
						PNumber number = new PNumber(result, p);
						processor.SetOperand(number);

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
				if (memory.CheckMemoryState() == MemoryState.Off)
					throw new Exception("В памяти лежит нулевое значение.");

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

		public void ChangeNotation(int newP)
		{
			p = newP;
			processor.SetNotation(p);
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

		public void Clear()
		{
			processor.ClearProcessor();
			editor.ClearEditor();
		}
	}
}
