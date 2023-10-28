## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7894DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,26E36513020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,26E66511070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C4D738]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 281
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9C5505EA0]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55FB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C5148958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,2313E402028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,2313E408C68
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C530DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF9C5507018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      qword ptr [7FF9C52CBD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5512890]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55076A8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 283
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7874DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,2B573E83020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,2B543E81070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C2D738]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 281
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9C5515E70]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C560B330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C5158958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,20D09402028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,20D09408C68
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C531DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF9C5517018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      qword ptr [7FF9C52DBD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5522778]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55176A8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 283
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7864DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,1B0C8D23020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1B0F8D21070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C1D738]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 281
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9C54F5780]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55E7FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C5138958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,1C47A402028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1C472400070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C52FDA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF9C54F57C8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      qword ptr [7FF9C52BBD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55020E0]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C54F5E58]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 283
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7874DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,286AD5E3020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,2868D5E1070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C2D858]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 281
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9C5505750]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55F9330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C5148958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,2A6F8C02028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,2A6F8C08C68
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C530DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF9C5505798]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      qword ptr [7FF9C52CBD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55123B8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5505E28]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 283
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7854DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,2414CA03020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,241ACA01070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C0D858]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 281
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9C55177B0]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5609FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C5158958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,1F8B5C02028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1F8B7C00070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C531DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF9C55177F8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      qword ptr [7FF9C52DBD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55249D0]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5517E88]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 283
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7884DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,233F26D3020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,233F26D9C68
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C3D738]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 281
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9BE425738]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9BE517FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9BE068958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,26E44002028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,26E44008C68
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9BE22DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF9BE425780]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      qword ptr [7FF9BE1EBD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9BE432270]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9BE425E10]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 283
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7864DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,1A8FD633020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1A8FD639C68
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C1D858]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 281
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9C0B85738]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0C79330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C07C8958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,25C49802028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,25C4B800070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C098DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF9C0B85780]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      qword ptr [7FF9C094BD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0B92270]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0B85E10]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 283
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7864DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,1BC9E123020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1BD0E121070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C31900]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 281
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9C52C9768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55FB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C5148958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,1F014802028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1F00E800070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C530DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF9C550B018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      qword ptr [7FF9C52CBD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5517680]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C550B6A8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 283
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7894DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,1FCBA4C3020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1FD3A4C1070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C61900]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 281
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9C52B9768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55E9330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C5138958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,22B9B402028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,22B97400070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C52FDA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF9C54F9228]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      qword ptr [7FF9C52BBD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5506CC0]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C54F98B8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 283
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7854DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,1E88B043020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1E88B049C68
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C21900]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 281
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9C52E9768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5619FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C5168958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,283F7402028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,283F3400070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C532DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF9C552B018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      qword ptr [7FF9C52EBD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5537680]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C552B6A8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 283
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7884DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,2284EB53020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,2288EB51070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C51900]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 281
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9C52C9768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55FB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C5148958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,1B6B7002028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1B6B7008C68
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C530DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF9C550D228]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      qword ptr [7FF9C52CBD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C551B6F8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C550D8B8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 283
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7894DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,1A0D82B3020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1A0D82B9C68
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C61900]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 281
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9C52D9768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C560D330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C5158958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,1FD2E402028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1FD2A400070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C531DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF9C551D228]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      qword ptr [7FF9C52DBD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C552A968]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C551D8B8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 283
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7894DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,1CA06383020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1CA06389C68
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C61900]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 281
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9BE1D9768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9BE509FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9BE058958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,169E3802028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,169DB800888
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9BE21DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF9BE41B228]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      qword ptr [7FF9BE1DBD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9BE429308]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9BE41B8B8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 283
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7854DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,167F8413020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,167F8419C68
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C21900]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 281
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9C0939768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0C67FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C07B8958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,218B8402028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,218B8408450
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C097DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-24],eax
       mov       ecx,[rbp-24]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       edx,[rbp+10]
       call      qword ptr [7FF9C0B79228]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       mov       rax,[rbp-30]
       mov       [rbp-8],rax
       xor       eax,eax
       mov       [rbp-14],eax
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       rax,[rbp-8]
       mov       [rbp-38],rax
       call      qword ptr [7FF9C093BD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
       mov       [rbp-40],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-40]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0B86B30]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
       nop
       nop
       mov       ecx,[rbp-14]
       add       ecx,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],ecx
