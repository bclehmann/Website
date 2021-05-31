---
Title: ScottPlot Cookbook
Description: Example plots shown next to the source code used to create them
---

# ScottPlot Cookbook

**The ScottPlot Cookbook is a collection of example plots shown next to the source code used to create them.** Because the API evolves over time, each cookbook is specific to the version of ScottPlot that was used to create it. 

<div class="d-flex justify-content-evenly">
    <div class="text-center m-3">
        <a class="btn btn-primary btn-lg fs-4" href="../cookbooks/latest">
            <svg xmlns="http://www.w3.org/2000/svg" width="32" height="32" fill="currentColor"
                class="bi bi-file-earmark-richtext-fill" viewBox="0 0 16 16">
                <path
                    d="M9.293 0H4a2 2 0 0 0-2 2v12a2 2 0 0 0 2 2h8a2 2 0 0 0 2-2V4.707A1 1 0 0 0 13.707 4L10 .293A1 1 0 0 0 9.293 0zM9.5 3.5v-2l3 3h-2a1 1 0 0 1-1-1zM7 6.25a.75.75 0 1 1-1.5 0 .75.75 0 0 1 1.5 0zm-.861 1.542 1.33.886 1.854-1.855a.25.25 0 0 1 .289-.047l1.888.974V9.5a.5.5 0 0 1-.5.5H5a.5.5 0 0 1-.5-.5V9s1.54-1.274 1.639-1.208zM5 11h6a.5.5 0 0 1 0 1H5a.5.5 0 0 1 0-1zm0 2h3a.5.5 0 0 1 0 1H5a.5.5 0 0 1 0-1z" />
            </svg>
            Latest Cookbook
        </a>
    </div>
    <div class="text-center m-3">
        <a class="btn btn-secondary btn-lg fs-4" href="https://www.fuget.org/packages/ScottPlot">
            <svg xmlns="http://www.w3.org/2000/svg" width="32" height="32" fill="currentColor"
                class="bi bi-gear-fill" viewBox="0 0 16 16">
                <path
                    d="M9.405 1.05c-.413-1.4-2.397-1.4-2.81 0l-.1.34a1.464 1.464 0 0 1-2.105.872l-.31-.17c-1.283-.698-2.686.705-1.987 1.987l.169.311c.446.82.023 1.841-.872 2.105l-.34.1c-1.4.413-1.4 2.397 0 2.81l.34.1a1.464 1.464 0 0 1 .872 2.105l-.17.31c-.698 1.283.705 2.686 1.987 1.987l.311-.169a1.464 1.464 0 0 1 2.105.872l.1.34c.413 1.4 2.397 1.4 2.81 0l.1-.34a1.464 1.464 0 0 1 2.105-.872l.31.17c1.283.698 2.686-.705 1.987-1.987l-.169-.311a1.464 1.464 0 0 1 .872-2.105l.34-.1c1.4-.413 1.4-2.397 0-2.81l-.34-.1a1.464 1.464 0 0 1-.872-2.105l.17-.31c.698-1.283-.705-2.686-1.987-1.987l-.311.169a1.464 1.464 0 0 1-2.105-.872l-.1-.34zM8 10.93a2.929 2.929 0 1 1 0-5.86 2.929 2.929 0 0 1 0 5.858z" />
            </svg>
            </svg>
            ScottPlot API
        </a>
    </div>
</div>

<div class="alert alert-primary" role="alert">
  <h4 class="alert-heading">⚠️ ScottPlot 4.1 Released in May, 2021</h4>
  Version 4.1 has some important changes from 4.0 which may affect existing projects.
  See the <a href="../faq/version-4.1">What's New in ScottPlot 4.1</a> page for a summary of major changes.
</div>

### ScottPlot API Reference

