namespace Service
{
    using System;

    public class FunnyMathService
    {
        private const int MaxNumber = 1000;

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
            } while (firstNumber != secondNumber);

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

        private string GetRandomOperator(bool hasAddition, bool hasSubtraction, bool hasMultiplication, bool hasDivision)
        {
            string[] operators = { "+", "-", "x", "/" };

            if (!hasAddition)
            {
                RemoveStringInArray(operators, "+");
            }
            if (!hasSubtraction)
            {
                RemoveStringInArray(operators, "-");
            }
            if (!hasMultiplication)
            {
                RemoveStringInArray(operators, "x");
            }
            if (!hasDivision)
            {
                RemoveStringInArray(operators, "/");
            }

            if (operators.Length == 0)
            {
                return string.Empty;
            }

            int randOperator = random.Next(operators.Length);

            return operators[randOperator];
        }

        private string[] RemoveStringInArray(string[] strArray, string strToRemove)
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
