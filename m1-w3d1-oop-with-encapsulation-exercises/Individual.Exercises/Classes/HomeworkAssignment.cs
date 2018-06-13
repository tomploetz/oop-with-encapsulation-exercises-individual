using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class HomeworkAssignment
    {
		
        // properties
		public int TotalMarks { get; set; }
		public int PossibleMarks { get; }
		public string SubmitterName { get; }
		public string LetterGrade
		{
			get				
			{
				double gradePercentage = 0.0;
				gradePercentage = ((double)TotalMarks / (double)(PossibleMarks) * 100);

				if (gradePercentage >= 90)
				{
					return "A";
				}
				else if (gradePercentage < 90 && gradePercentage >= 80)
				{
					return "B";
				}
				else if (gradePercentage >= 70 && gradePercentage <= 79)
				{
					return "C";
				}
				else if (gradePercentage >= 60 && gradePercentage <= 69)
				{
					return "D";
				}
				else
				{
					return "F";
				}
				
			}

		}


		// constructors
		public HomeworkAssignment(int possibleMarks, string submitterName)
		{
			PossibleMarks = possibleMarks;
			SubmitterName = submitterName;
		}


    }
}
