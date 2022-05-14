{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  Job-WORVYS : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.Extensions.BenchmarkTests  Categories=Collections  

{noformat}
||        Method ||    Mean ||   Error ||  StdDev || StdErr ||     Min ||      Q1 ||  Median ||      Q3 ||     Max ||       Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 ||Code Size ||Allocated ||
| *GetDescription* | *251.1 ns* |  *2.67 ns* |  *2.23 ns* | *0.62 ns* | *246.5 ns* | *250.0 ns* | *251.3 ns* | *252.7 ns* | *254.1 ns* | *3,983,243.0* |       *2.669 ns* |      *13.00* |    *2.021* |  *2.000* |  *-0.3983* |    *1* |            *** |       *No* | *0.0024* |     *319 B* |      *24 B* |
|       *GetItems* | *868.7 ns* | *12.11 ns* | *11.32 ns* | *2.92 ns* | *855.1 ns* | *860.3 ns* | *866.0 ns* | *875.8 ns* | *894.3 ns* | *1,151,210.5* |      *12.106 ns* |      *15.00* |    *2.451* |  *2.000* |   *0.8002* |    *2* |            *** |       *No* | *0.0563* |     *484 B* |     *512 B* |
