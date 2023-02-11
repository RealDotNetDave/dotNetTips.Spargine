## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A23928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       ecx,[rsp+28]
       mov       edx,[rsp+2C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L04
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       movsxd    r8,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L05
M01_L04:
       mov       [rsp+20],ecx
       mov       [rsp+24],edx
       mov       rcx,rdi
       mov       rdx,[rsp+20]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61AFEC28]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
M01_L07:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 259
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11621DB0]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11867FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115EBD68]
       mov       rdi,rax
       mov       rcx,215DA408C38
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115EBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115EB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11253510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA113E5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA11623018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFA115E3378]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+38],rax
       mov       ecx,[rsp+38]
       mov       edx,[rsp+3C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L05
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       mov       r8d,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L06
M01_L05:
       mov       [rsp+30],ecx
       mov       [rsp+34],edx
       mov       rcx,rdi
       mov       rdx,[rsp+30]
       call      qword ptr [7FFA11623198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA1120A108]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFA11623060]
M01_L08:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 479
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A33928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       ecx,[rsp+28]
       mov       edx,[rsp+2C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L04
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       movsxd    r8,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L05
M01_L04:
       mov       [rsp+20],ecx
       mov       [rsp+24],edx
       mov       rcx,rdi
       mov       rdx,[rsp+20]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B0EC28]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
M01_L07:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 259
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11631DB0]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11877FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115FBD68]
       mov       rdi,rax
       mov       rcx,216CA400040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115FBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115FB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115FBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113CFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11263510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115FBAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA113F5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA11633018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFA115F3378]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+38],rax
       mov       ecx,[rsp+38]
       mov       edx,[rsp+3C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L05
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       mov       r8d,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L06
M01_L05:
       mov       [rsp+30],ecx
       mov       [rsp+34],edx
       mov       rcx,rdi
       mov       rdx,[rsp+30]
       call      qword ptr [7FFA11633198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA1121A108]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFA11633060]
M01_L08:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 479
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A23928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       ecx,[rsp+28]
       mov       edx,[rsp+2C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L04
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       movsxd    r8,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L05
M01_L04:
       mov       [rsp+20],ecx
       mov       [rsp+24],edx
       mov       rcx,rdi
       mov       rdx,[rsp+20]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61AFEC28]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
M01_L07:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 259
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11601DB0]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11855FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115CBD68]
       mov       rdi,rax
       mov       rcx,1973F000040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115CBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115CB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115CBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA1139FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11233510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115CBAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA113C5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA11603018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFA115C3378]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+38],rax
       mov       ecx,[rsp+38]
       mov       edx,[rsp+3C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L05
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       mov       r8d,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L06
M01_L05:
       mov       [rsp+30],ecx
       mov       [rsp+34],edx
       mov       rcx,rdi
       mov       rdx,[rsp+30]
       call      qword ptr [7FFA11603198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA111EA128]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFA11603060]
M01_L08:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 479
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       ecx,[rsp+28]
       mov       edx,[rsp+2C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L04
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       movsxd    r8,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L05
M01_L04:
       mov       [rsp+20],ecx
       mov       [rsp+24],edx
       mov       rcx,rdi
       mov       rdx,[rsp+20]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B1EC28]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
M01_L07:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 259
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11611DB0]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11865FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115DBD68]
       mov       rdi,rax
       mov       rcx,2BB49800040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115DBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115DB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11243510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA113D5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA11613018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFA115D3378]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+38],rax
       mov       ecx,[rsp+38]
       mov       edx,[rsp+3C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L05
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       mov       r8d,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L06
M01_L05:
       mov       [rsp+30],ecx
       mov       [rsp+34],edx
       mov       rcx,rdi
       mov       rdx,[rsp+30]
       call      qword ptr [7FFA11613198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA111FA108]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFA11613060]
M01_L08:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 479
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A53928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       ecx,[rsp+28]
       mov       edx,[rsp+2C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L04
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       movsxd    r8,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L05
M01_L04:
       mov       [rsp+20],ecx
       mov       [rsp+24],edx
       mov       rcx,rdi
       mov       rdx,[rsp+20]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B2EC28]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
M01_L07:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 259
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11601DB0]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11855FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115CBD68]
       mov       rdi,rax
       mov       rcx,282BFC00040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115CBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115CB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115CBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA1139FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11233510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115CBAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA113C5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA11603018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFA115C3378]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+38],rax
       mov       ecx,[rsp+38]
       mov       edx,[rsp+3C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L05
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       mov       r8d,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L06
M01_L05:
       mov       [rsp+30],ecx
       mov       [rsp+34],edx
       mov       rcx,rdi
       mov       rdx,[rsp+30]
       call      qword ptr [7FFA11603198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA111EA108]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFA11603060]
M01_L08:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 479
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A63928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       ecx,[rsp+28]
       mov       edx,[rsp+2C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L04
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       movsxd    r8,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L05
M01_L04:
       mov       [rsp+20],ecx
       mov       [rsp+24],edx
       mov       rcx,rdi
       mov       rdx,[rsp+20]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B3EC28]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
M01_L07:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 259
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11641DB0]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11889330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA1160BD68]
       mov       rdi,rax
       mov       rcx,1DB64000040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA1160BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11476CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11476CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA1160B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA1160BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA1160D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113DFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11273510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA1160BAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA1160D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA11405750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA11643018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFA11603378]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+38],rax
       mov       ecx,[rsp+38]
       mov       edx,[rsp+3C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L05
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       mov       r8d,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L06
M01_L05:
       mov       [rsp+30],ecx
       mov       [rsp+34],edx
       mov       rcx,rdi
       mov       rdx,[rsp+30]
       call      qword ptr [7FFA11643198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA1122A128]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFA11643060]
M01_L08:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 479
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A33928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       ecx,[rsp+28]
       mov       edx,[rsp+2C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L04
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       movsxd    r8,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L05
M01_L04:
       mov       [rsp+20],ecx
       mov       [rsp+24],edx
       mov       rcx,rdi
       mov       rdx,[rsp+20]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B0EC28]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
M01_L07:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 259
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11621DB0]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11867FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115EBD68]
       mov       rdi,rax
       mov       rcx,27FA6C00040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115EBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115EB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11253510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA113E5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA11623018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFA115E3378]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+38],rax
       mov       ecx,[rsp+38]
       mov       edx,[rsp+3C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L05
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       mov       r8d,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L06
M01_L05:
       mov       [rsp+30],ecx
       mov       [rsp+34],edx
       mov       rcx,rdi
       mov       rdx,[rsp+30]
       call      qword ptr [7FFA11623198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA1120A128]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFA11623060]
M01_L08:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 479
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A63928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       ecx,[rsp+28]
       mov       edx,[rsp+2C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L04
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       movsxd    r8,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L05
M01_L04:
       mov       [rsp+20],ecx
       mov       [rsp+24],edx
       mov       rcx,rdi
       mov       rdx,[rsp+20]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B3EC28]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
M01_L07:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 259
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11611DB0]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11859330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115DBD68]
       mov       rdi,rax
       mov       rcx,1D0D6400040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115DBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115DB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11243510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA113D5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA11613018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFA115D3378]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+38],rax
       mov       ecx,[rsp+38]
       mov       edx,[rsp+3C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L05
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       mov       r8d,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L06
M01_L05:
       mov       [rsp+30],ecx
       mov       [rsp+34],edx
       mov       rcx,rdi
       mov       rdx,[rsp+30]
       call      qword ptr [7FFA11613198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA111FA128]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFA11613060]
M01_L08:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 479
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A33928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       ecx,[rsp+28]
       mov       edx,[rsp+2C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L04
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       movsxd    r8,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L05
M01_L04:
       mov       [rsp+20],ecx
       mov       [rsp+24],edx
       mov       rcx,rdi
       mov       rdx,[rsp+20]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B0EC28]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
M01_L07:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 259
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11621DB0]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11869330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115EBD68]
       mov       rdi,rax
       mov       rcx,167F1800040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115EBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115EB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11253510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA113E5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA11623018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFA115E3378]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+38],rax
       mov       ecx,[rsp+38]
       mov       edx,[rsp+3C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L05
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       mov       r8d,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L06
M01_L05:
       mov       [rsp+30],ecx
       mov       [rsp+34],edx
       mov       rcx,rdi
       mov       rdx,[rsp+30]
       call      qword ptr [7FFA11623198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA1120A148]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFA11623060]
M01_L08:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 479
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A23928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       ecx,[rsp+28]
       mov       edx,[rsp+2C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L04
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       movsxd    r8,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L05
M01_L04:
       mov       [rsp+20],ecx
       mov       [rsp+24],edx
       mov       rcx,rdi
       mov       rdx,[rsp+20]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61AFFC08]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
M01_L07:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 259
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11605E28]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11857330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115CBD68]
       mov       rdi,rax
       mov       rcx,14E90400040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115CBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115CB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115CBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA1139FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11233510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115CBAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA113C5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA11607018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFA115C3360]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+38],rax
       mov       ecx,[rsp+38]
       mov       edx,[rsp+3C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L05
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       mov       r8d,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L06
M01_L05:
       mov       [rsp+30],ecx
       mov       [rsp+34],edx
       mov       rcx,rdi
       mov       rdx,[rsp+30]
       call      qword ptr [7FFA11607198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA111EA108]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFA11607060]
M01_L08:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 479
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       ecx,[rsp+28]
       mov       edx,[rsp+2C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L04
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       movsxd    r8,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L05
M01_L04:
       mov       [rsp+20],ecx
       mov       [rsp+24],edx
       mov       rcx,rdi
       mov       rdx,[rsp+20]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B1FC08]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
M01_L07:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 259
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11615E28]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11859330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115DBD68]
       mov       rdi,rax
       mov       rcx,22E7B400040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115DBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115DB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11243510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA113D5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA11617018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFA115D3360]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+38],rax
       mov       ecx,[rsp+38]
       mov       edx,[rsp+3C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L05
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       mov       r8d,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L06
M01_L05:
       mov       [rsp+30],ecx
       mov       [rsp+34],edx
       mov       rcx,rdi
       mov       rdx,[rsp+30]
       call      qword ptr [7FFA11617198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA111FA108]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFA11617060]
M01_L08:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 479
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A63928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       ecx,[rsp+28]
       mov       edx,[rsp+2C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L04
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       movsxd    r8,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L05
M01_L04:
       mov       [rsp+20],ecx
       mov       [rsp+24],edx
       mov       rcx,rdi
       mov       rdx,[rsp+20]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B3FC08]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
M01_L07:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 259
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11625E28]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11867FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115EBD68]
       mov       rdi,rax
       mov       rcx,20BEF000040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115EBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115EB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11253510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA113E5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA11627018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFA115E3360]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+38],rax
       mov       ecx,[rsp+38]
       mov       edx,[rsp+3C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L05
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       mov       r8d,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L06
M01_L05:
       mov       [rsp+30],ecx
       mov       [rsp+34],edx
       mov       rcx,rdi
       mov       rdx,[rsp+30]
       call      qword ptr [7FFA11627198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA1120A108]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFA11627060]
M01_L08:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 479
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       ecx,[rsp+28]
       mov       edx,[rsp+2C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L04
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       movsxd    r8,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L05
M01_L04:
       mov       [rsp+20],ecx
       mov       [rsp+24],edx
       mov       rcx,rdi
       mov       rdx,[rsp+20]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B1FC08]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
M01_L07:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 259
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11615E28]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11857FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115DBD68]
       mov       rdi,rax
       mov       rcx,19823804448
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115DBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115DB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11243510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA113D5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA11617018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFA115D3360]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+38],rax
       mov       ecx,[rsp+38]
       mov       edx,[rsp+3C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L05
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       mov       r8d,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L06
M01_L05:
       mov       [rsp+30],ecx
       mov       [rsp+34],edx
       mov       rcx,rdi
       mov       rdx,[rsp+30]
       call      qword ptr [7FFA11617198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA111FA108]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFA11617060]
M01_L08:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 479
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A33928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       ecx,[rsp+28]
       mov       edx,[rsp+2C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L04
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       movsxd    r8,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L05
M01_L04:
       mov       [rsp+20],ecx
       mov       [rsp+24],edx
       mov       rcx,rdi
       mov       rdx,[rsp+20]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B0FC08]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
