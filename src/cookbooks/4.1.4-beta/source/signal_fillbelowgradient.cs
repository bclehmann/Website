// Gradient Fill Below
// Signal plots can be filled below using a color gradient.
var plt = new ScottPlot.Plot(600, 400);

double[] data = DataGen.RandomWalk(1000);

var sig = plt.AddSignal(data);
sig.FillType = FillType.FillBelow;
sig.FillColor1 = Color.Blue;
sig.GradientFillColor1 = Color.Transparent;

plt.AxisAutoX(0);

plt.SaveFig("signal_fillBelowGradient.png");