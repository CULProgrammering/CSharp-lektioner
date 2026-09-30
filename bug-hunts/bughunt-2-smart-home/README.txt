BUG HUNT 2: SMART HOME
=======================
The smart home app broke after the last update. It contains 4 bugs.
Fixing one bug may reveal the next one - that is normal, keep going!
At least one bug only shows up in the OUTPUT.

Tip: compiler WARNINGS are clues too, not just errors.

Your mission:
1. Fix every bug until the program compiles AND prints exactly the
   expected output below.
2. Be ready to explain WHY each one was a bug.

Setup: open this folder in VS Code (or Visual Studio) and run:

    dotnet run

The project file is already included - no setup needed.
(If dotnet complains about the target framework, open the .csproj
file and change net8.0 to your installed version, e.g. net9.0.)

EXPECTED OUTPUT
---------------
Kitchen Lamp glows warm white
Kitchen Lamp is online
Living Room Speaker plays a startup sound
Living Room Speaker is online
Volume: 40%
