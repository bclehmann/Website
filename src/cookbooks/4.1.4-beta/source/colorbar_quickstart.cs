// Colorbar
// A colorbar displays a colormap beside the data area. Colorbars are typically added to plots containing heatmaps.
var plt = new ScottPlot.Plot(600, 400);

plt.AddColorbar();

plt.SaveFig("colorbar_quickstart.png");