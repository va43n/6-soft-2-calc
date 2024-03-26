namespace _6_soft_2_calc
{
	public class Processor
	{
		private Operation operation;
		private PNumber leftOperand;
		private PNumber rightOperand;

		public Processor(int p)
		{
			operation = Operation.None;
			
			leftOperand = new PNumber();
			leftOperand.ChangeP(p);

			rightOperand = new PNumber();
			rightOperand.ChangeP(p);
		}

		public string CalculateSomething(int tag)
		{
            //"=" || "+", "-", "*", "/"
            if (tag == 22 || (operation != Operation.None && tag >= 23 && tag <= 26))
				CalculateOperation();

			//"+", "-", "*", "/"
			else if (tag >= 23 && tag <= 26)
				SetOperation(tag);

			//"^2", "^(-1)", "^(1/2)"
			else if (tag >= 27 && tag <= 29)
				return CalculateFunction(tag);

			return leftOperand.ConvertToP();
		}

        public void ClearProcessor()
        {
            operation = Operation.None;

            leftOperand.ClearNumber();
            rightOperand.ClearNumber();
        }

        public void SetOperand(PNumber number)
		{
			if (operation == Operation.None)
				leftOperand.Copy(number);
			else
				rightOperand.Copy(number);
		}

		public void SetOperation(int tag)
		{
			if (tag == -1)
				operation = Operation.None;
			else if (tag == 23)
				operation = Operation.Addition;
			else if (tag == 24)
				operation = Operation.Subtraction;
			else if (tag == 25)
				operation = Operation.Multiplication;
			else if (tag == 26)
				operation = Operation.Division;
		}

		private void CalculateOperation()
		{
			leftOperand.CalculateOperation(rightOperand, operation);
		}

		public string CalculateFunction(int tag)
		{
			Function function = Function.Square;

			if (tag == 27)
				function = Function.Square;
			else if (tag == 28)
				function = Function.Reverse;
			else if (tag == 29)
				function = Function.SquareRoot;

			if (operation == Operation.None)
			{
				leftOperand.CalculateFunction(function);
				return leftOperand.ConvertToP();
			}

			rightOperand.CalculateFunction(function);
			return rightOperand.ConvertToP();
		}

		public string SetNotation(int newP)
		{
			leftOperand.ChangeP(newP);

            rightOperand.ClearNumber();
            rightOperand.ChangeP(newP);

			return leftOperand.ConvertToP();
		}

		public string SetSameOperand()
		{
			rightOperand.Copy(leftOperand);

			return rightOperand.ConvertToP();
		}

		public Operation CheckOperation()
		{
			return operation;
		}

		public string ChangeCalculationModeInOperands(CalculationMode newMode)
		{
			leftOperand.ChangeCalculationMode(newMode);
			rightOperand.ChangeCalculationMode(newMode);

			return leftOperand.ConvertToP();
		}
	}
}