M01_L03:
       mov       eax,[rbp-14]
       cmp       eax,[rbp+10]
       setl      al
       movzx     eax,al
       mov       [rbp-18],eax
       cmp       dword ptr [rbp-18],0
       jne       short M01_L01
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0B798B8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].TrimExcess()
       nop
       mov       rax,[rbp-8]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 283
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7864DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,1B8BBD13020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1B87BD11070
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C28DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C28E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C79ECA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       jmp       short M01_L08
M01_L08:
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 411
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9C52E7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C561B330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C5168958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,13744402028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,13750400070
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C532DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5544B10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9C52E7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5544B50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      qword ptr [7FF9C52EBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5303330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 412
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7884DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,1F438583020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1F4C8581070
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C48E38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C48E78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7A0CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       jmp       short M01_L08
M01_L08:
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 411
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9C52C7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55F9330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C5148958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,236F0002028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,236F0008C68
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C530DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C55238A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9C52C7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C55238E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      qword ptr [7FF9C52CBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C52E3330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 412
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7894DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,2427D033020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,2425D031070
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C58DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C58E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7A1CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       jmp       short M01_L08
M01_L08:
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 411
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9C52D7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5609330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C5158958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,17502802028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,174FE800070
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C531DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C55338A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9C52D7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C55338E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      qword ptr [7FF9C52DBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C52F3330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 412
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7854DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,15243B53020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,15253B51070
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C18D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C18DD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C79DCA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       jmp       short M01_L08
M01_L08:
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 411
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9C52D7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C561BFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C5158958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,2D858002028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,2D85A004048
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C531DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5538608
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9C52D7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5538648
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      qword ptr [7FF9C52DBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C52F3330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 412
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7874DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,26F73543020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,26F83541070
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C38D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C38DD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C79FCA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       jmp       short M01_L08
M01_L08:
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 411
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9C52E7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5617FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C5168958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,1DC08C02028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1DC08C08C68
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C532DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5543120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9C52E7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5543160
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      qword ptr [7FF9C52EBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5303330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 412
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7894DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,16A75543020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,16A55541070
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C58D18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C58D58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7A1CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       jmp       short M01_L08
M01_L08:
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 411
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9C07E7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0B19330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C0668958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,2A693002028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,2A693008C68
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C082DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C0A438A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9C07E7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C0A438E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      qword ptr [7FF9C07EBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0803330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 412
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7864DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,18D423F3020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,18D423F9C68
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C28DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C28E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C79ECA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       jmp       short M01_L08
M01_L08:
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 411
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9C0957720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0C87FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C07D8958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,2B143800030
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,2B145800070
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C099DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C0BB2CF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9C0957A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C0BB2D30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      qword ptr [7FF9C095BCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0973330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 412
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7874DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,270FD953020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,270FD959C68
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C38DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C38E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C79FCA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       jmp       short M01_L08
M01_L08:
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 411
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9C52D7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C560D330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C5158958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,268A4402028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,268A4408450
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C531DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5536B88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9C52D7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5536BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      qword ptr [7FF9C52DBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C52F3330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 412
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7864DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,1C8C2B13020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1C8D2B11070
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C28CF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C28D38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C79ECA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       jmp       short M01_L08
M01_L08:
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 411
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9C52C7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55F7FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C5148958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,2628FC02028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,2628FC08C68
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C530DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5523150
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9C52C7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5523190
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      qword ptr [7FF9C52CBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C52E3330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 412
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7864DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,1FE28C63020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1FE08C61070
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C28DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C28E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C79ECA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       jmp       short M01_L08
M01_L08:
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 411
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9C52B7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55E7FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C5138958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,1ACA7402028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1ACA3400070
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C52FDA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5513AA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9C52B7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5513AE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      qword ptr [7FF9C52BBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C52D3330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 412
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7884DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,1AC3AA03020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1AC3AA09C68
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C48DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C48E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7A0CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       jmp       short M01_L08
M01_L08:
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 411
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9C52D7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5609FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C5158958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,28848402028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,28848408C68
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C531DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5534E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9C52D7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5534E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      qword ptr [7FF9C52DBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C52F3330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 412
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7884DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,24B448F3020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,24B448F9C68
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C48CF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C48D38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7A0CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       jmp       short M01_L08
M01_L08:
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 411
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9C52D7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C560D330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C5158958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,1527E802028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1527C800070
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C531DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5536C50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9C52D7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5536C90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      qword ptr [7FF9C52DBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C52F3330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 412
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7874DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,18E8EA91028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,18E6EA91070
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C38D80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C38DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C79FCA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       jmp       short M01_L08
M01_L08:
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 411
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9BE1C7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9BE4FB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9BE048958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,18044002028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1804E000070
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9BE20DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9BE427050
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9BE1C7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9BE427090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      qword ptr [7FF9BE1CBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9BE1E3330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 412
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 74
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C7874DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,186B7DC3020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,186E7DC1070
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C38CC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7C38D08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C79FCA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       jmp       short M01_L08
M01_L08:
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 411
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9C0947720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0C77FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],edx
       cmp       dword ptr [7FF9C07C8958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-18],r8
       mov       r8,[rbp-18]
       mov       [rsp+20],r8
       mov       r8,17DC8C02028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,17DC4C00070
       mov       r8,[r8]
       mov       ecx,[rbp+18]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C098DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-2C],eax
       mov       ecx,[rbp-2C]
       mov       [rbp+18],ecx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-40],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C0BA2320
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M01_L02:
       mov       rcx,[rbp-40]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9C0947A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       nop
       jmp       short M01_L07
M01_L03:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-48],rcx
       jmp       short M01_L05
M01_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C0BA2360
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M01_L05:
       mov       rcx,[rbp-10]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-48]
       mov       edx,19
       call      qword ptr [7FF9C094BCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rbp-58],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0963330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-1C]
       add       eax,1
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       [rbp-1C],eax
M01_L07:
       mov       ecx,[rbp-1C]
       cmp       ecx,[rbp+18]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-20],ecx
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rax,[rbp-10]
       mov       [rbp-28],rax
       nop
       mov       rax,[rbp-28]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 412
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rcx,275D02D7F10
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,275D02D7F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,275D02D7F10
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,275D02D2F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rbx,192B8C06F18
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,192B8C06F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,192B8C01F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C078B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C078B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rcx,2EFFCE97F10
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2EFFCE97F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,2EFFCE97F10
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2EFFCE92F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rbx,28AFF806F18
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,28AFF806F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,28AFF801F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C512B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C512B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rcx,2B43B277F10
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2B43B277F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,2B43B277F10
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2B43B272F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rbx,1D6F7C02B10
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1D6F7C02B08
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1D6FBC01F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C512B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C512B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rcx,20574335F18
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20574335F10
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,20574335F18
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,20594332F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rbx,195A5C04F20
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,195A5C04F18
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,195A9C01F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C512B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C512B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rcx,1ED6FDF3B08
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1ED6FDF3B00
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,1ED6FDF3B08
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1ED2FDF2F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rbx,18903406F18
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,18903406F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,18903401F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C50FB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C50FB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rcx,2357B053B08
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2357B053B00
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,2357B053B08
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2353B052F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rbx,1D1A6C04F20
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1D1A6C04F18
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1D1AAC01F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C510B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C510B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rcx,1DE660E7F10
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1DE660E7F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,1DE660E7F10
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1DE660E2F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.CoordinateProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rbx,25C2B406F18
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,25C2B406F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,25C2B401F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C511B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C511B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7894DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       lea       rcx,[rbp-8]
       lea       rdx,[rbp-10]
       lea       r8,[rbp-18]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       nop
       mov       ecx,[rbp+18]
       mov       [rsp+20],ecx
       mov       ecx,[rbp+20]
       mov       [rsp+28],ecx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       r9d,[rbp+10]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L01
M01_L01:
       mov       rax,[rbp-20]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FF9C52E71E0]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5619FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C5168958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       lea       rcx,[rbp-8]
       lea       rdx,[rbp-10]
       lea       r8,[rbp-18]
       call      qword ptr [7FF9C52E7150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       nop
       mov       ecx,[rbp+18]
       mov       [rsp+20],ecx
       mov       ecx,[rbp+20]
       mov       [rsp+28],ecx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       r9d,[rbp+10]
       call      qword ptr [7FF9C52E7108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7894DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       lea       rcx,[rbp-8]
       lea       rdx,[rbp-10]
       lea       r8,[rbp-18]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       nop
       mov       ecx,[rbp+18]
       mov       [rsp+20],ecx
       mov       ecx,[rbp+20]
       mov       [rsp+28],ecx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       r9d,[rbp+10]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L01
M01_L01:
       mov       rax,[rbp-20]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FF9C52E71E0]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5617FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C5168958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       lea       rcx,[rbp-8]
       lea       rdx,[rbp-10]
       lea       r8,[rbp-18]
       call      qword ptr [7FF9C52E7150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       nop
       mov       ecx,[rbp+18]
       mov       [rsp+20],ecx
       mov       ecx,[rbp+20]
       mov       [rsp+28],ecx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       r9d,[rbp+10]
       call      qword ptr [7FF9C52E7108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7874DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       lea       rcx,[rbp-8]
       lea       rdx,[rbp-10]
       lea       r8,[rbp-18]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       nop
       mov       ecx,[rbp+18]
       mov       [rsp+20],ecx
       mov       ecx,[rbp+20]
       mov       [rsp+28],ecx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       r9d,[rbp+10]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L01
M01_L01:
       mov       rax,[rbp-20]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FF9C52E71E0]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5619FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C5168958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       lea       rcx,[rbp-8]
       lea       rdx,[rbp-10]
       lea       r8,[rbp-18]
       call      qword ptr [7FF9C52E7150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       nop
       mov       ecx,[rbp+18]
       mov       [rsp+20],ecx
       mov       ecx,[rbp+20]
       mov       [rsp+28],ecx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       r9d,[rbp+10]
       call      qword ptr [7FF9C52E7108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7884DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       lea       rcx,[rbp-8]
       lea       rdx,[rbp-10]
       lea       r8,[rbp-18]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       nop
       mov       ecx,[rbp+18]
       mov       [rsp+20],ecx
       mov       ecx,[rbp+20]
       mov       [rsp+28],ecx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       r9d,[rbp+10]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L01
M01_L01:
       mov       rax,[rbp-20]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FF9C52D71E0]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C560D330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C5158958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       lea       rcx,[rbp-8]
       lea       rdx,[rbp-10]
       lea       r8,[rbp-18]
       call      qword ptr [7FF9C52D7150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       nop
       mov       ecx,[rbp+18]
       mov       [rsp+20],ecx
       mov       ecx,[rbp+20]
       mov       [rsp+28],ecx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       r9d,[rbp+10]
       call      qword ptr [7FF9C52D7108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7864DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       lea       rcx,[rbp-8]
       lea       rdx,[rbp-10]
       lea       r8,[rbp-18]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       nop
       mov       ecx,[rbp+18]
       mov       [rsp+20],ecx
       mov       ecx,[rbp+20]
       mov       [rsp+28],ecx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       r9d,[rbp+10]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L01
M01_L01:
       mov       rax,[rbp-20]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FF9C52F71E0]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5627FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C5178958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       lea       rcx,[rbp-8]
       lea       rdx,[rbp-10]
       lea       r8,[rbp-18]
       call      qword ptr [7FF9C52F7150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       nop
       mov       ecx,[rbp+18]
       mov       [rsp+20],ecx
       mov       ecx,[rbp+20]
       mov       [rsp+28],ecx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       r9d,[rbp+10]
       call      qword ptr [7FF9C52F7108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7874DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       lea       rcx,[rbp-8]
       lea       rdx,[rbp-10]
       lea       r8,[rbp-18]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       nop
       mov       ecx,[rbp+18]
       mov       [rsp+20],ecx
       mov       ecx,[rbp+20]
       mov       [rsp+28],ecx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       r9d,[rbp+10]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L01
M01_L01:
       mov       rax,[rbp-20]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FF9BE1D71E0]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9BE50B330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9BE058958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       lea       rcx,[rbp-8]
       lea       rdx,[rbp-10]
       lea       r8,[rbp-18]
       call      qword ptr [7FF9BE1D7150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       nop
       mov       ecx,[rbp+18]
       mov       [rsp+20],ecx
       mov       ecx,[rbp+20]
       mov       [rsp+28],ecx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       r9d,[rbp+10]
       call      qword ptr [7FF9BE1D7108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,14
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C7874DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       lea       rcx,[rbp-8]
       lea       rdx,[rbp-10]
       lea       r8,[rbp-18]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       nop
       mov       ecx,[rbp+18]
       mov       [rsp+20],ecx
       mov       ecx,[rbp+20]
       mov       [rsp+28],ecx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       r9d,[rbp+10]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L01
M01_L01:
       mov       rax,[rbp-20]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,14
       call      qword ptr [7FF9C09671E0]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0C97FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C07E8958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       lea       rcx,[rbp-8]
       lea       rdx,[rbp-10]
       lea       r8,[rbp-18]
       call      qword ptr [7FF9C0967150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       nop
       mov       ecx,[rbp+18]
       mov       [rsp+20],ecx
       mov       ecx,[rbp+20]
       mov       [rsp+28],ecx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       mov       r8,[rbp-18]
       mov       r9d,[rbp+10]
       call      qword ptr [7FF9C0967108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       mov       [rbp-28],rax
       mov       rax,[rbp-28]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 133
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C7884DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,1EEB9BA3020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1EEB9BA9C68
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       ecx,[rbp+18]
       mov       edx,[rbp+20]
       mov       r8d,[rbp+28]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7A0CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],eax
M01_L03:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       jne       short M01_L01
       mov       rax,[rbp-8]
       mov       [rbp-30],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-30]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 301
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF9C52D73C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5609FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C5158958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,1354B802028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,13549800070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C531DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9C52D7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       ecx,[rbp+18]
       mov       edx,[rbp+20]
       mov       r8d,[rbp+28]
       call      qword ptr [7FF9C52D73A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C52F3330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],eax
M01_L03:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       jne       short M01_L01
       mov       rax,[rbp-8]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 302
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C7874DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,1A940151028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1A920151070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       ecx,[rbp+18]
       mov       edx,[rbp+20]
       mov       r8d,[rbp+28]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C79FCA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],eax
M01_L03:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       jne       short M01_L01
       mov       rax,[rbp-8]
       mov       [rbp-30],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-30]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 301
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF9C52B73C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55E9330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C5138958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,285CC002028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,285D2000070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C52FDA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9C52B7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       ecx,[rbp+18]
       mov       edx,[rbp+20]
       mov       r8d,[rbp+28]
       call      qword ptr [7FF9C52B73A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C52D3330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],eax
M01_L03:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       jne       short M01_L01
       mov       rax,[rbp-8]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 302
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C7894DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,150D61C3020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,150B61C5860
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       ecx,[rbp+18]
       mov       edx,[rbp+20]
       mov       r8d,[rbp+28]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7A1CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],eax
M01_L03:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       jne       short M01_L01
       mov       rax,[rbp-8]
       mov       [rbp-30],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-30]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 301
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF9C52E73C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5619330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C5168958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,2083E002028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,2083E008C68
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C532DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9C52E7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       ecx,[rbp+18]
       mov       edx,[rbp+20]
       mov       r8d,[rbp+28]
       call      qword ptr [7FF9C52E73A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5303330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],eax
M01_L03:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       jne       short M01_L01
       mov       rax,[rbp-8]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 302
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C7864DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,1981BDE3020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1980BDE1070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       ecx,[rbp+18]
       mov       edx,[rbp+20]
       mov       r8d,[rbp+28]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C79ECA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],eax
M01_L03:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       jne       short M01_L01
       mov       rax,[rbp-8]
       mov       [rbp-30],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-30]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 301
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF9C52B73C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55EB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C5138958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,2F509402028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,2F505400070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C52FDA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9C52B7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       ecx,[rbp+18]
       mov       edx,[rbp+20]
       mov       r8d,[rbp+28]
       call      qword ptr [7FF9C52B73A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C52D3330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],eax
M01_L03:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       jne       short M01_L01
       mov       rax,[rbp-8]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 302
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C7894DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,28CF50B3020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,28D050B1070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       ecx,[rbp+18]
       mov       edx,[rbp+20]
       mov       r8d,[rbp+28]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7A1CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],eax
M01_L03:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       jne       short M01_L01
       mov       rax,[rbp-8]
       mov       [rbp-30],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-30]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 301
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF9C52E73C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C561BFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C5168958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,1F3C6002028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1F3C8000070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C532DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9C52E7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       ecx,[rbp+18]
       mov       edx,[rbp+20]
       mov       r8d,[rbp+28]
       call      qword ptr [7FF9C52E73A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5303330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],eax
M01_L03:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       jne       short M01_L01
       mov       rax,[rbp-8]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 302
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C7864DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,188C22B3020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,188C22B5478
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       ecx,[rbp+18]
       mov       edx,[rbp+20]
       mov       r8d,[rbp+28]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C79ECA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],eax
M01_L03:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       jne       short M01_L01
       mov       rax,[rbp-8]
       mov       [rbp-30],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-30]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 301
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF9C07E73C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0B17FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C0668958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,24CE8402028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,24CE8408C68
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C082DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9C07E7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       ecx,[rbp+18]
       mov       edx,[rbp+20]
       mov       r8d,[rbp+28]
       call      qword ptr [7FF9C07E73A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0803330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],eax
M01_L03:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       jne       short M01_L01
       mov       rax,[rbp-8]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 302
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C7894DD8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,182D1663020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,182D1669C68
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       ecx,[rbp+18]
       mov       edx,[rbp+20]
       mov       r8d,[rbp+28]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7A1CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],eax
M01_L03:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       jne       short M01_L01
       mov       rax,[rbp-8]
       mov       [rbp-30],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-30]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 301
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       mov       edx,2
       mov       r8d,19
       mov       r9d,14
       call      qword ptr [7FF9C09473C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0C77FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],ecx
       mov       [rbp+18],edx
       mov       [rbp+20],r8d
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C07C8958],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       xor       r8d,r8d
       mov       [rbp-10],r8
       mov       r8,[rbp-10]
       mov       [rsp+20],r8
       mov       r8,238CF402028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,238C7400070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C098DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9C0947A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       short M01_L03
