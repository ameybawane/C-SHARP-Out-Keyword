# C-SHARP-Out-Keyword

The out is a keyword in C# which is used for the passing the arguments to methods as a reference type. It is generally used when a method returns multiple values.

Important Points:
•	It is similar to ref keyword. But the main difference between ref and out keyword is that ref needs that the variable must be initialized before it passed to the method. But out parameter doesn’t require the variables to be initialized before it passed to the method. But before it returns a value to the calling method, the variable must be initialized in the called method.
•	It is also similar to the in keyword but the in keyword does not allow the method that called to change the argument value but ref allows.
•	For using out keyword as a parameter both the method definition and calling method must use the out keyword explicitly.
•	The out parameters are not allowed to use in asynchronous methods.
•	The out parameters are not allowed to use in iterator methods.
•	There can be more than one out parameter in a method.
•	At the time of method call, out parameter can be declared inline. But the inline out parameters can be accessed in the same block of code where it calls.
•	Method overloading can also be done using out parameters.
•	Properties cannot be passed as out parameters as these are not variables.
•	Up to C# 6.0, a user first declares the variable then it can only pass as an out argument. But from C# 7.0, excepting a separate variable declaration, the user can also declare the out variable in the argument list of the method call.

# Declaration of out Parameter:  
// No need to initialize 
// the variable here
data_type variable_name;

Method_Name(out variable_name);

// you can also convert both above two 
// lines of codes as follows from
//  C# 7.0 onwards
Method_Name(out data_type variable_name);

Here the value of variable_name must be initialized in the called method before it returns a value. 

Ex.
// C# program to illustrate the
// concept of out parameter
using System;
 
class Geek {
 
    // Main method
    static public void Main()
    {
 
        // Declaring variable
        // without assigning value
        int i;
 
        // Pass variable i to the method
        // using out keyword
        Addition(out i);
 
        // Display the value i
        Console.WriteLine("The addition of the value is: {0}", i);
    }
 
    // Method in which out parameter is passed
    // and this method returns the value of
    // the passed parameter
    public static void Addition(out int i)
    {
        i = 30;
        i += i;
    }
}
 O/P : The addition of the value is: 60

# Multiple out Parameters: 
In C#, a user is allowed to pass multiple out parameters to the method and the method returns multiple values. 

Example: In the below code, we declared two value variables without initializing i.e int i, j;. Now we pass these parameters to the Addition method using out keyword like Addition(out i, out j);. The value of these variables is assigned in the method in which they passed. 

// C# program to illustrate the
// concept of multiple out parameter
using System;
 
class Geek {
 
    // Main method
    static public void Main()
    {
 
        // Declaring variables
        // without assigning values
        int i, j;
 
        // Pass multiple variable to
        // the method using out keyword
        Addition(out i, out j);
 
        // Display the value i and j
        Console.WriteLine("The addition of the value is: {0}", i);
        Console.WriteLine("The addition of the value is: {0}", j);
    }
 
    // Method in which out parameters
    // are passed and this method returns
    // the values of the passed parameters
    public static void Addition(out int p, out int q)
    {
        p = 30;
        q = 40;
        p += p;
        q += q;
    }
}
Output: 
The addition of the value is: 60
The addition of the value is: 80
 
# Enhancement of Out Parameter in C# 7.0 : 
In C# 7.0, there are some new features added to the out parameter and the features are: 
•	In C# 7.0, the out parameter can pass without its declaration and initialization which is termed as the In-line declaration of Out parameter or Implicit Type Out Parameter. Its scope is limited to the method body i.e. local scope.
•	The out parameter is allowed to use var type in the method parameter list.
•	In out parameter, it is not compulsory that the name of the out parameter is same in both definition and call.
•	It can also be used in Try Pattern.
Example: Below programs demonstrate the inline declaration of Out parameter. Here the line of code i.e Area(out int length, out int width, out int Rarea); contains the inline declaration of Out parameter as these variables are directly declared inside the method calling. The value of the variables is initialized in the method in which they passed.
Note: You need to require C# 7.0 version to run this example.
Example:  
•	C#
// C# program to illustrate the
// concept of out parameter
using System;
 
class Geek
{
 
    // Main method
    static public void Main()
    {
 
        // In-line declaring variables
        // without assigning values
        // Passing multiple variable to
        // the method using out keyword
        Area(out int length, out int width, out int Rarea);
 
        // Display the value length, width, and Rarea
        System.Console.WriteLine("Length of the rectangle is: "+ length);
        System.Console.WriteLine("Width of the rectangle is: "+ width);
        System.Console.WriteLine("Area of the rectangle is: "+ Rarea);
        Console.ReadLine();
    }
 
    // Method in which out parameters are passed
    // and this method returns the values of
    // the passed parameters
    public static void Area(out int p, out int q, out int Rarea)
    {
        p = 30;
        q = 40;
        Rarea = p * q;
    }
}
Output: 
Length of the rectangle is  : 30
Width of the rectangle is : 40
Area of the rectangle is : 1200

