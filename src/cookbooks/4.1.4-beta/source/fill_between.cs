// Fill Between Curves
// Given two curves, a polygon can be created to give the appearance of shading between them. Here we will display two scatter plots, then create a polygon to fill the region between them.
var plt = new ScottPlot.Plot(600, 400);

// create sample data
double[] xs = DataGen.Range(0, 10, .1, true);
double[] ys1 = DataGen.Sin(xs);
double[] ys2 = DataGen.Cos(xs);

// add a polygon to fill the region between the two curves
plt.AddFill(xs, ys1, xs, ys2);

// add two scatter plots the traditional way
plt.AddScatter(xs, ys1, color: Color.Black);
plt.AddScatter(xs, ys2, color: Color.Black);

// tighten the axis limits so we don't see lines on the edges
plt.SetAxisLimits(xMin: 0, xMax: 10);

plt.SaveFig("fill_between.png");