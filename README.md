[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!

W1 L2 In Class Notes:

How would you describe this game world in objects? What attributes and actions do these objects have? How do these objects act on or affect each other?

  Player - Bunny sprite
  
    Press WASD to move the sprite.
    
    Press Space so the Player Sprite plants seeds.
    
  Plant Sprites
  
    When the Player presses space, a plant sprite appears from the player's location.
    
  UI
  
    Seeds planted:
    
      Counts and outputs the amount of plant sprites on screen.
      
    Seeds remaining:
    
      Counts and outputs the amount of plants remaining. 
      
  The player sprite interacts with Plant sprites through the space button.
  
  The number of plant sprites on the screen affects the output number in the UI.

My Coding Process:

My biggest problem while coding was figuring out the public void PlantSeed() function. Specifically figuring out how to change the in game score., Text_SeedsPlantedNum and Text_SeedsRemainingNum, when the player planted a seed which meant that they pressed down the space button.

Shout out to Professor Reid, Elijah, Liam, Vix, and Kevin for helping me figure it out. I learned that I needed to move my if(Input.GetKeyDown(KeyCode.Space)) if statement to private void Update() because PlantSeed() is purely made to only instantiate the plant seed prefab so that it shows up on the in-game screen. 

The next thing I had a problem was feeding the public void UpdateSeeds (int seedsLeft, int seedsPlanted) from PlantCountUI script the right information so that it shows the correct score in-game. At first I tried using seedsLeft and seedsPlanted as the variable I wanted to change and feed into the plantCountUI.UpdateSeeds but it was wrong because seedsLeft and seedsPlanted does not exist inside the Player script. I needed to use _numSeedsLeft and _numSeedsPlanted since they already existed in the Player script.

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites
