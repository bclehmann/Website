// Using a DateTime Axis
// You probably never want to do this... but OHLCs have an X value you can customize to be a DateTime (converted to a double using DateTime.ToOATime()). The advantage is that you can use the native DateTime axis support on the horizontal axis. The disadvantage is that gaps in time appear as gaps in the candlesticks. Weekends without trading will appear as gaps. The alternative to this method is to plot a series of OHLCs using sequential numbers, then manually define the axis tick labels.
var plt = new ScottPlot.Plot(600, 400);

OHLC[] prices = DataGen.RandomStockPrices(null, 60, TimeSpan.FromDays(1));

// add the OHLCs to the plot and the horizontal axis to display DateTime tick labels
plt.AddCandlesticks(prices);
plt.XAxis.DateTimeFormat(true);

plt.SaveFig("finance_dateTimeAxis.png");