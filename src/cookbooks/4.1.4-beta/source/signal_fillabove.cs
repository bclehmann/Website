// Gradient Fill Above
// Signal plots can be filled above using a color gradient.
var plt = new ScottPlot.Plot(600, 400);

double[] data = DataGen.RandomWalk(1000);

var sig = plt.AddSignal(data);
sig.FillType = FillType.FillAbove;
sig.FillColor1 = Color.Blue;
sig.GradientFillColor1 = Color.Transparent;

plt.AxisAutoX(0);

plt.SaveFig("signal_fillAbove.png");