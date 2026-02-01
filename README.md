# HW4
## Devlog
The MVC pattern separates the data and input processing aspect of the Player object from the display that shows certain information about the player & game state. The player holds data about the amount of points it currently possesses, and detects the space key input to apply an upward force to the player. Whenever the player scores a point, it invokes an event OnPlayerScore, and whenever the player hits an obstacle, the script invokes the event OnPlayerDeath. The player doesn't care what methods are subscribed to the events, it simply invokes the event, which decouples the code so that changing one functionality doesn't affect the other. In this MG4, we subscribe the UpdateScore() method from the UI script to OnPlayerScore, and ShowGameOverPanel() method from the UI script to OnPlayerDeath, via the singleton instance GameController, which enabled this the decoupling of the code as described earlier. The Player class serves both the purpose of the model (score data) and the controller (receive input), while the UI class serves the purpose of the view, since it updates and displays correct data to the actual players of this game. 

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
