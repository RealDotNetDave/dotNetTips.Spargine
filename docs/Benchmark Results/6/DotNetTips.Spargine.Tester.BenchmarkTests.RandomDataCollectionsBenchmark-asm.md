## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       ecx,1
       mov       rdx,7FFB910A4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB91397508]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2EAF5EA0]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EBE9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
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
       call      qword ptr [7FFB2E8FF360]
       mov       rdi,rax
       mov       rcx,14088C00070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E8FF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7371C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7371C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E8FDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E8FF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E8FF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E533510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E8FF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2E8FF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6D5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB2EAF7018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFB2E8BBD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFB2EAF7198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB2EC55848]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB2EAF7060]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       ecx,1
       mov       rdx,7FFB910B4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB913A0528]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2EAF9360]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EBEBFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
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
       call      qword ptr [7FFB2E8FF360]
       mov       rdi,rax
       mov       rcx,2A4CF800070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E8FF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7371C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7371C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E8FDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E8FF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E8FF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E533510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E8FF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2E8FF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6D5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB2EAF93A8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFB2E8BBD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFB2EAF9528]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB2EC55A68]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB2EAF93F0]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       ecx,1
       mov       rdx,7FFB910D4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB913C74E8]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2EB097B0]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EBF9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
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
       call      qword ptr [7FFB2E90F360]
       mov       rdi,rax
       mov       rcx,28C5F800070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E90F498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E90DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E90F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E90F558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E70D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E543510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E90F090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2E90F558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6E5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB2EB097F8]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFB2E8CBD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFB2EB09978]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB2EC65A08]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB2EB09840]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       ecx,1
       mov       rdx,7FFB910D4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB913C74A8]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2D8D9E88]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9CBFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
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
       call      qword ptr [7FFB2D6DF360]
       mov       rdi,rax
       mov       rcx,13DF6408C68
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D6DF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5171C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5171C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D6DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D6DF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D313510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6DF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2D6DF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4B5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB2D8DB018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFB2D69BD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFB2D8DB198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB2DA35FA8]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB2D8DB060]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       ecx,1
       mov       rdx,7FFB910B4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB913A7508]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2D905E88]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9F9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
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
       call      qword ptr [7FFB2D70F360]
       mov       rdi,rax
       mov       rcx,14FA9400070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D70F498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5471C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5471C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D70DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D70F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D70F558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D50D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D343510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D70F090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2D70F558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4E5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB2D907018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFB2D6CBD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFB2D907198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB2DA66008]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB2D907060]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       ecx,1
       mov       rdx,7FFB910A4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB913974C8]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2D905EA0]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9F9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
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
       call      qword ptr [7FFB2D70F360]
       mov       rdi,rax
       mov       rcx,2B0B8808C68
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D70F498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5471C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5471C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D70DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D70F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D70F558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D50D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D343510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D70F090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2D70F558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4E5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB2D907018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFB2D6CBD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFB2D907198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB2DA66008]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB2D907060]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       ecx,1
       mov       rdx,7FFB910D4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB913C74C8]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2D8D5768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9C7FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
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
       call      qword ptr [7FFB2D6DF360]
       mov       rdi,rax
       mov       rcx,211FC808C68
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D6DF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5171C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5171C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D6DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D6DF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D313510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6DF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2D6DF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4B5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB2D8D57B0]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFB2D69BD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFB2D8D5930]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB2DA36048]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB2D8D57F8]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       ecx,1
       mov       rdx,7FFB910B4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB913A12A8]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2E899768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EBC9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
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
       call      qword ptr [7FFB2E8DF360]
       mov       rdi,rax
       mov       rcx,24D46000070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E8DF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7171C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7171C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E8DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E8DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E8DF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E513510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E8DF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2E8DF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6B5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB2EADD228]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFB2E89BD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFB2EADD3A8]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB2EC35748]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB2EADD270]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       ecx,1
       mov       rdx,7FFB910C4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB913B82E8]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2E8C9768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EBFB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
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
       call      qword ptr [7FFB2E90F360]
       mov       rdi,rax
       mov       rcx,21FF0000070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E90F498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E90DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E90F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E90F558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E70D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E543510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E90F090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2E90F558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6E5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB2EB0B228]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFB2E8CBD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFB2EB0B3A8]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB2EC65A48]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB2EB0B270]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       ecx,1
       mov       rdx,7FFB910D4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB913C8308]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2E899768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EBC7FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
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
       call      qword ptr [7FFB2E8DF360]
       mov       rdi,rax
       mov       rcx,221AC000070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E8DF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7171C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7171C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E8DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E8DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E8DF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E513510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E8DF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2E8DF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6B5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB2EAD9228]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFB2E89BD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFB2EAD93A8]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB2EC35AE8]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB2EAD9270]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       ecx,1
       mov       rdx,7FFB910C4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB913B8308]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2D6D9768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2DA0BFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
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
       call      qword ptr [7FFB2D71F360]
       mov       rdi,rax
       mov       rcx,238F2000070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D71F498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5571C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5571C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D71DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D71F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D71F558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D51D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D353510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D71F090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2D71F558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4F5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB2D91F228]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFB2D6DBD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFB2D91F3A8]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB2DA76008]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB2D91F270]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       ecx,1
       mov       rdx,7FFB910D4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB913C8308]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2D6A9768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9DBFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
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
       call      qword ptr [7FFB2D6EF360]
       mov       rdi,rax
       mov       rcx,1347BC00070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D6EF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5271C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5271C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D6EDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6EF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D6EF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D323510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6EF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2D6EF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4C5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB2D8ED018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFB2D6ABD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFB2D8ED198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB2DA46008]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB2D8ED060]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       ecx,1
       mov       rdx,7FFB910A4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB91398308]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2D6B9768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9E9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
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
       call      qword ptr [7FFB2D6FF360]
       mov       rdi,rax
       mov       rcx,2536BC00070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D6FF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5371C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5371C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D6FDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6FF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D6FF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D333510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6FF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2D6FF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4D5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB2D8FD228]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFB2D6BBD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFB2D8FD3A8]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB2DA56128]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB2D8FD270]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       ecx,1
       mov       rdx,7FFB910A4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L06
M01_L03:
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].AddWithResize(DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper)
M01_L05:
       add       ebx,1
       jo        short M01_L08
       cmp       ebx,esi
       jl        short M01_L03
M01_L06:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB91398308]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L07
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]].set_Capacity(Int32)
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2D6A9768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9D9330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
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
       call      qword ptr [7FFB2D6EF360]
       mov       rdi,rax
       mov       rcx,15765C08C68
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D6EF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5271C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5271C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D6EDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6EF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D6EF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D323510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6EF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFB2D6EF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4C5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFB2D8E9228]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFB2D6ABD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFB2D8E93A8]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFB2DA46048]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFB2D8E9270]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       ecx,1
       mov       rdx,7FFB910C4B48
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
       mov       rdx,7FFB91484B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB91484B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB9124CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L09
       cmp       r14d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 230
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFB2E897720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EBC9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       call      qword ptr [7FFB2E8DF360]
       mov       rbx,rax
       mov       rcx,1AF46400888
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E8DF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7171C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7171C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E8DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E8DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E8DF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E513510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E8DF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2E8DF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6B5750]
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
       mov       rdx,7FFB2EAF1D78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2E897A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFB2EAF1DB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FFB2E89BCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2E8B0E78]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 448
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       ecx,1
       mov       rdx,7FFB910A4B48
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
       mov       rdx,7FFB91464B10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB91464B50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB9122CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L09
       cmp       r14d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 230
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFB2E8D7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EC07FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       call      qword ptr [7FFB2E91F360]
       mov       rbx,rax
       mov       rcx,170BF000070
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E91F498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7571C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7571C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E91DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E91F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E91F558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E71D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E553510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E91F090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2E91F558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6F5750]
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
       mov       rdx,7FFB2EB30B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2E8D7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFB2EB30BD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FFB2E8DBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2E8F0E78]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 448
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       ecx,1
       mov       rdx,7FFB910C4B48
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
       mov       rdx,7FFB91484B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB91484B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB9124CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L09
       cmp       r14d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 230
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFB2E8D7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EC09330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       call      qword ptr [7FFB2E91F360]
       mov       rbx,rax
       mov       rcx,263FC800888
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E91F498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7571C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7571C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E91DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E91F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E91F558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E71D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E553510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E91F090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2E91F558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6F5750]
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
       mov       rdx,7FFB2EACFFF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2E8D7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFB2EB303F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FFB2E8DBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2E8F0E78]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 448
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       ecx,1
       mov       rdx,7FFB910C4B48
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
       mov       rdx,7FFB91484BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB91484C08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB9124CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L09
       cmp       r14d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 230
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFB2D6B7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9E7FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       call      qword ptr [7FFB2D6FF360]
       mov       rbx,rax
       mov       rcx,1F822400070
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D6FF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5371C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5371C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D6FDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6FF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D6FF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D333510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D6FF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2D6FF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4D5750]
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
       mov       rdx,7FFB2D8AFFF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D6B7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFB2D9103F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FFB2D6BBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D6D0E78]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 448
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       ecx,1
       mov       rdx,7FFB910A4B48
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
       mov       rdx,7FFB9143FE88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB9143FEC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB9122CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L09
       cmp       r14d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 230
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFB2D6D7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2DA09FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       call      qword ptr [7FFB2D71F360]
       mov       rbx,rax
       mov       rcx,28419808C68
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D71F498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5571C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5571C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D71DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D71F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D71F558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D51D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D353510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D71F090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2D71F558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4F5750]
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
       mov       rdx,7FFB2D934438
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D6D7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFB2D934478
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FFB2D6DBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D6F0E78]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 448
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       ecx,1
       mov       rdx,7FFB910A4B48
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
       mov       rdx,7FFB91463108
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB91463148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB9122CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L09
       cmp       r14d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 230
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFB2D697720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9C9330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       call      qword ptr [7FFB2D6DF360]
       mov       rbx,rax
       mov       rcx,14380008C68
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D6DF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5171C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5171C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D6DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D6DF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D313510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D6DF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2D6DF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4B5750]
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
       mov       rdx,7FFB2D8F09F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D697A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFB2D8F0A30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FFB2D69BCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D6B0E78]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 448
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       ecx,1
       mov       rdx,7FFB910A4B48
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
       mov       rdx,7FFB91464BD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB91464C10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB9122CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L09
       cmp       r14d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 230
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFB2D6A7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9D9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       call      qword ptr [7FFB2D6EF360]
       mov       rbx,rax
       mov       rcx,1A6C8800070
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D6EF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5271C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5271C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D6EDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6EF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D6EF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D323510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D6EF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2D6EF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4C5750]
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
       mov       rdx,7FFB2D901950
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D6A7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFB2D901990
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FFB2D6ABCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D6C0E78]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 448
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       ecx,1
       mov       rdx,7FFB910D4B48
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
       mov       rdx,7FFB91494BF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB91494C38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB9125CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L09
       cmp       r14d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 230
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFB2E897720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EBCBFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       call      qword ptr [7FFB2E8DF360]
       mov       rbx,rax
       mov       rcx,1EF35C00070
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E8DF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7171C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7171C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E8DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E8DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E8DF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E513510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E8DF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2E8DF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6B5750]
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
       mov       rdx,7FFB2EAF3EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2E897A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFB2EAF3EF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FFB2E89BCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2E8B0E78]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 448
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       ecx,1
       mov       rdx,7FFB910D4B48
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
       mov       rdx,7FFB91494B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB91494B98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB9125CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L09
       cmp       r14d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 230
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFB2E8D7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EC0B330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       call      qword ptr [7FFB2E91F360]
       mov       rbx,rax
       mov       rcx,17F2C400070
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E91F498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7571C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7571C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E91DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E91F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E91F558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E71D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E553510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E91F090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2E91F558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6F5750]
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
       mov       rdx,7FFB2EB30DE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2E8D7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFB2EB30E28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FFB2E8DBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2E8F0E78]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 448
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       ecx,1
       mov       rdx,7FFB910B4B48
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
       mov       rdx,7FFB91474BF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB91474C38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB9123CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L09
       cmp       r14d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 230
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFB2E8C7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EBF9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       call      qword ptr [7FFB2E90F360]
       mov       rbx,rax
       mov       rcx,26C65008C68
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E90F498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E90DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E90F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E90F558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E70D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E543510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E90F090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2E90F558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6E5750]
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
       mov       rdx,7FFB2EB22740
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2E8C7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFB2EB22780
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FFB2E8CBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2E8E0E78]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 448
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       ecx,1
       mov       rdx,7FFB91094B48
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
       mov       rdx,7FFB91454B70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB91454BB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB9121CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L09
       cmp       r14d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 230
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFB2D6D7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2DA09FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       call      qword ptr [7FFB2D71F360]
       mov       rbx,rax
       mov       rcx,21B4F800070
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D71F498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5571C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5571C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D71DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D71F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D71F558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D51D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D353510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D71F090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2D71F558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4F5750]
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
       mov       rdx,7FFB2D934438
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D6D7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFB2D934478
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FFB2D6DBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D6F0E78]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 448
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       ecx,1
       mov       rdx,7FFB910B4B48
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
       mov       rdx,7FFB91474BD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB91474C10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB9123CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L09
       cmp       r14d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 230
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFB2D697720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9C9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       call      qword ptr [7FFB2D6DF360]
       mov       rbx,rax
       mov       rcx,185DC800070
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D6DF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5171C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5171C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D6DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D6DF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D313510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D6DF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2D6DF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4B5750]
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
       mov       rdx,7FFB2D8F28F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D697A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFB2D8F2938
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FFB2D69BCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D6B0E78]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 448
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       ecx,1
       mov       rdx,7FFB910A4B48
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
       mov       rdx,7FFB91464BA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB91464BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB9122CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L09
       cmp       r14d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 230
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFB2D6B7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9E9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       call      qword ptr [7FFB2D6FF360]
       mov       rbx,rax
       mov       rcx,2C949800070
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D6FF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5371C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5371C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D6FDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6FF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D6FF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D333510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D6FF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2D6FF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4D5750]
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
       mov       rdx,7FFB2D9138D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D6B7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFB2D913910
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FFB2D6BBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D6D0E78]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 448
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       mov       ecx,1
       mov       rdx,7FFB910C4B48
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
       mov       rdx,7FFB9145F610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L08
