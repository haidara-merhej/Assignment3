/*
-----------------------------------------------------------------------
                        Project Structure
-----------------------------------------------------------------------


| 1 |  Project Files and Directories:


1. .csproj: defines the project's configuration, dependencies, 
    including the target framework, build properties and package references.

2. program.cs: contains the application's entry point and main logic that runs when the application starts.

3. obj/: a directory that stores intermediate files generated during the build process.

4. bin/: a directory that contains the build outputs, including the compliled application assemblies 
    and related files.



| 2 |  File-Scoped Namespace: reduces indentation by eliminating the need for an enclosing block {}.


| 3 |  Solution Format (sln vs slnx): The .slnx formate uses XML, providing a simpler and more readable
structure than the .sln format.

*/

namespace  CSharpBasicsAssignment;

internal class Program
{
    public static void Main(string[] args)
    {
        /*
        --------------------------------------------------
                PartB - Types & Conventions
        --------------------------------------------------
        */
        RunTypesDemo();


        /*
        --------------------------------------------------
            PartC - Value Types vs Reference Types
        --------------------------------------------------
        */
        RunValueVsReferenceDemo();

        /*
        --------------------------------------------------
            PartD - Scope and Operators
        --------------------------------------------------
        */
        RunScopeAndOperatorDemo();
    }

    static void RunTypesDemo()
    {
        int age = 26;
        long distance = 90000L;
        double avgScore = 13.2d;
        decimal price = 44.21m;
        bool isActive = false;
        char grade = 'A';
        string name = "Ahmed";
        var password  = "1234";

        Console.WriteLine("PartB - Types & Conventions:\n");

        Console.WriteLine($"Age type         : {age.GetType()}");
        Console.WriteLine($"Distance type    : {distance.GetType()}");
        Console.WriteLine($"Averag Score type: {avgScore.GetType()}");
        Console.WriteLine($"Price type       : {price.GetType()}");
        Console.WriteLine($"Is Active type   : {isActive.GetType()}");
        Console.WriteLine($"Grade type       : {grade.GetType()}");
        Console.WriteLine($"Name type        : {name.GetType()}");
        Console.WriteLine($"Password type    : {password.GetType()}");

        Console.WriteLine("\nImplicit Conversion:");
        //Implicit Conversion
        int number = 1000;
        long number2 = number;
        Console.WriteLine($"int: {number} -> long: {number2}");
        char ch = 'H';
        int integer = ch;
        Console.WriteLine($"char: {ch} -> int: {integer}");

        //Explicit Conversion
        double value = 10.6d;

        int a = (int)value;
        int b = Convert.ToInt32(value);
        Console.WriteLine("\nExplicit Conversion:");
        Console.WriteLine("(int)            : " + a);
        Console.WriteLine("Convert.ToInt32(): " + b);
        //(int) trancates the decimal part,
        //while Convert.ToInt32() rounds to the nearest integer.

        //Integer Division vs Floating-Point Division:
        Console.WriteLine("\nInteger Division vs Floating-Point Division:");
        Console.WriteLine($"\n5 / 2 : {5 / 2}"); 
        Console.WriteLine($"5.0 / 2: {5.0 / 2}");
        // Integer division discards the fractional part,
        // while floating-point division preserves it.

        //Boxing & UnBoxing
        int n = 100;
        object ob = n;
        int unboxed = (int)ob;

        Console.WriteLine("\nBoxing and UnBoxing:");
        Console.WriteLine($"Boxed: {ob}");
        Console.WriteLine($"Unboxed: {unboxed}");


        //Parsing: int.Parse() vs int.TryParse()
        Console.WriteLine("\nParsing: int.Parse() vs int.TryParse()");
        int num = int.Parse("14");
        Console.WriteLine("number: " + num);

        bool isParsed = int.TryParse("ab", out int result);
        Console.WriteLine($"Is parsed: {isParsed}, number: {result}");
        //int.Parse() throws a format exception if conversion fails,
        //while int.TryParse() returns false and a default value without throwing an exception

        //Conversion float to decimal
        float f = 10.5f;
        decimal d = (decimal)f;

        Console.WriteLine("\nConvert Float to Decimal:");
        Console.WriteLine($"float value  : {f}");
        Console.WriteLine($"decimal value: {d}");
        //An explicit cast is required to convert float to decimal
    }
    
