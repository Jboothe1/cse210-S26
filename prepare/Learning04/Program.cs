using System;

/*
    Name: Josh Boothe
    Class: CSE 210
    Description:
        Program to demonstrate inheritance using a base Assignment class
        and two derived classes: MathAssignment and WritingAssignment.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. Teacher notes
*/

class Program
{
    static void Main(string[] args)
    {
        //Input

        Assignment jlbAssignment = new Assignment(
            "Samuel Bennett",
            "Multiplication"
        );

        MathAssignment jlbMathAssignment = new MathAssignment(
            "Roberto Rodriguez",
            "Fractions",
            "7.3",
            "8-19"
        );

        WritingAssignment jlbWritingAssignment = new WritingAssignment(
            "Mary Waters",
            "European History",
            "The Causes of World War II"
        );

        //Process

        string jlbAssignmentSummary = jlbAssignment.jlbGetSummary();

        string jlbMathSummary = jlbMathAssignment.jlbGetSummary();
        string jlbMathHomeworkList = jlbMathAssignment.jlbGetHomeworkList();

        string jlbWritingSummary = jlbWritingAssignment.jlbGetSummary();
        string jlbWritingInformation = jlbWritingAssignment.jlbGetWritingInformation();

        //Output

        jlbPrint(jlbAssignmentSummary);

        jlbPrint("");

        jlbPrint(jlbMathSummary);
        jlbPrint(jlbMathHomeworkList);

        jlbPrint("");

        jlbPrint(jlbWritingSummary);
        jlbPrint(jlbWritingInformation);
    }

    //Project Output functions that call Support Functions

    public static void jlbPrint(string jlbText)
    {
        Support.jlbDisplay(jlbText);
    }
}