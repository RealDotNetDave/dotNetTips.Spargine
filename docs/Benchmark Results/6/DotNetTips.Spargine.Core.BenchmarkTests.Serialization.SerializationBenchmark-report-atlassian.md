{noformat}

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.19044.1706 (21H2)
Intel Core i7-7660U CPU 2.50GHz (Kaby Lake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.300
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  Job-BDXZTS : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT

EvaluateOverhead=True  Server=True  Toolchain=.NET 6.0  
Namespace=DotNetTips.Spargine.Core.BenchmarkTests.Serialization  

{noformat}
||                          Method ||        Categories ||     Mean ||    Error ||   StdDev ||   StdErr ||      Min ||       Q1 ||   Median ||       Q3 ||      Max ||     Op/s ||CI99.9% Margin ||Iterations ||Kurtosis ||MValue ||Skewness ||Rank ||LogicalGroup ||Baseline || Gen 0 ||Code Size || Gen 1 ||Allocated ||
| *'Deserialize: JSON-PersonProper'* |      *Serialization* |  *2.626 μs* | *0.0284 μs* | *0.0266 μs* | *0.0069 μs* |  *2.589 μs* |  *2.608 μs* |  *2.621 μs* |  *2.649 μs* |  *2.682 μs* | *380,828.0* |      *0.0284 μs* |      *15.00* |    *2.035* |  *2.000* |   *0.4842* |    *2* |            *** |       *No* | *0.0763* |     *297 B* |      *-* |     *712 B* |
| *'Deserialize: JSON-PersonRecord'* |      *Serialization* |  *7.466 μs* | *0.0421 μs* | *0.0351 μs* | *0.0097 μs* |  *7.388 μs* |  *7.463 μs* |  *7.471 μs* |  *7.491 μs* |  *7.506 μs* | *133,939.4* |      *0.0421 μs* |      *13.00* |    *2.789* |  *2.000* |  *-1.0054* |    *4* |            *** |       *No* | *0.2747* |     *297 B* |      *-* |   *2,584 B* |
|  *'Deserialize: XML=PersonProper'* |  *XML,Serialization* | *19.843 μs* | *0.2407 μs* | *0.2251 μs* | *0.0581 μs* | *19.477 μs* | *19.685 μs* | *19.873 μs* | *20.015 μs* | *20.213 μs* |  *50,396.2* |      *0.2407 μs* |      *15.00* |    *1.634* |  *2.000* |  *-0.0512* |    *8* |            *** |       *No* | *1.9836* |     *679 B* |      *-* |  *18,412 B* |
|  *'Deserialize: XML=PersonRecord'* |  *XML,Serialization* | *15.091 μs* | *0.1471 μs* | *0.1376 μs* | *0.0355 μs* | *14.923 μs* | *14.983 μs* | *15.067 μs* | *15.173 μs* | *15.371 μs* |  *66,265.5* |      *0.1471 μs* |      *15.00* |    *1.970* |  *2.000* |   *0.4463* |    *6* |            *** |       *No* | *1.9531* |     *679 B* | *0.0458* |  *18,180 B* |
|   *'Serialize: JSON=PersonProper'* | *JSON,Serialization* |  *1.505 μs* | *0.0186 μs* | *0.0155 μs* | *0.0043 μs* |  *1.475 μs* |  *1.498 μs* |  *1.509 μs* |  *1.513 μs* |  *1.529 μs* | *664,546.0* |      *0.0186 μs* |      *13.00* |    *2.308* |  *2.000* |  *-0.6053* |    *1* |            *** |       *No* | *0.1240* |     *530 B* |      *-* |   *1,152 B* |
|   *'Serialize: JSON=PersonRecord'* | *JSON,Serialization* |  *2.952 μs* | *0.0587 μs* | *0.0742 μs* | *0.0155 μs* |  *2.829 μs* |  *2.881 μs* |  *2.995 μs* |  *3.007 μs* |  *3.049 μs* | *338,732.9* |      *0.0587 μs* |      *23.00* |    *1.550* |  *2.714* |  *-0.5385* |    *3* |            *** |       *No* | *0.2556* |     *530 B* |      *-* |   *2,360 B* |
|    *'Serialize: XML=PersonProper'* |  *XML,Serialization* | *15.989 μs* | *0.1815 μs* | *0.1698 μs* | *0.0438 μs* | *15.746 μs* | *15.874 μs* | *15.931 μs* | *16.087 μs* | *16.380 μs* |  *62,542.7* |      *0.1815 μs* |      *15.00* |    *2.565* |  *2.000* |   *0.7114* |    *7* |            *** |       *No* | *2.2583* |     *724 B* | *0.0305* |  *20,838 B* |
|                *StringToXDocument* |  *XML,Serialization* |  *9.147 μs* | *0.0609 μs* | *0.0540 μs* | *0.0144 μs* |  *9.059 μs* |  *9.121 μs* |  *9.136 μs* |  *9.163 μs* |  *9.252 μs* | *109,325.9* |      *0.0609 μs* |      *14.00* |    *2.587* |  *2.000* |   *0.6098* |    *5* |            *** |       *No* | *1.7090* |     *231 B* | *0.0305* |  *15,888 B* |
