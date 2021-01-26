// Text Alignment and Rotation
// Advanced options are available to customize rotation and alignment. Note that if rotation is used, alignment is ignored.
var plt = new ScottPlot.Plot(600, 400);

int pointCount = 51;
double[] x = DataGen.Consecutive(pointCount);
double[] sin = DataGen.Sin(pointCount);
double[] cos = DataGen.Cos(pointCount);

plt.AddScatter(x, sin);
plt.AddScatter(x, cos);

plt.AddPoint(25, 0.8, color: Color.Green);
var t1 = plt.AddText(" Important Point (1)", 25, 0.8, 16, Color.Green);

plt.AddPoint(30, 0.3, color: Color.Black, size: 15);
var t2 = plt.AddText(" Default alignment (2)", 30, 0.3, 16);

plt.AddPoint(30, 0, color: Color.Black, size: 15);
var t3 = plt.AddText("Middle center (3)", 30, 0, 16);
t3.Alignment = Alignment.MiddleCenter;

plt.AddPoint(30, -0.3, color: Color.Black, size: 15);
var t4 = plt.AddText("Upper left (4)", 30, -0.3, 16);
t4.Alignment = Alignment.UpperLeft;

plt.AddPoint(5, -.5, color: Color.Blue, size: 15);
var t5 = plt.AddText(" Rotated Text (5)", 5, -.5, 16);
t5.Rotation = -30;

var t6 = plt.AddText(" Filled Background (6)", 15, -.6, 16);
t6.Color = Color.Red;
t6.FontBold = true;
t6.BackgroundFill = true;
t6.BackgroundColor = Color.LightBlue;

plt.SaveFig("text_alignment.png");