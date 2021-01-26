// Bar Graph with Defined Positions
// Horizontal positions for each bar can be defined manually. If you define bar positions, you will probably want to define the bar width as well.
var plt = new ScottPlot.Plot(600, 400);

// create sample data
double[] values = { 26, 20, 23, 7, 16 };
double[] positions = { 10, 20, 30, 40, 50 };

// add a bar graph to the plot
var bar = plt.AddBar(values, positions);

// customize the width of bars (80% of the inter-position distance looks good)
bar.BarWidth = (positions[1] - positions[0]) * .8;

// adjust axis limits so there is no padding below the bar graph
plt.SetAxisLimits(yMin: 0);

plt.SaveFig("bar_positions.png");