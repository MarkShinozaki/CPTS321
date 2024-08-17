# Homeworks 

## [Homework 0](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/tree/Homeworks/CPTS321-SoftwareEngineeringPrinciples-Homework-0)

### Homework 0: Overview
#### Repository Setup and Management

#### Details of the Tasks:
##### 1. Repository Creation:

- Create two separate GitLab repositories on the EECS server:
  - `CptS321-HWs`: This will be used for all homework assignments.
  - `CptS321-in-class-exercises`: This will be used for all in-class exercises.
- Create an empty (blank) solution in both repositories using Visual Studio (for Windows and WinForms) or Rider (for cross-platform development).

##### 2. Repository Configuration:

- Set both repositories to private.
- Add the instructor and all TAs as "Maintainers" to both repositories (use EECS GitLab IDs; email invites will not work).
- Add a `README` file to both repositories that includes your full name and WSU ID.
- Set up `.gitignore` in both repositories.

##### 3. Tagging and Submission:

- Tag the versions of the repositories you want to be graded with the tag `HW0`.
- Submit the links to these repositories (either the tag or branch links) via Canvas by the HW deadline.
- Additionally, submit the links to the main branches of both repositories in the survey for Week 2, by Thursday of Week 2.



--- 

## [Homework 1](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/tree/Homeworks/CPTS321-SoftwareEngineeringPrinciples-Homework-1)

### Homework 1: Overview
#### Binary Search Tree (BST) Number List in Console/Terminal

#### Topics Covered:
- Basic data structures (Binary Search Tree)
- Command-line input and output
- Implementation of custom algorithms

#### Details of the Tasks:
##### 1. Input Handling:

- Create a C# console application that reads a single line of integers separated by spaces. All integers will be in the range [0, 100].

##### 2. Binary Search Tree Implementation:

- Implement your own Binary Search Tree (BST) to store the integers in the order they are entered.
- Ensure that no duplicates are added to the tree.

##### 3. Sorted Output:

- Traverse the BST in order and display the numbers in sorted order (smallest to largest).

##### 4. Statistics Display:

- Display the following statistics about the BST:
  - Total number of items.
  - Number of levels in the tree.
  - Theoretical minimum number of levels based on the number of nodes.

##### 5. Repository Management and Submission:

- Work on this assignment in a branch called `Branch_HW1`.
- Before the deadline, tag the version you want to be graded with `HW1`.
- Submit the link to the repository (either the tag or branch link) via Canvas by the HW deadline.

##### 6. Points Breakdown:

- Fulfillment of requirements: 5 points.
- Quality of version control: 1 point.
- Code cleanliness and efficiency: 1 point.
- Identifier quality: 1 point.
- Comment quality: 1 point.
- Test case quality: 1 point.


---

## [Homework 2](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/tree/Homeworks/CPTS321-SoftwareEngineeringPrinciples-Homework-2)

### Homework 2: Overview
#### WinForms/Avalonia .NET Application

#### Topics Covered:
- GUI development using WinForms or Avalonia
- Algorithm implementation and performance analysis
- Object-oriented design principles

#### Details of the Tasks:
##### 1. Create a WinForms or Avalonia Application:
- Depending on your platform, create a new WinForms or Avalonia project in Visual Studio or JetBrains Rider.

##### 2. Design the Interface:

- Add a `TextBox` to your form for displaying results. Ensure it has the `Multiline` property set to `true` and is docked to fill the form.

##### 3. Generate a List of Random Integers:
- Use the `Random` class to generate a list of 10,000 random integers in the range [0, 20,000].

##### 4. Implement Three Distinct Integer Counting Methods:

- **Method 1**: Use a `HashSet` to count distinct integers and calculate the time complexity.
- **Method 2**: Implement a method that counts distinct integers using O(1) auxiliary storage, focusing on space efficiency.
- **Method 3**: Sort the list and then count distinct integers with O(1) storage and O(n) time complexity.

##### 5. Display the Results:

- Output the results of each method into the `TextBox` in your application.

##### 6. Version Control and Submission:

- Work on a branch called `Branch_HW2` and submit the final tag as `HW2`.
- Follow TDD practices and ensure each commit is cohesive and well-documented.

