// Slice Values
// The value of each slice can be displayed at its center.
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 778, 43, 283, 76, 184 };
var pie = plt.AddPie(values);
pie.ShowValues = true;

plt.SaveFig("pie_showValues.png");