M01_L01:
       nop
       mov       ecx,[rbp+18]
       mov       edx,[rbp+20]
       mov       r8d,[rbp+28]
       call      qword ptr [7FF9C09473A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp-20],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0963330]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M01_L02
       call      CORINFO_HELP_OVERFLOW
M01_L02:
       mov       [rbp-14],eax
M01_L03:
       mov       ecx,[rbp-14]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       jne       short M01_L01
       mov       rax,[rbp-8]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 302
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,150
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7874DD8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       r8d,r8d
       mov       [rbp-20],r8
       mov       r8,[rbp-20]
       mov       [rsp+20],r8
       mov       r8,15CD9213020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,15D69211070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L04
M01_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-0B8]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-130],rcx
       lea       rdi,[rbp-128]
       lea       rsi,[rbp-0B8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp-130]
       lea       rdx,[rbp-128]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C437B0]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       nop
       nop
       mov       eax,[rbp-24]
       add       eax,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-24],eax
M01_L04:
       mov       ecx,[rbp-24]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       jne       short M01_L02
       mov       rax,[rbp-18]
       mov       [rbp-30],rax
       nop
       jmp       short M01_L05
M01_L05:
       mov       rax,[rbp-30]
       add       rsp,150
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 338
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9C54FBBE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55EB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,150
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C5138958],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       r8d,r8d
       mov       [rbp-20],r8
       mov       r8,[rbp-20]
       mov       [rsp+20],r8
       mov       r8,24325402028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,24321400070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C52FDA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9C54FBC00]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L04
