# SFMF

> SFMF is a framework facilitating the creation, distribution, and installation of mods for Superflight.

## Getting Started

### Prerequisites

You'll need to make sure you've got these few things set up in order to compile and run SFMF.

- Superflight
- Visual Studio
- .NET 4.6.1 (I haven't tested which other versions are compatible)

### Installing

Since SFMF references a couple of the game's .dll files, you'll need to update those references to point to your copy of Superflight.

Update these references in _SFMF > SFMF_:

```
Assembly-CSharp -> ...\SuperFlight\superflight_Data\Managed\Assembly-CSharp.dll
UnityEngine.CoreModule -> ...\SuperFlight\superflight_Data\Managed\UnityEngine.CoreModule.dll
```

Once those references have been updated, you should be able run the project with no errors.

## Project Structure

- _SFMF_ - The assembly that is injected into Superflight with the core mod that searches for and loads all other mods.
- _SFMFLauncher_ - The front end application for managing SFMF and installed mods.
- _SFMFManager_ - The library responsible for managing downloading and installing mods as well as installing the framework.

## Acknowledgments

- Inspired and seeded by [@Phlarfl's](https://github.com/Phlarfl) implementation of SFMF.
