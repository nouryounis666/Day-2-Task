using System;

namespace day02task
{
    class Program
    {
        static void Main()
        {
            #region Problem 1
            //// an integer variable 'x' and its value is 10
            //int x = 10;

            //// an integer variable 'y' and its value is 20
            //int y = 20;

            ///* calculate the sum of 'x' and 'y' 
            //   and store the result in the variable 'sum' */
            //int sum = x + y;

            //// display the result of the sum of 'x' and 'y' 
            //Console.WriteLine(sum);

            ///* Question: What is the shortcut to comment and uncomment a selected block of code in Visual Studio?
            //   Shortcut:
            //        Comment: Ctrl + K, Ctrl + C
            //        Uncomment: Ctrl + K, Ctrl + U
            //*/
            #endregion


            #region Problem 2
            //// 10 is integer so i fixed it by changing its data type from string to integer
            //int x = 10;

            //// add variable 'y'
            //int y = 90;

            //// Correct 'console' to 'Console'
            //Console.WriteLine(x + y);

            ///* Question: Explain the difference between a runtime error and a logical error with examples.
            //    Runtime Error: Occurs during program execution, causing it to crash.
            //    Example: Dividing by zero.
            //    Logical Error: The program runs without crashing but produces incorrect results.
            //    Example: Using subtraction instead of addition in a calculation.
            //*/
            #endregion


            #region Problem 3
            //string FullName = "Nour Tamer";
            //int Age = 18;
            //decimal MonthlySalary = 5500.00m;
            //bool IfStudent = true;

            ///* Question: Why is it important to follow naming conventions such as PascalCase in C#? 
            //   Naming conventions improve code readability and maintainability.
            //   PascalCase is commonly used for class names and public methods,
            //   making it easier to distinguish them from local variables and private members.
            // */ 
            #endregion



            #region Problem 4
            //Person person1 = new Person { Name = "Younis" };
            //Person person2 = person1; person2.Name = "Nour";
            //Console.WriteLine(person1.Name); // Output: Nour

            ///* Question: Explain the difference between value types and reference types in terms of memory allocation. 
            //   Value Types: Stored on the stack. Each variable has its own copy of data.
            //   Example: int, float, char.
            //   Reference Types: Stored on the heap. Variables hold references to memory locations.
            //   Example: class, string, object.
            //*/
            #endregion



            #region Problem 5
            //int x = 15;
            //int y = 4;
            ////sum
            //int sum = x + y;
            //// difference
            //int difference = x - y;
            ////product
            //int product = x * y;
            ////division result
            //double divisionResult = (double)x / y; //  double for accurate division
            //// Remainder
            //int remainder = x % y;

            //Console.WriteLine($"Sum: {sum}, Difference: {difference}, Product: {product}, Division: {divisionResult}, Remainder: {remainder}");

            ///* Question: What will be the output of the following code? Explain why: 
            //        int a = 2, b = 7; 
            //        Console.WriteLine(a % b);
            //   The output is 2.
            //   Explanation: The modulus operator % returns the remainder of the division of a by b. Since 2 divided by 7 is 0 with a remainder of 2 .
            //*/
            #endregion


            #region Problem 6
            //int number = 16;

            //if (number > 10 && number % 2 == 0)
            //    Console.WriteLine("The number is greater than 10 and even.");
            //else
            //    Console.WriteLine("The number is not greater than 10 and not even.");

            ///* Question: How does the && (logical AND) operator differ from the & (bitwise AND) operator?
            //   && (Logical AND): Stops evaluation if the first condition is false (short-circuiting).
            //   & (Bitwise AND): Always evaluates both conditions. Operates on bits if used with integers.
            //*/ 
            #endregion


            #region Problem 7
            //Console.Write("Enter a double value: ");
            //string doubleInput = Console.ReadLine();
            //try
            //{
            //    double inputDouble = double.Parse(doubleInput);
            //    int implicitCast = (int)inputDouble;
            //    int explicitCast = Convert.ToInt32(inputDouble);

            //    Console.WriteLine($"Implicit Cast: {implicitCast}, Explicit Cast: {explicitCast}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid double number.");
            //}

            ///* Question: Why is explicit casting required when converting a double to an int?
            //   Explicit casting is required when converting from a larger type (like double) to a smaller type (like int) to prevent data loss.
            //*/ 
            #endregion


            #region Problem 8 
            //Console.Write("Enter your age: ");
            //string input = Console.ReadLine();
            //try
            //{
            //    int age = int.Parse(input);
            //    if (age > 0)
            //    {
            //        Console.WriteLine("Valid age.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Age must be greater than 0.");
            //    }
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Invalid input. Please enter a number.");
            //}

            ///* Question: What exception might occur if the input is invalid and how can you handle it
            //   Exception: FormatException if the input is not a valid number.
            //   Handling: Use a try-catch block to manage invalid inputs.
            // */
            #endregion



            #region Problem 9
            //int X = 5;
            //// PreFix [Increment and then use it (Print)]
            //Console.WriteLine(++X);//6  X=6
            //// PostFix [use it (Print) and then Increment]
            //Console.WriteLine(X++);//6  X=7

            ///* Question: Given the code below, what is the value of x after execution? Explain why 
            //        int x = 5; 
            //        int y = ++x + x++; 
            //    Value of x = 7
            //    Explanation:
            //    ++x increments x to 6 before adding.
            //    x++ uses x = 6 for addition and then increments to 7.
            //    Result: y = 6 + 6 = 12, x = 7.
            //*/ 
            #endregion


        }


    }
    class Person 
    { 
        public string Name { get; set; } 
    }

}


