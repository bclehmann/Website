// Manual Tick Labels
// Tick positions and labels can be defined manually.
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// manually define X axis tick positions and labels
double[] xPositions = { 7, 21, 37, 46 };
string[] xLabels = { "VII", "XXI", "XXXVII", "XLVI" };
plt.XAxis.ManualTickPositions(xPositions, xLabels);

// manually define Y axis tick positions and labels
double[] yPositions = { -1, 0, .5, 1 };
string[] yLabels = { "bottom", "center", "half", "top" };
plt.YAxis.ManualTickPositions(yPositions, yLabels);

plt.SaveFig("ticks_defined.png");