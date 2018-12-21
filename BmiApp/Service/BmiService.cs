namespace Service
{
    using System;

    public class BmiService
    {
        public static float CalculateBmiMetric(float weightInKg, float heightInCm)
        {
            return weightInKg / (float)Math.Pow(heightInCm / 100, 2);
        }

        public static float CalculateBmiUs(float weightInPound, float heightInInches)
        {
            return 703 * weightInPound / (float)Math.Pow(heightInInches, 2);
        }

        public static string BmiStatus(float bmiResult)
        {
            if (bmiResult < 18.5)
            {
                return "Underweight";
            }
            if (bmiResult < 24.9)
            {
                return "Normal Weight";
            }
            if (bmiResult < 29.9)
            {
                return "Overweight";
            }
            if (bmiResult < 34.9)
            {
                return "Obesity (Class 1)";
            }
            if (bmiResult < 39.9)
            {
                return "Obesity (Class 2)";
            }
            return "Extreme Obesity";
        }
    }
}
