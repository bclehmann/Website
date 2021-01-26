// CPH
// This example demonstrates how to plot a cumulative probability histogram (CPH) to compare the distribution of two datasets.
var plt = new ScottPlot.Plot(600, 400);

// create sample data for two datasets
Random rand = new Random(0);
double[] values1 = DataGen.RandomNormal(rand, pointCount: 1000, mean: 50, stdDev: 20);
double[] values2 = DataGen.RandomNormal(rand, pointCount: 1000, mean: 45, stdDev: 25);
var hist1 = new ScottPlot.Statistics.Histogram(values1, min: 0, max: 100);
var hist2 = new ScottPlot.Statistics.Histogram(values2, min: 0, max: 100);

// display datasets as step plots
var sp1 = plt.AddScatter(hist1.bins, hist1.cumulativeFrac);
sp1.Label = "Sample A";
sp1.StepDisplay = true;
sp1.MarkerSize = 0;

var sp2 = plt.AddScatter(hist2.bins, hist2.cumulativeFrac);
sp2.Label = "Sample B";
sp2.StepDisplay = true;
sp2.MarkerSize = 0;

// decorate the plot
plt.Legend();
plt.SetAxisLimits(yMin: 0, yMax: 1);
plt.Grid(lineStyle: LineStyle.Dot);
plt.Title("Cumulative Probability Histogram");
plt.XAxis.Label("Probability (fraction)");
plt.YAxis.Label("Value (units)");

plt.SaveFig("stats_cph.png");