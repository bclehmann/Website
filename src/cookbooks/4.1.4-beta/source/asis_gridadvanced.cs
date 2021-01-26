// Advanced Grid Customization
// Grid lines can be extensively customized using various configuration methods.
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// advanced grid customizations are available by accessing Axes directly
plt.XAxis.MajorGrid(color: Color.FromArgb(100, Color.Black));
plt.XAxis.MinorGrid(enable: true, color: Color.FromArgb(20, Color.Black));
plt.YAxis.MajorGrid(lineWidth: 2, lineStyle: LineStyle.Dash, color: Color.Magenta);

plt.SaveFig("asis_gridAdvanced.png");