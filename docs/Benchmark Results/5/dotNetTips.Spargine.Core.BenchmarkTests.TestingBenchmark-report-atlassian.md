{noformat}

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.300-preview.21180.15
  [Host]     : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT
  Job-PDALPH : .NET Core 5.0.5 (CoreCLR 5.0.521.16609, CoreFX 5.0.521.16609), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Namespace=dotNetTips.Spargine.Core.BenchmarkTests  Categories=TESTS  

{noformat}
||                          Method ||     Mean ||    Error ||   StdDev ||   StdErr ||      Min ||       Q1 ||   Median ||       Q3 ||      Max ||         Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Ratio ||  Welch(10%)/p-values ||Rank ||                                                           LogicalGroup ||Baseline ||Gen 0 ||Gen 1 ||Gen 2 ||Allocated ||Code Size ||
|                 *CalculatePercent* |  *8.047 ns* | *0.0258 ns* | *0.0229 ns* | *0.0061 ns* |  *8.004 ns* |  *8.036 ns* |  *8.043 ns* |  *8.060 ns* |  *8.092 ns* | *124,264,321.0* |      *0.0258 ns* |      *14.00* |    *2.419* |  *2.000* |   *0.2490* |  *1.00* |             *Base: ?|?* |    *2* | *Job-PDALPH(EvaluateOverhead=True, Server=True, Toolchain=.NET Core 5.0)* |      *Yes* |     *-* |     *-* |     *-* |         *-* |     *146 B* |
| *CalculatePercentAggressiveInline* |  *7.649 ns* | *0.0283 ns* | *0.0264 ns* | *0.0068 ns* |  *7.614 ns* |  *7.631 ns* |  *7.636 ns* |  *7.678 ns* |  *7.688 ns* | *130,741,815.6* |      *0.0283 ns* |      *15.00* |    *1.403* |  *2.000* |   *0.4212* |  *0.95* |   *Same: 1.0000|1.0000* |    *1* | *Job-PDALPH(EvaluateOverhead=True, Server=True, Toolchain=.NET Core 5.0)* |       *No* |     *-* |     *-* |     *-* |         *-* |     *192 B* |
|         *CalculatePercentNoInline* |  *8.057 ns* | *0.0518 ns* | *0.0485 ns* | *0.0125 ns* |  *7.992 ns* |  *8.023 ns* |  *8.039 ns* |  *8.093 ns* |  *8.140 ns* | *124,116,657.7* |      *0.0518 ns* |      *15.00* |    *1.668* |  *2.000* |   *0.4180* |  *1.00* |   *Same: 1.0000|1.0000* |    *2* | *Job-PDALPH(EvaluateOverhead=True, Server=True, Toolchain=.NET Core 5.0)* |       *No* |     *-* |     *-* |     *-* |         *-* |     *146 B* |
|   *CalculatePercentNoOptimization* |  *9.862 ns* | *0.0286 ns* | *0.0267 ns* | *0.0069 ns* |  *9.826 ns* |  *9.845 ns* |  *9.854 ns* |  *9.879 ns* |  *9.917 ns* | *101,401,201.7* |      *0.0286 ns* |      *15.00* |    *2.053* |  *2.000* |   *0.4228* |  *1.23* | *Slower: 0.0000|1.0000* |    *4* | *Job-PDALPH(EvaluateOverhead=True, Server=True, Toolchain=.NET Core 5.0)* |       *No* |     *-* |     *-* |     *-* |         *-* |     *155 B* |
|      *CalculatePercentPreserveSig* |  *8.422 ns* | *0.0884 ns* | *0.0738 ns* | *0.0205 ns* |  *8.296 ns* |  *8.381 ns* |  *8.423 ns* |  *8.490 ns* |  *8.542 ns* | *118,734,520.1* |      *0.0884 ns* |      *13.00* |    *1.888* |  *2.000* |  *-0.0875* |  *1.05* |   *Same: 1.0000|1.0000* |    *3* | *Job-PDALPH(EvaluateOverhead=True, Server=True, Toolchain=.NET Core 5.0)* |       *No* |     *-* |     *-* |     *-* |         *-* |     *146 B* |
|     *CalculatePercentSynchronized* | *19.224 ns* | *0.0685 ns* | *0.0641 ns* | *0.0165 ns* | *19.160 ns* | *19.179 ns* | *19.189 ns* | *19.260 ns* | *19.366 ns* |  *52,017,241.2* |      *0.0685 ns* |      *15.00* |    *2.697* |  *2.000* |   *1.0429* |  *2.39* | *Slower: 0.0000|1.0000* |    *5* | *Job-PDALPH(EvaluateOverhead=True, Server=True, Toolchain=.NET Core 5.0)* |       *No* |     *-* |     *-* |     *-* |         *-* |     *258 B* |
