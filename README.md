# (Pierre's Bakery)

#### (An introduction to C# namespaces, MSTesting TDD for C# and basic console applications in this format)

#### By (Christopher Ross Davila)

## Technologies Used

* _C# 10 _
* _MSTest_
* _GitHub_
*_.Net SDK 6_
* _ASP.NET Core MVC 6_


## Description
* This is an application that serves as an introduction to C# concepts such as namespaces, classes and field constructors. It also follows best TDD practices and a RGR workflow to test each part of the business logic. This console application acts as a order form for a fictitious digital storefront called Pierre's Bakery.  Pierres Bakery has two types of items for sale, Bread and Pastry.  The cost for Bread is five dollars per loaf and the pastries are two dollars per pastry.  Using math equations and branching logic the user is able to take advantage of a deal for both items that offers them buy two get one free for bread and buy three get one free for pastries.  When running the console application, the user will be prompted with a decision to either buy bread, pastry or both.  Based on the users choice they will then be prompted to enter the amount of bread and/or pastries desired.  The application will then calculate the cost for bread, pastries and/or both items and print to the screen the resulting cost associated with the desired purchase.  This will automatically end the program after a goodbye message

## Setup/Installation Requirements

* _1. Clone this repo._
* _2. Open your terminal (e.g., Terminal or GitBash) and navigate to this project's production directory called "PerresBakery"._
* _3. In the command line, run the command "dotnet run" to compile and execute the console application. Since this is a console application, you'll interact with it through text commands in your terminal._
* _4. Once the program is running it will give instructions on how to choose which item(s) to purchase and based items chosen will ask the user to enter an integer for each or one item._
* _5. Simply type each number and hit enter and the program will automatically give you a respose for total cost and cost of type of item.
* _6. The program will then give a farewell message and exit. To rerun the program simply repeat from step 3._

## Known Bugs

* _No error handling set up yet for incorrect responses to yes or no questions or not entering a whole number of one or greater_
* _special characters will give no response, the user must type in the response exactly how it is prompted_
* _Application is not set up to run multiple times without using dotnet run_

## License
[MIT](https://github.com/ChrisRDavila/Pierres_Bakery.Solution/blob/main/License.txt)