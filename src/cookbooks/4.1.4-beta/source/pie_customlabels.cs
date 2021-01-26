// Custom Slice Labels
// Custom slice labels can be used to display values using custom formats
var plt = new ScottPlot.Plot(600, 400);

double[] values = { 778, 43, 283, 76, 184 };
string[] labels = { "C#", "JAVA", "Python", "F#", "PHP" };

// modify labels to include a custom formatted value
labels = Enumerable.Range(0, values.Length)
       .Select(i => $"{labels[i]}\n({values[i]})")
       .ToArray();

var pie = plt.AddPie(values);
pie.GroupNames = labels;
pie.ShowLabels = true;

plt.SaveFig("pie_customLabels.png");