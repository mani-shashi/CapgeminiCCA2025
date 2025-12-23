using System;

namespace PracticeQuestions
{
    public class GradeChecker
    {
        public string getGradeRemarks(char grade)
        {
            string GradeRemarks = "";

            switch (char.ToLower(grade))
            {
                case 'e': 
                    GradeRemarks = "Excellent";
                    break;
                case 'v':
                    GradeRemarks = "Very Good";
                    break;
                case 'g':
                    GradeRemarks = "Good";
                    break;
                case 'a':
                    GradeRemarks = "Average";
                    break;
                case 'f':
                    GradeRemarks = "Fail";
                    break;
            }
            return GradeRemarks;
        }
    }
}