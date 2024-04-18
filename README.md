# SplitTheBill
=============================================================================
                          Bill Splitting and Tip Calculating Application Guide
=============================================================================

Developer Information:
-----------------------
Name: Avinash Nagaiah
Student ID: A00227141

=============================================================================

Application Overview:
----------------------
The Bill Splitting and Tip Calculating Application provides functionality to evenly split bills and calculate individual tips based on meal costs and a designated tip percentage. It supports calculations for splitting the total bill among any number of patrons and computing tips either as a percentage of the total bill or weighted by individual contributions.

=============================================================================

Technologies Used:
-------------------
- .NET Core 8.0: Framework used for the application.
- C#: Programming language.
- MSTest: Used for unit testing the application functionalities.

=============================================================================

Getting Started in GitHub Codespaces:
---------------------------------------
1. Navigate to the GitHub repository in your browser.
2. Click on the "Code" button and select "Open with Codespaces".
3. Choose to open an existing codespace or create a new one if none exists.

Running the Application:
-------------------------
1. Open the integrated terminal by selecting Terminal > New Terminal from the menu.
2. Navigate to the project directory:
    cd SplitTheBillSolution
3. Build the solution:
    dotnet build
4. Run tests to ensure functionality:
    dotnet test

Example Usage and Output:
---------------------------
Welcome to the Bill Splitting and Tip Calculating Application
Please enter the total bill amount and the number of patrons:
Enter the total bill: 200
Enter the number of patrons: 4
Each person should pay: 50

Please enter individual meal costs and desired tip percentage:
Enter meal cost for Alice: 50
Enter meal cost for Bob: 100
Enter meal cost for Charlie: 50
Enter tip percentage: 10
Tip amounts: Alice - 5, Bob - 10, Charlie - 5

=============================================================================

