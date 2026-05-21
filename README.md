# GDIM 33 In-Class Activities
## W1
### Activity 1

1. [Drawing of Inspirations](https://docs.google.com/drawings/d/1pbu8YMQbX8sjMdfPu9fKgFeI2y3iZbUQsjBBI4HWDZo/edit?usp=sharing)

All the games seem to be action games, and I really like the lightsaber fights, thus maybe I should make a pure sword fight game.

2. Peer: Zhengfan Yang, he also plays gacha games, gacha game god

3. LA: Elijah, he also play death stranding.



### Activity 2

<img width="1466" height="1134" alt="image" src="https://github.com/user-attachments/assets/d615b755-a6a9-473f-a5d8-9617aefa87c5" />




## W3

### Activity 1
<img width="1767" height="1010" alt="image" src="https://github.com/user-attachments/assets/d148aa6e-052d-4152-a949-c803f59eb6a8" />

### Activity 2

1. You don't have to memorize the name of the custom event name.

2. The debug.log on the transition nodes like from exploring to dialog mode can clearly tell you if the custom event has triggered. This can help you identify if it's the transition's fault if the custom event failed to trigger or it's the event's fault by adding one debug.log behind each of the custom event and after the custom event trigger.

3. I think not. Since I'm doing a fixed camera position, the mouse movement does no effect on the game. I can even show the mouse and make the mouse more use, like clicking on a near by object instead of pressing E to interact.

4. It is relavent. There will be two game states, one is explore/ action or whatever you call it, basically the player can move around the scene. The other state should be UI only, like when interacted with terminals, the game pauses and the player can take their time to choose the items. The cursor will also show up.

## W4

### Activity 1

1.
Currently, the player can move inside the scene and open unlocked doors to switch to new scenes. The player can also kite the zombie but not attacking it in the combat scene.
  
My Goal is to test if the players are able to be used to the inverse in input when switching camera locations. (some camera locations will have a normal wsad input, other places where the camera is facing the player will have inversed input.

2.
Playtest team mamber: Allen Gu, Haoyi Zhang, Zhengfan Yang, Yaokun Wan, Pengcheng Qi(me)

3.
Notes from results of Zhengfan Yang, Yaokun Wan, and Haoyi Zhang: All three mentioned that the only issue is still the abrupt change in camera and input direction. Especially for the horizontal inputs a and d, it's hard to adapt to the change in directions. For the other aspects, there are no negative feedbacks.

### Activity 2

1. No they don't, since the writer only have to create new scriptable objects to design new dialog and their replies.
2. There will be huge amounts of new scriptable objects created when the dialog number increase. Also, a dialog can only have 4 replies total.
3. After writing methods in scripts, the nodes in visual scripting isn't updated, so that when searching for that new method when clicking right mouse button nothing appears. When regenerating nodes, the methods will be considered into the visual scripting thing and you'd be able to search and use them in the graph.

Extra Credit: Added Images for each choice.

<img width="2082" height="801" alt="image" src="https://github.com/user-attachments/assets/d0becd06-b709-46f5-ac62-974f2716c1db" />

## W5

### Activity 1

Step1: Use Animation to make the key unlock animation

​	Substep1: Add a new animation

​	Substep2: Drag the position and rotation in the timeline

​	Substep3: Add keyframes

Step2: Create an animator for this key

​	Substep1: Add New Animator

​	Substep2: Add an empty state as default and the new animation made with a trigger transition

Step3: use script to make the key animation play when unlocking

​	Substep1: add the method for playing the animation

​	Substep2: make the key become visible -> play animation -> key become invisible

​	Substep3: call the method on the point when unlocking the door

### Activity 2

Step 1 and 2 completed, but didn't make the door unlock mechanics.

## W6

### Activity 1

1. The build contains logic for picking up objects, but they can only be opened via debug keys yet.
2. [link to itch page](https://wolffielotsecond.itch.io/gdim33-vertical-slice-demo-02)
3. playtest goals: See how people think about the effectiveness of the UI and animations.
4. Playtest Notes: Player thinks the animation is okay. Only feedback is still on the transitions between controlls when camera positions change.

### Activity 2

1. All of the color values are between 0f and 1f, making the result always smaller or equal to the original
2. More translucent, since the values are also between 0 and 1, making the result smaller than the original
3. The vertex data from the mesh, since the UV coordinates are stored in them
4. No. I've already done this in Unreal before

## W7

1. The data came from the mesh, where each vertex in the mesh stores color attributes.
2. GPU interpolates the vertex color data across the surface during rendering.
3. Vertex color is only stored per vertex, but textures stores color per pixel. It's useful for AO baking, LOD coloration, and vertex painting masks, or rendering objects in the distance to save performance.
4. Some dark parts of the model have a incorrect normal/ inverted normal.
5. We can use it to check for stretching or seams, this can validate the mapping of textures.
6. The light direction and surface normal are pointing toward to each other, thus producing a negative dot product instead of positive as it should be.
7. Additive blend mode makes the noise texture visible instead of transparant.

## W8

### Activity 1

1. A bug on interacting the door and the camera stucks on it
2. Interaction prompt should add the name of the key to press
3. Make the doors more visible on the second floor
4. Add VFX to pick-up-ables to notify the player
5. Bad walking orientation
6. Zombie hit feedback (damage reaction)

### Activity 2

1. The normal Shiba gets drawn first in the StencilWritePass. That pass uses Compare Function = Always and Pass = Replace, so wherever the real Shiba appears, it writes stencil value 1. Then the enlarged Outline pass uses Compare Function = Not Equal with value 1, meaning it only draws where the stencil is not already 1. So the outline cannot draw over the original Shiba; it only appears around the outside. Fail/ZFail stay Keep, so failed pixels do not change the stencil.
2. The Shiba is being drawn almost twice, once in the StencilWritePass before opaques, and again in the regular opaque pass. The stencil pass is mainly there to write stencil information, but because Override Mode is None, it still draws the Shiba normally with its material while also writing to the stencil. That is why the Frame Debugger shows very similar Shiba draws happening twice.
3. The cel shader splits the material into 2 sections, the lit and the shadow. To combine them, we should use add (since black regions are literally 0 and when we add things there, it will replace all the dark regions.)
4. The Outline Renderer Feature’s Layer Mask is set to only draw objects on the Outline layer. So when the Shiba is moved onto the Outline layer, the outline pass includes it. When it is moved back to Default, the outline pass ignores it.
