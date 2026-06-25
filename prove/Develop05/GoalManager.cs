using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _jlbGoals;
    private int _jlbScore;

    public GoalManager()
    {
        _jlbGoals = new List<Goal>();
        _jlbScore = 0;
    }

    public void JlbStart()
    {
        string jlbUserChoice = "";

        while (jlbUserChoice != "6")
        {
            JlbDisplayPlayerInfo();
            JlbDisplayMenu();

            jlbUserChoice = Console.ReadLine();
            Console.WriteLine();

            if (jlbUserChoice == "1")
            {
                JlbCreateGoal();
            }
            else if (jlbUserChoice == "2")
            {
                JlbListGoals();
            }
            else if (jlbUserChoice == "3")
            {
                JlbSaveGoals();
            }
            else if (jlbUserChoice == "4")
            {
                JlbLoadGoals();
            }
            else if (jlbUserChoice == "5")
            {
                JlbRecordEvent();
            }
            else if (jlbUserChoice == "6")
            {
                Console.WriteLine("Thanks for playing Eternal Quest. Keep working toward your goals!");
            }
            else
            {
                Console.WriteLine("Please choose a valid menu option.");
            }

            Console.WriteLine();
        }
    }

    private void JlbDisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_jlbScore} points.");
        Console.WriteLine($"Current Rank: {JlbGetRankForScore(_jlbScore)}");
        Console.WriteLine();
    }

    private void JlbDisplayMenu()
    {
        Console.WriteLine("Menu Options:");
        Console.WriteLine("  1. Create New Goal");
        Console.WriteLine("  2. List Goals");
        Console.WriteLine("  3. Save Goals");
        Console.WriteLine("  4. Load Goals");
        Console.WriteLine("  5. Record Event");
        Console.WriteLine("  6. Quit");
        Console.Write("Select a choice from the menu: ");
    }

    private void JlbCreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");

        int jlbGoalType = JlbPromptForInt("Which type of goal would you like to create? ", 1);

        if (jlbGoalType < 1 || jlbGoalType > 3)
        {
            Console.WriteLine("That is not a valid goal type.");
            return;
        }

        string jlbShortName = JlbPromptForText("What is the name of your goal? ");
        string jlbDescription = JlbPromptForText("What is a short description of it? ");
        int jlbPoints = JlbPromptForInt("What is the amount of points associated with this goal? ", 0);

        if (jlbGoalType == 1)
        {
            SimpleGoal jlbSimpleGoal = new SimpleGoal(jlbShortName, jlbDescription, jlbPoints);
            _jlbGoals.Add(jlbSimpleGoal);
        }
        else if (jlbGoalType == 2)
        {
            EternalGoal jlbEternalGoal = new EternalGoal(jlbShortName, jlbDescription, jlbPoints);
            _jlbGoals.Add(jlbEternalGoal);
        }
        else if (jlbGoalType == 3)
        {
            int jlbTargetCount = JlbPromptForInt("How many times does this goal need to be accomplished for a bonus? ", 1);
            int jlbBonusPoints = JlbPromptForInt("What is the bonus for accomplishing it that many times? ", 0);

            ChecklistGoal jlbChecklistGoal = new ChecklistGoal(jlbShortName, jlbDescription, jlbPoints, jlbTargetCount, jlbBonusPoints);
            _jlbGoals.Add(jlbChecklistGoal);
        }

        Console.WriteLine("Goal created successfully!");
    }

    private void JlbListGoals()
    {
        if (_jlbGoals.Count == 0)
        {
            Console.WriteLine("You do not have any goals yet.");
            return;
        }

        Console.WriteLine("The goals are:");

        for (int jlbIndex = 0; jlbIndex < _jlbGoals.Count; jlbIndex++)
        {
            Goal jlbGoal = _jlbGoals[jlbIndex];
            Console.WriteLine($"{jlbIndex + 1}. {jlbGoal.JlbGetDetailsString()}");
        }
    }

    private void JlbRecordEvent()
    {
        if (_jlbGoals.Count == 0)
        {
            Console.WriteLine("You do not have any goals to record yet.");
            return;
        }

        Console.WriteLine("The goals are:");

        for (int jlbIndex = 0; jlbIndex < _jlbGoals.Count; jlbIndex++)
        {
            Goal jlbGoal = _jlbGoals[jlbIndex];
            Console.WriteLine($"{jlbIndex + 1}. {jlbGoal.JlbGetShortName()}");
        }

        int jlbGoalNumber = JlbPromptForInt("Which goal did you accomplish? ", 1);

        if (jlbGoalNumber < 1 || jlbGoalNumber > _jlbGoals.Count)
        {
            Console.WriteLine("That goal number does not exist.");
            return;
        }

        Goal jlbSelectedGoal = _jlbGoals[jlbGoalNumber - 1];

        int jlbOldScore = _jlbScore;
        string jlbOldRank = JlbGetRankForScore(jlbOldScore);

        int jlbEarnedPoints = jlbSelectedGoal.JlbRecordEvent();

        if (jlbEarnedPoints > 0)
        {
            _jlbScore += jlbEarnedPoints;

            Console.WriteLine($"Congratulations! You have earned {jlbEarnedPoints} points!");
            Console.WriteLine($"You now have {_jlbScore} points.");

            string jlbNewRank = JlbGetRankForScore(_jlbScore);

            if (jlbOldRank != jlbNewRank)
            {
                Console.WriteLine($"Level up! Your new rank is: {jlbNewRank}");
            }
        }
        else
        {
            Console.WriteLine("That goal is already complete, so no extra points were added.");
        }
    }

    private void JlbSaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string jlbFileName = Console.ReadLine();

        using (StreamWriter jlbOutputFile = new StreamWriter(jlbFileName))
        {
            jlbOutputFile.WriteLine(_jlbScore);

            foreach (Goal jlbGoal in _jlbGoals)
            {
                jlbOutputFile.WriteLine(jlbGoal.JlbGetStringRepresentation());
            }
        }

        Console.WriteLine("Goals saved successfully!");
    }

    private void JlbLoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string jlbFileName = Console.ReadLine();

        if (!File.Exists(jlbFileName))
        {
            Console.WriteLine("That file does not exist.");
            return;
        }

        string[] jlbLines = File.ReadAllLines(jlbFileName);

        if (jlbLines.Length == 0)
        {
            Console.WriteLine("The file is empty.");
            return;
        }

        _jlbGoals.Clear();
        _jlbScore = int.Parse(jlbLines[0]);

        for (int jlbIndex = 1; jlbIndex < jlbLines.Length; jlbIndex++)
        {
            Goal jlbLoadedGoal = JlbCreateGoalFromFile(jlbLines[jlbIndex]);

            if (jlbLoadedGoal != null)
            {
                _jlbGoals.Add(jlbLoadedGoal);
            }
        }

        Console.WriteLine("Goals loaded successfully!");
    }

    private Goal JlbCreateGoalFromFile(string jlbLine)
    {
        string[] jlbMainParts = jlbLine.Split(new char[] { ':' }, 2);

        if (jlbMainParts.Length != 2)
        {
            return null;
        }

        string jlbGoalType = jlbMainParts[0];
        string[] jlbGoalParts = jlbMainParts[1].Split('|');

        if (jlbGoalType == "SimpleGoal")
        {
            string jlbShortName = jlbGoalParts[0];
            string jlbDescription = jlbGoalParts[1];
            int jlbPoints = int.Parse(jlbGoalParts[2]);
            bool jlbIsComplete = bool.Parse(jlbGoalParts[3]);

            return new SimpleGoal(jlbShortName, jlbDescription, jlbPoints, jlbIsComplete);
        }
        else if (jlbGoalType == "EternalGoal")
        {
            string jlbShortName = jlbGoalParts[0];
            string jlbDescription = jlbGoalParts[1];
            int jlbPoints = int.Parse(jlbGoalParts[2]);

            return new EternalGoal(jlbShortName, jlbDescription, jlbPoints);
        }
        else if (jlbGoalType == "ChecklistGoal")
        {
            string jlbShortName = jlbGoalParts[0];
            string jlbDescription = jlbGoalParts[1];
            int jlbPoints = int.Parse(jlbGoalParts[2]);
            int jlbTargetCount = int.Parse(jlbGoalParts[3]);
            int jlbBonusPoints = int.Parse(jlbGoalParts[4]);
            int jlbAmountCompleted = int.Parse(jlbGoalParts[5]);

            return new ChecklistGoal(jlbShortName, jlbDescription, jlbPoints, jlbTargetCount, jlbBonusPoints, jlbAmountCompleted);
        }

        return null;
    }

    private int JlbPromptForInt(string jlbPrompt, int jlbMinimumValue)
    {
        int jlbNumber;
        bool jlbIsValid = false;

        while (!jlbIsValid)
        {
            Console.Write(jlbPrompt);
            string jlbInput = Console.ReadLine();

            if (int.TryParse(jlbInput, out jlbNumber) && jlbNumber >= jlbMinimumValue)
            {
                return jlbNumber;
            }

            Console.WriteLine($"Please enter a whole number that is at least {jlbMinimumValue}.");
        }

        return 0;
    }

    private string JlbPromptForText(string jlbPrompt)
    {
        Console.Write(jlbPrompt);
        string jlbText = Console.ReadLine();

        jlbText = jlbText.Replace("|", "/");
        jlbText = jlbText.Replace(":", "-");

        return jlbText;
    }

    private string JlbGetRankForScore(int jlbScore)
    {
        if (jlbScore >= 5000)
        {
            return "Level 6 - Eternal Quest Champion";
        }
        else if (jlbScore >= 3000)
        {
            return "Level 5 - Goal Master";
        }
        else if (jlbScore >= 2000)
        {
            return "Level 4 - Disciplined Disciple";
        }
        else if (jlbScore >= 1000)
        {
            return "Level 3 - Steady Striver";
        }
        else if (jlbScore >= 500)
        {
            return "Level 2 - Quest Apprentice";
        }
        else
        {
            return "Level 1 - Humble Beginner";
        }
    }
}