{noformat}

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  Job-MOYFHY : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Namespace=dotNetTips.Spargine.Core.Xml.BenchmarkTests  Categories=XmlSerialization  

{noformat}
||            Method ||    Mean ||   Error ||  StdDev ||  StdErr ||     Min ||      Q1 ||  Median ||      Q3 ||     Max ||    Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 || Gen 1 ||Gen 2 ||Allocated ||Code Size ||
| *'Deserialize: XML'* | *26.59 μs* | *0.528 μs* | *1.235 μs* | *0.153 μs* | *24.26 μs* | *25.78 μs* | *26.24 μs* | *27.46 μs* | *29.56 μs* | *37,608.6* |      *0.5285 μs* |      *65.00* |    *2.521* |  *2.545* |   *0.5526* |    *3* |            *** |       *No* | *2.0142* |      *-* |     *-* |  *18.33 KB* |   *0.38 KB* |
|          *Serialize* | *18.32 μs* | *0.526 μs* | *1.517 μs* | *0.155 μs* | *15.72 μs* | *17.19 μs* | *18.18 μs* | *19.21 μs* | *22.19 μs* | *54,586.5* |      *0.5257 μs* |      *96.00* |    *2.574* |  *2.960* |   *0.4881* |    *2* |            *** |       *No* | *2.2583* | *0.0305* |     *-* |  *19.73 KB* |   *0.42 KB* |
|  *StringToXDocument* | *14.82 μs* | *0.474 μs* | *1.398 μs* | *0.140 μs* | *12.71 μs* | *13.62 μs* | *14.65 μs* | *15.77 μs* | *18.59 μs* | *67,457.1* |      *0.4742 μs* |     *100.00* |    *2.526* |  *2.667* |   *0.5986* |    *1* |            *** |       *No* | *1.7090* |      *-* |     *-* |  *15.52 KB* |   *0.37 KB* |
