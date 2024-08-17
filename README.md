# Solid Principle Presentation 

## [PDF File - "2023-Fall-SOLID Principles.pdf"](https://github.com/MarkShinozaki/CPTS321-SoftwareEngineeringPrinciples/blob/Bonus-(SOLID-PRINCIPLES)/2023-Fall-SOLID%20Principles.pdf):

- This PDF is a guide on how to write better code using SOLID principles. These are five important rules for making your code easier to understand, change, and fix. Here’s what each principle means:

#### 1. Single Responsibility Principle (SRP): Each class should do only one thing. For example, a class that handles invoices should not also send emails.
   
#### 2. Open-Closed Principle (OCP): You should be able to add new features to your code without changing existing code. This prevents breaking what already works.

#### 3. Liskov Substitution Principle (LSP): If you have a base class and a subclass, you should be able to use the subclass wherever the base class is expected, without problems.

#### 4. Interface Segregation Principle (ISP): Don’t force a class to implement functions it doesn’t need. It’s better to have smaller, more specific interfaces.

#### 5. Dependency Inversion Principle (DIP): High-level classes should not depend on low-level classes. Both should depend on abstractions (interfaces).

## Soccer.cs and SoccerRefactored.cs Files:

- **Soccer.cs**: This file contains code related to a soccer game or soccer-related operations. However, this code might not follow the SOLID principles well. For example, it might have classes that do too many things (violating SRP) or are hard to extend without changing (violating OCP).

- **SoccerRefactored.cs**: This is an improved version of the Soccer.cs file. Here, the code has been rewritten to follow the SOLID principles. For example, if there was a class that handled both player stats and game rules, it might now be split into two separate classes, each with a single responsibility.

