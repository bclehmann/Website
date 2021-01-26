// Horizontal Bar Graph
// Bar graphs are typically displayed as columns, but it's possible to show bars as rows.
var plt = new ScottPlot.Plot(600, 400);

// create sample data
double[] values = { 26, 20, 23, 7, 16 };
double[] errors = { 3, 2, 5, 1, 3 };
double[] positions = { 1, 2, 3, 4, 5 };

// add a bar graph to the plot and customize it to render horizontally
var bar = plt.AddBar(values, errors, positions);
bar.VerticalOrientation = false;

// adjust axis limits so there is no padding to the left of the bar graph
plt.SetAxisLimits(xMin: 0);

plt.SaveFig("bar_horizontal.png");