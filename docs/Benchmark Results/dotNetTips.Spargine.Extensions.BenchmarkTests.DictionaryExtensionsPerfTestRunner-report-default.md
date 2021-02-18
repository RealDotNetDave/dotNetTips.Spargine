
BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  Job-NPULEA : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Categories=DictionaryExtensions  

                  Method | CollectionCount |        Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
------------------------ |---------------- |------------:|----------:|----------:|-------:|------:|------:|----------:|
     **'Upsert:New Person'** |              **25** |  **9,022.9 ns** | **219.55 ns** | **626.40 ns** | **0.0153** |     **-** |     **-** |    **5515 B** |
     'Upsert:New Person' |              50 |  8,959.1 ns | 224.45 ns | 643.98 ns | 0.0153 |     - |     - |    5515 B |
     'Upsert:New Person' |             100 |  9,003.4 ns | 199.01 ns | 567.79 ns | 0.0153 |     - |     - |   11666 B |
     'Upsert:New Person' |             250 |  8,951.9 ns | 206.17 ns | 588.22 ns | 0.0153 |     - |     - |    5515 B |
     'Upsert:New Person' |             500 |  8,863.4 ns | 194.71 ns | 558.66 ns | 0.0153 |     - |     - |   11667 B |
     'Upsert:New Person' |            1000 |  8,965.4 ns | 205.53 ns | 589.69 ns | 0.0153 |     - |     - |    5515 B |
     **GetOrAdd:Dictionary** |              **25** |    **417.2 ns** |   **0.71 ns** |   **0.59 ns** | **0.0057** |     **-** |     **-** |      **56 B** |
     GetOrAdd:Dictionary |              50 |    780.2 ns |   2.33 ns |   2.06 ns | 0.0057 |     - |     - |      56 B |
     GetOrAdd:Dictionary |             100 |  1,438.1 ns |  26.70 ns |  24.98 ns | 0.0057 |     - |     - |      56 B |
     GetOrAdd:Dictionary |             250 |  3,268.4 ns |  17.34 ns |  15.37 ns | 0.0038 |     - |     - |      56 B |
     GetOrAdd:Dictionary |             500 |  6,803.7 ns |  35.25 ns |  32.98 ns |      - |     - |     - |      56 B |
     GetOrAdd:Dictionary |            1000 | 13,436.0 ns |  36.45 ns |  34.09 ns |      - |     - |     - |      56 B |
 **GetOrAdd:Dictionary-New** |              **25** |  **9,042.2 ns** | **219.25 ns** | **636.08 ns** | **0.0153** |     **-** |     **-** |    **5515 B** |
 GetOrAdd:Dictionary-New |              50 |  8,982.7 ns | 202.38 ns | 574.13 ns | 0.0153 |     - |     - |    5515 B |
 GetOrAdd:Dictionary-New |             100 |  9,018.2 ns | 189.41 ns | 540.40 ns | 0.0153 |     - |     - |   11666 B |
 GetOrAdd:Dictionary-New |             250 |  9,047.5 ns | 222.05 ns | 633.51 ns | 0.0153 |     - |     - |    5515 B |
 GetOrAdd:Dictionary-New |             500 |  8,883.9 ns | 203.26 ns | 573.31 ns | 0.0153 |     - |     - |    5515 B |
 GetOrAdd:Dictionary-New |            1000 |  8,970.4 ns | 221.68 ns | 636.05 ns | 0.0153 |     - |     - |    5515 B |
                  **Upsert** |              **25** |    **418.8 ns** |   **1.50 ns** |   **1.47 ns** | **0.0057** |     **-** |     **-** |      **56 B** |
                  Upsert |              50 |    745.2 ns |   2.63 ns |   2.46 ns | 0.0057 |     - |     - |      56 B |
                  Upsert |             100 |  1,395.2 ns |   6.09 ns |   5.70 ns | 0.0057 |     - |     - |      56 B |
                  Upsert |             250 |  3,443.3 ns |  14.81 ns |  13.86 ns | 0.0038 |     - |     - |      56 B |
                  Upsert |             500 |  6,575.6 ns |  31.39 ns |  27.83 ns |      - |     - |     - |      56 B |
                  Upsert |            1000 | 12,814.7 ns |  35.21 ns |  31.21 ns |      - |     - |     - |      56 B |
