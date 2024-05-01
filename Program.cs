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

int examAssignments = 5;

string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan"];

int[] sophiaScores = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScores = [92, 89, 81, 96, 90, 89];
int[] emmaScores = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScores = [90, 95, 87, 88, 96, 96];

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// display the header row for scores/grades
Console.Clear();
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");

/*
The outer foreach loop is used to:
- iterate through student names 
- assign a student's grades to the studentScores array
- calculate exam and extra credit sums (inner foreach loop)
- calculate numeric and letter grade
- write the score report information
*/
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

    int gradedAssignments = 0;
    int gradedExtraCreditAssignments = 0;

    int sumExamScores = 0;
    int sumExtraCreditScores = 0;

    decimal currentStudentGrade = 0;
    decimal currentStudentExamScore = 0;
    decimal currentStudentExtraCreditScore = 0;

    /* 
    the inner foreach loop: 
    - sums the exam and extra credit scores
    - counts the extra credit assignments
    */
    foreach (int score in studentScores)
    {
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
        {
            sumExamScores = sumExamScores + score;
        }

        else
        {
            gradedExtraCreditAssignments += 1;
            sumExtraCreditScores += score;
        }
    }

    currentStudentExamScore = (decimal)sumExamScores / examAssignments;
    currentStudentExtraCreditScore = (decimal)sumExtraCreditScores / gradedExtraCreditAssignments;

    currentStudentGrade = (sumExamScores + ((decimal)sumExtraCreditScores / 10)) / examAssignments;

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

    Console.WriteLine($"{currentStudent}\t\t{currentStudentExamScore}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentStudentExtraCreditScore} ({(((decimal)sumExtraCreditScores / 10) / examAssignments)} pts)");
}



//////////////////////////////////////////////// Boolean Expressions ////////////////////////////////////////////////

string permission = "Admin|Manager";
int level = 53;

if (permission.Contains("Admin"))
{
    if (level > 55)
    {
        Console.WriteLine("Welcome, Super Admin user.");
    }
    else
    {
        Console.WriteLine("Welcome, Admin user.");
    }
}
else if (permission.Contains("Manager"))
{
    if (level >= 20)
    {
        Console.WriteLine("Contact an Admin for access.");
    }
    else
    {
        Console.WriteLine("You do not have sufficient privileges.");
    }
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}



//////////////////////////////////////////////// Variable Scope ////////////////////////////////////////////////

int[] numbers = { 4, 8, 15, 16, 23, 42 };
int totalNumbers = 0;
bool found = false;

foreach (int number in numbers)
{
    totalNumbers += number;
    if (number == 42)
        found = true;
}

if (found)
    Console.WriteLine("Set contains 42");

Console.WriteLine($"Total: {totalNumbers}");



//////////////////////////////////////////////// Switch case ////////////////////////////////////////////////

int employeeLevel = 100;
string employeeName = "John Smith";

string employeeTitle = "";

switch (employeeLevel)
{
    case 100:
        employeeTitle = "Junior Associate";
        break;
    case 200:
        employeeTitle = "Senior Associate";
        break;
    case 300:
        employeeTitle = "Manager";
        break;
    case 400:
        employeeTitle = "Senior Manager";
        break;
    default:
        employeeTitle = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {employeeTitle}");


// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string stockType = "";
string stockColor = "";
string stockSize = "";

switch (product[0])
{
    case "01":
        stockType = "Sweat shirt";
        break;
    case "02":
        stockType = "T-Shirt";
        break;
    case "03":
        stockType = "Sweat pants";
        break;
    default:
        stockType = "Other";
        break;
}

switch (product[1])
{
    case "BL":
        stockColor = "Black";
        break;
    case "MN":
        stockColor = "Maroon";
        break;
    default:
        stockColor = "White";
        break;
}

switch (product[2])
{
    case "S":
        stockSize = "Small";
        break;
    case "M":
        stockSize = "Medium";
        break;
    case "L":
        stockSize = "Large";
        break;
    default:
        stockSize = "One Size Fits All";
        break;
}

Console.WriteLine($"Product: {stockSize} {stockColor} {stockType}");