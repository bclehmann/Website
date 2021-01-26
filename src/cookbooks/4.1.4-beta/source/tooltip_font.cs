// Tooltip Font
// Tooltips fonts can be customized
var plt = new ScottPlot.Plot(600, 400);

double[] ys = DataGen.Sin(50);
plt.AddSignal(ys);

var tt1 = plt.AddTooltip("Top", 12, ys[12]);
tt1.Font.Color = System.Drawing.Color.Magenta;
tt1.Font.Size = 24;

var tt2 = plt.AddTooltip("Negative Slope", 25, ys[25]);
tt2.Font.Name = "Comic Sans MS";
tt2.Font.Bold = true;

plt.SaveFig("tooltip_font.png");