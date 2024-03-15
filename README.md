# OniExtract2020

Compiled under VS2022 for ONI version U47-562200-VD

## SteamDB Info

App ID: 457140

Depot ID: 457141

Manifest ID: 5347960185499743335

Rollback game in Steam console:

```
download_depot <AppID> <DepotsID> <ManifestID>
```

## Install steps

go to `Documents\Klei\OxygenNotIncluded\mods` and create the following new subfolder: `local\OniExtract`

Then add the dll `OniExtract2.dll` from this repo into the newly created folder

Copy `mod_info.yaml` and `mod.yaml` from this repo into that same folder

Enable the mod in game

Output will be in `Documents\Klei\OxygenNotIncluded\export`


## Build steps

Load up solution, click `build`, grab OniExtract2.dll from debug folder

## Output Result

Go to `Documents\Klei\OxygenNotIncluded\export` . Here is the dir tree:

```
export
├─ database
│    └─ database.json
└─ images
```