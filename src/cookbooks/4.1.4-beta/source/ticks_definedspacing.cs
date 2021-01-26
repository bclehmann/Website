// Defined Tick Spacing
// The space between tick marks can be manually defined by setting the grid spacing.
var plt = new ScottPlot.Plot(600, 400);

// plot the positive data in the negative space
double[] values = DataGen.Sin(50);
var sig = plt.AddSignal(values);
sig.OffsetX = -50;

// then invert the sign of the axis tick labels
plt.XAxis.ManualTickSpacing(2);
plt.YAxis.ManualTickSpacing(.1);

plt.SaveFig("ticks_definedSpacing.png");