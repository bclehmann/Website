// Light1
// Customize many plot features using style presets
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// customize the plot style
plt.Style(Style.Light1);

plt.SaveFig("style_light1.png");