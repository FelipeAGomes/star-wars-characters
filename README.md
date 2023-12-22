# Star Wars Characters

# Introduction
Welcome to the Star Wars Character - Back-End, the server-side component of our [Web application](https://github.com/FelipeAGomes/star-wars-characters-web). This back-end is powered by .NET Core and is responsible for seamlessly interfacing with the Star Wars API,
providing data to the front-end. This application enables character listing, and dynamic character search within the vast Star Wars universe.

# Features
Character Listing
The main page displays a paginated list of Star Wars characters. Pagination allows you to navigate through multiple pages of characters.

## Character Details
Clicking on a character from the list displays a detailed page with more in-depth information about the character.

## Name Search
The search bar allows you to search for characters by name. The search is dynamic, returning results as you type. If the full name is not entered, the API will return all characters that contain the entered substring.

# Technologies Used
## Back-End
- #### .NET 7.0

## Front-End
- #### Vue.js 3
- #### Quasar Framework
- #### [Web Application](https://github.com/FelipeAGomes/star-wars-characters-web)

## API
- #### [Star Wars API](https://swapi.dev/)

# Project setup

## Make sure you have the .NET SDK installed on your system. Then, run the following commands in the terminal:

1. Open a terminal and navigate to the "StarWarsCharacters" directory:
   
   ```bash
   cd path/to/StarWarsCharacters

3. Restore dependencies:

   ```bash
   dotnet restore

5. Start the server:

    ```bash
   dotnet run
The back-end server will be accessible at http://localhost:7160.

For more details on the front-end setup,[Web Application](https://github.com/FelipeAGomes/star-wars-characters-web).
