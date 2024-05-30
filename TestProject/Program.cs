using System;

int currentAssignments = 5;

// initialize variables - graded assignments
int[] sophiaScores = new int[] {90, 86, 87, 98, 100, 94, 90};
int[] andrewScores = new int[] {92, 89, 81, 96, 90, 89};
int[] emmaScores = new int[] {90, 85, 87, 98, 68, 89, 89, 89};
int[] loganScores = new int[] {90, 95, 87, 88, 96, 96};

// student names
string[] studentNames = new string[] {"Sophia", "Andrew", "Logan", "Emma"};

// current student scores
int[] studentScores = new int[10];
string currentStudentLetterGrade = "";

Console.WriteLine("Student\t\tExam Score\t\tOverall\t\tGrade\t\tExtra Credit\n");

foreach(string name in studentNames) {
    if (name == "Sophia")
        studentScores = sophiaScores;
    else if (name == "Andrew")
        studentScores = andrewScores;
    else if (name == "Logan")
        studentScores = loganScores;
    else if (name == "Emma")
        studentScores = emmaScores;

    decimal sumAssingmentScores = 0;
    int sumCreditsScores = 0;
    int sumExamScores = 0;

    decimal currentExtraCreditPoints;
    decimal currentStudentGrade;
    decimal currentExtraCredit;
    decimal currentExamScore;

    int gradedAssignmentsCounter = 0;
    int creditsCounter = 0;

    foreach(int score in studentScores) {
        // add the exam score with extra credits to the sum
        if (gradedAssignmentsCounter >= currentAssignments) {
            sumAssingmentScores += (decimal)score / 10;
            sumCreditsScores += score;
            creditsCounter++;
        } else {
            // add the exam score to the sum
            sumAssingmentScores += score;
            sumExamScores += score;
        }
        gradedAssignmentsCounter++;
    }

    currentExtraCreditPoints = ((decimal)sumCreditsScores / 10) / currentAssignments;
    currentStudentGrade = (decimal)sumAssingmentScores / currentAssignments;
    currentExtraCredit = (decimal)sumCreditsScores / creditsCounter;
    currentExamScore = (decimal)sumExamScores / currentAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";

    Console.WriteLine($"{name}:\t\t{currentExamScore}\t\t\t{currentStudentGrade}\t\t{currentStudentLetterGrade}\t\t{currentExtraCredit} ({currentExtraCreditPoints} pts)");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();