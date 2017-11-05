# Part 7 - Automating Unit Tests
Last time we left our code with a dependency on a 3rd party library, multiple internal modules (VS Projects), and a passing test. Great! But how do we know the test passes? At the moment it requires us to have our 'interactive hat' on. It would be much better if we knew just by running our automted build. So let's do that.

Before we start, here is the current state of our build script:

{{
<project name="nant" default="compile" xmlns="http://nant.sf.net/schemas/nant.xsd">
	<target name="clean">
		<delete dir="build" if="${directory::exists('build')}"/>
	</target>
	<target name="compile">
		<solution solutionfile="src\Sycamore.sln" configuration="AutomatedDebug" />
	</target>
</project>
}}

We're going to add a test target. Here's our first cut:

{{
<target name="test">
	<exec program="nunit-console.exe" basedir="tools\nunit" workingdir="build\Debug\UnitTests">
		<arg value="SherwoodForest.Sycamore.UnitTests.dll" />
	</exec>	
</target>
}}

Here we are using an <exec> task to run the NUnit Console application that's already in our development tree (that was handy, wasn't it? That's why we left all the NUnit binaries in our tree.) Some projects will use the <nunit> or <nunit2> tasks to run their tests from a build script, but this requires your version of NAnt and version of NUnit being in sync. Personally, I think the <exec> call looks pretty clean so I'm happy to use that rather than the tighter NUnit integration. And it means that later on if we update one of these 2 tools we don't have to worry about breaking this part of our build script.

The slightly tricky thing here is getting our directory specifications right. <exec>'s basedir attribute is the location of the actual .exe we want to run, and workingdir is the directory we want to run the application in. What might catch you out is that workingdir is relative to your NAnt base directory, not to the basedir attribute in the task specification.

Try running this target by entering go test from a command prompt in the project root. Did it work? What if you try go clean test ? The problem is that we need to compile our code before we test our code. NAnt supports this kind of problem through the depends target attribute and <call> task. Now we are entering the realm of much disagreement between build script developers. :) Which is the best option? And how should it be used? If you're new to NAnt, you'll probably want to skip the next few paragraphs.

depends specifies that for a target to run, all the targets in the depends list must have all run already. If they haven't, they will be run first, and then the requested target will run. <call> is much more like a traditional procedure call. So surely <call> is the best option, since we all know about procedure calls, right? Well, maybe, but the problem is that depends is really quite a clean way of writing things, especially when our script has multiple entry points. Also, traditionally, the behaviour of '*' have been a little strange when using <call>. depends though can get messy ifevery target has 7 different dependencies.

So, for better or worse, here's my current advice on this subject:
# Use depends as the primary way of defining flow in your build script.
# If a target has a depends value, don't give it a body. In other words a target should have task definitions, or dependencies, but not both. This is to try and get away from the 'dependency explosion' that Ant / NAnt scripts tend towards.
# Use <call> only for the equivalent of an extract method refactoring. <call>ed targets should never have dependencies. Think very carefully about * when using <call>.
We'll put this hot potato back on the fire now.

(Paragraph skippers, join back in here.) So back to our test target. What we want to say is that running the unit tests depends on compiling the code. So we'll add the attribute depends="compile" to the test target tag.

{{
<target name="test" depends="compile" />
	<exec program="nunit-console.exe" basedir="tools\nunit" workingdir="build\Debug\UnitTests">
		<arg value="SherwoodForest.Sycamore.UnitTests.dll" />
	</exec>
</target>
}}

Now we're mixing up our dependencies and tasks though, breaking rule 2 above. We'll use an extract dependency target refactoring to split the target into 2 (note the second dependency on the test target):

{{
<target name="test" depends="compile, run-unit-tests" description="Compile and Run Tests" />
<target name="run-unit-tests">
	<exec program="nunit-console.exe" basedir="tools\nunit" workingdir="build\Debug\UnitTests">
		<arg value="SherwoodForest.Sycamore.UnitTests.dll" />
	</exec>
</target>
}}

There's something else we've done here - we've added a description to the test target. This is important - you should use the convention that targets with a description value are runnable by the user. If a user tries running a target without a description then that's down to them - they should be aware that the script may fail since dependencies have not been run. Users can easily see all the 'public' targets in a build script by doing go - projecthelp (the 'main' targets asNAnt calls them are our public targets.)

OK, we can run our tests, but where are the results? What we'd actually like is to use NUnit's XML output so that results can be picked up by another process, such as CruiseControl.NET. Let's put this XML output somewhere in the build folder, since its another one of our build artifacts. We'll update the run-unit-tests target as follows:

{{
<target name="run-unit-tests">
	<mkdir dir="build\test-reports" />
	<exec program="nunit-console.exe" basedir="tools\nunit" workingdir="build\Debug\UnitTests">
		<arg value="SherwoodForest.Sycamore.UnitTests.dll" />
		<arg value="/xml:..\..\test-reports\UnitTests.xml" />
	</exec>
</target>
}}

We used the /xml: parameter for NUnit, and made sure the report output directory already existed.

One more thing, and then we'll be done. We already introduced the idea of a build script refactoring above when we split-up the test target. If you look at the current state of the build script though, you'll see there's plenty of scope for another refactoring - 'introduce variable', or introduce script property as we'll call it in the build script world. Look at all those places where we use the folder name build. Lets put that in a script property called build.dir. Now our script looks like:

{{
<project name="nant" default="test" xmlns="http://nant.sf.net/schemas/nant.xsd">
	<property name="build.dir" value="build" />
	
	<!-- User targets -->
	<target name="test" depends="compile, run-unit-tests" description="Compile and Run Tests" />
	
	<target name="clean" description="Delete Automated Build artifacts">
		<delete dir="${build.dir}" if="${directory::exists(property::get-value('build.dir'))}"/>
	</target>

	<target name="compile" description="Compiles using the AutomatedDebug Configuration">
		<solution solutionfile="src\Sycamore.sln" configuration="AutomatedDebug" />
	</target>

	<!-- Internal targets -->
	<target name="run-unit-tests">
		<mkdir dir="${build.dir}\test-reports" />
		<exec program="nunit-console.exe" basedir="tools\nunit" workingdir="${build.dir}\Debug\UnitTests">
			<arg value="SherwoodForest.Sycamore.UnitTests.dll"/>
			<arg value="/xml:..\..\test-reports\UnitTests.xml"/>
		</exec>
	</target>
</project>
}}

A lot of people will introduce a script level property whenever theyintroduce a new directory, file, etc. I advise you not to do this in your build script development since (I think) it hinders maintainablity. Treat your build script like well maintained code - do the simplest thing that works, but refactor mercilessly. In terms of introduce script property you should really only be doing it once the same piece of information is used by multiple targets. For example, a lot of people would introduce a src.dir property out of principle, and in our case it would have the value src. But what would that gain us? In our build script we only ever use that directory name once, so its simpler just to leave it as a literal usage in the call to <solution>.

Notice in the last example we also added descriptions to all the targets we want to be public, and split the file up into (effectively) public and private targets. XML is not the cleanest language to develop in, but by thinking about simplicity and readabilty, you can make your build scripts more maintainable.

To summarise this part:
* Use the <exec> task to call NUnit within your build script.
* Use targets that just specify dependencies to create flow within yourbuild script.
* Don't use dependencies with targets that specify tasks
* Split your targets into 'public' and 'private' targets by giving public targets a description.
* Use build script refactorings to simplify the structure of your NAnt file.
* Don't introduce unnecesssary script