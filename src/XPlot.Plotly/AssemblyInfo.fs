﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("XPlot.Plotly")>]
[<assembly: AssemblyProductAttribute("XPlot")>]
[<assembly: AssemblyDescriptionAttribute("Data visualization library for F#")>]
[<assembly: AssemblyVersionAttribute("1.4.2")>]
[<assembly: AssemblyFileVersionAttribute("1.4.2")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "1.4.2"
    let [<Literal>] InformationalVersion = "1.4.2"
