using System;

/*
    Name: Josh Boothe
    Class: CSE 210
    Description:
        Eternal Quest Program for tracking simple, eternal, and checklist goals.

    Creativity / Exceeding Requirements:
        I added a gamification ranking system that gives the user a title based on
        their score. The program displays the user's current rank and gives a
        level-up message when the user's rank increases after recording a goal.

    Sources:
        1. https://byui-cse.github.io/cse210-course-2023
        2. CSE 210 Eternal Quest assignment instructions
*/

class Program
{
    static void Main(string[] args)
    {
        GoalManager jlbGoalManager = new GoalManager();
        jlbGoalManager.JlbStart();
    }
}