M01_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-0B8]
       mov       edx,19
       call      qword ptr [7FF9C52BBD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-130],rcx
       lea       rdi,[rbp-128]
       lea       rsi,[rbp-0B8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp-130]
       lea       rdx,[rbp-128]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C550AD30]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       nop
       nop
       mov       eax,[rbp-24]
       add       eax,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-24],eax
M01_L04:
       mov       ecx,[rbp-24]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       jne       short M01_L02
       mov       rax,[rbp-18]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,150
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 339
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,150
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7854DD8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       r8d,r8d
       mov       [rbp-20],r8
       mov       r8,[rbp-20]
       mov       [rsp+20],r8
       mov       r8,2211C733020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,220EC731070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L04
M01_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-0B8]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-130],rcx
       lea       rdi,[rbp-128]
       lea       rsi,[rbp-0B8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp-130]
       lea       rdx,[rbp-128]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C237B0]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       nop
       nop
       mov       eax,[rbp-24]
       add       eax,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-24],eax
M01_L04:
       mov       ecx,[rbp-24]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       jne       short M01_L02
       mov       rax,[rbp-18]
       mov       [rbp-30],rax
       nop
       jmp       short M01_L05
M01_L05:
       mov       rax,[rbp-30]
       add       rsp,150
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 338
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9C54F9BE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55E7FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,150
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C5138958],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       r8d,r8d
       mov       [rbp-20],r8
       mov       r8,[rbp-20]
       mov       [rsp+20],r8
       mov       r8,1AEA9002028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1AEA9008C68
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C52FDA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9C54F9C00]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L04
M01_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-0B8]
       mov       edx,19
       call      qword ptr [7FF9C52BBD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-130],rcx
       lea       rdi,[rbp-128]
       lea       rsi,[rbp-0B8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp-130]
       lea       rdx,[rbp-128]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5508A58]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       nop
       nop
       mov       eax,[rbp-24]
       add       eax,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-24],eax
