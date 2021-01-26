// Population Plot
// The population plot makes it easy to display populations as bar graphs, box-and-whisker plots, scattered values, or box plots and data points side-by-side. The population plot is different than using a box plot with an error bar in that you pass your original data into the population plot and it determines the standard deviation, standard error, quartiles, mean, median, outliers, etc., and you get to determine how to display these values.
var plt = new ScottPlot.Plot(600, 400);

// create sample data to represent test scores
Random rand = new Random(0);
double[] scores = DataGen.RandomNormal(rand, 35, 85, 5);

// First, create a Population object from your test scores
var pop = new Statistics.Population(scores);

// You can access population statistics as public fields
plt.Title($"Mean: {pop.mean} +/- {pop.stdErr}");

// You can plot a population
plt.AddPopulation(pop);

// improve the style of the plot
plt.XAxis.Ticks(true);
plt.XAxis.Grid(false);

plt.SaveFig("population_quickstart.png");