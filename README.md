# Lecture Slides 

## Week 1 
#### - Class overview. Introduction to C#. basic language features.
#### - Independentreview of time complexity and Git/GitLab.


### ***[w1.1 - Class Overview](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w1.1.%20Class%20overview.pdf)***
  - This document provides an overview of a university course taught by Dr. Venera Arnaoudova at Washington State University. It includes course logistics, such as class times, office hours, communication expectations, and grading breakdown. The document emphasizes the importance of class attendance, participation, and independent learning. The course focuses on learning C# and developing large-scale software projects, with additional emphasis on data structures, algorithms, and good software design practices.

### ***[w1.2 - IntroToCSharp](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w1.2.%20IntroToCSharp.pdf)***
  - This document introduces the basics of C# programming within the context of the .NET platform. It covers the different implementations of .NET, the fundamentals of C#, including its managed language features, syntax, access modifiers, and the distinctions between value types and reference types. The document also outlines important concepts such as inheritance, interfaces, and properties in C#. This material is part of a course at Washington State University, aiming to provide foundational knowledge for students transitioning from C++ to C#.

### ***[w1.3 - From C++ to C#](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w1.3%20FROM%20C%2B%2B%20TO%20C%23.jpeg)***
  - This document is a set of slides designed to help students transition from C++ to C#. It compares and contrasts the two languages, highlighting similarities like syntax and object-oriented features, as well as differences such as memory management, access modifiers, and the handling of data types. The slides also discuss C#'s managed code environment, automatic garbage collection, and the language's strong emphasis on safety and simplicity.

***
## Week 2
#### - More about C#.

***
## Week 3
#### - Introduction to NUnit and Test Driven Development (TDD)
#### - Naming and commenting practices. 

### ***[w3.2 Testing](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w3.2.%20Testing.pdf)***
  - This document introduces the concept of software testing with a focus on automated and systematic approaches using NUnit. It discusses different types of testing (e.g., white-box, black-box, unit testing) and the importance of assertions to validate test outcomes. The document also introduces Test-Driven Development (TDD), emphasizing the iterative process of writing tests before implementing code. It includes practical examples and steps for setting up a testing environment in Visual Studio or JetBrains Rider

### ***[w3.3 Naming and Commenting](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w3.3.Naming%20and%20commenting.pdf)***
  - This document outlines best practices for naming and commenting code in C#. It covers the importance of clear, concise, and consistent naming conventions, avoiding common naming mistakes, and following standard practices such as using camelCase for variables and PascalCase for class names. The document also emphasizes the role of comments in code clarity, explaining when and how to use both summary and inline comments effectively. Additionally, it introduces tools like StyleCop for enforcing coding standards.


***
## Week 4
#### - Introduction to StyleCop.
#### - Streams and TextReader/TexterWriter abstractions.

### ***[w4.1 ConfiguringStyleCop-WIDE](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w4.1.ConfiguringStyleCop-WIDE.pdf)***
  - This document provides a guide on configuring StyleCop, a tool used to enforce coding standards in C#. It covers setting up StyleCop in Visual Studio and JetBrains Rider, including the creation and configuration of the `stylecop.json file`. The document emphasizes the importance of adhering to default coding rules, but also provides instructions on how to justify and commit changes to the configuration. This guide is essential for maintaining consistent code quality across projects​.

### ***[w4.3 Streams-WIDE](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w4.3.%20Streams-WIDE.pdf)***
  - This document discusses the concept of streams in C# and how they can be used to handle different data sources, such as files, memory, and network connections. It contrasts the approaches taken by different programmers in dealing with changing requirements and demonstrates the benefits of using streams to write flexible and maintainable code. The document also explains how various stream types, like `FileStream`, `NetworkStream`, and `MemoryStream`, can be utilized to extend the functionality of a program without modifying the core logic​.


***
## Week 5

#### - DLLs and class libaries.
#### - Introductions to GUIs and event-driven applications: design tactics (logic and UI decoupling; delegates and events).


### ***[w5.1.1 DLLs and Class Libraries](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w5.1.1%20DLLs%20and%20Class%20Libraries.pdf)***
  - This document introduces the concept of DLLs (Dynamic Link Libraries) and class libraries in C#. It explains how DLLs, which contain code and data, are loaded into memory by an application at runtime to extend functionality. The document covers how to create and use class libraries in C# projects, emphasizing the benefits of cohesion, reusability, and information hiding. It also touches on the use of reflection to dynamically load and use DLLs in applications.

