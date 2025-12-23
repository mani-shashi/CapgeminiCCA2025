using System;

namespace PracticeQuestions
{
    public class TriangleChecker
    {
        public string checkTriangleType(double a, double b, double c)
        {
            string triangleType;

            if (a == b && b == c)
            {
                triangleType = "Equilateral Triangle";
            } else if (a == b || b == c || c == a)
            {
                triangleType="Isosceles Triangle";
            } else
            {
                triangleType = "Scalene Triangle";
            }
            return triangleType;
        }

    }
}