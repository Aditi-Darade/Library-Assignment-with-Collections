Create an application that models a library. The library has different types of items such as books, DVDs, and CDs. Your task is to create interfaces and classes that represent these items, and implement methods that are appropriate for each item.

Part 1: Create Interfaces
First, create the following interfaces:

ILoanable: defines the properties and methods that an item that can be borrowed should have. This should include properties such as LoanPeriod and Borrower, as well as methods such as Borrow and Return.

IPrintable: defines the method Print, which should print out information about the item.



Part 2: Create Classes
Next, create classes that implement the ILoanable and IPrintable interfaces for the following types of items:

Book: has properties such as Author, Title, and ISBN, and should be loanable for 21 days.

DVD: has properties such as Director, Title, and LengthInMinutes, and should be loanable for 7 days.

CD: has properties such as Artist, Title, and NumberOfTracks, and should be loanable for 14 days.

Each class should implement the ILoanable and IPrintable interfaces in a way that is appropriate for that item.



Part 3: Create a Library Class
Create a Library class that has the following properties and methods:

Items: a list of items in the library.

AddItem: a method that adds an item to the library.

RemoveItem: a method that removes an item from the library.

PrintLibrary: a method that prints out information about all items in the library.



Part 4: Test Your Implementation
In the Main method, create an instance of the Library class and add some Book, DVD, and CD objects to the library. Test that you can borrow and return items, and print out information about all items in the library.



Requirements
Your implementation should meet the following requirements:

All classes should implement the appropriate interfaces in a way that is appropriate for that item.

The Library class should have the specified properties and methods.

You should demonstrate that your implementation works by adding items to the library, borrowing and returning them, and printing out information about all items in the library.



Sample output:

CD: Abbey Road by The Beatles (borrowed by John Smith)
DVD: The Shawshank Redemption directed by Frank Darabont (0 min)
Book: Harry Potter and the Philosopher's Stone by J.K. Rowling (ISBN: 9780747532743)
