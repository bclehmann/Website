// Tick Label Culture
// Large numbers and dates are formatted differently for different cultures. Hungarian uses spaces to separate large numbers and periods to separate fields in dates.
var plt = new ScottPlot.Plot(600, 400);

// generate some data
double[] price = DataGen.RandomWalk(null, 60 * 8, 10000);
DateTime start = new DateTime(2019, 08, 25, 8, 30, 00);
double pointsPerDay = 24 * 60;

// create the plot
var sig = plt.AddSignal(price, pointsPerDay);
sig.OffsetX = start.ToOADate();

// set the localization
var culture = System.Globalization.CultureInfo.CreateSpecificCulture("hu"); // Hungarian
plt.SetCulture(culture);

// further decorate the plot
plt.XAxis.DateTimeFormat(true);
plt.YAxis.Label("Price");
plt.XAxis.Label("Date and Time");
plt.XAxis2.Label("Hungarian Formatted DateTime Tick Labels");

plt.SaveFig("ticks_culture.png");