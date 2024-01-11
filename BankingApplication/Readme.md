
> [!NOTE]
> I started this project really late and had to rush to turn it in, obviously this is not an ideal situation and I would make sure to give yourself a lot of time to fully work through this Final Exam/Project .

# Project Steps/Requirements 

1. Authenticate users: should be ablet to login before any of the other features below are made available to them. for authentication. 

- this means that your design should accomodate that and that you do not need to implement the actual authentication 


2. Check status: 
Uses should be able to check the status of all their accounts. Saving accounts have interests that clients gain as well as a minimum amount that should be available on the account. Checking the status consists of: 

- Check accounts: Show the account numebr, current balance and the last 5 transactions 

- Saving accounts: SHow the account number, current balance, interest rate, total amount of interest gained for the year, and the last 5 transactions of the account 

3. Transfer funds: users should be able to transfer money from one account to another ( assume for now that only accounts from this bank can be used for transfer). A user can transfer funds from one of their own or someone else's account. Of course, the transfer is valid and should happen only if sufficient funds are
available. Thus, the transaction consists of 3 actions: 1) check for available sufficient
funds, 2) withdraw the funds from one account, and 3) add funds into the receiving
account. The user should be able to undo the last transaction within the next 5 minutes
of placing the transaction (i.e., within 5 minutes after clicking on the transfer funds
button). Employees, can cancel the transaction within the first 24h. This should be implemented with GUI functionality. 


> [!IMPORTANT]
> Below are all the parts that I did not get done in this project.

## Fixed/Finished Features

- GUI for all User interaction events
- Hashed passwords for all client accounts and admin passwords
- Admin Status
- Admin View
- Admin Removal of clients
- Admin Overview of clients (seeing all clients in system)
- Client Account Creation
- Client Dashboard (check status, transfers, sign out)
- Check status (Account status: shows checking account and savings account details, interest and interest gained)

## Feature implmented with errors

- Internal transfers (within the same client account)
- external transfers, are made but not updated (Transfers made to other client accounts)
- client Undo Transfers
- Admin Undo Transfers (time is set but the
- Account status, tabluar form of seeing transactions, transaction are being made but just not shown in GUI
- Structural features
- Modular programming
- StyleCop package

## Non-implemented features

- Admin Undo/Cancel transfers
- Client Cancel transfer


---

> [!WARNING]
> Below is all the points I lost on this assignment.
> There were many errors with this project, in terms of the structure of the files/modularity of the application with GUI, accessibility of classes in terms public vs private classes, also the flow of actions is a bit messy. 


Q1 comments: 
No submission/Documentation (-5) 
( submitted late to Prof. via Email)

Q1: Factory Method is responsible creting objects, not interacting with xml data  (-1)

Q2: comments: NEW COMMENTS: 
Version Control: Implementation committed before tests, all code in one commit (-3) 

Design: WinForms are defined within the class library, forms are instantiating classes that should be privae and managed by engine class, not modular, Hardcoded values for transaction (in Transaction.cs in the Transaction Method, etc.) no use of events, does not adhere to patterns in design document (-6) 

Quality of Code: 

Forms are mixed with logic class classes, actions are hardcoded into the forms, multiple forms are generated for a simple display, not using events for updating UI (-3),

Tests: One one test that is not informative (-2.5)
