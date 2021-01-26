// Fill Above and Below
// Signal plots can be filled above and below
var plt = new ScottPlot.Plot(600, 400);

double[] data = DataGen.RandomWalk(1000);

var sig = plt.AddSignal(data);
sig.FillType = FillType.FillAboveAndBelow;
sig.FillColor1 = Color.Green;
sig.GradientFillColor1 = Color.Green;
sig.FillColor2 = Color.Red;
sig.GradientFillColor2 = Color.Red;
sig.BaselineY = 5;

plt.AxisAutoX(0);

plt.SaveFig("signal_fillAboveAndBelow.png");