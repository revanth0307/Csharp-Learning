class Question
{
    public string questionText;
    public string optionA;
    public string optionB;
    public string optionC;
    public string optionD;
    public char correctAnswerLetter;
    private static char defaultCorrectAnswerLetter='X';

    public Question()
    {
        //TO DO: Initialize questionText, optionA, optionB, optionC, optionD as null. Initialize correctAnswerLetter to the
        //value of static field 'defaultCorrectAnswerLetter'.
        questionText = null;
        optionA = null;
        optionB = null;
        optionC = null;
        optionD = null;
        correctAnswerLetter = defaultCorrectAnswerLetter;

    }

    public Question(string questionText)
    {
        //TO DO: Initialize questionText.
        //Also, initialize optionA, optionB, optionC, optionD as null.
        //Initialize correctAnswerLetter to the value of static field 'defaultCorrectAnswerLetter'.
        this.questionText = questionText;
        optionA = null;
        optionB = null;
        optionC = null;
        optionD = null;
        correctAnswerLetter=defaultCorrectAnswerLetter;

    }

    public Question(string questionText, string optionA, string optionB, string optionC, string optionD, char correctAnswerLetter)
    {
        //TO DO: Initialize questionText, optionA, optionB, optionC, optionD and correctAnswerText.
        //Validate the value of correctAnswerLetter. It should either 'A', 'B', 'C' or 'D' only
        this.questionText=questionText;
        this.optionA=optionA;
        this.optionB=optionB;
        this.optionC=optionC;
        this.optionD=optionD;

        if (correctAnswerLetter == 'A' || correctAnswerLetter == 'B' || correctAnswerLetter == 'C' || correctAnswerLetter == 'D')
        {
            this.correctAnswerLetter= correctAnswerLetter;
        }
        else
        {
            this.correctAnswerLetter=defaultCorrectAnswerLetter;
        }
    }

    public bool AreOptionsValid()
    {
        //TO DO: Return true, if at least two options are not null
        int count = 0;
        if (optionA != null) count++;
        if (optionB != null) count++;
        if (optionC != null) count++;
        if (optionD != null) count++;
        return count >= 2;

    }

    public void DisplayQuestion()
    {
        Console.WriteLine("Question: " + questionText);
        Console.WriteLine("A: " + optionA);
        Console.WriteLine("B: " + optionB);
        Console.WriteLine("C: " + optionC);
        Console.WriteLine("D: " + optionD);
    }
}

class Program
{
    static void Main()
    {
        //TO DO: Create an object of Question class and pass no arguments to the constructor
        Question question1 = new Question();
        //TO DO: Create an object of Question class and pass value for questionText only to the constructor.
        Question question2 = new Question("Can multiple inheritance possible in C# using interfaces?");
        //TO DO: Create an object of Question class and pass values for questionText, optionA, optionB, optionC, optionD
        //and correctAnswerLetter to the constructor.
        Question question3 = new Question("Can multiple inheritance possible in C# using interfaces?", "Yes", "No", "May Be", "NA",'A');
        //TO DO: Create an object of Question class and pass
        //values for questionText, optionA, optionB, optionC, optionD only to the constructor.
        Question question4 = new Question("Which language is used for .NET?")
        {
            optionA = "Java",
            optionB = "C#",
            optionC = "Python",
            optionD = null
        };

        question3.DisplayQuestion();
        Console.WriteLine("Enter your choice:");
        string input=Console.ReadLine();
        char userAnswer = char.ToUpper(input[0]);
        if (userAnswer == question3.correctAnswerLetter)
        {
            Console.WriteLine("Correct answer!!");
        }
        else
        {
            Console.WriteLine("Wrong answer!! the correct answer is: "+question3.correctAnswerLetter);
        }
        
    }
}