### ***[w5.1.2 GUIs and WinForms-WIDE](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w5.1.2.%20GUIs%20and%20WinForms-WIDE.pdf)***
  - This document provides an overview of creating graphical user interfaces (GUIs) using WinForms and Avalonia in C#. It discusses the basics of event-driven programming, where applications respond to user interactions such as clicks or key presses. The document explains how to design interfaces using Visual Studio's drag-and-drop tools for WinForms, and it introduces Avalonia for cross-platform UI development, which uses XAML for interface design.

### ***[5.2. Design Principles for Event-Driven Applications-WIDE](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w5.2.%20Design%20Principles%20for%20Event-Driven%20Applications-WIDE.pdf)***
  - This document discusses key design principles for developing event-driven applications. It emphasizes the importance of decoupling the user interface (UI) from the logic/data layers to create more maintainable and flexible software. The document also introduces design patterns such as the observer pattern, which allows components to notify others of state changes, and discusses how to implement these patterns in C# using features like the `INotifyPropertyChanged` interface and events

***
## Week 6 

#### - Spreadsheet design overview.
#### - Assorted Questions and Concepts.
#### - Sample Mid-term 1.

### ***[6.1.1 Spreadsheet Design Overview-WIDE](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w6.1.1.%20Spreadsheet%20Design%20Overview-WIDE.pdf)***
  - This document outlines the design of a spreadsheet application, focusing on separating the UI from the logic/data layers following the Model-View Separation Principle. It details the structure and responsibilities of the Cell and Spreadsheet classes, which are part of the application's engine. The design emphasizes encapsulation, property-change notifications, and adherence to good software design principles such as low coupling and high cohesion​.


### ***[w6.2.1 Assorted Questions and Concepts-WIDE](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w6.1.1.%20Spreadsheet%20Design%20Overview-WIDE.pdf)***
  - This document presents a series of coding questions and concepts aimed at reinforcing understanding of C# programming and software design principles. The questions cover various topics, including identifying compilation errors, understanding string manipulation, reference passing, loops, and implementing algorithms with specific time and space complexity requirements. It serves as a practice resource for homework and exams.


### ***[w6.2.2 Assorted Questions and Concepts-WIDE](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w6.2.2.%20Assorted%20Questions%20and%20Concepts-WIDE-part2.pdf)***
  - This continuation of the previous document includes additional programming challenges, focusing on efficient algorithm design and problem-solving in C#. The questions address topics such as counting distinct values, building frequency tables, and managing large datasets. The document also provides insights into what to expect on exams, including multiple-choice questions, code analysis, and design problems​. 
    

***
## Week 7
#### - GRASP Principles.
#### - Testing non-public entities.

### ***[w.7.2 Unit Testing Non Public Entities-WIDE](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w7.2.%20Unit%20Testing%20Non%20Public%20Entities-WIDE.pdf)***
  - This document discusses strategies for unit testing non-public methods in C#. It covers the use of friend assemblies to test internal methods and the application of reflection to test private methods. The guide provides detailed steps for setting up a testing environment that allows for the testing of non-public methods without compromising encapsulation, along with examples and best practices.

### ***[w7.3 Expression Tree Code.zip](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w7.3%20Expression%20tree%20code.zip)***

### ***[w.7.3.1 Expression Trees-WIDE](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w7.3%20Expression%20Trees-WIDE.pdf)***
  - This document explains the concept of expression trees, particularly in the context of parsing and calculating formulas in a spreadsheet application. It covers the structure of binary expression trees, the types of nodes required, and how to design and implement an expression tree. The material also includes practical examples and discusses the importance of designing for future changes.

### ***[w7.3.2 POS-Domain-Model](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w7.3-POS-domain-model.pdf)***
  - This document presents a partial domain model for a Point-of-Sale (POS) application, illustrating the relationships between various entities like Sales, LineItems, Products, and Payments. It emphasizes the importance of creating a clear and maintainable model by focusing on essential associations that preserve knowledge and reduce redundancy. The document is useful for understanding how to design domain models for similar retail applications. 

### ***[w7.3 Grasp-cont](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w7.3.GRASP-cont.pdf)***
  - This document explores advanced GRASP (General Responsibility Assignment Software Patterns) principles, focusing on how to assign responsibilities in object-oriented design. It covers key principles such as Creator, Controller, Pure Fabrication, Indirection, and Protected Variations, providing examples and applications in software design. The content is geared toward improving the design and maintainability of complex software systems.