M01_L07:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 259
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11615E28]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11857FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115DBD68]
       mov       rdi,rax
       mov       rcx,1A175C00040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115DBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115DB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11243510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA113D5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA11617018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFA115D3360]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+38],rax
       mov       ecx,[rsp+38]
       mov       edx,[rsp+3C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L05
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       mov       r8d,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L06
M01_L05:
       mov       [rsp+30],ecx
       mov       [rsp+34],edx
       mov       rcx,rdi
       mov       rdx,[rsp+30]
       call      qword ptr [7FFA11617198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA111FA108]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFA11617060]
M01_L08:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 479
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A53928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       ecx,[rsp+28]
       mov       edx,[rsp+2C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L04
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       movsxd    r8,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L05
M01_L04:
       mov       [rsp+20],ecx
       mov       [rsp+24],edx
       mov       rcx,rdi
       mov       rdx,[rsp+20]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B2FC08]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
M01_L07:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 259
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11605E28]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11849330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115CBD68]
       mov       rdi,rax
       mov       rcx,2E296008C38
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115CBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115CB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115CBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA1139FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11233510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115CBAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA113C5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA11607018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFA115C3360]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+38],rax
       mov       ecx,[rsp+38]
       mov       edx,[rsp+3C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L05
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       mov       r8d,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L06
M01_L05:
       mov       [rsp+30],ecx
       mov       [rsp+34],edx
       mov       rcx,rdi
       mov       rdx,[rsp+30]
       call      qword ptr [7FFA11607198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA111EA128]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFA11607060]
M01_L08:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 479
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       ecx,[rsp+28]
       mov       edx,[rsp+2C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L04
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       movsxd    r8,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L05
M01_L04:
       mov       [rsp+20],ecx
       mov       [rsp+24],edx
       mov       rcx,rdi
       mov       rdx,[rsp+20]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B1FC08]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
M01_L07:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 259
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11635E28]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11877FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115FBD68]
       mov       rdi,rax
       mov       rcx,1B02A800858
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115FBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115FB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115FBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113CFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11263510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115FBAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA113F5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA11637018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFA115F3360]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+38],rax
       mov       ecx,[rsp+38]
       mov       edx,[rsp+3C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L05
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       mov       r8d,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L06
M01_L05:
       mov       [rsp+30],ecx
       mov       [rsp+34],edx
       mov       rcx,rdi
       mov       rdx,[rsp+30]
       call      qword ptr [7FFA11637198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA1121A128]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFA11637060]
M01_L08:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 479
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       ecx,[rsp+28]
       mov       edx,[rsp+2C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L04
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       movsxd    r8,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L05
M01_L04:
       mov       [rsp+20],ecx
       mov       [rsp+24],edx
       mov       rcx,rdi
       mov       rdx,[rsp+20]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B1FC08]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
M01_L07:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 259
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11625E28]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11875FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115EBD68]
       mov       rdi,rax
       mov       rcx,1C131400040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115EBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115EB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11253510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA113E5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA11627018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFA115E3360]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+38],rax
       mov       ecx,[rsp+38]
       mov       edx,[rsp+3C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L05
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       mov       r8d,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L06
M01_L05:
       mov       [rsp+30],ecx
       mov       [rsp+34],edx
       mov       rcx,rdi
       mov       rdx,[rsp+30]
       call      qword ptr [7FFA11627198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA1120A108]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFA11627060]
M01_L08:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 479
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A53928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+28],rax
       mov       ecx,[rsp+28]
       mov       edx,[rsp+2C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L04
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       movsxd    r8,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L05
M01_L04:
       mov       [rsp+20],ecx
       mov       [rsp+24],edx
       mov       rcx,rdi
       mov       rdx,[rsp+20]
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B2FC08]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
M01_L07:
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L08:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 259
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11615E28]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11859330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]](Int32)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       vzeroupper
       mov       esi,ecx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115DBD68]
       mov       rdi,rax
       mov       rcx,1A5FA800040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115DBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115DB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11243510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAE0]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFA113D5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFA11617018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFA115D3360]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, dotNetTips.Spargine.6.Tester]]()
       mov       [rsp+38],rax
       mov       ecx,[rsp+38]
       mov       edx,[rsp+3C]
       inc       dword ptr [rdi+14]
       mov       rax,[rdi+8]
       mov       r8d,[rdi+10]
       mov       r9d,[rax+8]
       cmp       r9d,r8d
       jbe       short M01_L05
       lea       r9d,[r8+1]
       mov       [rdi+10],r9d
       mov       r8d,r8d
       lea       rax,[rax+r8*8+10]
       mov       [rax],ecx
       mov       [rax+4],edx
       jmp       short M01_L06
M01_L05:
       mov       [rsp+30],ecx
       mov       [rsp+34],edx
       mov       rcx,rdi
       mov       rdx,[rsp+30]
       call      qword ptr [7FFA11617198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA111FA128]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFA11617060]
M01_L08:
       mov       rax,rdi
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 479
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L03
       mov       rcx,[rbx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA61C01A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA61C01AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA61BD78E8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L09
       cmp       r15d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFA11637900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11879330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115FBD68]
       mov       rbx,rax
       mov       rcx,19814808C38
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFA115FBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115FB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115FBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113CFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11263510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115FBAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L04
       mov       rcx,[rbx+10]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA1162A470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA115F3000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFA1162A4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115F13C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115DCAB8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L10
       cmp       r15d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 500
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L03
       mov       rcx,[rbx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA61C01A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA61C01AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA61BD78E8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L09
       cmp       r15d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFA11637900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11877FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115FBD68]
       mov       rbx,rax
       mov       rcx,1B04E000040
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFA115FBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115FB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115FBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113CFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11263510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115FBAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L04
       mov       rcx,[rbx+10]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA1162A470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA115F3000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFA1162A4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115F13C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115DCAB8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L10
       cmp       r15d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 500
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L03
       mov       rcx,[rbx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA61C01A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA61C01AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA61BD78E8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L09
       cmp       r15d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFA11637900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11877FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115FBD68]
       mov       rbx,rax
       mov       rcx,289B2C04830
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFA115FBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115FB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115FBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113CFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11263510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115FBAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L04
       mov       rcx,[rbx+10]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA1162A470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA115F3000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFA1162A4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115F13C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115DCAB8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L10
       cmp       r15d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 500
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A53928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L03
       mov       rcx,[rbx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA61C11A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA61C11AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA61BE78E8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L09
       cmp       r15d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFA11617900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11859330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115DBD68]
       mov       rbx,rax
       mov       rcx,118C0000858
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFA115DBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115DB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11243510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115DBAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L04
       mov       rcx,[rbx+10]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA1160A470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA115D3000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFA1160A4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115D13C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115BCAB8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L10
       cmp       r15d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 500
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A63928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L03
       mov       rcx,[rbx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA61C21A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA61C21AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA61BF78E8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L09
       cmp       r15d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFA11637900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11885FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115FBD68]
       mov       rbx,rax
       mov       rcx,1BFB7000858
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFA115FBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115FB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115FBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113CFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11263510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115FBAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L04
       mov       rcx,[rbx+10]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA1162A470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA115F3000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFA1162A4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115F13C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115DCAB8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L10
       cmp       r15d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 500
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A33928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L03
       mov       rcx,[rbx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA61BF1A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA61BF1AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA61BC78E8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L09
       cmp       r15d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFA11607900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11849330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115CBD68]
       mov       rbx,rax
       mov       rcx,274C3808C38
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFA115CBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115CB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115CBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA1139FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11233510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115CBAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113C5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L04
       mov       rcx,[rbx+10]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA115FA470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA115C3000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFA115FA4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115C13C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115ACAB8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L10
       cmp       r15d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 500
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A33928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L03
       mov       rcx,[rbx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA61BF1A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA61BF1AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA61BC78E8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L09
       cmp       r15d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFA11627900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11869330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115EBD68]
       mov       rbx,rax
       mov       rcx,158C2C00040
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFA115EBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115EB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11253510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115EBAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L04
       mov       rcx,[rbx+10]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA1161A470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA115E3000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFA1161A4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115E13C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115CCAB8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L10
       cmp       r15d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 500
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A53928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L03
       mov       rcx,[rbx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA61C11A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA61C11AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA61BE78E8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L09
       cmp       r15d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFA11647900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11889330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA1160BD68]
       mov       rbx,rax
       mov       rcx,27566808C38
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFA1160BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11476CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11476CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA1160B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA1160BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA1160D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113DFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11273510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA1160BAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA1160D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA11405750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L04
       mov       rcx,[rbx+10]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA1163A470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA11603000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFA1163A4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA116013C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115ECAB8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L10
       cmp       r15d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 500
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A33928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L03
       mov       rcx,[rbx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA61BF1A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA61BF1AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA61BC78E8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L09
       cmp       r15d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFA11637900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11877FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115FBD68]
       mov       rbx,rax
       mov       rcx,22ED2800040
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFA115FBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115FB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115FBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113CFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11263510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115FBAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L04
       mov       rcx,[rbx+10]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA1162A470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA115F3000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFA1162A4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115F13C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115DCAB8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L10
       cmp       r15d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 500
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L03
       mov       rcx,[rbx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA61C01A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA61C01AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA61BD78E8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L09
       cmp       r15d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFA11647900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11887FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA1160BD68]
       mov       rbx,rax
       mov       rcx,2530B000040
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFA1160BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11476CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11476CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA1160B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA1160BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA1160D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113DFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11273510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA1160BAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA1160D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA11405750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L04
       mov       rcx,[rbx+10]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA1163A470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA11603000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFA1163A4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA116013C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115ECAB8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L10
       cmp       r15d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 500
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A33928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L03
       mov       rcx,[rbx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA61BF1A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA61BF1AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA61BC78E8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L09
       cmp       r15d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFA11627900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11867FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115EBD68]
       mov       rbx,rax
       mov       rcx,2A51F000040
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFA115EBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115EB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11253510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115EBAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L04
       mov       rcx,[rbx+10]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA1161A470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA115E3000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFA1161A4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115E13C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115CCAB8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L10
       cmp       r15d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 500
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L03
       mov       rcx,[rbx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA61C01A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA61C01AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA61BD78E8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L09
       cmp       r15d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFA11607900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11849330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115CBD68]
       mov       rbx,rax
       mov       rcx,1D99A406C40
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFA115CBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115CB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115CBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA1139FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11233510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115CBAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113C5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L04
       mov       rcx,[rbx+10]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA115FA470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA115C3000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFA115FA4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115C13C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115ACAB8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L10
       cmp       r15d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 500
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A33928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L03
       mov       rcx,[rbx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA61BF1A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA61BF1AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA61BC78E8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L09
       cmp       r15d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFA11637900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11879330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115FBD68]
       mov       rbx,rax
       mov       rcx,16867C00040
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFA115FBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115FB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115FBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113CFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11263510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115FBAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L04
       mov       rcx,[rbx+10]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA1162A470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA115F3000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFA1162A4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115F13C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115DCAB8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L10
       cmp       r15d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 500
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L03
       mov       rcx,[rbx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA61C01A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA61C01AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA61BD78E8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L09
       cmp       r15d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFA11627900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11869330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115EBD68]
       mov       rbx,rax
       mov       rcx,24CD4008C38
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFA115EBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115EB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11253510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115EBAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L04
       mov       rcx,[rbx+10]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA1161A470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA115E3000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFA1161A4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115E13C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115CCAB8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L10
       cmp       r15d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 500
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A53928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L03
       mov       rcx,[rbx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA61C11A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA61C11AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA61BE78E8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L09
       cmp       r15d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFA11637900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11879330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115FBD68]
       mov       rbx,rax
       mov       rcx,1892D400040
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFA115FBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115FB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115FBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113CFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11263510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115FBAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L04
       mov       rcx,[rbx+10]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA1162A470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA115F3000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFA1162A4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115F13C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115DCAB8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L10
       cmp       r15d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 500
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L03
       mov       rcx,[rbx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA61C01A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA61C01AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA61BD78E8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L09
       cmp       r15d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFA11607900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11847FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115CBD68]
       mov       rbx,rax
       mov       rcx,25B33400040
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFA115CBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115CB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115CBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA1139FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11233510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115CBAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113C5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L04
       mov       rcx,[rbx+10]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA115FA470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA115C3000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFA115FA4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115C13C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115ACAB8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L10
       cmp       r15d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 500
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A53928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L03
       mov       rcx,[rbx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA61C11A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA61C11AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA61BE78E8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L09
       cmp       r15d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFA11627900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11867FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115EBD68]
       mov       rbx,rax
       mov       rcx,18E1EC00040
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFA115EBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115EB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11253510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115EBAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L04
       mov       rcx,[rbx+10]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA1161A470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA115E3000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFA1161A4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115E13C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115CCAB8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L10
       cmp       r15d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 500
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A33928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L03
       mov       rcx,[rbx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rdi
       mov       rdx,7FFA61BF1A80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFA61BF1AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA61BC78E8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L09
       cmp       r15d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 282
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFA11617900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11857FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp-30],rcx
       mov       rdi,rcx
       mov       esi,edx
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115DBD68]
       mov       rbx,rax
       mov       rcx,25022000040
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFA115DBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115DB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11243510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115DBAE0]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rbx,[rdi+10]
       cmp       qword ptr [rbx+10],0
       je        short M01_L04
       mov       rcx,[rbx+10]
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFA1160A470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFA115D3000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFA1160A4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115D13C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115BCAB8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r15d,1
       jo        short M01_L10
       cmp       r15d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,r14
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 500
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rsp+38],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+0A0]
       mov       r15d,[rsp+0A8]
       mov       r12d,[rsp+0B0]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,64
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,2
       jmp       short M01_L03
