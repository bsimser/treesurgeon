# Part 3 - Adding files to Source Control
A quick recap. So far we have made sure we have a good source control environment and have created a Visual Studio Solution with a well structured folder setup. But we haven't checked those files into our Source Control server yet - we'd better fix that.

Your Source Control administrator will probably tell you where to make your initial check-in of your new project, but I suggest you think about simplicity for a moment:
* If you're using Perforce, consider using 1 depot as the 'server side' equivalent of your meta root. You don't lose any security options, and you gain in that developers may already have this depot mapped in their client so won't need to change any source control configuration.
* If you're using Subversion, just use one repository for all the projects in your department (see here for a good explanation why.) Use a new directory for your new project (and probably check it in to a 'trunk' sub-directory, but you can always move it later.) 
* If you're using CVS, its fairly standard to create a new CVSROOT for each project, and I would recommend it. Note that you'll have to setup any extra permissions and triggers that you use as standard. I've seen organisations make good use of GForge to manage their CVS server.
* For other Source Control systems, follow similar guidelines 
Once you've figured out the source control location of your new project, don't be too hasty about checking in. Its worth taking a moment to decide what you actually want to check in. Files you don't want to include are: 
* Build output folders - don't check in the bin or obj sub-folders of your VS project folders
* Any Solution .suo or VS Project .user files - these are user and environment specific and should not be checked in 
* Any Resharper, or other third-party tool output. (Resharper generates a SolutionName.resharperoptions file and a _ReSharper.SolutionName folder, neither of which you need to save) 
Not checking these files in is good, but making sure no-one else ever checks them in later by mistake is even better. CVS and Subversion both offer such functionality through .cvsignore files and svn:ignore properties respectively. With Perforce, you can use Triggers, but this is not as elegant a solution. 
Moving back to our Sycamore example, I'm going to use a Subversion server to check in our work. First of all I delete all the temporary files we discussed above. Then I'm going to use the svn command line tool, but you could use TortoiseSVN or AnkhSVN instead. My command line looks like: 

{{ c:\devel\sycamore>svn import -m "Initial Sycamore Import" . file:///c:/svn-repos/sycamore/trunk  }}

Once the intial checkin is complete I'm going to delete my 'sycamore' folder  and then checkout from Subversion the folder we just imported to get a local versioned folder. After that I reload the solution in Visual Studio and compile. This recreates the temporary files. 

I then set the svn:ignore value for src to be **.suo, ReSharper.Sycamore and **.resharperoptions. The svn:ignore for VS Project dirs should be set to **.user, bin and obj. You should be able to test you've captured everything by doing a svn status in the root folder and only seeing output for merging the properties of the src and VS Project directories. Make sure to commit these property updates.

To see exactly the state of Sycamore as it currently stands, download a zip file from here (link unavailable).

To summarise this part:
* Pick a Source Control location that is simple for everyone to use.
* When checking in your project directory, make sure not to include build artfacts or temporary environment files.
* If possible, configure your Source Control to make sure no-one can check in such files in the future.

In the [next part](http://www.codeplex.com/treesurgeon/Wiki/View.aspx?title=DevelopmentTreePart4) we'll be adding an automated build for our project using NAnt.