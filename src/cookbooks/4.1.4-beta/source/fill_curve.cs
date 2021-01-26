// Fill Under Curve
// Fill methods help to create semitransparent polygons to fill the area under a curve. This can be used to give the appearance of shading under a scatter plot, even though the plottable created here is a polygon with optional edge color and fill color.
var plt = new ScottPlot.Plot(600, 400);

// create sample data
double[] xs = DataGen.Range(0, 10, .1, true);
double[] ys1 = DataGen.Sin(xs);
double[] ys2 = DataGen.Cos(xs);

// add filled polygons
plt.AddFill(xs, ys1);
plt.AddFill(xs, ys2, baseline: -.25);

// tighten the axis limits so we don't see lines on the edges
plt.SetAxisLimits(xMin: 0, xMax: 10);

plt.SaveFig("fill_curve.png");