M01_L02:
       test      edx,edx
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+34],eax
       test      esi,esi
       jle       near ptr M01_L07
M01_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+20],rax
       call      System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,[rsp+28]
       lea       rcx,[rdx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+28]
       lea       rcx,[rdx+48]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       mov       rcx,[rsp+28]
       mov       r8,rcx
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M01_L05
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L06
M01_L05:
       mov       rcx,r13
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L06:
       mov       eax,[rsp+34]
       add       eax,1
       jo        short M01_L09
       cmp       eax,esi
       mov       [rsp+34],eax
       jl        near ptr M01_L04
M01_L07:
       mov       rdx,[r13+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B1D2D0]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L08
       mov       edx,[r13+10]
       mov       rcx,r13
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 584
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      qword ptr [7FFA115E1060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rsp+38],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       mov       r12d,[rsp+0C0]
       test      esi,esi
       jle       short M01_L00
       xor       eax,eax
       cmp       esi,64
       setle     al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,2
       jmp       near ptr M01_L04
M01_L02:
       test      edx,edx
       jne       near ptr M01_L04
       call      qword ptr [7FFA115EBD68]
       mov       r13,rax
       mov       rcx,1E7D9800040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115EBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115EB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA11253510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115EBAE0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      qword ptr [7FFA112C7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+44],eax
       test      esi,esi
       jle       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       call      qword ptr [7FFA115E9DE0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+30],rax
       call      qword ptr [7FFA115E9BE8]; System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,[rsp+38]
       lea       rcx,[rdx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+38]
       lea       rcx,[rdx+48]
       mov       rdx,[rsp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,edi
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621AB0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621B10]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621B40]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621B70]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      qword ptr [7FFA115E1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621BD0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFA115E11B0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621C00]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621C30]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       mov       rcx,[rsp+38]
       mov       r8,rcx
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M01_L06
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L07
M01_L06:
       mov       rcx,r13
       mov       rdx,r8
       call      qword ptr [7FFA112C7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L07:
       mov       eax,[rsp+44]
       add       eax,1
       jo        short M01_L10
       cmp       eax,esi
       mov       [rsp+44],eax
       jl        near ptr M01_L05
M01_L08:
       mov       rdx,[r13+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA1120E008]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L09
       mov       edx,[r13+10]
       mov       rcx,r13
       call      qword ptr [7FFA112C7960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L09:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 833
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rsp+38],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+0A0]
       mov       r15d,[rsp+0A8]
       mov       r12d,[rsp+0B0]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,64
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,2
       jmp       short M01_L03
M01_L02:
       test      edx,edx
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A33928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+34],eax
       test      esi,esi
       jle       near ptr M01_L07
M01_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+20],rax
       call      System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,[rsp+28]
       lea       rcx,[rdx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+28]
       lea       rcx,[rdx+48]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       mov       rcx,[rsp+28]
       mov       r8,rcx
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M01_L05
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L06
M01_L05:
       mov       rcx,r13
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L06:
       mov       eax,[rsp+34]
       add       eax,1
       jo        short M01_L09
       cmp       eax,esi
       mov       [rsp+34],eax
       jl        near ptr M01_L04
M01_L07:
       mov       rdx,[r13+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B0D2D0]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L08
       mov       edx,[r13+10]
       mov       rcx,r13
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 584
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      qword ptr [7FFA115D1060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rsp+38],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       mov       r12d,[rsp+0C0]
       test      esi,esi
       jle       short M01_L00
       xor       eax,eax
       cmp       esi,64
       setle     al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,2
       jmp       near ptr M01_L04
M01_L02:
       test      edx,edx
       jne       near ptr M01_L04
       call      qword ptr [7FFA115DBD68]
       mov       r13,rax
       mov       rcx,29D0F800040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115DBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115DB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA11243510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115DBAE0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      qword ptr [7FFA112B7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+44],eax
       test      esi,esi
       jle       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       call      qword ptr [7FFA115D9DE0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+30],rax
       call      qword ptr [7FFA115D9BE8]; System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,[rsp+38]
       lea       rcx,[rdx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+38]
       lea       rcx,[rdx+48]
       mov       rdx,[rsp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,edi
       call      qword ptr [7FFA115D1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11611AB0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      qword ptr [7FFA115D1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11611AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      qword ptr [7FFA115D1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11611B10]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFA115D1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11611B40]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFA115D1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11611B70]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      qword ptr [7FFA115D1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11611BD0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFA115D11B0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11611C00]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      qword ptr [7FFA115D1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11611C30]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       mov       rcx,[rsp+38]
       mov       r8,rcx
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M01_L06
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L07
M01_L06:
       mov       rcx,r13
       mov       rdx,r8
       call      qword ptr [7FFA112B7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L07:
       mov       eax,[rsp+44]
       add       eax,1
       jo        short M01_L10
       cmp       eax,esi
       mov       [rsp+44],eax
       jl        near ptr M01_L05
M01_L08:
       mov       rdx,[r13+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA111FDFE8]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L09
       mov       edx,[r13+10]
       mov       rcx,r13
       call      qword ptr [7FFA112B7960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L09:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 833
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rsp+38],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+0A0]
       mov       r15d,[rsp+0A8]
       mov       r12d,[rsp+0B0]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,64
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,2
       jmp       short M01_L03
M01_L02:
       test      edx,edx
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A63928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+34],eax
       test      esi,esi
       jle       near ptr M01_L07
M01_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+20],rax
       call      System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,[rsp+28]
       lea       rcx,[rdx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+28]
       lea       rcx,[rdx+48]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       mov       rcx,[rsp+28]
       mov       r8,rcx
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M01_L05
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L06
M01_L05:
       mov       rcx,r13
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L06:
       mov       eax,[rsp+34]
       add       eax,1
       jo        short M01_L09
       cmp       eax,esi
       mov       [rsp+34],eax
       jl        near ptr M01_L04
M01_L07:
       mov       rdx,[r13+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B3D2D0]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L08
       mov       edx,[r13+10]
       mov       rcx,r13
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 584
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      qword ptr [7FFA115D1060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rsp+38],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       mov       r12d,[rsp+0C0]
       test      esi,esi
       jle       short M01_L00
       xor       eax,eax
       cmp       esi,64
       setle     al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,2
       jmp       near ptr M01_L04
M01_L02:
       test      edx,edx
       jne       near ptr M01_L04
       call      qword ptr [7FFA115DBD68]
       mov       r13,rax
       mov       rcx,2373B004830
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115DBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115DB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA11243510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115DBAE0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      qword ptr [7FFA112B7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+44],eax
       test      esi,esi
       jle       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       call      qword ptr [7FFA115D9DE0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+30],rax
       call      qword ptr [7FFA115D9BE8]; System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,[rsp+38]
       lea       rcx,[rdx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+38]
       lea       rcx,[rdx+48]
       mov       rdx,[rsp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,edi
       call      qword ptr [7FFA115D1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11611AB0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      qword ptr [7FFA115D1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11611AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      qword ptr [7FFA115D1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11611B10]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFA115D1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11611B40]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFA115D1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11611B70]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      qword ptr [7FFA115D1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11611BD0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFA115D11B0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11611C00]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      qword ptr [7FFA115D1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11611C30]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       mov       rcx,[rsp+38]
       mov       r8,rcx
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M01_L06
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L07
M01_L06:
       mov       rcx,r13
       mov       rdx,r8
       call      qword ptr [7FFA112B7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L07:
       mov       eax,[rsp+44]
       add       eax,1
       jo        short M01_L10
       cmp       eax,esi
       mov       [rsp+44],eax
       jl        near ptr M01_L05
M01_L08:
       mov       rdx,[r13+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA111FE008]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L09
       mov       edx,[r13+10]
       mov       rcx,r13
       call      qword ptr [7FFA112B7960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L09:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 833
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rsp+38],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+0A0]
       mov       r15d,[rsp+0A8]
       mov       r12d,[rsp+0B0]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,64
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,2
       jmp       short M01_L03
M01_L02:
       test      edx,edx
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A63928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+34],eax
       test      esi,esi
       jle       near ptr M01_L07
M01_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+20],rax
       call      System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,[rsp+28]
       lea       rcx,[rdx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+28]
       lea       rcx,[rdx+48]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       mov       rcx,[rsp+28]
       mov       r8,rcx
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M01_L05
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L06
M01_L05:
       mov       rcx,r13
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L06:
       mov       eax,[rsp+34]
       add       eax,1
       jo        short M01_L09
       cmp       eax,esi
       mov       [rsp+34],eax
       jl        near ptr M01_L04
M01_L07:
       mov       rdx,[r13+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B3D2D0]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L08
       mov       edx,[r13+10]
       mov       rcx,r13
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 584
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      qword ptr [7FFA115E1060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rsp+38],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       mov       r12d,[rsp+0C0]
       test      esi,esi
       jle       short M01_L00
       xor       eax,eax
       cmp       esi,64
       setle     al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,2
       jmp       near ptr M01_L04
M01_L02:
       test      edx,edx
       jne       near ptr M01_L04
       call      qword ptr [7FFA115EBD68]
       mov       r13,rax
       mov       rcx,1BA26C06428
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115EBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115EB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA11253510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115EBAE0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      qword ptr [7FFA112C7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+44],eax
       test      esi,esi
       jle       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       call      qword ptr [7FFA115E9DE0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+30],rax
       call      qword ptr [7FFA115E9BE8]; System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,[rsp+38]
       lea       rcx,[rdx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+38]
       lea       rcx,[rdx+48]
       mov       rdx,[rsp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,edi
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621AB0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621B10]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621B40]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621B70]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      qword ptr [7FFA115E1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621BD0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFA115E11B0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621C00]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621C30]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       mov       rcx,[rsp+38]
       mov       r8,rcx
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M01_L06
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L07
M01_L06:
       mov       rcx,r13
       mov       rdx,r8
       call      qword ptr [7FFA112C7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L07:
       mov       eax,[rsp+44]
       add       eax,1
       jo        short M01_L10
       cmp       eax,esi
       mov       [rsp+44],eax
       jl        near ptr M01_L05
M01_L08:
       mov       rdx,[r13+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA1120DFE8]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L09
       mov       edx,[r13+10]
       mov       rcx,r13
       call      qword ptr [7FFA112C7960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L09:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 833
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rsp+38],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+0A0]
       mov       r15d,[rsp+0A8]
       mov       r12d,[rsp+0B0]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,64
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,2
       jmp       short M01_L03
M01_L02:
       test      edx,edx
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A53928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+34],eax
       test      esi,esi
       jle       near ptr M01_L07
