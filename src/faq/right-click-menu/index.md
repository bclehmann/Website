---
title: Custom Right-Click Menu
description: How to add a custom right-click menu to ScottPlot user controls
---

# Custom Right-Click Menu

User controls have a `RightClicked` event handler you can add a custom event to. This event could open a context menu, but it could also perform other actions.

<div class='text-center'>

![](right-click-menu.gif)

</div>

## Windows Forms

[Download this example from GitHub](https://github.com/ScottPlot/Website/tree/main/src/faq/right-click-menu/src/)

```cs
public Form1()
{
    InitializeComponent();
    formsPlot1.RightClicked += CustomRightClickEvent;
}

private void CustomRightClickEvent(object sender, EventArgs e)
{
    ContextMenuStrip customMenu = new ContextMenuStrip();
    customMenu.Items.Add(new ToolStripMenuItem("Add Sine Wave", null, new EventHandler(AddSine)));
    customMenu.Items.Add(new ToolStripMenuItem("Clear Plot", null, new EventHandler(ClearPlot)));
    customMenu.Show(Cursor.Position);
}

private void AddSine(object sender, EventArgs e)
{
    Random rand = new Random();
    double[] data = ScottPlot.DataGen.Sin(51, phase: rand.NextDouble() * 1000);
    formsPlot1.Plot.AddSignal(data);
    formsPlot1.Plot.AxisAuto();
    formsPlot1.Render();
}

private void ClearPlot(object sender, EventArgs e)
{
    formsPlot1.Plot.Clear();
    formsPlot1.Plot.AxisAuto();
    formsPlot1.Render();
}
```