## How to setup a .NET Development Tree Part 2

In Part 1 we looked at making sure we had our Source Control story straight. With that sorted out, we can start creating some files to put in it. 

First some terminology, I'm going to use the word 'Project' to define the thing that all the files in our development tree go to make up. It is more than just a Visual Studio Project. I'm going to use an example project called Sycamore. 

Next, I'm going to assume you are using Visual Studio 2003. Pretty much everything we are going to look at will work without Visual Studio, but I'll assume you have it anyway. 

First, we want to make a new folder. We'll put it in our meta root - a place where you check projects out from Source Control. On my machine, this folder is C:\devel but on your machine (and anyone else's) it might be different. You should never assume the concrete location of meta roots. 

Call the new folder pretty much the same thing as your project. I say 'pretty much' since I like to remove capitals and spaces, but its really up to you. Our folder will be called sycamore. It is the root of our development tree. All source code for this project will exist somewhere under this root. Any tool or library dependencies that exist outside the scope of this root will have to be managed carefully. There will be no source under this root that belongs to any other project. 

To start with we are just going to create a Visual Studio-compilable 'solution'. A solution contains source code, so we're going to create a sub-folder of sycamore called src. We will have other sub-directories later, but they will contain other things, so its good to separate the source out into its own location. 

In src we create our new Visual Studio solution. To make things easy, I'm going to call it Sycamore. Unfortunately, Visual Studio doesn't make it easy - it wants to put it in a another sub-folder called Sycamore so once I've created an empty solution I'll close it down and move the Solution.sln file into the src folder. We can delete the extra Sycamore folder that Visual Studio created for us. 

Next to create some VS Projects. In this part, I'm going to keep it simple - just a single command line application in one project. We'll be creating some more projects later. I like projects to have their own folder under src. We never merge VS projects into one folder and never put their 'project roots' anywhere other than src. 

In Visual Studio I create a C# Console Application called SycamoreConsole. Its location on my machine is C:\devel\sycamore\src, but the location on your's will depend on your meta root. VS creates the project for us and creates a class called Class1. 

We're also going to change some of the project properties. First the Assembly Name. In later parts we'll talk about dll names, but for console applications, pick something short and obvious. We're going to call our's sycamore. For the Default Namespace, I like to use the convention OrganisationName.ProjectName.VSProjectName, so in our case I'm going to use the Namespace SherwoodForest.Sycamore.SycamoreConsole. Save these properties and go back to the Class1 window. 

First, set the namespace to be as you just set in the Project properties. Now rename the class to something sensible (we'll use HelloWorld for now), and don't forget to rename the file to match. (I recommend you use ReSharper which will do the file rename for you.) I also like to delete all the unnecessary comments. Sticking with tradition we'll add the statement Console.WriteLine("Hello World"); to the main method. Compile, run and make sure everything does as expected. 

We're done for now. We may be making baby steps, but we are already seeing some defintions and patterns emerge:

* The root is the upper most point of our development tree. 
* All files belonging to a project exist under the root. 
* No files belonging to any other project exist under the root. 
* The root itself is resident in a meta root which can change from machine to machine. 
* All source code resides under a src sub-folder. 
* The project .sln file is saved in the src folder. 
* All Visual Studio Projects exist in their own sub-folders under the src folder. 
* Visual Studio Project folders are atomic, and should be named identically to the project they contain. 
* The default namespace for a Visual Studio project should be OrganisationName.ProjectName.VSProjectName.

In the [next part](http://www.codeplex.com/treesurgeon/Wiki/View.aspx?title=DevelopmentTreePart3&referringTitle=Part2) we'll look at what we have to do to get this project into Source Control.