// Fill Below
// Signal plots can be filled below with a solid color.
var plt = new ScottPlot.Plot(600, 400);

double[] data = DataGen.RandomWalk(1000);

var sig = plt.AddSignal(data);
sig.FillType = FillType.FillBelow;
sig.FillColor1 = Color.Blue;

plt.AxisAutoX(0);

plt.SaveFig("signal_fillBelow.png");