    static void RunValueVsReferenceDemo()
    {
        Console.WriteLine("\nPartC - Value Types vs Reference Types:");
        Point p1 = new Point{ X = 10, Y = 20};
        Point p2 = p1;

        p2.X = 99;
        Console.WriteLine("\nValue Types:");
        Console.WriteLine($"p1.X = {p1.X}");
        Console.WriteLine($"p2.X = {p2.X}");
        //Point is a value type, so assigning p1 ro p2 copies its data.
        //Changing p2 does not affect p1 because each variable has its own copy.

        Order order1 = new Order
        {
            Id = 1,
            CustomerName = "John Doe",
            Quantity = 5,
            UnitPrice = 10.5m,
            TotalPrice = 52.5m,
            IsPaid = false,
            DiscountPercent = 10.0,
            ShippingCity = "New York",
            Priority = 'H',
            ItemCode = 1234567890L
        };

        Console.WriteLine("\nReference Types:");
        Console.WriteLine($"Order1 Total Price: {order1.CalculateTotalPrice()}");

        Order order2 = order1;
        order2.IsPaid = true;
        Console.WriteLine($"Is Paid Order1: {order1.IsPaid}");
        Console.WriteLine($"Is Paid Order2: {order2.IsPaid}");
        //Order is a reference type, so assigning o1 to o2 copies the reference.
        //Both variables refer to the same object in memory
        //Changes made through o2 are visible through o1


        object boxedOrder = order1;

        Console.WriteLine(object.ReferenceEquals(boxedOrder, order1));

        Order order3 = (Order)boxedOrder;
        Console.WriteLine(object.ReferenceEquals(order1, order3));

        order1.PrintSummary();

        //Value types store their data directly,
        // and assigning one value type variable to another copies its data.

        //Reference types store references to objects,
        //  and assigning one reference variable to another copies the reference,
        //  so both variables can refer to the same object in memory

    }


   private static int field = 1000; // Field-Scope variable
    static void RunScopeAndOperatorDemo()
    {
        Console.WriteLine("\nPartD - Scope and Operators:");

        Console.WriteLine("\nBlock-Scoped Variable:");
        for(int i = 0; i < 3; i++)
        {
            int loopVariable = i * 10; // Block-Scoped variable
            Console.WriteLine($"Loop Variable: {loopVariable}");
        }
        
        // Console.WriteLine($"Loop Variable: {loopVariable}");
        // loopvariable is not accessible outside the for loop block, as it is block-scoped.

        Console.WriteLine("\nField-Scoped Variable:");
        Method1();
        Method2();  

        Console.WriteLine($"Method: {field}");
        // Method1 and Method2 can access the field-scope variable 'field'
        

        Console.WriteLine("\nMethod-Scoped Variable:");
        Method3(); 
        //Console.WriteLine($"Local Variable: {local}");
        // local is not accessible outside Method3, as it is method-scoped.




        // D2 - Comound Assignment Operators

        Console.WriteLine("\nCompound Assignment Operators:");
        int total = 100;
        
        total += 10; // total = total + 10
        Console.WriteLine($"\nAfter +=: {total}");

        total -= 5; // total = total - 5
        Console.WriteLine($"After -=: {total}");

        total *= 2; // total = total * 2
        Console.WriteLine($"After *=: {total}");    

        total /= 3; // total = total / 3
        Console.WriteLine($"After /=: {total}");


        // D3 - Bitwise Operators
        int a = 12;
        int b = 10;

        Console.WriteLine("\nBitwise Operators:");
        Console.WriteLine($"a & b: {a & b}"); // Bitwise AND
        Console.WriteLine($"a | b: {a | b}"); // Bitwise OR
        Console.WriteLine($"a ^ b: {a ^ b}"); // Bitwise XOR

        //The & operator performs bitwwise AND on integers, returning a new integer 
        // with bits set to 1 only where both operands have bits set to 1.

        //The && operator is a logical AND operator that evaluates boolean expressions 
        // and returns true only if both operands are true.
    }
    static void Method1()
    {
        Console.WriteLine($"Method One: {field}");
    }
    static void Method2()
    {
        Console.WriteLine($"Method Two: {field}");
    }
    static void Method3()
    {
        int local = 500; // Method-Scope variable
        Console.WriteLine($"Local Variable: {local}");
    }

}
