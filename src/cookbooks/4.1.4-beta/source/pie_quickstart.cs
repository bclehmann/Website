// Pie Chart
// A pie chart illustrates numerical proportions as slices of a circle.
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 778, 283, 184, 76, 43 };
plt.AddPie(values);

plt.SaveFig("pie_quickstart.png");