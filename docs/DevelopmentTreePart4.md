# Part 4 - Adding an Automated Build
At this point we have a basic Visual Studio solution checked into Source Control. Now its time to automate how we build this solution.

Most of the time .NET developers will work solely within the Visual Studio environment, compiling their solution with the in-built compiler, and running tests using TestDriven.NET (more on testing to come...). But relying solely on Visual Studio as a way to produce build artifacts and run your tests isn't enough. For instance:
* How do you run scheduled or triggered builds for your project? Using the command line version of Visual Studio (devenv.com) provides you with only basic command line features.
* Visual Studio's 'pre-' and 'post-' build events provide some build scripting beyond just compiling code, but such scripting is limited in scope and expressiveness. 
The current 'de-facto' automated build tool for .NET projects is NAnt. NAnt is based on the Java build tool Ant and has similar strengths (integration with lots of useful tools, few dependencies) and also its weaknesses (being defined in XML means large build scripts quickly get hard to maintain). .NET 2 and Visual Studio 2005 will come with their own build scripting tool, MSBuild, which is very similar to NAnt. Investing in NAnt now should give you a build script you can easily convert to MSBuild later, should you want to. 
NAnt is a tool that can be installed on every developers machine. However, I like to check NAnt into the project tree for some simple reasons:
* It saves the manual steps of everyone copying it to their machine, and installing it. (Remember - manual steps take time and are a possible point of error.)
* NAnt changes between versions, and such changes can effect the behaviour of a build. Making sure that everyone has the same version of NAnt when everyone is manually installing it can be tricky, and is time consuming when you want to upgrade the version of NAnt everyone uses.
* Many projects use their own 'custom' NAnt tasks. Storing these in source control along with the project's own version of NAnt makes distribution to team members painless.
* It is not a large tool, so the overhead of storing it in source control should not be a problem.
To add NAnt to your project tree, first download and unpack its binary zip file (I'm going to use NAnt 0.85 RC1, available here.) Then, copy the bin folder to your project directory. I like to put all build-time tools in a subfolder of my project root called tools, and then put the contents of NAnt's bin folder in tools\nant. Before going any further, commit NAnt to your project's source control, making sure to include in the commit message the version of NAnt you are using. Later on, this will help you decide whether you want to upgrade to a new version.

You tell NAnt what to do using a build script. The standard for naming NAnt build scripts is ProjectName.build. The build script is a gateway into our project, so I like to save it in the root folder. You can edit your build script with Visual Studio - create it as a 'solution item' (Right click on the solution icon in Solution Explorer and choose Add new item... or Add existing item...). If you follow the instructions here and here you'll even get IntelliSense! (Thanks to Serge van e Oever and Craig Boland for writing it up.)

Our first NAnt build script will just compile our project. There are several ways to do this, and I'm going to use the <solution> task:
{{
<?xml version="1.0" ?>
<project name="nant" default="compile" xmlns="http://nant.sf.net/schemas/nant.xsd">
	<target name="compile">
		<solution solutionfile="src\Sycamore.sln" configuration="debug" />
	</target>
</project>
}}
I like to use the <solution> task for a couple of reasons:
* For developers to work in Visual Studio we need to define how to compile our project in Visual Studio using its'references' system. <solution> lets us re-use all this work in 1 line of script. If we were to use the <csc> task instead we would need to maintain a separate set of compile definitions (which would be time-consuming and might not match the Solution / VS Project setup).
* Using <solution> rather than the <exec> task calling out to devenv.com is less resource intensive, gives more appropriate feedback and also allows us to run builds on machines without Visual Studio installed (it just needs the .NET SDK.) If you have a problem using <solution> you can always quickly replace it with an <exec> to devenv.com
To run your build, save the build script, open a command prompt and change to your project's root folder. Then just entertools\nant\NAnt. You  should see output like:
{{
NAnt 0.85 (Build 0.85.1793.0; rc1; 28/11/2004)
Copyright (C) 2001-2004 Gerry Shaw
http://nant.sourceforge.net
Buildfile: file:///c:/devel/sycamore/Sycamore.build
Target(s) specified: compile
compile:
[solution](solution) Starting solution build.
[solution](solution) Building 'SycamoreConsole' [debug](debug) ...
BUILD SUCCEEDED
Total time: 0.2 seconds.
}}
Woohoo - a successful build! We have something new, that works, so submit the build script (and your changes to theSolution file that include the build script) to source control.

The current state of Sycamore is available here (link unavailable).

To summarise this part:
* Add an automated build system to your project.
* Use NAnt to automate your .NET 1.1 and earlier projects.
* Check the NAnt distribution into your development tree.
* Create a build script and save it in your development tree.
* Use the <solution> task to compile your project.
In the [next part](http://www.codeplex.com/treesurgeon/Wiki/View.aspx?title=DevelopmentTreePart5&referringTitle=Home) we'll be adding some more features to our automated build.