// 5 Million Points
// Signal plots with millions of points can be interacted with in real time.
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
for (int i = 0; i < 5; i++)
{
    // add a new signal plot with one million points
    double[] values = DataGen.RandomWalk(rand, 1_000_000);
    plt.AddSignal(values);
}
plt.Benchmark(enable: true);

plt.SaveFig("signal_5millionPoints.png");