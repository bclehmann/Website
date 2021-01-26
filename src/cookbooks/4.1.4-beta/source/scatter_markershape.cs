// All marker shapes
// Legend indicates names of all available marker shapes
var plt = new ScottPlot.Plot(600, 400);

int pointCount = 51;
double[] x = DataGen.Consecutive(pointCount);

string[] markerShapeNames = Enum.GetNames(typeof(MarkerShape));
for (int i = 0; i < markerShapeNames.Length; i++)
{
    Enum.TryParse(markerShapeNames[i], out MarkerShape ms);
    double[] sin = DataGen.Sin(pointCount, 2, -i);
    plt.AddScatter(x, sin, markerSize: 7, markerShape: ms, label: markerShapeNames[i]);
}

plt.Grid(enable: false);
var legend = plt.Legend();
legend.FontSize = 10;

plt.SaveFig("scatter_markerShape.png");