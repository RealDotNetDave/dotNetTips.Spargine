{noformat}

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.300-preview.21180.15
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  Job-CJSTKQ : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Namespace=dotNetTips.Spargine.Extensions.BenchmarkTests.Tester  Categories=RandomData  

{noformat}
||                              Method ||     Mean ||    Error ||   StdDev ||   StdErr ||      Min ||       Q1 ||   Median ||       Q3 ||      Max ||     Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size || Gen 0 ||Gen 1 ||Gen 2 ||Allocated ||
|                   *'Creating: Person'* |  *6.632 μs* | *0.0438 μs* | *0.0388 μs* | *0.0104 μs* |  *6.587 μs* |  *6.597 μs* |  *6.625 μs* |  *6.658 μs* |  *6.718 μs* | *150,792.1* |      *0.0438 μs* |      *14.00* |    *2.353* |  *2.000* |   *0.6919* |    *1* |            *** |       *No* |   *0.72 KB* | *0.3357* |     *-* |     *-* |   *3.04 KB* |
|              *'Creating: PersonFixed'* |  *6.877 μs* | *0.1157 μs* | *0.0966 μs* | *0.0268 μs* |  *6.711 μs* |  *6.810 μs* |  *6.907 μs* |  *6.959 μs* |  *7.011 μs* | *145,409.4* |      *0.1157 μs* |      *13.00* |    *1.490* |  *2.000* |  *-0.2044* |    *2* |            *** |       *No* |   *0.72 KB* | *0.3357* |     *-* |     *-* |   *3.04 KB* |
|               *'Creating: PersonPlus'* |  *6.777 μs* | *0.0511 μs* | *0.0453 μs* | *0.0121 μs* |  *6.713 μs* |  *6.752 μs* |  *6.764 μs* |  *6.821 μs* |  *6.844 μs* | *147,550.3* |      *0.0511 μs* |      *14.00* |    *1.532* |  *2.000* |   *0.2900* |    *2* |            *** |       *No* |   *0.72 KB* | *0.3357* |     *-* |     *-* |   *3.04 KB* |
|             *'Creating: PersonProper'* |  *7.139 μs* | *0.0376 μs* | *0.0333 μs* | *0.0089 μs* |  *7.090 μs* |  *7.117 μs* |  *7.134 μs* |  *7.157 μs* |  *7.199 μs* | *140,076.0* |      *0.0376 μs* |      *14.00* |    *1.829* |  *2.000* |   *0.3376* |    *3* |            *** |       *No* |   *0.72 KB* | *0.3357* |     *-* |     *-* |   *3.04 KB* |
|             *'Creating: PersonRecord'* |  *8.439 μs* | *0.0982 μs* | *0.0919 μs* | *0.0237 μs* |  *8.307 μs* |  *8.367 μs* |  *8.427 μs* |  *8.508 μs* |  *8.580 μs* | *118,493.6* |      *0.0982 μs* |      *15.00* |    *1.494* |  *2.000* |   *0.0440* |    *4* |            *** |       *No* |   *1.15 KB* | *0.4425* |     *-* |     *-* |   *4.08 KB* |
| *'PropertiesToString(): PersonProper'* | *56.265 μs* | *0.1087 μs* | *0.0964 μs* | *0.0258 μs* | *56.069 μs* | *56.209 μs* | *56.286 μs* | *56.330 μs* | *56.380 μs* |  *17,772.9* |      *0.1087 μs* |      *14.00* |    *2.009* |  *2.000* |  *-0.6290* |    *6* |            *** |       *No* |   *1.18 KB* | *7.9956* |     *-* |     *-* |  *70.64 KB* |
| *'PropertiesToString(): PersonRecord'* | *38.360 μs* | *0.1318 μs* | *0.1169 μs* | *0.0312 μs* | *38.089 μs* | *38.298 μs* | *38.370 μs* | *38.402 μs* | *38.544 μs* |  *26,068.6* |      *0.1318 μs* |      *14.00* |    *2.992* |  *2.000* |  *-0.4129* |    *5* |            *** |       *No* |   *1.61 KB* | *5.0659* |     *-* |     *-* |  *44.99 KB* |