// Display first N points
// When plotting live data it is useful to allocate a large array in memory then fill it with values as they come in. By setting the maxRenderIndex property of a scatter plot to can prevent rendering the end of the array (which is probably filled with zeros).
var plt = new ScottPlot.Plot(600, 400);

// create an array larger than we intend to display
double[] values = DataGen.RandomWalk(1000);

// only render the first N points of the signal
var sig = plt.AddSignal(values);
sig.MaxRenderIndex = 500;

plt.SaveFig("signal_firstNpoints.png");