M01_L05:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB9145F650
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB9124CA40]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L09
       cmp       r14d,esi
       jl        short M01_L05
M01_L08:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L09:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 230
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFB2D697720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9CBFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 76
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
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
       call      qword ptr [7FFB2D6DF360]
       mov       rbx,rax
       mov       rcx,26622C00070
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D6DF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5171C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5171C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D6DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D6DF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D313510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D6DF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFB2D6DF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4B5750]
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
       mov       rdx,7FFB2D8F5028
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D697A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       xor       r14d,r14d
       test      esi,esi
       jle       short M01_L09
M01_L06:
       mov       rcx,[rbx+18]
       test      rcx,rcx
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rdi
       mov       rdx,7FFB2D8F5068
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FFB2D69BCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D6B0E78]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       add       r14d,1
       jo        short M01_L10
       cmp       r14d,esi
       jl        short M01_L06
M01_L09:
       mov       rax,rbp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L10:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 448
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,270D6133B38
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,270D6133B30
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,270D6133B38
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
       mov       rdx,270F6132F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,1BEEA406F48
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1BEEA406F40
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
       mov       rdx,1BEEA401F50
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
       call      qword ptr [7FFB2D4DB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2D4DB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,2024C057F40
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2024C057F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,2024C057F40
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
       mov       rdx,2024C052F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,1A856006F48
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1A856006F40
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
       mov       rdx,1A856001F50
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
       call      qword ptr [7FFB2D51B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2D51B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,177A9667F40
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,177A9667F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,177A9667F40
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
       mov       rdx,177A9662F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,1610DC06F48
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1610DC06F40
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
       mov       rdx,1610DC01F50
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
       call      qword ptr [7FFB2D50B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2D50B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,14B17127F40
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,14B17127F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,14B17127F40
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
       mov       rdx,14B17122F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,11A46406F48
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,11A46406F40
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
       mov       rdx,11A46401F50
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
       call      qword ptr [7FFB2D4FB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2D4FB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,208096C3B38
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,208096C3B30
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,208096C3B38
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
       mov       rdx,208496C2F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,223FA802B40
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,223FA802B38
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
       mov       rdx,223EE801F50
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
       call      qword ptr [7FFB2D4FB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2D4FB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,1F18AD57F40
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F18AD57F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,1F18AD57F40
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
       mov       rdx,1F18AD52F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,13297406F48
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,13297406F40
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
       mov       rdx,13297401F50
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
       call      qword ptr [7FFB2D4DB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2D4DB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,1E15D813B38
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E15D813B30
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,1E15D813B38
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
       mov       rdx,1E17D812F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,23DE2406F48
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,23DE2406F40
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
       mov       rdx,23DE2401F50
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
       call      qword ptr [7FFB2D51B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2D51B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       edi,[rsi+284]
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 152
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,15125C35FE0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rdx,[rcx+18]
M01_L00:
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dl
       movzx     edx,dl
       test      edx,edx
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdx,rax
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       xor       edx,edx
       mov       [rbx],rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 198
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       test      ebx,ebx
       jle       short M02_L00
       cmp       ebx,64
       setle     al
       movzx     eax,al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M02_L02
       mov       ebx,2
       jmp       short M02_L03
M02_L02:
       test      edx,edx
       jne       short M02_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB910D4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L11
M02_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r8,[rsp+40]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+48]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       rax,[rsp+40]
       test      rdi,rdi
       je        short M02_L05
       mov       r8,rax
       mov       rcx,r8
       mov       rdx,[rdi+18]
       mov       [rsp+38],r8
       jmp       short M02_L06
M02_L05:
       mov       r8,rax
       mov       [rsp+38],r8
       mov       rcx,r8
       mov       rdx,15125C31028
       mov       rdx,[rdx]
M02_L06:
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       rax,[rsp+38]
       test      rbp,rbp
       jne       short M02_L07
       mov       r8,rax
       mov       rcx,r8
       xor       edx,edx
       mov       [rsp+30],r8
       jmp       short M02_L08
M02_L07:
       mov       r8,rax
       mov       [rsp+30],r8
       mov       rcx,r8
       mov       rdx,[rbp+20]
M02_L08:
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       inc       dword ptr [r12+14]
       mov       rcx,[r12+8]
       mov       edx,[r12+10]
       cmp       [rcx+8],edx
       jbe       short M02_L09
       lea       r8d,[rdx+1]
       mov       [r12+10],r8d
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L10
M02_L09:
       mov       rcx,r12
       mov       rdx,[rsp+30]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L10:
       add       r13d,1
       jo        short M02_L12
       cmp       r13d,ebx
       jl        near ptr M02_L04
M02_L11:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r12
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
M02_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 592
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       edi,[rsi+284]
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      qword ptr [7FFB2E897150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      qword ptr [7FFB2E897108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EBCD330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,1A2C3404FE8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rax,[rcx+18]
M01_L00:
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      qword ptr [7FFB2EAD1900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      qword ptr [7FFB2EAD1900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      qword ptr [7FFB2E8997E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFB2E823780]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      qword ptr [7FFB2EAD1900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       xor       edx,edx
       mov       [rbx],rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 195
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       test      ebx,ebx
       jle       short M02_L00
       xor       eax,eax
       cmp       ebx,64
       setle     al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M02_L02
       mov       ebx,2
       jmp       near ptr M02_L04
M02_L02:
       test      edx,edx
       jne       near ptr M02_L04
       call      qword ptr [7FFB2E8DF360]
       mov       r12,rax
       mov       rcx,1A2B7400888
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FFB2E8DF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7171C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7171C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E8DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E8DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E8DF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       edx,3
       call      qword ptr [7FFB2E513510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E8DF090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFB2E8DF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6B5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      qword ptr [7FFB2E587918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L12
M02_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      qword ptr [7FFB2EAD7978]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      qword ptr [7FFB2EAD7780]; System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r8,[rsp+40]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+48]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       call      qword ptr [7FFB2E897528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FFB2EAD7BE8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFB2E897528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FFB2EAD7C18]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       rax,[rsp+40]
       test      rdi,rdi
       je        short M02_L06
       mov       r8,rax
       mov       rcx,r8
       mov       rdx,[rdi+18]
       mov       [rsp+38],r8
       jmp       short M02_L07
M02_L06:
       mov       r8,rax
       mov       [rsp+38],r8
       mov       rcx,r8
       mov       rdx,1A2C3400030
       mov       rdx,[rdx]
M02_L07:
       call      qword ptr [7FFB2EAD7C48]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2EAD7C78]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFB2E897528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2EAD7CA8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FFB2E897390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2EAD7D08]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFB2E897138]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2EAD7D38]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       rax,[rsp+38]
       test      rbp,rbp
       jne       short M02_L08
       mov       r8,rax
       mov       rcx,r8
       xor       edx,edx
       mov       [rsp+30],r8
       jmp       short M02_L09
M02_L08:
       mov       r8,rax
       mov       [rsp+30],r8
       mov       rcx,r8
       mov       rdx,[rbp+20]
M02_L09:
       call      qword ptr [7FFB2EAD7D68]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       inc       dword ptr [r12+14]
       mov       rcx,[r12+8]
       mov       edx,[r12+10]
       cmp       [rcx+8],edx
       jbe       short M02_L10
       lea       r8d,[rdx+1]
       mov       [r12+10],r8d
       movsxd    rdx,edx
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L11
M02_L10:
       mov       rcx,r12
       mov       rdx,[rsp+30]
       call      qword ptr [7FFB2E587A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L11:
       add       r13d,1
       jo        short M02_L13
       cmp       r13d,ebx
       jl        near ptr M02_L05
M02_L12:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r12
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
M02_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 837
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       edi,[rsi+284]
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 152
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,235DEF57FD8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rdx,[rcx+18]
M01_L00:
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dl
       movzx     edx,dl
       test      edx,edx
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdx,rax
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       xor       edx,edx
       mov       [rbx],rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 198
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       test      ebx,ebx
       jle       short M02_L00
       cmp       ebx,64
       setle     al
       movzx     eax,al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M02_L02
       mov       ebx,2
       jmp       short M02_L03
M02_L02:
       test      edx,edx
       jne       short M02_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB910A4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L11
M02_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r8,[rsp+40]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+48]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       rax,[rsp+40]
       test      rdi,rdi
       je        short M02_L05
       mov       r8,rax
       mov       rcx,r8
       mov       rdx,[rdi+18]
       mov       [rsp+38],r8
       jmp       short M02_L06
M02_L05:
       mov       r8,rax
       mov       [rsp+38],r8
       mov       rcx,r8
       mov       rdx,235DEF53020
       mov       rdx,[rdx]
M02_L06:
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       rax,[rsp+38]
       test      rbp,rbp
       jne       short M02_L07
       mov       r8,rax
       mov       rcx,r8
       xor       edx,edx
       mov       [rsp+30],r8
       jmp       short M02_L08
M02_L07:
       mov       r8,rax
       mov       [rsp+30],r8
       mov       rcx,r8
       mov       rdx,[rbp+20]
M02_L08:
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       inc       dword ptr [r12+14]
       mov       rcx,[r12+8]
       mov       edx,[r12+10]
       cmp       [rcx+8],edx
       jbe       short M02_L09
       lea       r8d,[rdx+1]
       mov       [r12+10],r8d
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L10
M02_L09:
       mov       rcx,r12
       mov       rdx,[rsp+30]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L10:
       add       r13d,1
       jo        short M02_L12
       cmp       r13d,ebx
       jl        near ptr M02_L04
M02_L11:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r12
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
M02_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 592
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       edi,[rsi+284]
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      qword ptr [7FFB2E8B7150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      qword ptr [7FFB2E8B7108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EBE9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,1A548806FE0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rax,[rcx+18]
M01_L00:
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      qword ptr [7FFB2EABF4B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      qword ptr [7FFB2EABF4B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      qword ptr [7FFB2E8B97E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFB2E843780]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      qword ptr [7FFB2EABF4B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       xor       edx,edx
       mov       [rbx],rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 195
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       test      ebx,ebx
       jle       short M02_L00
       xor       eax,eax
       cmp       ebx,64
       setle     al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M02_L02
       mov       ebx,2
       jmp       near ptr M02_L04
M02_L02:
       test      edx,edx
       jne       near ptr M02_L04
       call      qword ptr [7FFB2E8FF360]
       mov       r12,rax
       mov       rcx,1A550800070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FFB2E8FF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7371C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7371C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E8FDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E8FF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E8FF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       edx,3
       call      qword ptr [7FFB2E533510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E8FF090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFB2E8FF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      qword ptr [7FFB2E5A7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L12
M02_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      qword ptr [7FFB2EAF5978]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      qword ptr [7FFB2EAF5780]; System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r8,[rsp+40]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+48]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       call      qword ptr [7FFB2E8B7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FFB2EAF5BE8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFB2E8B7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FFB2EAF5C18]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       rax,[rsp+40]
       test      rdi,rdi
       je        short M02_L06
       mov       r8,rax
       mov       rcx,r8
       mov       rdx,[rdi+18]
       mov       [rsp+38],r8
       jmp       short M02_L07
M02_L06:
       mov       r8,rax
       mov       [rsp+38],r8
       mov       rcx,r8
       mov       rdx,1A548802028
       mov       rdx,[rdx]
M02_L07:
       call      qword ptr [7FFB2EAF5C48]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2EAF5C78]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFB2E8B7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2EAF5CA8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FFB2E8B7390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2EAF5D08]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFB2E8B7138]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2EAF5D38]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       rax,[rsp+38]
       test      rbp,rbp
       jne       short M02_L08
       mov       r8,rax
       mov       rcx,r8
       xor       edx,edx
       mov       [rsp+30],r8
       jmp       short M02_L09
M02_L08:
       mov       r8,rax
       mov       [rsp+30],r8
       mov       rcx,r8
       mov       rdx,[rbp+20]
M02_L09:
       call      qword ptr [7FFB2EAF5D68]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       inc       dword ptr [r12+14]
       mov       rcx,[r12+8]
       mov       edx,[r12+10]
       cmp       [rcx+8],edx
       jbe       short M02_L10
       lea       r8d,[rdx+1]
       mov       [r12+10],r8d
       movsxd    rdx,edx
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L11
M02_L10:
       mov       rcx,r12
       mov       rdx,[rsp+30]
       call      qword ptr [7FFB2E5A7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L11:
       add       r13d,1
       jo        short M02_L13
       cmp       r13d,ebx
       jl        near ptr M02_L05
M02_L12:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r12
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
M02_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 837
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       edi,[rsi+284]
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 152
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,24163493BD0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rdx,[rcx+18]
M01_L00:
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dl
       movzx     edx,dl
       test      edx,edx
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdx,rax
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       xor       edx,edx
       mov       [rbx],rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 198
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       test      ebx,ebx
       jle       short M02_L00
       cmp       ebx,64
       setle     al
       movzx     eax,al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M02_L02
       mov       ebx,2
       jmp       short M02_L03
M02_L02:
       test      edx,edx
       jne       short M02_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB910C4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L11
M02_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r8,[rsp+40]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+48]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       rax,[rsp+40]
       test      rdi,rdi
       je        short M02_L05
       mov       r8,rax
       mov       rcx,r8
       mov       rdx,[rdi+18]
       mov       [rsp+38],r8
       jmp       short M02_L06
M02_L05:
       mov       r8,rax
       mov       [rsp+38],r8
       mov       rcx,r8
       mov       rdx,24183493020
       mov       rdx,[rdx]
M02_L06:
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       rax,[rsp+38]
       test      rbp,rbp
       jne       short M02_L07
       mov       r8,rax
       mov       rcx,r8
       xor       edx,edx
       mov       [rsp+30],r8
       jmp       short M02_L08
M02_L07:
       mov       r8,rax
       mov       [rsp+30],r8
       mov       rcx,r8
       mov       rdx,[rbp+20]
M02_L08:
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       inc       dword ptr [r12+14]
       mov       rcx,[r12+8]
       mov       edx,[r12+10]
       cmp       [rcx+8],edx
       jbe       short M02_L09
       lea       r8d,[rdx+1]
       mov       [r12+10],r8d
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L10
M02_L09:
       mov       rcx,r12
       mov       rdx,[rsp+30]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L10:
       add       r13d,1
       jo        short M02_L12
       cmp       r13d,ebx
       jl        near ptr M02_L04
M02_L11:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r12
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
M02_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 592
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       edi,[rsi+284]
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      qword ptr [7FFB2E8B7150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      qword ptr [7FFB2E8B7108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EBE9330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,1DC3C006FE0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rax,[rcx+18]
M01_L00:
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      qword ptr [7FFB2EABF0D8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      qword ptr [7FFB2EABF0D8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      qword ptr [7FFB2E8B97E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFB2E843780]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      qword ptr [7FFB2EABF0D8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       xor       edx,edx
       mov       [rbx],rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 195
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       test      ebx,ebx
       jle       short M02_L00
       xor       eax,eax
       cmp       ebx,64
       setle     al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M02_L02
       mov       ebx,2
       jmp       near ptr M02_L04
M02_L02:
       test      edx,edx
       jne       near ptr M02_L04
       call      qword ptr [7FFB2E8FF360]
       mov       r12,rax
       mov       rcx,1DC3C008C68
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FFB2E8FF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7371C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7371C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E8FDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E8FF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E8FF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       edx,3
       call      qword ptr [7FFB2E533510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E8FF090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFB2E8FF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      qword ptr [7FFB2E5A7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L12
M02_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      qword ptr [7FFB2EAF5240]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      qword ptr [7FFB2EAF5048]; System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r8,[rsp+40]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+48]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       call      qword ptr [7FFB2E8B7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FFB2EAF5498]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFB2E8B7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FFB2EAF54C8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       rax,[rsp+40]
       test      rdi,rdi
       je        short M02_L06
       mov       r8,rax
       mov       rcx,r8
       mov       rdx,[rdi+18]
       mov       [rsp+38],r8
       jmp       short M02_L07
M02_L06:
       mov       r8,rax
       mov       [rsp+38],r8
       mov       rcx,r8
       mov       rdx,1DC3C002028
       mov       rdx,[rdx]
M02_L07:
       call      qword ptr [7FFB2EAF54F8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2EAF5528]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFB2E8B7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2EAF5558]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FFB2E8B7390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2EAF55B8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFB2E8B7138]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2EAF55E8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       rax,[rsp+38]
       test      rbp,rbp
       jne       short M02_L08
       mov       r8,rax
       mov       rcx,r8
       xor       edx,edx
       mov       [rsp+30],r8
       jmp       short M02_L09
M02_L08:
       mov       r8,rax
       mov       [rsp+30],r8
       mov       rcx,r8
       mov       rdx,[rbp+20]
M02_L09:
       call      qword ptr [7FFB2EAF5618]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       inc       dword ptr [r12+14]
       mov       rcx,[r12+8]
       mov       edx,[r12+10]
       cmp       [rcx+8],edx
       jbe       short M02_L10
       lea       r8d,[rdx+1]
       mov       [r12+10],r8d
       movsxd    rdx,edx
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L11
M02_L10:
       mov       rcx,r12
       mov       rdx,[rsp+30]
       call      qword ptr [7FFB2E5A7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L11:
       add       r13d,1
       jo        short M02_L13
       cmp       r13d,ebx
       jl        near ptr M02_L05
M02_L12:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r12
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
M02_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 837
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       edi,[rsi+284]
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 152
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,1DBF0F17FD8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rdx,[rcx+18]
M01_L00:
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dl
       movzx     edx,dl
       test      edx,edx
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdx,rax
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       xor       edx,edx
       mov       [rbx],rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 198
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       test      ebx,ebx
       jle       short M02_L00
       cmp       ebx,64
       setle     al
       movzx     eax,al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M02_L02
       mov       ebx,2
       jmp       short M02_L03
M02_L02:
       test      edx,edx
       jne       short M02_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB910A4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L11
M02_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r8,[rsp+40]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+48]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       rax,[rsp+40]
       test      rdi,rdi
       je        short M02_L05
       mov       r8,rax
       mov       rcx,r8
       mov       rdx,[rdi+18]
       mov       [rsp+38],r8
       jmp       short M02_L06
M02_L05:
       mov       r8,rax
       mov       [rsp+38],r8
       mov       rcx,r8
       mov       rdx,1DBF0F13020
       mov       rdx,[rdx]
M02_L06:
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       rax,[rsp+38]
       test      rbp,rbp
       jne       short M02_L07
       mov       r8,rax
       mov       rcx,r8
       xor       edx,edx
       mov       [rsp+30],r8
       jmp       short M02_L08
M02_L07:
       mov       r8,rax
       mov       [rsp+30],r8
       mov       rcx,r8
       mov       rdx,[rbp+20]
M02_L08:
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       inc       dword ptr [r12+14]
       mov       rcx,[r12+8]
       mov       edx,[r12+10]
       cmp       [rcx+8],edx
       jbe       short M02_L09
       lea       r8d,[rdx+1]
       mov       [r12+10],r8d
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L10
M02_L09:
       mov       rcx,r12
       mov       rdx,[rsp+30]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L10:
       add       r13d,1
       jo        short M02_L12
       cmp       r13d,ebx
       jl        near ptr M02_L04
M02_L11:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r12
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
M02_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 592
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       edi,[rsi+284]
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      qword ptr [7FFB2D6C7150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      qword ptr [7FFB2D6C7108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9FB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,2AE5F406FE0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rax,[rcx+18]
M01_L00:
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      qword ptr [7FFB2D8CF4B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      qword ptr [7FFB2D8CF4B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      qword ptr [7FFB2D6C97E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFB2D653A50]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      qword ptr [7FFB2D8CF4B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       xor       edx,edx
       mov       [rbx],rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 195
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       test      ebx,ebx
       jle       short M02_L00
       xor       eax,eax
       cmp       ebx,64
       setle     al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M02_L02
       mov       ebx,2
       jmp       near ptr M02_L04
M02_L02:
       test      edx,edx
       jne       near ptr M02_L04
       call      qword ptr [7FFB2D70F360]
       mov       r12,rax
       mov       rcx,2AE5D400070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FFB2D70F498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5471C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5471C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D70DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D70F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D70F558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D50D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       edx,3
       call      qword ptr [7FFB2D343510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D70F090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFB2D70F558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      qword ptr [7FFB2D3B7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L12
M02_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      qword ptr [7FFB2D905978]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      qword ptr [7FFB2D905780]; System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r8,[rsp+40]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+48]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       call      qword ptr [7FFB2D6C7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FFB2D905BA0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFB2D6C7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FFB2D905BD0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       rax,[rsp+40]
       test      rdi,rdi
       je        short M02_L06
       mov       r8,rax
       mov       rcx,r8
       mov       rdx,[rdi+18]
       mov       [rsp+38],r8
       jmp       short M02_L07
M02_L06:
       mov       r8,rax
       mov       [rsp+38],r8
       mov       rcx,r8
       mov       rdx,2AE5F402028
       mov       rdx,[rdx]
M02_L07:
       call      qword ptr [7FFB2D905C00]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2D905C30]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFB2D6C7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2D905C60]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FFB2D6C7390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2D905CC0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFB2D6C7138]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2D905CF0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       rax,[rsp+38]
       test      rbp,rbp
       jne       short M02_L08
       mov       r8,rax
       mov       rcx,r8
       xor       edx,edx
       mov       [rsp+30],r8
       jmp       short M02_L09
M02_L08:
       mov       r8,rax
       mov       [rsp+30],r8
       mov       rcx,r8
       mov       rdx,[rbp+20]
M02_L09:
       call      qword ptr [7FFB2D905D20]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       inc       dword ptr [r12+14]
       mov       rcx,[r12+8]
       mov       edx,[r12+10]
       cmp       [rcx+8],edx
       jbe       short M02_L10
       lea       r8d,[rdx+1]
       mov       [r12+10],r8d
       movsxd    rdx,edx
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L11
M02_L10:
       mov       rcx,r12
       mov       rdx,[rsp+30]
       call      qword ptr [7FFB2D3B7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L11:
       add       r13d,1
       jo        short M02_L13
       cmp       r13d,ebx
       jl        near ptr M02_L05
M02_L12:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r12
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
M02_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 837
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       edi,[rsi+284]
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 152
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,22C41E47FD8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rdx,[rcx+18]
M01_L00:
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dl
       movzx     edx,dl
       test      edx,edx
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdx,rax
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       xor       edx,edx
       mov       [rbx],rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 198
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       test      ebx,ebx
       jle       short M02_L00
       cmp       ebx,64
       setle     al
       movzx     eax,al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M02_L02
       mov       ebx,2
       jmp       short M02_L03
M02_L02:
       test      edx,edx
       jne       short M02_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB910C4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L11
M02_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r8,[rsp+40]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+48]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       rax,[rsp+40]
       test      rdi,rdi
       je        short M02_L05
       mov       r8,rax
       mov       rcx,r8
       mov       rdx,[rdi+18]
       mov       [rsp+38],r8
       jmp       short M02_L06
M02_L05:
       mov       r8,rax
       mov       [rsp+38],r8
       mov       rcx,r8
       mov       rdx,22C41E43020
       mov       rdx,[rdx]
M02_L06:
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       rax,[rsp+38]
       test      rbp,rbp
       jne       short M02_L07
       mov       r8,rax
       mov       rcx,r8
       xor       edx,edx
       mov       [rsp+30],r8
       jmp       short M02_L08
M02_L07:
       mov       r8,rax
       mov       [rsp+30],r8
       mov       rcx,r8
       mov       rdx,[rbp+20]
M02_L08:
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       inc       dword ptr [r12+14]
       mov       rcx,[r12+8]
       mov       edx,[r12+10]
       cmp       [rcx+8],edx
       jbe       short M02_L09
       lea       r8d,[rdx+1]
       mov       [r12+10],r8d
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L10
M02_L09:
       mov       rcx,r12
       mov       rdx,[rsp+30]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L10:
       add       r13d,1
       jo        short M02_L12
       cmp       r13d,ebx
       jl        near ptr M02_L04
M02_L11:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r12
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
M02_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 592
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       edi,[rsi+284]
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      qword ptr [7FFB2D6D7150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      qword ptr [7FFB2D6D7108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2DA0B330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,25096806FE0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rax,[rcx+18]
M01_L00:
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      qword ptr [7FFB2D8DF330]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      qword ptr [7FFB2D8DF330]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      qword ptr [7FFB2D6D97E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFB2D663780]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      qword ptr [7FFB2D8DF330]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       xor       edx,edx
       mov       [rbx],rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 195
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       test      ebx,ebx
       jle       short M02_L00
       xor       eax,eax
       cmp       ebx,64
       setle     al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M02_L02
       mov       ebx,2
       jmp       near ptr M02_L04
M02_L02:
       test      edx,edx
       jne       near ptr M02_L04
       call      qword ptr [7FFB2D71F360]
       mov       r12,rax
       mov       rcx,25092800070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FFB2D71F498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5571C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5571C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D71DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D71F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D71F558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D51D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       edx,3
       call      qword ptr [7FFB2D353510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D71F090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFB2D71F558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      qword ptr [7FFB2D3C7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L12
M02_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      qword ptr [7FFB2D915978]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      qword ptr [7FFB2D915780]; System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r8,[rsp+40]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+48]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       call      qword ptr [7FFB2D6D7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FFB2D915BE8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFB2D6D7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FFB2D915C18]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       rax,[rsp+40]
       test      rdi,rdi
       je        short M02_L06
       mov       r8,rax
       mov       rcx,r8
       mov       rdx,[rdi+18]
       mov       [rsp+38],r8
       jmp       short M02_L07
M02_L06:
       mov       r8,rax
       mov       [rsp+38],r8
       mov       rcx,r8
       mov       rdx,25096802028
       mov       rdx,[rdx]
M02_L07:
       call      qword ptr [7FFB2D915C48]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2D915C78]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFB2D6D7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2D915CA8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FFB2D6D7390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2D915D08]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFB2D6D7138]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2D915D38]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       rax,[rsp+38]
       test      rbp,rbp
       jne       short M02_L08
       mov       r8,rax
       mov       rcx,r8
       xor       edx,edx
       mov       [rsp+30],r8
       jmp       short M02_L09
M02_L08:
       mov       r8,rax
       mov       [rsp+30],r8
       mov       rcx,r8
       mov       rdx,[rbp+20]
M02_L09:
       call      qword ptr [7FFB2D915D68]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       inc       dword ptr [r12+14]
       mov       rcx,[r12+8]
       mov       edx,[r12+10]
       cmp       [rcx+8],edx
       jbe       short M02_L10
       lea       r8d,[rdx+1]
       mov       [r12+10],r8d
       movsxd    rdx,edx
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L11
M02_L10:
       mov       rcx,r12
       mov       rdx,[rsp+30]
       call      qword ptr [7FFB2D3C7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L11:
       add       r13d,1
       jo        short M02_L13
       cmp       r13d,ebx
       jl        near ptr M02_L05
M02_L12:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r12
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
M02_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 837
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       edi,[rsi+284]
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 152
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,256643E7FD8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rdx,[rcx+18]
M01_L00:
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dl
       movzx     edx,dl
       test      edx,edx
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdx,rax
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       xor       edx,edx
       mov       [rbx],rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 198
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       test      ebx,ebx
       jle       short M02_L00
       cmp       ebx,64
       setle     al
       movzx     eax,al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M02_L02
       mov       ebx,2
       jmp       short M02_L03
M02_L02:
       test      edx,edx
       jne       short M02_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB910A4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L11
M02_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r8,[rsp+40]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+48]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       rax,[rsp+40]
       test      rdi,rdi
       je        short M02_L05
       mov       r8,rax
       mov       rcx,r8
       mov       rdx,[rdi+18]
       mov       [rsp+38],r8
       jmp       short M02_L06
M02_L05:
       mov       r8,rax
       mov       [rsp+38],r8
       mov       rcx,r8
       mov       rdx,256643E3020
       mov       rdx,[rdx]
M02_L06:
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       rax,[rsp+38]
       test      rbp,rbp
       jne       short M02_L07
       mov       r8,rax
       mov       rcx,r8
       xor       edx,edx
       mov       [rsp+30],r8
       jmp       short M02_L08
M02_L07:
       mov       r8,rax
       mov       [rsp+30],r8
       mov       rcx,r8
       mov       rdx,[rbp+20]
M02_L08:
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       inc       dword ptr [r12+14]
       mov       rcx,[r12+8]
       mov       edx,[r12+10]
       cmp       [rcx+8],edx
       jbe       short M02_L09
       lea       r8d,[rdx+1]
       mov       [r12+10],r8d
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L10
M02_L09:
       mov       rcx,r12
       mov       rdx,[rsp+30]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L10:
       add       r13d,1
       jo        short M02_L12
       cmp       r13d,ebx
       jl        near ptr M02_L04
M02_L11:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r12
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
M02_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 592
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       edi,[rsi+284]
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      qword ptr [7FFB2D6D7150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      qword ptr [7FFB2D6D7108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2DA07FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,1ABEA806FE0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rax,[rcx+18]
M01_L00:
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      qword ptr [7FFB2D8DF0D8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      qword ptr [7FFB2D8DF0D8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      qword ptr [7FFB2D6D97E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFB2D663780]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      qword ptr [7FFB2D8DF0D8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       xor       edx,edx
       mov       [rbx],rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 195
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       test      ebx,ebx
       jle       short M02_L00
       xor       eax,eax
       cmp       ebx,64
       setle     al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M02_L02
       mov       ebx,2
       jmp       near ptr M02_L04
M02_L02:
       test      edx,edx
       jne       near ptr M02_L04
       call      qword ptr [7FFB2D71F360]
       mov       r12,rax
       mov       rcx,1ABF2800070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FFB2D71F498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5571C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5571C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D71DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D71F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D71F558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D51D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       edx,3
       call      qword ptr [7FFB2D353510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D71F090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFB2D71F558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      qword ptr [7FFB2D3C7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L12
M02_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      qword ptr [7FFB2D915240]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      qword ptr [7FFB2D915048]; System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r8,[rsp+40]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+48]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       call      qword ptr [7FFB2D6D7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FFB2D9154B0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFB2D6D7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FFB2D9154E0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       rax,[rsp+40]
       test      rdi,rdi
       je        short M02_L06
       mov       r8,rax
       mov       rcx,r8
       mov       rdx,[rdi+18]
       mov       [rsp+38],r8
       jmp       short M02_L07
M02_L06:
       mov       r8,rax
       mov       [rsp+38],r8
       mov       rcx,r8
       mov       rdx,1ABEA802028
       mov       rdx,[rdx]
M02_L07:
       call      qword ptr [7FFB2D915510]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2D915540]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFB2D6D7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2D915570]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FFB2D6D7390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2D9155D0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFB2D6D7138]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2D915600]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       rax,[rsp+38]
       test      rbp,rbp
       jne       short M02_L08
       mov       r8,rax
       mov       rcx,r8
       xor       edx,edx
       mov       [rsp+30],r8
       jmp       short M02_L09
M02_L08:
       mov       r8,rax
       mov       [rsp+30],r8
       mov       rcx,r8
       mov       rdx,[rbp+20]
M02_L09:
       call      qword ptr [7FFB2D915630]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       inc       dword ptr [r12+14]
       mov       rcx,[r12+8]
       mov       edx,[r12+10]
       cmp       [rcx+8],edx
       jbe       short M02_L10
       lea       r8d,[rdx+1]
       mov       [r12+10],r8d
       movsxd    rdx,edx
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L11
M02_L10:
       mov       rcx,r12
       mov       rdx,[rsp+30]
       call      qword ptr [7FFB2D3C7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L11:
       add       r13d,1
       jo        short M02_L13
       cmp       r13d,ebx
       jl        near ptr M02_L05
M02_L12:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r12
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
M02_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 837
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       edi,[rsi+284]
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 152
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,19738CD7FD8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rdx,[rcx+18]
M01_L00:
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dl
       movzx     edx,dl
       test      edx,edx
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       call      System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       mov       rdx,rax
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       xor       edx,edx
       mov       [rbx],rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 198
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       test      ebx,ebx
       jle       short M02_L00
       cmp       ebx,64
       setle     al
       movzx     eax,al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M02_L02
       mov       ebx,2
       jmp       short M02_L03
M02_L02:
       test      edx,edx
       jne       short M02_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorNumberIsInvalidBasedOnTheMinMaxValue()
       mov       rbx,rax
       mov       ecx,1
       mov       rdx,7FFB910C4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L11
M02_L04:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r8,[rsp+40]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+48]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       rax,[rsp+40]
       test      rdi,rdi
       je        short M02_L05
       mov       r8,rax
       mov       rcx,r8
       mov       rdx,[rdi+18]
       mov       [rsp+38],r8
       jmp       short M02_L06
M02_L05:
       mov       r8,rax
       mov       [rsp+38],r8
       mov       rcx,r8
       mov       rdx,19738CD3020
       mov       rdx,[rdx]
M02_L06:
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       rax,[rsp+38]
       test      rbp,rbp
       jne       short M02_L07
       mov       r8,rax
       mov       rcx,r8
       xor       edx,edx
       mov       [rsp+30],r8
       jmp       short M02_L08
M02_L07:
       mov       r8,rax
       mov       [rsp+30],r8
       mov       rcx,r8
       mov       rdx,[rbp+20]
M02_L08:
       call      DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       inc       dword ptr [r12+14]
       mov       rcx,[r12+8]
       mov       edx,[r12+10]
       cmp       [rcx+8],edx
       jbe       short M02_L09
       lea       r8d,[rdx+1]
       mov       [r12+10],r8d
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L10
M02_L09:
       mov       rcx,r12
       mov       rdx,[rsp+30]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L10:
       add       r13d,1
       jo        short M02_L12
       cmp       r13d,ebx
       jl        near ptr M02_L04
M02_L11:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r12
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
M02_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 592
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rdi
       push      rsi
       sub       rsp,58
       xor       eax,eax
       mov       [rsp+38],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       edi,[rsi+284]
       lea       rcx,[rsp+50]
       lea       rdx,[rsp+48]
       lea       r8,[rsp+40]
       call      qword ptr [7FFB2D6A7150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      qword ptr [7FFB2D6A7108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9DBFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,58
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 155
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       mov       rcx,21927806FE0
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rax,[rcx+18]
M01_L00:
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      qword ptr [7FFB2D8E3780]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      qword ptr [7FFB2D8E3780]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      qword ptr [7FFB2D6A97E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FFB2D633A50]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      qword ptr [7FFB2D8E3780]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L03:
       xor       edx,edx
       mov       [rbx],rdx
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 195
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       mov       rsi,rcx
       mov       rbp,rdx
       mov       rdi,r8
       mov       ebx,r9d
       mov       r14d,[rsp+0B0]
       mov       r15d,[rsp+0B8]
       test      ebx,ebx
       jle       short M02_L00
       xor       eax,eax
       cmp       ebx,64
       setle     al
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       mov       edx,eax
       test      eax,eax
       jne       short M02_L02
       mov       ebx,2
       jmp       near ptr M02_L04
M02_L02:
       test      edx,edx
       jne       near ptr M02_L04
       call      qword ptr [7FFB2D6EF360]
       mov       r12,rax
       mov       rcx,21923800070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FFB2D6EF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5271C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5271C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D6EDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6EF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D6EF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       edx,3
       call      qword ptr [7FFB2D323510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D6EF090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFB2D6EF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4C5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      qword ptr [7FFB2D397918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L12
M02_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      qword ptr [7FFB2D8E9978]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      qword ptr [7FFB2D8E9780]; System.Globalization.RegionInfo.get_CurrentRegion()
       mov       rcx,rax
       mov       rax,[rax]
       mov       rax,[rax+48]
       call      qword ptr [rax+8]
       mov       r8,[rsp+40]
       lea       rcx,[r8+20]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+40]
       lea       rcx,[rax+48]
       mov       rdx,[rsp+28]
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,r14d
       call      qword ptr [7FFB2D6A7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FFB2D8E9BB8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFB2D6A7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FFB2D8E9BE8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       rax,[rsp+40]
       test      rdi,rdi
       je        short M02_L06
       mov       r8,rax
       mov       rcx,r8
       mov       rdx,[rdi+18]
       mov       [rsp+38],r8
       jmp       short M02_L07
M02_L06:
       mov       r8,rax
       mov       [rsp+38],r8
       mov       rcx,r8
       mov       rdx,21927802028
       mov       rdx,[rdx]
M02_L07:
       call      qword ptr [7FFB2D8E9C18]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2D8E9C48]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFB2D6A7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2D8E9C78]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FFB2D6A7390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2D8E9CD8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FFB2D6A7138]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFB2D8E9D08]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       rax,[rsp+38]
       test      rbp,rbp
       jne       short M02_L08
       mov       r8,rax
       mov       rcx,r8
       xor       edx,edx
       mov       [rsp+30],r8
       jmp       short M02_L09
M02_L08:
       mov       r8,rax
       mov       [rsp+30],r8
       mov       rcx,r8
       mov       rdx,[rbp+20]
M02_L09:
       call      qword ptr [7FFB2D8E9D38]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
       inc       dword ptr [r12+14]
       mov       rcx,[r12+8]
       mov       edx,[r12+10]
       cmp       [rcx+8],edx
       jbe       short M02_L10
       lea       r8d,[rdx+1]
       mov       [r12+10],r8d
       movsxd    rdx,edx
       mov       r8,[rsp+30]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M02_L11
M02_L10:
       mov       rcx,r12
       mov       rdx,[rsp+30]
       call      qword ptr [7FFB2D397A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M02_L11:
       add       r13d,1
       jo        short M02_L13
       cmp       r13d,ebx
       jl        near ptr M02_L05
M02_L12:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r12
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
M02_L13:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 837
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
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
       mov       ecx,1
       mov       rdx,7FFB910A4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,7FFB90F14938
       mov       edx,47
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,28A208F9278
       mov       rdx,[rdx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L04
M01_L03:
       mov       ecx,edi
       mov       edx,ebx
       mov       r8d,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FFB90E10688
       call      qword ptr [7FFB90E10688]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,[r14+8]
       mov       r11,7FFB90E10690
       call      qword ptr [7FFB90E10690]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FFB90E10698
       call      qword ptr [7FFB90E10698]
       add       r15d,1
       jo        short M01_L05
       cmp       r15d,esi
       jl        short M01_L03
M01_L04:
       mov       rax,r14
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 314
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFB2E8B73C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EBE9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFB2E8FF360]
       mov       r14,rax
       mov       rcx,29424400070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E8FF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7371C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7371C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E8FDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E8FF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E8FF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E533510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E8FF090]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFB2E8FF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,2942C407F90
       mov       rdx,[rdx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L05
M01_L04:
       mov       ecx,edi
       mov       edx,ebx
       mov       r8d,ebp
       call      qword ptr [7FFB2E8B73A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FFB2E2F0AF0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFB2E2F0AF8
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FFB2E2F0B00
       call      qword ptr [r11]
       add       r15d,1
       jo        short M01_L06
       cmp       r15d,esi
       jl        short M01_L04
M01_L05:
       mov       rax,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFB2E6F78E8]
       int       3
; Total bytes of code 503
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
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
       mov       ecx,1
       mov       rdx,7FFB910B4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,7FFB90F24938
       mov       edx,47
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1D92F839278
       mov       rdx,[rdx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L04
M01_L03:
       mov       ecx,edi
       mov       edx,ebx
       mov       r8d,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FFB90E20688
       call      qword ptr [7FFB90E20688]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,[r14+8]
       mov       r11,7FFB90E20690
       call      qword ptr [7FFB90E20690]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FFB90E20698
       call      qword ptr [7FFB90E20698]
       add       r15d,1
       jo        short M01_L05
       cmp       r15d,esi
       jl        short M01_L03
M01_L04:
       mov       rax,r14
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 314
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFB2E8B73C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EBEBFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFB2E8FF360]
       mov       r14,rax
       mov       rcx,146F5C04478
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E8FF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7371C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7371C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E8FDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E8FF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E8FF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E533510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E8FF090]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFB2E8FF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,146F1C03B88
       mov       rdx,[rdx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L05
M01_L04:
       mov       ecx,edi
       mov       edx,ebx
       mov       r8d,ebp
       call      qword ptr [7FFB2E8B73A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FFB2E2F0AF8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFB2E2F0B00
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FFB2E2F0B08
       call      qword ptr [r11]
       add       r15d,1
       jo        short M01_L06
       cmp       r15d,esi
       jl        short M01_L04
M01_L05:
       mov       rax,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFB2E6F78E8]
       int       3
; Total bytes of code 503
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
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
       mov       ecx,1
       mov       rdx,7FFB910C4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,7FFB90F34938
       mov       edx,47
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,17378219278
       mov       rdx,[rdx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L04
M01_L03:
       mov       ecx,edi
       mov       edx,ebx
       mov       r8d,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FFB90E30688
       call      qword ptr [7FFB90E30688]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,[r14+8]
       mov       r11,7FFB90E30690
       call      qword ptr [7FFB90E30690]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FFB90E30698
       call      qword ptr [7FFB90E30698]
       add       r15d,1
       jo        short M01_L05
       cmp       r15d,esi
       jl        short M01_L03
M01_L04:
       mov       rax,r14
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 314
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFB2E8B73C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EBE9330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFB2E8FF360]
       mov       r14,rax
       mov       rcx,20FB3008450
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2E8FF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7371C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7371C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E8FDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E8FF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E8FF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E6FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2E533510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E8FF090]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFB2E8FF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,20FB3007F90
       mov       rdx,[rdx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L05
M01_L04:
       mov       ecx,edi
       mov       edx,ebx
       mov       r8d,ebp
       call      qword ptr [7FFB2E8B73A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FFB2E2F0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFB2E2F0AA0
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FFB2E2F0AA8
       call      qword ptr [r11]
       add       r15d,1
       jo        short M01_L06
       cmp       r15d,esi
       jl        short M01_L04
M01_L05:
       mov       rax,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFB2E6F78E8]
       int       3
; Total bytes of code 503
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
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
       mov       ecx,1
       mov       rdx,7FFB910C4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,7FFB90F34938
       mov       edx,47
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,13846F79278
       mov       rdx,[rdx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L04
M01_L03:
       mov       ecx,edi
       mov       edx,ebx
       mov       r8d,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FFB90E30688
       call      qword ptr [7FFB90E30688]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,[r14+8]
       mov       r11,7FFB90E30690
       call      qword ptr [7FFB90E30690]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FFB90E30698
       call      qword ptr [7FFB90E30698]
       add       r15d,1
       jo        short M01_L05
       cmp       r15d,esi
       jl        short M01_L03
M01_L04:
       mov       rax,r14
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 314
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFB2D6C73C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9FD330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFB2D70F360]
       mov       r14,rax
       mov       rcx,27FA6C00070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D70F498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5471C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5471C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D70DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D70F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D70F558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D50D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D343510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D70F090]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFB2D70F558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,27FA4C07F90
       mov       rdx,[rdx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L05
M01_L04:
       mov       ecx,edi
       mov       edx,ebx
       mov       r8d,ebp
       call      qword ptr [7FFB2D6C73A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FFB2D100A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFB2D100AA0
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FFB2D100AA8
       call      qword ptr [r11]
       add       r15d,1
       jo        short M01_L06
       cmp       r15d,esi
       jl        short M01_L04
M01_L05:
       mov       rax,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFB2D5078E8]
       int       3
; Total bytes of code 503
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
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
       mov       ecx,1
       mov       rdx,7FFB910C4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,7FFB90F34938
       mov       edx,47
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,17680F79278
       mov       rdx,[rdx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L04
M01_L03:
       mov       ecx,edi
       mov       edx,ebx
       mov       r8d,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FFB90E30688
       call      qword ptr [7FFB90E30688]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,[r14+8]
       mov       r11,7FFB90E30690
       call      qword ptr [7FFB90E30690]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FFB90E30698
       call      qword ptr [7FFB90E30698]
       add       r15d,1
       jo        short M01_L05
       cmp       r15d,esi
       jl        short M01_L03
M01_L04:
       mov       rax,r14
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 314
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFB2D6B73C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9E9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFB2D6FF360]
       mov       r14,rax
       mov       rcx,16B95800070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D6FF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5371C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5371C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D6FDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6FF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D6FF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D333510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D6FF090]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFB2D6FF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,16B91807F90
       mov       rdx,[rdx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L05
M01_L04:
       mov       ecx,edi
       mov       edx,ebx
       mov       r8d,ebp
       call      qword ptr [7FFB2D6B73A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FFB2D0F0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFB2D0F0AA0
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FFB2D0F0AA8
       call      qword ptr [r11]
       add       r15d,1
       jo        short M01_L06
       cmp       r15d,esi
       jl        short M01_L04
M01_L05:
       mov       rax,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFB2D4F78E8]
       int       3
; Total bytes of code 503
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
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
       mov       ecx,1
       mov       rdx,7FFB910B4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,7FFB90F24938
       mov       edx,47
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,14E44639278
       mov       rdx,[rdx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L04
M01_L03:
       mov       ecx,edi
       mov       edx,ebx
       mov       r8d,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FFB90E20688
       call      qword ptr [7FFB90E20688]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,[r14+8]
       mov       r11,7FFB90E20690
       call      qword ptr [7FFB90E20690]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FFB90E20698
       call      qword ptr [7FFB90E20698]
       add       r15d,1
       jo        short M01_L05
       cmp       r15d,esi
       jl        short M01_L03
M01_L04:
       mov       rax,r14
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 314
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFB2D6B73C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9E9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFB2D6FF360]
       mov       r14,rax
       mov       rcx,1784F800070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D6FF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5371C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5371C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D6FDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6FF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D6FF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D333510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D6FF090]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFB2D6FF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,17857807F90
       mov       rdx,[rdx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L05
M01_L04:
       mov       ecx,edi
       mov       edx,ebx
       mov       r8d,ebp
       call      qword ptr [7FFB2D6B73A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FFB2D0F0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFB2D0F0AA0
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FFB2D0F0AA8
       call      qword ptr [r11]
       add       r15d,1
       jo        short M01_L06
       cmp       r15d,esi
       jl        short M01_L04
M01_L05:
       mov       rax,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFB2D4F78E8]
       int       3
; Total bytes of code 503
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
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
       mov       ecx,1
       mov       rdx,7FFB91094B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rcx,7FFB90F04938
       mov       edx,47
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,20D7AA09278
       mov       rdx,[rdx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L04
M01_L03:
       mov       ecx,edi
       mov       edx,ebx
       mov       r8d,ebp
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FFB90E00688
       call      qword ptr [7FFB90E00688]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,[r14+8]
       mov       r11,7FFB90E00690
       call      qword ptr [7FFB90E00690]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FFB90E00698
       call      qword ptr [7FFB90E00698]
       add       r15d,1
       jo        short M01_L05
       cmp       r15d,esi
       jl        short M01_L03
M01_L04:
       mov       rax,r14
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L05:
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 314
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFB2D6B73C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9E9330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       esi,ecx
       mov       edi,edx
       mov       ebx,r8d
       mov       ebp,r9d
       test      esi,esi
       jle       short M01_L00
       mov       eax,1
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFB2D6FF360]
       mov       r14,rax
       mov       rcx,2431F000070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFB2D6FF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5371C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5371C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D6FDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6FF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D6FF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFB2D333510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D6FF090]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFB2D6FF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,24323007F90
       mov       rdx,[rdx]
       lea       rcx,[r15+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[r14+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       r15d,r15d
       test      esi,esi
       jle       short M01_L05
M01_L04:
       mov       ecx,edi
       mov       edx,ebx
       mov       r8d,ebp
       call      qword ptr [7FFB2D6B73A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FFB2D0F0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFB2D0F0AA0
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FFB2D0F0AA8
       call      qword ptr [r11]
       add       r15d,1
       jo        short M01_L06
       cmp       r15d,esi
       jl        short M01_L04
M01_L05:
       mov       rax,r14
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,7
       call      qword ptr [7FFB2D4F78E8]
       int       3
; Total bytes of code 503
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1E0
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+1E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+200],xmm4
       add       rax,30
       jne       short M01_L00
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
       mov       ecx,1
       mov       rdx,7FFB910D4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB90F44938
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2E815059270
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L05
M01_L04:
       lea       rcx,[rsp+170]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+100]
       lea       rsi,[rsp+170]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FFB90E40628
       call      qword ptr [7FFB90E40628]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+8]
       mov       r11,7FFB90E40630
       call      qword ptr [7FFB90E40630]
       mov       r15d,eax
       lea       rdi,[rsp+90]
       lea       rsi,[rsp+100]
       mov       ecx,0E
       rep movsq
       mov       r12,[rbp+8]
       lea       rdi,[rsp+20]
       lea       rsi,[rsp+90]
       mov       ecx,0E
       rep movsq
       mov       rcx,r12
       lea       r8,[rsp+20]
       mov       edx,r15d
       mov       r11,7FFB90E40638
       call      qword ptr [7FFB90E40638]
       add       r14d,1
       jo        short M01_L06
       cmp       r14d,ebx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,rbp
       add       rsp,1E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 458
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2EB09BE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EBF7FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,180
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+180],xmm4
       vmovdqa   xmmword ptr [rsp+rax+190],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1A0],xmm4
       add       rax,30
       jne       short M01_L00
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
       call      qword ptr [7FFB2E90F360]
       mov       rbp,rax
       mov       rcx,1C3BAC08C68
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFB2E90F498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E90DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E90F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E90F558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E70D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFB2E543510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E90F090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2E90F558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1C3BAC07F88
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L06
M01_L05:
       lea       rcx,[rsp+110]
       mov       edx,19
       call      qword ptr [7FFB2E8CBD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FFB2E300AF0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[rbp+8]
       mov       r11,7FFB2E300AF8
       call      qword ptr [r11]
       mov       r15d,eax
       mov       r12,[rbp+8]
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,r12
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       r11,7FFB2E300B00
       call      qword ptr [r11]
       add       r14d,1
       jo        short M01_L07
       cmp       r14d,ebx
       jl        near ptr M01_L05
M01_L06:
       mov       rax,rbp
       add       rsp,180
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       ecx,7
       call      qword ptr [7FFB2E7078E8]
       int       3
; Total bytes of code 613
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1E0
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+1E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+200],xmm4
       add       rax,30
       jne       short M01_L00
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
       mov       ecx,1
       mov       rdx,7FFB910C4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB90F34938
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,19DDFE99270
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L05
M01_L04:
       lea       rcx,[rsp+170]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+100]
       lea       rsi,[rsp+170]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FFB90E30628
       call      qword ptr [7FFB90E30628]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+8]
       mov       r11,7FFB90E30630
       call      qword ptr [7FFB90E30630]
       mov       r15d,eax
       lea       rdi,[rsp+90]
       lea       rsi,[rsp+100]
       mov       ecx,0E
       rep movsq
       mov       r12,[rbp+8]
       lea       rdi,[rsp+20]
       lea       rsi,[rsp+90]
       mov       ecx,0E
       rep movsq
       mov       rcx,r12
       lea       r8,[rsp+20]
       mov       edx,r15d
       mov       r11,7FFB90E30638
       call      qword ptr [7FFB90E30638]
       add       r14d,1
       jo        short M01_L06
       cmp       r14d,ebx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,rbp
       add       rsp,1E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 458
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2EB1BBE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EC09FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,180
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+180],xmm4
       vmovdqa   xmmword ptr [rsp+rax+190],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1A0],xmm4
       add       rax,30
       jne       short M01_L00
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
       call      qword ptr [7FFB2E91F360]
       mov       rbp,rax
       mov       rcx,1A264800070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFB2E91F498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7571C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7571C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E91DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E91F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E91F558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E71D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFB2E553510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E91F090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2E91F558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1A26E807F88
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L06
M01_L05:
       lea       rcx,[rsp+110]
       mov       edx,19
       call      qword ptr [7FFB2E8DBD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FFB2E310AF8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[rbp+8]
       mov       r11,7FFB2E310B00
       call      qword ptr [r11]
       mov       r15d,eax
       mov       r12,[rbp+8]
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,r12
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       r11,7FFB2E310B08
       call      qword ptr [r11]
       add       r14d,1
       jo        short M01_L07
       cmp       r14d,ebx
       jl        near ptr M01_L05
M01_L06:
       mov       rax,rbp
       add       rsp,180
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       ecx,7
       call      qword ptr [7FFB2E7178E8]
       int       3
; Total bytes of code 613
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1E0
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+1E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+200],xmm4
       add       rax,30
       jne       short M01_L00
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
       mov       ecx,1
       mov       rdx,7FFB910A4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB90F14938
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2425DE44E68
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L05
M01_L04:
       lea       rcx,[rsp+170]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+100]
       lea       rsi,[rsp+170]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FFB90E10628
       call      qword ptr [7FFB90E10628]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+8]
       mov       r11,7FFB90E10630
       call      qword ptr [7FFB90E10630]
       mov       r15d,eax
       lea       rdi,[rsp+90]
       lea       rsi,[rsp+100]
       mov       ecx,0E
       rep movsq
       mov       r12,[rbp+8]
       lea       rdi,[rsp+20]
       lea       rsi,[rsp+90]
       mov       ecx,0E
       rep movsq
       mov       rcx,r12
       lea       r8,[rsp+20]
       mov       edx,r15d
       mov       r11,7FFB90E10638
       call      qword ptr [7FFB90E10638]
       add       r14d,1
       jo        short M01_L06
       cmp       r14d,ebx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,rbp
       add       rsp,1E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 458
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2EB0BBE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2EBFB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,180
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+180],xmm4
       vmovdqa   xmmword ptr [rsp+rax+190],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1A0],xmm4
       add       rax,30
       jne       short M01_L00
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
       call      qword ptr [7FFB2E90F360]
       mov       rbp,rax
       mov       rcx,1E620C00070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFB2E90F498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2E7471C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2E90DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2E90F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2E90F558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2E70D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFB2E543510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2E90F090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2E90F558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2E6E5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1E61EC07F88
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L06
M01_L05:
       lea       rcx,[rsp+110]
       mov       edx,19
       call      qword ptr [7FFB2E8CBD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FFB2E300A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[rbp+8]
       mov       r11,7FFB2E300AA0
       call      qword ptr [r11]
       mov       r15d,eax
       mov       r12,[rbp+8]
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,r12
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       r11,7FFB2E300AA8
       call      qword ptr [r11]
       add       r14d,1
       jo        short M01_L07
       cmp       r14d,ebx
       jl        near ptr M01_L05
M01_L06:
       mov       rax,rbp
       add       rsp,180
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       ecx,7
       call      qword ptr [7FFB2E7078E8]
       int       3
; Total bytes of code 613
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1E0
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+1E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+200],xmm4
       add       rax,30
       jne       short M01_L00
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
       mov       ecx,1
       mov       rdx,7FFB910B4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB90F24938
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,261D33C9270
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L05
M01_L04:
       lea       rcx,[rsp+170]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+100]
       lea       rsi,[rsp+170]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FFB90E20628
       call      qword ptr [7FFB90E20628]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+8]
       mov       r11,7FFB90E20630
       call      qword ptr [7FFB90E20630]
       mov       r15d,eax
       lea       rdi,[rsp+90]
       lea       rsi,[rsp+100]
       mov       ecx,0E
       rep movsq
       mov       r12,[rbp+8]
       lea       rdi,[rsp+20]
       lea       rsi,[rsp+90]
       mov       ecx,0E
       rep movsq
       mov       rcx,r12
       lea       r8,[rsp+20]
       mov       edx,r15d
       mov       r11,7FFB90E20638
       call      qword ptr [7FFB90E20638]
       add       r14d,1
       jo        short M01_L06
       cmp       r14d,ebx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,rbp
       add       rsp,1E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 458
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2D8FBBE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9E9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,180
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+180],xmm4
       vmovdqa   xmmword ptr [rsp+rax+190],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1A0],xmm4
       add       rax,30
       jne       short M01_L00
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
       call      qword ptr [7FFB2D6FF360]
       mov       rbp,rax
       mov       rcx,12D77000070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFB2D6FF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5371C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5371C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D6FDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6FF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D6FF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFB2D333510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D6FF090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D6FF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4D5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,12D7B007F88
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L06
M01_L05:
       lea       rcx,[rsp+110]
       mov       edx,19
       call      qword ptr [7FFB2D6BBD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FFB2D0F0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[rbp+8]
       mov       r11,7FFB2D0F0AA0
       call      qword ptr [r11]
       mov       r15d,eax
       mov       r12,[rbp+8]
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,r12
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       r11,7FFB2D0F0AA8
       call      qword ptr [r11]
       add       r14d,1
       jo        short M01_L07
       cmp       r14d,ebx
       jl        near ptr M01_L05
M01_L06:
       mov       rax,rbp
       add       rsp,180
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       ecx,7
       call      qword ptr [7FFB2D4F78E8]
       int       3
; Total bytes of code 613
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1E0
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+1E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+200],xmm4
       add       rax,30
       jne       short M01_L00
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
       mov       ecx,1
       mov       rdx,7FFB910A4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB90F14938
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,166534A9270
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L05
M01_L04:
       lea       rcx,[rsp+170]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+100]
       lea       rsi,[rsp+170]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FFB90E10628
       call      qword ptr [7FFB90E10628]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+8]
       mov       r11,7FFB90E10630
       call      qword ptr [7FFB90E10630]
       mov       r15d,eax
       lea       rdi,[rsp+90]
       lea       rsi,[rsp+100]
       mov       ecx,0E
       rep movsq
       mov       r12,[rbp+8]
       lea       rdi,[rsp+20]
       lea       rsi,[rsp+90]
       mov       ecx,0E
       rep movsq
       mov       rcx,r12
       lea       r8,[rsp+20]
       mov       edx,r15d
       mov       r11,7FFB90E10638
       call      qword ptr [7FFB90E10638]
       add       r14d,1
       jo        short M01_L06
       cmp       r14d,ebx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,rbp
       add       rsp,1E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 458
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2D8EB9D8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9D9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,180
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+180],xmm4
       vmovdqa   xmmword ptr [rsp+rax+190],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1A0],xmm4
       add       rax,30
       jne       short M01_L00
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
       call      qword ptr [7FFB2D6EF360]
       mov       rbp,rax
       mov       rcx,1F8A0000070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFB2D6EF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5271C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5271C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D6EDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6EF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D6EF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFB2D323510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D6EF090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D6EF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4C5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1F8A4005F90
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L06
M01_L05:
       lea       rcx,[rsp+110]
       mov       edx,19
       call      qword ptr [7FFB2D6ABD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FFB2D0E0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[rbp+8]
       mov       r11,7FFB2D0E0AA0
       call      qword ptr [r11]
       mov       r15d,eax
       mov       r12,[rbp+8]
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,r12
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       r11,7FFB2D0E0AA8
       call      qword ptr [r11]
       add       r14d,1
       jo        short M01_L07
       cmp       r14d,ebx
       jl        near ptr M01_L05
M01_L06:
       mov       rax,rbp
       add       rsp,180
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       ecx,7
       call      qword ptr [7FFB2D4E78E8]
       int       3
; Total bytes of code 613
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1E0
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+1E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+200],xmm4
       add       rax,30
       jne       short M01_L00
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
       mov       ecx,1
       mov       rdx,7FFB910B4B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB90F24938
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,234927E4E68
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L05
M01_L04:
       lea       rcx,[rsp+170]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+100]
       lea       rsi,[rsp+170]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FFB90E20628
       call      qword ptr [7FFB90E20628]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+8]
       mov       r11,7FFB90E20630
       call      qword ptr [7FFB90E20630]
       mov       r15d,eax
       lea       rdi,[rsp+90]
       lea       rsi,[rsp+100]
       mov       ecx,0E
       rep movsq
       mov       r12,[rbp+8]
       lea       rdi,[rsp+20]
       lea       rsi,[rsp+90]
       mov       ecx,0E
       rep movsq
       mov       rcx,r12
       lea       r8,[rsp+20]
       mov       edx,r15d
       mov       r11,7FFB90E20638
       call      qword ptr [7FFB90E20638]
       add       r14d,1
       jo        short M01_L06
       cmp       r14d,ebx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,rbp
       add       rsp,1E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 458
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2D91B9D8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2DA09FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,180
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+180],xmm4
       vmovdqa   xmmword ptr [rsp+rax+190],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1A0],xmm4
       add       rax,30
       jne       short M01_L00
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
       call      qword ptr [7FFB2D71F360]
       mov       rbp,rax
       mov       rcx,259A9C00070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFB2D71F498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5571C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5571C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D71DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D71F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D71F558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D51D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFB2D353510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D71F090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D71F558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,259B1C07F88
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L06
M01_L05:
       lea       rcx,[rsp+110]
       mov       edx,19
       call      qword ptr [7FFB2D6DBD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FFB2D110A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[rbp+8]
       mov       r11,7FFB2D110AA0
       call      qword ptr [r11]
       mov       r15d,eax
       mov       r12,[rbp+8]
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,r12
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       r11,7FFB2D110AA8
       call      qword ptr [r11]
       add       r14d,1
       jo        short M01_L07
       cmp       r14d,ebx
       jl        near ptr M01_L05
M01_L06:
       mov       rax,rbp
       add       rsp,180
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       ecx,7
       call      qword ptr [7FFB2D5178E8]
       int       3
; Total bytes of code 613
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,1E0
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       mov       rax,0FFFFFFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+1E0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1F0],xmm4
       vmovdqa   xmmword ptr [rsp+rax+200],xmm4
       add       rax,30
       jne       short M01_L00
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
       mov       ecx,1
       mov       rdx,7FFB91094B48
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB90F04938
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1412E386E60
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L05
M01_L04:
       lea       rcx,[rsp+170]
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+100]
       lea       rsi,[rsp+170]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FFB90E00628
       call      qword ptr [7FFB90E00628]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+8]
       mov       r11,7FFB90E00630
       call      qword ptr [7FFB90E00630]
       mov       r15d,eax
       lea       rdi,[rsp+90]
       lea       rsi,[rsp+100]
       mov       ecx,0E
       rep movsq
       mov       r12,[rbp+8]
       lea       rdi,[rsp+20]
       lea       rsi,[rsp+90]
       mov       ecx,0E
       rep movsq
       mov       rcx,r12
       lea       r8,[rsp+20]
       mov       edx,r15d
       mov       r11,7FFB90E00638
       call      qword ptr [7FFB90E00638]
       add       r14d,1
       jo        short M01_L06
       cmp       r14d,ebx
       jl        near ptr M01_L04
