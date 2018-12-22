namespace Service
{
    using System;

    public class FunnyMathService
    {
        public const int Addition = 1;
        public const int Subtraction = 2;
        public const int Multiplication = 3;
        public const int Division = 4;

        private const int MaxNumber = 1000;

        private static string[] operatorNames = { "", "Addition", "Subtraction", "Multiplication", "Division" };

        private Random random;
        private int firstNumber;
        private int secondNumber;
        private string randOperator;

        public FunnyMathService()
        {
            random = new Random();
        }

        public string GenerateMathQuestion(bool hasAddition, bool hasSubtraction, bool hasMultiplication, bool hasDivision)
        {
            randOperator = GetRandomOperator(hasAddition, hasSubtraction, hasMultiplication, hasDivision);
            firstNumber = random.Next(MaxNumber);
            do
            {
                secondNumber = random.Next(MaxNumber);
            } while (firstNumber == secondNumber);

            return $"{firstNumber} {randOperator} {secondNumber} = ?";
        }

        public string GetResultString()
        {
            return $"{firstNumber} {randOperator} {secondNumber} = {GetResult()}";
        }

        public int GetResult()
        {
            switch (randOperator)
            {
                case "+":
                    return firstNumber + secondNumber;
                case "-":
                    return firstNumber - secondNumber;
                case "x":
                    return firstNumber * secondNumber;
                case "/":
                    return firstNumber / secondNumber;
            }

            return 0;
        }

        public static string GetOperatorName(int op)
        {
            return operatorNames[op];
        }

        private string GetRandomOperator(bool hasAddition, bool hasSubtraction, bool hasMultiplication, bool hasDivision)
        {
            string[] operators = { "+", "-", "x", "/" };

            if (!hasAddition)
            {
                RemoveStringInArray(ref operators, "+");
            }
            if (!hasSubtraction)
            {
                RemoveStringInArray(ref operators, "-");
            }
            if (!hasMultiplication)
            {
                RemoveStringInArray(ref operators, "x");
            }
            if (!hasDivision)
            {
                RemoveStringInArray(ref operators, "/");
            }

            if (operators.Length == 0)
            {
                return string.Empty;
            }

            int randOperator = random.Next(operators.Length);

            return operators[randOperator];
        }

        private string[] RemoveStringInArray(ref string[] strArray, string strToRemove)
        {
            int searchIndex = Array.FindIndex<string>(strArray, s => s == strToRemove);

            if (searchIndex == strArray.Length - 1)
            {
                Array.Resize<string>(ref strArray, strArray.Length - 1);
                return strArray;
            }

            for (int i = searchIndex; i < strArray.Length - 1; i++)
            {
                strArray[i] = strArray[i + 1];
            }

            Array.Resize<string>(ref strArray, strArray.Length - 1);
            return strArray;
        }
    }
}