##### 7. Grading Breakdown:

- 1 point for Method 1.
- 2 points each for Methods 2 and 3.
- 1 point each for version control, code quality, identifier quality, comments, and test cases.


---

## [Homework 3](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/tree/Homeworks/CPTS321-SoftwareEngineeringPrinciples-Homework-3)

### Homework 3: Overview
#### WinForms/Avalonia "Notepad" Application with Fibonacci Sequence

#### Topics Covered:
- GUI development using WinForms or Avalonia
- Implementing file I/O and custom TextReader
- Working with large numbers using BigInteger

#### Details of the Tasks:

##### 1. Create a Notepad-like Application:

- Create a WinForms or Avalonia application with a TextBox to display and edit text, and buttons or menu options for loading and saving files.

##### 2. Implement Saving Functionality:

- Provide the ability to save text to a file using `SaveFileDialog`.

##### 2. Implement Loading Functionality:

- Implement a method called `LoadText` that reads from a TextReader and displays the content in the `TextBox`.
- Add options to load text from a file and to load the first 50 or 100 numbers of the Fibonacci sequence.

##### 4. FibonacciTextReader Class:

- Create a custom `TextReader` that generates Fibonacci numbers and integrates with the LoadText method.
- Use `BigInteger` to handle large Fibonacci numbers and ensure correct sequence generation.

##### 5. Version Control and Submission:

- Work on a branch called `Branch_HW3` and submit the final tag as `HW3`.
- Adhere to TDD practices, with clear and concise commits.

##### 6. Grading Breakdown:

- 2 points for saving functionality.
- 3 points for the loading function.
- 1 point each for version control, code quality, identifier quality, comments, and test cases.



--- 

## [Homework 4](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/tree/Homeworks/CPTS321-SoftwareEngineeringPrinciples-Homework-4)

### Homework 4: Overview
#### First Steps for Your Spreadsheet Application

#### Topics Covered:
- GUI development using WinForms or Avalonia
- Building the foundation of a spreadsheet application
- Implementing basic data structures

#### Details of the Tasks:
##### 1. Project Setup:

- Create a new WinForms or Avalonia application and name it `Spreadsheet_FirstName_LastName`.
- Set up a DataGridView (for WinForms) or DataGrid (for Avalonia) to serve as the main interface of the spreadsheet.

##### 2. Grid Initialization:

- Programmatically create columns A to Z in the spreadsheet.
- Programmatically create 50 rows, numbered 1 to 50.

##### 3. Logic Engine Class Library:
- Create a separate class library project in the same solution for the logic engine. This will contain the core functionality of the spreadsheet, decoupled from the UI.

##### 4. Implement the Cell Class:
- Create an abstract base class named `Cell` with properties for `RowIndex`, `ColumnIndex`, `Text`, and `Value`.
- Implement the `INotifyPropertyChanged` interface to notify the UI of changes.

##### 5. Implement the Spreadsheet Class:

- The `Spreadsheet` class will manage a 2D array of `Cell` objects and handle cell creation and value updates.
- Implement a `GetCell` method to retrieve cells and properties to return the number of rows and columns.

##### 6. Event Handling:

- Link the UI to the logic engine by subscribing to property change events in the `Spreadsheet` class.
- Implement a demo in the UI to show how changing cells in the Spreadsheet object updates the UI.

##### 7. Version Control and Submission:

Work on a branch called Branch_HW4 and submit the final tag as HW4.
Adhere to TDD practices, with clear and concise commits.
Grading Breakdown:

5 points for correct functionality.
1 point each for version control, code quality, identifier quality, comments, and test cases.

---

## [Homework 5](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/tree/Homeworks/CPTS321-SoftwareEngineeringPrinciples-Homework-5)

### Homework 5: Overview
#### Arithmetic Expression Trees (Part 1)

#### Topics Covered:
- Expression parsing and evaluation
- Data structures (Expression Trees)
- Implementing a console application for testing

#### Details of the Tasks:
##### 1. Create the ExpressionTree Class:

- Develop the `ExpressionTree` class in your logic engine DLL. This class will parse and evaluate arithmetic expressions.

##### 2. Implement Expression Tree Functions:

