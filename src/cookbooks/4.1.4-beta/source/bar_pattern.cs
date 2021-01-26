// Bar Fill Pattern
// Bar graph fill pattern can be customized.
var plt = new ScottPlot.Plot(600, 400);

var bar1 = plt.AddBar(new double[] { 10, 13, 15 }, new double[] { 1, 5, 9 });
bar1.HatchStyle = Drawing.HatchStyle.StripedUpwardDiagonal;
bar1.FillColor = Color.Gray;
bar1.FillColorHatch = Color.Black;
bar1.Label = "Series 1";

var bar2 = plt.AddBar(new double[] { 14, 15, 9 }, new double[] { 2, 6, 10 });
bar2.HatchStyle = Drawing.HatchStyle.StripedWideDownwardDiagonal;
bar2.FillColor = Color.DodgerBlue;
bar2.FillColorHatch = Color.DeepSkyBlue;
bar2.Label = "Series 2";

var bar3 = plt.AddBar(new double[] { 13, 6, 14 }, new double[] { 3, 7, 11 });
bar3.HatchStyle = Drawing.HatchStyle.LargeCheckerBoard;
bar3.FillColor = Color.SeaGreen;
bar3.FillColorHatch = Color.DarkSeaGreen;
bar3.Label = "Series 3";

// add a legend to display each labeled bar plot
plt.Legend(location: Alignment.UpperRight);

// adjust axis limits so there is no padding below the bar graph
plt.SetAxisLimits(yMin: 0, yMax: 20);

plt.SaveFig("bar_pattern.png");