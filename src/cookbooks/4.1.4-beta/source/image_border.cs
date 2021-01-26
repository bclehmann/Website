// Image Border
// The borders of images can be customized.
var plt = new ScottPlot.Plot(600, 400);

// display some sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// place an image on the plot
plt.Add(new ScottPlot.Plottable.Image()
{
    Bitmap = DataGen.SampleImage(),
    X = 10,
    Y = .5,
    Rotation = 30,
    BorderColor = Color.Magenta,
    BorderSize = 5,
});

plt.SaveFig("image_border.png");