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
```C#
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
- This assignment helps you practice file I/O operations in C# and encourages you to think about robust error handling and the principles of software design, such as designing for change. By following the steps outlined above, you will complete the task while ensuring the program is user-friendly and resilient to errors

---

### ***[w.5.1.1 - Activity 5](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/InClassExercises/5.1.1%20Activity%20.png)***

### ***[w5.1.2 - Activity 6](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/InClassExercises/5.1.2%20Activity.png)***

#### Description of the Assignment:
- This assignment is divided into two parts, each focusing on different C# programming concepts.

##### 1. Transform Code into a Reusable Class Library:

- You will take code from a previous exercise and refactor it into a reusable class library named StreamUtil.
- After creating the class library, you will create a new project named DLLwithStreamsDemo that will use this library.
- The primary goal is to understand how to package and reuse code across different projects by adding references to .dll files.

##### 2. Property Changed Events Demo:

- You will create a GUI-based C# application named `PropertyChangedEventsDemo` that demonstrates the use of property change notifications.
- The task includes creating a simple GUI, defining a Person class, and setting up fields and properties that the GUI will eventually interact with.

#### Steps to Complete the Assignment:

#### Part 1: Creating a Reusable Class Library

##### 1. Create the Class Library Project:
- Open Visual Studio.
- Create a new Class Library project within your solution and name it `StreamUtil`.
- Move the code that you want to make reusable into this library. This will typically involve extracting common functionality that could be used across multiple projects.

##### 2. Create the Demo Project:

- In the same solution, create a new Console Application project named `DLLwithStreamsDemo`.
- This project will demonstrate how to use the StreamUtil library.

##### 3. Add the DLL Reference:

- Build the `StreamUtil` project to generate the .dll file.
- In the `DLLwithStreamsDemo` project, add a reference to the `StreamUtil.dll` file by browsing to its location.
- You can also add the reference directly to the project using Visual Studio’s project reference options.

##### 4. Write Code to Demonstrate the Library:

- In the `DLLwithStreamsDemo` project, write code that utilizes the functionality provided by the `StreamUtil` library.
- Run the project to ensure that everything works as expected.

#### Part 2: Property Changed Events Demo

##### 1. Create the Project:

- In the same solution, create a new WPF or WinForms project named `PropertyChangedEventsDemo`.

##### 2. Build the GUI:

- Design a GUI that matches the example provided in the image.
- Include text boxes or labels for `First Name` and `Last Name`, along with buttons to change the values.

##### 3. Create the Person Class:
- Define a Person class with the following:
  - Private fields:  `firstName` and `lastName`.
  - Public properties: `FirstName` and `LastName` that encapsulate these fields.

##### 4. Link the GUI (Future Task):
- Although not required immediately, the GUI will eventually need to interact with the Person class using property change notifications.

#### Summary:
- By completing these tasks, you will gain experience in modular programming, code reuse through class libraries, and GUI development with property change events. The first part emphasizes the importance of separating functionality into reusable components, while the second part introduces property change notifications, which are fundamental for reactive UI designs in C#.

---


### ***[w.7.2 - Activity 7](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/tree/InClassExercises/7.2%20Unit%20Testing%20Activity)***

#### Description of the Assignment:
- This assignment is focused on testing non-public (internal and private) methods in a C# project using NUnit. The tasks involve creating a class with an internal method, setting up a unit test project, and writing test cases for the internal method. Additionally, you will explore how to access and test private methods using reflection.

#### Steps to Complete the Assignment:

#### Part 1: Testing Internal Methods

##### 1. Create the Class with an Internal Method:
- In your `HelloWorld` project, create a new class named `ClassToDemoTestingNonPublic`.
- Define an internal static method `tripleThis` in this class. The method should take an integer as input and return its value tripled.

```C#
internal static int tripleThis(int aNumber)
{
    return aNumber * 3;
}
```

##### 2. Set Up the NUnit Test Project:

- If you haven't already, create a new NUnit test project named `HelloWorldTests` within the same solution as your `HelloWorld` project.
- Ensure that `HelloWorldTests` has access to the `HelloWorld` project's internal entities by modifying the `AssemblyInfo.cs` file in the `HelloWorld` project:

```C#
[assembly: InternalsVisibleTo("HelloWorldTests")]
```

##### 3. Write Test Cases for the Internal Method:

- In the `HelloWorldTests` project, write test cases to verify the behavior of the `tripleThis` method.
- Consider different scenarios, such as positive numbers, zero, and negative numbers, when writing your test cases.
- Example test cases:

```C#
[Test]
public void TripleThis_ShouldReturnTripleValue()
{
    Assert.AreEqual(9, ClassToDemoTestingNonPublic.tripleThis(3));
    Assert.AreEqual(0, ClassToDemoTestingNonPublic.tripleThis(0));
    Assert.AreEqual(-15, ClassToDemoTestingNonPublic.tripleThis(-5));
}
```

##### 4. Determine Test Case Types and Number:

- Consider edge cases such as:
  - Large numbers (positive and negative).
  - Special cases like `int.MaxValue` and `int.MinValue`.
- You might need around 5 to 7 test cases to cover various scenarios comprehensively.

#### Part 2: Testing Private Methods Using Reflection

##### 1. Access Private Methods via Reflection:
- Create a test class in `HelloWorldTests` to demonstrate how to access and test private methods using reflection.
- Use the `GetMethod` method along with appropriate `BindingFlags` to retrieve the private method, and use `MethodBase.Invoke` to execute it.

- Example code structure:

```C#
[TestFixture]
public class ClassToDemoTestingNonPublicTest
{
    private MethodInfo GetMethod(string methodName)
    {
        var type = typeof(ClassToDemoTestingNonPublic);
        return type.GetMethod(methodName, BindingFlags.NonPublic | BindingFlags.Static);
    }

