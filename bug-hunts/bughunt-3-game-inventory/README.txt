BUG HUNT 3: GAME INVENTORY
===========================
The inventory system for a small RPG is broken. It contains 4 bugs.
All of them stop the program from compiling - the compiler messages
are your treasure map. Read them carefully!

Your mission:
1. Fix every bug until the program compiles AND prints exactly the
   expected output below.
2. Be ready to explain WHY each one was a bug.

One hint about the story: the Ancient Key is a quest item.
Quest items can NEVER be sold.

Setup: open this folder in VS Code (or Visual Studio) and run:

    dotnet run

The project file is already included - no setup needed.
(If dotnet complains about the target framework, open the .csproj
file and change net8.0 to your installed version, e.g. net9.0.)

EXPECTED OUTPUT
---------------
You drink the Health Potion
You swing the Iron Sword
The Ancient Key glows faintly
Sold Health Potion for 10 gold
Sold Iron Sword for 50 gold
