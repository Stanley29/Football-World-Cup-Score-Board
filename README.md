Application consist of three parts:
1.FootballWorldCupLibrary - class library for processing of all actions.
2.ScoreBoard - Console Appllication, contains simple GUI 
3.WorldCupLibraryTestProject - testing project for FootballWorldCupLibrary testing with unit tests

1.FootballWorldCupLibrary
It contains the following main components.
1.1 WorldCupManager
It is main processing unit, it process the following actions:
1)Init Summary - fill the list with Games with certain initial values (team names and scores).
2)Update Score - the method simulate the sending of the current Game scores from Partners.
Actually, the method generate the random values in range of 0 to 10.
3)Finish Game - the method saves the final Game score to total score list.

1.2.Menu
The class contains the main logic for the Console GUI processing

1.3.GameMenu
The class contains the logic for the Console sub GUI processing for support of exact game

1.4.MainMenu
The class is necessary for realization of the DIP principle of SOLID for the Menu and GameMenu

1.5.Game
The class realize the main processing unit, i.e. it is Game with teams names and teams scores.

2.ScoreBoard
This module realize the simple console GUI
2.1.When the application started, user has three options:
1)Start Game - user should input 1 and press Enter, when the option is chosen the Game sub Menu will be open (defined in next chapter 2.2)
2)Get a summary of games by total score - user should input 2 and press Enter, when choose this option the current games list with current scroes will be indicated.
3)Exit - user should input 6 and press Enter, when choose this option the application will be closed

2.2 Game started.
When user chosen the option Start Game (i.e. pressed 1 as in the chapter 2.1) from the chapter above, new sub menu will be displayed.
It is Game submenu with 4 options:
1)Start Game - user should input 1 and press Enter, when choose this option input menu will be open.
User should input Home Team name and Away Team name. Initial score as  0- 0 will be indicated.
After this step the Game is considered as Started.
2) Update score - user should input 2 and press Enter, when choose the option, user can get current game scores from the FootballWorldCupLibrary.
During the Game user can use the Update Score method several time, each time the scores will be updated.
3)Finish Game - user should input 3 and press Enter, when choose the option user can make the Game finish.
After the option chosen - the final scores will be indicated and the Game statistic (team names and related scores) will be stored in the list of total scores.
After the option user should let the Game sub menu with option 6 - Exit to Main Menu
4) Exit to Main Menu - user should input 6 and press Enter, with this option user will be returned to the main menu.

