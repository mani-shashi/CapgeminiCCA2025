using System;

namespace PracticeQuestions
{
    public class LargestChecker
    {
        public int checkLargest(int num1, int num2, int num3)
        {
            int largest=num1;
            if (num1 >= num2 && num1 >= num3)
            {
                largest = num1;
            } else if (num2 >= num1 && num2 >= num3)
            {
                largest = num2;
            }else
            {
                largest = num3;
            }
            return largest;
        }
    }
}