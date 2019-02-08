namespace Service
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class MathQuizService
    {
        public const int Addition = 1;
        public const int Subtraction = 2;
        public const int Multiplication = 3;
        public const int Division = 4;

        public const int HasAddAndSubtract = 3;
        public const int HasAllOperators = 5;

        public const int Easy = 1;
        public const int Normal = 2;
        public const int Hard = 3;
        public const int Expert = 4;

        public string[] operatorSymbols = {"", "+", "-", "x", "/" };

        public int FirstNumber;
        public int SecondNumber;
        public int Result;

        private Random random;
        private int gameMode;
        private int operatorScope;
        private int quizOperator;
        private int maxResultValue;
        private string playerName;
        
        public MathQuizService(int gameMode = Easy, string playerName = "Unknown")
        {
            random = new Random();
            this.gameMode = gameMode;
            this.playerName = playerName;

            ConfigGameMode();
        }

        public void GenerateQuiz()
        {
            quizOperator = random.Next(1, operatorScope);
            switch (quizOperator)
            {
                case Addition:
                    FirstNumber = random.Next(2, maxResultValue - 1);
                    Result = random.Next(FirstNumber, maxResultValue);
                    SecondNumber = Result - FirstNumber;
                    break;
                case Subtraction:
                    SecondNumber = random.Next(2, maxResultValue - 1);
                    FirstNumber = random.Next(FirstNumber, maxResultValue);
                    Result = FirstNumber - SecondNumber;
                    break;
                case Multiplication:
                    Result = random.Next(2, maxResultValue);
                    do
                    {
                        SecondNumber = random.Next(1, (int)Math.Ceiling(Math.Sqrt((double)Result)));
                    } while (Result % SecondNumber == 0);
                    FirstNumber = Result / SecondNumber;
                    break;
                case Division:
                    FirstNumber = random.Next((int)Math.Ceiling(Math.Sqrt((double)maxResultValue)), maxResultValue + 1);
                    do
                    {
                        SecondNumber = random.Next(1, (int)Math.Ceiling(Math.Sqrt((double)FirstNumber)));
                    } while(FirstNumber % SecondNumber == 0);
                    Result = FirstNumber / SecondNumber;
                    break;
                default: break;
            }
        }

        public bool CheckUserResult(int userResult)
        {
            return userResult == Result;
        }

        public string GetOperatorSymbol()
        {
            return operatorSymbols[quizOperator];
        }

        private void ConfigGameMode()
        {
            switch (gameMode)
            {
                case Easy:
                    operatorScope = HasAddAndSubtract;
                    maxResultValue = 30;
                    break;
                case Normal:
                    operatorScope = HasAddAndSubtract;
                    maxResultValue = 100;
                    break;
                case Hard:
                    operatorScope = HasAllOperators;
                    maxResultValue = 1000;
                    break;
                case Expert:
                    operatorScope = HasAllOperators;
                    maxResultValue = 10000;
                    break;
                default: break;
            }
        }
    }
}