    [Test]
    public void TestPrivateMethod()
    {
        var methodInfo = GetMethod("privateInstanceMethod");
        var result = methodInfo.Invoke(null, new object[] { 5 });
        Assert.AreEqual(15, result); // Assuming the private method multiplies by 3
    }
}
```

#### Summary:
- This assignment will give you hands-on experience with testing non-public methods in a C# application using NUnit. You'll learn how to structure your code for testability, how to modify access levels for testing purposes, and how to leverage reflection to test private methods that would otherwise be inaccessible.

---

### ***[w7.3 - Activity 8](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/InClassExercises/7.3%20Activity.png)***

#### Description of the Assignment:
- This assignment revolves around the design and analysis of a Monopoly game system. The focus is on understanding object-oriented design principles and applying them to decide the responsibilities of different objects and classes within the Monopoly game. You are required to answer conceptual questions that pertain to the creation, management, and control of various components within the game, such as the Square object, the game controller, and the dice.

#### Steps to Complete the Assignment:

##### 1. Analyze the Questions:

- The assignment provides five questions that need to be answered, each focusing on different aspects of the Monopoly game system design.
- The questions prompt you to think about responsibility allocation, object creation, and control flow in the context of a domain-driven design approach.

##### 2. Provide Detailed Answers:

- For each question, provide a detailed response that reflects your understanding of object-oriented design principles. Consider concepts like Single Responsibility Principle (SRP), Dependency Inversion, and Separation of Concerns when formulating your answers.

#### Answering the Questions:

##### 1. Who should create the `Square` object?

- The `Square` objects could be created by a `Board` class or a SquareFactory. The `Board` class might handle the arrangement of `Square` objects on the game board, so it would make sense for it to also manage their creation. Alternatively, a dedicated factory class could be responsible for creating `Square` objects, especially if there are different types of squares (e.g., Property, Chance, Jail).

##### 2. Who knows about a `Square` object, given a key?

- The `Board` class or a `SquareRepository` could be responsible for mapping a key (such as an index or name) to a specific `Square` object. The `Board` class likely maintains a collection of all `Square` objects, so it can provide access to any specific square when given a key.

##### 3. Who is the Controller for the `playGame` system operation?

- The `GameController` class would likely be the controller for the `playGame` system operation. This class would coordinate the overall game flow, handle player turns, and enforce the rules of the game. It interacts with other classes such as `Player`, `Board`, and `Dice`.

##### 4. How should the controller interact with the rest of the classes in the domain layer?

- The `GameController` should use dependency injection to interact with other classes like `Board`, `Player`, and `Dice`. It should delegate responsibilities to these classes, ensuring that each class manages its own data and operations (e.g., Board handles square positions, `Player` handles player states). The controller should orchestrate actions without directly managing the internal workings of these objects.

##### 5. Who should be responsible for handling the dice (rolling and summing the dice totals)?

- A `Dice` class should handle rolling and summing the dice totals. This class encapsulates the logic for generating random dice rolls and calculating the total, ensuring that this responsibility is isolated from other parts of the system. The `GameController` would call this class to obtain dice results during a player’s turn.

#### Summary:
- This assignment requires you to think critically about object-oriented design, particularly in the context of a game system. By answering the provided questions, you will develop a clearer understanding of how to assign responsibilities within a system, how objects interact, and how to maintain a clean and modular architecture.

---

### ***[w13.3 - Activity 9](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/tree/InClassExercises/13.3%20Activity)***

#### Description of the Assignment:
- In this assignment, you will create a WinForms application that demonstrates how to perform tasks on the main thread versus a new thread. The application includes two buttons: one to perform a long task on the same thread and another to perform the task on a new thread with a progress bar that tracks its progress. This assignment will help you understand threading in Windows Forms applications and how to update the UI safely from different threads.

#### Steps to Complete the Assignment:

##### 1. Create the User Interface:

- Design a WinForm interface with two buttons:
  - Button 1: "Do long task on same thread"
  - Button 2: "Do long task on new thread with progress bar"
- Add a `ProgressBar` control that will be visible only when the new thread is running.

##### 2. Implement the `ThreadCompleted()` Method:
- This method will reinitialize the UI after the task completes. Specifically, it should:
  - Enable both buttons.
  - Hide the `ProgressBar`.

##### 3. Implement the `DoTask(TimeSpan howLong)` Method:

- This method simulates a long-running task. It should:
  - Wait for the duration specified by `howLong`.
  - Notify the UI thread that the task is complete using the ThreadCompleted() method.
  - Pass the ThreadCompleted method as a callback to ensure the UI is updated correctly after the task finishes.

##### 4. Create the `btnTaskOnUIThread_Click` Event Handler:

- This event handler will execute the long task on the UI thread. It should:
  - Disable both buttons to prevent additional clicks.
  - Make the `ProgressBar` visible (if used for the new thread task).
  - Call the `DoTask` method with a 10-second duration.

##### 5. Create the `btnTaskOnNewThread_Click` Event Handler:

- This event handler will execute the long task on a new thread. It should:
  - Disable both buttons.
  - Make the ProgressBar visible.
  - Create and start a new thread that runs the DoTask method with a 10-second duration.

#### Summary:
- This assignment teaches you how to manage long-running tasks in a WinForms application without freezing the UI. You will learn about the importance of using separate threads for resource-intensive operations and how to synchronize the UI updates with the main thread safely. The final application will clearly demonstrate the difference between performing a task on the UI thread versus a background thread, with the help of a progress bar.


---

### ***[w14.3 - Activity 10](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/InClassExercises/14.3%20Activity%20.png)***


#### Description of the Assignment:
- In this assignment, you are tasked with identifying and applying code refactoring techniques to improve the quality of an ExpressionTree coding demo. Refactoring is the process of restructuring existing code without changing its external behavior to enhance readability, reduce complexity, or improve performance. The assignment will guide you through reviewing refactoring techniques, applying them to a specific file, and documenting the changes.

#### Steps to Complete the Assignment:
##### 1. Review Refactoring Techniques:
- Browse through the list of refactorings defined by Martin Fowler in his book Refactoring: Improving the Design of Existing Code.

- Also, review the refactoring techniques supported by your Integrated Development Environment (IDE). Most modern IDEs, like Visual Studio, offer built-in refactoring tools.

##### 2. Analyze the Expression File:

- Open the `Expression` file from the `ExpressionTree` coding demo.
- Identify areas in the code where refactoring could improve its structure, maintainability, or efficiency. This could include applying techniques like Extract Method, Rename Variable, Simplify Conditional Expressions, Replace Magic Number with Symbolic Constant, and more.
- Consider both refactorings you have already applied during previous work on this file and any new refactorings that you identify now.

##### 3. Document the Refactorings:

- As you apply refactorings, document them in the following format:

```C#
<Refactoring name>(<defined by>);<Old/New>: Details.
```

- For Example:
  
```C#
Extract Method (Fowler); Old: Long method with multiple responsibilities. New: Separated the code into distinct methods for better readability.
```
##### 4. Identify and List Additional Refactorings:

- Once you have completed the refactorings, go through the refactored code again to identify any further improvements that can be made.
- List these additional refactorings using the same format as above.

#### Summary:
- This assignment helps you practice critical analysis and refactoring of code, a crucial skill in software development. By the end of this activity, you should have a cleaner, more maintainable version of the `ExpressionTree` code, along with a documented list of improvements made. This will not only improve your understanding of refactoring techniques but also contribute to your ability to maintain and improve codebases in future projects.





