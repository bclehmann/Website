// Colorbar Ticks
// Tick marks can be added to colorbars. Each tick is described by a position (a fraction of the distance from the bottom to the top) and a string (the tick label).
var plt = new ScottPlot.Plot(600, 400);

var cb = plt.AddColorbar();
cb.AddTick(0, "-123");
cb.AddTick(1, "+123");
cb.AddTick(.5, "0");
cb.AddTick(.25, "-61.5");
cb.AddTick(.75, "+61.5");

plt.SaveFig("colorbar_ticks.png");