# CS-Jukebox
Introducing CS-Jukebox, a tool that allows you to play your own custom music kits in CS2!

[![CS Jukebox Trailer](https://img.youtube.com/vi/s9UX5aizHTY/0.jpg)](https://www.youtube.com/watch?v=s9UX5aizHTY)
![image](https://user-images.githubusercontent.com/26579319/128274959-d2ada5f1-ac48-4d88-b7c0-4cf9a42ea790.png)

# Getting Started
1. [Download the latest release](https://github.com/zzhabib/CS-Jukebox/releases/download/v1.01/CS.Jukebox.v1.01.zip) (Windows only).
2. Extract the folder inside the zip.
3. Launch CS-Jukebox.exe
4. Jukebox will ask you to locate the root folder for CS2. This is the folder "game" in your game root (steamapps\common\Counter-Strike Global Offensive\game)
5. If CS2 is open, it must be restarted for Jukebox to work.

# How to create kits
Creating a music kit can be easily done inside CS-Jukebox
1. Click the "Add" button on the main screen.
2. Create a name for the music kit.
3. For each song, click browse to navigate to a song downloaded on your computer.
4. Adjust any controls such as Volume or Start Position.
5. Click Save and enjoy your music kit.

# How it works
CS-Jukebox works by using CS2's official <a href="https://developer.valvesoftware.com/wiki/Counter-Strike:_Global_Offensive_Game_State_Integration">GameState Integration</a>
to read data from the game such as round phases, bomb states, and teams. This method is safe and will not cause any VAC bans.

Credit to [rakijah](https://github.com/rakijah) for creating [CSGSI](https://github.com/rakijah/CSGSI) & TimosCodd (https://github.com/TimosCodd) for porting over to CS2.
