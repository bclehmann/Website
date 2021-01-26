// Log Scale
// ScottPlot will only display data on a linear 2D plane, however you can log-transform data before plotting it to give the appearance of log scales. Customizing tick options for log-spaced minor ticks further improves appearance of these graphs.
var plt = new ScottPlot.Plot(600, 400);

// generate some interesting log-distributed data
int pointCount = 200;
double[] dataXs = new double[pointCount];
double[] dataYs = new double[pointCount];
Random rand = new Random(0);
for (int i = 0; i < pointCount; i++)
{
    double x = 10.0 * i / pointCount;
    dataXs[i] = x;
    dataYs[i] = Math.Pow(2, x) + rand.NextDouble() * i;
}

// this tool can convert linear data to log data
double[] dataYsLog = ScottPlot.Tools.Log10(dataYs);
plt.AddScatter(dataXs, dataYsLog, lineWidth: 0);

// place minor ticks to simulate a log scale
plt.YAxis.MinorLogScale(true);

// make minor grid lines visible for added effect
plt.YAxis.MinorGrid(enable: true, color: Color.FromArgb(10, Color.Black));

// decorate the plot
plt.Title("Data (Log Scale)");
plt.YLabel("Vertical Units (10^x)");
plt.XLabel("Horizontal Units");

plt.SaveFig("asis_log.png");