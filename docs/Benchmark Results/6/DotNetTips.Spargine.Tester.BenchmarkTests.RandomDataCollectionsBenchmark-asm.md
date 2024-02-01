## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7C4B50
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
       vmulsd    xmm0,xmm0,qword ptr [7FF9DBAB7AE8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CDE39750]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CDF2B330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CDC3F360]
       mov       rdi,rax
       mov       rcx,27646408C70
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CDC3F498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CDA79458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CDA79458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CDC3DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CDC3F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CDC3F600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CDA3D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CD873510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CDC3F090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CDC3F600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CDA05750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CDE39798]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FF9CDBFBD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FF9CDE39918]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FF9CDF95748]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9CDE397E0]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7B4B50
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
       vmulsd    xmm0,xmm0,qword ptr [7FF9DBAA7AC8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CF5D5EE8]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6C9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3DF360]
       mov       rdi,rax
       mov       rcx,21328008C70
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3DF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CF5D7018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FF9CF39BD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FF9CF5D7198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FF9CF735A28]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5D7060]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7A4B50
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
       vmulsd    xmm0,xmm0,qword ptr [7FF9DBA97AE8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CF5F7EB8]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6EBFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3FF360]
       mov       rdi,rax
       mov       rcx,2BD95408C70
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3FF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF239458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF239458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3FDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3FF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3FF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF033510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3FF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CF3FF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1C5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CF5F9018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FF9CF3BBD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FF9CF5F9198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FF9CF755A28]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5F9060]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7A4B50
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
       vmulsd    xmm0,xmm0,qword ptr [7FF9DBA97B08]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CF5D9768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6CB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3DF360]
       mov       rdi,rax
       mov       rcx,1EB05000078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3DF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CF5D97B0]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FF9CF39BD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FF9CF5D9930]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FF9CF735EE8]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5D97F8]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7C4B50
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
       vmulsd    xmm0,xmm0,qword ptr [7FF9DBAB7AE8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CF5C9738]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6BB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3CF360]
       mov       rdi,rax
       mov       rcx,1A3B6C08C70
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3CF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF209458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF209458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3CDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3CF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3CF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3CF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CF3CF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CF195750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CF5C9780]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FF9CF38BD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FF9CF5C9900]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FF9CF726008]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5C97C8]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7B4B50
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
       vmulsd    xmm0,xmm0,qword ptr [7FF9DBAA7B08]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CF5E9E88]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6DD330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3EF360]
       mov       rdi,rax
       mov       rcx,2A8D7C00078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3EF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF229458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF229458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3EF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3EF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3EF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CF3EF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CF5EB018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FF9CF3ABD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FF9CF5EB198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FF9CF746008]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5EB060]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB794B50
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
       vmulsd    xmm0,xmm0,qword ptr [7FF9DBA87B08]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CF5D7E70]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6CD330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3DF360]
       mov       rdi,rax
       mov       rcx,1C61AC08C70
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3DF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CF5D9018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FF9CF39BD50]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FF9CF5D9198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FF9CF736008]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5D9060]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7C4B50
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
       vmulsd    xmm0,xmm0,qword ptr [7FF9DBAB2DA8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CDBF9768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CDF2BFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CDC3F360]
       mov       rdi,rax
       mov       rcx,1A563000078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CDC3F498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CDA79458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CDA79458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CDC3DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CDC3F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CDC3F600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CDA3D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CD873510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CDC3F090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CDC3F600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CDA05750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CDE3D018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FF9CDBFBD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FF9CDE3D198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FF9CDF95728]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9CDE3D060]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB794B50
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
       vmulsd    xmm0,xmm0,qword ptr [7FF9DBA88928]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CF379768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6A9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3BF360]
       mov       rdi,rax
       mov       rcx,1E62D400078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3BF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3BDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3BF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CEFF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3BF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CF185750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CF5BB228]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FF9CF37BD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FF9CF5BB3A8]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FF9CF715F48]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5BB270]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7C4B50
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
       vmulsd    xmm0,xmm0,qword ptr [7FF9DBAB8928]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CF379768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6AB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3BF360]
       mov       rdi,rax
       mov       rcx,2310F400078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3BF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3BDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3BF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CEFF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3BF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CF185750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CF5BB228]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FF9CF37BD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FF9CF5BB3A8]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FF9CF715C68]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5BB270]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7A4B50
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
       vmulsd    xmm0,xmm0,qword ptr [7FF9DBA98908]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CF379768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6A9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3BF360]
       mov       rdi,rax
       mov       rcx,1E96AC00890
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3BF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3BDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3BF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CEFF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3BF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CF185750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CF5BD228]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FF9CF37BD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FF9CF5BD3A8]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FF9CF716008]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5BD270]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7C4B50
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
       vmulsd    xmm0,xmm0,qword ptr [7FF9DBAB8908]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CF3A9768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6DB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3EF360]
       mov       rdi,rax
       mov       rcx,1A635800078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3EF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF229458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF229458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3EF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3EF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3EF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CF3EF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CF5EB228]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FF9CF3ABD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FF9CF5EB3A8]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FF9CF746008]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5EB270]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB784B50
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
       vmulsd    xmm0,xmm0,qword ptr [7FF9DBA788E8]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CF3A9768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6D9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3EF360]
       mov       rdi,rax
       mov       rcx,23A00408C70
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3EF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF229458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF229458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3EF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3EF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3EF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CF3EF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CF5EB228]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FF9CF3ABD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FF9CF5EB3A8]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FF9CF746008]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5EB270]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB794B50
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
       vmulsd    xmm0,xmm0,qword ptr [7FF9DBA88908]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CF389768]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6BB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3CF360]
       mov       rdi,rax
       mov       rcx,213AF000078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3CF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF209458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF209458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3CDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3CF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3CF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3CF090]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FF9CF3CF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FF9CF195750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FF9CF5CB018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FF9CF38BD38]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FF9CF5CB198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FF9CF726008]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FF9CF5CB060]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7A4B50
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
       mov       rdx,7FF9DBB62888
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
       mov       rdx,7FF9DBB628C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9DB92CBE8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9CDC17720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CDF49FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CDC5F360]
       mov       rbx,rax
       mov       rcx,1A47A408C70
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FF9CDC5F498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CDA99458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CDA99458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CDC5DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CDC5F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CDC5F600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CDA5D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CD893510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CDC5F090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CDC5F600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CDA25750]
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
       mov       rdx,7FF9CDE72568
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CDC17A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9CDE725A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FF9CDC1BCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CDC33420]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7C4B50
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
       mov       rdx,7FF9DBB85008
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
       mov       rdx,7FF9DBB85048
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9DB94CBE8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9CF377720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6A9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3BF360]
       mov       rbx,rax
       mov       rcx,25536406C78
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3BF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3BDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3BF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CEFF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3BF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF185750]
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
       mov       rdx,7FF9CF5D3FD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF377A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9CF5D4010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FF9CF37BCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF393420]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB794B50
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
       mov       rdx,7FF9DBB55008
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
       mov       rdx,7FF9DBB55048
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9DB91CBE8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9CF397720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6CD330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3DF360]
       mov       rbx,rax
       mov       rcx,14C4C808C70
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3DF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3DF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1A5750]
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
       mov       rdx,7FF9CF5F3310
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF397A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9CF5F3350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FF9CF39BCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF3B3420]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7A4B50
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
       mov       rdx,7FF9DBB61968
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
       mov       rdx,7FF9DBB619A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9DB92CBE8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9CF3B7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6EB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3FF360]
       mov       rbx,rax
       mov       rcx,24A63400078
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3FF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF239458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF239458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3FDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3FF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3FF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF033510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3FF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF3FF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1C5750]
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
       mov       rdx,7FF9CF614058
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF3B7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9CF614098
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FF9CF3BBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF3D3420]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7B4B50
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
       mov       rdx,7FF9DBB74F40
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
       mov       rdx,7FF9DBB74F80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9DB93CBE8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9CF377720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6A9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3BF360]
       mov       rbx,rax
       mov       rcx,21B34400078
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3BF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3BDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3BF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CEFF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3BF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF185750]
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
       mov       rdx,7FF9CF5D15B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF377A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9CF5D15F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FF9CF37BCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF393420]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB794B50
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
       mov       rdx,7FF9DBB54FD8
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
       mov       rdx,7FF9DBB55018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9DB91CBE8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9CF3A7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6DBFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3EF360]
       mov       rbx,rax
       mov       rcx,26213000078
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3EF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF229458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF229458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3EF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3EF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3EF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF3EF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1B5750]
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
       mov       rdx,7FF9CF603540
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF3A7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9CF603580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FF9CF3ABCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF3C3420]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7B4B50
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
       mov       rdx,7FF9DBB75008
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
       mov       rdx,7FF9DBB75048
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9DB93CBE8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9CF377720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6A9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3BF360]
       mov       rbx,rax
       mov       rcx,22373000078
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3BF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3BDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3BF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CEFF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3BF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF185750]
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
       mov       rdx,7FF9CF5D0808
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF377A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9CF5D0848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FF9CF37BCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF393420]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB784B50
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
       mov       rdx,7FF9DBB44F70
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
       mov       rdx,7FF9DBB44FB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9DB90CBE8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9CDBF7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CDF2B330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CDC3F360]
       mov       rbx,rax
       mov       rcx,267A7800078
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FF9CDC3F498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CDA79458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CDA79458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CDC3DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CDC3F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CDC3F600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CDA3D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CD873510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CDC3F090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CDC3F600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CDA05750]
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
       mov       rdx,7FF9CDE53D48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CDBF7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9CDE53D88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FF9CDBFBCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CDC13420]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7A4B50
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
       mov       rdx,7FF9DBB64FD8
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
       mov       rdx,7FF9DBB65018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9DB92CBE8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9CF3A7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6DBFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3EF360]
       mov       rbx,rax
       mov       rcx,2178E400078
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3EF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF229458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF229458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3EF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3EF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3EF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF3EF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1B5750]
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
       mov       rdx,7FF9CF603948
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF3A7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9CF603988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FF9CF3ABCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF3C3420]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7B4B50
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
       mov       rdx,7FF9DBB75008
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
       mov       rdx,7FF9DBB75048
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9DB93CBE8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9CF3A7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6D7FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3EF360]
       mov       rbx,rax
       mov       rcx,1C1E9408C70
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3EF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF229458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF229458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3EF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3EF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3EF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF3EF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1B5750]
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
       mov       rdx,7FF9CF600628
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF3A7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9CF600668
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FF9CF3ABCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF3C3420]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7A4B50
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
       mov       rdx,7FF9DBB64FD8
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
       mov       rdx,7FF9DBB65018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9DB92CBE8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9CF397720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6CB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3DF360]
       mov       rbx,rax
       mov       rcx,1AEDD000078
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3DF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3DF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1A5750]
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
       mov       rdx,7FF9CF5F36C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF397A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9CF5F3708
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FF9CF39BCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF3B3420]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7A4B50
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
       mov       rdx,7FF9DBB65008
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
       mov       rdx,7FF9DBB65048
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9DB92CBE8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9CF387720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6B9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3CF360]
       mov       rbx,rax
       mov       rcx,128EA000078
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3CF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF209458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF209458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3CDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3CF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3CF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3CF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF3CF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF195750]
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
       mov       rdx,7FF9CF5E1868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF387A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9CF5E18A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FF9CF38BCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF3A3420]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7C4B50
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
       mov       rdx,7FF9DBB84FD8
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
       mov       rdx,7FF9DBB85018
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9DB94CBE8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9CF377720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6ABFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3BF360]
       mov       rbx,rax
       mov       rcx,23228C08C70
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3BF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3BDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3BF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CEFF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3BF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF185750]
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
       mov       rdx,7FF9CF5D3880
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF377A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9CF5D38C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FF9CF37BCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF393420]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7B4B50
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
       mov       rdx,7FF9DBB74F70
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
       mov       rdx,7FF9DBB74FB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       edx,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9DB93CBE8]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+284]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FF9CF3A7720]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6DD330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3EF360]
       mov       rbx,rax
       mov       rcx,162B4800078
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3EF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF229458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF229458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3EF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3EF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3EF090]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FF9CF3EF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1B5750]
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
       mov       rdx,7FF9CF603608
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF3A7A80]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FF9CF603648
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L08:
       mov       edx,19
       call      qword ptr [7FF9CF3ABCD8]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF3C3420]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,22096007F40
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,22096007F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,22096007F40
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
       mov       rdx,22096002F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,233D5C06F48
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,233D5C06F40
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
       mov       rdx,233D5C01F50
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
       call      qword ptr [7FF9CF1EB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1EB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,1C154CE7F40
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C154CE7F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,1C154CE7F40
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
       mov       rdx,1C154CE2F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,2C3DD806F48
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2C3DD806F40
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
       mov       rdx,2C3DD801F50
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
       call      qword ptr [7FF9CF1CB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1CB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,1AFA1395F48
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1AFA1395F40
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,1AFA1395F48
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
       mov       rdx,1AFC1392F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,1935EC06F48
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1935EC06F40
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
       mov       rdx,1935EC01F50
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
       call      qword ptr [7FF9CF1CB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1CB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,1E1A4667F40
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E1A4667F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,1E1A4667F40
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
       mov       rdx,1E1A4662F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,2B22C406F48
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2B22C406F40
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
       mov       rdx,2B22C401F50
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
       call      qword ptr [7FF9CF1CB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1CB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,24270F47F40
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,24270F47F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,24270F47F40
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
       mov       rdx,24270F42F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,1DA69806F48
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1DA69806F40
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
       mov       rdx,1DA69801F50
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
       call      qword ptr [7FF9CF1DB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1DB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,1FFAB2A7F40
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1FFAB2A7F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,1FFAB2A7F40
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
       mov       rdx,1FFAB2A2F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,1990C006F48
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1990C006F40
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
       mov       rdx,1990C001F50
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
       call      qword ptr [7FF9CF1EB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1EB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,1CE72947F40
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1CE72947F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,1CE72947F40
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
       mov       rdx,1CE72942F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,1E835C06F48
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1E835C06F40
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
       mov       rdx,1E835C01F50
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
       call      qword ptr [7FF9CF1BB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1BB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<CoordinateProperOrderByBenchmark>b__4_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,1A3AE1F3BD8
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
       mov       rdx,7FF9DB794B50
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
       mov       rdx,1A3CE1F3020
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CDBE7150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      qword ptr [7FF9CDBE7108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CDF19FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,22DFFC06FE8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rax,[rcx+18]
M01_L00:
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      qword ptr [7FF9CDE21180]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      qword ptr [7FF9CDE21180]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      qword ptr [7FF9CDBE97E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FF9CDB73A50]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      qword ptr [7FF9CDE21180]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9CDC2F360]
       mov       r12,rax
       mov       rcx,22E0BC00078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FF9CDC2F498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CDA69458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CDA69458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CDC2DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CDC2F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CDC2F600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CDA2D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       edx,3
       call      qword ptr [7FF9CD863510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CDC2F090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF9CDC2F600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CD9F5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      qword ptr [7FF9CD8D7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L12
M02_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      qword ptr [7FF9CDE27240]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      qword ptr [7FF9CDE27048]; System.Globalization.RegionInfo.get_CurrentRegion()
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
       call      qword ptr [7FF9CDBE7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FF9CDE274B0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      qword ptr [7FF9CDBE7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FF9CDE274E0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
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
       mov       rdx,22DFFC02028
       mov       rdx,[rdx]
M02_L07:
       call      qword ptr [7FF9CDE27510]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CDE27540]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      qword ptr [7FF9CDBE7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CDE27570]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FF9CDBE7390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CDE275D0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF9CDBE7138]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CDE27600]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
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
       call      qword ptr [7FF9CDE27630]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
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
       call      qword ptr [7FF9CD8D7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,14CB5E47FE0
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
       mov       rdx,7FF9DB7B4B50
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
       mov       rdx,14CB5E43020
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF397150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      qword ptr [7FF9CF397108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6CBFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,2284E406FE8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rax,[rcx+18]
M01_L00:
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      qword ptr [7FF9CF5D1780]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      qword ptr [7FF9CF5D1780]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      qword ptr [7FF9CF3997E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FF9CF323A50]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      qword ptr [7FF9CF5D1780]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9CF3DF360]
       mov       r12,rax
       mov       rcx,22850400078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FF9CF3DF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3DF090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      qword ptr [7FF9CF087918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L12
M02_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      qword ptr [7FF9CF5D7978]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      qword ptr [7FF9CF5D7780]; System.Globalization.RegionInfo.get_CurrentRegion()
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
       call      qword ptr [7FF9CF397528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FF9CF5D7C00]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      qword ptr [7FF9CF397528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FF9CF5D7C30]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
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
       mov       rdx,2284E402028
       mov       rdx,[rdx]
M02_L07:
       call      qword ptr [7FF9CF5D7C60]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5D7C90]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      qword ptr [7FF9CF397528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5D7CC0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FF9CF397390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5D7D20]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF9CF397138]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5D7D50]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
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
       call      qword ptr [7FF9CF5D7D80]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
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
       call      qword ptr [7FF9CF087A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,1EE8D0B7FE0
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
       mov       rdx,7FF9DB7B4B50
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
       mov       rdx,1EE8D0B3020
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF397150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      qword ptr [7FF9CF397108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6CBFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,1B50AC06FE8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rax,[rcx+18]
M01_L00:
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      qword ptr [7FF9CF5D1900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      qword ptr [7FF9CF5D1900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      qword ptr [7FF9CF3997E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FF9CF323A50]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      qword ptr [7FF9CF5D1900]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9CF3DF360]
       mov       r12,rax
       mov       rcx,1B50CC00078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FF9CF3DF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3DF090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      qword ptr [7FF9CF087918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L12
M02_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      qword ptr [7FF9CF5D7978]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      qword ptr [7FF9CF5D7780]; System.Globalization.RegionInfo.get_CurrentRegion()
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
       call      qword ptr [7FF9CF397528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FF9CF5D7BD0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      qword ptr [7FF9CF397528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FF9CF5D7C00]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
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
       mov       rdx,1B50AC02028
       mov       rdx,[rdx]
M02_L07:
       call      qword ptr [7FF9CF5D7C30]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5D7C60]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      qword ptr [7FF9CF397528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5D7C90]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FF9CF397390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5D7CF0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF9CF397138]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5D7D20]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
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
       call      qword ptr [7FF9CF5D7D50]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
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
       call      qword ptr [7FF9CF087A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,23C70837FE0
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
       mov       rdx,7FF9DB794B50
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
       mov       rdx,23C70833020
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF377150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      qword ptr [7FF9CF377108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6AB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,1EEAA406FE8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rax,[rcx+18]
M01_L00:
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      qword ptr [7FF9CF57F4B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      qword ptr [7FF9CF57F4B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      qword ptr [7FF9CF3797E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FF9CF303A50]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      qword ptr [7FF9CF57F4B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9CF3BF360]
       mov       r12,rax
       mov       rcx,1EEAA408C70
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FF9CF3BF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3BDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3BF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       edx,3
       call      qword ptr [7FF9CEFF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3BF090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF185750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      qword ptr [7FF9CF067918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L12
M02_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      qword ptr [7FF9CF5B5978]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      qword ptr [7FF9CF5B5780]; System.Globalization.RegionInfo.get_CurrentRegion()
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
       call      qword ptr [7FF9CF377528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FF9CF5B5BB8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      qword ptr [7FF9CF377528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FF9CF5B5BE8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
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
       mov       rdx,1EEAA402028
       mov       rdx,[rdx]
M02_L07:
       call      qword ptr [7FF9CF5B5C18]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5B5C48]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      qword ptr [7FF9CF377528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5B5C78]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FF9CF377390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5B5CD8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF9CF377138]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5B5D08]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
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
       call      qword ptr [7FF9CF5B5D38]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
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
       call      qword ptr [7FF9CF067A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,1C3EFA33BD8
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
       mov       rdx,7FF9DB7B4B50
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
       mov       rdx,1C40FA33020
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF3A7150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      qword ptr [7FF9CF3A7108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6DB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,26661806FE8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rax,[rcx+18]
M01_L00:
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      qword ptr [7FF9CF5E30D8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      qword ptr [7FF9CF5E30D8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      qword ptr [7FF9CF3A97E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FF9CF333A50]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      qword ptr [7FF9CF5E30D8]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9CF3EF360]
       mov       r12,rax
       mov       rcx,2666D800078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FF9CF3EF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF229458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF229458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3EF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3EF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3EF090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF9CF3EF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      qword ptr [7FF9CF097918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L12
M02_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      qword ptr [7FF9CF5E9240]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      qword ptr [7FF9CF5E9048]; System.Globalization.RegionInfo.get_CurrentRegion()
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
       call      qword ptr [7FF9CF3A7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FF9CF5E94B0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      qword ptr [7FF9CF3A7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FF9CF5E94E0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
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
       mov       rdx,26661802028
       mov       rdx,[rdx]
M02_L07:
       call      qword ptr [7FF9CF5E9510]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5E9540]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      qword ptr [7FF9CF3A7528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5E9570]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FF9CF3A7390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5E95D0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF9CF3A7138]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5E9600]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
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
       call      qword ptr [7FF9CF5E9630]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
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
       call      qword ptr [7FF9CF097A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,1E2AE963BD8
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
       mov       rdx,7FF9DB7C4B50
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
       mov       rdx,1E2CE963020
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF377150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      qword ptr [7FF9CF377108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6AB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,22796406FE8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rax,[rcx+18]
M01_L00:
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      qword ptr [7FF9CF57F4B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      qword ptr [7FF9CF57F4B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      qword ptr [7FF9CF3797E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FF9CF303A50]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      qword ptr [7FF9CF57F4B0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9CF3BF360]
       mov       r12,rax
       mov       rcx,227A2400078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FF9CF3BF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3BDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3BF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       edx,3
       call      qword ptr [7FF9CEFF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3BF090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF185750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      qword ptr [7FF9CF067918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L12
M02_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      qword ptr [7FF9CF5B5978]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      qword ptr [7FF9CF5B5780]; System.Globalization.RegionInfo.get_CurrentRegion()
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
       call      qword ptr [7FF9CF377528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FF9CF5B5BB8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      qword ptr [7FF9CF377528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FF9CF5B5BE8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
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
       mov       rdx,22796402028
       mov       rdx,[rdx]
M02_L07:
       call      qword ptr [7FF9CF5B5C18]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5B5C48]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      qword ptr [7FF9CF377528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5B5C78]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FF9CF377390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5B5CD8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF9CF377138]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5B5D08]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
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
       call      qword ptr [7FF9CF5B5D38]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
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
       call      qword ptr [7FF9CF067A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,18D59127FE0
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
       mov       rdx,7FF9DB794B50
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
       mov       rdx,18D59123020
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF397150]; DotNetTips.Spargine.Tester.RandomData.GetRandomLocationData(DotNetTips.Spargine.Tester.Data.Country ByRef, DotNetTips.Spargine.Tester.Data.State ByRef, DotNetTips.Spargine.Tester.Data.City ByRef)
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],14
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+48]
       mov       r8,[rsp+40]
       mov       r9d,edi
       call      qword ptr [7FF9CF397108]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.Tester.Data.City, Int32, Int32, Int32)
       xor       ecx,ecx
       mov       [rsp+50],rcx
       mov       [rsp+48],rcx
       mov       [rsp+40],rcx
       mov       [rsp+38],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+38]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6C9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       mov       rcx,1E9D0006FE8
       mov       rcx,[rcx]
       cmp       qword ptr [rcx+8],0
       jne       short M01_L01
       mov       rax,[rcx+18]
M01_L00:
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.Country>)
       call      qword ptr [7FF9CF5D3180]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rdx,[rdi]
       mov       rdx,[rdx+88]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.State, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.State>)
       call      qword ptr [7FF9CF5D3180]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rcx,[rsi]
       mov       rcx,[rcx+8]
       test      rcx,rcx
       je        short M01_L03
       call      qword ptr [7FF9CF3997E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jle       short M01_L03
       jmp       short M01_L02
M01_L01:
       call      qword ptr [7FF9CF323A50]; System.Lazy`1[[System.__Canon, System.Private.CoreLib]].CreateValue()
       jmp       short M01_L00
M01_L02:
       mov       rdx,[rsi]
       mov       rdx,[rdx+8]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[DotNetTips.Spargine.Tester.Data.City, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Data.City>)
       call      qword ptr [7FF9CF5D3180]; DotNetTips.Spargine.Extensions.EnumerableExtensions.PickRandom[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
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
       call      qword ptr [7FF9CF3DF360]
       mov       r12,rax
       mov       rcx,1E9CE000078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FF9CF3DF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3DF090]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,r12
       mov       edx,ebx
       call      qword ptr [7FF9CF087918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       r13d,r13d
       test      ebx,ebx
       jle       near ptr M02_L12
M02_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+40],rax
       call      qword ptr [7FF9CF5D9240]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+28],rax
       call      qword ptr [7FF9CF5D9048]; System.Globalization.RegionInfo.get_CurrentRegion()
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
       call      qword ptr [7FF9CF397528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FF9CF5D9480]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,r14d
       call      qword ptr [7FF9CF397528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+40]
       call      qword ptr [7FF9CF5D94B0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
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
       mov       rdx,1E9D0002028
       mov       rdx,[rdx]
M02_L07:
       call      qword ptr [7FF9CF5D94E0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       rdx,[rsi+58]
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5D9510]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r15d
       call      qword ptr [7FF9CF397528]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5D9540]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       mov       ecx,[rsi+0B8]
       call      qword ptr [7FF9CF397390]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5D95A0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF9CF397138]; DotNetTips.Spargine.Tester.RandomData.GeneratePostalCode(DotNetTips.Spargine.Tester.Data.Country, DotNetTips.Spargine.Tester.Data.City)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FF9CF5D95D0]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
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
       call      qword ptr [7FF9CF5D9600]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
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
       call      qword ptr [7FF9CF087A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB784B50
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
       mov       rcx,7FF9DB5E4938
       mov       edx,47
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,171DC839298
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
       mov       r11,7FF9DB4E0688
       call      qword ptr [7FF9DB4E0688]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,[r14+8]
       mov       r11,7FF9DB4E0690
       call      qword ptr [7FF9DB4E0690]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FF9DB4E0698
       call      qword ptr [7FF9DB4E0698]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CDC073C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CDF3B330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CDC4F360]
       mov       r14,rax
       mov       rcx,14159000078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CDC4F498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CDA89458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CDA89458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CDC4DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CDC4F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CDC4F600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CDA4D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CD883510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CDC4F090]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF9CDC4F600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CDA15750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,14153007FF0
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
       call      qword ptr [7FF9CDC073A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FF9CD640AF0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FF9CD640AF8
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FF9CD640B00
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
       call      qword ptr [7FF9CDA478E8]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7C4B50
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
       mov       rcx,7FF9DB624938
       mov       edx,47
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1B842369298
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
       mov       r11,7FF9DB520688
       call      qword ptr [7FF9DB520688]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,[r14+8]
       mov       r11,7FF9DB520690
       call      qword ptr [7FF9DB520690]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FF9DB520698
       call      qword ptr [7FF9DB520698]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF3973C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6C9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3DF360]
       mov       r14,rax
       mov       rcx,1CA54C00078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3DF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3DF090]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,1CA52C05FF8
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
       call      qword ptr [7FF9CF3973A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FF9CEDD0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FF9CEDD0AA0
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FF9CEDD0AA8
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
       call      qword ptr [7FF9CF1D78E8]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB784B50
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
       mov       rcx,7FF9DB5E4938
       mov       edx,47
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,17C24079298
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
       mov       r11,7FF9DB4E0688
       call      qword ptr [7FF9DB4E0688]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,[r14+8]
       mov       r11,7FF9DB4E0690
       call      qword ptr [7FF9DB4E0690]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FF9DB4E0698
       call      qword ptr [7FF9DB4E0698]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF3973C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6CBFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3DF360]
       mov       r14,rax
       mov       rcx,1CA4D000078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3DF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3DF090]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,1CA4F007FF0
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
       call      qword ptr [7FF9CF3973A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FF9CEDD0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FF9CEDD0AA0
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FF9CEDD0AA8
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
       call      qword ptr [7FF9CF1D78E8]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB794B50
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
       mov       rcx,7FF9DB5F4938
       mov       edx,47
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,15F6FA69298
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
       mov       r11,7FF9DB4F0688
       call      qword ptr [7FF9DB4F0688]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,[r14+8]
       mov       r11,7FF9DB4F0690
       call      qword ptr [7FF9DB4F0690]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FF9DB4F0698
       call      qword ptr [7FF9DB4F0698]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF3A73C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6D9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3EF360]
       mov       r14,rax
       mov       rcx,1C57F408C70
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3EF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF229458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF229458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3EDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3EF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3EF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3EF090]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF9CF3EF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1B5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,1C57F407FF0
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
       call      qword ptr [7FF9CF3A73A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FF9CEDE0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FF9CEDE0AA0
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FF9CEDE0AA8
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
       call      qword ptr [7FF9CF1E78E8]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7A4B50
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
       mov       rcx,7FF9DB604938
       mov       edx,47
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1A9277E9298
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
       mov       r11,7FF9DB500688
       call      qword ptr [7FF9DB500688]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,[r14+8]
       mov       r11,7FF9DB500690
       call      qword ptr [7FF9DB500690]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FF9DB500698
       call      qword ptr [7FF9DB500698]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF3873C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6B9FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3CF360]
       mov       r14,rax
       mov       rcx,1C254C00078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3CF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF209458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF209458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3CDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3CF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3CF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3CF090]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF9CF3CF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF195750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,1C244C07FF0
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
       call      qword ptr [7FF9CF3873A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FF9CEDC0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FF9CEDC0AA0
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FF9CEDC0AA8
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
       call      qword ptr [7FF9CF1C78E8]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7A4B50
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
       mov       rcx,7FF9DB604938
       mov       edx,47
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,24F8D1D9298
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
       mov       r11,7FF9DB500688
       call      qword ptr [7FF9DB500688]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,[r14+8]
       mov       r11,7FF9DB500690
       call      qword ptr [7FF9DB500690]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FF9DB500698
       call      qword ptr [7FF9DB500698]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF3873C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6BB330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3CF360]
       mov       r14,rax
       mov       rcx,200FFC00078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3CF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF209458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF209458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3CDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3CF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3CF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3CF090]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF9CF3CF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF195750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,200FDC07FF0
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
       call      qword ptr [7FF9CF3873A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FF9CEDC0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FF9CEDC0AA0
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FF9CEDC0AA8
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
       call      qword ptr [7FF9CF1C78E8]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB784B50
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
       mov       rcx,7FF9DB5E4938
       mov       edx,46
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,22B049A9288
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
       mov       r11,7FF9DB4E0688
       call      qword ptr [7FF9DB4E0688]
       test      eax,eax
       jne       short M01_L06
       mov       rcx,[r14+8]
       mov       r11,7FF9DB4E0690
       call      qword ptr [7FF9DB4E0690]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FF9DB4E0698
       call      qword ptr [7FF9DB4E0698]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9CF3973C0]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6C9330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3DF360]
       mov       r14,rax
       mov       rcx,2D0AB400890
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FF9CF3DF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3DF090]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       rdx,2D0AF407FF0
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
       call      qword ptr [7FF9CF3973A8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecord(Int32, Int32, Int32)
       mov       r12,rax
       mov       rcx,[r14+8]
       mov       r11,7FF9CEDD0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FF9CEDD0AA0
       call      qword ptr [r11]
       mov       edx,eax
       mov       rcx,[r14+8]
       mov       r8,r12
       mov       r11,7FF9CEDD0AA8
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
       call      qword ptr [7FF9CF1D78E8]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7C4B50
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
       mov       rcx,7FF9DB624938
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1AF22CE4E88
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
       mov       r11,7FF9DB520628
       call      qword ptr [7FF9DB520628]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+8]
       mov       r11,7FF9DB520630
       call      qword ptr [7FF9DB520630]
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
       mov       r11,7FF9DB520638
       call      qword ptr [7FF9DB520638]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CDE3BBE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CDF29FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CDC3F360]
       mov       rbp,rax
       mov       rcx,1AA36800078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9CDC3F498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CDA79458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CDA79458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CDC3DC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CDC3F078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CDC3F600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CDA3D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FF9CD873510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CDC3F090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CDC3F600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CDA05750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1AA28807FE8
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
       call      qword ptr [7FF9CDBFBD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FF9CD630AF0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[rbp+8]
       mov       r11,7FF9CD630AF8
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
       mov       r11,7FF9CD630B00
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
       call      qword ptr [7FF9CDA378E8]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB784B50
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
       mov       rcx,7FF9DB5E4938
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,26A32C49290
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
       mov       r11,7FF9DB4E0628
       call      qword ptr [7FF9DB4E0628]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+8]
       mov       r11,7FF9DB4E0630
       call      qword ptr [7FF9DB4E0630]
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
       mov       r11,7FF9DB4E0638
       call      qword ptr [7FF9DB4E0638]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CF5D9BE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6C7FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3DF360]
       mov       rbp,rax
       mov       rcx,1501B008C70
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9CF3DF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3DF090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1501B007FE8
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
       call      qword ptr [7FF9CF39BD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FF9CEDD0AF8
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[rbp+8]
       mov       r11,7FF9CEDD0B00
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
       mov       r11,7FF9CEDD0B08
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
       call      qword ptr [7FF9CF1D78E8]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB794B50
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
       mov       rcx,7FF9DB5F4938
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1F108FF9290
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
       mov       r11,7FF9DB4F0628
       call      qword ptr [7FF9DB4F0628]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+8]
       mov       r11,7FF9DB4F0630
       call      qword ptr [7FF9DB4F0630]
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
       mov       r11,7FF9DB4F0638
       call      qword ptr [7FF9DB4F0638]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CF5C9BE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6B7FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3CF360]
       mov       rbp,rax
       mov       rcx,172DEC00078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9CF3CF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF209458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF209458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3CDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3CF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3CF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FF9CF003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3CF090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF3CF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF195750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,172D6C07FE8
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
       call      qword ptr [7FF9CF38BD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FF9CEDC0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[rbp+8]
       mov       r11,7FF9CEDC0AA0
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
       mov       r11,7FF9CEDC0AA8
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
       call      qword ptr [7FF9CF1C78E8]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7C4B50
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
       mov       rcx,7FF9DB624938
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1FFCF6E4E88
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
       mov       r11,7FF9DB520628
       call      qword ptr [7FF9DB520628]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+8]
       mov       r11,7FF9DB520630
       call      qword ptr [7FF9DB520630]
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
       mov       r11,7FF9DB520638
       call      qword ptr [7FF9DB520638]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CF5CD9D8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6BD330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3CF360]
       mov       rbp,rax
       mov       rcx,21CAC408C70
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9CF3CF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF209458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF209458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3CDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3CF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3CF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FF9CF003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3CF090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF3CF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF195750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,21CAC407FE8
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
       call      qword ptr [7FF9CF38BD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FF9CEDC0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[rbp+8]
       mov       r11,7FF9CEDC0AA0
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
       mov       r11,7FF9CEDC0AA8
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
       call      qword ptr [7FF9CF1C78E8]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB794B50
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
       mov       rcx,7FF9DB5F4938
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2326CFA9290
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
       mov       r11,7FF9DB4F0628
       call      qword ptr [7FF9DB4F0628]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+8]
       mov       r11,7FF9DB4F0630
       call      qword ptr [7FF9DB4F0630]
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
       mov       r11,7FF9DB4F0638
       call      qword ptr [7FF9DB4F0638]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CF5BDBE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6AD330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3BF360]
       mov       rbp,rax
       mov       rcx,2E137000078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9CF3BF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF1F9458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3BDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3BF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1BD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FF9CEFF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3BF090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF3BF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF185750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2E139007FE8
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
       call      qword ptr [7FF9CF37BD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FF9CEDB0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[rbp+8]
       mov       r11,7FF9CEDB0AA0
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
       mov       r11,7FF9CEDB0AA8
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
       call      qword ptr [7FF9CF1B78E8]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7A4B50
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
       mov       rcx,7FF9DB604938
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2095D519290
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
       mov       r11,7FF9DB500628
       call      qword ptr [7FF9DB500628]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+8]
       mov       r11,7FF9DB500630
       call      qword ptr [7FF9DB500630]
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
       mov       r11,7FF9DB500638
       call      qword ptr [7FF9DB500638]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CF5DDBE8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6CBFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3DF360]
       mov       rbp,rax
       mov       rcx,1AAC3C00078
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9CF3DF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF219458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3DDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3DF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1DD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3DF090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF3DF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF1A5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1AAB9C07FE8
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
       call      qword ptr [7FF9CF39BD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FF9CEDD0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[rbp+8]
       mov       r11,7FF9CEDD0AA0
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
       mov       r11,7FF9CEDD0AA8
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
       call      qword ptr [7FF9CF1D78E8]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rdx,7FF9DB7B4B50
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
       mov       rcx,7FF9DB614938
       mov       edx,21
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,277BA3E9290
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
       mov       r11,7FF9DB510628
       call      qword ptr [7FF9DB510628]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[rbp+8]
       mov       r11,7FF9DB510630
       call      qword ptr [7FF9DB510630]
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
       mov       r11,7FF9DB510638
       call      qword ptr [7FF9DB510638]
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+284]
       call      qword ptr [7FF9CF5CD9D8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CF6BBFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FF9CF3CF360]
       mov       rbp,rax
       mov       rcx,183E8408C70
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FF9CF3CF498]
       mov       rsi,rax
       mov       ecx,536
       mov       rdx,7FF9CF209458
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,8BA
       mov       rdx,7FF9CF209458
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CF3CDC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FF9CF3CF078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FF9CF3CF600]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FF9CF1CD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FF9CF003510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FF9CF3CF090]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FF9CF3CF600]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FF9CF195750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,183E8407FE8
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
       call      qword ptr [7FF9CF38BD20]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       lea       rdi,[rsp+0A0]
       lea       rsi,[rsp+110]
       mov       ecx,0E
       rep movsq
       mov       rcx,[rbp+8]
       mov       r11,7FF9CEDC0A98
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[rbp+8]
       mov       r11,7FF9CEDC0AA0
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
       mov       r11,7FF9CEDC0AA8
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
       call      qword ptr [7FF9CF1C78E8]
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

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,1DA17853B40
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1DA17853B30
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1DA17853B40
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
       mov       rdx,1DA37852F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,1D623006F50
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1D623006F40
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
       mov       rdx,1D623001F50
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
       call      qword ptr [7FF9CDA4B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CDA4B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,1F19C047F48
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F19C047F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1F19C047F48
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
       mov       rdx,1F19C042F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,19212406F50
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,19212406F40
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
       mov       rdx,19212401F50
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
       call      qword ptr [7FF9CF1EB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1EB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,18C7C117F48
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,18C7C117F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,18C7C117F48
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
       mov       rdx,18C7C112F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,2294D406F50
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2294D406F40
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
       mov       rdx,2294D401F50
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
       call      qword ptr [7FF9CF1CB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1CB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,1F66A667F48
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F66A667F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1F66A667F48
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
       mov       rdx,1F66A662F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,1B2A6006F50
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1B2A6006F40
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
       mov       rdx,1B2A6001F50
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
       call      qword ptr [7FF9CF1EB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1EB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,1C1926D7F48
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C1926D7F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1C1926D7F48
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
       mov       rdx,1C1926D2F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,1CB39406F50
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1CB39406F40
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
       mov       rdx,1CB39401F50
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
       call      qword ptr [7FF9CF1EB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1EB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,24BF6587F48
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,24BF6587F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,24BF6587F48
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
       mov       rdx,24BF6582F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,18BE7406F50
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,18BE7406F40
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
       mov       rdx,18BE7401F50
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
       call      qword ptr [7FF9CF1FB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1FB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,1E935A77F48
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E935A77F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1E935A77F48
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
       mov       rdx,1E935A72F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,18DDDC06F50
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,18DDDC06F40
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
       mov       rdx,18DDDC01F50
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
       call      qword ptr [7FF9CF1CB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1CB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonOrderByBenchmark>b__12_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,14D02E97F50
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,14D02E97F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,14D02E97F50
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
       mov       rdx,14D02E92F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,21FBF406F58
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,21FBF406F40
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
       mov       rdx,21FBF401F50
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
       call      qword ptr [7FF9CDA4B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CDA4B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,219960A3B48
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,219960A3B30
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,219960A3B48
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
       mov       rdx,219B60A2F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,1BBB7406F58
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1BBB7406F40
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
       mov       rdx,1BBB7401F50
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
       call      qword ptr [7FF9CF1FB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1FB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,154D1117F50
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,154D1117F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,154D1117F50
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
       mov       rdx,154D1112F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,2B177806F58
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2B177806F40
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
       mov       rdx,2B177801F50
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
       call      qword ptr [7FF9CF1EB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1EB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,18FDD137F50
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,18FDD137F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,18FDD137F50
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
       mov       rdx,18FDD132F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,2803A406F58
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2803A406F40
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
       mov       rdx,2803A401F50
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
       call      qword ptr [7FF9CF1BB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1BB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,1D9660C7F50
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1D9660C7F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1D9660C7F50
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
       mov       rdx,1D9660C2F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,18CC7006F58
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,18CC7006F40
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
       mov       rdx,18CC7001F50
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
       call      qword ptr [7FF9CF1CB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1CB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,246D7B37F50
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,246D7B37F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,246D7B37F50
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
       mov       rdx,246D7B32F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,23D22006F58
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,23D22006F40
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
       mov       rdx,23D22001F50
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
       call      qword ptr [7FF9CF1CB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1CB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,2487B305F58
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2487B305F40
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2487B305F58
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
       mov       rdx,2489B302F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,2BE7D804F60
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,2BE7D804F48
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
       mov       rdx,2BE81801F50
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
       call      qword ptr [7FF9CF1EB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1EB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonProperOrderByBenchmark>b__13_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,2402B137F58
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2402B137F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,2402B137F58
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
       mov       rdx,2402B132F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,139B5406F60
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,139B5406F40
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
       mov       rdx,139B5401F50
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
       call      qword ptr [7FF9CDA2B780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CDA2B780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,21C76BC7F58
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,21C76BC7F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,21C76BC7F58
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
       mov       rdx,21C76BC2F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,22FF7C06F60
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,22FF7C06F40
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
       mov       rdx,22FF7C01F50
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
       call      qword ptr [7FF9CF1FB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1FB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,20739E07F58
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20739E07F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,20739E07F58
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
       mov       rdx,20739E02F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,1ECE8806F60
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1ECE8806F40
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
       mov       rdx,1ECE8801F50
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
       call      qword ptr [7FF9CF1CB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1CB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,2678EA93B50
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2678EA93B30
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,2678EA93B50
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
       mov       rdx,267AEA92F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,216B0C04F68
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,216B0C04F48
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
       mov       rdx,216B8C01F50
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
       call      qword ptr [7FF9CF1CB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1CB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,1F9E2245F60
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F9E2245F40
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,1F9E2245F60
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
       mov       rdx,1FA02242F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,273D1406F60
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,273D1406F40
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
       mov       rdx,273D1401F50
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
       call      qword ptr [7FF9CF1BB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1BB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,2155E297F58
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2155E297F38
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,2155E297F58
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
       mov       rdx,2155E292F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,1FE02006F60
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,1FE02006F40
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
       mov       rdx,1FE02001F50
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
       call      qword ptr [7FF9CF1CB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1CB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
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
       mov       rcx,1E5785C5F60
       mov       rbx,[rcx]
       test      rbx,rbx
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E5785C5F40
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)
       mov       [rbx+18],rdx
       mov       rcx,1E5785C5F60
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
       mov       rdx,1E5985C2F38
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

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
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
       mov       rbx,15918006F60
       mov       rbp,[rbx]
       test      rbp,rbp
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester],[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       mov       rdx,15918006F40
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
       mov       rdx,15918001F50
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
       call      qword ptr [7FF9CF1EB780]
       int       3
M00_L02:
       mov       ecx,9
       call      qword ptr [7FF9CF1EB780]
       int       3
; Total bytes of code 254
```
**Method was not JITted yet.**
DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark+<>c.<PersonValOrderByBenchmark>b__14_0(DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord)