M01_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+20],rax
       call      System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,[rsp+28]
       lea       rcx,[rdx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+28]
       lea       rcx,[rdx+48]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       mov       rcx,[rsp+28]
       mov       r8,rcx
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M01_L05
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L06
M01_L05:
       mov       rcx,r13
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L06:
       mov       eax,[rsp+34]
       add       eax,1
       jo        short M01_L09
       cmp       eax,esi
       mov       [rsp+34],eax
       jl        near ptr M01_L04
M01_L07:
       mov       rdx,[r13+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B2D2D0]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L08
       mov       edx,[r13+10]
       mov       rcx,r13
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 584
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      qword ptr [7FFA115E1060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rsp+38],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       mov       r12d,[rsp+0C0]
       test      esi,esi
       jle       short M01_L00
       xor       eax,eax
       cmp       esi,64
       setle     al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,2
       jmp       near ptr M01_L04
M01_L02:
       test      edx,edx
       jne       near ptr M01_L04
       call      qword ptr [7FFA115EBD68]
       mov       r13,rax
       mov       rcx,25CE9004830
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115EBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115EB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA11253510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115EBAE0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      qword ptr [7FFA112C7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+44],eax
       test      esi,esi
       jle       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       call      qword ptr [7FFA115E9DE0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+30],rax
       call      qword ptr [7FFA115E9BE8]; System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,[rsp+38]
       lea       rcx,[rdx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+38]
       lea       rcx,[rdx+48]
       mov       rdx,[rsp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,edi
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621AB0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621B10]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621B40]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621B70]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      qword ptr [7FFA115E1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621BD0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFA115E11B0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621C00]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621C30]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       mov       rcx,[rsp+38]
       mov       r8,rcx
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M01_L06
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L07
M01_L06:
       mov       rcx,r13
       mov       rdx,r8
       call      qword ptr [7FFA112C7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L07:
       mov       eax,[rsp+44]
       add       eax,1
       jo        short M01_L10
       cmp       eax,esi
       mov       [rsp+44],eax
       jl        near ptr M01_L05
M01_L08:
       mov       rdx,[r13+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA1120DFE8]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L09
       mov       edx,[r13+10]
       mov       rcx,r13
       call      qword ptr [7FFA112C7960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L09:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 833
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rsp+38],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+0A0]
       mov       r15d,[rsp+0A8]
       mov       r12d,[rsp+0B0]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,64
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,2
       jmp       short M01_L03
M01_L02:
       test      edx,edx
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A53928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+34],eax
       test      esi,esi
       jle       near ptr M01_L07
M01_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+20],rax
       call      System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,[rsp+28]
       lea       rcx,[rdx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+28]
       lea       rcx,[rdx+48]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       mov       rcx,[rsp+28]
       mov       r8,rcx
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M01_L05
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L06
M01_L05:
       mov       rcx,r13
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L06:
       mov       eax,[rsp+34]
       add       eax,1
       jo        short M01_L09
       cmp       eax,esi
       mov       [rsp+34],eax
       jl        near ptr M01_L04
M01_L07:
       mov       rdx,[r13+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B2D2D0]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L08
       mov       edx,[r13+10]
       mov       rcx,r13
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 584
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      qword ptr [7FFA115F1060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rsp+38],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       mov       r12d,[rsp+0C0]
       test      esi,esi
       jle       short M01_L00
       xor       eax,eax
       cmp       esi,64
       setle     al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,2
       jmp       near ptr M01_L04
M01_L02:
       test      edx,edx
       jne       near ptr M01_L04
       call      qword ptr [7FFA115FBD68]
       mov       r13,rax
       mov       rcx,20B44000040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115FBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115FB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115FBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113CFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA11263510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115FBAE0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      qword ptr [7FFA112D7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+44],eax
       test      esi,esi
       jle       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       call      qword ptr [7FFA115F9DE0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+30],rax
       call      qword ptr [7FFA115F9BE8]; System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,[rsp+38]
       lea       rcx,[rdx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+38]
       lea       rcx,[rdx+48]
       mov       rdx,[rsp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,edi
       call      qword ptr [7FFA115F1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11631AB0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      qword ptr [7FFA115F1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11631AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      qword ptr [7FFA115F1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11631B10]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFA115F1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11631B40]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFA115F1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11631B70]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      qword ptr [7FFA115F1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11631BD0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFA115F11B0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11631C00]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      qword ptr [7FFA115F1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11631C30]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       mov       rcx,[rsp+38]
       mov       r8,rcx
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M01_L06
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L07
M01_L06:
       mov       rcx,r13
       mov       rdx,r8
       call      qword ptr [7FFA112D7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L07:
       mov       eax,[rsp+44]
       add       eax,1
       jo        short M01_L10
       cmp       eax,esi
       mov       [rsp+44],eax
       jl        near ptr M01_L05
M01_L08:
       mov       rdx,[r13+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA1121DFE8]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L09
       mov       edx,[r13+10]
       mov       rcx,r13
       call      qword ptr [7FFA112D7960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L09:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 833
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rsp+38],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+0A0]
       mov       r15d,[rsp+0A8]
       mov       r12d,[rsp+0B0]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,64
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,2
       jmp       short M01_L03
M01_L02:
       test      edx,edx
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+34],eax
       test      esi,esi
       jle       near ptr M01_L07
M01_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+20],rax
       call      System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,[rsp+28]
       lea       rcx,[rdx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+28]
       lea       rcx,[rdx+48]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       mov       rcx,[rsp+28]
       mov       r8,rcx
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M01_L05
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L06
M01_L05:
       mov       rcx,r13
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L06:
       mov       eax,[rsp+34]
       add       eax,1
       jo        short M01_L09
       cmp       eax,esi
       mov       [rsp+34],eax
       jl        near ptr M01_L04
M01_L07:
       mov       rdx,[r13+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B1D2D0]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L08
       mov       edx,[r13+10]
       mov       rcx,r13
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 584
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      qword ptr [7FFA115E1060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rsp+38],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       mov       r12d,[rsp+0C0]
       test      esi,esi
       jle       short M01_L00
       xor       eax,eax
       cmp       esi,64
       setle     al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,2
       jmp       near ptr M01_L04
M01_L02:
       test      edx,edx
       jne       near ptr M01_L04
       call      qword ptr [7FFA115EBD68]
       mov       r13,rax
       mov       rcx,21B2C004830
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115EBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115EB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA11253510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115EBAE0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      qword ptr [7FFA112C7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+44],eax
       test      esi,esi
       jle       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       call      qword ptr [7FFA115E9DE0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+30],rax
       call      qword ptr [7FFA115E9BE8]; System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,[rsp+38]
       lea       rcx,[rdx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+38]
       lea       rcx,[rdx+48]
       mov       rdx,[rsp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,edi
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621AB0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621B10]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621B40]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621B70]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      qword ptr [7FFA115E1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621BD0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFA115E11B0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621C00]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621C30]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       mov       rcx,[rsp+38]
       mov       r8,rcx
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M01_L06
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L07
M01_L06:
       mov       rcx,r13
       mov       rdx,r8
       call      qword ptr [7FFA112C7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L07:
       mov       eax,[rsp+44]
       add       eax,1
       jo        short M01_L10
       cmp       eax,esi
       mov       [rsp+44],eax
       jl        near ptr M01_L05
M01_L08:
       mov       rdx,[r13+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA1120DFE8]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L09
       mov       edx,[r13+10]
       mov       rcx,r13
       call      qword ptr [7FFA112C7960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L09:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 833
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rsp+38],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+0A0]
       mov       r15d,[rsp+0A8]
       mov       r12d,[rsp+0B0]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,64
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,2
       jmp       short M01_L03
M01_L02:
       test      edx,edx
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+34],eax
       test      esi,esi
       jle       near ptr M01_L07
M01_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+20],rax
       call      System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,[rsp+28]
       lea       rcx,[rdx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+28]
       lea       rcx,[rdx+48]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       mov       rcx,[rsp+28]
       mov       r8,rcx
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M01_L05
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L06
M01_L05:
       mov       rcx,r13
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L06:
       mov       eax,[rsp+34]
       add       eax,1
       jo        short M01_L09
       cmp       eax,esi
       mov       [rsp+34],eax
       jl        near ptr M01_L04
M01_L07:
       mov       rdx,[r13+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B1D2D0]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L08
       mov       edx,[r13+10]
       mov       rcx,r13
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 584
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      qword ptr [7FFA115F1060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rsp+38],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       mov       r12d,[rsp+0C0]
       test      esi,esi
       jle       short M01_L00
       xor       eax,eax
       cmp       esi,64
       setle     al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,2
       jmp       near ptr M01_L04
M01_L02:
       test      edx,edx
       jne       near ptr M01_L04
       call      qword ptr [7FFA115FBD68]
       mov       r13,rax
       mov       rcx,24A42C00040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115FBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115FB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115FBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113CFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA11263510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115FBAE0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      qword ptr [7FFA112D7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+44],eax
       test      esi,esi
       jle       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       call      qword ptr [7FFA115F9DE0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+30],rax
       call      qword ptr [7FFA115F9BE8]; System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,[rsp+38]
       lea       rcx,[rdx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+38]
       lea       rcx,[rdx+48]
       mov       rdx,[rsp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,edi
       call      qword ptr [7FFA115F1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11631AB0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      qword ptr [7FFA115F1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11631AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      qword ptr [7FFA115F1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11631B10]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFA115F1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11631B40]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFA115F1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11631B70]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      qword ptr [7FFA115F1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11631BD0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFA115F11B0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11631C00]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      qword ptr [7FFA115F1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11631C30]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       mov       rcx,[rsp+38]
       mov       r8,rcx
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M01_L06
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L07
M01_L06:
       mov       rcx,r13
       mov       rdx,r8
       call      qword ptr [7FFA112D7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L07:
       mov       eax,[rsp+44]
       add       eax,1
       jo        short M01_L10
       cmp       eax,esi
       mov       [rsp+44],eax
       jl        near ptr M01_L05
M01_L08:
       mov       rdx,[r13+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA1121DFE8]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L09
       mov       edx,[r13+10]
       mov       rcx,r13
       call      qword ptr [7FFA112D7960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L09:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 833
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rsp+38],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+0A0]
       mov       r15d,[rsp+0A8]
       mov       r12d,[rsp+0B0]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,64
       setle     al
       movzx     eax,al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,2
       jmp       short M01_L03
M01_L02:
       test      edx,edx
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+34],eax
       test      esi,esi
       jle       near ptr M01_L07
M01_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+28],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+20],rax
       call      System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,[rsp+28]
       lea       rcx,[rdx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+28]
       lea       rcx,[rdx+48]
       mov       rdx,[rsp+20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+28]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       mov       rcx,[rsp+28]
       mov       r8,rcx
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M01_L05
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L06
M01_L05:
       mov       rcx,r13
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L06:
       mov       eax,[rsp+34]
       add       eax,1
       jo        short M01_L09
       cmp       eax,esi
       mov       [rsp+34],eax
       jl        near ptr M01_L04
M01_L07:
       mov       rdx,[r13+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA61B1D2D0]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L08
       mov       edx,[r13+10]
       mov       rcx,r13
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 584
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       xor       eax,eax
       mov       [rsp+38],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+284]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      qword ptr [7FFA115E1060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rsp+38],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rsp+38]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vzeroupper
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       mov       r12d,[rsp+0C0]
       test      esi,esi
       jle       short M01_L00
       xor       eax,eax
       cmp       esi,64
       setle     al
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M01_L02
       mov       esi,2
       jmp       near ptr M01_L04
