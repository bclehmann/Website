// Bar Graph with Error Bars
// Errorbars can be added to any bar graph.
var plt = new ScottPlot.Plot(600, 400);

// add a bar graph to the plot
double[] values = { 26, 20, 23, 7, 16 };
var bar = plt.AddBar(values);

// add errorbars to the bar graph and customize styling as desired
double[] errors = { 3, 2, 5, 1, 3 };
bar.YErrors = errors;
bar.ErrorCapSize = .1;

// adjust axis limits so there is no padding below the bar graph
plt.SetAxisLimits(yMin: 0);

plt.SaveFig("bar_error.png");