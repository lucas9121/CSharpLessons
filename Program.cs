// See https://aka.ms/new-console-template for more information
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    } else{
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
}


if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}


Random random = new Random();
int daysUntilExpiration = random.Next(12);
// int discountPercentage = 0;

// Your code goes here

if(daysUntilExpiration > 5 && daysUntilExpiration <= 10){
    Console.WriteLine("Your subscription will expire soon. Renew now!");
} else if (daysUntilExpiration > 1 && daysUntilExpiration <= 5){
    Console.Write($"Your subscription expires in ${daysUntilExpiration} days.\nRenew now and save 10%!\n");
} else if (daysUntilExpiration == 1){
    Console.Write("Your subscription expires within a day!\nRenew now and save 20%!\n");
} else {
    Console.WriteLine("Your subscription has expired.");
}



//////////////////////////////////////////////// for each ////////////////////////////////////////////////

string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] = "F000";

Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

int[] inventory = [200, 450, 700, 175, 250];
int sum = 0;
int bin = 0;
foreach(int item in inventory){
    sum += item;
    bin++;
    Console.WriteLine($"Bin {bin} = {item} items (Running total: {sum})");
}
Console.WriteLine($"We have {sum} items in inventory");

string[] newFraudulentOrderIDs = ["B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"];

foreach(string nameID in newFraudulentOrderIDs){
    if(nameID.StartsWith('B')){
        Console.WriteLine($"fradulent id: nameID");
    }
}


//////////////////////////////////////////////// Student Grade ////////////////////////////////////////////////

// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = [90, 86, 87, 98, 100];
int[] andrewScores = [92, 89, 81, 96, 90];
int[] emmaScores = [90, 85, 87, 98, 68];
int[] loganScores = [90, 95, 87, 88, 96];

// Student names
string[] studentNames = [ "Sophia", "Andrew", "Emma", "Logan" ];

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Write the Report Header to the console
Console.WriteLine("Student\t\tGrade\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    foreach (int score in studentScores)
    {
        // add the exam score to the sum
        sumAssignmentScores += score;
    }

    currentStudentGrade = (decimal)sumAssignmentScores / currentAssignments;

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

    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}