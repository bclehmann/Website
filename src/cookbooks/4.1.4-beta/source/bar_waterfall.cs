// Waterfall Bar Graph
// Waterfall bar graphs use bars to represent changes in value from the previous level. This style graph can be created by offseting each bar by the sum of all bars preceeding it. This effect is similar to financial plots (OHLC and Candlestick) which are described in another section.
var plt = new ScottPlot.Plot(600, 400);

double[] values = DataGen.RandomNormal(0, 12, 5, 10);
double[] offsets = Enumerable.Range(0, values.Length).Select(x => values.Take(x).Sum()).ToArray();

var bar = plt.AddBar(values);
bar.YOffsets = offsets;
bar.FillColorNegative = Color.Red;
bar.FillColor = Color.Green;

plt.SaveFig("bar_waterfall.png");