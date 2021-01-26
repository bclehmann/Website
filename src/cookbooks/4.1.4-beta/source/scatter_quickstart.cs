// Scatter Plot Quickstart
// Scatter plots are best for small numbers of paired X/Y data points. For evenly-spaced data points Signal is much faster.
var plt = new ScottPlot.Plot(600, 400);

// create sample X/Y data
int pointCount = 51;
double[] x = DataGen.Consecutive(pointCount);
double[] sin = DataGen.Sin(pointCount);
double[] cos = DataGen.Cos(pointCount);

// add scatter plots
plt.AddScatter(x, sin);
plt.AddScatter(x, cos);

plt.SaveFig("scatter_quickstart.png");