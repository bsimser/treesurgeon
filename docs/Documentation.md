## Using Tree Surgeon

Tree Surgeon is pretty simple, but it is fully functional. Its based on Mike Roberts's series of articles on How to setup a .NET Development Tree (see links below).

Download the installer, and just run the GUI. Your generated project will appear in your My Documents folder and you should move it to wherever you like to develop on your machine (the meta-root if you read the article above.)

Your generated project has a Visual Studio solution waiting for you in the src folder. Also, if you go into the project root directory, you can run an automated build. It should look a bit like this:

{{
C:\Program Files\TreeSurgeon\MyNewProject>go
NAnt 0.85 (Build 0.85.1793.0; rc1; 28/11/2004)
Copyright (C) 2001-2004 Gerry Shaw
http://nant.sourceforge.net

Buildfile: file:///C:/Program Files/TreeSurgeon/MyNewProject/MyNewProject.build
Target(s) specified: test

compile:

 [solution](solution) Starting solution build.
 [solution](solution) Building 'MyNewProjectConsole' [AutomatedDebug](AutomatedDebug) ...
 [solution](solution) Building 'Core' [AutomatedDebug](AutomatedDebug) ...
 [solution](solution) Building 'UnitTests' [AutomatedDebug](AutomatedDebug) ...

run-unit-tests:

    [mkdir](mkdir) Creating directory 'C:\Program Files\TreeSurgeon\MyNewProject\build\test-reports'.
     [exec](exec) NUnit version 2.2.2
     [exec](exec) Copyright (C) 2002-2003 James W. Newkirk, Michael C. Two, Alexei A. Vorontsov, Charlie Poole.
     [exec](exec) Copyright (C) 2000-2003 Philip Craig.
     [exec](exec) All Rights Reserved.
     [exec](exec)
     [exec](exec) OS Version: Microsoft Windows NT 5.1.2600.0    .NET Version: 1.1.4322.2032
     [exec](exec)
     [exec](exec) .
     [exec](exec) Tests run: 1, Failures: 0, Not run: 0, Time: 0.060 seconds
     [exec](exec)
     [exec](exec)

test:

BUILD SUCCEEDED

Total time: 4.4 seconds.
}}
## Creating a .NET Development Tree Blog Series
This is the series of blog posts created by Mike Roberts that started Tree Surgeon.

[Introduction](DevelopmentTreeIntroduction)
[Building the Development Tree](DevelopmentTreePart1)
[Adding Files to the Tree](DevelopmentTreePart2)
[Checking into Source Control](DevelopmentTreePart3)
[Automating the Build](DevelopmentTreePart4)
[Extending the Build](DevelopmentTreePart5)
[Adding Unit Tests](DevelopmentTreePart6)
[Automating Unit Tests and Packaging](DevelopmentTreePart7)