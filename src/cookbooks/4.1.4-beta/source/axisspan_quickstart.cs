// Axis Span
// Axis spans shade a portion of one axis. Axis spans extend to negative and positive infinity on the other axis.
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// add axis spans
plt.AddVerticalSpan(.15, .85);
plt.AddHorizontalSpan(10, 25);

plt.SaveFig("axisSpan_quickstart.png");