M01_L04:
       mov       ecx,[rbp-24]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       jne       short M01_L02
       mov       rax,[rbp-18]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,150
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 339
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,150
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7874DD8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       r8d,r8d
       mov       [rbp-20],r8
       mov       r8,[rbp-20]
       mov       [rsp+20],r8
       mov       r8,2211AA23020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,220EAA21070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L04
M01_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-0B8]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-130],rcx
       lea       rdi,[rbp-128]
       lea       rsi,[rbp-0B8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp-130]
       lea       rdx,[rbp-128]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C437B0]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       nop
       nop
       mov       eax,[rbp-24]
       add       eax,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-24],eax
M01_L04:
       mov       ecx,[rbp-24]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       jne       short M01_L02
       mov       rax,[rbp-18]
       mov       [rbp-30],rax
       nop
       jmp       short M01_L05
M01_L05:
       mov       rax,[rbp-30]
       add       rsp,150
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 338
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9C552B9D8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5619FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,150
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C5168958],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       r8d,r8d
       mov       [rbp-20],r8
       mov       r8,[rbp-20]
       mov       [rsp+20],r8
       mov       r8,23128402028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,2312A400070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C532DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9C552B9F0]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L04
M01_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-0B8]
       mov       edx,19
       call      qword ptr [7FF9C52EBD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-130],rcx
       lea       rdi,[rbp-128]
       lea       rsi,[rbp-0B8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp-130]
       lea       rdx,[rbp-128]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55390A8]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       nop
       nop
       mov       eax,[rbp-24]
       add       eax,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-24],eax
