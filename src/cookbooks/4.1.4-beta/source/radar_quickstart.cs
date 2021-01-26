// Radar
// A radar chart concisely displays multiple values. Radar plots are also called a spider charts or star charts.
var plt = new ScottPlot.Plot(600, 400);

double[,] values = {
    { 78,  83, 84, 76, 43 },
    { 100, 50, 70, 60, 90 }
};

plt.AddRadar(values);

// improve plot styling
plt.Frameless();
plt.Grid(enable: false);

plt.SaveFig("radar_quickstart.png");