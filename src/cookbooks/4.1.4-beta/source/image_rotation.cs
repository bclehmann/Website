// Image Rotation
// Images can be rotated, but rotation is always relative to the upper left corner.
var plt = new ScottPlot.Plot(600, 400);

// display some sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// place a rotated image on the plot
Bitmap monaLisa = DataGen.SampleImage();
var ip1 = new ScottPlot.Plottable.Image() { Bitmap = monaLisa, X = 10, Y = .5, Rotation = 30 };
plt.Add(ip1);
plt.AddPoint(ip1.X, ip1.Y, color: Color.Magenta, size: 20);

plt.SaveFig("image_rotation.png");