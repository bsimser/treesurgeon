## How to setup a .NET Development Tree Part 1

So, lets start building our development tree. Feel free to join in. :) 

The first thing you need is a Source Control environment. This may sound simple, but even at this stage I have seen some strange things happen on projects. 

Here are some 'must haves':

* Your source control server must be fast. Your developers are often going to be waiting for your source control to do things, so don't scrimp on hardware. Specifically:
	* Do use decent, modern, hardware. 
	* Don't use network shares to store files - in my experience it will slow your source control by about 10x. Instead invest in some locally redundant disks (RAID 5 is OK, RAID 0+1 is better), and a backup strategy. 
	* Don't put your Source Control server on the other side of the world from your team. Keep it local, and make sure your network isn't getting bogged down. Obviously with distributed teams this may not be possible, but if your team isn't distributed, don't distribute your hardware. 
* Don't be tight on hard disk space. Get about as much as you think you might need in 3-5 years. Disk space really is cheap and having lots of it means that people can worry about producing software, and not about whether they are going over quota. 
* Give developers write access to the code they need to work on. If you trust them to write code, you should trust them to be able to edit their own work without having to go through slow processes. Other team's code may be a different matter. 
* Put each development tree in its own folder under source control - don't try and 'save' work or space by merging them. It really will save you headaches and time. See the 'hard disk space' point. 
* Make sure new source control clients can be set up fast and correctly. Document what needs to be done for each project on a Wiki. If your Source Control Client setup takes over 10 minutes, or is more than a page of manual work, change it. If necessary throw away your current Source Control software and start again. 
* Make sure basic source control operations are quick, simple and well understood. All developers should be easily able to do all of the following operations - if they don't know how or if these processes are cumbersome or slow to execute, then change them (again, if necessary consider changing your Source Control software)
	* Check out from nothing 
	* Get updates 
	* Find differences between server and local versions 
	* Revert local versions 
	* Commit changes
* Your Source Control system must be consistently trustworthy - if developers are losing changes or files are becoming corrupted, fix it. 
* Your Source Control server should support the following more advanced operations, which developers should be able to perform if necessary:
	* Labelling (tagging) 
	* Branching (parallel, independent, development of integratable code lines) 
	* Automation (be driven by a process, not just a person) 

The above points I believe are all necessary for an effective development 
project. For an 'excellent' project I recommend the following:

* A good source control server can happily accomodate 100 developers. I recommend the following kind of system:
	* UNIX/Linux based - Most good Source Control software is written primarily for a UNIX/Linux environment so don't support edge cases. 
	* At least dual-CPU (I like the idea of one CPU being able to do work, and one doing I/O, but I'm sure that's rather a simplistic model these days) 
	* At least 1GB RAM - if your often-accessed source is already cached you should get a speed up. 
	* Don't run anything else on the machine apart from a Source Control server. If you do (e.g. source control reporting), invest in extra processors and monitor what impact those extra applications are having. 
	* Use 1 disk set for applications and checkpoints/journals, and a separate disk set for your actual data.
* If cash is fairly easily available in your organisation, use Perforce. I've been using it on an off for 4 years now and it never ceases to amaze me how fast and stable it is. It also requires almost zero maintenance. 
* Otherwise use Subversion. It is free, and better than any other SCM system I've tried apart from Perforce. 
* If you are using Visual SourceSafe, I strongly urge you to migrate away from it. It is renowned for not being scalable and is also prone to file corruption. If you are not experienced with UNIX, or any other SCM tool apart from VSS, I have heard good things about SourceGear Vault. 
* Use clean and simple setups for your 'meta' trees. In Perforce, putting all projects in one 'depot' is perfectly reasonable, and use similar ideas for other tools. 

If after reading all of this you are thinking 'Nice ideas, but we don't have the time or money to do any of this', then think how much it would really cost you to (say) invest in a new Linux server and Subversion, and how much money you are losing through lack of productivity. Its also a lot simpler than you think. Why not try out Subversion for half a day with a good book? 

In the [next part](http://www.codeplex.com/treesurgeon/Wiki/View.aspx?title=DevelopmentTreePart2&referringTitle=Part1) we'll start looking at some code - stay tuned! 