M01_L02:
       test      edx,edx
       jne       near ptr M01_L04
       call      qword ptr [7FFA115EBD68]
       mov       r13,rax
       mov       rcx,293B5000040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115EBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115EB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA11253510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115EBAE0]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      qword ptr [7FFA112C7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+44],eax
       test      esi,esi
       jle       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       call      qword ptr [7FFA115E9DE0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+30],rax
       call      qword ptr [7FFA115E9BE8]; System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       rdx,[rsp+38]
       lea       rcx,[rdx+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rsp+38]
       lea       rcx,[rdx+48]
       mov       rdx,[rsp+30]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,edi
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621AB0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621B10]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621B40]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621B70]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      qword ptr [7FFA115E1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621BD0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFA115E11B0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621C00]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFA11621C30]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       mov       rcx,[rsp+38]
       mov       r8,rcx
       inc       dword ptr [r13+14]
       mov       rcx,[r13+8]
       mov       edx,[r13+10]
       cmp       [rcx+8],edx
       jbe       short M01_L06
       lea       eax,[rdx+1]
       mov       [r13+10],eax
       movsxd    rdx,edx
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L07
M01_L06:
       mov       rcx,r13
       mov       rdx,r8
       call      qword ptr [7FFA112C7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L07:
       mov       eax,[rsp+44]
       add       eax,1
       jo        short M01_L10
       cmp       eax,esi
       mov       [rsp+44],eax
       jl        near ptr M01_L05
M01_L08:
       mov       rdx,[r13+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFA1120DFE8]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L09
       mov       edx,[r13+10]
       mov       rcx,r13
       call      qword ptr [7FFA112C7960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L09:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rsi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 833
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+284]
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 125
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     cl
       movzx     ecx,cl
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A33928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFA618A4928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,18719EC2F38
       mov       rdx,[rdx]
       mov       rax,[rsp+48]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L04
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L05
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rdx,346DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L06
       mov       rdx,0FFFCB923A29C779B
       cmp       rcx,rdx
       jl        near ptr M01_L06
       imul      rax,rcx,2710
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2BCA2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0C000000000000000
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFA617A0340
       call      qword ptr [7FFA617A0340]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFA617A0348
       call      qword ptr [7FFA617A0348]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFA617A0350
       call      qword ptr [7FFA617A0350]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L05
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L03
M01_L04:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.SR.get_Overflow_TimeSpanTooLong()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      System.DateTime.ThrowTicksOutOfRange()
       int       3
M01_L08:
       xor       ecx,ecx
       call      System.DateTime.ThrowDateArithmetic(Int32)
       int       3
M01_L09:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
M01_L10:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 1156
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+284]
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      qword ptr [7FFA115E11C8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 126
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       mov       ecx,1
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       near ptr M01_L03
       call      qword ptr [7FFA115EBD68]
       mov       r12,rax
       mov       rcx,29FA4400040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115EBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115EB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11253510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115EBAE0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,29FA8401F70
       mov       rdx,[rdx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L05
M01_L04:
       call      qword ptr [7FFA115E1120]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      qword ptr [7FFA115E9DE0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      qword ptr [7FFA115E1B58]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA11443918]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      qword ptr [7FFA11463750]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [7FFA115E1180]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L06
       movsxd    rcx,ecx
       mov       rdx,141DD76000
       imul      rcx,rdx
       mov       rdx,0CCCCCCCCCCCCCCC
       cmp       rcx,rdx
       jg        near ptr M01_L09
       mov       rdx,0F333333333333334
       cmp       rcx,rdx
       jl        near ptr M01_L09
       lea       rax,[rcx+rcx*4]
       add       rax,rax
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      qword ptr [7FFA11443450]; System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2BCA2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0C000000000000000
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      qword ptr [7FFA11463048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      qword ptr [7FFA115E1AF8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115E1B88]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      qword ptr [7FFA115E1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115E1BB8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115E1C18]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      qword ptr [7FFA115E1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115E1B28]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      qword ptr [7FFA115E1060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFA11010858
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFA11010860
       call      qword ptr [r11]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFA11010868
       call      qword ptr [r11]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L06
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       call      qword ptr [7FFA11441180]
       int       3
M01_L08:
       xor       ecx,ecx
       call      qword ptr [7FFA114411E0]
       int       3
M01_L09:
       call      qword ptr [7FFA11417678]
       int       3
M01_L10:
       mov       ecx,7
       call      qword ptr [7FFA114178E8]
       int       3
; Total bytes of code 1308
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+284]
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 125
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     cl
       movzx     ecx,cl
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A63928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFA618D4928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,292E7262F38
       mov       rdx,[rdx]
       mov       rax,[rsp+48]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L04
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L05
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rdx,346DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L06
       mov       rdx,0FFFCB923A29C779B
       cmp       rcx,rdx
       jl        near ptr M01_L06
       imul      rax,rcx,2710
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2BCA2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0C000000000000000
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFA617D0340
       call      qword ptr [7FFA617D0340]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFA617D0348
       call      qword ptr [7FFA617D0348]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFA617D0350
       call      qword ptr [7FFA617D0350]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L05
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L03
M01_L04:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.SR.get_Overflow_TimeSpanTooLong()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      System.DateTime.ThrowTicksOutOfRange()
       int       3
M01_L08:
       xor       ecx,ecx
       call      System.DateTime.ThrowDateArithmetic(Int32)
       int       3
M01_L09:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
M01_L10:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 1156
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+284]
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      qword ptr [7FFA115D11C8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 126
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       mov       ecx,1
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       near ptr M01_L03
       call      qword ptr [7FFA115DBD68]
       mov       r12,rax
       mov       rcx,23349800040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115DBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115DB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11243510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115DBAE0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,23347801F70
       mov       rdx,[rdx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L05
M01_L04:
       call      qword ptr [7FFA115D1120]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      qword ptr [7FFA115D9DE0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      qword ptr [7FFA115D1B58]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA11433918]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      qword ptr [7FFA11453750]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [7FFA115D1180]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L06
       movsxd    rcx,ecx
       mov       rdx,141DD76000
       imul      rcx,rdx
       mov       rdx,0CCCCCCCCCCCCCCC
       cmp       rcx,rdx
       jg        near ptr M01_L09
       mov       rdx,0F333333333333334
       cmp       rcx,rdx
       jl        near ptr M01_L09
       lea       rax,[rcx+rcx*4]
       add       rax,rax
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      qword ptr [7FFA11433450]; System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2BCA2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0C000000000000000
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      qword ptr [7FFA11453048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      qword ptr [7FFA115D1AF8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      qword ptr [7FFA115D1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115D1B88]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      qword ptr [7FFA115D1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115D1BB8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFA115D1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115D1C18]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      qword ptr [7FFA115D1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115D1B28]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      qword ptr [7FFA115D1060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFA11000858
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFA11000860
       call      qword ptr [r11]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFA11000868
       call      qword ptr [r11]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L06
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       call      qword ptr [7FFA11431180]
       int       3
M01_L08:
       xor       ecx,ecx
       call      qword ptr [7FFA114311E0]
       int       3
M01_L09:
       call      qword ptr [7FFA11407678]
       int       3
M01_L10:
       mov       ecx,7
       call      qword ptr [7FFA114078E8]
       int       3
; Total bytes of code 1308
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+284]
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 125
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     cl
       movzx     ecx,cl
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A53928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFA618C4928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,278282B2F38
       mov       rdx,[rdx]
       mov       rax,[rsp+48]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L04
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L05
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rdx,346DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L06
       mov       rdx,0FFFCB923A29C779B
       cmp       rcx,rdx
       jl        near ptr M01_L06
       imul      rax,rcx,2710
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2BCA2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0C000000000000000
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFA617C0340
       call      qword ptr [7FFA617C0340]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFA617C0348
       call      qword ptr [7FFA617C0348]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFA617C0350
       call      qword ptr [7FFA617C0350]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L05
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L03
M01_L04:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.SR.get_Overflow_TimeSpanTooLong()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      System.DateTime.ThrowTicksOutOfRange()
       int       3
M01_L08:
       xor       ecx,ecx
       call      System.DateTime.ThrowDateArithmetic(Int32)
       int       3
M01_L09:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
M01_L10:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 1156
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+284]
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      qword ptr [7FFA116011C8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 126
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       mov       ecx,1
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       near ptr M01_L03
       call      qword ptr [7FFA1160BD68]
       mov       r12,rax
       mov       rcx,1A6D0800040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA1160BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11476CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11476CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA1160B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA1160BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA1160D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113DFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11273510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA1160BAE0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFA1160D000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA11405750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,1A6D2801F70
       mov       rdx,[rdx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L05
M01_L04:
       call      qword ptr [7FFA11601120]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      qword ptr [7FFA11609DE0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      qword ptr [7FFA11601B58]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA11463918]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      qword ptr [7FFA11483750]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [7FFA11601180]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L06
       movsxd    rcx,ecx
       mov       rdx,141DD76000
       imul      rcx,rdx
       mov       rdx,0CCCCCCCCCCCCCCC
       cmp       rcx,rdx
       jg        near ptr M01_L09
       mov       rdx,0F333333333333334
       cmp       rcx,rdx
       jl        near ptr M01_L09
       lea       rax,[rcx+rcx*4]
       add       rax,rax
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      qword ptr [7FFA11463450]; System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2BCA2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0C000000000000000
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      qword ptr [7FFA11483048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      qword ptr [7FFA11601AF8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      qword ptr [7FFA11601330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA11601B88]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      qword ptr [7FFA11601210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA11601BB8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFA11601330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA11601C18]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      qword ptr [7FFA11601210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA11601B28]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      qword ptr [7FFA11601060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFA11030858
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFA11030860
       call      qword ptr [r11]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFA11030868
       call      qword ptr [r11]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L06
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       call      qword ptr [7FFA11461180]
       int       3
M01_L08:
       xor       ecx,ecx
       call      qword ptr [7FFA114611E0]
       int       3
M01_L09:
       call      qword ptr [7FFA11437678]
       int       3
M01_L10:
       mov       ecx,7
       call      qword ptr [7FFA114378E8]
       int       3
; Total bytes of code 1308
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+284]
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 125
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     cl
       movzx     ecx,cl
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFA618B4928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,172A1902F38
       mov       rdx,[rdx]
       mov       rax,[rsp+48]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L04
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L05
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rdx,346DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L06
       mov       rdx,0FFFCB923A29C779B
       cmp       rcx,rdx
       jl        near ptr M01_L06
       imul      rax,rcx,2710
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2BCA2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0C000000000000000
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFA617B0340
       call      qword ptr [7FFA617B0340]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFA617B0348
       call      qword ptr [7FFA617B0348]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFA617B0350
       call      qword ptr [7FFA617B0350]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L05
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L03
M01_L04:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.SR.get_Overflow_TimeSpanTooLong()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      System.DateTime.ThrowTicksOutOfRange()
       int       3
M01_L08:
       xor       ecx,ecx
       call      System.DateTime.ThrowDateArithmetic(Int32)
       int       3
M01_L09:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
M01_L10:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 1156
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+284]
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      qword ptr [7FFA115E11C8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 126
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       mov       ecx,1
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       near ptr M01_L03
       call      qword ptr [7FFA115EBD68]
       mov       r12,rax
       mov       rcx,2143A000040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115EBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115EB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11253510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115EBAE0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,2143C001F70
       mov       rdx,[rdx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L05
M01_L04:
       call      qword ptr [7FFA115E1120]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      qword ptr [7FFA115E9DE0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      qword ptr [7FFA115E1B58]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA11443918]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      qword ptr [7FFA11463750]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [7FFA115E1180]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L06
       movsxd    rcx,ecx
       mov       rdx,141DD76000
       imul      rcx,rdx
       mov       rdx,0CCCCCCCCCCCCCCC
       cmp       rcx,rdx
       jg        near ptr M01_L09
       mov       rdx,0F333333333333334
       cmp       rcx,rdx
       jl        near ptr M01_L09
       lea       rax,[rcx+rcx*4]
       add       rax,rax
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      qword ptr [7FFA11443450]; System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2BCA2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0C000000000000000
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      qword ptr [7FFA11463048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      qword ptr [7FFA115E1AF8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115E1B88]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      qword ptr [7FFA115E1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115E1BB8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115E1C18]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      qword ptr [7FFA115E1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115E1B28]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      qword ptr [7FFA115E1060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFA11010858
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFA11010860
       call      qword ptr [r11]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFA11010868
       call      qword ptr [r11]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L06
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       call      qword ptr [7FFA11441180]
       int       3
M01_L08:
       xor       ecx,ecx
       call      qword ptr [7FFA114411E0]
       int       3
M01_L09:
       call      qword ptr [7FFA11417678]
       int       3
M01_L10:
       mov       ecx,7
       call      qword ptr [7FFA114178E8]
       int       3
; Total bytes of code 1308
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+284]
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 125
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     cl
       movzx     ecx,cl
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A33928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFA618A4928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2CAC4A52F38
       mov       rdx,[rdx]
       mov       rax,[rsp+48]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L04
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L05
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rdx,346DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L06
       mov       rdx,0FFFCB923A29C779B
       cmp       rcx,rdx
       jl        near ptr M01_L06
       imul      rax,rcx,2710
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2BCA2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0C000000000000000
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFA617A0340
       call      qword ptr [7FFA617A0340]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFA617A0348
       call      qword ptr [7FFA617A0348]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFA617A0350
       call      qword ptr [7FFA617A0350]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L05
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L03
M01_L04:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.SR.get_Overflow_TimeSpanTooLong()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      System.DateTime.ThrowTicksOutOfRange()
       int       3
M01_L08:
       xor       ecx,ecx
       call      System.DateTime.ThrowDateArithmetic(Int32)
       int       3
M01_L09:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
M01_L10:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 1156
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+284]
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      qword ptr [7FFA115E11C8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 126
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       mov       ecx,1
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       near ptr M01_L03
       call      qword ptr [7FFA115EBD68]
       mov       r12,rax
       mov       rcx,1A4D6C00040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115EBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115EB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11253510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115EBAE0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,1A4DEC01F70
       mov       rdx,[rdx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L05
M01_L04:
       call      qword ptr [7FFA115E1120]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      qword ptr [7FFA115E9DE0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      qword ptr [7FFA115E1B58]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA11443918]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      qword ptr [7FFA11463750]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [7FFA115E1180]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L06
       movsxd    rcx,ecx
       mov       rdx,141DD76000
       imul      rcx,rdx
       mov       rdx,0CCCCCCCCCCCCCCC
       cmp       rcx,rdx
       jg        near ptr M01_L09
       mov       rdx,0F333333333333334
       cmp       rcx,rdx
       jl        near ptr M01_L09
       lea       rax,[rcx+rcx*4]
       add       rax,rax
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      qword ptr [7FFA11443450]; System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2BCA2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0C000000000000000
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      qword ptr [7FFA11463048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      qword ptr [7FFA115E1AF8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115E1B88]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      qword ptr [7FFA115E1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115E1BB8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFA115E1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115E1C18]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      qword ptr [7FFA115E1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115E1B28]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      qword ptr [7FFA115E1060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFA11010858
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFA11010860
       call      qword ptr [r11]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFA11010868
       call      qword ptr [r11]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L06
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       call      qword ptr [7FFA11441180]
       int       3
M01_L08:
       xor       ecx,ecx
       call      qword ptr [7FFA114411E0]
       int       3
M01_L09:
       call      qword ptr [7FFA11417678]
       int       3
M01_L10:
       mov       ecx,7
       call      qword ptr [7FFA114178E8]
       int       3
; Total bytes of code 1308
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+284]
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 125
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     cl
       movzx     ecx,cl
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A33928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFA618A4928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,15157C82F38
       mov       rdx,[rdx]
       mov       rax,[rsp+48]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L04
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L05
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rdx,346DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L06
       mov       rdx,0FFFCB923A29C779B
       cmp       rcx,rdx
       jl        near ptr M01_L06
       imul      rax,rcx,2710
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2BCA2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0C000000000000000
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFA617A0340
       call      qword ptr [7FFA617A0340]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFA617A0348
       call      qword ptr [7FFA617A0348]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFA617A0350
       call      qword ptr [7FFA617A0350]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L05
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L03
M01_L04:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.SR.get_Overflow_TimeSpanTooLong()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      System.DateTime.ThrowTicksOutOfRange()
       int       3
M01_L08:
       xor       ecx,ecx
       call      System.DateTime.ThrowDateArithmetic(Int32)
       int       3
M01_L09:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
M01_L10:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 1156
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+284]
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      qword ptr [7FFA115C11C8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 126
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       mov       ecx,1
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       near ptr M01_L03
       call      qword ptr [7FFA115CBD68]
       mov       r12,rax
       mov       rcx,1F17D000040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115CBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115CB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115CBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA1139FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11233510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115CBAE0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113C5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,1F181001F70
       mov       rdx,[rdx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L05
M01_L04:
       call      qword ptr [7FFA115C1120]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      qword ptr [7FFA115C9DE0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      qword ptr [7FFA115C1B58]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA11423918]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      qword ptr [7FFA11443750]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [7FFA115C1180]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L06
       movsxd    rcx,ecx
       mov       rdx,141DD76000
       imul      rcx,rdx
       mov       rdx,0CCCCCCCCCCCCCCC
       cmp       rcx,rdx
       jg        near ptr M01_L09
       mov       rdx,0F333333333333334
       cmp       rcx,rdx
       jl        near ptr M01_L09
       lea       rax,[rcx+rcx*4]
       add       rax,rax
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      qword ptr [7FFA11423450]; System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2BCA2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0C000000000000000
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      qword ptr [7FFA11443048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      qword ptr [7FFA115C1AF8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      qword ptr [7FFA115C1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115C1B88]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      qword ptr [7FFA115C1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115C1BB8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFA115C1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115C1C18]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      qword ptr [7FFA115C1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115C1B28]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      qword ptr [7FFA115C1060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFA10FF0858
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFA10FF0860
       call      qword ptr [r11]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFA10FF0868
       call      qword ptr [r11]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L06
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       call      qword ptr [7FFA11421180]
       int       3
M01_L08:
       xor       ecx,ecx
       call      qword ptr [7FFA114211E0]
       int       3
M01_L09:
       call      qword ptr [7FFA113F7678]
       int       3
M01_L10:
       mov       ecx,7
       call      qword ptr [7FFA113F78E8]
       int       3
; Total bytes of code 1308
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+284]
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 125
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     cl
       movzx     ecx,cl
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A33928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFA618A4928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1C4DC542F38
       mov       rdx,[rdx]
       mov       rax,[rsp+48]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L04
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L05
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rdx,346DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L06
       mov       rdx,0FFFCB923A29C779B
       cmp       rcx,rdx
       jl        near ptr M01_L06
       imul      rax,rcx,2710
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2BCA2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0C000000000000000
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFA617A0340
       call      qword ptr [7FFA617A0340]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFA617A0348
       call      qword ptr [7FFA617A0348]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFA617A0350
       call      qword ptr [7FFA617A0350]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L05
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L03
M01_L04:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.SR.get_Overflow_TimeSpanTooLong()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      System.DateTime.ThrowTicksOutOfRange()
       int       3
M01_L08:
       xor       ecx,ecx
       call      System.DateTime.ThrowDateArithmetic(Int32)
       int       3
M01_L09:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
M01_L10:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 1156
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+284]
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      qword ptr [7FFA115C11C8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 126
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       mov       ecx,1
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       near ptr M01_L03
       call      qword ptr [7FFA115CBD68]
       mov       r12,rax
       mov       rcx,2570D000040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115CBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115CB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115CBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA1139FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11233510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115CBAE0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113C5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,25715001F70
       mov       rdx,[rdx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L05
M01_L04:
       call      qword ptr [7FFA115C1120]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      qword ptr [7FFA115C9DE0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      qword ptr [7FFA115C1B58]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA11423918]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      qword ptr [7FFA11443750]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [7FFA115C1180]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L06
       movsxd    rcx,ecx
       mov       rdx,141DD76000
       imul      rcx,rdx
       mov       rdx,0CCCCCCCCCCCCCCC
       cmp       rcx,rdx
       jg        near ptr M01_L09
       mov       rdx,0F333333333333334
       cmp       rcx,rdx
       jl        near ptr M01_L09
       lea       rax,[rcx+rcx*4]
       add       rax,rax
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      qword ptr [7FFA11423450]; System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2BCA2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0C000000000000000
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      qword ptr [7FFA11443048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      qword ptr [7FFA115C1AF8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      qword ptr [7FFA115C1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115C1B88]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      qword ptr [7FFA115C1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115C1BB8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFA115C1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115C1C18]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      qword ptr [7FFA115C1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115C1B28]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      qword ptr [7FFA115C1060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFA10FF0858
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFA10FF0860
       call      qword ptr [r11]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFA10FF0868
       call      qword ptr [r11]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L06
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       call      qword ptr [7FFA11421180]
       int       3
M01_L08:
       xor       ecx,ecx
       call      qword ptr [7FFA114211E0]
       int       3
M01_L09:
       call      qword ptr [7FFA113F7678]
       int       3
M01_L10:
       mov       ecx,7
       call      qword ptr [7FFA113F78E8]
       int       3
; Total bytes of code 1308
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+284]
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 125
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     cl
       movzx     ecx,cl
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A53928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFA618C4928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1F5F61A2F38
       mov       rdx,[rdx]
       mov       rax,[rsp+48]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L04
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L05
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rdx,346DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L06
       mov       rdx,0FFFCB923A29C779B
       cmp       rcx,rdx
       jl        near ptr M01_L06
       imul      rax,rcx,2710
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2BCA2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0C000000000000000
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFA617C0340
       call      qword ptr [7FFA617C0340]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFA617C0348
       call      qword ptr [7FFA617C0348]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFA617C0350
       call      qword ptr [7FFA617C0350]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L05
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L03
M01_L04:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.SR.get_Overflow_TimeSpanTooLong()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      System.DateTime.ThrowTicksOutOfRange()
       int       3
M01_L08:
       xor       ecx,ecx
       call      System.DateTime.ThrowDateArithmetic(Int32)
       int       3
M01_L09:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
M01_L10:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 1156
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+284]
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      qword ptr [7FFA115F11C8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 126
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       mov       ecx,1
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       near ptr M01_L03
       call      qword ptr [7FFA115FBD68]
       mov       r12,rax
       mov       rcx,11649408C38
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115FBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115FB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115FBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113CFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11263510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115FBAE0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,11649401F70
       mov       rdx,[rdx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L05
M01_L04:
       call      qword ptr [7FFA115F1120]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      qword ptr [7FFA115F9DE0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      qword ptr [7FFA115F1B58]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA11453918]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      qword ptr [7FFA11473750]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [7FFA115F1180]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L06
       movsxd    rcx,ecx
       mov       rdx,141DD76000
       imul      rcx,rdx
       mov       rdx,0CCCCCCCCCCCCCCC
       cmp       rcx,rdx
       jg        near ptr M01_L09
       mov       rdx,0F333333333333334
       cmp       rcx,rdx
       jl        near ptr M01_L09
       lea       rax,[rcx+rcx*4]
       add       rax,rax
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      qword ptr [7FFA11453450]; System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2BCA2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0C000000000000000
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      qword ptr [7FFA11473048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      qword ptr [7FFA115F1AF8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      qword ptr [7FFA115F1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115F1B88]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      qword ptr [7FFA115F1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115F1BB8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFA115F1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115F1C18]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      qword ptr [7FFA115F1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115F1B28]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      qword ptr [7FFA115F1060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFA11020858
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFA11020860
       call      qword ptr [r11]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFA11020868
       call      qword ptr [r11]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L06
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       call      qword ptr [7FFA11451180]
       int       3
M01_L08:
       xor       ecx,ecx
       call      qword ptr [7FFA114511E0]
       int       3
M01_L09:
       call      qword ptr [7FFA11427678]
       int       3
M01_L10:
       mov       ecx,7
       call      qword ptr [7FFA114278E8]
       int       3
; Total bytes of code 1308
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+284]
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 125
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       cmp       esi,7FFFFFFF
       setle     cl
       movzx     ecx,cl
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rsi,rax
       mov       ecx,119
       mov       rdx,7FFA61A23928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFA61894928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1CBB9692F38
       mov       rdx,[rdx]
       mov       rax,[rsp+48]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L04
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L05
       movsxd    rcx,ecx
       imul      rcx,0E10
       lea       rcx,[rcx+rcx*2]
       shl       rcx,3
       imul      rcx,3E8
       mov       rdx,346DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L06
       mov       rdx,0FFFCB923A29C779B
       cmp       rcx,rdx
       jl        near ptr M01_L06
       imul      rax,rcx,2710
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2BCA2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0C000000000000000
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFA61790340
       call      qword ptr [7FFA61790340]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFA61790348
       call      qword ptr [7FFA61790348]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFA61790350
       call      qword ptr [7FFA61790350]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L05
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L03
M01_L04:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       call      System.SR.get_Overflow_TimeSpanTooLong()
       mov       r8,rax
       mov       rcx,rsi
       xor       edx,edx
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       call      System.DateTime.ThrowTicksOutOfRange()
       int       3
M01_L08:
       xor       ecx,ecx
       call      System.DateTime.ThrowDateArithmetic(Int32)
       int       3
M01_L09:
       call      System.ThrowHelper.ThrowArgumentOutOfRange_TimeSpanTooLong()
       int       3
M01_L10:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 1156
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+284]
       mov       edx,1
       mov       r8d,0F
       mov       r9d,19
       call      qword ptr [7FFA115D11C8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       [rbp-10],rax
       mov       rdx,[rsi+18]
       lea       rcx,[rdx+10]
       mov       rdx,[rbp-10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 126
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,0C8
       vzeroupper
       xor       eax,eax
       mov       [rsp+0B0],rax
       mov       [rsp+0B8],rax
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       mov       r14d,[rsp+130]
       mov       r15d,[rsp+138]
       mov       r12d,[rsp+140]
       mov       r13d,[rsp+148]
       test      esi,esi
       jle       short M01_L00
       mov       ecx,1
       jmp       short M01_L01
M01_L00:
       xor       ecx,ecx
M01_L01:
       test      ecx,ecx
       jne       near ptr M01_L03
       call      qword ptr [7FFA115DBD68]
       mov       r12,rax
       mov       rcx,15E53000040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFA115DBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115DB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFA11243510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115DBAE0]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,15E5B001F70
       mov       rdx,[rdx]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       lea       rcx,[rax+8]
       mov       rdx,[rsp+48]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+60]
       mov       [rsp+70],rax
       xor       edx,edx
       mov       [rsp+0C4],edx
       test      esi,esi
       jle       near ptr M01_L05
M01_L04:
       call      qword ptr [7FFA115D1120]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      qword ptr [7FFA115D9DE0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      qword ptr [7FFA115D1B58]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFA11433918]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      qword ptr [7FFA11453750]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [7FFA115D1180]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
       imul      ecx,eax,16D
       jo        near ptr M01_L06
       movsxd    rcx,ecx
       mov       rdx,141DD76000
       imul      rcx,rdx
       mov       rdx,0CCCCCCCCCCCCCCC
       cmp       rcx,rdx
       jg        near ptr M01_L09
       mov       rdx,0F333333333333334
       cmp       rcx,rdx
       jl        near ptr M01_L09
       lea       rax,[rcx+rcx*4]
       add       rax,rax
       mov       [rsp+88],rax
       mov       rcx,[rsp+0B8]
       mov       edx,[rsp+0B0]
       movsx     rdx,dx
       movsxd    rdx,edx
       imul      rdx,3C
       mov       r8,0D6BF94D5E5
       cmp       rdx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      qword ptr [7FFA11433450]; System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2BCA2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2BCA2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0C000000000000000
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FFFFFF29406B2A1B
       cmp       rcx,r8
       jl        near ptr M01_L09
       imul      r8,rcx,989680
       vxorps    xmm0,xmm0,xmm0
       vmovupd   [rsp+90],xmm0
       lea       rcx,[rsp+90]
       call      qword ptr [7FFA11453048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      qword ptr [7FFA115D1AF8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      qword ptr [7FFA115D1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115D1B88]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      qword ptr [7FFA115D1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115D1BB8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFA115D1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115D1C18]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      qword ptr [7FFA115D1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFA115D1B28]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      qword ptr [7FFA115D1060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFA11000858
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFA11000860
       call      qword ptr [r11]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFA11000868
       call      qword ptr [r11]
       mov       edx,[rsp+0C4]
       add       edx,1
       jo        short M01_L06
       cmp       edx,esi
       mov       [rsp+0C4],edx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,[rsp+70]
       add       rsp,0C8
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       call      qword ptr [7FFA11431180]
       int       3
M01_L08:
       xor       ecx,ecx
       call      qword ptr [7FFA114311E0]
       int       3
M01_L09:
       call      qword ptr [7FFA11407678]
       int       3
M01_L10:
       mov       ecx,7
       call      qword ptr [7FFA114078E8]
       int       3
; Total bytes of code 1308
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,208
       lea       rbp,[rsp+240]
       xor       eax,eax
       mov       [rbp-1F8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       ebx,ecx
       test      ebx,ebx
       jle       short M01_L01
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rbx,rax
       mov       ecx,119
       mov       rdx,7FFA61A33928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFA618A4928
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1CE52E82F58
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L05
M01_L04:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       lea       rcx,[rbp-0A8]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFA617A0480
       call      qword ptr [7FFA617A0480]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFA617A0488
       call      qword ptr [7FFA617A0488]
       mov       r12d,eax
       lea       rdi,[rbp-188]
       lea       rsi,[rbp-118]
       mov       ecx,0E
       rep movsq
       mov       r13,[r14+8]
       lea       rdi,[rbp-1F8]
       lea       rsi,[rbp-188]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp-1F8]
       mov       edx,r12d
       mov       r11,7FFA617A0490
       call      qword ptr [7FFA617A0490]
       add       r15d,1
       jo        short M01_L06
       cmp       r15d,ebx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,r14
       add       rsp,208
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 510
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11637A08]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11885FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,198
       lea       rbp,[rsp+1D0]
       xor       eax,eax
       mov       [rbp-188],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       ebx,ecx
       test      ebx,ebx
       jle       short M01_L01
       mov       eax,1
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA115FBD68]
       mov       r14,rax
       mov       rcx,1DC42400040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115FBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115FB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115FBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113CFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA11263510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115FBAE0]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1DC40401F90
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L06
M01_L05:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       lea       rcx,[rbp-0A8]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115F1690]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFA11020858
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[r14+8]
       mov       r11,7FFA11020860
       call      qword ptr [r11]
       mov       r12d,eax
       mov       r13,[r14+8]
       lea       rdi,[rbp-188]
       lea       rsi,[rbp-118]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp-188]
       mov       edx,r12d
       mov       r11,7FFA11020868
       call      qword ptr [r11]
       add       r15d,1
       jo        short M01_L07
       cmp       r15d,ebx
       jl        near ptr M01_L05
M01_L06:
       mov       rax,r14
       add       rsp,198
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       ecx,7
       call      qword ptr [7FFA114278E8]
       int       3
; Total bytes of code 689
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,208
       lea       rbp,[rsp+240]
       xor       eax,eax
       mov       [rbp-1F8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       ebx,ecx
       test      ebx,ebx
       jle       short M01_L01
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rbx,rax
       mov       ecx,119
       mov       rdx,7FFA61A53928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFA618C4928
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1A852672F58
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L05
M01_L04:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       lea       rcx,[rbp-0A8]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFA617C0480
       call      qword ptr [7FFA617C0480]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFA617C0488
       call      qword ptr [7FFA617C0488]
       mov       r12d,eax
       lea       rdi,[rbp-188]
       lea       rsi,[rbp-118]
       mov       ecx,0E
       rep movsq
       mov       r13,[r14+8]
       lea       rdi,[rbp-1F8]
       lea       rsi,[rbp-188]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp-1F8]
       mov       edx,r12d
       mov       r11,7FFA617C0490
       call      qword ptr [7FFA617C0490]
       add       r15d,1
       jo        short M01_L06
       cmp       r15d,ebx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,r14
       add       rsp,208
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 510
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11617A08]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11859330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,198
       lea       rbp,[rsp+1D0]
       xor       eax,eax
       mov       [rbp-188],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       ebx,ecx
       test      ebx,ebx
       jle       short M01_L01
       mov       eax,1
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA115DBD68]
       mov       r14,rax
       mov       rcx,18F61008C38
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115DBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115DB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA11243510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115DBAE0]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,18F61001F90
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L06
M01_L05:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       lea       rcx,[rbp-0A8]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115D1690]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFA11000858
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[r14+8]
       mov       r11,7FFA11000860
       call      qword ptr [r11]
       mov       r12d,eax
       mov       r13,[r14+8]
       lea       rdi,[rbp-188]
       lea       rsi,[rbp-118]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp-188]
       mov       edx,r12d
       mov       r11,7FFA11000868
       call      qword ptr [r11]
       add       r15d,1
       jo        short M01_L07
       cmp       r15d,ebx
       jl        near ptr M01_L05
M01_L06:
       mov       rax,r14
       add       rsp,198
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       ecx,7
       call      qword ptr [7FFA114078E8]
       int       3
; Total bytes of code 689
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,208
       lea       rbp,[rsp+240]
       xor       eax,eax
       mov       [rbp-1F8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       ebx,ecx
       test      ebx,ebx
       jle       short M01_L01
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rbx,rax
       mov       ecx,119
       mov       rdx,7FFA61A63928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFA618D4928
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,291650B2F58
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L05
M01_L04:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       lea       rcx,[rbp-0A8]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFA617D0480
       call      qword ptr [7FFA617D0480]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFA617D0488
       call      qword ptr [7FFA617D0488]
       mov       r12d,eax
       lea       rdi,[rbp-188]
       lea       rsi,[rbp-118]
       mov       ecx,0E
       rep movsq
       mov       r13,[r14+8]
       lea       rdi,[rbp-1F8]
       lea       rsi,[rbp-188]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp-1F8]
       mov       edx,r12d
       mov       r11,7FFA617D0490
       call      qword ptr [7FFA617D0490]
       add       r15d,1
       jo        short M01_L06
       cmp       r15d,ebx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,r14
       add       rsp,208
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 510
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11617A08]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11865FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,198
       lea       rbp,[rsp+1D0]
       xor       eax,eax
       mov       [rbp-188],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       ebx,ecx
       test      ebx,ebx
       jle       short M01_L01
       mov       eax,1
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA115DBD68]
       mov       r14,rax
       mov       rcx,201AF800040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115DBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115DB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA11243510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115DBAE0]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,201AD801F90
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L06
M01_L05:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       lea       rcx,[rbp-0A8]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115D1690]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFA11000858
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[r14+8]
       mov       r11,7FFA11000860
       call      qword ptr [r11]
       mov       r12d,eax
       mov       r13,[r14+8]
       lea       rdi,[rbp-188]
       lea       rsi,[rbp-118]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp-188]
       mov       edx,r12d
       mov       r11,7FFA11000868
       call      qword ptr [r11]
       add       r15d,1
       jo        short M01_L07
       cmp       r15d,ebx
       jl        near ptr M01_L05
M01_L06:
       mov       rax,r14
       add       rsp,198
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       ecx,7
       call      qword ptr [7FFA114078E8]
       int       3
; Total bytes of code 689
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,208
       lea       rbp,[rsp+240]
       xor       eax,eax
       mov       [rbp-1F8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       ebx,ecx
       test      ebx,ebx
       jle       short M01_L01
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rbx,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFA618B4928
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1BE28EF2F58
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L05
M01_L04:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       lea       rcx,[rbp-0A8]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFA617B0480
       call      qword ptr [7FFA617B0480]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFA617B0488
       call      qword ptr [7FFA617B0488]
       mov       r12d,eax
       lea       rdi,[rbp-188]
       lea       rsi,[rbp-118]
       mov       ecx,0E
       rep movsq
       mov       r13,[r14+8]
       lea       rdi,[rbp-1F8]
       lea       rsi,[rbp-188]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp-1F8]
       mov       edx,r12d
       mov       r11,7FFA617B0490
       call      qword ptr [7FFA617B0490]
       add       r15d,1
       jo        short M01_L06
       cmp       r15d,ebx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,r14
       add       rsp,208
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 510
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11607A08]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11849330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,198
       lea       rbp,[rsp+1D0]
       xor       eax,eax
       mov       [rbp-188],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       ebx,ecx
       test      ebx,ebx
       jle       short M01_L01
       mov       eax,1
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA115CBD68]
       mov       r14,rax
       mov       rcx,1E3AA000040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115CBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115CB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115CBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA1139FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA11233510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115CBAE0]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113C5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1E3A8001F90
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L06
M01_L05:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       lea       rcx,[rbp-0A8]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115C1690]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFA10FF0858
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[r14+8]
       mov       r11,7FFA10FF0860
       call      qword ptr [r11]
       mov       r12d,eax
       mov       r13,[r14+8]
       lea       rdi,[rbp-188]
       lea       rsi,[rbp-118]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp-188]
       mov       edx,r12d
       mov       r11,7FFA10FF0868
       call      qword ptr [r11]
       add       r15d,1
       jo        short M01_L07
       cmp       r15d,ebx
       jl        near ptr M01_L05
M01_L06:
       mov       rax,r14
       add       rsp,198
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       ecx,7
       call      qword ptr [7FFA113F78E8]
       int       3
; Total bytes of code 689
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,208
       lea       rbp,[rsp+240]
       xor       eax,eax
       mov       [rbp-1F8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       ebx,ecx
       test      ebx,ebx
       jle       short M01_L01
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rbx,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFA618B4928
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1DBBC632F58
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L05
M01_L04:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       lea       rcx,[rbp-0A8]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFA617B0480
       call      qword ptr [7FFA617B0480]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFA617B0488
       call      qword ptr [7FFA617B0488]
       mov       r12d,eax
       lea       rdi,[rbp-188]
       lea       rsi,[rbp-118]
       mov       ecx,0E
       rep movsq
       mov       r13,[r14+8]
       lea       rdi,[rbp-1F8]
       lea       rsi,[rbp-188]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp-1F8]
       mov       edx,r12d
       mov       r11,7FFA617B0490
       call      qword ptr [7FFA617B0490]
       add       r15d,1
       jo        short M01_L06
       cmp       r15d,ebx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,r14
       add       rsp,208
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 510
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11607A08]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11847FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,198
       lea       rbp,[rsp+1D0]
       xor       eax,eax
       mov       [rbp-188],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       ebx,ecx
       test      ebx,ebx
       jle       short M01_L01
       mov       eax,1
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA115CBD68]
       mov       r14,rax
       mov       rcx,1AE71800040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115CBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115CB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115CBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA1139FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA11233510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115CBAE0]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113C5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1AE75801F90
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L06
M01_L05:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       lea       rcx,[rbp-0A8]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115C1690]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFA10FF0858
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[r14+8]
       mov       r11,7FFA10FF0860
       call      qword ptr [r11]
       mov       r12d,eax
       mov       r13,[r14+8]
       lea       rdi,[rbp-188]
       lea       rsi,[rbp-118]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp-188]
       mov       edx,r12d
       mov       r11,7FFA10FF0868
       call      qword ptr [r11]
       add       r15d,1
       jo        short M01_L07
       cmp       r15d,ebx
       jl        near ptr M01_L05
