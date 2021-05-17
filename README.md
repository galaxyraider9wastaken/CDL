# CDL
CDL is the new Microsoft XNA, but first a little backstory. I always loved coding in C# with Microsoft XNA but I always thought it could do better, like with better 3d support and  more tutorials. Well thats CDL aka C#/C++ Drawing Libary. CDL has two versions one is Made in C++ and C# using OpenGl and is used with C#, The other version is made in C++ and is just used for C++. There also might eventully be a version for python.

# Looking at the code
Looking at the source code can be confusing, basicly the project is split into two folders one is called CSDL aka C Sharp Drawing Library and the other is called CPPDL aka C Plus Plus Drawing Library.

# How does it work
Basicly CDL uses a files to communicate between diffrent programming languages, when you use a draw function or create a camera or window or change the data it will change the file so you are runing your code with visual studio or whatever then when you run it, it executes CDL and starts reading from the files, and writing all the sprites and updating positions and reading them over and over. It can also work with almsot every programming language someone just need to devlop the functions in that language and have it write to a file.
