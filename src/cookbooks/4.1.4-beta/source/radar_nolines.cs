// No Axis Lines
// A radar chart can have no drawn axis as well.
var plt = new ScottPlot.Plot(600, 400);

double[,] values = {
        { 78, 83, 84, 76, 43 },
        { 100, 50, 70, 60, 90 }
    };

var radarPlot = plt.AddRadar(values);
radarPlot.AxisType = RadarAxis.None;
radarPlot.ShowAxisValues = false;

plt.SaveFig("radar_noLines.png");