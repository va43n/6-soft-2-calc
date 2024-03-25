namespace _6_soft_2_calc
{
	public enum Operation { None, Addition, Subtraction, Multiplication, Division }


	public enum Function { Square, SquareRoot, Reverse }


	public class PNumber
	{
		public static string alphabet = "0123456789ABCDEF";
		private double number;
		private int p;
		private int c;

		public PNumber()
		{
			number = 0;
			p = 2;
			c = 0;
		}

		public PNumber(string n0, int p0)
		{
			int delimeterPosition, sign;

			if (n0[0] == '-')
			{
				sign = -1;
				n0 = n0.Remove(0, 1);
			}
			else
				sign = 1;

			number = ConvertTo10(n0, p0) * sign;
			p = p0;

			delimeterPosition = n0.IndexOf('.');
			if (delimeterPosition == -1)
				delimeterPosition = n0.IndexOf(",");
			c = delimeterPosition != -1 ? n0.Length - delimeterPosition - 1 : 0;
		}

		private double ConvertTo10(string n0, int p0)
		{
			int weightPower, delimeterPosition = n0.IndexOf('.');
			string numberWithoutDelimeter = n0;
			double result = 0;

			if (delimeterPosition != -1)
			{
				weightPower = delimeterPosition - 1;
				numberWithoutDelimeter = numberWithoutDelimeter.Remove(delimeterPosition, 1);
			}
			else
				weightPower = n0.Length - 1;

			try
			{
				weightPower = Convert.ToInt32(Math.Pow(p0, weightPower));

                for (int i = 0; i < numberWithoutDelimeter.Length; i++)
                    result += weightPower * alphabet.IndexOf(numberWithoutDelimeter[i]) / Math.Pow(p0, i);
			}
			catch (OverflowException)
			{
				throw new CalculatorException("Вы ввели слишком большое число.");
			}

			return result;
		}

		public string ConvertToP()
		{
			string result;
			double absNumber = Math.Abs(number);

			if (number == Math.Floor(number))
				result = TenToInt(Convert.ToInt32(absNumber));
			else
				result = TenToInt(Convert.ToInt32(Math.Floor(absNumber))) + "." + TenToDouble(absNumber - Math.Floor(absNumber));

			result = number >= 0 ? result : "-" + result;

			return result;
		}

		private string TenToInt(int number)
		{
			string s = "", temp;

			if (number == 0)
				return "0";

			while (number >= 1)
			{
				temp = alphabet[number % p].ToString();

				s = s.Insert(0, temp);
				number /= p;
			}

			return s;
		}

		private string TenToDouble(double number)
		{
			string s = "";

			for (int i = 0; i < c && number != 0.0; i++)
			{
				number *= p;
				s += alphabet[Convert.ToInt32(Math.Floor(number))];
				number -= Math.Floor(number);
			}

			return s;
		}

		public void CalculateOperation(PNumber number2, Operation operation)
		{
			string strResult;
			int accuracy;

			if (this.p != number2.p)
				throw new CalculatorException("p1 и p2 не равны.");

			if (operation == Operation.Addition)
				this.number += number2.number;
			else if (operation == Operation.Subtraction)
				this.number -= number2.number;
			else if (operation == Operation.Multiplication)
				this.number *= number2.number;
			else if (operation == Operation.Division)
			{
				if (number2.number == 0)
					throw new CalculatorException("Деление на 0 запрещено.");
				this.number /= number2.number;
			}

			strResult = this.number.ToString();
			if (strResult[0] == '-')
				strResult = strResult.Remove(0, 1);

			accuracy = strResult.IndexOf(".");
			if (accuracy == -1)
				accuracy = strResult.IndexOf(",");
			accuracy = accuracy != -1 ? strResult.Length - accuracy - 1 : 0;

			this.c = (int)Math.Round(accuracy * Math.Log(10) / Math.Log(p) + 0.5);
		}

		public void CalculateFunction(Function function)
		{
			int accuracy;
			string strResult;

			if (function == Function.Square)
				number *= number;
			else if (function == Function.SquareRoot)
			{
				if (number < 0)
					throw new Exception("Отрицательное число под корнем недопустимо.");
				number = Math.Sqrt(number);
			}
			else if (function == Function.Reverse)
			{
				if (number == 0)
					throw new Exception("Деление на 0 запрещено.");
				number = 1 / number;
			}

			strResult = Math.Abs(number).ToString();

			accuracy = strResult.IndexOf(".");
			if (accuracy == -1)
				accuracy = strResult.IndexOf(",");
			accuracy = accuracy != -1 ? strResult.Length - accuracy - 1 : 0;

			this.c = (int)Math.Round(accuracy * Math.Log(10) / Math.Log(p) + 0.5);
		}

		public void ChangeP(int newP)
		{
			int accuracy;
			string strResult = number.ToString();

            accuracy = strResult.IndexOf(".");
            if (accuracy == -1)
                accuracy = strResult.IndexOf(",");
            accuracy = accuracy != -1 ? strResult.Length - accuracy - 1 : 0;

            p = newP;
            c = (int)Math.Round(accuracy * Math.Log(10) / Math.Log(p) + 0.5);
        }

		public void ClearNumber()
		{
			c = 0;
			number = 0;
		}

		public void Copy(PNumber number)
		{
			this.number = number.number;
			this.p = number.p;
			this.c = number.c;
		}

		public void CreatePI()
		{
			string strResult;
			int delimeterPosition;

			number = Math.PI;
			strResult = number.ToString();
            delimeterPosition = strResult.IndexOf('.');
            if (delimeterPosition == -1)
                delimeterPosition = strResult.IndexOf(",");

            c = delimeterPosition != -1 ? strResult.Length - delimeterPosition - 1 : 0;
        }

		public int GetP()
		{
			return p;
		}
	}
}
