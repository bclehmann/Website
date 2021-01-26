// Spline Interpolation
// Interpolated splines create curves with many X/Y points to smoothly connect a limited number of input points.
var plt = new ScottPlot.Plot(600, 400);

// create a small number of X/Y data points and display them
double[] xs = { 0, 10, 20, 30 };
double[] ys = { 65, 25, 55, 80 };
plt.AddScatter(xs, ys, Color.Black, markerSize: 10, lineWidth: 0, label: "Original Data");

// Calculate the interpolated splines using three different methods:
//   Natural splines are "stiffer" than a polynomial interpolations and are less likely to oscillate.
//   Periodic splines are natural splines whose first and last point slopes are matched.
//   End slope splines let you define first and last data point slopes (defaults to zero).
var nsi = new ScottPlot.Statistics.Interpolation.NaturalSpline(xs, ys, resolution: 20);
var psi = new ScottPlot.Statistics.Interpolation.PeriodicSpline(xs, ys, resolution: 20);
var esi = new ScottPlot.Statistics.Interpolation.EndSlopeSpline(xs, ys, resolution: 20);

// plot the interpolated Xs and Ys
plt.AddScatter(nsi.interpolatedXs, nsi.interpolatedYs, Color.Red, markerSize: 3, label: "Natural Spline");
plt.AddScatter(psi.interpolatedXs, psi.interpolatedYs, Color.Green, markerSize: 3, label: "Periodic Spline");
plt.AddScatter(esi.interpolatedXs, esi.interpolatedYs, Color.Blue, markerSize: 3, label: "End Slope Spline");

plt.Legend();

plt.SaveFig("misc_interpolation.png");