// Gradient Fill Above and Below
// Gradients can be used to fill above and below.
var plt = new ScottPlot.Plot(600, 400);

double[] data = DataGen.RandomWalk(1000);

plt.Style(Style.Gray1);
plt.Colorset(Drawing.Palette.OneHalfDark);

var sig = plt.AddSignal(data);
sig.MarkerSize = 0;
sig.Color = Color.Black;
sig.FillType = FillType.FillAboveAndBelow;
sig.FillColor1 = Color.FromArgb(255, 44, 160, 44); // Green
sig.GradientFillColor1 = Color.Transparent;
sig.FillColor2 = Color.FromArgb(255, 214, 39, 40); // Red
sig.GradientFillColor2 = Color.Transparent;
sig.BaselineY = 5;

plt.AxisAutoX(0);

plt.SaveFig("signal_gradientAboveAndBelowGradient.png");