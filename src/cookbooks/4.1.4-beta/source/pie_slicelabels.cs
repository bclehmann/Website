// Slice Labels
// The label for each slice can be displayed at its center.
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 778, 43, 283, 76, 184 };
string[] labels = { "C#", "JAVA", "Python", "F#", "PHP" };
var pie = plt.AddPie(values);
pie.GroupNames = labels;
pie.ShowLabels = true;

plt.SaveFig("pie_sliceLabels.png");