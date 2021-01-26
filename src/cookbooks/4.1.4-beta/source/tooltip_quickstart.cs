// Tooltip Quickstart
// Tooltips are annotations that point to an X/Y coordinate on the plot
var plt = new ScottPlot.Plot(600, 400);

double[] ys = DataGen.Sin(50);
plt.AddSignal(ys);

plt.AddTooltip(label: "Special Point", x: 17, y: ys[17]);

plt.SaveFig("tooltip_quickstart.png");