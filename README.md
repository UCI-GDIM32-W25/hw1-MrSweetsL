[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
How would you describe this game world in objects? What attributes and actions do these objects have? How do these objects act on or affect each other?
- Player - Bunny sprite
  - Press WASD to move the sprite.
  - Press Space so the Player Sprite plants seeds.
- Plant Sprites
  - When the Player presses space, a plant sprite appears from the player's location.
- UI
  - Seeds planted:
    - Counts and outputs the amount of plant sprites on screen.
  - Seeds remaining:
    - Counts and outputs the amount of plants remaining. 
- The player sprite interacts with Plant sprites through the space button.
- The number of plant sprites on the screen affects the output number in the UI.

## Devlog
So my coding breakdown wasn't too off the mark from Professor Reids during class. I got the ideas right and how the different codes interact with each other. However, Professor Reid's breakdown was like SUPER specific to like naming the public class and typing specific code stuff. I didn't do that for my notes because I couldn't remember all the stuff from the script but I think my first time breaking down code wasn't too bad since I at least got the ideas down. Next time, I'll try to be more specific by including code names and such. 

The way I connected my coding breakdown to my coding process was I did each function one at a time for one script at a time. For example, I started with the Player.cs script coding. The first thing I did from my break down list is the player sprites WASD movement. I should have specified in my breakdown that this is done with several if statements inside the private void Update() function. The next thing on the list was if the player pressed down on KeyCode.Space then call PlantSeed(); which then leads us to the public void PlantSeed() function and I should have mentioned that inside this function I need to use the instantiate code to create the plant prefab in my breakdown notes. 

The next thing I did was to make sure the UI score outputted the correct Text_SeedsPlantedNum and Text_SeedsRemainingNum which should have been mentioned in my breakdown for the UI. 

My Coding Process:

My biggest problem while coding was figuring out the public void PlantSeed() function. Specifically figuring out how to change the in-game score., Text_SeedsPlantedNum and Text_SeedsRemainingNum, when the player planted a seed which meant that they pressed down the space button.

Shout out to Professor Reid, Elijah, Liam, Vix, and Kevin for helping me figure it out. I learned that I needed to move my if(Input.GetKeyDown(KeyCode.Space)) if statement to private void Update() because PlantSeed() is purely made to only instantiate the plant seed prefab so that it shows up on the in-game screen. 

The next thing I had a problem was feeding the public void UpdateSeeds (int seedsLeft, int seedsPlanted) from PlantCountUI script the right information so that it shows the correct score in-game. At first, I tried using seedsLeft and seedsPlanted as the variables I wanted to change and feed into the plantCountUI.UpdateSeeds but it was wrong because seedsLeft and seedsPlanted do not exist inside the Player script. I needed to use _numSeedsLeft and _numSeedsPlanted since they already existed in the Player script.

Once I coded in _numSeedsLeft -= 1; and _numSeedsPlanted += 1; the Text_SeedsPlantedNum was working in the game scene but Text_SeedsRemainingNum wasn't. The reason was because I didn't set _numSeedsLeft = _numSeeds; in private void Start (). Finally, everything worked after fixing and adding the code. To make sure that the player can't plant anymore seeds, I added an if statement where the score can only change when _numSeedsPlanted <= 5. I did the same thing for PlantSeed() so that the plant prefab can only show up on the screen if there are already 5 existing in the screen. 

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
Thank you for clearly connecting the plan you wrote in your break-down to your code. Good job with this Devlog!

I do want to point out:

> The first thing I did from my break down list is the player sprites WASD movement. I should have specified in my breakdown that this is done with several if statements inside the private void Update() function.

You actually did your break-down correctly. When we write a high-level breakdown like our W1L2 activity, we don't need to talk about the details of our plan to code the project yet. I'll specifically call out (like we did for the W2L2 activity to break down HW2) when a break-down should talk about code.

Also, be careful in these Devlogs with talking about code that doesn't work. Our Devlogs this quarter are different than last quarter; we're focusing less on talking about a problem we solved, and instead answering a specific prompt. You did manage to answer the prompt for this Devlog, I just wanted to give you a heads-up for future Devlogs to make sure they're laser-focused on the prompt!

Please consider formatting your break-down activities with the hyphen '-' symbol as suggested above, and remove the prompts. Also, make sure to put your break-down in the appropriate section. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).
