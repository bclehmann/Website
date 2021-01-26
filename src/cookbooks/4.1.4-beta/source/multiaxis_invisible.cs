// Axis Visibility
// Visibility of axes can be toggled. In this example an additional Y axis is added but the primary Y axis is hidden. The result is a plot that appears to only have one Y axis.
var plt = new ScottPlot.Plot(600, 400);

// plot one set of data using the primary Y axis
var sigSmall = plt.AddSignal(DataGen.Sin(51, mult: 1));
sigSmall.YAxisIndex = 0;
plt.YAxis.Label("Primary Axis");
plt.YAxis.Color(sigSmall.Color);

// plot another set of data using an additional axis
var sigBig = plt.AddSignal(DataGen.Cos(51, mult: 100));
var yAxis3 = plt.AddAxis(Renderable.Edge.Left, axisIndex: 2);
sigBig.YAxisIndex = 2;
yAxis3.Label("Additional Axis");
yAxis3.Color(sigBig.Color);

// hide the primary Y axis
plt.YAxis.IsVisible = false;

plt.SaveFig("multiAxis_invisible.png");