# Visual Studio Live! Las Vegas - March 2023  

## Description  
This repository contains slides and code samples for sessions presented at Visual Studio Live! Las Vegas - March 19-24, 2023.  

## Sessions  

**HOL01 - Asynchronous and Parallel Programming in C#**  
Level: Intermediate

Asynchronous programming is a critical skill to take full advantage of today's multi-core systems. But async programming brings its own set of issues. In this workshop, we'll work through some of those issues and get comfortable using parts of the .NET Task Parallel Library (TPL).  

We'll start by calling asynchronous methods using the Task Asynchronous Pattern (TAP), including how to handle exceptions and cancellation. With this in hand, we'll look at creating our own asynchronous methods and methods that use asynchronous libraries. Along the way, we'll see how to avoid deadlocks, how to isolate our code for easier async, and why it's important to stay away from "async void".  

In addition, we'll look at some patterns for running code in parallel, including using Parallel.ForEachAsync, channels, and other techniques. We'll see pros and cons so that we can use the right pattern for a particular problem.  

Throughout the day, we'll go hands-on with lab exercises to put these skills into practice.  

Objectives:  

* Use asynchronous methods with Task and await  
* Create asynchronous methods and libraries  
* How to avoid deadlocks and other pitfalls  
* Understand different parallel programming techniques  

Pre-Requisites:  

Basic understanding of C# and object-oriented programming (classes, inheritance, methods, and properties). No prior experience with asynchronous programming is necessary; we'll take care of that as we go.  

Attendee Requirements:

* You must provide your own laptop computer (Windows or Mac) for this hands-on lab.

* You need to have the .NET 6 SDK or .NET 7 SDK installed as well as the code editor of your choice (Visual Studio 2022 Community Edition or Visual Studio Code are both good (free) choices).

* Interactive labs, web application samples, and console samples will work with Windows, macOS, and Linux (anywhere .NET 6/7 will run).

* WPF desktop samples will only work on Windows machines. There are equivalent web and console examples for these projects.

Links:

* .NET 7.0 SDK
[https://dotnet.microsoft.com/en-us/download](https://dotnet.microsoft.com/en-us/download)

* Visual Studio 2022 (Community)
[https://visualstudio.microsoft.com/downloads/](https://visualstudio.microsoft.com/downloads/)
Note: Install the "ASP.NET and web development" workload for the labs and samples. Include ".NET desktop development" for "digit-display" sample and WPF-based samples.

* Visual Studio Code
[https://code.visualstudio.com/download](https://code.visualstudio.com/download)

Resources:  
* Slides: [/HOL01-Async-Programming/SLIDES-HOL01-Asynchronous-Programming-in-CSharp.pdf](./HOL01-Async-Programming/SLIDES-HOL01-Asynchronous-Programming-in-CSharp.pdf)
* Sample Code: [/HOL01-Async-Programming/](./HOL01-Async-Programming/)  
* Labs (for easy download): [https://github.com/jeremybytes/async-workshop-labs-only-2023](https://github.com/jeremybytes/async-workshop-labs-only-2023)

---  

**W03 - Catching Up with Interfaces in C#: What You Know Might be Wrong**  
Level: Intermediate  

C# 8 brought new features to interfaces, including default implementation, access modifiers, and static members. Then in C# 11, we got static abstract members. We'll look at these new features, and see where they are useful and where they should be avoided. The world of interfaces has changed; the line between interfaces and abstract classes has blurred; and C# now has multiple inheritance. With some practical tips, "gotchas", and plenty of examples, we'll see how to use these features effectively (and safely) in our code.  

You will learn:

* Pros and cons of default implementation in interfaces
* Why you may want a "private" interface member
* Why you need to be more explicit when using interfaces  

Resources:  
* Slides: [/W03-Catching-Up-With-Interfaces/SLIDES-W03-Catching-Up-With-CSharp-Interfaces.pdf](./W03-Catching-Up-With-Interfaces/SLIDES-W03-Catching-Up-With-CSharp-Interfaces.pdf)
* Sample Code: [/W03-Catching-Up-With-Interfaces/](./W03-Catching-Up-With-Interfaces/)

---

