## How to setup a .NET Development Tree - Introduction

In the last few weeks I've setup 2 brand new .Development Trees for .NET projects. What do I mean by development tree?

* It is a directory structure 
* containing: 
	* source files 
	* tools and dependencies 
	* references to external tools and dependencies 
* checked into source control 
* that is atomically integratable 
* to produce a set of artifacts 

A good development tree should:

* be easily integratable on new environments 
* require little maintainance 
* but be easily maintainable when it does require maintenance 
* support, but not hamper, developer productivity 
* have consistent behaviour 

This is all a bit wooly, but will do for an intial stab. I might come back and refine these points later. 

Anyway, I've setup quite a few development trees in my time, in Java and .NET. In this series of blog entries I hope to develop a good 'boilerplate' development tree structure for .NET projects that other people can use. 