// Styled Signal Plot
// Signal plots can be styled using public fields. Signal plots can also be offset by a defined X or Y amount.
var plt = new ScottPlot.Plot(600, 400);

double[] ys = DataGen.RandomWalk(null, 500);
int sampleRate = 10;

var sp2 = plt.AddSignal(ys, sampleRate, Color.Magenta);
sp2.OffsetY = 1000;
sp2.OffsetX = 300;
sp2.LineStyle = LineStyle.Dash;
sp2.LineWidth = 2;

plt.SaveFig("signal_styled.png");