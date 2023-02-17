# TitanHelpApp
Your final project will be a group programming project.The instructions are as follows:

Group Programming Project


Everyone in the group is required to provide the code for a particular layer. One group member should do the presentation layer code, one should do the domain layer code and one should do the data access layer code. They can get help from other members of the team if necessary, but the majority of the work should be theirs. This will be very important in determining your final grade, so make sure that you participate in the project. We will be using Github for this project so I will be able to see the contributions each team member has made to the project.


The Project

Complete the following TitanHelp Application:

The program should display an interface to the user that displays all help desk tickets. When the program starts there should be no tickets. Add a "Create Ticket" button that when clicked, displays a form to enter a new Help Desk Ticket. The form should have the following fields:

Name
Date
Problem Desciption
The form should have a save button. When clicked the application layer should create an Instance of a Ticket object and store the Ticket in a database. The UI should now display the new Ticket item in the main Tickets page. The application should use frameworks at the necessary layers For example, if you are using .net, you should have the following:

Presentation Layer – Razor or Asp.net MVC or WPF

Application Layer –   A Ticket class as a POCO

Data Access Layer – Entity Framework.

Bonus Points for using the following:


DI 5 pts
Unit Tests 5 pts
REST 5 pts
