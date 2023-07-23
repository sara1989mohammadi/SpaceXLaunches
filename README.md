# SpaceX Launches
Sample app for getting all the launches SpaceX and details them.

This project was bootstrapped with [Create React App](https://github.com/facebook/create-react-app).

And also use [ASP.NET Core](https://github.com/dotnet/aspnetcore) for the backend.

Support three versions of .NET:

- [.NET 6](https://github.com/ivanpaulovich/clean-architecture-manga/tree/main) - .NET 6.

## Description
For BackEnd, I used Clean Architecture.
This project has 4 Domain layers:
- Domain
- Persistence
- Application
- API

The domain layer has entities of the project.<br/>
In Persistence I implementation of connect to the database with [EF Core](https://github.com/dotnet/efcore).<br/>
The application has logic for our project.<br/>
API is an endpoint of our application because our frontend project is a react application and I need to connect the backend to the frontend.<br/>

For test BachEnd, I mock the return data from Repositories and use the [Moq](https://github.com/moq/moq) library.

In the FrontEnd project a few components need to use state and Launches list one of the best practices is a [React ContextAPI](https://legacy.reactjs.org/docs/context.html) and use it.<br/>
For Unit test components of frontend, I use [Jest](https://github.com/jestjs/jest) and [React Testing Library](https://github.com/testing-library/react-testing-library) for mocking state and ContextAPI.

## Database

The template is configured to use [EF Core In-Memory Database](https://learn.microsoft.com/en-us/ef/core/providers/in-memory/?tabs=dotnet-core-cli) by default. If you would prefer to use SQL Server you can change the provide in Program.cs and change it to UseSqlServer. for create the database you should change the NotMaped Columns to JSON Columns please see this [Link](https://learn.microsoft.com/en-us/ef/core/what-is-new/ef-core-7.0/whatsnew#json-columns).

## 🔧Technologies
![React](https://camo.githubusercontent.com/9f73cc3ca53f4f6ba2bd3db11812f4f0b63e9ea1/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f52656163742532302d2532333631444146422e7376673f267374796c653d666f722d7468652d6261646765266c6f676f3d5265616374266c6f676f436f6c6f723d7768697465?ref=morioh.com&utm_source=morioh.com)&nbsp;
![.NET](https://camo.githubusercontent.com/a8ea388e7c27e30cf73230acff28209c1f2a6d72/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f2e4e45542532302d2532333543324439312e7376673f267374796c653d666f722d7468652d6261646765266c6f676f3d2e4e4554266c6f676f436f6c6f723d7768697465?ref=morioh.com&utm_source=morioh.com)&nbsp;
![Tailwind CSS](https://camo.githubusercontent.com/0756d4e6bfe73bddb650dc6de8aa0f8811caaac8/68747470733a2f2f696d672e736869656c64732e696f2f62616467652f5461696c77696e645f4353532532302d2532333338423241432e7376673f267374796c653d666f722d7468652d6261646765266c6f676f3d5461696c77696e64253230435353266c6f676f436f6c6f723d7768697465?ref=morioh.com&utm_source=morioh.com)


## Stack

- Create React App
- React ContextAPI
- Tailwind CSS
- ASP.NET Core
- EF Core

Quick Start
-----------

```shell
$ git clone https://github.com/sara1989mohammadi/SpaceXLaunches.git
$ cd /FrontEnd/spacex-launches
$ npm install
$ npm start
$ cd /BackEnd/SpaceXLaunche
$ dotnet restore
$ dotnet run 
```

Also, you open the BackEnd project with Visual Studio you don't need todo anything

Run Test
-----------

```shell
$ cd /FrontEnd/spacex-launches
$ npm test
$ cd /BackEnd/SpaceXLaunche
$ dotnet test
```

If you open the test Project you can run it with Test in the menu

## Learn More

You can learn more in the [Create React App documentation](https://facebook.github.io/create-react-app/docs/getting-started).

The following sections are recommended:

- [Code Splitting](https://facebook.github.io/create-react-app/docs/code-splitting)
- [Tutorial react hooks](https://reactjs.org/docs/hooks-intro.html)
- [React ContextAPI](https://legacy.reactjs.org/docs/context.html)
- [React Testing Library](https://github.com/testing-library/react-testing-library)

