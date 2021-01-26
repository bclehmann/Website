// Polygon Quickstart
// Polygons are 2D shapes made from pairs of X/Y points. The last point connects back to the first point, forming a closed shape. Polygons can be optionally outlined and optionally filled. Colors with semitransparency are especially useful for polygons.
var plt = new ScottPlot.Plot(600, 400);

double[] xs1 = { 2, 8, 6, 4 };
double[] ys1 = { 3, 4, 0.5, 1 };
plt.AddPolygon(xs1, ys1);

double[] xs2 = { 3, 2.5, 5 };
double[] ys2 = { 4.5, 1.5, 2.5 };
plt.AddPolygon(xs2, ys2, plt.GetNextColor(.5), lineWidth: 2);

plt.SaveFig("polygon_quickstart.png");