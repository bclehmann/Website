// Signal Plot Quickstart
// Signal plots are ideal for evenly-spaced data with thousands or millions of points.
var plt = new ScottPlot.Plot(600, 400);

double[] values = DataGen.RandomWalk(null, 100_000);
int sampleRate = 20_000;

// Signal plots require a data array and a sample rate (points per unit)
plt.AddSignal(values, sampleRate);

plt.Benchmark(enable: true);
plt.Title($"Signal Plot: One Million Points");

plt.SaveFig("signal_quickstart.png");