# UNITY
Here are some important tips and tricks collected along the way that I learned Unity.

## Shortcuts

* Maximize to Game View: Shift + Space
* Duplicate: Ctrl + D
* Play mode: Ctrl + P

## Some Important Points
* Time.deltatime is the amount time since the computer drew the last frame, kind off balances out the differences in FPS in different systems.
* If you are using Physics - Adding forces and changing velocities then do it in **FixedUpdate**
* Making the camera follow the player can be done in multiple ways:
	* First and obvious way is to parent the camera to the object/player, unity allows us to nest game objects. Drag and drop on the player object. Problem with this is that if we rotate the player then even the camera rotates.
	* Use Script to follow only player.
* Prefabs are used whenver you want multiple objects of same type. You just drag the object into your project to create a prefab.
* For some reason full screen on play does not work, however if you select *maximize on play* it works absolutely fine.
* A canvas is a place where we can display all our UI elements.