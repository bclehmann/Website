// SignalConst Quickstart
// SignalConst plots pre-processes data to render much faster than Signal plots. Pre-processing takes a little time up-front and requires 4x the memory of Signal.
var plt = new ScottPlot.Plot(600, 400);

double[] values = DataGen.RandomWalk(1_000_000);
plt.AddSignal(values);
plt.Title("One Million Points");
plt.Benchmark();

plt.SaveFig("signalconst_quickstart.png");