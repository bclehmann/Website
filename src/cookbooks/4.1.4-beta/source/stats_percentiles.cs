// Percentiles
// Percentiles are a good tool to analyze the distribution of your data and filter out extreme values.
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 500;
double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.Random(rand, pointCount);

double tenthPercentile = Statistics.Common.Percentile(ys, 10);

plt.Title("10th Percentile");
plt.AddScatter(xs, ys, lineWidth: 0, markerShape: MarkerShape.openCircle);
plt.AddHorizontalLine(tenthPercentile, width: 3, style: LineStyle.Dash);

plt.SaveFig("stats_percentiles.png");