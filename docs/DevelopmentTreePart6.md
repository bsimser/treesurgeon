# Part 6 - Adding Unit Tests
By now we have some source code checked in to our Source Control server. Its got a structured folder hierarchy and we're being careful about how we check specific files in (and ignore others). We're combining Visual Studio and NAnt to have a simple yet powerful automated build that works closely with the changes we make during interactive development.

So far though we only have 1 source file and shockingly no tests. We need to change this.

To do this we're going to create 2 new assemblies - one application DLL, and  one DLL for unit tests. .NET won't allow you to use .exe assemblies as references for other projects, so a unit test DLL can only reference another DLL. Its slightly off-topic but because of this reason I try to keep my .exe projects as small as possible (because any classes in them can't be unit tested) and have nearly all code in a DLL.

So let's create our new Application DLL. I'm going to call it Core. Following the conventions we set down in part 2, the VS Project Folder is stored in src and we change the default namespace to SherwoodForest.Sycamore.Core. Before closing the Project Properties window though, there are 2 more things to change.

Firstly, for DLLs I like to use the naming convention that the Assembly has the same name as the default namespace. Also, following what we did in the previous part, create an 'AutomatedDebug' configuration, based on the 'Debug' Configuration, except with the output path of ..\..\build\Debug\Core. Make sure your Solution build configurations are all mapped correctly. We won't need the 'Class1' which VS automatically creates, so delete it.

We follow exactly the same procedure for our Unit Test DLL, giving the VS Project the (not particularly original, nevertheless informative) name of UnitTests. Save everything and make sure you can compile in Visual Studio and using your build script.

Before we write a test, we need to setup our project with NUnit. There's a few hoops to go through here but we only have to do it once for our project. Firstly, download NUnit - I'm going to be using NUnit 2.2.2 for this example. Download the binary zip file, not the MSI. While its downloading, open up your Global Assembly Cache (or GAC) - it will be in C:\Windows\Assembly, or something similar. Look to see if you have any NUnit assmblies in it. If you do, try to get rid of them by uninstalling any previous versions of NUnit from your computer.

Why are we worrying about not using the GAC and MSI's? Well, for pretty much exactly the reasons as we specified for NAnt, we want to use NUnit from our development tree . The problem is that if we have any NUnit assemblies in the GAC, they will take priority over the NUnit in our development tree. We could go through being explicit about the versions of NUnit each assembly requries, but that's a lot of hassle. Its easier just not to make NUnit a system wide tool, and this means getting it out of the GAC. (Mike Two, one of the NUnit authors, is probably going to shoot me for suggesting all of this. If you want to make NUnit a system tool then that will work too, you just have a few more hoops to jump through.)

By now your NUnit download should be complete. Extract it, take the bin folder and put in next to the nant folder in your project's tools folder. Rename it to nunit.

To create test fixtures in our UnitTests VS Project, we need to reference the nunit.framework assembly. This introduces a new concept - that of third party code dependencies. To implement these, I like to have a new toplevel folder in my project root called lib. Do this in your project and copy the nunit.framework.dll file from the NUnit distribution to the new folder. Once you've done that, add lib\nunit.framework.dll as a Reference to your UnitTests project.

Because of the previous step we now have the same file (nunit.framework.dll) copied twice in our development tree. Its worth doing this because we have a clear separation between code dependencies (in the lib folder) and build time tools (in the tools folder). We could delete the entire tools folder and the solution would still compile in Visual Studio. This is an example of making things clean and simple. It uses more disk space, but remember what we said back in Part 1 about that?

So finally we can actually write a test! For Sycamore, I'm going to add the following as a file called TreeRecogniserTest.cs to my UnitTests project:

{{
using NUnit.Framework;
using SherwoodForest.Sycamore.Core;
namespace SherwoodForest.Sycamore.UnitTests
{
	[TestFixture](TestFixture)
	public class TreeRecogniserTest
	{
		[Test](Test)
		public void ShouldRecogniseLarchAs1()
		{
			TreeRecogniser recogniser = new TreeRecogniser();
			Assert.AreEqual(1, recogniser.Recognise("Larch"));
		}
	}
}
}}

To implement this, I add Core as a Project Reference to UnitTests and create a new class in Core called TreeRecogniser:

{{
namespace SherwoodForest.Sycamore.Core
{
	public class TreeRecogniser
	{
		public int Recognise(string treeName)
		{
			if (treeName == "Larch")
			{
				return 1;
			}
			else
			{
				return 0;
			}
		}
	}
}
}}

I can then run this test by using TestDriven.NET within the IDE, or by using the NUnit GUI and pointing it at src\UnitTests\bin\Debug\SherwoodForest.Sycamore.UnitTests.dll. The tests should pass in either case.

If we run our automated NAnt build, everything should compile OK, and you should be able to see each of the VS Projects compiling in their AutomatedDebug Build Configuration. The tests aren't run yet, but that's what we'll be looking at next time. Even so, we are still at a check-in point. We have 2 new project folders to add, but remember the exclusion rules (*.user, bin and obj). Being a Subversion command-line user, I like to use the the -N (non recursive) flag of svn add to make sure I can mark the svn:ignore property before all the temporary files get added.

Also, don't forget to check in tools\nunit or the new lib folder.

The current state of Sycamore is available here (link not available).

So let's wrap up this part then. We covered some new generic principles about projects and dependencies. We also looked at the specifics of using NUnit. Some concrete points to take away are: 
* Set DLL Names to be the same as the default namespace
* Put your Unit Tests in a separate VS project called UnitTests
* Save NUnit in your development tree in its own folder under tools
* Put all DLLs your code depends on in a top level folder called lib. Theonly exceptions are system DLLs such as .NET Framework Libraries.

[Next Section Unit Test Automation](http://www.codeplex.com/treesurgeon/Wiki/View.aspx?title=DevelopmentTreePart7)