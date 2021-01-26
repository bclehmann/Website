// Tooltip Colors
// Tooltips border and fill styles can be customized
var plt = new ScottPlot.Plot(600, 400);

double[] ys = DataGen.Sin(50);
plt.AddSignal(ys);

var tt = plt.AddTooltip("This point has\na negative slope", 25, ys[25]);
tt.Font.Size = 24;
tt.Font.Color = System.Drawing.Color.White;
tt.FillColor = System.Drawing.Color.Blue;
tt.BorderWidth = 5;
tt.BorderColor = System.Drawing.Color.Navy;
tt.ArrowSize = 15;

plt.SaveFig("tooltip_colors.png");