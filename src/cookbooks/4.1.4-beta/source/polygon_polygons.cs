// Many Polygons
// Special rendering optimizations are available to display a large number of polygons.
var plt = new ScottPlot.Plot(600, 400);

// create a list of random polygons
List<List<(double x, double y)>> polys = new List<List<(double x, double y)>>();
int polygonCount = 5_000;
int pointsPerPolygon = 100;
Random rand = new Random(0);
for (int i = 0; i < polygonCount; i++)
{
    // random placement
    double polyX = rand.NextDouble() * 100;
    double polyY = rand.NextDouble() * 100;

    // points are random locations around a circle of random size
    double polyR = rand.NextDouble();
    double[] xs = Enumerable.Range(0, pointsPerPolygon).Select(x => polyR * Math.Cos(2.0 * Math.PI * x / pointsPerPolygon) + polyX).ToArray();
    double[] ys = Enumerable.Range(0, pointsPerPolygon).Select(x => polyR * Math.Sin(2.0 * Math.PI * x / pointsPerPolygon) + polyY).ToArray();

    // add this polygon to the list
    List<(double x, double y)> thisPolygon = xs.Zip(ys, (xp, yp) => (xp, yp)).ToList();
    polys.Add(thisPolygon);
}

// plot the list of polygons with one step
plt.AddPolygons(polys, fillColor: Color.Green);

// ensure X and Y pixel scales are the same (so circles aren't ovals)
plt.AxisScaleLock(true);

plt.SaveFig("polygon_polygons.png");