M01_L05:
       mov       rax,rbp
       add       rsp,1E0
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L06:
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       ecx,6
       call      System.ThrowHelper.ThrowNotSupportedException(System.ExceptionResource)
       int       3
; Total bytes of code 458
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FFB2D8DBBE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFB2D9C9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,180
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFEB0
M01_L00:
       vmovdqa   xmmword ptr [rsp+rax+180],xmm4
       vmovdqa   xmmword ptr [rsp+rax+190],xmm4
       vmovdqa   xmmword ptr [rsp+rax+1A0],xmm4
       add       rax,30
       jne       short M01_L00
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
       call      qword ptr [7FFB2D6DF360]
       mov       rbp,rax
       mov       rcx,2587D000070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFB2D6DF498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFB2D5171C8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFB2D5171C8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFB2D6DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFB2D6DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFB2D6DF558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFB2D4DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFB2D313510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFB2D6DF090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFB2D6DF558]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFB2D4B5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,25873003B80
       mov       rdx,[rdx]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       xor       r14d,r14d
       test      ebx,ebx
       jle       near ptr M01_L06
M01_L05:
       lea       rcx,[rsp+110]
       mov       edx,19
       call      qword ptr [7FFB2D69BD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FFB2D0D0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[rbp+8]
       mov       r11,7FFB2D0D0AA0
       call      qword ptr [r11]
       mov       r15d,eax
       mov       r12,[rbp+8]
       lea       rdi,[rsp+30]
       lea       rsi,[rsp+0A0]
       mov       ecx,0E
       rep movsq
       mov       rcx,r12
       lea       r8,[rsp+30]
       mov       edx,r15d
       mov       r11,7FFB2D0D0AA8
       call      qword ptr [r11]
       add       r14d,1
       jo        short M01_L07
       cmp       r14d,ebx
       jl        near ptr M01_L05
M01_L06:
       mov       rax,rbp
       add       rsp,180
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M01_L07:
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       ecx,7
       call      qword ptr [7FFB2D4D78E8]
       int       3
; Total bytes of code 613
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,21E59327F48
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,21E59327F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,21E59327F48
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
       mov       rdx,21E59322F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,1D1EB006F50
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1D1EB006F40
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
       mov       rdx,1D1EB001F50
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
       call      qword ptr [7FFB2E6FB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2E6FB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,24498AC3B40
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,24498AC3B30
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,24498AC3B40
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
       mov       rdx,244B8AC2F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,2BB13002B48
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2BB13002B38
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
       mov       rdx,2BB17001F50
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
       call      qword ptr [7FFB2E6FB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2E6FB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,21B5FF73B40
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,21B5FF73B30
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,21B5FF73B40
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
       mov       rdx,21B7FF72F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,1B3E2C06F50
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1B3E2C06F40
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
       mov       rdx,1B3E2C01F50
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
       call      qword ptr [7FFB2E70B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2E70B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,29B4E343B40
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,29B4E343B30
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,29B4E343B40
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
       mov       rdx,29B5E342F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,25C6B806F50
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,25C6B806F40
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
       mov       rdx,25C6B801F50
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
       call      qword ptr [7FFB2D50B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2D50B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,2D1BC235F50
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2D1BC235F40
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2D1BC235F50
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
       mov       rdx,2D1BC232F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,27D24402B48
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,27D24402B38
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
       mov       rdx,27D28401F50
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
       call      qword ptr [7FFB2D51B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2D51B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,1ABA7D57F48
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1ABA7D57F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1ABA7D57F48
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
       mov       rdx,1ABA7D52F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,23614C06F50
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,23614C06F40
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
       mov       rdx,23614C01F50
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
       call      qword ptr [7FFB2D4FB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2D4FB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,23843567F48
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,23843567F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,23843567F48
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
       mov       rdx,23843562F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,23899C04F58
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,23899C04F48
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
       mov       rdx,2389DC01F50
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
       call      qword ptr [7FFB2D4DB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2D4DB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,15EC9205F58
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,15EC9205F40
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,15EC9205F58
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
       mov       rdx,15EE9202F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,26F53406F58
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,26F53406F40
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
       mov       rdx,26F53401F50
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
       call      qword ptr [7FFB2E70B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2E70B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,1C015B37F50
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C015B37F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1C015B37F50
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
       mov       rdx,1C015B32F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,27E18806F58
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,27E18806F40
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
       mov       rdx,27E18801F50
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
       call      qword ptr [7FFB2E6DB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2E6DB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,2236A1D7F50
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2236A1D7F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2236A1D7F50
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
       mov       rdx,2236A1D2F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,2B3CF406F58
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2B3CF406F40
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
       mov       rdx,2B3CF401F50
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
       call      qword ptr [7FFB2E6FB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2E6FB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,14A31CE7F50
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,14A31CE7F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,14A31CE7F50
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
       mov       rdx,14A31CE2F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,21B58806F58
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,21B58806F40
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
       mov       rdx,21B58801F50
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
       call      qword ptr [7FFB2D50B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2D50B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,10E32FB7F50
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,10E32FB7F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,10E32FB7F50
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
       mov       rdx,10E32FB2F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,1274A002B50
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1274A002B38
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
       mov       rdx,12738001F50
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
       call      qword ptr [7FFB2D4FB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2D4FB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,2EBE5B47F50
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2EBE5B47F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2EBE5B47F50
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
       mov       rdx,2EBE5B42F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,17306C06F58
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,17306C06F40
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
       mov       rdx,17306C01F50
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
       call      qword ptr [7FFB2D51B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2D51B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,23876057F50
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,23876057F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,23876057F50
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
       mov       rdx,23876052F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,1FC0CC06F58
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1FC0CC06F40
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
       mov       rdx,1FC0CC01F50
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
       call      qword ptr [7FFB2D4FB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2D4FB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,1F14D347F58
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F14D347F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,1F14D347F58
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
       mov       rdx,1F14D342F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,2BC66404F68
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2BC66404F48
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
       mov       rdx,2BC6A401F50
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
       call      qword ptr [7FFB2E6FB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2E6FB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,1FFF4C43B50
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1FFF4C43B30
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,1FFF4C43B50
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
       mov       rdx,20014C42F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,23382C06F60
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,23382C06F40
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
       mov       rdx,23382C01F50
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
       call      qword ptr [7FFB2E6EB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2E6EB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,25F46797F58
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,25F46797F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,25F46797F58
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
       mov       rdx,25F46792F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,29AA8806F60
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,29AA8806F40
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
       mov       rdx,29AA8801F50
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
       call      qword ptr [7FFB2E6EB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2E6EB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,22053E55F60
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,22053E55F40
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,22053E55F60
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
       mov       rdx,22053E52F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,23687C06F60
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,23687C06F40
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
       mov       rdx,23687C01F50
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
       call      qword ptr [7FFB2D50B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2D50B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,18255883B50
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,18255883B30
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,18255883B50
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
       mov       rdx,18275882F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,1F3AF402B58
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1F3AF402B38
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
       mov       rdx,1F3B3401F50
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
       call      qword ptr [7FFB2D4DB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2D4DB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,21DD2FB7F58
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,21DD2FB7F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,21DD2FB7F58
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
       mov       rdx,21DD2FB2F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,26999004F68
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,26999004F48
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
       mov       rdx,2699D001F50
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
       call      qword ptr [7FFB2E71B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2E71B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       mov       rcx,2569C1C7F58
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2569C1C7F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,2569C1C7F58
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
       mov       rdx,2569C1C2F38
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       mov       rbx,152E7806F60
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,152E7806F40
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
       mov       rdx,152E7801F50
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
       call      qword ptr [7FFB2D50B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FFB2D50B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

