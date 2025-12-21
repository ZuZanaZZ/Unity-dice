# Description
- Unity project 3D dice simulation. 
- The cube was modelled to look like dice. It rolls and tumbles upon pressing spacebar of left clicking. The scene can be reset by pressing x.
- The resulting value of the roll is displayed on the UI above the dice.
# Functionality
## Scene setup
- The scene includes grass coloured ground plane, simple lighting and a camera that is pointed at the dice.

<img width="1000" height="432" alt="image" src="https://github.com/user-attachments/assets/050f0172-6974-40d6-9be0-564e6097c9c5" />

## UI display
- The UI is made with world canvas positioned above the dice, following it as it rolls around.
- The UI includes:
	- Instructions displayed before the game is started.
	- Text that indicates that the dice is rolling.
	- The resulting value of the roll.
 
<img width="1000" height="221" alt="image" src="https://github.com/user-attachments/assets/3b98d819-1138-4be1-9c5e-84c9adfe8bf8" />
  
<img width="500" height="451" alt="image" src="https://github.com/user-attachments/assets/0787db72-0a3a-4488-af43-c19ad9cf962c" />
<br />
<img width="500" height="392" alt="image" src="https://github.com/user-attachments/assets/9c951a06-2e27-4efd-aa7e-a8ddf95b58e0" />

## Dice model
- The dice texture was drawn by me and modelled in Blender.
- The layout of the faces is as per standard: 1 is opposite of 6, 2 is opposite of 5 and 3 is opposite of 4.
- The faces of the dice are distinguished by using UV mapping.

<img width="300" height="269" alt="image" src="https://github.com/user-attachments/assets/dd0863ab-b188-4f12-b7a3-e74d85408ab2" />

## Rolling mechanic
- The forces and torque is applied either upon pressing the spacebar, or left clicking. The forces are varies between rolls, and there is a cooldown applied to prevent the spamming of the rolling mechanic.
- For collision detection, the Unity physics engine is used, together with the Rigidbody component of the dice.
- After the dice settles down after rolling, denoted by the velocity reaching 0, the detection of the result begins.

![DiceRolling](https://github.com/user-attachments/assets/8dd50ab3-f982-414d-94b4-ee8efe804ace)

## Face detection
- The face detections is implemented using raycasts.
- The face hitting the ground is identified, and the value of the opposite face is returned as the result of the roll. 
# Sources
## CameraFollow
- Smooth camera following the dice from: https://www.youtube.com/watch?v=MFQhpwc6cKE
- Vector comparison reference: https://discussions.unity.com/t/compare-vector3/136577/2
## DiceCollision
- WaitUntil from: https://stackoverflow.com/questions/30056471/how-to-make-the-script-wait-sleep-in-a-simple-way-in-unity
- Raycast explanation: https://www.youtube.com/watch?v=cUf7FnNqv7U
## DiceRoll
- Tutorial on the new input system: https://www.youtube.com/watch?v=qEtLamo_-_g
## DiceResetPosition
- Resetting rotation from: https://discussions.unity.com/t/help-with-setting-rotation-to-0-0-0/58413
## TextUI
- Camera initialization example: https://www.youtube.com/watch?v=Fw3uQmx-46M
