// Nth Order Statistics
// The Nth order statistic of a set is the Nth smallest value of the set (indexed from 1).
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 500;
double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.Random(rand, pointCount);

int n = 200;
double nthValue = Statistics.Common.NthOrderStatistic(ys, n);

plt.Title($"{n}th Smallest Value (of {pointCount})");
plt.AddScatter(xs, ys, lineWidth: 0, markerShape: MarkerShape.openCircle);
plt.AddHorizontalLine(nthValue, width: 3, style: LineStyle.Dash);

plt.SaveFig("stats_orderStatistics.png");