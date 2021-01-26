// Text
// The Text plottable displays a string at an X/Y coordinate in unit space. Unlike the Annotation plottable, text moves when the axes are adjusted.
var plt = new ScottPlot.Plot(600, 400);

int pointCount = 51;
double[] x = DataGen.Consecutive(pointCount);
double[] sin = DataGen.Sin(pointCount);
double[] cos = DataGen.Cos(pointCount);

plt.AddScatter(x, sin);
plt.AddScatter(x, cos);

plt.AddText("sample text", 10, .5, size: 16, color: Color.Blue);

plt.SaveFig("text_quickstart.png");