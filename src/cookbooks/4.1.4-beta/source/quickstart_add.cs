// Manually Add a Plottable
// You can create a plot manually, then add it to the plot with Add(). This allows you to create custom plot types and add them to the plot.
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Consecutive(51);
double[] sin = DataGen.Sin(51);

// instantiate a plottable
var splt = new ScottPlot.Plottable.ScatterPlot(xs, sin);

// customize its style or change its data as desired
splt.Color = Color.Navy;
splt.MarkerSize = 10;
splt.MarkerShape = MarkerShape.filledDiamond;

// add it to the plot
plt.Add(splt);

plt.SaveFig("quickstart_add.png");