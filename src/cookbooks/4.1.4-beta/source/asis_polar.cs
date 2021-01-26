// Polar Coordinates
// A helper function converts radius and theta arrays into Cartesian coordinates suitable for plotting with traditioanl plot types.
var plt = new ScottPlot.Plot(600, 400);

// create data with polar coordinates
int count = 400;
double step = 0.01;

double[] rs = new double[count];
double[] thetas = new double[count];

for (int i = 0; i < rs.Length; i++)
{
    rs[i] = 1 + i * step;
    thetas[i] = i * 2 * Math.PI * step;
}

// convert polar data to Cartesian data
(double[] xs, double[] ys) = ScottPlot.Tools.ConvertPolarCoordinates(rs, thetas);

// plot the Cartesian data
plt.AddScatter(xs, ys);

// decorate the plot
plt.Title("Scatter Plot of Polar Data");
plt.AxisScaleLock(true);

plt.SaveFig("asis_polar.png");