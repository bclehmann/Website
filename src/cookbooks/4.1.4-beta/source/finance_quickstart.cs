// Candlestick Chart
// ScottPlot can draw some financial indicators on plots in X/Y space, but users looking to develop robust financial charts should probably look at other libraries designed specifically for financial charting. The biggest limitations are (1) lack of mouse interaction and (2) the horizontal axis is strictly numeric Cartesian space and is not ideal for plotting dates. That said, some financial charting is possible with ScottPlot, and this cookbook demonstrates common use cases.
var plt = new ScottPlot.Plot(600, 400);

// OHLCs are open, high, low, and closing prices for a time range.
OHLC[] prices = DataGen.RandomStockPrices(null, 60);
plt.AddCandlesticks(prices);

plt.SaveFig("finance_quickstart.png");