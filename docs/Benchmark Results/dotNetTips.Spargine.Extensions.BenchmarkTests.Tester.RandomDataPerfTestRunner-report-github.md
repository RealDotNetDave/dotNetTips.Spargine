``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  Job-NPULEA : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Categories=RandomData  

```
|                               Method |      Mean |     Error |    StdDev |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------------------------------- |----------:|----------:|----------:|-------:|------:|------:|----------:|
|                   **&#39;Creating: Person&#39;** |  **6.655 μs** | **0.0052 μs** | **0.0046 μs** | **0.5951** |     **-** |     **-** |   **5.39 KB** |
|              **&#39;Creating: PersonFixed&#39;** |  **6.648 μs** | **0.0098 μs** | **0.0092 μs** | **0.5951** |     **-** |     **-** |   **5.39 KB** |
|               **&#39;Creating: PersonPlus&#39;** |  **6.814 μs** | **0.0087 μs** | **0.0081 μs** | **0.6027** |     **-** |     **-** |   **5.39 KB** |
|             **&#39;Creating: PersonProper&#39;** |  **6.842 μs** | **0.0276 μs** | **0.0230 μs** | **0.6104** |     **-** |     **-** |   **5.39 KB** |
|             **&#39;Creating: PersonRecord&#39;** | **10.172 μs** | **0.2025 μs** | **0.5004 μs** | **0.8240** |     **-** |     **-** |   **7.43 KB** |
| **&#39;PropertiesToString(): PersonProper&#39;** | **55.785 μs** | **0.5962 μs** | **0.5577 μs** | **8.2397** |     **-** |     **-** |  **72.88 KB** |
| **&#39;PropertiesToString(): PersonRecord&#39;** | **36.551 μs** | **0.4040 μs** | **0.3779 μs** | **5.4321** |     **-** |     **-** |  **48.23 KB** |
