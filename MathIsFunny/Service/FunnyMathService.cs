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
            switch(randOperator)
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

            // ToDo: use algorithm to remove operator here

            if (operators.Length == 0)
            {
                return string.Empty;
            }
            
            int randOperator = random.Next(operators.Length);

            return operators[randOperator];
        }
    }
}
