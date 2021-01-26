// Quantiles
// A q-Quantile is a generalization of quartiles and percentiles to any number of buckets.
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 500;
double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.Random(rand, pointCount);

// A septile is a 7-quantile
double secondSeptile = Statistics.Common.Quantile(ys, 2, 7);

plt.Title("Second Septile");
plt.AddScatter(xs, ys, lineWidth: 0, markerShape: MarkerShape.openCircle);
plt.AddHorizontalLine(secondSeptile, width: 3, style: LineStyle.Dash);

plt.SaveFig("stats_quantiles.png");