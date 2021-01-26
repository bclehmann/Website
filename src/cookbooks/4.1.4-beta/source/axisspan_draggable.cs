// Draggable Axis Span
// Axis spans can be dragged using the mouse. Drag limits are boundaries over which the edges of spans cannot cross.
var plt = new ScottPlot.Plot(600, 400);

// plot sample data
plt.AddSignal(DataGen.Sin(51));
plt.AddSignal(DataGen.Cos(51));

// dragging can be enabled and optionally limited to a range
var vSpan = plt.AddVerticalSpan(.15, .85);
vSpan.DragEnabled = true;
vSpan.DragLimitMin = -1;
vSpan.DragLimitMax = 1;

// spans can be configured to allow dragging but disallow resizing
var hSpan = plt.AddHorizontalSpan(10, 25);
hSpan.DragEnabled = true;
hSpan.DragFixedSize = true;

plt.SaveFig("axisSpan_draggable.png");