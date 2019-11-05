# Sonic_R_Final
Naming Conventions:
All assets should be named with a descriptive 3 letter tag at the front. Scripts and folders can be omitted from this naming convention and should be named something descriptive e.g. GameManager.

For searchability follow this convention for all non scripts and non folders:
- Materials - MAT_Example
- Shader - SDR_Example
- Prefab - PFB_Example
- Stage - STG_Example
- Sprite - SPR_Example
- PNG - PNG_Example
- WAV - WAV_Example

If there are any filetypes not mentioned above, add them above to maintain consistency.


File Locations:
All prefabs should be within the prefab folder with a matching folder that contains all their dependencies (scripts, art, sound, etc.). Organization within the folder is up to you. 

All generic scripts should be within the scripts folder, although if you feel like a subfolder would help, add one.

All music should be found within the audio folder. For sound effects, if they belong to a prefab, make sure they are in the folder associated with the prefab.

All generic images should go into the images folder, however if the image belongs to a specific prefab, make sure it is in the folder associated with the prefab.

Prototyping:
We will maintain one scene for each of us to prototype major changes and one main scene which the game will be run on.

Unity Code:
Functions should have a descriptor that describes what the function does, outputs, and takes in as input. This can be ignored for simple functions like getters and setters.

Code should be legible and easy to follow. If any lines of code are difficult to conceptualize, add a comment explaining it. 

Github:
Make sure you commit often. Commit messages should be in the following form:
<verb> <message>
e.g.
Created GameManger script

