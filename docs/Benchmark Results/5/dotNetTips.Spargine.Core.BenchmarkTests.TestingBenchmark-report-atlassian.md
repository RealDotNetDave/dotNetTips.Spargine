{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19042.1165 (20H2/October2020Update)
Unknown processor
.NET SDK=6.0.100-preview.7.21379.14
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
  Job-UTOYIO : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 5.0  
Namespace=dotNetTips.Spargine.Core.BenchmarkTests  Categories=TESTS  

{noformat}
||          Method ||      Mean ||    Error ||   StdDev ||   StdErr ||       Min ||        Q1 ||    Median ||        Q3 ||       Max ||           Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Ratio ||RatioSD ||  Welch(10%)/p-values ||Rank ||                                                      LogicalGroup ||Baseline ||Code Size ||Allocated ||
| *AggressiveInline* |  *0.2628 ns* | *0.0047 ns* | *0.0044 ns* | *0.0011 ns* |  *0.2570 ns* |  *0.2600 ns* |  *0.2616 ns* |  *0.2652 ns* |  *0.2705 ns* | *3,805,379,723.9* |      *0.0047 ns* |      *15.00* |    *1.746* |  *2.000* |   *0.3713* |  *0.98* |    *0.02* |   *Same: 1.0000|1.0000* |    *1* | *Job-UTOYIO(EvaluateOverhead=True, Server=True, Toolchain=.NET 5.0)* |       *No* |      *24 B* |         *-* |
|         *Baseline* |  *0.2675 ns* | *0.0055 ns* | *0.0051 ns* | *0.0013 ns* |  *0.2620 ns* |  *0.2637 ns* |  *0.2662 ns* |  *0.2696 ns* |  *0.2770 ns* | *3,738,593,239.7* |      *0.0055 ns* |      *15.00* |    *1.983* |  *2.000* |   *0.7972* |  *1.00* |    *0.00* |             *Base: ?|?* |    *1* | *Job-UTOYIO(EvaluateOverhead=True, Server=True, Toolchain=.NET 5.0)* |      *Yes* |      *24 B* |         *-* |
|         *NoInline* |  *2.1192 ns* | *0.0692 ns* | *0.0680 ns* | *0.0170 ns* |  *2.0285 ns* |  *2.0431 ns* |  *2.1229 ns* |  *2.1740 ns* |  *2.2083 ns* |   *471,884,111.6* |      *0.0692 ns* |      *16.00* |    *1.318* |  *2.857* |  *-0.0910* |  *7.92* |    *0.31* | *Slower: 0.0000|1.0000* |    *3* | *Job-UTOYIO(EvaluateOverhead=True, Server=True, Toolchain=.NET 5.0)* |       *No* |      *97 B* |         *-* |
|   *NoOptimization* |  *0.2722 ns* | *0.0026 ns* | *0.0023 ns* | *0.0006 ns* |  *0.2689 ns* |  *0.2707 ns* |  *0.2712 ns* |  *0.2740 ns* |  *0.2767 ns* | *3,673,745,712.9* |      *0.0026 ns* |      *14.00* |    *1.909* |  *2.000* |   *0.5160* |  *1.02* |    *0.02* |   *Same: 1.0000|1.0000* |    *2* | *Job-UTOYIO(EvaluateOverhead=True, Server=True, Toolchain=.NET 5.0)* |       *No* |      *24 B* |         *-* |
|      *PreserveSig* |  *0.2724 ns* | *0.0031 ns* | *0.0029 ns* | *0.0007 ns* |  *0.2657 ns* |  *0.2708 ns* |  *0.2724 ns* |  *0.2743 ns* |  *0.2779 ns* | *3,671,121,901.6* |      *0.0031 ns* |      *15.00* |    *3.035* |  *2.000* |  *-0.3685* |  *1.02* |    *0.02* |   *Same: 1.0000|1.0000* |    *2* | *Job-UTOYIO(EvaluateOverhead=True, Server=True, Toolchain=.NET 5.0)* |       *No* |      *24 B* |         *-* |
|     *Synchronized* | *15.2466 ns* | *0.1343 ns* | *0.1256 ns* | *0.0324 ns* | *14.9780 ns* | *15.2169 ns* | *15.2863 ns* | *15.3215 ns* | *15.3727 ns* |    *65,588,339.2* |      *0.1343 ns* |      *15.00* |    *2.737* |  *2.000* |  *-1.0945* | *57.02* |    *1.35* | *Slower: 0.0000|1.0000* |    *4* | *Job-UTOYIO(EvaluateOverhead=True, Server=True, Toolchain=.NET 5.0)* |       *No* |     *213 B* |         *-* |
