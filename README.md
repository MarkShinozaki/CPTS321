# In-Class Activities

> [!NOTE]
> Below are the links to the in-person class assignments, at the end of the semester if you have completed all in-person/TDDs class assignments you will recieve credit for them, but this credit isn't worth very much. I have compiled a list of all the In-Class work you will have to complete that I could find, but there could be some I am missing. It is advised to attend all classes and periodically complete these assignments in class and then tag them. 

> [!WARNING]
> All These in-class Assignments are subject to change and may not be up-to-date, always refer to the current distributed material you are provided with.

---

### ***[w1.1 - Activity 1](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/InClassExercises/1.1%20Activity.png)***
### ***[w1.3 - Activity 2](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/tree/InClassExercises/1.3%20Activity)***

#### Assignment Description:
- You are tasked with creating a C# console application that demonstrates various programming concepts, including passing by reference and value, displaying messages, writing to files, and implementing basic data structures like linked lists. The main program should present a menu to the user with several options, allow the user to choose an action, and execute the corresponding code based on their selection.

#### Assignment Goals:
1. Menu and Program Flow:

  - The program should display a menu with the following options:
      - Show the pass-by-reference and pass-by-value scenario.
      - Display "Hello World" on the screen.
      - Write "Hello World" to a file.
      - Add two numbers in a linked list.
      - Quit the program.
        
- The user selects an option, and the program performs the corresponding task.

2. Demonstrate Concepts:

- Pass-by-Reference vs. Pass-by-Value: Implement an `Angle` as both a class and a structure to show how passing by reference differs from passing by value.
- Basic Message Class: Create a `BasicMessageClas`s with a `message` field, a `Message` property, and a `ShowMessage` method to display or write the message.
- Linked List Implementation: Implement a linked list that stores positive integers and provides methods for adding and manipulating the list.

#### Process to Complete the Assignment:
##### 1. Create the Solution and Project:

- Open Visual Studio or Rider.
- Create a new solution for all in-class exercises (e.g., "CptS321-in-class-exercises").
- Create a new project within this solution called HelloWorld. This will be a Console Application.

##### 2. Develop the Main Program (Program.cs):

- Write code to print the menu described above and allow the user to select an option.
- Based on the user's choice, call the appropriate method to demonstrate the selected feature.

##### 3. Implement the Angle Class and Structure:

- Create an `Angle` class and an `Angle` structure.
- Write code to demonstrate how classes (reference types) and structures (value types) are passed differently.

##### 4. Create the BasicMessageClass:

- Implement a `BasicMessageClass` with the following:
- A field `message`.
- A property `Message`.
- Two constructors: a default constructor and one with a parameter to initialize the message.
- A `ShowMessage` method that can either display the message on the console or write it to a file.

##### 5. Integrate BasicMessageClass into the Main Program:
- Create an instance of `BasicMessageClass` with the message "Hello World!".
- Implement the functionality to display the message on the console or write it to a file based on user input.

##### 6. Implement the Linked List:
- Create a `LinkedListNode` class with a constructor to initialize the node.
- Create a `LinkedList` class to manage the list.
- Implement an `Add` method to add numbers to the linked list.

##### 7. Test and Finalize the Program:
- Test each menu option to ensure it functions correctly.
- Ensure the program handles unexpected input gracefully and closes when the user selects the Quit option.

--- 

### ***[w3.2 - Activity 3](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/tree/InClassExercises/3.2%20Activity)***

#### Description of the Assignment:
- This assignment involves setting up a basic unit testing environment using NUnit in a C# project. The objective is to practice Test-Driven Development (TDD) by creating and testing a Math class with a simple Add method, then writing test cases for it. Additionally, you will implement a method called IsLeap in a Date class, following the principles of TDD.

#### Steps to Complete the Assignment:
##### 1. Part 1: Setting up NUnit Tests (Tasks 1-6)
- Create a New NUnit Test Project:
  - Open Visual Studio 2022 or JetBrains Rider (ensure you have NUnit installed).
  - Create a new NUnit Test Project named HelloWorldTests in the same solution as your HelloWorld project.

##### 2. Implement the Math Class:

- In your `HelloWorld` project, create a new class `Math` under the namespace `HelloWorld.Math`.
- Implement the `Add` method in the `Math` class:

```C#
public static int Add(int a, int b)
{
    return 0; // Placeholder implementation
}
```
##### 3. Create a Test File for the Math Class:
- In the `HelloWorldTests` project, create a new test file named `MathTest`.
- Define it under the namespace `HelloWorld.Math.Tests`.

