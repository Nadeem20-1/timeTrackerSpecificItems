How to install:

1. Replace old TabletController.cs with this new version (only update is new variable).
2. Install TimeTracker.prefab into existing world.
3. Drag the appropriate Texts to fill in the public variables:

Stopwatch.cs:
Ctscan Time Text = Room (Text)
Mri Time Text = Room(1) (Text)
Or Time Text = Room(2) (Text)
Radiology Time Text = Room(3) (Text)
Ultrasound Time Text = Room(4) (Text)
Current Room = currentRoom (Text)

TabletController.cs:
Current Room = currentRoom (Text)
