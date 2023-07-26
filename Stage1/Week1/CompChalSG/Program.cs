/*
Program Name: Competency Challenge Problem - Student Name and Grades
Last Updated: July 22, 2023
Program Description: 
	This program read in input from the user and reports back the final grade of a student.
	Program prompts users for number of students, name of students, score for homework, score for quizzes & score for exams
	Calculates the average score, assigns letter grade
	Returns scores back to the user.

Requirements:
1 - Number of students is integers >= 1.
2 - Provide five homework grades, three quiz grades, and two exam grades.  All grades must be between integers 0 and 100 inclusively.
3 - Final grade average is calculated by adding together 50% of the homework average, 30% of the quiz average and 20% of the exam average.
4 - Final grade letter is calculated  based on the above final grade average.  If it is 90% or greater, it is an A; 80% or better is a B; 70% or better is a C; 60% or better is a D; and anything less than 60% is an F.
5 - Display the student's name, homework average, quiz average, exam average, final average and final grade.


Main() Algorithm:
1 - Create variables.
2 - do-while loop to repeat processes based on the num of students provided.
    2.1 - do-while loop to prompt user for number of students & check if value is int >1
    2.2 - do-while loop to prompt user for name of student.
    2.3 - Call getStudentGradeMeth(), pass in student name, number of items to grade, and name of item to grade, return avg score
    2.4 -  Calculate total avg.
    2.5 - Switch Statements. Produce letter grade based on avg score
    2.6 - Display student name, homework score avg, quiz score avg, exam score avg, final avg & letter grade
    2.7 - Reset homework score avg, quiz score avg, exam score avg back to 0 value.

getStudentGradeMeth() Algorithm:
1 - Create variables.
2 - for-loop to repeat the process based on the quantity of items to be graded.
    2.1 - do-while loop to prompt user for grade for item to be scored, repeat for number of items to grade quantity.
        2.1.1 - Get score
        2.1.2 - Check if the provided score is integer.
        2.1.3 - Check if the provided score is 0 <= x <= 100.
        2.1.4 - Add the provided score to the total score.
3 - Calculate avg score with score total / quantity of item to be scored
4 - Return avg score
*/



using System;

namespace CompChalSG
{
    class Program
    {

        // getStudentGradeMeth() method to get scores
        // ================================================================================
        static int getStudentGradeMeth(string studentName, int itemQuantity, string itemName)
        {
            // 1 - Create variables.
            string ScoreString;
            int Score;
            int ScoreTotal = 0;
            int avgScore;


            // 2 - for-loop to repeat the process based on the quantity of items to be graded.
            Console.WriteLine($"For student {studentName}, enter in the following {itemQuantity} {itemName} scores.");
            for (int fl_i = 1; fl_i <= itemQuantity; ++fl_i)
            {
                // 2.1 - do-while loop to prompt user for grade for item to be scored, repeat for number of items to grade quantity.
                do
                {
                    // 2.1.1 - Get score
                    Console.WriteLine($"---> Enter in {itemName} score #{fl_i} (int, 0 <= x <= 100): ");
                    ScoreString = Console.ReadLine();

                    // 2.1.2 - Check if the provided score is integer.
                    if (!int.TryParse(ScoreString, out Score))
                    {
                        Console.WriteLine("ERROR: This is not a number, try again.");
                    }

                    // 2.1.3 - Check if the provided score is 0 <= x <= 100.
                    if ((Score > 100) || (Score < -1))
                    {
                        Console.WriteLine("ERROR: The number must be > 0 but < 100, try again.");
                    }

                } while ((!int.TryParse(ScoreString, out Score)) || ((Score > 100) || (Score < 0))); //end do-while, score

                //2.1.4 - Add the provided score to the total score.
                ScoreTotal = ScoreTotal + Score;

            } // end for-loop, quiz scores

            // 3 - Calculate avg score with score total / quantity of item to be scored
            avgScore = ScoreTotal / itemQuantity;

            //4 - Return avg score
            return avgScore;

        } // end getStudentGradeMeth()



        // Main()
        // ================================================================================
        static void Main(string[] args)
        {
            // 1 - Create variables.
            string numOfStudentsString;
            int numOfStudents;
            string studentName;
            string hwScoreString, qzScoreString, exScoreString;
            int hwScore, qzScore, exScore;
            int hwScoreAvg, qzScoreAvg, exScoreAvg, totalAvg;
            string letterGrade;


            // 2 - do-while loop to repeat processes based on the num of students provided.
            // 2.1 - do-while loop to prompt user for number of students & check if value is int >1
            do
            {
                Console.WriteLine("--------------------------------------------------.");
                Console.WriteLine("---> PLease enter in number of students (int, > 1).");
                numOfStudentsString = Console.ReadLine();
                if (!int.TryParse(numOfStudentsString, out numOfStudents))
                {
                    Console.WriteLine("ERROR: number of students must be int.  Try again.");
                }
                if (numOfStudents < 1)
                {
                    Console.WriteLine("ERROR: number of students cannot be < 1.  Try again.");
                }
            } while (numOfStudents < 1); // end do-while, num of students


            //2.2 - do-while loop to prompt user for name of student.
            for (int i = 1; i <= numOfStudents; ++i)
            {
                do
                {
                    Console.WriteLine("--------------------------------------------------.");
                    Console.WriteLine($"---> PLease enter in student #{i} name.");
                    studentName = Console.ReadLine();

                    if (String.IsNullOrEmpty(studentName))
                    {
                        Console.WriteLine("ERROR: Student name cannot be emptny. Try again.");
                    }
                } while (String.IsNullOrEmpty(studentName)); // end do-while, student name


                // 2.3 - Call getStudentGradeMeth(), pass in student name, number of items to grade, and name of item to grade, return avg score
                hwScoreAvg = getStudentGradeMeth(studentName, 5, "Homework");
                qzScoreAvg = getStudentGradeMeth(studentName, 3, "Quiz");
                exScoreAvg = getStudentGradeMeth(studentName, 2, "Exam");


                // 2.4 -  Calculate total avg, final grade = (50% * homework avg) + (30% * quiz avg) + (20% * exam avg)
                totalAvg = (int)((0.50 * hwScoreAvg) + (0.30 * qzScoreAvg) + (0.20 * exScoreAvg));


                // 2.5 - Switch Statements. Produce letter grade based on avg score
                switch (totalAvg)
                {
                    case >= 90:
                        letterGrade = "A";
                        break;
                    case >= 80:
                        letterGrade = "B";
                        break;
                    case >= 70:
                        letterGrade = "C";
                        break;
                    case >= 60:
                        letterGrade = "D";
                        break;
                    default:
                        letterGrade = "F";
                        break;
                }


                // 2.6 - Display student name, homework score avg, quiz score avg, exam score avg, final avg & letter grade
                Console.WriteLine($"Student {studentName}'s final evaluation...");
                Console.WriteLine($"homework avg = {hwScoreAvg}, quiz avg = {qzScoreAvg}, exam avg = {exScoreAvg}.");
                Console.WriteLine($"Total Average = {totalAvg}, with a letter grade of = '{letterGrade}'.");


                // 2.7 - Reset homework score avg, quiz score avg, exam score avg back to 0 value.
                hwScoreAvg = qzScoreAvg = exScoreAvg = totalAvg = 0;

            } // end for-loop, numb of students


        } // end Main()
    } // end Class
} // end namespace

