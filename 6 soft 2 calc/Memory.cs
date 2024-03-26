namespace _6_soft_2_calc
{
	public enum MemoryState { On, Off }

	public class Memory
	{
		private MemoryState state;
		private PNumber number;

		public Memory()
		{
			state = MemoryState.Off;
			number = new PNumber();
		}

		public string CheckMemoryValue()
		{
			return number.ConvertToP();
		}

		public void ClearMemory()
		{
			number.ClearNumber();
			state = MemoryState.Off;
		}

		public string SaveValueInMemory(PNumber newNumber)
		{
			state = MemoryState.On;

			number.Copy(newNumber);

			return number.ConvertToP();
		}

		public string AddValueToMemory(PNumber newNumber)
		{
			state = MemoryState.On;

			number.ChangeP(newNumber.GetP());
			number.CalculateOperation(newNumber, Operation.Addition);

			return number.ConvertToP();
		}

		public MemoryState CheckMemoryState()
		{
			return state;
		}

		public void SetNotation(int newP)
		{
			number.ChangeP(newP);
		}

		public void ChangeCalculationModeInMemory(CalculationMode newMode)
		{
			number.ChangeCalculationMode(newMode);
		}
	}
}
