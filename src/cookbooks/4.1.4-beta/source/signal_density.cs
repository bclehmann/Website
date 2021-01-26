// Display data density
// When plotting extremely high density data, you can't always see the trends underneath all those overlapping data points. If you send an array of colors to PlotSignal(), it will use those colors to display density.
var plt = new ScottPlot.Plot(600, 400);

// create an extremely noisy signal with a subtle sine wave beneath it
Random rand = new Random(0);
int pointCount = 100_000;
double[] signal1 = DataGen.Sin(pointCount, 3);
double[] noise = DataGen.RandomNormal(rand, pointCount, 0, 5);
double[] data = new double[pointCount];
for (int i = 0; i < data.Length; i++)
    data[i] = signal1[i] + noise[i];

// plot the noisy signal using the traditional method
var sp1 = plt.AddSignal(data);
sp1.OffsetY = -40;
sp1.Color = Color.Red;

// use a custom colors to display data of different densities
string[] colorCodes = { "#440154", "#39568C", "#1F968B", "#73D055" };
Color[] colors = colorCodes.Select(x => ColorTranslator.FromHtml(x)).ToArray();

var sp2 = plt.AddSignal(data);
sp2.DensityColors = colors;

plt.Title("Color by Density vs. Solid Color");
plt.AxisAuto(0, .1);

plt.SaveFig("signal_density.png");