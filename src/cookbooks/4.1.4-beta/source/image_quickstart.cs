// Image Quickstart
// The Image plottable places a Bitmap at a location in X/Y space.The image's position will move in space as the axes move, but the size of the bitmap will always be the same (matched to the display resolution). 
var plt = new ScottPlot.Plot(600, 400);

// display some sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// create the bitmap we want to display
Bitmap monaLisa = DataGen.SampleImage();

// create the image plottable and add it to the plot
var imagePlot = new ScottPlot.Plottable.Image() { Bitmap = monaLisa, X = 10, Y = .5 };

plt.Add(imagePlot);

plt.SaveFig("image_quickstart.png");