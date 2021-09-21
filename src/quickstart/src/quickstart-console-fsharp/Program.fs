open ScottPlot

[<EntryPoint>]
let main argv =
    let dataX = [| 1.0 .. 5.0 |]
    let dataY = [| for x in dataX -> x * x |]
    let plt = Plot(400, 300);
    plt.AddScatter(dataX, dataY);
    plt.SaveFig("quickstart.png");
    0
