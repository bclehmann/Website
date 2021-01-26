// Bar Graph
// A simple bar graph can be created from a series of values. By default values are palced at X positions 0, 1, 2, etc.
var plt = new ScottPlot.Plot(600, 400);

// create sample data
double[] values = { 26, 20, 23, 7, 16 };

// add a bar graph to the plot
plt.AddBar(values);

// adjust axis limits so there is no padding below the bar graph
plt.SetAxisLimits(yMin: 0);

plt.SaveFig("bar_quickstart.png");