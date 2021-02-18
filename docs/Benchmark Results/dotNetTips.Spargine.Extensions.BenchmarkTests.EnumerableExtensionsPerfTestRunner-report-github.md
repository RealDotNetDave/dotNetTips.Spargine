``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Unknown processor
.NET Core SDK=5.0.200-preview.21079.7
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  Job-NPULEA : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET Core 5.0  
Categories=EnumerableExtensions  

```
|                                 Method | CollectionCount |           Mean |         Error |        StdDev |   Gen 0 |  Gen 1 | Gen 2 | Allocated |
|--------------------------------------- |---------------- |---------------:|--------------:|--------------:|--------:|-------:|------:|----------:|
|            **&#39;FirstOrDefault: Alternate&#39;** |              **25** |   **7,309.369 ns** |     **9.5796 ns** |     **7.9994 ns** |  **0.6027** |      **-** |     **-** |    **5611 B** |
|            &#39;FirstOrDefault: Alternate&#39; |              50 |   7,454.121 ns |     9.0476 ns |     8.4631 ns |  0.6180 |      - |     - |    5611 B |
|            &#39;FirstOrDefault: Alternate&#39; |             100 |   7,493.042 ns |    10.6247 ns |     9.9383 ns |  0.6104 |      - |     - |    5611 B |
|            &#39;FirstOrDefault: Alternate&#39; |             250 |   7,759.672 ns |     6.5185 ns |     5.4433 ns |  0.6104 |      - |     - |    5611 B |
|            &#39;FirstOrDefault: Alternate&#39; |             500 |   7,559.732 ns |    10.5897 ns |     8.8429 ns |  0.6180 |      - |     - |    5611 B |
|            &#39;FirstOrDefault: Alternate&#39; |            1000 |   7,286.789 ns |   105.6344 ns |    98.8105 ns |  0.6104 |      - |     - |    5611 B |
| **&#39;FirstOrDefault: Predicate, Alternate&#39;** |              **25** |   **7,580.515 ns** |    **11.1852 ns** |     **9.9154 ns** |  **0.6180** |      **-** |     **-** |    **5675 B** |
| &#39;FirstOrDefault: Predicate, Alternate&#39; |              50 |   8,165.708 ns |    21.8421 ns |    20.4311 ns |  0.6256 |      - |     - |    5675 B |
| &#39;FirstOrDefault: Predicate, Alternate&#39; |             100 |   8,445.995 ns |    95.1783 ns |    89.0298 ns |  0.6104 |      - |     - |    5675 B |
| &#39;FirstOrDefault: Predicate, Alternate&#39; |             250 |  10,419.403 ns |   134.0020 ns |   125.3455 ns |  0.6104 |      - |     - |    5675 B |
| &#39;FirstOrDefault: Predicate, Alternate&#39; |             500 |  12,598.849 ns |   146.0624 ns |   136.6268 ns |  0.6256 |      - |     - |    5675 B |
| &#39;FirstOrDefault: Predicate, Alternate&#39; |            1000 |  18,744.363 ns |    37.5555 ns |    31.3606 ns |  0.6104 |      - |     - |    5675 B |
|              **&#39;ToImmutable: Dictionary&#39;** |              **25** |   **5,039.844 ns** |     **8.7078 ns** |     **7.2714 ns** |  **0.1831** |      **-** |     **-** |    **1696 B** |
|              &#39;ToImmutable: Dictionary&#39; |              50 |  11,027.857 ns |     7.3802 ns |     6.1628 ns |  0.3510 |      - |     - |    3296 B |
|              &#39;ToImmutable: Dictionary&#39; |             100 |  25,986.861 ns |    52.3720 ns |    43.7330 ns |  0.7019 |      - |     - |    6496 B |
|              &#39;ToImmutable: Dictionary&#39; |             250 |  76,786.812 ns |   784.5337 ns |   733.8533 ns |  1.7090 |      - |     - |   16096 B |
|              &#39;ToImmutable: Dictionary&#39; |             500 | 172,614.782 ns |   482.6914 ns |   451.5099 ns |  3.4180 |      - |     - |   32096 B |
|              &#39;ToImmutable: Dictionary&#39; |            1000 | 387,301.120 ns | 1,552.5876 ns | 1,376.3285 ns |  6.8359 | 0.9766 |     - |   64096 B |
|                    **&#39;ToImmutable: List&#39;** |              **25** |     **686.165 ns** |     **6.3116 ns** |     **5.9039 ns** |  **0.1364** |      **-** |     **-** |    **1248 B** |
|                    &#39;ToImmutable: List&#39; |              50 |   1,321.986 ns |     8.7197 ns |     7.7298 ns |  0.2670 |      - |     - |    2448 B |
|                    &#39;ToImmutable: List&#39; |             100 |   2,547.973 ns |     2.8283 ns |     2.6456 ns |  0.5341 | 0.0038 |     - |    4848 B |
|                    &#39;ToImmutable: List&#39; |             250 |   6,171.678 ns |    11.4768 ns |    10.7354 ns |  1.3123 | 0.0305 |     - |   12048 B |
|                    &#39;ToImmutable: List&#39; |             500 |  12,715.413 ns |    10.7111 ns |     8.9443 ns |  2.6245 | 0.1068 |     - |   24000 B |
|                    &#39;ToImmutable: List&#39; |            1000 |  25,171.638 ns |    25.6926 ns |    24.0329 ns |  5.2185 | 0.4883 |     - |   48048 B |
|                                  **Count** |              **25** |       **5.477 ns** |     **0.0117 ns** |     **0.0104 ns** |       **-** |      **-** |     **-** |         **-** |
|                                  Count |              50 |       5.429 ns |     0.0106 ns |     0.0099 ns |       - |      - |     - |         - |
|                                  Count |             100 |       5.684 ns |     0.0889 ns |     0.0832 ns |       - |      - |     - |         - |
|                                  Count |             250 |       6.404 ns |     0.1616 ns |     0.1729 ns |       - |      - |     - |         - |
|                                  Count |             500 |       5.628 ns |     0.0236 ns |     0.0197 ns |       - |      - |     - |         - |
|                                  Count |            1000 |       5.482 ns |     0.0140 ns |     0.0131 ns |       - |      - |     - |         - |
|                                **FastAny** |              **25** |     **548.006 ns** |     **1.1567 ns** |     **1.0254 ns** |  **0.0038** |      **-** |     **-** |      **40 B** |
|                                FastAny |              50 |   1,023.220 ns |    13.1471 ns |    12.2978 ns |  0.0038 |      - |     - |      40 B |
|                                FastAny |             100 |   2,278.924 ns |     4.1240 ns |     3.6558 ns |  0.0038 |      - |     - |      40 B |
|                                FastAny |             250 |   6,223.060 ns |    48.9087 ns |    45.7492 ns |       - |      - |     - |      40 B |
|                                FastAny |             500 |  11,574.219 ns |    33.4504 ns |    31.2895 ns |       - |      - |     - |      40 B |
|                                FastAny |            1000 |  26,051.713 ns |    85.7352 ns |    80.1968 ns |       - |      - |     - |      40 B |
|                              **FastCount** |              **25** |     **339.264 ns** |     **4.3365 ns** |     **3.8442 ns** |       **-** |      **-** |     **-** |         **-** |
|                              FastCount |              50 |     716.216 ns |     2.4446 ns |     2.0413 ns |       - |      - |     - |         - |
|                              FastCount |             100 |   1,314.800 ns |     3.2421 ns |     2.5312 ns |       - |      - |     - |         - |
|                              FastCount |             250 |   4,067.947 ns |    13.5629 ns |    12.6867 ns |       - |      - |     - |         - |
|                              FastCount |             500 |   8,464.674 ns |    28.6354 ns |    26.7856 ns |       - |      - |     - |         - |
|                              FastCount |            1000 |  19,413.204 ns |    71.2838 ns |    66.6790 ns |       - |      - |     - |         - |
|                            **FirstOrNull** |              **25** |     **310.555 ns** |     **0.6571 ns** |     **0.5487 ns** |  **0.0377** |      **-** |     **-** |     **344 B** |
|                            FirstOrNull |              50 |     491.537 ns |     0.5574 ns |     0.4941 ns |  0.0591 |      - |     - |     544 B |
|                            FirstOrNull |             100 |     818.095 ns |     0.5581 ns |     0.4660 ns |  0.1030 |      - |     - |     944 B |
|                            FirstOrNull |             250 |   1,919.540 ns |     2.5748 ns |     2.1501 ns |  0.2327 |      - |     - |    2144 B |
|                            FirstOrNull |             500 |   3,547.197 ns |     3.9776 ns |     3.7206 ns |  0.4539 |      - |     - |    4144 B |
|                            FirstOrNull |            1000 |   6,922.894 ns |     6.5774 ns |     6.1525 ns |  0.8850 |      - |     - |    8144 B |
|                             **StartsWith** |              **25** |     **151.968 ns** |     **0.5946 ns** |     **0.4642 ns** |  **0.0069** |      **-** |     **-** |      **64 B** |
|                             StartsWith |              50 |     292.917 ns |     0.3511 ns |     0.2932 ns |  0.0067 |      - |     - |      64 B |
|                             StartsWith |             100 |     513.301 ns |     0.6643 ns |     0.5888 ns |  0.0067 |      - |     - |      64 B |
|                             StartsWith |             250 |   1,182.997 ns |     2.3876 ns |     2.2334 ns |  0.0057 |      - |     - |      64 B |
|                             StartsWith |             500 |   2,550.521 ns |     4.1261 ns |     3.6577 ns |  0.0038 |      - |     - |      64 B |
|                             StartsWith |            1000 |   5,068.394 ns |    10.0110 ns |     9.3643 ns |       - |      - |     - |      64 B |
|                **StructuralSequenceEqual** |              **25** |     **240.833 ns** |     **2.1476 ns** |     **1.9038 ns** |  **0.0067** |      **-** |     **-** |      **64 B** |
|                StructuralSequenceEqual |              50 |     457.101 ns |     0.3999 ns |     0.3545 ns |  0.0067 |      - |     - |      64 B |
|                StructuralSequenceEqual |             100 |     865.572 ns |     8.9317 ns |     8.3547 ns |  0.0067 |      - |     - |      64 B |
|                StructuralSequenceEqual |             250 |   2,141.304 ns |     4.0373 ns |     3.5790 ns |  0.0038 |      - |     - |      64 B |
|                StructuralSequenceEqual |             500 |   4,210.906 ns |    47.3157 ns |    44.2591 ns |       - |      - |     - |      64 B |
|                StructuralSequenceEqual |            1000 |   8,007.523 ns |    73.7382 ns |    65.3670 ns |       - |      - |     - |      64 B |
|                      **ToDelimitedString** |              **25** |   **3,803.287 ns** |    **75.6008 ns** |   **124.2143 ns** |  **1.1177** |      **-** |     **-** |   **10240 B** |
|                      ToDelimitedString |              50 |   6,634.557 ns |    15.8231 ns |    14.0268 ns |  2.2278 | 0.0229 |     - |   19816 B |
|                      ToDelimitedString |             100 |  12,759.089 ns |    82.9676 ns |    77.6080 ns |  4.5166 | 0.1373 |     - |   38888 B |
|                      ToDelimitedString |             250 |  30,922.852 ns |    50.7406 ns |    47.4628 ns | 10.1929 | 0.7324 |     - |   89560 B |
|                      ToDelimitedString |             500 |  57,817.265 ns |    63.9483 ns |    56.6885 ns | 18.8599 |      - |     - |  168632 B |
|                      ToDelimitedString |            1000 | 115,182.292 ns |   167.0522 ns |   156.2607 ns | 36.7432 | 5.9814 |     - |  326776 B |
|                           **ToDictionary** |              **25** |     **765.094 ns** |     **0.6992 ns** |     **0.6540 ns** |  **0.1030** |      **-** |     **-** |     **944 B** |
|                           ToDictionary |              50 |   1,542.115 ns |     2.3585 ns |     2.0908 ns |  0.1965 |      - |     - |    1784 B |
|                           ToDictionary |             100 |   3,209.739 ns |     5.0471 ns |     4.2145 ns |  0.3395 |      - |     - |    3128 B |
|                           ToDictionary |             250 |   9,327.712 ns |    11.2270 ns |     9.9525 ns |  0.9155 | 0.0153 |     - |    8336 B |
|                           ToDictionary |             500 |  21,423.166 ns |    51.9121 ns |    48.5586 ns |  1.5869 | 0.0305 |     - |   14720 B |
|                           ToDictionary |            1000 |  47,410.855 ns |   131.1504 ns |   122.6781 ns |  3.4180 | 0.1831 |     - |   31016 B |
|                           **ToLinkedList** |              **25** |     **569.213 ns** |     **0.9928 ns** |     **0.8801 ns** |  **0.1345** |      **-** |     **-** |    **1232 B** |
|                           ToLinkedList |              50 |   1,137.834 ns |     1.8839 ns |     1.7622 ns |  0.2689 |      - |     - |    2480 B |
|                           ToLinkedList |             100 |   2,216.649 ns |    21.0037 ns |    16.3983 ns |  0.5302 | 0.0038 |     - |    4880 B |
|                           ToLinkedList |             250 |   5,459.025 ns |     4.3582 ns |     3.8634 ns |  1.3123 | 0.0229 |     - |   12080 B |
|                           ToLinkedList |             500 |  10,897.326 ns |     7.9857 ns |     7.0791 ns |  2.6093 |      - |     - |   24080 B |
|                           ToLinkedList |            1000 |  22,443.939 ns |    55.3450 ns |    51.7698 ns |  5.1880 |      - |     - |   48080 B |
