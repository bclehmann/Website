// Custom Tick Label Culture
// SetCulture() as arguments to let the user manually define formatting strings which will be used globally to change how numbers and dates are formatted.
var plt = new ScottPlot.Plot(600, 400);

// generate 10 days of data
int pointCount = 10;
double[] values = DataGen.RandomWalk(null, pointCount);
double[] days = new double[pointCount];
DateTime day1 = new DateTime(1985, 09, 24);
for (int i = 0; i < days.Length; i++)
    days[i] = day1.AddDays(1).AddDays(i).ToOADate();

// plot the data with custom tick format (https://tinyurl.com/ycwh45af)
plt.AddScatter(days, values);
plt.XAxis.TickLabelFormat("M\\/dd", dateTimeFormat: true);

plt.SaveFig("ticks_cultureCustom.png");