---
Title: ScottPlot - Interactive Plotting Library for .NET
Description: ScottPlot is a free and open-source plotting library for .NET that makes it easy to interactively display large datasets. Line plots, bar charts, pie graphs, scatter plots, and more can be created with just a few lines of code.
---

# ScottPlot

**ScottPlot is a free and open-source plotting library for .NET** that makes it easy to interactively display large datasets. Line plots, bar charts, pie graphs, scatter plots, and more can be created with just a few lines of code.

* [**ScottPlot Cookbook**](cookbook) 👈 ***See what ScottPlot can do!***

* [**ScottPlot Overview**](overview) - Core concepts summarized for new users

* [**ScottPlot FAQ**](faq) - Code examples demonstrating common tasks and answering frequently asked questions



<div class="text-center">

![](scottplot.gif)

</div>

### Quickstart

Create an interactive plot in less than a minute!

* [Windows Forms](quickstart#windows-forms-quickstart)
* [WPF](quickstart#wpf-quickstart)
* [Avalonia](quickstart#avalonia-quickstart)
* [Console Application](quickstart#console-quickstart)

### Supported Platforms

* .NET 5.0
* .NET Core 2.0 and newer
* .NET Framework 4.6.1 and newer

_ScottPlot [3.1.6](https://github.com/ScottPlot/ScottPlot/releases/tag/3.1.6) was the final version to support .NET Framework 4.5_

_Linux and MacOS users may need to install [libgdiplus](quickstart#libgdiplus) to use ScottPlot_

### ScottPlot Cookbook

The [**ScottPlot Cookbook**](cookbook) demonstrates how to create line plots, bar charts, pie graphs, scatter plots, and more with just a few lines of code. An interactive version of every cookbook example is available as part of the [ScottPlot Demo](demo) application.

<div class="text-center">

[![](cookbook/cookbook-thumbnails-small.jpg)](cookbook)

</div>

### Plot in the Cloud with ScottPlot

**This figure is an example of ScottPlot running in the cloud.** Every hour an [Azure Function](https://azure.microsoft.com/en-us/services/functions/) hits the [GitHub API](https://docs.github.com/en/rest) to get an updated list of stargazers, then uses ScottPlot to create a figure from this data and saves it to web-accessible blob storage. Since this automatically-generated plot is just a static image accessible by a URL, it can be displayed in places where JavaScript is not permitted (like in this readme file). Creating plots as images on a server allows dynamic plots to be displayed in many interesting places!

<p align="center">
  <a href="https://stargraph.z20.web.core.windows.net/scottplot-stars.png" target="_blank">
    <img src="https://stargraph.z20.web.core.windows.net/scottplot-stars.png?">
  </a>
</p>

### Miscellaneous

* **If you enjoy ScottPlot** you can [***give us a star***](https://github.com/ScottPlot/ScottPlot) ⭐

* **New features** are listed on the [releases](https://github.com/ScottPlot/ScottPlot/releases) page

* **Contributions are welcome!** See [contributing.md](https://github.com/ScottPlot/ScottPlot/blob/master/CONTRIBUTING.md) to get started

### About ScottPlot
ScottPlot was created by [Scott W Harden](https://www.swharden.com/wp/about-scott/) (with many contributions from the open-source community) and is provided under the permissive [MIT license](https://github.com/ScottPlot/ScottPlot/blob/master/LICENSE).