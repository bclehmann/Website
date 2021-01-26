// Scatter Plot with Errorbars
// An array of values can be supplied for error bars and redering options can be customized as desired
var plt = new ScottPlot.Plot(600, 400);

int pointCount = 20;
Random rand = new Random(0);
double[] xs = DataGen.Consecutive(pointCount);
double[] ys = DataGen.RandomWalk(rand, pointCount);
double[] xErr = DataGen.RandomNormal(rand, pointCount, .2);
double[] yErr = DataGen.RandomNormal(rand, pointCount);

var sp = plt.AddScatter(xs, ys);
sp.XError = xErr;
sp.YError = yErr;
sp.ErrorCapSize = 3;
sp.ErrorLineWidth = 1;
sp.LineStyle = LineStyle.Dot;

plt.SaveFig("scatter_errorbar.png");