M01_L06:
       mov       rax,r14
       add       rsp,198
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       ecx,7
       call      qword ptr [7FFA113F78E8]
       int       3
; Total bytes of code 689
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,208
       lea       rbp,[rsp+240]
       xor       eax,eax
       mov       [rbp-1F8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       ebx,ecx
       test      ebx,ebx
       jle       short M01_L01
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rbx,rax
       mov       ecx,119
       mov       rdx,7FFA61A63928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFA618D4928
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1D20B082F58
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L05
M01_L04:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       lea       rcx,[rbp-0A8]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFA617D0480
       call      qword ptr [7FFA617D0480]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFA617D0488
       call      qword ptr [7FFA617D0488]
       mov       r12d,eax
       lea       rdi,[rbp-188]
       lea       rsi,[rbp-118]
       mov       ecx,0E
       rep movsq
       mov       r13,[r14+8]
       lea       rdi,[rbp-1F8]
       lea       rsi,[rbp-188]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp-1F8]
       mov       edx,r12d
       mov       r11,7FFA617D0490
       call      qword ptr [7FFA617D0490]
       add       r15d,1
       jo        short M01_L06
       cmp       r15d,ebx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,r14
       add       rsp,208
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 510
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11637A08]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11877FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,198
       lea       rbp,[rsp+1D0]
       xor       eax,eax
       mov       [rbp-188],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       ebx,ecx
       test      ebx,ebx
       jle       short M01_L01
       mov       eax,1
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA115FBD68]
       mov       r14,rax
       mov       rcx,217E7800040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115FBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11466CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115FB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115FBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113CFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA11263510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115FBAE0]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115FD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,217DF801F90
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L06
M01_L05:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       lea       rcx,[rbp-0A8]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115F1690]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFA11020858
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[r14+8]
       mov       r11,7FFA11020860
       call      qword ptr [r11]
       mov       r12d,eax
       mov       r13,[r14+8]
       lea       rdi,[rbp-188]
       lea       rsi,[rbp-118]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp-188]
       mov       edx,r12d
       mov       r11,7FFA11020868
       call      qword ptr [r11]
       add       r15d,1
       jo        short M01_L07
       cmp       r15d,ebx
       jl        near ptr M01_L05
