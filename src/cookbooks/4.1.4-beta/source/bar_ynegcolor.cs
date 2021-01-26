// Negative Bar Colors
// Bars with negative values can be colored differently than positive ones.
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 23, -17, 19, -24, 22 };

var bar = plt.AddBar(values);
bar.FillColor = Color.Green;
bar.FillColorNegative = Color.Red;

plt.SaveFig("bar_yNegColor.png");