M01_L04:
       mov       ecx,[rbp-24]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       jne       short M01_L02
       mov       rax,[rbp-18]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,150
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 339
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,150
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7884DD8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       r8d,r8d
       mov       [rbp-20],r8
       mov       r8,[rbp-20]
       mov       [rsp+20],r8
       mov       r8,20F45433020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,20F05431070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L04
M01_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-0B8]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-130],rcx
       lea       rdi,[rbp-128]
       lea       rsi,[rbp-0B8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp-130]
       lea       rdx,[rbp-128]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C53658]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       nop
       nop
       mov       eax,[rbp-24]
       add       eax,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-24],eax
M01_L04:
       mov       ecx,[rbp-24]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       jne       short M01_L02
       mov       rax,[rbp-18]
       mov       [rbp-30],rax
       nop
       jmp       short M01_L05
M01_L05:
       mov       rax,[rbp-30]
       add       rsp,150
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 338
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9C54FBBE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C55EB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,150
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C5138958],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       r8d,r8d
       mov       [rbp-20],r8
       mov       r8,[rbp-20]
       mov       [rsp+20],r8
       mov       r8,11DA0802028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,11DA0808C68
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C52FDA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9C54FBC00]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L04
M01_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-0B8]
       mov       edx,19
       call      qword ptr [7FF9C52BBD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-130],rcx
       lea       rdi,[rbp-128]
       lea       rsi,[rbp-0B8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp-130]
       lea       rdx,[rbp-128]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C550A2C0]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       nop
       nop
       mov       eax,[rbp-24]
       add       eax,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-24],eax
M01_L04:
       mov       ecx,[rbp-24]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       jne       short M01_L02
       mov       rax,[rbp-18]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,150
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 339
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,150
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7884DD8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       r8d,r8d
       mov       [rbp-20],r8
       mov       r8,[rbp-20]
       mov       [rsp+20],r8
       mov       r8,235048A3020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,235048A5478
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L04
M01_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-0B8]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-130],rcx
       lea       rdi,[rbp-128]
       lea       rsi,[rbp-0B8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp-130]
       lea       rdx,[rbp-128]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C537B0]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       nop
       nop
       mov       eax,[rbp-24]
       add       eax,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-24],eax
M01_L04:
       mov       ecx,[rbp-24]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       jne       short M01_L02
       mov       rax,[rbp-18]
       mov       [rbp-30],rax
       nop
       jmp       short M01_L05
