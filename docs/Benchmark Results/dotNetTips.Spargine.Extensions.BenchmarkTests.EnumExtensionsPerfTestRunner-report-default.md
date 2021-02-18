
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  Job-NPULEA : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Categories=EnumExtensions  

         Method |       Mean |   Error |  StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
--------------- |-----------:|--------:|--------:|-------:|------:|------:|----------:|
 **GetDescription** |   **406.6 ns** | **1.29 ns** | **1.00 ns** | **0.0024** |     **-** |     **-** |      **24 B** |
       **GetItems** | **1,042.1 ns** | **2.68 ns** | **2.50 ns** | **0.0553** |     **-** |     **-** |     **512 B** |
