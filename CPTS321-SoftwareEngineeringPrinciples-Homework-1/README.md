# CPTS321 - WASHINGTON STATE UNIVERISTY 
## C# - Software Engineering Principles

> [!TIP]
> This is the first real assignment and is meant to help you understand how to code in C#

### Steps: 
1. Get a list of integer numbers from the user on a SINGLE LINE
   - The numbers will be in the range [0,100]
   - The numbers will be separated by spaces
   - You may assume that the user enters a correctly formatted input string that meets these requirements
   - You may use Console.ReadLine or a similar method to get input from the user
  
2. Add all the numbers to a binary search tree in the order they were entered
   - Don't allow duplicates
   - Use the Split function on the entered string for easy parsing (split on the space character)
  
3. Display the numbers in sorted order (smallest first, largest last)
   - Traverse the tree in order to produce this output
  
4. Display the following statistics about the tree
   - Number of items (note that this will be less than or equal to the number of items entered by the user, since duplicates won't be added to the tree). Write a function that determines this from your BST, NOT the array returned from the split. In other words, you must have a Count function in your BST implementation (you are not allowed to use any existing implementation for that)
   - Number of levels in the tress. A tree with no nodes at all has zero levels. A tree with a single node has 1 level. A tree with 2 nodes has 2 levels. A tree with three nodes could have 2 or 3 levels. You should know why this is from your advanced data structures course.
   - Theoretical minimum number of levels that the tree could have given the number of nodes it containes (figure out the formula to calculate this) 

>[!IMPORTANT]
> Below is the output that you should get when completing this assignment


'Enter a collection of numbers in the range [0,100], separated by spaces:\
&nbsp;&nbsp;&nbsp;&nbsp;55 22 77 88 11 22 44 77 55 99 22\
&nbsp;&nbsp;&nbsp;&nbsp;Tree contents: 11 22 44 55 77 88 99\
&nbsp;&nbsp;&nbsp;&nbsp;Tree Statistics:\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Number of nodes: 7\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Number of levels: 4\
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Minimum number of levels that a tree with 7 nodes could have = 3\
Done'


