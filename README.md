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
- Use the "FM Files\4231 example tactic.fmf" as your formation

In the Formation class a different Formation can be created. In the future this will be interactive in the application.

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