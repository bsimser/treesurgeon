## Development

**Source Control**
Tree Surgeon uses [Team Foundation Server on CodePlex](http://www.codeplex.com/treesurgeon/SourceControl/ListDownloadableCommits.aspx) to manage it's codebase. You can access the repository (preferred) using any Subversion client. The SVN address for the project is [https://treesurgeon.svn.codeplex.com/svn](https://treesurgeon.svn.codeplex.com/svn).

**Issue Tracking**
Issue Tracking is done using CodePlex [here](http://www.codeplex.com/treesurgeon/WorkItem/List.aspx).

**Version Naming**

_Released Versions_

Released versions have the following numbering:

Major.minor.revision.buildnumber, where 
* We plan on updating Major versions only on a major milestone in the project. 
* We update **minor** versions when there is a significant improvement in the application, or a breaking change in configuration since the previous release. When updating the **minor** version number, we reset the **revision** to zero. 
* We use **revision** numbers of more than 0 when we do not want to update the minor version number, but do want to make a new release. This may be due to some bugfixes, minor updates, etc. We never just increase the **revision** number if there has been a breaking change 
* **buildnumber** is the Continuous Integration build number. We never reset this. A buildnumber of 0 implies a build that was produced outside of our Continuous Integration environment 

Our Continuous Integration process creates a build label that includes the **Major.minor.revision** part. We update this as late as possible before a release, or release candidate, for a new release version.

_Unreleased versions_

Unreleased versions have the following names:

* **Next** - The next release, where the final release name has not yet been set 
* **Soon** - Issues that we hope to resolve soon 
* **Eventually** - Issues that we hope to resolve at some point in the future, but after the next major release 

All unresolved issues should be assigned to one of these versions by a project administrator. Issues should only be moved to Next if they have been resolved since the last release, or are an unresolved blocker for the next release.

**Coding Standards**

Coding standards on the project, should you decide to contribute to it, are pretty light (and open to negotiation and discussion):

* All code has unit test coverage
* private class fields using _ prefix with camelCase
* properties are PascalCased
* public methods are PascalCased
* private/protected methods are preferred to be camelCased but are acceptable as PascalCased
* Order of members in a class: fields, constructors, everything else
* Use interfaces to define contracts
* do not use regions 

Use tabs, not spaces in your patches - Some folks like 2 spaces, some like 4, but that's an IDE setting. Change your IDE settings to use tabs, not spaces, and then you can set your tab to 2 spaces if you prefer that. Here is a quick macro to flip between tabs and spaces in Visual Studio: [http://abombss.com/blog/2007/12/12/toggle-between-tabs-spaces-with-ease/](http://abombss.com/blog/2007/12/12/toggle-between-tabs-spaces-with-ease/)

**Patches**

To contribute new features to this project please follow these steps:

# Download the source code from the source code repository. You can check it out with TortoiseSVN here: [https://treesurgeon.svn.codeplex.com/svn](https://treesurgeon.svn.codeplex.com/svn)
# Add your feature.
# Create a subversion patch for your code from the root directory using the instructions found [here](http://tortoisesvn.net/docs/release/TortoiseSVN_en/tsvn-dug-patch.html).
# Submit the patch to the patch upload page. Go to [http://www.codeplex.com/treesurgeon/SourceControl/UploadPatch.aspx](http://www.codeplex.com/treesurgeon/SourceControl/UploadPatch.aspx) and upload the patch file.
# Update the issue (story) you were working on with a note that you've uploaded a patch
# Subscribe to the patch rss feed so that you know when a Committer adds comments to your submission.
# The project coordinators will evaluate and apply your patch
# If a committer makes some suggestions please take these at face value and help us keep a solid codebase. 

