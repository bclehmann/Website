// Values Above Bars
// The value of each bar can be displayed above it.
var plt = new ScottPlot.Plot(600, 400);

// create sample data
double[] values = { 27.3, 23.1, 21.2, 16.1, 6.4, 19.2, 18.7, 17.3, 20.3, 13.1 };

// add a bar graph to the plot and enable values to be displayed above each bar
var bar = plt.AddBar(values);
bar.ShowValuesAboveBars = true;

// adjust axis limits so there is no padding below the bar graph
plt.SetAxisLimits(yMin: 0);

plt.SaveFig("bar_values.png");