M01_L05:
       mov       rax,[rbp-30]
       add       rsp,150
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 338
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9C551B9D8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C560B330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,150
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C5158958],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       r8d,r8d
       mov       [rbp-20],r8
       mov       r8,[rbp-20]
       mov       [rsp+20],r8
       mov       r8,13C90C02028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,13C98C00070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C531DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9C551B9F0]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L04
M01_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-0B8]
       mov       edx,19
       call      qword ptr [7FF9C52DBD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-130],rcx
       lea       rdi,[rbp-128]
       lea       rsi,[rbp-0B8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp-130]
       lea       rdx,[rbp-128]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5528F60]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       nop
       nop
       mov       eax,[rbp-24]
       add       eax,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-24],eax
M01_L04:
       mov       ecx,[rbp-24]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       jne       short M01_L02
       mov       rax,[rbp-18]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,150
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 339
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,150
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7864DD8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       r8d,r8d
       mov       [rbp-20],r8
       mov       r8,[rbp-20]
       mov       [rsp+20],r8
       mov       r8,272E5113020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,272E5115478
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L04
M01_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-0B8]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-130],rcx
       lea       rdi,[rbp-128]
       lea       rsi,[rbp-0B8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp-130]
       lea       rdx,[rbp-128]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C33658]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       nop
       nop
       mov       eax,[rbp-24]
       add       eax,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-24],eax
M01_L04:
       mov       ecx,[rbp-24]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       jne       short M01_L02
       mov       rax,[rbp-18]
       mov       [rbp-30],rax
       nop
       jmp       short M01_L05
M01_L05:
       mov       rax,[rbp-30]
       add       rsp,150
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 338
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9C0A0B9D8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0AF9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,150
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C0648958],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       r8d,r8d
       mov       [rbp-20],r8
       mov       r8,[rbp-20]
       mov       [rsp+20],r8
       mov       r8,249C8802028
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,249C0800070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C080DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9C0A0B9F0]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L04
M01_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-0B8]
       mov       edx,19
       call      qword ptr [7FF9C07CBD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-130],rcx
       lea       rdi,[rbp-128]
       lea       rsi,[rbp-0B8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp-130]
       lea       rdx,[rbp-128]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0A19418]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       nop
       nop
       mov       eax,[rbp-24]
       add       eax,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-24],eax
M01_L04:
       mov       ecx,[rbp-24]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       jne       short M01_L02
       mov       rax,[rbp-18]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,150
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 339
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,150
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C7854DD8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       r8d,r8d
       mov       [rbp-20],r8
       mov       r8,[rbp-20]
       mov       [rsp+20],r8
       mov       r8,1CDDFF83020
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,1CE5FF81070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L04
M01_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-0B8]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-130],rcx
       lea       rdi,[rbp-128]
       lea       rsi,[rbp-0B8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp-130]
       lea       rdx,[rbp-128]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C7C237B0]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       nop
       nop
       mov       eax,[rbp-24]
       add       eax,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-24],eax
M01_L04:
       mov       ecx,[rbp-24]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       jne       short M01_L02
       mov       rax,[rbp-18]
       mov       [rbp-30],rax
       nop
       jmp       short M01_L05