- Add methods to set variables, evaluate the expression, and construct the tree from a given string.

##### 3. Console Application:

- Create a console application to demo the functionality of the `ExpressionTree`. This includes a menu to enter expressions, set variable values, evaluate the expression, and quit.

##### 4. Parsing and Tree Construction:

- Support simplified expressions with a single type of operator (+, -, *, or /) without parentheses.
- Build a proper expression tree with nodes for constants, variables, and operators.

##### 5. Variable Support:

- Implement variable handling in the `ExpressionTree` class, allowing users to set values dynamically.

##### 6. Version Control and Submission:

- Work on a branch called `Branch_HW5` and submit the final tag as `HW5`.
- Follow TDD principles and ensure the code is well-documented.

##### 7. Grading Breakdown:

- 5 points for implementing correct functionality.
- 1 point each for version control, code quality, identifier quality, comments, and test cases


---

## [Homework 6](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/tree/Homeworks/CPTS321-SoftwareEngineeringPrinciples-Homework-6)

### Homework 6: Overview
#### Arithmetic Expression Trees (Part 2)

#### Topics Covered:
- Advanced parsing and evaluation of arithmetic expressions
- Support for operator precedence and parentheses
- Implementation of a comprehensive expression tree

#### Details of the Tasks:
##### 1. Operator and Parentheses Support:

- Extend your expression tree to handle addition (+), subtraction (-), multiplication (*), and division (/) operators with correct precedence.
- Implement support for parentheses to ensure expressions are evaluated correctly based on grouping.

##### 2. Tree Construction:

- Ensure that the expression tree is built correctly using a Factory pattern as discussed in class. Each node should represent an operator or operand with proper relationships.

##### 3. Variable Support:

- Support variables in expressions, including multi-character variable names (e.g., A2).
- Store variables in a dictionary within the expression tree class, initializing them with a default value of 0.

##### 4. Version Control and Submission:
- Work in a branch named `Branch_HW6` and tag the final version as `HW6` before merging.
Submit the repository link with the tag via Canvas by the deadline.

#### 5. Grading Breakdown:

- 5 points for correct functionality.
- 1 point each for version control, code quality, identifier quality, comments, and test cases.
  
--- 

## [Homework 7](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/tree/Homeworks/CPTS321-SoftwareEngineeringPrinciples-Homework-7)

### Homework 7: Overview
#### Spreadsheet Formula Evaluation

#### Topics Covered:
- Integration of expression trees with a spreadsheet application
- Evaluation of formulas within spreadsheet cells
- Efficient update propagation of dependent cells

#### Details of the Tasks:

##### 1. Spreadsheet Application Updates:

- Modify your spreadsheet application to use the expression tree for evaluating cell formulas.
- Display the formula in edit mode and the evaluated result otherwise.

##### 2. Expression Evaluation Integration:

- Implement formula parsing in the spreadsheet so that when a cell’s formula is updated, the `ExpressionTree` class evaluates it.
- Handle variable names corresponding to cell references (e.g., `A1`, `B2`).

##### 3. Update Propagation:

- Ensure that when a cell’s value is updated, all dependent cells are recalculated. Use an efficient design such as event-driven updates to avoid recalculating the entire spreadsheet unnecessarily.

##### 4. Version Control and Submission:

- Work in a branch named Branch_HW7 and tag the final version as HW7 before merging.
- Submit the repository link with the tag via Canvas by the deadline.

##### 5. Grading Breakdown:

- 5 points for correct functionality.
- 1 point each for version control, code quality, identifier quality, comments, and test cases.


---

## [Homework 8](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/tree/Homeworks/CPTS321-SoftwareEngineeringPrinciples-Homework-8)

### Homework 8: Overview
#### Undo/Redo System Implementation

#### Topics Covered:
- Implementation of an undo/redo system
- GUI updates and event handling
- Advanced property management

#### Details of the Tasks:
##### 1. Add Background Color Property to Cells:
- In the logic engine, add a `uint` property named` BGColor` to the `Cell` class to store the background color. The default color should be white (`0xFFFFFFFF`).
- Ensure that changes to the BGColor property trigger the property-changed event, allowing the UI to update accordingly.