##### 4. Add Reference to HelloWorld Project:

- Add the `HelloWorld` project as a reference to the` HelloWorldTests` project to allow testing of the Math class.

- This can be done by right-clicking on `Dependencies` in `HelloWorldTests`, selecting `Add Project Reference`, and adding `HelloWorld`.

##### 5. Create a Test Method for `Add`:
- Implement a test method named `TestAdd` in `MathTest` using NUnit.
- Write assertion statements to test various cases for the `Add` method (e.g., adding positive numbers, negative numbers, and zero).

##### 6. Run the Tests:
- Execute the tests using the built-in test runner.
- Since the `Add` method currently returns `0`, all or most of the tests should fail, confirming that the test cases are working.

#### Part 2: Implementing `IsLeap` Method in the `Date` Class

1. Practice TDD to Implement `IsLeap`:
- Implement a method IsLeap in the Date class to determine if a given year is a leap year.
- Recall the rules:
  - A year divisible by 4 is a leap year.
  - A year not divisible by 4 is a common year.
  - A century year not divisible by 400 is a common year.
  - A century year divisible by 400 is a leap year.

2. Follow the TDD Process:
- Write unit tests for `IsLeap` before implementing the method.
- Start with a failing test and iteratively add code to the method until all tests pass.

3. Tag the Last Commit:
- Once completed, tag the last commit for this in-class exercise to potentially earn bonus points.

#### Summary:
- By completing this assignment, you will have practiced both setting up and running NUnit tests and using TDD to implement a method. This exercise will strengthen your understanding of unit testing and how it integrates into the development process.

--- 


### ***[w4.3 - Activity 4](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/InClassExercises/4.3%20Activity%20.png)***

#### Description of the Assignment:
- In this assignment, you are required to create a new C# project named HelloWorldFileStream within the existing in-class exercise solution. The goal is to develop a console application that interacts with the user to create and write to a text file. The program will prompt the user to provide a file name and the content that should be written to that file. The program should handle errors gracefully, allowing the user to restart the process if something goes wrong.

#### Steps to Complete the Assignment:

##### 1. Create the Project:
- Open Visual Studio or JetBrains Rider.
- In the existing solution for your in-class exercises, create a new Console Application project named `HelloWorldFileStream`.

##### 2. Main Program Structure:

- In the `Program.cs` file, implement the main flow of the program:
  - Prompt the user to enter a file name.
  - Attempt to create a text file with the provided name using `FileStream` or `StreamWriter`.
  - Prompt the user to enter the content they want to write to the file.
  - Write the user's input to the file.

##### 3. Error Handling and Restart Option:

- Implement error handling to catch any issues that might occur during file creation or writing (e.g., invalid file names, access issues).
- If an error occurs, inform the user and give them the option to restart the process from the beginning.

##### 4. Design for Change:
- Structure your code in a way that makes it easy to modify and extend in the future. For example:
  - Use methods to separate the different tasks (e.g., getting input, writing to the file, handling errors).
  - Consider how you might add features, such as allowing the user to append to an existing file or choose different file types, in future iterations.

#### Example Pseudocode:
```
static void Main(string[] args)
{
    while (true)
    {
        try
        {
            // Step 1: Prompt for the file name
            Console.WriteLine("Enter the file name:");
            string fileName = Console.ReadLine();

            // Step 2: Prompt for the text to write
            Console.WriteLine("Enter the text to write into the file:");
            string text = Console.ReadLine();

            // Step 3: Write text to the file
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.WriteLine(text);
            }

            Console.WriteLine("File written successfully!");

            break; // Exit loop if successful
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            Console.WriteLine("Would you like to try again? (y/n)");
            if (Console.ReadLine().ToLower() != "y")
            {
                break;
            }
        }
    }
}
```
#### Summary:
This assignment helps you practice file I/O operations in C# and encourages you to think about robust error handling and the principles of software design, such as designing for change. By following the steps outlined above, you will complete the task while ensuring the program is user-friendly and resilient to errors

























---


***[w.5.1.1 - Activity 5](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/InClassExercises/5.1.1%20Activity%20.png)***

***[w5.1.2 - Activity 6](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/InClassExercises/5.1.2%20Activity.png)***

***[w.7.2 - Activity 7](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/tree/InClassExercises/7.2%20Unit%20Testing%20Activity)***

***[w7.3 - Activity 8](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/InClassExercises/7.3%20Activity.png)***

***[w13.3 - Activity 9](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/tree/InClassExercises/13.3%20Activity)***

***[w14.3 - Activity 10](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/InClassExercises/14.3%20Activity%20.png)***













