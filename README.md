# ZombieCamoList

Basic camo tracker for MW3 COD Zombies. Challenges and Levels are geared toward unlocking "Gold Enigma", which is the first step to unlocking the mastery camo grind.

All mastery camo challeges are the same for every weapon, so they are not documented in the app. The tracker reads from a text file, and updates a list box of every class of weapon. 
users can then click on a weapon to see the challenges, levels, and camos unclocked for each weapon. There is also a progress tracker that reads froma file and updates values based on
number of checkboxes, checked for each completed gun. Project is a great way to keep track of your progress locally, as this can be a very long process and the in-game
UI, is clunky and hard to keep track of in my opinion.

## Setup

Grab the 'progress.txt' file from the data sources folder and place it in the projects bin folder located in the solution. (Same folder as the applications .exe file)

`git clone https://github.com/Cole-Z/ZombieCamoList.git`

`dotnet build`

`dotnet run`

## Interface

In order to fill the application with the data, use the 'open file' button to open the 'zombie_camo_mw3.txt' file

![interfaceZombie](https://github.com/Cole-Z/ZombieCamoList/assets/98670265/476b04d3-a095-4f5e-a37d-5d22f348e675)


## Reading text files

Once you upload the text file, you then will be shown all weapons and their details

![interface_data_loaded](https://github.com/Cole-Z/ZombieCamoList/assets/98670265/331e7593-f944-46e9-af7e-91fc4940b24f)

## Selecting a weapon

Once a weapon is selected, you then will be shown the levels, challenges, and camos for each tier on the selected weapon.

![weapon_select](https://github.com/Cole-Z/ZombieCamoList/assets/98670265/06005865-e1ac-45ca-9405-3370cd164dac)

## Saving Progress

You can also update your progress while the app is running, lets say you knock out a a couple weapons and want to start on others while in game. You can
check off the weapons you just completed to update your progress and save the progress to your file.

![update_progress](https://github.com/Cole-Z/ZombieCamoList/assets/98670265/4fa3097b-f28b-4419-84a7-951359d78b13)

## Adding a new Weapon to file

Often, Call of Duty will release a new weapon for a new seaon. In this form, you can also add a new weapon if one is added in a new season update.

![add_new_weapon](https://github.com/Cole-Z/ZombieCamoList/assets/98670265/9c9f8997-9a3b-47c0-bee5-019023647c61)


Once added, you can view the weapon and its details within the textboxes and list boxes as well see it in the update progress section.

![display_saved_weapon](https://github.com/Cole-Z/ZombieCamoList/assets/98670265/eee78412-c2c0-4bef-99a5-1f81a1dff87b)

Thanks for checking it out!