M01_L06:
       mov       rax,r14
       add       rsp,198
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       ecx,7
       call      qword ptr [7FFA114278E8]
       int       3
; Total bytes of code 689
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,208
       lea       rbp,[rsp+240]
       xor       eax,eax
       mov       [rbp-1F8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       ebx,ecx
       test      ebx,ebx
       jle       short M01_L01
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rbx,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFA618B4928
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,203497F2F58
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L05
M01_L04:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       lea       rcx,[rbp-0A8]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFA617B0480
       call      qword ptr [7FFA617B0480]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFA617B0488
       call      qword ptr [7FFA617B0488]
       mov       r12d,eax
       lea       rdi,[rbp-188]
       lea       rsi,[rbp-118]
       mov       ecx,0E
       rep movsq
       mov       r13,[r14+8]
       lea       rdi,[rbp-1F8]
       lea       rsi,[rbp-188]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp-1F8]
       mov       edx,r12d
       mov       r11,7FFA617B0490
       call      qword ptr [7FFA617B0490]
       add       r15d,1
       jo        short M01_L06
       cmp       r15d,ebx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,r14
       add       rsp,208
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 510
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11617A08]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11859330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,198
       lea       rbp,[rsp+1D0]
       xor       eax,eax
       mov       [rbp-188],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       ebx,ecx
       test      ebx,ebx
       jle       short M01_L01
       mov       eax,1
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA115DBD68]
       mov       r14,rax
       mov       rcx,2377E000040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115DBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11446CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115DB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115DBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113AFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA11243510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115DBAE0]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115DD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,23786001F90
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L06
M01_L05:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       lea       rcx,[rbp-0A8]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115D1690]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFA11000858
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[r14+8]
       mov       r11,7FFA11000860
       call      qword ptr [r11]
       mov       r12d,eax
       mov       r13,[r14+8]
       lea       rdi,[rbp-188]
       lea       rsi,[rbp-118]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp-188]
       mov       edx,r12d
       mov       r11,7FFA11000868
       call      qword ptr [r11]
       add       r15d,1
       jo        short M01_L07
       cmp       r15d,ebx
       jl        near ptr M01_L05
