``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  Job-NPULEA : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Categories=ObjectExtensions  

```
|                                              Method |           Mean |       Error |        StdDev |  Gen 0 |  Gen 1 | Gen 2 | Allocated |
|---------------------------------------------------- |---------------:|------------:|--------------:|-------:|-------:|------:|----------:|
|                                       **&#39;As: IPerson&#39;** |      **6.2474 ns** |   **0.0098 ns** |     **0.0092 ns** |      **-** |      **-** |     **-** |         **-** |
|                               **&#39;Clone: PersonProper&#39;** |  **7,888.0011 ns** |  **12.1092 ns** |    **10.1117 ns** | **0.3052** |      **-** |     **-** |    **2893 B** |
|                   **&#39;ComputeSha256Hash: PersonProper&#39;** |  **9,213.9564 ns** |  **17.6453 ns** |    **16.5054 ns** | **0.4883** |      **-** |     **-** |    **4581 B** |
|                   **&#39;ComputeSha256Hash: PersonRecord&#39;** |  **6,602.2631 ns** |   **5.9614 ns** |     **4.6543 ns** | **0.4425** |      **-** |     **-** |    **4136 B** |
|                          **&#39;DisposeFields: DataTable&#39;** |  **5,849.0168 ns** |  **10.6019 ns** |     **9.3983 ns** | **0.7172** |      **-** |     **-** |    **6560 B** |
|                         **&#39;HasProperty: PersonProper&#39;** |    **251.9337 ns** |   **0.3047 ns** |     **0.2850 ns** | **0.0277** |      **-** |     **-** |     **256 B** |
|                           **&#39;IsNotNull: PersonProper&#39;** |      **0.0000 ns** |   **0.0000 ns** |     **0.0000 ns** |      **-** |      **-** |     **-** |         **-** |
|                              **&#39;IsNull: PersonProper&#39;** |      **0.0000 ns** |   **0.0000 ns** |     **0.0000 ns** |      **-** |      **-** |     **-** |         **-** |
|             **&#39;PersonRecord: Duplication with new ID&#39;** |     **26.4361 ns** |   **0.0529 ns** |     **0.0469 ns** | **0.0096** |      **-** |     **-** |      **88 B** |
|                          **&#39;PersonRecord: ToString()&#39;** |  **1,021.2854 ns** |   **1.7547 ns** |     **1.6414 ns** | **0.2289** |      **-** |     **-** |    **2096 B** |
| **&#39;PropertiesToDictionary: PersonProper-Ignore Nulls&#39;** | **33,220.2148 ns** |  **69.2532 ns** |    **61.3911 ns** | **4.2114** |      **-** |     **-** |   **38608 B** |
|   **&#39;PropertiesToDictionary: PersonProper-With Nulls&#39;** | **32,457.1035 ns** |  **56.0143 ns** |    **52.3959 ns** | **4.2114** |      **-** |     **-** |   **38612 B** |
| **&#39;PropertiesToDictionary: PersonRecord-Ignore Nulls&#39;** | **18,227.0280 ns** |  **45.3909 ns** |    **42.4587 ns** | **2.4109** |      **-** |     **-** |   **22138 B** |
|   **&#39;PropertiesToDictionary: PersonRecord-With Nulls&#39;** | **18,460.5994 ns** |  **28.4700 ns** |    **25.2379 ns** | **2.4109** |      **-** |     **-** |   **22139 B** |
|     **&#39;PropertiesToString: PersonProper-Ignore Nulls&#39;** | **42,956.3944 ns** |  **53.2120 ns** |    **41.5444 ns** | **7.5684** |      **-** |     **-** |   **69264 B** |
|       **&#39;PropertiesToString: PersonProper-With Nulls&#39;** | **45,246.0614 ns** | **302.3609 ns** |   **282.8286 ns** | **7.5073** |      **-** |     **-** |   **69296 B** |
|     **&#39;PropertiesToString: PersonRecord-Ignore Nulls&#39;** | **28,274.5428 ns** | **551.9183 ns** | **1,510.8675 ns** | **4.5776** |      **-** |     **-** |   **41678 B** |
|       **&#39;PropertiesToString: PersonRecord-With Nulls&#39;** | **26,196.8197 ns** |  **63.1233 ns** |    **59.0456 ns** | **4.6387** |      **-** |     **-** |   **41774 B** |
|                           **&#39;StripNull: PersonProper&#39;** |      **9.9461 ns** |   **0.0171 ns** |     **0.0160 ns** |      **-** |      **-** |     **-** |         **-** |
|                              **&#39;ToJson: PersonProper&#39;** |  **3,506.5042 ns** |   **3.7970 ns** |     **3.5517 ns** | **0.2098** |      **-** |     **-** |    **1925 B** |
|                              **&#39;ToJson: PersonRecord&#39;** |  **2,294.5198 ns** |   **3.0321 ns** |     **2.8363 ns** | **0.1831** |      **-** |     **-** |    **1696 B** |
|                          **&#39;TryDispose: PersonProper&#39;** |    **428.6303 ns** |   **0.4492 ns** |     **0.4201 ns** | **0.3181** | **0.0005** |     **-** |    **2920 B** |
