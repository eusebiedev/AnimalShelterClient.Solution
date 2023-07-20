# Animal Shelter MVC Client Front End

### By Eusebie Siebenberg

## Description

An MVC Client front end application which consumes the Animal Shelter API, linked below in the installation requirements section. This application was built as part of the further exploration objective related to my independent code review project: Build a custom API for a local animal shelter to list available cats and dogs, using C#/.NET technologies, with full CRUD functionality.

## Technologies Used

* C#
* .NET 6
* ASP.NET Core
* Newtonsoft.Json
* Entity Framework Core
* Pomelo Entity Framework Core
* EF Core Migrations
* RestSharp
* MySQL
* Javascript
* Jquery
* HTML

## MCV Client Front End Setup/Installation Requirements

To use the MVC Client front end website, you must run both AnimalShelterApi & AnimalShelterClient together:

1. After following the instructions for cloning and opening the AnimalShelterApi here:
https://github.com/eusebiedev/AnimalShelterApi.Solution
2. Open your shell of choice (e.g., Terminal or GitBash) and run these commands in order:
3. Clone this client repository to any other directory using $ `git clone https://github.com/eusebiedev/AnimalShelterClient.Solution.git`
4. Open both projects separately in your IDE of choice
5. Navigate to the **API** project directory with $ `cd AnimalShelterApi`
5. First start the API with $ `dotnet run`
6. Navigate to the **CLIENT** project directory with $ `cd AnimalShelterClient`
7. Now start the Client Front End with $ `dotnet watch run`
8. Interact with the Animal database, viewing, editing, deleting and creating animals

## Known Bugs as of 6/9/23

Occassionally user has to click the CRUD buttons twice to have changes take effect. Or refresh the browser after making changes to the database

## [MIT](https://opensource.org/license/mit/) License 

Copyright © 2023 Eusebie Siebenberg

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

If you have any questions, comments, or concerns, please reach out to me at: siebenee@gmail.com
