// Horizontal Scale Bar
// Set the vertical or horizontal sizer to zero and the scale bar will only span one dimension.
var plt = new ScottPlot.Plot(600, 400);

// plot sample data 
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// remove horizontal scale only
plt.XAxis.Ticks(false);
plt.Frame(visible: false, left: true);
plt.Grid(enable: false);

// add a horizontal scale bar (no Y height)
plt.AddScaleBar(5, 0, "100 ms", null);

plt.SaveFig("scalebar_horizontal.png");