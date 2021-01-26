// Axis Line
// An axis line marks a position on an axis. Axis lines extend to positive and negative infinity on the other axis.
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// add axis lines
plt.AddHorizontalLine(.85);
plt.AddVerticalLine(23);

// customize axis lines with optional arguments
plt.AddVerticalLine(x: 33, color: Color.Magenta, width: 3, style: LineStyle.Dot);

plt.SaveFig("axisLine_basics.png");