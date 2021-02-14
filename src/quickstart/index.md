---
Title: ScottPlot Quickstart
Description: These simple examples demonstrate how to use ScottPlot in the console, WinForms, WPF, or Avalonia
---

# ScottPlot Quickstart

* These examples demonstrate how to plot simple data with ScottPlot
* The **[ScottPlot Cookbook](http://swharden.com/scottplot/cookbook)** has many more advanced examples

<div class="alert alert-warning" role="alert">
  <h4 class="alert-heading">⚠️ Pre-Release Documentation</h4>
  This documentation is specific to <strong>ScottPlot 4.1</strong> which is currently available as a pre-release package on NuGet
</div>

**Table of Contents:**

![](TOC)

## Console Quickstart

**Step 1:** Install the [`ScottPlot`](https://www.nuget.org/packages/ScottPlot) NuGet package

**Step 2:** Add the following to your start-up sequence:

```cs
double[] dataX = new double[] { 1, 2, 3, 4, 5 };
double[] dataY = new double[] { 1, 4, 9, 16, 25 };
var plt = new ScottPlot.Plot(400, 300);
plt.AddScatter(dataX, dataY);
plt.SaveFig("quickstart.png");
```

![](src/console-quickstart/screenshot.png)

_Source code for this application is [available on GitHub](https://github.com/ScottPlot/Website/tree/main/src/quickstart/src/quickstart-console)_

## Windows Forms Quickstart

**Step 1:** Install the [`ScottPlot.WinForms`](https://www.nuget.org/packages/ScottPlot.WinForms) NuGet package

**Step 2:** Drag a `FormsPlot` from the Toolbox onto your Form

**Step 3:** Plot some data in your start-up sequence

```cs
double[] dataX = new double[] {1, 2, 3, 4, 5};
double[] dataY = new double[] {1, 4, 9, 16, 25};
formsPlot1.Plot.AddScatter(dataX, dataY);
```

![](src/quickstart-winforms/screenshot.png)

_Source code for this application is [available on GitHub](https://github.com/ScottPlot/Website/tree/main/src/quickstart/src/quickstart-winforms)_

## WPF Quickstart

**Step 1:** Install ScottPlot.WPF [using NuGet](https://docs.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-in-visual-studio)

**Step 2:** Add a WpfPlot to your layout area and give it a unique name
```xaml
<WpfPlot Name="wpfPlot1" />
```

**Step 3:** Plot some data in your start-up sequence

```cs
double[] dataX = new double[] {1, 2, 3, 4, 5};
double[] dataY = new double[] {1, 4, 9, 16, 25};
wpfPlot1.Plot.AddScatter(dataX, dataY);
```

![](scottplot-quickstart-wpf.png)


## Avalonia Quickstart

**Step 1:** Install ScottPlot.Avalonia [using NuGet](https://docs.microsoft.com/en-us/nuget/quickstart/install-and-use-a-package-in-visual-studio)

**Step 2:** Add an AvaPlot to your layout area and give it a unique name
```xaml
<AvaPlot Name="avaPlot1"/>
```

**Step 3:** Plot some data in your start-up sequence

```cs
var avaplot1 = this.Find<AvaPlot>("avaPlot1");

double[] dataX = new double[] { 1, 2, 3, 4, 5 };
double[] dataY = new double[] { 1, 4, 9, 16, 25 };
avaplot1.Plot.AddScatter(dataX, dataY);
```

![](scottplot-quickstart-avalonia.png)
