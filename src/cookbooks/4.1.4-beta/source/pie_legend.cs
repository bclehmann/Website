// Slices in Legend
// Slices can be labeled in the legend.
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 778, 43, 283, 76, 184 };
string[] labels = { "C#", "JAVA", "Python", "F#", "PHP" };
var pie = plt.AddPie(values);
pie.GroupNames = labels;
plt.Legend();

plt.SaveFig("pie_legend.png");