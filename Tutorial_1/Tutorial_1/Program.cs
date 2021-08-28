using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial_1     
{
    class Program       // Container
    {
        static void Main(string[] args)     // Method or a Function. Also a Container, that contains all the Executable Code!
        {
            //Basic variable Types
            #region Tutorial_part_1
            //Basic variable Types
            //string characterName="John";
            //char grade = 'A';
            //int characterAge=25;
            //double gpa = 3.2; //float,double,decimal -> from least to most accurate
            //bool isMale = true;

            //const int n30 = 30;


            //                                                        // The order of writing the code actually Matters Alot !!!!!
            //Console.WriteLine("Man name's " + characterName);      // Set of instructions must be in order !
            //Console.WriteLine("He is " + characterAge + " years old " );
            //Console.WriteLine("He likes the name " + characterName);
            //Console.WriteLine("But don't like being " + characterAge);
            //Console.ReadLine();
            //Tutorial_part_1 
            #endregion

            //STRING OPERATIONS
            #region Tutorial_part_2
            //STRING OPERATIONS
            //
            //Console.WriteLine("Giraffe\"Academy");
            //Console.WriteLine("Giraffe\nAcademy");
            //string phase = "Giraffe Academy " + "is cool";
            ////0123456789~ index of character in String 
            //string contains = "Academy";
            //Console.WriteLine(phase.ToUpper());
            //Console.WriteLine(phase.Contains(contains));
            //Console.WriteLine(phase[8]);
            //Console.WriteLine(phase.IndexOf("Academy"));  // Returns the Index of the first character in the  Found string
            //Console.WriteLine(phase.IndexOf('z'));  // Not inside of String, Returns -1
            //Console.WriteLine(phase.Substring(8));  // Returns all after the 8th character
            //Console.WriteLine(phase.Substring(phase.IndexOf("Academy")));  // Combining two different functions for string operations

            //Console.ReadLine();

            #endregion

            // Mathematical Operations
            #region Tutorial_part_3
            // Mathematical Operations
            //  Console.WriteLine(5+8);     // Will make computation math
            //  Console.WriteLine(5%2);       // Modules operator
            //  Console.WriteLine((4+2)*3);       // Multiplication is taking priority, using Parenthesis will help with the Order of Calculations
            //   Console.WriteLine(5 / 2.0);           // If one of the numbers is Decimal, the result will return decimal,
            //   Console.WriteLine(5 / 2);           // but if Both of the numbers are Integer, the end result, no matter the operation, is Integer
            //int num = 6;
            //num++;  //num--
            //Console.WriteLine(num);

            // Methods = block of code performs a specific task
            // Calling a Method
            // for e.g. Math

            //Console.WriteLine(Math.);   //Math.Abs(-40)); Pow(3.8,2); Sqrt(36)); Max(4,90); Round(4.66)
            //Console.ReadLine();

            #endregion

            // Get User Input
            #region Tutorial_part_4
            //// Get User Input

            //Console.Write("Enter your name: ");     //Prompt for a User         //For Future Reference Carriege Return , LineFeed = "\r\n"
            //string name = Console.ReadLine();      // Always is a STRING INPUT
            //Console.WriteLine("Hello " + name);
            //Console.Write("Enter your age: ");     //Prompt for a User         //For Future Reference Carriege Return , LineFeed = "\r\n"
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Your age is " + age);
            //Console.ReadLine();

            #endregion

            // Building a Calculator(basic)
            #region Tutorial_part_5
            // Building a Calculator (basic)
            //int num = Convert.ToInt32("45");    // Only ASCII NUMBERS, any other letter or symbol will return Error

            //Console.WriteLine(num+6);

            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine()); // Only takse Inputs in the format it is required to, otherwise Error is set
            //Console.Write("Enter another number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine(num1 + num2);
            //Console.ReadLine();
            #endregion

            //Building a Mad Libs Game
            #region Tutorial_part_6
            //Building a Mad Libs Game

            //string color, pluralNoun, celebrity;

            //Console.Write("Enter a color: ");
            //color = Console.ReadLine();

            //Console.Write("Enter a plural noun: ");
            //pluralNoun = Console.ReadLine();

            //Console.Write("Enter a celebrity: ");
            //celebrity = Console.ReadLine();

            //Console.WriteLine("Roses are "+color);
            //Console.WriteLine(pluralNoun + " are blue");
            //Console.WriteLine("I Love "+celebrity+" !");

            //Console.Read();

            #endregion

            // Arrays
            #region Tutorial_part_7
            // Arrays
            //int[] luckyNumbers = { 4,8,15,16,23,42 };
            //                    // 0,1,2 , 3, 4, 5
            ////access individual elements in the array
            //Console.WriteLine(luckyNumbers[0]);
            ////update a value of an element
            //luckyNumbers[1] = 900;
            //Console.WriteLine(luckyNumbers[1]);

            //string[] friends = new string[5];//must put number of elements of the array to hold, new is giving empty array
            //friends[0] = "Jim";
            //friends[1] = "Kelly";

            //for (int i = 0; i < friends.Length; i++)
            //{
            //    Console.WriteLine(friends[i]);
            //}


            //Console.ReadLine();
            #endregion

            ////call the Method, use #Region Tutorial_part_8
            #region Tutorial_part_8_sub
            ////call the Method, use #Region Tutorial_part_8
            //SayHi("Mike", 33);        // Passing information into the Method are called Parameters, or Arguments
            //SayHi("John", 56);
            //SayHi("Tom", 14);
            #endregion

            //// Return values from the Method. use #Region Tutorial_part_9
            #region Tutorial_part_9_sub
            //// Return values from the Method. use #Region Tutorial_part_9
            //Console.WriteLine(Cubed(5));
            #endregion

            // If Statements
            #region Tutorial_part_10
            //// If Statements
            //bool isMale = false;
            //bool isTall = true;

            //if (isMale && isTall)   // &&(AND) , ||(OR)
            //{
            //    Console.WriteLine("You are a tall male");
            //}
            //else if (isMale && !isTall)
            //{
            //    Console.WriteLine("You are a short male");
            //}
            //else if (!isMale && isTall)
            //{
            //    Console.WriteLine("You are a tall, but you are a female");
            //}
            //else
            //{
            //    Console.WriteLine("You are either not male or not tall or both");
            //}
            #endregion

            // More If Statements
            #region Tutorial_part_11_sub
            //// More If Statements

            ////build a MAX method. Takes 2 inputs, and returns the Greater number
            //Console.WriteLine(GetMax(22, 100, 40));

            #endregion

            // Building a Better Calculator (4 Function +,-,/,*)
            #region Tutorial_part_12
            //// Building a Better Calculator 
            //// Let the user input the numbers and also specify the Arithmetic Operation

            //Console.WriteLine("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Choose Operator:");
            //string op = Console.ReadLine();

            //Console.WriteLine("Enter a number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //if (op == "+")
            //{
            //    Console.WriteLine(num1 + num2);
            //}
            //else if (op=="-")
            //{
            //    Console.WriteLine(num1 - num2);
            //}
            //else if (op == "/")
            //{
            //    Console.WriteLine(num1 / num2);
            //}
            //else if (op == "*")
            //{
            //    Console.WriteLine(num1 * num2);
            //}
            //else
            //{               
            //    Console.WriteLine("Invalid Operator");        
            //}


            #endregion

            // Switch Case Statement
            #region Tutorial_part_13_sub
            // // Switch Case Statement
            // Console.WriteLine("Enter a number of the week");
            //Console.WriteLine( GetDay(Convert.ToInt32(Console.ReadLine())));

            #endregion

            //While LOOP , DO WHILE
            #region Tutorial_part_14
            //While LOOP, DO WHILE

            //int index = 1;

            //while (index <=5)     // First checks the Condition
            //{
            //    Console.WriteLine("count: " + index);
            //    index++;

            //}

            //int index = 6;

            //do                    //First Do(Run the code), after it Checks the Condition
            //{
            //    Console.WriteLine("count: " + index);
            //    index++;

            //} while (index <= 5) ;

            #endregion

            //Building a Guessing Game
            #region Tutorial_part_15
            //Building a Guessing Game  -Define a secret word for User to Gueass it

            //string secretWord = "giraffe";
            //string guess = "";
            //int guessCount = 0;
            //int guessLimit = 3;
            //bool outofGuesses = false;

            //do
            //{
            //    Console.Write("Enter guess: ");
            //    guess = Console.ReadLine();
            //    if (guess != secretWord)
            //    {
            //        guessCount++;
            //    }

            //    outofGuesses = (guessCount == guessLimit);      // outofGuesses -> It is like a FLAG, which Raises a Condition or State
            //}
            //while ((guess != secretWord) && (!outofGuesses));

            //if (outofGuesses)
            //{
            //    Console.Write("You are out of Guesses!");
            //}
            //else
            //{
            //    Console.Write("You win!");
            //}
            #endregion

            //For Loops
            #region Tutorial_part_16
            //For Loops
            ////int i = 1;
            ////while (i<=5)
            ////{
            ////    Console.WriteLine(i);
            ////    i++;
            ////}
            //for (int i = 0; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            //Building an Exponent Method  = ONLY WORKS for POSITIVE PowerNumbers
            #region Tutorial_part_17_sub
            //Building an Exponent Method  

            // pass a 2,3 -> 2^3  etc.
            //Console.WriteLine( getPow(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine())));

            #endregion

            //2D - ARRAYS
            #region Tutorial_part_18
            //2D - ARRAYS
            /*  int[,] numberGrid =
              {
                  {1, 2 },
                  {3, 4 },
                  {5, 6 }
              };

              Console.WriteLine(numberGrid[1, 1]);

              int[,] myArray = new int[2, 3]; // Telling C# what size is the Array in example given = 2 rows, 3 columns.*/
            #endregion


            //Exception Handling 
            #region Tutorial_part_19
            //Exception Handling - Tells you something that happen which C# couldnt handle!!!.
            // The program wiil terminate, or keep going when an exception gets thrown.
            // Basics with working with exception.
            //try
            //{      // Any Code that we think Can Break the Program, can be put in Try Block. When it Breaks the Code will go to Catch Block and execute whatever code we have there!!
            //    Console.Write("Enter a number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine()); // There is a code that might Throw an Exception, and Try to Catch it, and instead of Crashing we wanna be able to Handle it.
            //    Console.Write("Enter another number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine(num1 / num2);
            //}
            ////catch(Exception e) // We can get more information about the Error that occured with applying () arguments to catch
            ////{
            ////    Console.WriteLine(e.Message);
            ////}
            ////// But what if we want to divide and do different things based on the Catched Exception, for example when DivideByZero DO THIS, when Entered wrong Format DO THAT
            ////// So we can Define Specific Exceptions
            ////This way we can Account for the different Exceptions
            //catch (DivideByZeroException e) 
            //{
            //    Console.WriteLine(e.Message); // Depending on the Exception you can put different code to be executed in the Catch Block
            //}
            //catch (FormatException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            ////// This will be executed NO MATTER WHAT!!! - this is Optional.... Not often used!
            ////finally
            ////{
            ////    Console.WriteLine(num1 / num2); 
            ////}

            #endregion

            // Classes & Objects
            #region Tutorial_part_20
            // Classes & Objects - Creating Custom Data Types
            // E.G. - a Phone, a Book
            // Objects - stores the Class, and is an instance of it
            //Book book1 = new Book(); // instance of a book
            //book1.title = "Harry Potter";
            //book1.author = "JK Rowling";
            //book1.pages = 400;

            //Book book2 = new Book(); // instance of a book
            //book2.title = "Lord of the Rings";
            //book2.author = "JRR Tolkien";
            //book2.pages = 700;

            //Console.WriteLine($"{book1.title} is written by {book1.author} and is {book1.pages} pages long");
            //Console.WriteLine($"{book2.title} is written by {book2.author} and is {book2.pages} pages long");

            #endregion

            // Constructors
            #region Tutorial_part_21
            //// Constructors -  special Method to put inside a C# CLASS, whenever we create an Object of the specific Class
            //// This is Linked to  Tutorial_part_20, and inside the Class
            //// The Constructor is created inside the Class and is by the same name. It can be created as many as needed.
            //Book book1 = new Book("Harry Potter", "JK Rowling", 400); // instance of a book

            //Book book2 = new Book("Lord of the Rings", "JRR Tolkien", 700); // instance of a book

            //Book book3 = new Book(); //e.g. there is a Constructor that Takes No Arguments

            //Console.WriteLine($"{book1.title} is written by {book1.author} and is {book1.pages} pages long");
            //Console.WriteLine($"{book2.title} is written by {book2.author} and is {book2.pages} pages long");
            //// Very Powerful 
            #endregion

            // Object Methods
            #region Tutorial_part_22
            //// Object Methods - Method that can be defined inside our class, that the objects of that class can use it, for example: find information, or modify information about themselves
            //Student student1 = new Student("Jim", "Bussiness", 2.8);
            //Student student2 = new Student("Pam", "Art", 3.6);

            //Console.WriteLine(student1.HasHonors());    // Depending on WHO calls the Method it will execute and return the proper information corresponding to the caller's class constructed attributes and their values.
            //Console.WriteLine(student2.HasHonors());

            #endregion


            //  Getters & Setters
            #region Tutorial_part_23
            ////  Getters & Setters - Two Types of Methods in Classes, that can Control the Access People have to the Attributes of these classes
            //// Makes your Classes more Secure. Allows to Define what Data is Valid and Invalid.
            //Movie avengers = new Movie("The Avengers", "Joss Whedon", "Dog"); //PG-13
            //Movie shrek = new Movie("Shrek", "Adam Adamson", "PG");
            //// G, PG, PG-13, R, NR    Rating Rules
            //// Prevent Overwriting and Wrongly Setting the Value of Rating!!!!, first by making Private variable, after that Getter & Setter
            //shrek.Rating = "R";
            //Console.WriteLine($"Shrek Rating is:{shrek.Rating}");
            //Console.WriteLine($"Shrek Rating is:{avengers.Rating}");
            //// Createing the Getters & Setters for Each Attribute is making it better secured and useful !!!
            #endregion

            // Static Class Attributes
            #region Tutorial_part_24
            //// Static Class Attributes - Special kind of attribute, that is shared by all of the Objects of the instances of that Class 
            //// In other words, Static Attributes is contained in the Class, not in the individual Objects
            //// Very Useful

            //Song holiday = new Song("Holiday", "Green Day", 200);
            //Console.WriteLine(Song.songCount);  // useful as to know how many Instances are Created lets say.
            //Console.WriteLine(holiday.getSongCount()); // when a Method is created inside we can get the same Song Count!!!
            //// but Doesn't give the individual songcout when song was created.
            //                                    // For other projects, -> how many Stations are created lets say.

            //Song kashmir = new Song("Kasmir", "Led Zeppelin", 150);
            //Console.WriteLine(Song.songCount);
            //Console.WriteLine(kashmir.getSongCount());


            #endregion

            // Static Methods & Classes
            #region Tutorial_part_25
            //  // Static Methods & Classes
            //  // Static Method that belongs to the Class itself
            //  // Console.WriteLine(Math.Sqrt(144)); // example of the Static Method is the Method Math!
            ///*  UsefulTools tools = new UsefulTools(); // If we want to create an Instance from the Static Method Class*/
            //  // but if we Dont want to, we must Specify inside the Class that it is STATIC CLASS 
            //  UsefulTools.SayHi(Console.ReadLine());

            #endregion

            // Inheritance
            #region Tutorial_part_26
            // Inheritance - One class can inherit  all of the functionality of another class
            // Super Class, and Sub Class, which inherits from the Super Class

            Chef chef = new Chef();     // Super Class
            chef.MakeChicken();
            chef.MakeSpecialDish();

            ItalianChef italianChef = new ItalianChef();    // Sub Class
            italianChef.MakePasta();
            italianChef.MakeChicken();
            italianChef.MakeSpecialDish();

            // What if The ItalianChef doesn't make BBQ Ribs as a SpecialDish
            // Then Overriding a Method. See inside the both classes

            #endregion

            Console.ReadLine();

            //Lookup Naming Convetion !
        }

        //Creating and Using a Method
        #region Tutorial_part_8
        ////METHODS  - block of code that does a specific task
        //// Take all that lines of code and put in a container. Then execute it and perform the task that code will carry out.
        //// Be able to re-use it several times and at different location of the main code.

        ////Say Hi to whoever is using the program

        //static void SayHi(string name, int age)  

        // //need to specify a Return type, void will return nothing. The Method can do a specific task, but also give us back Information
        // // O N L Y a C O D E In The Main Method Will Be EXECUTED ! ! ! , must be called
        //{     
        //    Console.WriteLine("Hello "+ name + " you are " + age);        
        //}
        #endregion

        //Return Statements
        #region Tutorial_part_9

        //// Returns values back to the caller. Extremly Useful
        //static double Cubed(double num)
        //{
        //    double result = Math.Pow(num,3);

        //    return result;
        //}


        #endregion

        // MAX Method
        #region Tutorial_part_11
        // MAX Method

        //static int GetMax(int num1, int num2, int num3)
        //{
        //    int result;

        //    if (num1 >= num2 && num1 >= num3)           // Comparison Operators >,<,>=,<=,==, != .
        //                                               // Also Comparing characters: 'c'!= 'b'
        //    {
        //        result = num1;
        //    }
        //    else if (num2 >= num1 && num2 >= num3)
        //    {
        //        result = num2;
        //    }
        //    else
        //    {
        //        result = num3;
        //    }

        //    return result;
        //}
        #endregion

        //Switch Case, return day of the week by number
        #region Tutorial_part_13
        ////Switch Case, return day of the week by number

        ////0 - > "sunday"
        ////1 - > "monday"

        //static string GetDay(int daynum)
        //{
        //    string dayname;

        //    switch (daynum)
        //    {
        //        case 0:
        //            dayname = "Sunday";
        //                break;

        //        case 1:
        //            dayname = "Monday";
        //                break;
        //        case 2:
        //            dayname = "Tuesday";
        //                break;
        //        case 3:
        //            dayname = "Wednesday";
        //                break;
        //        case 4:
        //            dayname = "Thursday";
        //                break;
        //        case 5:
        //            dayname = "Friday";
        //                break;
        //        case 6:
        //            dayname = "Saturday";
        //                break;
        //        default:
        //            dayname = "Invalid Day Number";
        //            break;
        //    }

        //    return dayname;
        //}
        #endregion

        //Building an Exponent Method =  ONLY WORKS for POSITIVE PowerNumbers
        #region Tutorial_part_17
        //Building an Exponent Method
        //static int getPow(int baseNum, int powNum)
        //{
        //    int result = 1;

        //    for (int i = 0; i < powNum; i++)
        //    {
        //        result =    result  * baseNum;
        //    }
        //    return result;
        //}
        #endregion
    }

}
