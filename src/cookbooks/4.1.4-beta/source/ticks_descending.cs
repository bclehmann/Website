// Descending Ticks
// ScottPlot will always display data where X values ascend from left to right. To simulate an inverted axis (where numbers decrease from left to right) plot data in the negative space, then invert the sign of tick labels.
var plt = new ScottPlot.Plot(600, 400);

// plot the positive data in the negative space
double[] values = DataGen.Sin(50);
var sig = plt.AddSignal(values);
sig.OffsetX = -50;

// then invert the sign of the axis tick labels
plt.XAxis.TickLabelNotation(invertSign: true);
plt.YAxis.TickLabelNotation(invertSign: true);

plt.SaveFig("ticks_descending.png");