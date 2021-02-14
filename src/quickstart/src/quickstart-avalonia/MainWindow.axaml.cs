using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using ScottPlot.Avalonia;

namespace ScottPlot.Demo.Avalonia
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            var avaplot1 = this.Find<AvaPlot>("AvaPlot1");

            double[] dataX = new double[] { 1, 2, 3, 4, 5 };
            double[] dataY = new double[] { 1, 4, 9, 16, 25 };
            avaplot1.Plot.AddScatter(dataX, dataY);
        }
        public void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
