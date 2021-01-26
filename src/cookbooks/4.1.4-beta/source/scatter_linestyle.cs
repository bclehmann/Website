// Custom lines
// Line color, size, and style can be customized. Setting markerSize to 0 prevents markers from being rendered.
var plt = new ScottPlot.Plot(600, 400);

int pointCount = 51;
double[] x = DataGen.Consecutive(pointCount);
double[] sin = DataGen.Sin(pointCount);
double[] cos = DataGen.Cos(pointCount);
double[] cos2 = DataGen.Cos(pointCount, mult: -1);

plt.AddScatter(x, sin, color: Color.Magenta, lineWidth: 0, markerSize: 10);
plt.AddScatter(x, cos, color: Color.Green, lineWidth: 5, markerSize: 0);
plt.AddScatter(x, cos2, color: Color.Blue, lineWidth: 3, markerSize: 0, lineStyle: LineStyle.DashDot);

var legend = plt.Legend();
legend.FixedLineWidth = false;

plt.SaveFig("scatter_lineStyle.png");