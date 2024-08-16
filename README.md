# Midterm Samples Questions 

> [!NOTE]
> Review the PNG's above to see some of the sample questions you can encounter on the first exam. Below there will be more additional questions. Also, All the questions that are included should be concepts and topics that will help you for both Midterm 1 and Midterm 2 but, these are specific questions pulled from Midterm 1 sample material.

> [!WARNING]
> All of the questions and material are topics and questions important to the course but be in mind these questions may or may not appear on the Midterm and specifically with this course, no two back-to-back semesters have the same Midterm 1 and Midterm 2 questions. Moreover, these questions can be similar and different to questions that you may encounter.

# Sample Questions 

## Question 1 

When should on use an 'abstract' class as opoosed to a 'class'? 
- [ ] It doesnt matter - they are equivalent
- [ ] When we need an object to be instantiated: a class cannot be instantiated but an abstract class can
- [ ] When we don't need to store state: an 'abstract class' cannot store state but a class can
- [x] **When some of the behavior can be only defined in the derived types**

## Question 2

Which of the following is true about C#?
- [ ] Types are checked dynamically and statically
- [ ] Types are checked statically but not dynamically
- [ ] Types are checked dynamically but not statically
- [x] **It supports event driven development**

## Question 3

When we use the keyboard static for an attribute (i.e., state) in a type:
- [ ] The attribute is immutable
- [ ] The value stored in the attribute cannot be changed
- [x] **The value storted in the attribute is teh same for all instances of the type**
- [ ] The static keyword is allowed for methods only, not for attributes

# Question 4 

If we do not explicitly specify an access modifier when declaring a type:

- [ ] There will be a compilation error
- [ ] The type will be visible from the same file only
- [x] **The type will be visible from the same project only**
- [ ] The type will be visible from everywhere (within and outside the project)

# Question 5

A TextReader is:

- [ ] A linear sequence of bytes
- [ ] A linear sequence of characters
- [x] **An abstract data source**
- [ ] A concrete class that can be instantiated

# Question 6 

A good design can be characterized with:

- [ ] Low cohesion and high coupling
- [ ] Low cohesion and low coupling
- [x] **High cohesion and low coupling**
- [ ] High cohesion and high coupling 

# Question 7

 Which of the following is true about DLL and executable applications? 

 - [x] **DLLs are meant to be used in other projects**
 - [ ] Executables are meant to be executed as stand-alone appplications
 - [ ] DLLs are meant to be executed as stand-alone applications
 - [ ] Executables are meant to be used in other projects

# Question 8 

Properties in C#: 

- [ ] Are like methods, getters and setters in particular
- [ ] are like fields from the outside as we set them using the "=" operator
- [x] **Promote encapsulation**
- [ ] Do not exist

# Question 9 

User defined classes in C#: 

- [ ] Are immutable
- [ ] Are value types
- [x] **Are reference types**
- [ ] Support multiple inheritance

# Question 10 

Which of thw following is true for C# types? 

- [ ] String instances are immutable
- [ ] StringBuilder instances are immutable
- [x] **String is a value type**
- [ ] 'int' is a value type

# Question 11 

Properties can perfrom calculations 

- [ ] False
- [x] **True**

# Question 12 

Consider the following code statement and select the sentences that are true: 
    public string Year {get; set;}

- [ ] The code will not compile
- [ ] It declares a method the returns a string and does nothing
- [ ] It declares an attribute of type string
- [x] **It declares a property of type string**

# Question 13 

In C# boxing is 

- [ ] Copying the value of a value type instance to a reference type instance
- [ ] Copying the value of a reference type instance to a value type instance
- [ ] Copying the value of a reference type instance to a reference type instance
- [x] **Copying the value of a value type instance to a value tyep instance**

# Question 14 

In C#, if a method is declared in a parent class with the signature "public virtual void Fool()", which of following allows to hide the method in a child class: 

- [ ] public void Foo()
- [x] **public new void Foo()**
- [ ] public override void Foo()
- [ ] None of the above

# Question 15

Which of the following are good design/architectutal practices when building applications with a GUI: 

- [x] **MVVM**
- [x] **Layered architecture**
- [x] **Observer design pattern**
- [ ] Have the logic and user interface in one file to promote encapsulation

# Question 18 

Provide definitions the following concepts: 

- MVVM: **A software architectural pattern that separates the user interface (View), the data model (Model), and the business logic or presentation logic (ViewModel). It promotes a clean separation of concerns, making the application more maintainable and testable.**
  
- Coupling: ** The degree of direct knowledge that one element has of another. Low coupling is desirable because it indicates that modules/components are independent of each other.**
  
- Cohesion: **The degree to which the elements inside a module belong together. High cohesion is desirable because it indicates that a module has a single, well-defined purpose.**
  
- Encapsulation: **The bundling of data and methods that operate on that data within a single unit (e.g., a class), and restricting access to some of the object's components, which is a means of preventing unintended interference and misuse.**

# Question 19 

You are contacted by a company to build an application in C# with a GUI (using WinForms or Avalonia) that will allow users to create, display, and remove different types of musical instruments. As a start, the application should support three instruments: piano, flute, and ukulele. More will come later so your design should allow to easily add those. Every instument will have a specific frequency for the sound (you can consider this being a positive number), a color (can represented as text), etc. You can give those properties defualt values; the user should be given the possibility to change the color but not the frequency. 

The GUI will have the following: 

- Three buttons to crearte an instrument (one button for each of the 3 types that are supported in the initial version of the application). Only one instrument can exist at the time. If the user creates an instrument and then clicks to create another instrument, the previous one is dicarded.

- A text box that displays the current instrument - type and its characteristics (frequency and color)
- A button to change the color of the current instrument. You can create a set of predefined colors and iterate over them over them or randomly chose one of them when the user clicks on the button.
- A button to play the current instrument. We will simulate playing an instrument by simply calling a method which will return a message that will be displayed in the GUI. The message will be "The <instrument type> was played!" where <instrument type> is the type of the current instrument.

You are expected to use good design and architectural principles seen in class. Provide rationale for your design choices when you feel there is a need. (remainder: Design for change!) 

- Class Design:
 - Use an abstract Instrument class with properties like Frequency (read-only) and Color.
 - Concrete classes Piano, Flute, and Ukulele inherit from Instrument.
 - Implement a ChangeColor method to cycle through predefined colors.
 - Implement a Play method that returns a message indicating the instrument is played.
   
- GUI Design:
 - Use the MVVM pattern to separate the UI (View) from the business logic (ViewModel) and data (Model).
 - The ViewModel will contain the current Instrument and commands to create, change color, and play the instrument.
 - The View will bind to the ViewModel and display the instrument’s type, color, and frequency, and provide buttons to interact with the instrument.






























