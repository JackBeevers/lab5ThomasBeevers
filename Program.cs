
void CreateCat()
{
Console.WriteLine("      beans    ");                            
Console.WriteLine("     ^_____^     ");                            
Console.WriteLine("   (  0   0  )   ");
Console.WriteLine("  ( ==  ^  == )   ");
Console.WriteLine("   )         (    ");
Console.WriteLine("  (           )   ");
Console.WriteLine(" ( (  )   (  ) )  ");
Console.WriteLine("(__(__)___(__)__) ");
Console.WriteLine("press enter when satifyed");
Console.ReadKey();
Console.Clear();
menu();
}

 
void returnsaying()
{
 Console.WriteLine("say something so i can say it back to you");
string userpick = Console.ReadLine();
 Console.WriteLine("This is what you wrote.");
 Console.WriteLine(userpick);
 Console.WriteLine("press enter when satifyed");
Console.ReadKey();
Console.Clear();
 menu();
}

void Addition()
{
 Console.WriteLine("Whats the first number you would like to add?");
    int Number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("whats the second?");
    int Number2 = int.Parse(Console.ReadLine());
    int Sum = Number1 + Number2;
    Console.WriteLine($"the total is {Sum}");
    Console.WriteLine("press enter when satifyed");
    Console.ReadKey();
    Console.Clear();
    menu();
}

void Subtraction()
{
Console.WriteLine("Whats the first number you would like to subtract?");
    int Number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("whats the second?");
    int Number2 = int.Parse(Console.ReadLine());
    int Difference = Number1 - Number2;
    Console.WriteLine($"the total is {Difference}");
    Console.WriteLine("press enter when satifyed");
    Console.ReadKey();
    Console.Clear();
    menu();
}

void Multiplication()
{
    Console.WriteLine("Whats the first number you would like to multiply?");
    int Number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("whats the second?");
    int Number2 = int.Parse(Console.ReadLine());
    int Product = Number1 * Number2;
    Console.WriteLine($"the total is {Product}");
    Console.WriteLine("press enter when satifyed");
    Console.ReadKey();
    Console.Clear();
    menu();
}

void Division()
{
    Console.WriteLine("Whats the first number you would like to divide?");
    int Number1 = int.Parse(Console.ReadLine());
    Console.WriteLine("whats the second?");
    int Number2 = int.Parse(Console.ReadLine());
    int Quotient = Number1 / Number2;
    Console.WriteLine($"the total is {Quotient}");
    Console.WriteLine("press enter when satifyed");
    Console.ReadKey();
    Console.Clear();
    menu();
}

void menu()
{
Console.WriteLine("What would you like to do?");
    Console.WriteLine("1. look at my cat?\n2. watch something you wrote down be repaeted back to you?\n3. Add Two Numbers together?\n4. Subtract Two Numbers from each other?\n5. Multiply Two Numbers against each other?\n6. Divide Two Numbers form each other?");
string answer = Console.ReadLine();
if (answer == "1" )
CreateCat();

if (answer == "2")
returnsaying();

if (answer == "3")
Addition();

if (answer == "4")
Subtraction();

if (answer == "5")
Multiplication();

if (answer == "6")
Division();
}
menu();