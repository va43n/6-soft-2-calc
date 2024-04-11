namespace _6_soft_2_calc
{
	public enum Operation { None, Addition, Subtraction, Multiplication, Division }

	public enum Function { Square, SquareRoot, Reverse }

	public enum CalculationMode { Double, Int }


	public class PNumber
	{
		public static string alphabet = "0123456789ABCDEF";
		public static string zero = "0";
		public static string standardDelimeter = ".";
		public static string differentDelimeter = ",";
		public static string stringSign = "-";

		private double number;
		private int p;
		private int c;
		private CalculationMode mode;

		public PNumber()
		{
			number = 0;
			p = 2;
			c = 0;
			mode = CalculationMode.Double;
		}

		public PNumber(string n0, int p0)
		{
			int delimeterPosition, sign;

			if (n0[0] == stringSign[0])
			{
				sign = -1;
				n0 = n0.Remove(0, 1);
			}
			else
				sign = 1;

			number = ConvertTo10(n0, p0) * sign;
			p = p0;

			delimeterPosition = n0.IndexOf(standardDelimeter);
			if (delimeterPosition == -1)
				delimeterPosition = n0.IndexOf(differentDelimeter);

			c = delimeterPosition != -1 ? n0.Length - delimeterPosition - 1 : 0;
            c = (int)Math.Floor(c * Math.Log(10) / Math.Log(p) + 0.5);

            mode = CalculationMode.Double;
        }

		private double ConvertTo10(string n0, int p0)
		{
			int weightPower, delimeterPosition = n0.IndexOf(standardDelimeter);
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

			try
			{
                if (number == Math.Floor(number))
                    result = TenToInt(Convert.ToInt32(absNumber));
                else
                    result = TenToInt(Convert.ToInt32(Math.Floor(absNumber))) + standardDelimeter + TenToDouble(absNumber - Math.Floor(absNumber));
            }
			catch (OverflowException)
			{
                throw new CalculatorException("Вы ввели слишком большое число.");
            }

			result = number >= 0 ? result : stringSign + result;

			return result;
		}

		private string TenToInt(int number)
		{
			string s = "", temp;

			if (number == 0)
				return zero;

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
			{
                this.number += number2.number;
                this.number = this.c > number2.c ? Math.Round(this.number, this.c) : Math.Round(this.number, number2.c);
            }
			else if (operation == Operation.Subtraction)
			{
                this.number -= number2.number;
				this.number = this.c > number2.c ? Math.Round(this.number, this.c) : Math.Round(this.number, number2.c);
            }
			else if (operation == Operation.Multiplication)
			{
                this.number *= number2.number;
                this.number = Math.Round(this.number, this.c + number2.c);
            }
			else if (operation == Operation.Division)
			{
				if (number2.number == 0)
					throw new CalculatorException("Деление на 0 запрещено.");

				this.number = mode == CalculationMode.Double ? this.number / number2.number : Math.Floor(this.number / number2.number);
            }

			strResult = this.number.ToString();
			if (strResult[0] == '-')
				strResult = strResult.Remove(0, 1);

			accuracy = strResult.IndexOf(standardDelimeter);
			if (accuracy == -1)
				accuracy = strResult.IndexOf(differentDelimeter);
			accuracy = accuracy != -1 ? strResult.Length - accuracy - 1 : 0;

			this.c = (int)Math.Floor(accuracy * Math.Log(10) / Math.Log(p) + 0.5);
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
					throw new CalculatorException("Отрицательное число под корнем недопустимо.");

				number = mode == CalculationMode.Double ? Math.Sqrt(number) : Math.Floor(Math.Sqrt(number));

            }
			else if (function == Function.Reverse)
			{
				if (number == 0)
					throw new CalculatorException("Деление на 0 запрещено.");

                number = mode == CalculationMode.Double ? 1 / number : Math.Floor(1 / number);
            }

			strResult = Math.Abs(number).ToString();

			accuracy = strResult.IndexOf(standardDelimeter);
			if (accuracy == -1)
				accuracy = strResult.IndexOf(differentDelimeter);
			accuracy = accuracy != -1 ? strResult.Length - accuracy - 1 : 0;

			this.c = (int)Math.Floor(accuracy * Math.Log(10) / Math.Log(p) + 0.5);
        }

		public void ChangeP(int newP)
		{
			int accuracy;
			string strResult = number.ToString();

            accuracy = strResult.IndexOf(standardDelimeter);
            if (accuracy == -1)
                accuracy = strResult.IndexOf(differentDelimeter);
            accuracy = accuracy != -1 ? strResult.Length - accuracy - 1 : 0;

            p = newP;
            c = (int)Math.Floor(accuracy * Math.Log(10) / Math.Log(p) + 0.5);
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
			this.mode = number.mode;
		}

		public void CreatePI()
		{
			string strResult;
			int delimeterPosition;

			number = Math.PI;
			if (mode == CalculationMode.Int)
				number = Math.Floor(number);

			strResult = number.ToString();
            delimeterPosition = strResult.IndexOf(standardDelimeter);
            if (delimeterPosition == -1)
                delimeterPosition = strResult.IndexOf(differentDelimeter);

            c = delimeterPosition != -1 ? strResult.Length - delimeterPosition - 1 : 0;
        }

		public int GetP()
		{
			return p;
		}

		public void ChangeCalculationMode(CalculationMode newMode)
		{
			int delimeterPosition;
			string strResult = number.ToString();

			mode = newMode;
			if (mode == CalculationMode.Int)
			{
                delimeterPosition = strResult.IndexOf(standardDelimeter);
                if (delimeterPosition == -1)
                    delimeterPosition = strResult.IndexOf(differentDelimeter);

				if (delimeterPosition != -1)
					number = Convert.ToDouble(strResult.Substring(0, delimeterPosition));

				c = 0;
            }
		}
	}
}
