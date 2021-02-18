
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  Job-NPULEA : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Categories=StringBuilderExtensions  

      Method |     Mean |    Error |   StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
------------ |---------:|---------:|---------:|-------:|-------:|------:|----------:|
 AppendBytes | 36.74 μs | 0.053 μs | 0.047 μs | 5.1880 | 0.1221 |     - |  45.69 KB |
