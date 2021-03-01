{noformat}

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  Job-HSBDIC : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests.Tester  Categories=RandomData  

{noformat}
||                              Method ||     Mean ||    Error ||   StdDev ||   StdErr ||      Min ||       Q1 ||   Median ||       Q3 ||      Max ||     Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size || Gen 0 ||Gen 1 ||Gen 2 ||Allocated ||
|                   *'Creating: Person'* |  *6.458 μs* | *0.0051 μs* | *0.0045 μs* | *0.0012 μs* |  *6.449 μs* |  *6.455 μs* |  *6.458 μs* |  *6.460 μs* |  *6.466 μs* | *154,852.1* |      *0.0051 μs* |      *14.00* |    *2.335* |  *2.000* |  *-0.1355* |    *1* |            *** |       *No* |   *0.72 KB* | *0.3357* |     *-* |     *-* |   *3.04 KB* |
|              *'Creating: PersonFixed'* |  *6.431 μs* | *0.0076 μs* | *0.0068 μs* | *0.0018 μs* |  *6.422 μs* |  *6.427 μs* |  *6.431 μs* |  *6.436 μs* |  *6.446 μs* | *155,488.8* |      *0.0076 μs* |      *14.00* |    *2.255* |  *2.000* |   *0.4336* |    *1* |            *** |       *No* |   *0.72 KB* | *0.3357* |     *-* |     *-* |   *3.04 KB* |
|               *'Creating: PersonPlus'* |  *6.750 μs* | *0.0855 μs* | *0.0800 μs* | *0.0207 μs* |  *6.650 μs* |  *6.686 μs* |  *6.726 μs* |  *6.802 μs* |  *6.895 μs* | *148,155.4* |      *0.0855 μs* |      *15.00* |    *1.746* |  *2.000* |   *0.4670* |    *3* |            *** |       *No* |   *0.72 KB* | *0.3357* |     *-* |     *-* |   *3.04 KB* |
|             *'Creating: PersonProper'* |  *6.578 μs* | *0.0548 μs* | *0.0512 μs* | *0.0132 μs* |  *6.493 μs* |  *6.530 μs* |  *6.600 μs* |  *6.612 μs* |  *6.659 μs* | *152,025.8* |      *0.0548 μs* |      *15.00* |    *1.485* |  *2.000* |  *-0.1663* |    *2* |            *** |       *No* |   *0.72 KB* | *0.3357* |     *-* |     *-* |   *3.04 KB* |
|             *'Creating: PersonRecord'* |  *9.419 μs* | *0.1826 μs* | *0.2789 μs* | *0.0501 μs* |  *8.359 μs* |  *9.323 μs* |  *9.509 μs* |  *9.514 μs* |  *9.789 μs* | *106,173.3* |      *0.1826 μs* |      *31.00* |    *8.127* |  *2.000* |  *-2.0330* |    *4* |            *** |       *No* |   *1.15 KB* | *0.4425* |     *-* |     *-* |   *4.08 KB* |
| *'PropertiesToString(): PersonProper'* | *56.467 μs* | *0.7828 μs* | *0.7323 μs* | *0.1891 μs* | *55.881 μs* | *55.931 μs* | *55.962 μs* | *57.328 μs* | *57.758 μs* |  *17,709.6* |      *0.7828 μs* |      *15.00* |    *1.450* |  *2.000* |   *0.6473* |    *6* |            *** |       *No* |   *1.18 KB* | *7.8735* |     *-* |     *-* |  *70.55 KB* |
| *'PropertiesToString(): PersonRecord'* | *36.219 μs* | *0.3713 μs* | *0.3291 μs* | *0.0880 μs* | *35.922 μs* | *36.042 μs* | *36.082 μs* | *36.125 μs* | *36.882 μs* |  *27,609.8* |      *0.3713 μs* |      *14.00* |    *2.586* |  *2.000* |   *1.1916* |    *5* |            *** |       *No* |    *1.6 KB* | *5.0049* |     *-* |     *-* |  *44.89 KB* |
