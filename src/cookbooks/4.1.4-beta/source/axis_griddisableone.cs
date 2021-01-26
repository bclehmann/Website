// Disable Vertical Grid
// Grid line visibility can be controlled for each axis individually. Use this to selectively enable grid lines only for the axes of interest. Keep in mind that vertical grid lines are controlled by horizontal axes.
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// each axis has its own visibility controls
plt.XAxis.Grid(false);

plt.SaveFig("axis_gridDisableOne.png");