// Right Y Axis
// This example shows how to display a Y axis only on the right side.
var plt = new ScottPlot.Plot(600, 400);

double[] values = DataGen.RandomWalk(100);
plt.AddSignal(values);

plt.YAxis.Ticks(false);
plt.YAxis2.Ticks(true);
plt.YAxis2.Label("Value");
plt.XAxis.Label("Sample Number");

plt.SaveFig("multiAxis_right.png");