// Fill Above and Below
// Sometimes you want to share the area under a curve, but change its color depending on which side of the baseline value it is. There's a helper method to make this easier.
var plt = new ScottPlot.Plot(600, 400);

// create sample data
Random rand = new Random(3);
double[] xs = DataGen.Consecutive(201);
double[] ys = DataGen.RandomWalk(rand, xs.Length);

// add filled polygons
plt.AddFillAboveAndBelow(xs, ys);

// tighten the axis limits so we don't see lines on the edges
plt.SetAxisLimits(xMin: 0, xMax: 200);

plt.SaveFig("fill_aboveBelow.png");