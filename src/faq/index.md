---
Title: ScottPlot FAQ
Description: Frequently asked questions about the ScottPlot library, user controls, and implementation suggestions.
---

## ScottPlot FAQ

* Read the [**ScottPlot Overview**](https://swharden.com/scottplot/overview) for a general introduction to the ScottPlot API

* Look over the [**ScottPlot Cookbook**](https://swharden.com/scottplot/cookbook) for code examples demonstrating common use cases

* This page contains answers to frequently asked questions and notes about uncommon use cases

<div class="alert alert-warning" role="alert">
  <h4 class="alert-heading">⚠️ Pre-Release Documentation</h4>
  This documentation is specific to <strong>ScottPlot 4.1</strong> which is currently available as a pre-release package on NuGet
</div>

<div class="alert alert-primary" role="alert">
  <h4 class="alert-heading">⚠️ This page is in development</h4>
  This page is being actively worked on in February, 2021. See <a href="https://github.com/ScottPlot/Website/issues/6">issue #6</a> for progress details.
</div>

### Plot: Axis and Ticks
* [Plot Data using a DateTime Axis](datetime)
* [Plot Data on Multiple or Non-Standard Axes](multi-axis)

### Plot: Styling
* [Custom Padding around the Data Area](padding)
* [Frameless Plots and Data Margin](padding/#frameless-plot)
* [Anti-Aliasing](anti-aliasing)

### Plot: Data
* [How to Plot Data Containing Gaps](data-gaps)

### Plot: Miscellaneous
* [MultiPlot: Multiple Plots in a Single Image](multiplot)
* [MVVM Pattern and Data Binding](mvvm)

### User Control: Interactive Behavior
* [Low Quality while Dragging](anti-aliasing)
* [Share Axes Between Plots](shared-axes)
* [Custom Right-Click Menu](right-click-menu)
* [Get the Mouse Position](mouse-position)
* [Show the Value of the Point Under the Cursor](mouse-position#highlight-the-data-point-near-the-cursor)

### User Control: Live Data
* [How to display live, changing data in a ScottPlot control](live-data)
  * [Changing Values in Fixed-Length Data](live-data/#changing-fixed-length-data)
  * [Rolling/Shifting Values in Fixed-Length Data](live-data/#rolling-fixed-length-data)
  * [Growing Data with Partial Array Rendering](live-data/#growing-data-with-partial-array-rendering)
  * [Growing Data with ScatterPlotList](live-data/#growing-data-with-scatterplotlist)
  * [Growing Data with SignalPlotList](live-data/#growing-data-with-signalplotlist)

### About ScottPlot
* [Who Created ScottPlot and Why?](history)
* [How Does ScottPlot Compare to Other Plotting Libraries?](compare)