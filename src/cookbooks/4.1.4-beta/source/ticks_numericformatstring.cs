// Numeric Format String
// Tick labels can be converted to text using a custom format string.
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// See https://tinyurl.com/y86clj9k to learn about numeric format strings
plt.XAxis.TickLabelFormat("E2", dateTimeFormat: false);
plt.YAxis.TickLabelFormat("P1", dateTimeFormat: false);

plt.SaveFig("ticks_numericFormatString.png");