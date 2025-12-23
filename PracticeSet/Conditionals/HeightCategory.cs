using System;

namespace PracticeQuestions
{
    public class HeightChecker
    {
        public string checkHeight(int height)
        {
            string heightStr = "";
            if (height <= 150)
            {
                heightStr = "Dwarf";
            } else if (height > 150 && height <= 165)
            {
                heightStr = "Average";
            } else if (height > 165 && height <= 190)
            {
                heightStr = "Tall";
            } else
            {
                heightStr = "Abnormal";
            }

            return heightStr;
        }
    }
}