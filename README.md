# OniExtract2020

Dumps game data, sprite data and images from game Oxygen Not Included.

Compiled under VS2022 for ONI version U51-600112.

## SteamDB Info

Game Name: Oxygen Not Included

App ID: 457140

Depot ID: 457141

Manifest ID: 5347960185499743335

Rollback game in Steam console:

```
download_depot <AppID> <DepotsID> <ManifestID>
```

## Build steps

Load up solution, click `build`, grab `OniExtract2.dll` from debug folder.

- Debug: `OniExtract2020\OniExtract\bin\Debug`
- Release: `OniExtract2020\OniExtract\bin\Release` 

## Install steps

### From Build

1. Build project.
2. Go to `Documents\Klei\OxygenNotIncluded\mods` and create the following new subfolder: `local\OniExtract`.

3. Add the `OniExtract2.dll` from debug folder into the newly created folder `local\OniExtract`.

4. Copy `mod_info.yaml` and `mod.yaml` from this repo into that same folder `local\OniExtract`.

### From Releases

1. Download package from Releases. Unzip package.
2. Go to `Documents\Klei\OxygenNotIncluded\mods` and create the following new subfolder: `local\OniExtract`.

3. Copy all files to `Documents\Klei\OxygenNotIncluded\mods\local\OniExtract`.



Enable the mod in game. Output will be in `Documents\Klei\OxygenNotIncluded\export`.

## Output Result

Go to `Documents\Klei\OxygenNotIncluded\export` . Here is the dir tree:

```
export
├─ database
│    ├─ building.json
│    ├─ db.json
│    ├─ elements.json
│    ├─ entities.json
│    ├─ equipment.json
│    ├─ food.json
│    ├─ geyser.json
│    ├─ po_string.json
│    ├─ recipe.json
│    └─ tags.json
└─ images
```