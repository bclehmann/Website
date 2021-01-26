// Speed Test
// Compare the speed to the same data plotted as a scatter plot.
var plt = new ScottPlot.Plot(600, 400);

double[] xs = DataGen.Consecutive(100_000, 1.0 / 20_000);
double[] values = DataGen.RandomWalk(null, 100_000);

plt.AddScatter(xs, values, Color.Red, markerSize: 0);

plt.Benchmark(enable: true);
plt.Title($"Scatter Plot: One Million Points");

plt.SaveFig("signal_advantage.png");