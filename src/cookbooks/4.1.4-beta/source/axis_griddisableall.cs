// Disable Grid
// Visibility of primary X and Y grids can be set using a single method.
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// hide grids
plt.Grid(false);

plt.SaveFig("axis_gridDisableAll.png");