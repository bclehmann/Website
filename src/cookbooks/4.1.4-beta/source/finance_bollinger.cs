// Bollinger Bands
// Bollinger bands are a common technical indicator that show the average +/- two times the standard deviation of a given time range preceeding it.
var plt = new ScottPlot.Plot(600, 400);

// generate sample stock prices
OHLC[] ohlcs = DataGen.RandomStockPrices(null, 100);
double[] xs = DataGen.Consecutive(ohlcs.Length);

// calculate the bands and the time range they cover
double[] xs2 = xs.Skip(20).ToArray();
(var sma, var bolL, var bolU) = Statistics.Finance.Bollinger(ohlcs, 20);

// plot technical indicators as scatter plots above the financial chart
plt.AddCandlesticks(ohlcs);
plt.AddScatter(xs2, sma, markerSize: 0, color: Color.Blue);
plt.AddScatter(xs2, bolL, markerSize: 0, color: Color.Blue, lineStyle: LineStyle.Dash);
plt.AddScatter(xs2, bolU, markerSize: 0, color: Color.Blue, lineStyle: LineStyle.Dash);

plt.SaveFig("finance_bollinger.png");