***
## Week 8
#### - Arithmetic expression trees.
#### - More on arithmetic expression trees - identifying problems and potential refactorings. Factory method pattern. The Shunting Yard Algorithm.

### ***[w8.1.2 Expression Tree Code Demo (cont.) ](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w8.1.2%20Expression%20Tree%20Code%20Demo%20continued-WIDE-Problems%20and%20Tests.pdf)***
  - This document discusses the problems identified in the initial implementation of an expression tree and outlines solutions to improve the design. Key improvements include refactoring the code to eliminate hardcoded operators, separating classes into different files, improving exception handling, and considering operator precedence. The document emphasizes the importance of maintaining passing tests throughout the refactoring process.

### ***[w8.2 Expression Tree Code Demo continued-WIDE-Factory Method Pattern](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w8.2%20Expression%20Tree%20Code%20Demo%20continued-WIDE-Factory%20Method%20Pattern.pdf)***
  - This document introduces the Factory Method Pattern as a solution to decouple the creation of operator nodes from the rest of the expression tree logic. By using a factory class, the implementation becomes more flexible and easier to extend, allowing the addition of new operators without modifying the core logic. The document provides examples and guidance on how to refactor the expression tree code using this pattern.

### ***[w8.3 Expression Tree Code Demo continued-Shunting Yard Algorithm-WIDE](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w8.3.%20Expression%20Tree%20Code%20Demo%20continued-Shunting%20Yard%20Algorithm-WIDE.pdf)***
  - This document explains how to use Dijkstra’s Shunting Yard Algorithm to transform an infix expression into postfix notation, which can then be used to build an expression tree more efficiently. The document details the steps of the algorithm and provides guidance on constructing an expression tree using a stack-based approach, enhancing the overall elegance and maintainability of the code



***
## Week 9
#### - More on Arithmetic expression trees.
#### - Lambda expressions, LINQ, Reflection.
#### - Testing

***
## Week 10
#### - Exceptions
  
***
## Week 11
#### - Solutions to the Expression Tree code Demo.
#### - Mid-Term 2 prep.
#### - Undo/Redo system design.

### ***[w11.1 Expression Tree Code Demo Continued-Lambda expressions, LINQ, Reflection-WIDE](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w11.1.%20Expression%20Tree%20Code%20Demo%20continued-Lambda%20expressions%2C%20LINQ%2C%20Reflection-WIDE.pdf)***
  - This document explores the use of lambda expressions, LINQ, and reflection in the context of an expression tree code demo. It explains how lambda expressions simplify function syntax, how LINQ can be used for querying collections, and how reflection allows for dynamic handling of operators in the expression tree. These features enable more flexible and maintainable code.

***

## Week 12
#### - XML.
#### - Threading.

### ***[w12.1 Expression Tree Code continued-Exceptions-WIDE](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w12.1.%20Expression%20Tree%20Code%20Demo%20continued-Exceptions-WIDE.pdf)***
  - This document focuses on handling exceptions in the expression tree code. It discusses different types of exceptions, creating custom exceptions, and strategies for catching and re-throwing exceptions. The material also emphasizes defensive programming practices to avoid exceptions where possible and improve code reliability​.

### ***[w12.2 Undo-Redo-WIDE](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w12.2.%20Undo-Redo-WIDE.pdf)***
  - This document introduces the implementation of undo and redo functionality in a spreadsheet application using the Command design pattern. It explains how to encapsulate operations as commands, allowing for easy undo and redo of actions like text or background color changes in cells. The material covers the benefits of this pattern in reducing code duplication and improving the separation between the UI and domain logic.

### ***[w12.3 XML-WIDE](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w12.3.%20XML-WIDE.pdf)***
  - This document discusses using XML to save and load spreadsheet data. It covers the basics of XML, its structure, and how to work with it in C#. The document explores different design options for serializing and deserializing spreadsheet data and provides examples of how to structure XML for future extensibility.

***
## Week 13
#### - Code Reviews.
#### - UML (domain model, class diagram, sequence and communication diagrams).
#### - Refactoring 

### ***[w13.2 Threading-WIDE](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w13.2.%20Threading-WIDE.pdf)***
  - This document introduces the concept of threading in software development, specifically in C#. It explains what threads are, how they operate, and why they are beneficial for improving performance and responsiveness in applications. The material also discusses basic threading methods such as Start, Join, and Sleep, and provides examples of working with threads, including handling shared state and the importance of thread safety.


