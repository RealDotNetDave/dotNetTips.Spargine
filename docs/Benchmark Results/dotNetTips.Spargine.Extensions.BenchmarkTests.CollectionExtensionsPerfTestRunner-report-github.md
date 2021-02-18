``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  Job-NPULEA : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Categories=CollectionExtensions  

```
|   Method | CollectionCount |          Mean |      Error |     StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------- |---------------- |--------------:|-----------:|-----------:|-------:|------:|------:|----------:|
| **AddRange** |              **25** |  **11,600.17 ns** |  **35.552 ns** |  **31.516 ns** | **0.0610** |     **-** |     **-** |     **664 B** |
| AddRange |              50 |  24,108.00 ns |  46.726 ns |  43.708 ns | 0.0916 |     - |     - |    1088 B |
| AddRange |             100 |  42,346.88 ns | 183.702 ns | 171.835 ns | 0.1831 |     - |     - |    1800 B |
| AddRange |             250 | 102,280.90 ns | 239.614 ns | 212.412 ns | 0.3662 |     - |     - |    3760 B |
| AddRange |             500 | 213,889.96 ns | 406.003 ns | 379.776 ns | 0.7324 |     - |     - |    7096 B |
| AddRange |            1000 | 407,982.00 ns | 562.835 ns | 469.993 ns | 0.4883 |     - |     - |   13744 B |
| **HasItems** |              **25** |      **21.87 ns** |   **0.098 ns** |   **0.092 ns** |      **-** |     **-** |     **-** |         **-** |
| HasItems |              50 |      21.56 ns |   0.111 ns |   0.098 ns |      - |     - |     - |         - |
| HasItems |             100 |      20.76 ns |   0.038 ns |   0.036 ns |      - |     - |     - |         - |
| HasItems |             250 |      20.70 ns |   0.073 ns |   0.068 ns |      - |     - |     - |         - |
| HasItems |             500 |      27.94 ns |   0.354 ns |   0.314 ns |      - |     - |     - |         - |
| HasItems |            1000 |      21.80 ns |   0.123 ns |   0.115 ns |      - |     - |     - |         - |
