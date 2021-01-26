// Plot a Range of Points
// It is sometimes useful to only display values within a range of the source data array.
var plt = new ScottPlot.Plot(600, 400);

// create an array larger than we intend to display
double[] values = DataGen.RandomWalk(1000);

// only render values between the two defined indexes
var sig = plt.AddSignal(values);
sig.MinRenderIndex = 400;
sig.MaxRenderIndex = 500;

plt.SaveFig("signal_range.png");