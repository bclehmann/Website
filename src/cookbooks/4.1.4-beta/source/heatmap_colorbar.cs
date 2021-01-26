// Heatmap with Colorbar
// Colorbars are often added when heatmaps are used.
var plt = new ScottPlot.Plot(600, 400);

double[,] data2D = { { 1, 2, 3 },
         { 4, 5, 6 } };

var hm = plt.AddHeatmap(data2D);
var cb = plt.AddColorbar(hm);

plt.SaveFig("heatmap_colorbar.png");