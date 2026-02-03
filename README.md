# HW4
## Devlog
### Prompts 1:
Here is how the model view controller is used in this project in order to keep the player code decoupled from other systems. This minigame mostly deals with the view and controller aspect. The code is decoupled through the use of a singleton and an event. The view subscribes to the controllers events and reacts to its changes. The gamecontroller class is responsible for the controller part because it contains the signelton and the place where the event is raised. My audio and ui script are responsible for the view part becuase they subscribe to the the event and play sounds and update the ui depending on if a point was scored.
### Prompt 2:
To explain, I decided to put my singleton in the gamecontroller script. I decided to do this because I wanted the pure logic of the points to be handle here, for organization purposes rather than the player script. Also, my game controller is repsonsible for allocating points to when the player passes through. This also insures that the game logic and asethics are in seperate scripts and that the logic is affecting the aesthetics and not vice versa. This singleton in my script allows me to acess different systems in the game without creating multiple methods for it. This also makes it decoupled. 

I acutally raised 2 events in my script. The first event I raisde was in the AddPoints() method in which if the points update it would subsrcibe to the HandlePoints() in the Ui script (put in start of that script). The HandlePoints method just updated the text. The same event suscribes to HandlePoints in the audio script that plays the audio for scoring a point. This event takes in the parameter of points to make super the ui and audio is updating from the points.

My second event deals is when the player collides with the pipe to let the audio system under HandleEndgame() to know to play the loosing audio. I decided to do an event for this so I didn't have so many methods and to ensure my audio system was decoupled. In Using the event, I can insure that code file and pattern is easy to read and understand.

## Open-Source Assets
If you added any other assets, list them here!
- [Brackey's Platformer Bundle](https://brackeysgames.itch.io/brackeys-platformer-bundle) - sound effects
- [2D pixel art seagull sprites](https://elthen.itch.io/2d-pixel-art-seagull-sprites) - seagull sprites
