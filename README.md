# Roll-a-ball (UI Toolkit + Input System)

A small physics-based collection game built in Unity. Based on the Unity Learn Roll-a-ball tutorials, with UI built using UI Toolkit and input handled by the new Input System following recommended practices.

## Highlights
- UI Toolkit HUD and menus (score, game over, victory)
- New Input System with action maps
- Clean separation of gameplay, UI, and input layers
- FixedUpdate physics movement
- Minimal, extensible code structure

## Requirements
- Unity 6000.2.0f1+

## Getting Started
1. Clone the repo.
2. Open the project in Unity.
3. Open the main scene (Assets/Scenes/MiniGame.unity).
4. Press Play.

## How to Play
- Move: WASD / Arrow Keys / Left Stick
- Avoid the red enemy while collecting yellow gems.
- Collect all gems to win.

## Project Structure
- Assets/ — Input Actions asset
- Assets/Scenes — main game scene(s)
- Assets/Scripts — gameplay, UI, and input scripts
- Assets/UI Toolkit — UXML, USS, Panel Settings

## UI Toolkit Notes
- UI created with UXML/USS and a Panel Settings asset
- A single UIDocument drives HUD
- UI elements queried/bound in C# (no legacy uGUI)

## Input System Notes (best practices)
- One Input Actions asset with separate action maps:
  - Player: Move (Vector2)
  - UI: Submit, Cancel, Navigate, Point, Click (Unused atm)
- PlayerInput drives control scheme and map switching
- Gameplay actions enabled only during gameplay
- Physics input read in FixedUpdate; no legacy Input API

## Differences from the Tutorial
- Replaced uGUI with UI Toolkit for HUD
- Changed Input System handling by disabling the project-wide inputs singleton
- Minor UX and code structure adjustments for maintainability

## License
- Code (e.g., Assets/Scripts and other source): PolyForm Noncommercial 1.0.0
  - SPDX: PolyForm-Noncommercial-1.0.0
  - Full text: https://polyformproject.org/licenses/noncommercial/1.0.0/
- Non-code assets (e.g., art, audio, prefabs, scenes): CC BY-NC 4.0
  - Summary: https://creativecommons.org/licenses/by-nc/4.0/
  - Legal code: https://creativecommons.org/licenses/by-nc/4.0/legalcode.txt

For commercial licensing of the code or assets, please contact the author.

## Acknowledgements
- Unity Learn: Roll-a-ball tutorial (concept and assets guidance)
- Unity documentation: UI Toolkit and Input System
