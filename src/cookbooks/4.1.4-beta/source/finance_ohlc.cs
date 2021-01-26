// OHLC Chart
// OHLC charts are an alternative to candlestick charts. They show high and low prices as a vertical line, and indicate open and close prices with little ticks to the left and to the right.
var plt = new ScottPlot.Plot(600, 400);

OHLC[] prices = DataGen.RandomStockPrices(null, 60);
plt.AddOHLCs(prices);

plt.SaveFig("finance_ohlc.png");