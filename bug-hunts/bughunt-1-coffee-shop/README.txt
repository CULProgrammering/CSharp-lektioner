BUG HUNT 1: THE COFFEE SHOP
============================
Someone pushed this code on a Friday afternoon without testing it.
It contains 5 bugs. Some stop the program from compiling - at least
one only shows up in the OUTPUT, so keep hunting after it compiles!

Your mission:
1. Fix every bug until the program compiles AND prints exactly the
   expected output below.
2. Be ready to explain WHY each one was a bug.

Tip: compiler WARNINGS are clues too, not just errors.

Setup: open this folder in VS Code (or Visual Studio) and run:

    dotnet run

The project file is already included - no setup needed.
(If dotnet complains about the target framework, open the .csproj
file and change net8.0 to your installed version, e.g. net9.0.)

EXPECTED OUTPUT
---------------
Latte (2 shots): 45 kr
Earl Grey: 30 kr (loose leaf)
Size of first drink: Large
