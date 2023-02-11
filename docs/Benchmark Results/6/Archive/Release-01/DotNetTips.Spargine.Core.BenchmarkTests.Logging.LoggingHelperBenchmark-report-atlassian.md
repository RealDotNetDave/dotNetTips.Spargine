{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  Job-ZCARTZ : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Logging  Categories=LOGGING  

{noformat}
||                      Method ||    Mean ||   Error ||  StdDev ||  StdErr ||  Median ||     Min ||      Q1 ||      Q3 ||     Max ||        Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline ||Code Size || Gen 0 ||Allocated ||
|    *LoggingHelper.LogCritical* | *43.85 ns* | *0.889 ns* | *1.187 ns* | *0.237 ns* | *43.79 ns* | *41.30 ns* | *43.49 ns* | *44.61 ns* | *45.69 ns* | *22,805,977.0* |      *0.8888 ns* |      *25.00* |    *2.473* |  *2.000* |  *-0.4251* |    *1* |            *** |       *No* |     *423 B* | *0.0148* |     *136 B* |
|       *LoggingHelper.LogDebug* | *47.89 ns* | *0.983 ns* | *2.317 ns* | *0.285 ns* | *49.01 ns* | *41.20 ns* | *46.63 ns* | *49.27 ns* | *50.79 ns* | *20,879,367.8* |      *0.9831 ns* |      *66.00* |    *3.250* |  *2.429* |  *-1.2390* |    *2* |            *** |       *No* |     *423 B* | *0.0146* |     *136 B* |
|       *LoggingHelper.LogError* | *43.74 ns* | *0.883 ns* | *1.500 ns* | *0.247 ns* | *43.63 ns* | *41.58 ns* | *42.61 ns* | *44.85 ns* | *47.55 ns* | *22,861,206.9* |      *0.8832 ns* |      *37.00* |    *2.562* |  *2.769* |   *0.5407* |    *1* |            *** |       *No* |     *423 B* | *0.0149* |     *136 B* |
| *LoggingHelper.LogInformation* | *43.65 ns* | *0.798 ns* | *0.667 ns* | *0.185 ns* | *43.68 ns* | *42.48 ns* | *43.20 ns* | *43.94 ns* | *44.75 ns* | *22,911,258.3* |      *0.7983 ns* |      *13.00* |    *2.023* |  *2.000* |   *0.1195* |    *1* |            *** |       *No* |     *423 B* | *0.0148* |     *136 B* |
|       *LoggingHelper.LogTrace* | *42.85 ns* | *0.866 ns* | *0.962 ns* | *0.221 ns* | *42.78 ns* | *41.16 ns* | *42.30 ns* | *43.53 ns* | *45.00 ns* | *23,336,916.3* |      *0.8658 ns* |      *19.00* |    *2.617* |  *2.000* |   *0.1510* |    *1* |            *** |       *No* |     *420 B* | *0.0148* |     *136 B* |
|     *LoggingHelper.LogWarning* | *43.83 ns* | *0.860 ns* | *0.804 ns* | *0.208 ns* | *43.58 ns* | *42.72 ns* | *43.10 ns* | *44.50 ns* | *45.05 ns* | *22,818,015.8* |      *0.8597 ns* |      *15.00* |    *1.275* |  *2.000* |   *0.0513* |    *1* |            *** |       *No* |     *423 B* | *0.0148* |     *136 B* |
