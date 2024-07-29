# <a href="https://learn.unity.com/tutorial/challenge-1-architecture-review">Challenge 1 - Architecture Review</a>                                                        <a href="https://unity.com/releases/2021-lts"> <img align="right" width="120" src="https://github.com/moha-b/VR/blob/Challenge-1-Architecture-Review/Assets/Challenges/01_Architecture/Readme%20Images/Unity.png" /> </a>   

In this task, we'll use the skills we learnt while creating our VR Room in an Architectural review app. With this prototype, the user may view a structure at a real-world scale, check a small 3D model and floor plan of that building, and even use a ruler to take measures while they look about.
- Open the broken architecture review prototype Scene:
    - From the Project window, expand, Assets > Challenges > 01_Architecture > Scenes
    - Double-click on the Architecture_Prototype_Broken Scene to open it.

- Begin working on the challenge tasks:
   - Work through the tasks outlined in the steps below.
   - If you want to push your skills, attempt the optional bonus challenge tasks, as well.
   - If you get stuck, there are hints for each task at the bottom of the page.

## challenge tasks 🔒
1.  The measuring stick and clipboard aren’t attaching properly to the left wrist.
      - The clipboard should be flipped around and the measuring stick should snap to the spot just to the left of the clipboard.

2.  The house model is snapping to the pedestal from very far away.
      - The house model should snap to the pedestal when you place it on top of the pedestal.

3.  You can currently snap the ruler and clipboard to the pedestal and the house model the left wrist.
      - You should only be able to put the house model on the pedestal, while the clipboard and measuring stick should only be able to snap to the wrist.

4.  The dining table is too tall. 
      - The table should be exactly 0.74 meters (or 29 inches) high.

5.  The teleportation anchor next to the pedestal puts the player upside-down and facing away from the pedestal.
      - Teleporting here should orient the player upright and towards the pedestal.


## Solution 🔓
### 1. The measuring stick and clipboard aren’t attaching properly to the left wrist. <img align="right" width="400" src="https://github.com/moha-b/VR/blob/Challenge-1-Architecture-Review/Assets/Challenges/01_Architecture/Readme%20Images/Socket_Measuring_Stick_Transform.png"/>
in your hierarchy select, XR Rig > LeftHand Controller > Socket_MeasuringStick > Attach 

you will notes that in the transform the position has a value, reset it to the default
1. right click on the `transform` component
2. select `reset` form the menu and we are done
**OR** 
you can do it manualy by set the x , y, and z value to 0
---

### 2. The house model is snapping to the pedestal from very far away.
in your hierarchy select,  Pedestal > Socket <img align="right" width="400" src="https://github.com/moha-b/VR/blob/Challenge-1-Architecture-Review/Assets/Challenges/01_Architecture/Readme%20Images/Pedestal_Socket_Sphere_Collider.png"/>

Here in the `Sphere Collider` Component the **Radius** is set to 2 which takes a large space to reduce the radius amount to any value u want but not too small you will find it hard to get the model back if u were to run this Challenge on the `XR Device Simulator`

---

### 3. You can currently snap the ruler and clipboard to the pedestal and the house model the left wrist.
in your hierarchy select,  Measuring Stick OR Clipboard  <img align="right" width="400" src="https://github.com/moha-b/VR/blob/Challenge-1-Architecture-Review/Assets/Challenges/01_Architecture/Readme%20Images/Clipboard_XR_Grab_Interactable.png"/>


Search for the `Interaction Layer Mask` as you can see it's set by default to **Everything** 

1. click on it (The drop-down menu) and select `Add New Layer` in the inspector you will navigate to `Interaction Layer Settings`.

2. add a new layer by typing the layer name in the first empty slot, now create our layer that will be only for the Measuring Stick and Clipboard.

3. go to Measuring Stick or Clipboard in the `Interaction Layer Mask`.

4. select **Nothing**(the drop-down menu) after that click again and select the new layer you have created. <img align="right" src=
"https://github.com/moha-b/VR/blob/Challenge-1-Architecture-Review/Assets/Challenges/01_Architecture/Readme%20Images/InteractionLayerSettings.png"/>

5. apply these changes on both objects the Measuring Stick and Clipboard do the exact same thing in step 4.

6. navigate to XR Rig > LeftHand Controller > Socket_Clipboard in `XR Socket Interactor` and apply step 4.

7. navigate to XR Rig > LeftHand Controller > Socket_MeasuringStick in `XR Socket Interactor` and apply step 4.

Now you can't hold anything with your left-hand controller except the objects that have the same layer with the `XR Socket Interactor` on your left-hand controller, after doing all 7 steps try and test it in your editor if you face any issues let me know by creating an [issues](https://github.com/moha-b/VR/issues) but first check the steps again.

---

### 4. The dining table is too tall. 
in your hierarchy select,  Table  <img align="right" width="300" src="https://github.com/moha-b/VR/blob/Challenge-1-Architecture-Review/Assets/Challenges/01_Architecture/Readme%20Images/Table.png"/>

you can Scale the whole object from `Transform` first Enable constraint property like the image below. Pick a good dimensions that is neither too big or too little for you.

 <img src="https://user-images.githubusercontent.com/73842931/226409742-06f253b2-9140-44c6-a627-57dc0f3f215b.png" />

### Another approach (how i did it).
In the `Table` object, you will find in it many child objects with names `Leg1` to `Leg4` and `Top` but no need for the **Top**. In `Leg1` go to the **Transform component** I change the y scale from whatever the value is to **1**. then do the same for other Leg objects. finally, after you do this you will find out that the `Top` object is **floating**, drag the `Top` object until it touches the Leg objects

---

### 5. The teleportation anchor next to the pedestal puts the player upside-down and facing away from the pedestal. 
In your hierarchy select, Teleportation Anchor  <img align="right" width="400" src="https://github.com/moha-b/VR/blob/Challenge-1-Architecture-Review/Assets/Challenges/01_Architecture/Readme%20Images/TeleportationAnchor.png"/>

- In the `Teleportation Anchor` Script under the **Teleportation Configuration** section look for 
**Match Orientation** you will find that it has a default value `Target Up` click on it (drop-down menu)
and select `Target Up And Forward`

- Navigate to `Anchor` object inside the `Teleportation Anchor` object **NOT THE SCRIPT** the object in the  hierarchy, then rotate it around the **y-axis** to the desired direction

<br />
<br />
<br />

<img align="left" width="50" height="50" src="https://user-images.githubusercontent.com/73842931/226426630-55bbdb41-429f-46ad-aecd-40643fe2ac72.png"> 

**IF YOU FACE ANY ISSUES, LET ME KNOW. [Create an Issue](https://github.com/moha-b/VR/issues)**    