M01_L05:
       mov       rax,[rbp-30]
       add       rsp,150
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 338
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9C0B99BE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0C89330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,150
       lea       rbp,[rsp+160]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],ecx
       cmp       dword ptr [7FF9C07D8958],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       r8d,r8d
       mov       [rbp-20],r8
       mov       r8,[rbp-20]
       mov       [rsp+20],r8
       mov       r8,270E1400030
       mov       r8,[r8]
       mov       [rsp+28],r8
       mov       r8,270E3400070
       mov       r8,[r8]
       mov       ecx,[rbp+10]
       mov       edx,1
       mov       r9d,7FFFFFFF
       call      qword ptr [7FF9C099DA98]; DotNetTips.Spargine.Core.Validator.ArgumentInRange(Int32, Int32, System.String, Int32, System.Nullable`1<Int32>, System.String)
       mov       [rbp-34],eax
       mov       ecx,[rbp-34]
       mov       [rbp+10],ecx
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9C0B99C00]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]..ctor()
       mov       rcx,[rbp-40]
       mov       [rbp-18],rcx
       xor       ecx,ecx
       mov       [rbp-24],ecx
       nop
       jmp       short M01_L04
M01_L02:
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-48],rcx
       lea       rcx,[rbp-0B8]
       mov       edx,19
       call      qword ptr [7FF9C095BD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rbp-48]
       mov       [rbp-130],rcx
       lea       rdi,[rbp-128]
       lea       rsi,[rbp-0B8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp-130]
       lea       rdx,[rbp-128]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0BA8A58]; System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]].Add(DotNetTips.Spargine.Tester.Models.ValueTypes.Person)
       nop
       nop
       mov       eax,[rbp-24]
       add       eax,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-24],eax
M01_L04:
       mov       ecx,[rbp-24]
       cmp       ecx,[rbp+10]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-28],ecx
       cmp       dword ptr [rbp-28],0
       jne       short M01_L02
       mov       rax,[rbp-18]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,150
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 339
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,1B97D627F18
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1B97D627F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1B97D627F18
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1B97D622F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rbx,27C90406F20
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,27C90406F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,27C90401F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C512B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C512B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,23FFA9A7F18
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,23FFA9A7F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,23FFA9A7F18
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,23FFA9A2F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rbx,1A79E006F20
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1A79E006F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1A79E001F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C513B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C513B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,1231F707F18
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1231F707F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1231F707F18
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1231F702F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rbx,17803004F28
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,17803004F18
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,17807001F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C50FB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C50FB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,18A13767F18
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,18A13767F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,18A13767F18
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,18A13762F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rbx,1955A006F20
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1955A006F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1955A001F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C510B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C510B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,1487B387F18
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1487B387F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1487B387F18
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1487B382F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rbx,11248406F20
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,11248406F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,11248401F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C50FB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C50FB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,252CFF13B10
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,252CFF13B00
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,252CFF13B10
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2530FF12F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rbx,17E5A004F28
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,17E5A004F18
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,17E5E001F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C060B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C060B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,2626E2A7F18
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2626E2A7F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2626E2A7F18
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2626E2A2F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rbx,1973F006F20
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1973F006F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1973F001F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C077B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C077B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,13B549A7F20
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,13B549A7F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,13B549A7F20
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,13B549A2F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rbx,1DBC0806B10
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1DBC0806AF8
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1DBC0801F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C511B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C511B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,1C9FF9D7F20
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C9FF9D7F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1C9FF9D7F20
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1C9FF9D2F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rbx,26104406F28
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,26104406F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,26104401F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C510B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C510B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,2DF50C17F20
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2DF50C17F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2DF50C17F20
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2DF50C12F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rbx,2D77F006F28
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2D77F006F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2D77F001F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C510B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C510B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,1EEF8097F20
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1EEF8097F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1EEF8097F20
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1EEF8092F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rbx,17F09C06F28
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,17F09C06F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,17F09C01F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C512B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C512B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,23977CF7F20
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,23977CF7F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,23977CF7F20
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,23977CF2F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rbx,1F0E6406F28
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1F0E6406F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1F0E6401F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C510B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C510B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,1A9B82F7F20
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1A9B82F7F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1A9B82F7F20
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1A9B82F2F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rbx,202F9C06F28
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,202F9C06F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,202F9C01F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C05FB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C05FB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rcx,15BE6ED7F20
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,15BE6ED7F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,15BE6ED7F20
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,15BE6ED2F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonProperOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+290]
       mov       rbx,1FCCB406F28
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1FCCB406F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1FCCB401F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C07AB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C07AB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rcx,1C12D325F30
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C12D325F10
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,1C12D325F30
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1C14D322F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rbx,28CFF006F30
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,28CFF006F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,28CFF001F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C512B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C512B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rcx,1B26BD67F28
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1B26BD67F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,1B26BD67F28
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1B26BD62F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rbx,2D093002B28
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2D093002B08
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2D09B001F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C511B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C511B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rcx,2349B1C7F28
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2349B1C7F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,2349B1C7F28
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2349B1C2F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rbx,254D3C04F38
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,254D3C04F18
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,254D7C01F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C50FB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C50FB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rcx,29483947F28
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,29483947F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,29483947F28
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,29483942F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rbx,291E6C06F30
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,291E6C06F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,291E6C01F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C512B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C512B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rcx,21C6BCF7F28
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,21C6BCF7F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,21C6BCF7F28
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,21C6BCF2F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rbx,22C73406F30
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,22C73406F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,22C73401F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C512B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C512B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rcx,1DFBDAB7F28
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1DFBDAB7F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,1DFBDAB7F28
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1DFBDAB2F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rbx,23C36806F30
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,23C36806F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,23C36801F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C061B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C061B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rcx,2675AF77F28
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2675AF77F08
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,2675AF77F28
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbx,rbx
       je        short M00_L02
       xor       edx,edx
       mov       [rbp+10],rdx
       lea       rcx,[rbp+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,2675AF72F38
       mov       rdx,[rdx]
       lea       rcx,[rbp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbp+28],0
       mov       [rsp+20],rbp
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M00_L02:
       mov       ecx,9
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 259
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.PersonValOrderByBenchmark()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+298]
       mov       rbx,1F4F1006F30
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1F4F1006F10
       mov       rdx,[rdx]
       lea       rcx,[rbp+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbp+18],rdx
       mov       rcx,rbx
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M00_L00:
       mov       rcx,offset MT_System.Linq.OrderedEnumerable`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M00_L01
       test      rbp,rbp
       je        short M00_L02
       xor       edx,edx
       mov       [rbx+10],rdx
       lea       rcx,[rbx+18]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1F4F1001F50
       mov       rdx,[rdx]
       lea       rcx,[rbx+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rbx+28],0
       mov       [rsp+20],rbx
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rsi+8],rcx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M00_L01:
       mov       ecx,10
       call      qword ptr [7FF9C077B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9C077B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

