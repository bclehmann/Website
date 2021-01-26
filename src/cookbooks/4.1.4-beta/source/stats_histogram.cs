// Histogram
// The Histogram class makes it easy to get binned population information.
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
double[] values = DataGen.RandomNormal(rand, pointCount: 1000, mean: 50, stdDev: 20);
var hist = new ScottPlot.Statistics.Histogram(values, min: 0, max: 100);

// plot the bins as a bar graph (on the primary Y axis)
var bar = plt.AddBar(hist.counts, hist.bins);
bar.BarWidth = hist.binSize * 1.2; // oversize to reduce render artifacts
bar.BorderLineWidth = 0;
bar.YAxisIndex = 0;
plt.YAxis.Label("Count (#)");
plt.YAxis.Color(bar.FillColor);

// plot the mean curve as a scatter plot (on the secondary Y axis)
var sp = plt.AddScatter(hist.bins, hist.countsFracCurve);
sp.MarkerSize = 0;
sp.LineWidth = 2;
sp.YAxisIndex = 1;
plt.YAxis2.Label("Fraction");
plt.YAxis2.Color(sp.Color);
plt.YAxis2.Ticks(true);

// decorate the plot
plt.XAxis2.Label("Normal Random Data", bold: true);
plt.XAxis.Label("Value (units)");
plt.SetAxisLimits(yMin: 0);
plt.Grid(lineStyle: LineStyle.Dot);

plt.SaveFig("stats_histogram.png");