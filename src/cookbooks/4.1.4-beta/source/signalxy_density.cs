// Different Densities
// Signal with mised low and high density data
var plt = new ScottPlot.Plot(600, 400);

Random rand = new Random(0);
int pointCount = 1_000_000;
double[] sine = DataGen.Sin(pointCount, 3);
double[] noise = DataGen.RandomNormal(rand, pointCount, 0, 0.5);
double[] ys = sine.Zip(noise, (s, n) => s + n).ToArray();
double[] xs = new double[pointCount];

double currentX = 0;
for (int i = 0; i < pointCount; i++)
{
    if ((i % 100000) < 10)
        currentX += 10;
    else
        currentX += 0.0001;
    xs[i] = currentX;
}

plt.AddSignalXY(xs, ys);

plt.SaveFig("signalxy_density.png");