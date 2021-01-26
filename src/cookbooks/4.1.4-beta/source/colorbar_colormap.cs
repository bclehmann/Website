// Colorbar for Colormap
// By default colorbars use the Viridis colormap, but this behavior can be customized and many colormaps are available.
var plt = new ScottPlot.Plot(600, 400);

plt.AddColorbar(Drawing.Colormap.Turbo);

plt.SaveFig("colorbar_colormap.png");