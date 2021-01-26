// Multiplier Notation
// Multiplier notation keeps tick labels small when plotting large data values.
var plt = new ScottPlot.Plot(600, 400);

double[] largeXs = DataGen.Consecutive(100, spacing: 1e6);
double[] largeYs = DataGen.Random(null, 100, multiplier: 1e6);

plt.AddScatter(largeXs, largeYs);
plt.XAxis.TickLabelNotation(multiplier: true);

plt.SaveFig("ticks_multiplier.png");