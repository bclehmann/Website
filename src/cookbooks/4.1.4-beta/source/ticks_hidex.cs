// Disable X Ticks
// Ticks can be hidden on a single axis.
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// hide just the horizontal axis ticks
plt.XAxis.Ticks(false);

plt.SaveFig("ticks_hidex.png");