# Devlog

### 12/4/2024 - Game description and to-do

- Game: Krillin Ball
- Description:   You are Krillin from Dragon Ball. You spawn on a platform that tilts in every direction. 
                On the platform lies the seven Dragon Balls on it that Krillin will need to collect. 
                The way you move Krillin around is by tilting the platform and letting Krillin roll. 
                Make sure to avoid the holes though, or else you will fall straight into Hell. 
                Collect all seven Dragon Balls!
- To do:
- Figure out how to attach Dragon Balls to platform without having them fall due to gravity
    - Attach it to the platform in hierarchy
    - Set kinematic

### 12/5/2024 - Updated game description and to-do
- Description:    You are Krillin from Dragon Ball. You spawn in a maze that tilts in every direction. 
                Scattered throughtout the maze are the seven Dragon Balls. You can only move throughtout
                the maze by tilting the maze and letting yourself roll. Your main objective is to escape
                this maze with all the Dragon Balls before time runs out. If you don't collect all seven 
                Dragon Balls before you reach the exit, you lose. Plan accordingly!

- To do:
- Figure out how to make Krillin not bounce when the platform rotates quickly
    - Change the way we rotate the platform
    - Originally we wanted to use the flight simulator controls to tilt the platform but we realized this was 
  not efficient
- Implement scoring (D)
- Build two mazes (L)
- Implement pause screen (D)
- Implement level changes (L)
- Implement glow when Krillin obtains Dragon Ball (L)
- Implement sounds
    - Rolling sound (in general when Krillin is rolling)
    - Obtain Dragon Ball sound
    - Win sound

### 12/6/2024 - 
- Implemented scoring system for all three mazes
- Implemented collision detection for Dragon Balls

### 12/7/2024
- Added menus that display in between completion of a level and loading of the next.
    - These menus give the player the option of either starting from the first level or progressing to the next level.
- Restructured functionality for displaying pause, start, and transition menus.
- Added instructions menu
    - Added functionality to where pause and instructions do not overlap with each other when they are both active
- Removed instructions menu
    - Added instructions to pause menu to simplify user experience
- Added background music