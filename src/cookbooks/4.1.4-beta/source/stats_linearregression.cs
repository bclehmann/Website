// Linear Regression
// A regression module is available to simplify the act of creating a linear regression line fitted to the data.
var plt = new ScottPlot.Plot(600, 400);

// Create some linear but noisy data
double[] ys = DataGen.NoisyLinear(null, pointCount: 100, noise: 30);
double[] xs = DataGen.Consecutive(ys.Length);
double x1 = xs[0];
double x2 = xs[xs.Length - 1];

// use the linear regression fitter to fit these data
var model = new ScottPlot.Statistics.LinearRegressionLine(xs, ys);

// plot the original data and add the regression line
plt.Title("Linear Regression\n" +
    $"Y = {model.slope:0.0000}x + {model.offset:0.0} " +
    $"(R² = {model.rSquared:0.0000})");
plt.AddScatter(xs, ys, lineWidth: 0);
plt.AddLine(model.slope, model.offset, (x1, x2), lineWidth: 2);

plt.SaveFig("stats_linearRegression.png");