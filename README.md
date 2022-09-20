# NeosModManager
A mod manager for [NeosVR](https://neos.com/).<br>
Manage and install mods from the community-managed listing of mods. More information about the mod list or modding neos in general can be found on the [NeosModLoader Website](https://www.neosmodloader.com/).

## Prerequisite
* [.Net Desktop Runtime 5.0+](https://dotnet.microsoft.com/en-us/download/dotnet/5.0)

## Install
Download the [Latest Release](https://github.com/XDelta/NeosModManager/releases/latest/).<br>
Ensure prerequites are installed. You may receive a prompt to install them when launching otherwise
Run `NeosModManager.exe`
Open the Settings page and set the Neos path to where you have your `Neos.exe`


## Features:
- Automatically download and install most mods from [Mod Manifest](https://github.com/neos-modding-group/neos-mod-manifest)
- Quick access to NeosVR, Logs, nml_mods and Application folders
- Options to use Neos.exe or NeosLauncher.exe
- Persistent launch arguments
- Manually check mod github pages for mod updates that aren't on the manifest yet
- Search Mods by name, category, description text, author, tags

## Launch Argments
Available launch argments for NMM itself
`-debug` Debug Logging Level
`-verbose` Verbose Logging Level (Includes all logs from all levels)
`-console` Optional Console window to see NMM logs live