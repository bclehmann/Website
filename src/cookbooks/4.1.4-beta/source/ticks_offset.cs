// Offset Notation
// Offset notation keeps tick labels small when plotting large data values that are close together.
var plt = new ScottPlot.Plot(600, 400);

double[] largeXs = DataGen.Consecutive(100, spacing: 1e6);
double[] largeYs = DataGen.Random(null, 100, multiplier: 1e6);

plt.AddScatter(largeXs, largeYs);
plt.XAxis.TickLabelNotation(offset: true);

plt.SaveFig("ticks_offset.png");