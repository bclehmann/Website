// Ruler mode
// Ruler mode is an alternative way to display axis ticks. It draws long ticks and offsets the tick labels to give the appearance of a ruler.
var plt = new ScottPlot.Plot(600, 400);

plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

plt.XAxis.RulerMode(true);
plt.YAxis.RulerMode(true);

plt.SaveFig("asis_ruler.png");