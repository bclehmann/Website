// Bars with Y Offsets
// By default bar graphs start at 0, but this does not have to be the case. Y offsets can be defined for each bar. When Y offsets are used, values represent the height of the bars (relative to their offsets).
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 23, 17, 19, 24, 22 };
double[] yOffsets = { -100, -100, -100, -100, -100 };

var bar = plt.AddBar(values);
bar.YOffsets = yOffsets;

// adjust axis limits so there is no padding below the bar graph
plt.SetAxisLimits(yMin: -100);

plt.SaveFig("bar_yoffset.png");