M01_L06:
       mov       rax,r14
       add       rsp,198
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       ecx,7
       call      qword ptr [7FFA114078E8]
       int       3
; Total bytes of code 689
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,208
       lea       rbp,[rsp+240]
       xor       eax,eax
       mov       [rbp-1F8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       ebx,ecx
       test      ebx,ebx
       jle       short M01_L01
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rbx,rax
       mov       ecx,119
       mov       rdx,7FFA61A53928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFA618C4928
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1B8EAB42F58
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L05
M01_L04:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       lea       rcx,[rbp-0A8]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFA617C0480
       call      qword ptr [7FFA617C0480]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFA617C0488
       call      qword ptr [7FFA617C0488]
       mov       r12d,eax
       lea       rdi,[rbp-188]
       lea       rsi,[rbp-118]
       mov       ecx,0E
       rep movsq
       mov       r13,[r14+8]
       lea       rdi,[rbp-1F8]
       lea       rsi,[rbp-188]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp-1F8]
       mov       edx,r12d
       mov       r11,7FFA617C0490
       call      qword ptr [7FFA617C0490]
       add       r15d,1
       jo        short M01_L06
       cmp       r15d,ebx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,r14
       add       rsp,208
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 510
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11607A08]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11849330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,198
       lea       rbp,[rsp+1D0]
       xor       eax,eax
       mov       [rbp-188],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       ebx,ecx
       test      ebx,ebx
       jle       short M01_L01
       mov       eax,1
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA115CBD68]
       mov       r14,rax
       mov       rcx,28E12C00040
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115CBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11436CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115CB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115CBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA1139FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA11233510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115CBAE0]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115CD000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113C5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,28E0AC01F90
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L06
M01_L05:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       lea       rcx,[rbp-0A8]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115C1690]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFA10FF0858
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[r14+8]
       mov       r11,7FFA10FF0860
       call      qword ptr [r11]
       mov       r12d,eax
       mov       r13,[r14+8]
       lea       rdi,[rbp-188]
       lea       rsi,[rbp-118]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp-188]
       mov       edx,r12d
       mov       r11,7FFA10FF0868
       call      qword ptr [r11]
       add       r15d,1
       jo        short M01_L07
       cmp       r15d,ebx
       jl        near ptr M01_L05
M01_L06:
       mov       rax,r14
       add       rsp,198
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       ecx,7
       call      qword ptr [7FFA113F78E8]
       int       3
; Total bytes of code 689
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,208
       lea       rbp,[rsp+240]
       xor       eax,eax
       mov       [rbp-1F8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       ebx,ecx
       test      ebx,ebx
       jle       short M01_L01
       cmp       ebx,7FFFFFFF
       setle     al
       movzx     eax,al
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rbx,rax
       mov       ecx,119
       mov       rdx,7FFA61A43928
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFA618B4928
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1A67BA52F58
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L05
M01_L04:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       lea       rcx,[rbp-0A8]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFA617B0480
       call      qword ptr [7FFA617B0480]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFA617B0488
       call      qword ptr [7FFA617B0488]
       mov       r12d,eax
       lea       rdi,[rbp-188]
       lea       rsi,[rbp-118]
       mov       ecx,0E
       rep movsq
       mov       r13,[r14+8]
       lea       rdi,[rbp-1F8]
       lea       rsi,[rbp-188]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp-1F8]
       mov       edx,r12d
       mov       r11,7FFA617B0490
       call      qword ptr [7FFA617B0490]
       add       r15d,1
       jo        short M01_L06
       cmp       r15d,ebx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,r14
       add       rsp,208
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 510
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFA11627A08]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA11875FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,198
       lea       rbp,[rsp+1D0]
       xor       eax,eax
       mov       [rbp-188],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-180],xmm4
       vmovdqa   xmmword ptr [rbp-170],xmm4
       mov       rax,0FFFFFFFFFFFFFEE0
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax-40],xmm4
       vmovdqa   xmmword ptr [rbp+rax-30],xmm4
       vmovdqa   xmmword ptr [rbp+rax-20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-40],rax
       mov       ebx,ecx
       test      ebx,ebx
       jle       short M01_L01
       mov       eax,1
       jmp       short M01_L02
M01_L01:
       xor       eax,eax
M01_L02:
       test      eax,eax
       jne       near ptr M01_L04
       call      qword ptr [7FFA115EBD68]
       mov       r14,rax
       mov       rcx,1C7FB808C38
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFA115EBEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFA11456CD8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA115EB438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA115EBAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA113BFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFA11253510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFA115EBAE0]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFA115ED000]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFA113E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1C7FB801F90
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      ebx,ebx
       jle       near ptr M01_L06
M01_L05:
       mov       dword ptr [rsp+20],0F
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],8
       mov       dword ptr [rsp+38],0F
       lea       rcx,[rbp-0A8]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      qword ptr [7FFA115E1690]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, dotNetTips.Spargine.6.Tester]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFA11010858
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[r14+8]
       mov       r11,7FFA11010860
       call      qword ptr [r11]
       mov       r12d,eax
       mov       r13,[r14+8]
       lea       rdi,[rbp-188]
       lea       rsi,[rbp-118]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp-188]
       mov       edx,r12d
       mov       r11,7FFA11010868
       call      qword ptr [r11]
       add       r15d,1
       jo        short M01_L07
       cmp       r15d,ebx
       jl        near ptr M01_L05
M01_L06:
       mov       rax,r14
       add       rsp,198
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       ecx,7
       call      qword ptr [7FFA114178E8]
       int       3
; Total bytes of code 689
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

