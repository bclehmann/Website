// Scale Limits
// Heatmap colormap scale can use a defined min/max value.
var plt = new ScottPlot.Plot(600, 400);

double[,] intensities = new double[100, 100];
for (int x = 0; x < 100; x++)
    for (int y = 0; y < 100; y++)
        intensities[x, y] = (Math.Sin(x * .2) + Math.Cos(y * .2)) * 100;

var hm = plt.AddHeatmap(intensities);
hm.Update(intensities, min: 0, max: 200);

var cb = plt.AddColorbar(hm);

plt.SaveFig("heatmap_limitScale.png");