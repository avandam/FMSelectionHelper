# FMSelectionHelper
Simple tool to help select your team in FM22. By importing a rtf file with your selection, using a tactic you can see the scores for players on that position. 

For now stuff is quite hardcoded: A specific tactic is used, where the roles are filled in specifically. 

TODO:

 - Create possibility to create your own tactic by selection positions and roles

## Instructions for use
First prepare FM for use:

- Import file "FM Files\ForExportFull.fmf": 
	- Go to Squad
	- In the Selection info drop down select Custom -> Import View
	- Select the ForExportFull.fmf file

Create the file to use in the tool:

- Go to Squad
- Select the ForExportFull view
- In the Filter, select all the players to include (senior, B team, U18)
- Click the FM logo in the top right
- Select Print Screen
- Select Text File and Ok
- Save the file somewhere on your file system

Then to create the player score list, start the tool, Click "Load Squad" and select the file you created. 

The results can be sorted per position.

## Formations
It is possible to create multiple formations that can be used with the tool. To create a formation:
- Start the tool and click the "Add Formation" button. 
- For each position select the position and the role for that position. 
- Fill in a name for the formation
- Click save

The formation is now saved in the directory of the tool as <Name>.for

When the tool is started, the directory is scanned for .for files and they are loaded in the combobox. When no formation files are found, a default (based on the tactic in FMFiles) is used.
To use a formation, first select a formation from the dropdown and then load the squad. When you want to check a new formation, first select the formation and then load the file again.