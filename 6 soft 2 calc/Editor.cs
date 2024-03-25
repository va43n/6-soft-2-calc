namespace _6_soft_2_calc
{
	public class Editor
	{
		private string currentNumber;
		private string formula;

		public Editor()
		{
			currentNumber = "0";
			formula = "";
		}

		public string EditSomething(int tag)
		{
			//0123456789ABCDEF
			if (tag < 16)
				currentNumber = currentNumber == "0" ? PNumber.alphabet[tag].ToString() : currentNumber + PNumber.alphabet[tag];

			else if (tag == 16 && currentNumber.IndexOf(".") == -1)
				currentNumber += currentNumber == "" ? "0." : ".";

			//"+/-"
			else if (tag == 17)
			{
				if (currentNumber[0] == '-')
					currentNumber = currentNumber.Remove(0, 1);
				else
					currentNumber = currentNumber.Insert(0, "-");
			}

			//"Clear"
			else if (tag == 18)
			{
				currentNumber = "0";
				formula = "";
			}

			//"CE"
			else if (tag == 19)
			{
				currentNumber = "0";
			}

			//"BS"
			else if (tag == 20)
			{
				if (currentNumber.Length == 1)
				{
					currentNumber = "0";
					return currentNumber;
				}
				currentNumber = currentNumber.Remove(currentNumber.Length - 1, 1);
			}

			//"=", "+", "-", "*", "/", "^2", "^(-1)", "^(1/2)"
			else if (tag >= 22 && tag <= 29)
			{
				string result;

				DeleteUnnecessarySymbols();
				result = currentNumber;

                currentNumber = "0";

				return result;
			}

			return currentNumber;
		}

		public void ChangeCurrentNumber(string newNumber)
		{
			currentNumber = newNumber;
		}

		public string GetCurrentNumber()
		{
			return currentNumber;
		}

		public void ClearEditor()
		{
			formula = "";
			currentNumber = "0";
		}

		public string GetFormula()
		{
			return formula;
		}

		public void UpgradeFormula(string part)
		{
			formula += part;
		}

		public void ChangeSignInFormula(string newSign)
		{
			formula = formula.Remove(formula.Length - 1, 1);
			formula += newSign;
		}

		private void DeleteUnnecessarySymbols()
		{
			for (int i = currentNumber.Length - 1; i >= 0; i--)
			{
				if (currentNumber[i] != '0' && currentNumber[i] != '.' || currentNumber.IndexOf(".") == -1)
					break;
				currentNumber = currentNumber.Remove(i, 1);
			}

			if (currentNumber == "-0")
				currentNumber = "0";
		}
	}
}
