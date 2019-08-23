# Park Finder Wep App
### By Rochelle Roberts
-----

## Description
* Park Finder uses my custom ParksAPI to display parks in Washington. 

## Technologies Used
* C#/.NET
* ASP.NET Core Web App MVC
* HTML
* MySQL
* Entity

## Installation
* Follow the following steps using the terminal
* After running project, go to http://localhost:5000

```sh
$ git clone https://github.com/rochellev/ParksAPI.git
$ cd ParksAPI
$ dotnet restore
$ dotnet ef database update
$ dotnet run
```

## API Features
* Full CRUD functionality
  * Developed Create, Read, Update, Delete endpoints
* MySQL Database
  * Parks Table
  * Data containing a park's name, state or national status, and city
  * Migrations used to maintain the tables
* Swagger
  * Provides clear documentation of the endpoints of the ParksAPI
  * https://localhost:5001/swagger/index.html
  * JSON Schema in swagger.json 
  <!-- * NSwagStudio to generate client code  -->

## Working on 
* working on using nswag --- oh boy!

* nevermind! I thought it would create models and views for me.. so moving on to make a MVC client side app to use my Parks api