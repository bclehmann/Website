// Draggable Axis Lines
// In GUI environments, axis lines can be draggable and moved with the mouse. Drag limits define the boundaries the lines can be dragged.
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// add axis lines and configure their drag settings
var hLine = plt.AddHorizontalLine(.85);
hLine.DragEnabled = true;
hLine.DragLimitMin = -1;
hLine.DragLimitMax = 1;

var vLine = plt.AddVerticalLine(23);
vLine.DragEnabled = true;
vLine.DragLimitMin = 0;
vLine.DragLimitMax = 50;

// you can access the position of an axis line at any time
Debug.WriteLine($"Vertical line is at X={vLine.X}");

plt.SaveFig("axisLine_draggable.png");