### ***[w13.3 Thread-cont-WIDE](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w13.3.%20Threading-cont-WIDE.pdf)***
  - This continuation of the threading topic delves deeper into passing information to threads, using lambda expressions, handling exceptions in threaded applications, and managing thread priorities. The document also covers threading in GUI applications like WinForms and Avalonia, emphasizing techniques to keep the UI responsive during long-running tasks. It provides practical coding examples and discusses how to safely update the UI from a worker thread.


***

## Week 14

### ***[w14.1-Code Review Presentation - Solutions](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w14.1-Code%20Review%20Presentation.pdf)***
  - This document provides an overview of the code review process, including its purpose, benefits, and best practices. It covers different types of code reviews, such as manual reviews, pair programming, and tool-assisted reviews. The presentation emphasizes the importance of code reviews for improving code quality, finding bugs early, and fostering better communication within development teams.

### ***[w14.3 Refactoring](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w14.3%20Refactoring.pdf)***
  - This document discusses the concept of refactoring, which involves restructuring existing code to improve its readability and maintainability without changing its external behavior. It covers different types of refactoring, such as extracting methods and renaming variables, and emphasizes the importance of maintaining clean code through frequent, incremental changes. The document also explores tools and methodologies that support refactoring within modern IDEs

### ***[w14.3-UML Presentation with solutions](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w14.3-UML%20Presentation%20with%20solutions.pdf)***
  - This document introduces the Unified Modeling Language (UML) and its application in software design. It covers various UML diagrams, such as class diagrams, sequence diagrams, and communication diagrams, explaining their importance in modeling the structure and behavior of software systems. The presentation also highlights the benefits of using UML for improving communication among stakeholders and identifying potential design issues early in the development process. 


### ***[UML - Class Diagrams, Sequence/Communication Diagrams](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w14.3-UML%20Presentation.pdf)***

### ***[SOLID Principles Presentation(myGroup)](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/tree/BonusPresentationMaterial(SOLID-PRINCIPLES))***
  - This document provides an overview of the SOLID principles in object-oriented programming, which are essential guidelines for creating maintainable and scalable software. The principles include Single Responsibility, Open-Closed, Liskov Substitution, Interface Segregation, and Dependency Inversion. Each principle is explained with visual examples, coding demonstrations, and real-world scenarios to illustrate how they can be applied to improve software design.


***
## Week 15
#### - Design Patterns(DP).
#### - Solid Principles.
#### - Design Anti-Patterns (AP).

### ***[Cpts321 - Design Patterns](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w15.1-DP-Presentation-solutions.pdf)***
  - This presentation introduces the concept of design patterns in software development, as popularized by the Gang of Four. It covers the three main categories of design patterns: Creational, Structural, and Behavioral, with detailed explanations and examples for patterns like Singleton, Composite, and Strategy. The document emphasizes the practical application of these patterns to solve common design problems in object-oriented programming​.

### ***[w15.3-AntiPatterns](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w15.3-AntiPatterns.pdf)***
  - This document discusses AntiPatterns, which are common responses to recurring problems that are counterproductive. It provides historical context and examples of various AntiPatterns, such as Spaghetti Code, God Object, and Stovepipe System. The document also offers solutions and refactoring strategies to address these issues, aiming to guide developers away from poor design practices and towards better coding standards​.

***
## Week 16
#### - Disposal and Garbage Collection, Mocking, Debugging.

### ***[w16.1-GC-cpts321-garbagecollection](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w16.1-GC-cpts321-garbagecollection-main.zip)***
  - This document explains the concepts of garbage collection and memory management in C#. It covers how the .NET runtime manages memory using a generational garbage collector, the conditions that trigger garbage collection, and the phases involved in the process. The document also discusses related topics like static variables, WPF bindings, and disposable objects, providing insights into optimizing memory usage in C# applications.

### ***[w16.3-Debugging-Presentation](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/LectureMaterial/w16.3-Debugging-Presentation.pdf)***
  - This presentation focuses on debugging techniques in software development. It covers the basics of using debuggers, such as setting breakpoints, stepping through code, and inspecting variables. Advanced topics include managing large loops, recursion, and using conditional breakpoints. The document also highlights the importance of understanding different types of errors—syntax, runtime, and logic—and how to effectively resolve them during the debugging process​. 



