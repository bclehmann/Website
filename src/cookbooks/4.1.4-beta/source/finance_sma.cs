// Simple Moving Average (SMA)
// A simple moving average (SMA) technical indicator can be calculated and drawn as a scatter plot.
var plt = new ScottPlot.Plot(600, 400);

// generate sample stock prices
OHLC[] ohlcs = DataGen.RandomStockPrices(null, 75);
double[] xs = DataGen.Consecutive(ohlcs.Length);

// calculate SMAs of different durations using helper methods
double[] sma8xs = xs.Skip(8).ToArray();
double[] sma8ys = Statistics.Finance.SMA(ohlcs, 8);
double[] sma20xs = xs.Skip(20).ToArray();
double[] sma20ys = Statistics.Finance.SMA(ohlcs, 20);

// plot technical indicators as scatter plots above the financial chart
plt.AddCandlesticks(ohlcs);
plt.AddScatter(sma8xs, sma8ys, markerSize: 0, color: Color.Blue, lineWidth: 2);
plt.AddScatter(sma20xs, sma20ys, markerSize: 0, color: Color.Navy, lineWidth: 2);

plt.SaveFig("finance_sma.png");