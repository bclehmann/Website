// Image Alignment
// By default the X/Y coordinates define the upper left position of the image, but alignment can be customized.
var plt = new ScottPlot.Plot(600, 400);

// display some sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// display an image with 3 different alignments
Bitmap monaLisa = DataGen.SampleImage();
var ip1 = new ScottPlot.Plottable.Image() { Bitmap = monaLisa, X = 10 };
var ip2 = new ScottPlot.Plottable.Image() { Bitmap = monaLisa, X = 25, Alignment = Alignment.MiddleCenter };
var ip3 = new ScottPlot.Plottable.Image() { Bitmap = monaLisa, X = 40, Alignment = Alignment.LowerRight };

plt.Add(ip1);
plt.Add(ip2);
plt.Add(ip3);

plt.AddPoint(ip1.X, ip1.Y, Color.Magenta, size: 20);
plt.AddPoint(ip2.X, ip2.Y, Color.Magenta, size: 20);
plt.AddPoint(ip3.X, ip3.Y, Color.Magenta, size: 20);

plt.SaveFig("image_alignment.png");