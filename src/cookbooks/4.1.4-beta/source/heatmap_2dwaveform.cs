// 2D Waveform
// This example demonstrates a heatmap with 1000 tiles
var plt = new ScottPlot.Plot(600, 400);

int width = 100;
int height = 100;

double[,] intensities = new double[width, height];

for (int x = 0; x < width; x++)
    for (int y = 0; y < height; y++)
        intensities[x, y] = (Math.Sin(x * .2) + Math.Cos(y * .2)) * 100;

var hm = plt.AddHeatmap(intensities);
var cb = plt.AddColorbar(hm);

plt.SaveFig("heatmap_2dWaveform.png");