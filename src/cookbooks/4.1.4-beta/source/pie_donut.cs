// Donut Chart
// Donut plots are pie charts with a hollow center.
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 778, 283, 184, 76, 43 };
var pie = plt.AddPie(values);
pie.Explode = true;
pie.DonutSize = .6;

plt.SaveFig("pie_donut.png");