/*
    * Author: Jonathan Cruz
    * Course: COMP-003A
    * Purpose: Lecture activity for variables, type system, Math, and Console properties
    * Reference: The C# Player's Guide (4e) by RB Whitaker
*/
using Microsoft.VisualBasic;
using static System.Formats.Asn1.AsnWriter;
using System.Diagnostics.Metrics;
using System.Runtime.Intrinsics.X86;

namespace COMP003A.LectureActivity2
    {
internal class Program
{
static void Main(string[] args)
{
/* working with variables */
// the following code shows all three primary variable-related activities:
string username; // declaring a variable (1 of 3)
Console.WriteLine("What is your name?"); // request for user input
username = Console.ReadLine(); // assigning a value to a variable (2 of 3)
Console.WriteLine("Hi " + username); // retrieving its current value (3 of 3)
20   
21   
22   // another example of the three primary variable related activities (declaring, assigning, and retrieving)
23   string favoriteColor;
24   Console.WriteLine("What is your favorite color?");
25   favoriteColor = Console.ReadLine();
26   Console.WriteLine("Your favorite color is " + favoriteColor);
27   
28   
29   /* working with variable integers */
30   int score; // declare a new variable with a data type int
31   // score = "Generic User"; // will fail to compile because you are assigning a string value to an integer variable
32   // score = "0"; // will still fail to compile because the "0" is still assigned as a string - enclosed in the double quotes
33   score = 0; // works
34   score = 4; // you can also reassign values to the variable as long as they are within scope and not constant
35   score = 11;
36   score = - 1564;
37   
38   
39   /* reading from a variable does not change it */
40   int a;
41   int b;
42   
43   a = 5;
44   b = 2;
45   Console.WriteLine("The current value of a: " + a);
46   Console.WriteLine("The current value of b: " + b);
47   
48   b = a;
49   a = - 3;
50   Console.WriteLine("The new value of a: " + a);
51   Console.WriteLine("The new value of b: " + b);
52   
53   /* variables are case-sensitive */
54   // the variables below are different despite having similar names
55   string exampleVariable;
56   string exampleVAriable;
57   string exampleVARiable;
58   
59   Console.WriteLine("**************************************************");
60   /*
61                * types of variables and values matter in C#. they are not interchangeable.
62                * there are eight integer types for storing integers of differing sizes and ranges: int, short, long, byte, sbyte, uint, ushort, and ulong.
63                * the char type stores single characters.
64                * the string type stores longer text.
65                * there are three types for storing real numbers: float, double, and decimal.
66                * the bool type stores truth values (true and false) used in logic.
67                * these types are the building blocks of a much larger type system.
68                * using var for a variable’s type tells the compiler to infer its type from the surrounding code, so you do not have to type it out. (But it still has a specific type.)
69                * the System.Convert class is a useful class to convert from one type to another.
70               */
71   
72   /* declaring and using variables with integer types */
73   byte aSingleByte = 34;
74   Console.WriteLine("aSingleByte: " + aSingleByte);
75   aSingleByte = 17;
76   Console.WriteLine("aSingleByte: " + aSingleByte);
77   
78   short aNumber = 5039;
79   Console.WriteLine("aNumber: " + aNumber);
80   aNumber = - 4354;
81   Console.WriteLine("aNumber: " + aNumber);
82   
83   long aVeryBigNumber = 395904282569;
84   Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);
85   aVeryBigNumber = 13;
86   Console.WriteLine("aVeryBigNumber: " + aVeryBigNumber);
87   
88   int anInteger = 2147483647;
89   
90   /* declaring,using, and concatenating characters ans strings */
91   char aLetter = 'A'; // character values are enclosed in single quotes
92   string message = "Hello World!"; // string values are enclosed in double quotes
93   
94   Console.WriteLine("Concatenation using + : " + aLetter + " " + message); // use the plus(+) sign in between characters/strings to concatenate
95   Console.WriteLine($"Concatenation using string interpolation : {aLetter} {message}"); // use string interpolation with a dollar-sign ($) before the opening double -quote and enclosing variables with curly braces ({variableName})
96
97   /* floating-point types */
98   double number1 = 3.5623;
99   float number2 = 3.5623f;
100   decimal number3 = 3.5623m;
101   Console.WriteLine($"Value of number1: {number1}");
102   Console.WriteLine($"Value of number2: {number2}");
103   Console.WriteLine($"Value of number3: {number3}");
104
105   /* scientific notation */
106   double avogadrosNumber = 6.022e23;
107   Console.WriteLine($"Value of avogadrosNumber: {avogadrosNumber}");
108
109   /* bool type */
110   bool itWorked = true;
111   Console.WriteLine($"Value of itWorked: {itWorked}");
112   itWorked = false;
113   Console.WriteLine($"New value of itWorked: {itWorked}");
114
115   /* convert */
116   string inputAgeString;
117   int inputAge;
118   int currentYear = 2023;
119
120   Console.WriteLine($"Enter age in {currentYear}: ");
121   inputAgeString = Console.ReadLine();
122   inputAge = Convert.ToInt32(inputAgeString);
123   Console.WriteLine($"Your age is {inputAge}");
124
125   Console.WriteLine("**************************************************");
126   /* 
127                * math operations 
128                * addition: +
129                * subtraction: -
130                * multiplication: *
131                * division: /
132                * modulo: % (remainder)
133                */
134   int addition = 2 + 3;
135   int subtraction = 5 - 2;
136   int multiplication = 22 * 2;
137   int division = 21 / 7;
138   int modulo = 77 % 5;
139   Console.WriteLine($"Value of addition: {addition}");
140   Console.WriteLine($"Value of subtraction: {subtraction}");
141   Console.WriteLine($"Value of multiplication: {multiplication}");
142   Console.WriteLine($"Value of division: {division}");
143   Console.WriteLine($"Value of modulo: {modulo}");
144
145   /* 
146                * arithmetic, compound expressions and order of operations 
147                * Multiplication and division are done first, left to right
148                * Addition and subtraction are done last, left to right
149                * Reference: https://csharpplayersguide.com/articles/operators-table
150                */
151
152   int arithmetic1; // declaring the variable arithmetic1.
153   arithmetic1 = 9 - 2; // assigning a value to arithmetic1, using some math.
154   Console.WriteLine($"Value of arithmetic1: {arithmetic1}");
155   arithmetic1 = 3 + 3; // another assignment.
156   Console.WriteLine($"New value of arithmetic1: {arithmetic1}");
157   int arithmetic2 = 3 + 1; // declaring arithmetic2 and assigning a value to arithmetic2 all at once.
Console.WriteLine($"Value of arithmetic2: {arithmetic2}");
arithmetic2 = 1 + 2; // assigning a second value to arithmetic2.
Console.WriteLine($"New value of arithmetic2: {arithmetic2}");

// use multiple sets of parentheses to group operations
int result = ((2 + 1) * 8 - (3 * 2) * 2) / 4;
Console.WriteLine($"Value of result: {result}");

/* compound assignment operator */
int compoundAssignmentOperator = 0;
compoundAssignmentOperator += 5; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator + 5; (a is 5 afterthis line runs.)
compoundAssignmentOperator -= 2; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator – 2; (a is 3 after this line runs.)
compoundAssignmentOperator *= 4; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator * 4; (a is 12 after this line runs.)
compoundAssignmentOperator /= 2; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator / 2; (a is 6 after this line runs.)
compoundAssignmentOperator %= 2; // The equivalent of compoundAssignmentOperator = compoundAssignmentOperator % 2; (a is 0 after this line runs.) 
/* increment and decrement operators */
int incrementDecrementOperators = 0;
incrementDecrementOperators++; // The equivalent of incrementDecrementOperators += 1; or incrementDecrementOperators = incrementDecrementOperators + 1;
incrementDecrementOperators--; // The equivalent of incrementDecrementOperators -= 1; or incrementDecrementOperators = incrementDecrementOperators - 1;
 
Console.WriteLine("**************************************************");
/* console 2.0 */
Console.Write("What is your name, human? "); // notice the space at the end.
string userName = Console.ReadLine(); // reads the entire line
// result: What is your name, human? jonathan
 
Console.WriteLine("Press any key when you're ready to begin.");
Console.ReadKey(); // reads a keystroke   
Console.BackgroundColor = ConsoleColor.Yellow; // changes the console background to yellow
Console.ForegroundColor = ConsoleColor.Black; // changes the console text to black
Console.Title = "Hello World!"; // changes the console title
   
Console.Beep(440, 1000); // computer beeps
}
}
}