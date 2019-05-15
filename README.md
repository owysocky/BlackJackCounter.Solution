# _BlackJack counter_

#### _05/10/2019_

#### By _**Olha Wysocky**_

## Description

_This is a web application that helps players of blackjack to count the chances of winning and suggest how much should they bet._

## Known Bugs

_No known bugs._

## Specs

- _Each card has an assigned value._
  - _2 through 6 is +1_
  - _7 through 9 is 0_
  - _10 through Ace is -1_
- _Keep total Running count_
- _Calculate true count: Running count/decks remaining_
  - _Standard blackjack has 6 decks_
- _Subtract cards to keep track of how many decks are left_
- _Raise bets when true count raises_

## Installation Requirements

- _Download and install .NET Core 1.1.4 SDK._
- _Download and install .NET Core Runtime 1.1.2_
- _Download and install Mono_
- _Download and install MAMP_

## Setup instructions

- _On GitHub, navigate to the main page of the repository._
- _On the right find the green button "Clone or download", click it._
- _To clone the repository in Desktop choose "Open in Desktop" or download the ZIP file._
- _For more information, see "Cloning a repository from GitHub to GitHub Desktop."_

* _Change into the work directory: \$ cd Blackj.Solution._
* _To run the program, first navigate to the Blackj folder then compile and execute: $ dotnet restore, $ dotnet build, dotnet run._
* _In the browser go to the link http://localhost:5000/, enjoy._
* _To run the tests, novigate the folder Blackj.Tests and use these commands: $ dotnet restore $ dotnet test._

## Technologies Used

- _C#_

### License

MIT

Copyright (c) 2019 **_Olha Wysocky_**
