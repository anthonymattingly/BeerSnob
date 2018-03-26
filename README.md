# BeerSnob
BeerSnob is an ASP.NET MVC web application that craft beer lovers can use to log new brews that they have sampled
along with information about the beer.
Entity Framework is used in conjunction with SQL Server localdb.

To run the application open the solution in Visual Studio.  The application will connect to localdb through Visual Studio.  In order to seed the database you must run the "update-database" command in the NuGet Package Manager console.  Seed data is neccessary in order for CRUD operations to work properly, otherwise the user will only be able to navigate views. At the home view scroll completely to the bottom of the page to view all page content.
