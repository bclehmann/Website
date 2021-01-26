// Additional Y Axis
// Additional axes can be added on any edge. Additional axes stack away from the plot area.
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

plt.SaveFig("multiAxis_additional.png");