##### 2. Update the GUI:
- Modify the event-handling code in the UI to respond to changes in cell background colors.
- For WinForms, use the `DataGridViewCell.Style.BackColor` property and the `Color.FromArgb` method to update cell colors.
- Add a button or menu option that allows users to change the background color of selected cells using a ColorDialog.

##### 3. Implement Undo/Redo System:

- Implement a comprehensive undo/redo system for changes to cell text and background color.
- Ensure that every undo operation adds a corresponding redo operation to the redo stack.
- The undo and redo stacks should be private and managed through public methods like `AddUndo`.
- Provide menu options or buttons to perform undo and redo actions, disabling them when their respective stacks are empty.
- The design must be extendable to support new undo/redo functionality without altering existing code.

##### 4. Version Control and Submission:

- Work in a branch called `Branch_HW8` and tag the final version as `HW8` before merging.
- Submit the repository link with the tag via Canvas by the deadline.

##### 5. Grading Breakdown:

- 5 points for correct functionality.
- 1 point each for version control, code quality, identifier quality, comments, and test cases

---

## [Homework 9](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/tree/Homeworks/CPTS321-SoftwareEngineeringPrinciples-Homework-9)


### Homework 9: Overview
#### Loading and Saving Spreadsheet Data

#### Topics Covered:
- XML data handling and persistence
- Advanced spreadsheet functionality
- Integration of file I/O with the application

#### Details of the Tasks:
##### 1. Add Load/Save Functionality:
- Design an XML format for your spreadsheet data, ensuring it supports storing cell names, background colors, and text/formulas.
- Implement saving and loading methods for your spreadsheet application, which should work with streams.
- Ensure that only cells with non-default properties are saved.

##### 2. UI Integration:

- Add menu options for loading and saving files in the UI.
- Upon loading, clear all existing data, including undo/redo stacks, and properly evaluate any formulas in the loaded data.

##### 3. XML Handling:

- Use .NET’s XML classes (e.g., `XDocument`, `XmlDocument`, `XmlReader`, `XmlWriter`) for reading and writing XML.
- Ensure the loading method can handle XML files with different tag orders or extra tags that were not saved by your application.

##### 4. Version Control and Submission:

- Work in a branch called `Branch_HW9` and tag the final version as `HW9` before merging.
- Submit the repository link with the tag via Canvas by the deadline.

##### Grading Breakdown:

- 5 points for correct functionality.
- 1 point each for version control, code quality, identifier quality, comments, and test cases

  
---

## [Homework 10](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/tree/Homeworks/CPTS321-SoftwareEngineeringPrinciples-Homework-10)

### Homework 10: Overview
#### Handling Circular References in Formulas

#### Topics Covered:
- Circular reference detection and handling
- Spreadsheet application enhancement
- Advanced formula evaluation and error management

#### Details of the Tasks:
##### 1. Understand the Problem:

- The assignment focuses on enhancing your spreadsheet application to detect and handle circular references in cell formulas. This requires refactoring your existing code to ensure the application can handle various problematic reference cases.

##### 2. Cases to Handle:

- **Non-Existent References**: The formula might reference a cell that doesn’t exist, such as `Z12345` or an invalid name like `Ba`. Handle this by setting the cell value to an error message instead of treating the reference as `0`.

- **Self-Referencing**: If a cell references itself in a formula (e.g., `=A1` or `=B2/(A1*A2)*7)`, the application should display an error string for that cell.

- **Circular References**: Detect circular references across multiple cells (e.g., `A1 = B1`, `B1 = A1`). This could be a direct circular reference or a more complex chain. The application must display an error for at least one cell in the chain and avoid infinite loops or stack overflows.

##### 3. Circular Reference Handling:

- The application should ensure that, when a circular reference is detected, it avoids infinite loops and updates all relevant cells correctly when the circular reference is resolved.

##### 4. Version Control and Submission:

- Create and work in a branch called `Branch_HW10`.
- Merge the branch back to the master once completed and tag the final version as `HW10`.
- Submit the repository link with the tag via Canvas by the deadline.

##### 5. Grading Breakdown:

- 5 points for implementing correct functionality.
- 1 point each for version control, code quality, identifier quality, comments, and test cases.


  