* [**ScottPlot.Plot**](https://www.fuget.org/packages/ScottPlot/latest/lib/netstandard2.0/ScottPlot.dll/ScottPlot/Plot) - This is the primary object users interact with to create and render plots
* [**ScottPlot.Plottable**](https://www.fuget.org/packages/ScottPlot/latest/lib/netstandard2.0/ScottPlot.dll/ScottPlot.Plottable) - This namespace contains all major plot types
* [**ScottPlot.DataGen**](https://www.fuget.org/packages/ScottPlot/latest/lib/netstandard2.0/ScottPlot.dll/ScottPlot/DataGen) - This class generates sample data useful for testing

### User Control API Reference
* [**Configuration**](https://www.fuget.org/packages/ScottPlot/latest/lib/netstandard2.0/ScottPlot.dll/ScottPlot.Control/Configuration) - This object is exposed in all controls and is used to modify their behavior
* [**ScottPlot.WinForms.FormsPlot**](https://www.fuget.org/packages/ScottPlot.WinForms/latest/lib/netcoreapp3.1/ScottPlot.WinForms.dll/ScottPlot/FormsPlot) - Windows Forms control
* [**ScottPlot.WPF.WpfPlot**](https://www.fuget.org/packages/ScottPlot.WPF/latest/lib/netcoreapp3.1/ScottPlot.WPF.dll/ScottPlot/WpfPlot) - Windows Presentation Foundation Control
* [**ScottPlot.Avalonia.AvaPlot**](https://www.fuget.org/packages/ScottPlot.Avalonia/latest/lib/netcoreapp3.1/ScottPlot.Avalonia.dll/ScottPlot.Avalonia/AvaPlot) - Avalonia Control


### Historical Cookbook Versions

New cookbooks are only generated after major features have been added to ScottPlot. 

Version | Date | Cookbook | Release Notes
---|---|---|---
4.1.16 | 2021-05-30 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.1.16) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.1.16)
4.1.14 | 2021-05-22 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.1.14) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.1.14)
4.1.13-beta | 2021-05-02 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.1.13-beta) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.1.13-beta)
4.1.12-beta | 2021-04-12 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.1.12-beta) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.1.12-beta)
4.1.11-beta | 2021-03-29 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.1.11-beta) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.1.11-beta)
4.1.10-beta | 2021-03-21 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.1.10-beta) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.1.10-beta)
4.1.9-beta | 2021-02-21 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.1.9-beta) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.1.9-beta)
4.1.8-beta | 2021-02-16 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.1.8-beta) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.1.8-beta)
4.1.7-beta | 2021-02-14 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.1.7-beta) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.1.7-beta)
4.1.6-beta | 2021-02-08 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.1.6-beta) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.1.6-beta)
4.1.5-beta | 2021-02-01 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.1.5-beta) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.1.5-beta)
4.1.4-beta | 2021-02-14 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.1.4-beta) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.1.4-beta)
4.1.3-beta | 2020-12-27 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.1.3-beta) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.1.3-beta)
4.1.2-beta | 2020-12-12 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.1.2-beta) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.1.2-beta)
4.0.47 | 2020-12-11 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.0.47) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.0.47)
4.0.46 | 2020-12-11 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.0.46) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.0.46)
4.0.44 | 2020-11-22 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.0.44) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.0.44)
4.0.40 | 2020-09-20 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.0.40) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.0.40)
4.0.38 | 2020-07-06 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.0.38) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.0.38)
4.0.36 | 2020-06-21 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.0.36) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.0.36)
4.0.35 | 2020-09-09 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.0.35) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.0.35)
4.0.32 | 2020-05-17 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.0.32) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.0.32)
4.0.31 | 2020-05-05 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.0.31) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.0.31)
4.0.30 | 2020-05-03 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.0.30) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.0.30)
4.0.29 | 2020-04-11 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.0.29) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.0.29)
4.0.28 | 2020-04-07 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.0.28) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.0.28)
4.0.27 | 2020-04-05 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.0.27) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.0.27)
4.0.26 | 2020-04-04 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.0.26) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.0.26)
4.0.25 | 2020-03-29 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.0.25) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.0.25)
4.0.24 | 2020-03-27 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.0.24) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.0.24)
4.0.23 | 2020-03-23 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.0.23) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.0.23)
4.0.22 | 2020-03-16 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.0.22) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.0.22)
4.0.21 | 2020-03-14 | [Cookbook](https://swharden.com/scottplot/cookbooks/4.0.21) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/4.0.21)
3.1.6 | 2019-10-10 | [Cookbook](https://swharden.com/scottplot/cookbooks/3.1.6) | [Release Notes](https://github.com/ScottPlot/ScottPlot/releases/tag/3.1.6)


* Late versions of `4.0.x` are stable, but as of late 2020 are no longer receiving major updates.

* Version `3.1.6` This is the last version that supported .NET Framework 4.5.
