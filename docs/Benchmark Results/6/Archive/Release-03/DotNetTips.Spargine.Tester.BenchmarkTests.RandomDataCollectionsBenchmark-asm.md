## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
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
       mov       ecx,119
       mov       rdx,7FFBD8FB38E0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD90989C8]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBD5685A80]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBD58D98A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBD5609330]
       mov       rdi,rax
       mov       rcx,141E6806480
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBD5609468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBD5476B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBD5476B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBD5603600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBD5609090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBD5609528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBD53DFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBD5273510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBD56090A8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBD5609528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBD5405750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFBD5687018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFBD5603378]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFBD5687198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFBD522BA48]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFBD5687060]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
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
       mov       ecx,119
       mov       rdx,7FFBD8FA38E0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD90889C8]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBD6A15A80]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBD6C69BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBD6999330]
       mov       rdi,rax
       mov       rcx,246E5008C90
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBD6999468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBD6806B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBD6806B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBD6993600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBD6999090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBD6999528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBD676FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBD6603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBD69990A8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBD6999528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBD6795750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFBD6A17018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFBD6993378]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFBD6A17198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFBD65BBA48]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFBD6A17060]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
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
       mov       ecx,119
       mov       rdx,7FFBD8F938E0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD90789C8]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBDAF35A80]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB1898A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAEB9330]
       mov       rdi,rax
       mov       rcx,24E53408C90
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAEB9468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDAD26B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDAD26B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAEB3600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAEB9090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAEB9528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAC8FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDAB23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAEB90A8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBDAEB9528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBDACB5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFBDAF37018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFBDAEB3378]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFBDAF37198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFBDAADBA68]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFBDAF37060]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
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
       mov       ecx,119
       mov       rdx,7FFBD8FC38E0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD90A89C8]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBDAF35A80]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB1898A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAEB9330]
       mov       rdi,rax
       mov       rcx,2428FC008B0
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAEB9468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDAD26B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDAD26B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAEB3600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAEB9090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAEB9528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAC8FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDAB23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAEB90A8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBDAEB9528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBDACB5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFBDAF37018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFBDAEB3378]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFBDAF37198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFBDAADBA68]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFBDAF37060]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
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
       mov       ecx,119
       mov       rdx,7FFBD8FA38E0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD90889C8]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBDAFD5A80]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB2298A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAF59330]
       mov       rdi,rax
       mov       rcx,27BA9004888
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF59468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADC6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADC6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF53600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF59090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF59528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD2FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF590A8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBDAF59528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD55750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFBDAFD7018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFBDAF53378]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFBDAFD7198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFBDAB7BA68]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFBDAFD7060]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
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
       mov       ecx,119
       mov       rdx,7FFBD8FA38E0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD90889C8]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBDAFB5A80]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB2098A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAF39330]
       mov       rdi,rax
       mov       rcx,187EE800098
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF39468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADA6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADA6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF33600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF39090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF39528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD0FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF390A8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBDAF39528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD35750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFBDAFB7018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFBDAF33378]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFBDAFB7198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFBDAB5BB68]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFBDAFB7060]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
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
       mov       ecx,119
       mov       rdx,7FFBD8FD38E0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD90B89C8]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBDAFD5A80]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB251FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAF59330]
       mov       rdi,rax
       mov       rcx,1B7EE8008B0
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF59468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADC6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADC6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF53600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF59090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF59528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD2FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF590A8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBDAF59528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD55750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFBDAFD7018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFBDAF53378]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFBDAFD7198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFBDAB953E8]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFBDAFD7060]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
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
       mov       ecx,119
       mov       rdx,7FFBD8FA38E0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD90889C8]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBDAFE5A80]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB23FFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAF69330]
       mov       rdi,rax
       mov       rcx,18EB0008C90
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF69468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF63600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF69090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF690A8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD65750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFBDAFE7018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFBDAF63378]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFBDAFE7198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFBDABA5A08]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFBDAFE7060]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
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
       mov       ecx,119
       mov       rdx,7FFBD8FC38E0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD90A99A8]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBD56A9DC8]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBD58F9BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBD5629330]
       mov       rdi,rax
       mov       rcx,2781C400098
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBD5629468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBD5496B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBD5496B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBD5623600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBD5629090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBD5629528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBD53FFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBD5293510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBD56290A8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBD5629528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBD5425750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFBD56AB018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFBD5623360]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFBD56AB198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFBD524BA48]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFBD56AB060]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
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
       mov       ecx,119
       mov       rdx,7FFBD8FD38E0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD90B99A8]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBD69F9DC8]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBD6C49BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBD6979330]
       mov       rdi,rax
       mov       rcx,17CD2808C90
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBD6979468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBD67E6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBD67E6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBD6973600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBD6979090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBD6979528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBD674FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBD65E3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBD69790A8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBD6979528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBD6775750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFBD69FB018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFBD6973360]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFBD69FB198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFBD659BA48]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFBD69FB060]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
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
       mov       ecx,119
       mov       rdx,7FFBD8FC38E0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD90A99A8]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBDAF39DC8]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB189BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAEB9330]
       mov       rdi,rax
       mov       rcx,2501E808C90
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAEB9468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDAD26B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDAD26B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAEB3600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAEB9090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAEB9528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAC8FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDAB23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAEB90A8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBDAEB9528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBDACB5750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFBDAF3B018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFBDAEB3360]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFBDAF3B198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFBDAADBA68]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFBDAF3B060]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
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
       mov       ecx,119
       mov       rdx,7FFBD8FC38E0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD90A99A8]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBDAFD9DC8]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB229330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAF59330]
       mov       rdi,rax
       mov       rcx,1A0008008B0
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF59468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADC6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADC6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF53600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF59090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF59528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD2FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF590A8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBDAF59528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD55750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFBDAFDB018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFBDAF53360]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFBDAFDB198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFBDAB7BA68]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFBDAFDB060]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
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
       mov       ecx,119
       mov       rdx,7FFBD8FA38E0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD90899A8]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBDAFE9DC8]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB239BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAF69330]
       mov       rdi,rax
       mov       rcx,1295E800098
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF69468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF63600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF69090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF690A8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD65750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFBDAFEB018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFBDAF63360]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFBDAFEB198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFBDAB8BA68]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFBDAFEB060]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
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
       mov       ecx,119
       mov       rdx,7FFBD8FD38E0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD90B99A8]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBDAFE9DC8]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB2398A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAF69330]
       mov       rdi,rax
       mov       rcx,28408400098
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF69468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF63600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF69090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF690A8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD65750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFBDAFEB018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFBDAF63360]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFBDAFEB198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFBDAB8BB88]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFBDAFEB060]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
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
       mov       ecx,119
       mov       rdx,7FFBD8FA38E0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD90899A8]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBDAFD9DC8]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB251FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAF59330]
       mov       rdi,rax
       mov       rcx,19E48800098
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF59468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADC6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADC6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF53600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF59090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF59528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD2FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF590A8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBDAF59528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD55750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFBDAFDB018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFBDAF53360]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFBDAFDB198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFBDAB953E8]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFBDAFDB060]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
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
       mov       ecx,119
       mov       rdx,7FFBD8FB38E0
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD90999A8]
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBDAFB9DC8]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB231330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAF39330]
       mov       rdi,rax
       mov       rcx,232FB000098
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF39468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADA6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADA6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF33600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF39090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF39528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD0FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF390A8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFBDAF39528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD35750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       edx,esi
       call      qword ptr [7FFBDAFBB018]; System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]..ctor(Int32)
       xor       ebx,ebx
       test      esi,esi
       jle       short M01_L07
M01_L04:
       call      qword ptr [7FFBDAF33360]; DotNetTips.Spargine.Tester.RandomData.GenerateCoordinate[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]]()
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
       call      qword ptr [7FFBDAFBB198]
M01_L06:
       add       ebx,1
       jo        short M01_L09
       cmp       ebx,esi
       jl        short M01_L04
M01_L07:
       mov       rdx,[rdi+8]
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,dword ptr [rdx+8]
       vmulsd    xmm0,xmm0,qword ptr [7FFBDAB759E8]
       vcvttsd2si edx,xmm0
       cmp       [rdi+10],edx
       jge       short M01_L08
       mov       edx,[rdi+10]
       mov       rcx,rdi
       call      qword ptr [7FFBDAFBB060]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
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
       mov       rdx,7FFBD8FA38E0
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
       mov       rdx,7FFBD9188DF8
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
       mov       rdx,7FFBD9188E38
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
       call      qword ptr [7FFBD9137A70]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFBD56BB900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBD5909330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBD5639330]
       mov       rbx,rax
       mov       rcx,251F3C08C90
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFBD5639468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBD54A6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBD54A6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBD5633600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBD5639090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBD5639528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBD540FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBD52A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBD56390A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBD5639528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBD5435750]
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
       mov       rdx,7FFBD56C0E40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFBD5633000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFBD56C0E80
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
       call      qword ptr [7FFBD56313C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBD561D038]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
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
       mov       rdx,7FFBD8FB38E0
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
       mov       rdx,7FFBD9198DF8
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
       mov       rdx,7FFBD9198E38
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
       call      qword ptr [7FFBD9147A70]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFBD69EB900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBD6C398A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBD6969330]
       mov       rbx,rax
       mov       rcx,2B987400098
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFBD6969468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBD67D6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBD67D6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBD6963600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBD6969090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBD6969528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBD673FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBD65D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBD69690A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBD6969528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBD6765750]
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
       mov       rdx,7FFBD69F0E40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFBD6963000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFBD69F0E80
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
       call      qword ptr [7FFBD69613C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBD694D038]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
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
       mov       rdx,7FFBD8F938E0
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
       mov       rdx,7FFBD9178DF8
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
       mov       rdx,7FFBD9178E38
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
       call      qword ptr [7FFBD9127A70]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFBDAF1B900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB169BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAE99330]
       mov       rbx,rax
       mov       rcx,24562000098
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAE99468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDAD06B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDAD06B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAE93600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAE99090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAE99528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAC6FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDAB03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAE990A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBDAE99528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAC95750]
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
       mov       rdx,7FFBDAF20E40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAE93000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFBDAF20E80
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
       call      qword ptr [7FFBDAE913C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAE7D038]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
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
       mov       rdx,7FFBD8FA38E0
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
       mov       rdx,7FFBD9188DF8
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
       mov       rdx,7FFBD9188E38
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
       call      qword ptr [7FFBD9137A70]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFBDAFEB900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB237FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAF69330]
       mov       rbx,rax
       mov       rcx,239C2400098
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF69468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF63600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF69090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF690A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD65750]
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
       mov       rdx,7FFBDAFF0E40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF63000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFBDAFF0E80
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
       call      qword ptr [7FFBDAF613C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF4D038]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
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
       mov       rdx,7FFBD8FA38E0
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
       mov       rdx,7FFBD9188DF8
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
       mov       rdx,7FFBD9188E38
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
       call      qword ptr [7FFBD9137A70]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFBDB8BB900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDBB09BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDB839330]
       mov       rbx,rax
       mov       rcx,229AA408C90
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFBDB839468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDB6A6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDB6A6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDB833600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDB839090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDB839528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDB60FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDB4A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDB8390A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBDB839528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDB635750]
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
       mov       rdx,7FFBDB8C0E40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFBDB833000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFBDB8C0E80
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
       call      qword ptr [7FFBDB8313C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBDB81D038]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
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
       mov       rdx,7FFBD8F938E0
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
       mov       rdx,7FFBD9178DF8
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
       mov       rdx,7FFBD9178E38
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
       call      qword ptr [7FFBD9127A70]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFBDAFCB900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB2198A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAF49330]
       mov       rbx,rax
       mov       rcx,2D65B800098
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF49468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADB6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADB6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF43600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF49090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF49528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD1FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF490A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBDAF49528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD45750]
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
       mov       rdx,7FFBDAFD0E40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF43000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFBDAFD0E80
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
       call      qword ptr [7FFBDAF413C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF2D038]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
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
       mov       rdx,7FFBD8FB38E0
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
       mov       rdx,7FFBD9198DF8
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
       mov       rdx,7FFBD9198E38
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
       call      qword ptr [7FFBD9147A70]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFBDAFCB900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB243330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAF49330]
       mov       rbx,rax
       mov       rcx,2A7D1C00098
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF49468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADB6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADB6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF43600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF49090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF49528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD1FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF490A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBDAF49528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD45750]
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
       mov       rdx,7FFBDAFD0E58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF43000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFBDAFD0E98
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
       call      qword ptr [7FFBDAF413C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF2D038]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
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
       mov       rdx,7FFBD8FB38E0
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
       mov       rdx,7FFBD9198DF8
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
       mov       rdx,7FFBD9198E38
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
       call      qword ptr [7FFBD9147A70]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFBDAFEB900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB261330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAF69330]
       mov       rbx,rax
       mov       rcx,180F0004888
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF69468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF63600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF69090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF690A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD65750]
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
       mov       rdx,7FFBDAFF0E58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF63000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFBDAFF0E98
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
       call      qword ptr [7FFBDAF613C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF4D038]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
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
       mov       rdx,7FFBD8FC38E0
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
       mov       rdx,7FFBD91A8DF8
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
       mov       rdx,7FFBD91A8E38
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
       call      qword ptr [7FFBD9157A70]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFBD56BB900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBD59098A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBD5639330]
       mov       rbx,rax
       mov       rcx,1BF488044A0
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFBD5639468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBD54A6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBD54A6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBD5633600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBD5639090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBD5639528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBD540FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBD52A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBD56390A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBD5639528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBD5435750]
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
       mov       rdx,7FFBD56C0E40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFBD5633000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFBD56C0E80
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
       call      qword ptr [7FFBD56313C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBD561D038]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
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
       mov       rdx,7FFBD8FB38E0
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
       mov       rdx,7FFBD9198DF8
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
       mov       rdx,7FFBD9198E38
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
       call      qword ptr [7FFBD9147A70]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFBD6A0B900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBD6C59BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBD6989330]
       mov       rbx,rax
       mov       rcx,23D6B0044A0
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFBD6989468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBD67F6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBD67F6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBD6983600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBD6989090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBD6989528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBD675FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBD65F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBD69890A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBD6989528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBD6785750]
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
       mov       rdx,7FFBD6A10E40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFBD6983000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFBD6A10E80
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
       call      qword ptr [7FFBD69813C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBD696D038]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
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
       mov       rdx,7FFBD8FB38E0
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
       mov       rdx,7FFBD9198DF8
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
       mov       rdx,7FFBD9198E38
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
       call      qword ptr [7FFBD9147A70]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFBDAF0B900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB159BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAE89330]
       mov       rbx,rax
       mov       rcx,22839008C90
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAE89468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDACF6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDACF6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAE83600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAE89090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAE89528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAC5FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDAAF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAE890A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBDAE89528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAC85750]
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
       mov       rdx,7FFBDAF10E40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAE83000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFBDAF10E80
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
       call      qword ptr [7FFBDAE813C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAE6D038]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
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
       mov       rdx,7FFBD8FA38E0
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
       mov       rdx,7FFBD9188DF8
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
       mov       rdx,7FFBD9188E38
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
       call      qword ptr [7FFBD9137A70]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFBDAFEB900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB2398A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAF69330]
       mov       rbx,rax
       mov       rcx,21E05800098
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF69468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF63600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF69090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF690A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD65750]
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
       mov       rdx,7FFBDAFF0E40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF63000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFBDAFF0E80
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
       call      qword ptr [7FFBDAF613C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF4D038]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
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
       mov       rdx,7FFBD8FA38E0
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
       mov       rdx,7FFBD9188DF8
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
       mov       rdx,7FFBD9188E38
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
       call      qword ptr [7FFBD9137A70]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFBDAFBB900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB207FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAF39330]
       mov       rbx,rax
       mov       rcx,28DE9800098
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF39468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADA6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADA6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF33600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF39090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF39528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD0FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF390A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBDAF39528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD35750]
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
       mov       rdx,7FFBDAFC0E40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF33000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFBDAFC0E80
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
       call      qword ptr [7FFBDAF313C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF1D038]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
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
       mov       rdx,7FFBD8FC38E0
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
       mov       rdx,7FFBD91A8DF8
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
       mov       rdx,7FFBD91A8E38
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
       call      qword ptr [7FFBD9157A70]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFBDAFDB900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB2298A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAF59330]
       mov       rbx,rax
       mov       rcx,1CCEFC00098
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF59468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADC6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADC6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF53600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF59090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF59528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD2FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF590A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBDAF59528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD55750]
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
       mov       rdx,7FFBDAFE0E40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF53000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFBDAFE0E80
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
       call      qword ptr [7FFBDAF513C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF3D038]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
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
       mov       rdx,7FFBD8FC38E0
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
       mov       rdx,7FFBD91A8DF8
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
       mov       rdx,7FFBD91A8E38
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
       call      qword ptr [7FFBD9157A70]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFBDAFEB900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB261FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAF69330]
       mov       rbx,rax
       mov       rcx,15E948024A8
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF69468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF63600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF69090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF690A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD65750]
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
       mov       rdx,7FFBDAFF0E58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF63000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFBDAFF0E98
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
       call      qword ptr [7FFBDAF613C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF4D038]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
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
       mov       rdx,7FFBD8FA38E0
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
       mov       rdx,7FFBD9188DF8
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
       mov       rdx,7FFBD9188E38
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
       call      qword ptr [7FFBD9137A70]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       edx,[rsi+274]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](Int32)
       call      qword ptr [7FFBDAFCB900]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB243330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFBDAF49330]
       mov       rbx,rax
       mov       rcx,214F3C00098
       mov       rcx,[rcx]
       xor       edx,edx
       cmp       dword ptr [rcx+8],0
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF49468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADB6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADB6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF43600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF49090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF49528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD1FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF490A8]
       mov       rdx,rax
       mov       rcx,rbx
       call      qword ptr [7FFBDAF49528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD45750]
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
       mov       rdx,7FFBDAFD0E58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF43000]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]]..ctor()
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
       mov       rdx,7FFBDAFD0E98
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
       call      qword ptr [7FFBDAF413C0]; DotNetTips.Spargine.Tester.RandomData.GenerateRefPerson[[System.__Canon, System.Private.CoreLib]](Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF2D038]; System.Collections.ObjectModel.Collection`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
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
       mov       rdx,7FFBD8FB38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD908D810]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L08
       mov       edx,[r13+10]
       mov       rcx,r13
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      qword ptr [7FFBD5611060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
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
       call      qword ptr [7FFBD5619330]
       mov       r13,rax
       mov       rcx,13A1A400098
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFBD5619468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBD5486B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBD5486B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBD5613600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBD5619090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBD5619528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBD53EFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFBD5283510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBD56190A8]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFBD5619528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBD5415750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      qword ptr [7FFBD52F7918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+44],eax
       test      esi,esi
       jle       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       call      qword ptr [7FFBD561BAB0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+30],rax
       call      qword ptr [7FFBD561B8B8]; System.Globalization.RegionInfo.get_CurrentRegion()
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
       call      qword ptr [7FFBD5611330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD5653078]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      qword ptr [7FFBD5611330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD56530A8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      qword ptr [7FFBD5611330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD56530D8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFBD5611330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD5653108]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFBD5611330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD5653138]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      qword ptr [7FFBD5611210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD5653198]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFBD56111B0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD56531C8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      qword ptr [7FFBD5611330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD56531F8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
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
       call      qword ptr [7FFBD52F7A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD523F708]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L09
       mov       edx,[r13+10]
       mov       rcx,r13
       call      qword ptr [7FFBD52F7960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L09:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
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
       mov       rdx,7FFBD8FC38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD909D810]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L08
       mov       edx,[r13+10]
       mov       rcx,r13
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      qword ptr [7FFBD6981060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
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
       call      qword ptr [7FFBD6989330]
       mov       r13,rax
       mov       rcx,2243C0008B0
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFBD6989468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBD67F6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBD67F6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBD6983600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBD6989090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBD6989528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBD675FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFBD65F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBD69890A8]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFBD6989528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBD6785750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      qword ptr [7FFBD6667918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+44],eax
       test      esi,esi
       jle       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       call      qword ptr [7FFBD698BAB0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+30],rax
       call      qword ptr [7FFBD698B8B8]; System.Globalization.RegionInfo.get_CurrentRegion()
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
       call      qword ptr [7FFBD6981330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD69C3078]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      qword ptr [7FFBD6981330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD69C30A8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      qword ptr [7FFBD6981330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD69C30D8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFBD6981330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD69C3108]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFBD6981330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD69C3138]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      qword ptr [7FFBD6981210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD69C3198]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFBD69811B0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD69C31C8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      qword ptr [7FFBD6981330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD69C31F8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
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
       call      qword ptr [7FFBD6667A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD65AF708]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L09
       mov       edx,[r13+10]
       mov       rcx,r13
       call      qword ptr [7FFBD6667960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L09:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
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
       mov       rdx,7FFBD8FA38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD907D810]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L08
       mov       edx,[r13+10]
       mov       rcx,r13
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      qword ptr [7FFBD6991060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
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
       call      qword ptr [7FFBD6999330]
       mov       r13,rax
       mov       rcx,20FB9404888
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFBD6999468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBD6806B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBD6806B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBD6993600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBD6999090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBD6999528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBD676FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFBD6603510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBD69990A8]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFBD6999528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBD6795750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      qword ptr [7FFBD6677918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+44],eax
       test      esi,esi
       jle       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       call      qword ptr [7FFBD699BAB0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+30],rax
       call      qword ptr [7FFBD699B8B8]; System.Globalization.RegionInfo.get_CurrentRegion()
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
       call      qword ptr [7FFBD6991330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD69D3078]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      qword ptr [7FFBD6991330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD69D30A8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      qword ptr [7FFBD6991330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD69D30D8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFBD6991330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD69D3108]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFBD6991330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD69D3138]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      qword ptr [7FFBD6991210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD69D3198]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFBD69911B0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD69D31C8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      qword ptr [7FFBD6991330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBD69D31F8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
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
       call      qword ptr [7FFBD6677A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD65BF708]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L09
       mov       edx,[r13+10]
       mov       rcx,r13
       call      qword ptr [7FFBD6677960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L09:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
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
       mov       rdx,7FFBD8FA38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD907D810]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L08
       mov       edx,[r13+10]
       mov       rcx,r13
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      qword ptr [7FFBDAEB1060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
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
       call      qword ptr [7FFBDAEB9330]
       mov       r13,rax
       mov       rcx,1B61E400098
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFBDAEB9468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDAD26B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDAD26B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAEB3600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAEB9090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAEB9528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAC8FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFBDAB23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAEB90A8]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFBDAEB9528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDACB5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      qword ptr [7FFBDAB97918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+44],eax
       test      esi,esi
       jle       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       call      qword ptr [7FFBDAEBBAB0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+30],rax
       call      qword ptr [7FFBDAEBB8B8]; System.Globalization.RegionInfo.get_CurrentRegion()
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
       call      qword ptr [7FFBDAEB1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAEF3078]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      qword ptr [7FFBDAEB1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAEF30A8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      qword ptr [7FFBDAEB1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAEF30D8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFBDAEB1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAEF3108]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFBDAEB1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAEF3138]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      qword ptr [7FFBDAEB1210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAEF3198]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFBDAEB11B0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAEF31C8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      qword ptr [7FFBDAEB1330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAEF31F8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
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
       call      qword ptr [7FFBDAB97A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBDAADF6E8]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L09
       mov       edx,[r13+10]
       mov       rcx,r13
       call      qword ptr [7FFBDAB97960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L09:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
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
       mov       rdx,7FFBD8FA38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD907D810]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L08
       mov       edx,[r13+10]
       mov       rcx,r13
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      qword ptr [7FFBDAF61060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
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
       call      qword ptr [7FFBDAF69330]
       mov       r13,rax
       mov       rcx,25F0C408478
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFBDAF69468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF63600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF69090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFBDABD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF690A8]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD65750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      qword ptr [7FFBDAC47918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+44],eax
       test      esi,esi
       jle       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       call      qword ptr [7FFBDAF6BAB0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+30],rax
       call      qword ptr [7FFBDAF6B8B8]; System.Globalization.RegionInfo.get_CurrentRegion()
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
       call      qword ptr [7FFBDAF61330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA3078]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      qword ptr [7FFBDAF61330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA30A8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      qword ptr [7FFBDAF61330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA30D8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFBDAF61330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA3108]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFBDAF61330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA3138]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      qword ptr [7FFBDAF61210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA3198]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFBDAF611B0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA31C8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      qword ptr [7FFBDAF61330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA31F8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
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
       call      qword ptr [7FFBDAC47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBDAB8F728]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L09
       mov       edx,[r13+10]
       mov       rcx,r13
       call      qword ptr [7FFBDAC47960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L09:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
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
       mov       rdx,7FFBD8FA38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD907D810]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L08
       mov       edx,[r13+10]
       mov       rcx,r13
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      qword ptr [7FFBDAF61060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
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
       call      qword ptr [7FFBDAF69330]
       mov       r13,rax
       mov       rcx,163C3400098
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFBDAF69468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF63600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF69090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFBDABD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF690A8]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD65750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      qword ptr [7FFBDAC47918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+44],eax
       test      esi,esi
       jle       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       call      qword ptr [7FFBDAF6BAB0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+30],rax
       call      qword ptr [7FFBDAF6B8B8]; System.Globalization.RegionInfo.get_CurrentRegion()
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
       call      qword ptr [7FFBDAF61330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA3078]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      qword ptr [7FFBDAF61330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA30A8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      qword ptr [7FFBDAF61330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA30D8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFBDAF61330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA3108]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFBDAF61330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA3138]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      qword ptr [7FFBDAF61210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA3198]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFBDAF611B0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA31C8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      qword ptr [7FFBDAF61330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA31F8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
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
       call      qword ptr [7FFBDAC47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBDAB8F708]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L09
       mov       edx,[r13+10]
       mov       rcx,r13
       call      qword ptr [7FFBDAC47960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L09:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
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
       mov       rdx,7FFBD8FC38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD909D810]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L08
       mov       edx,[r13+10]
       mov       rcx,r13
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      qword ptr [7FFBDAF51060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
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
       call      qword ptr [7FFBDAF59330]
       mov       r13,rax
       mov       rcx,15C20000098
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFBDAF59468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADC6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADC6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF53600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF59090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF59528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD2FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFBDABC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF590A8]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFBDAF59528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD55750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      qword ptr [7FFBDAC37918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+44],eax
       test      esi,esi
       jle       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       call      qword ptr [7FFBDAF5BAB0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+30],rax
       call      qword ptr [7FFBDAF5B8B8]; System.Globalization.RegionInfo.get_CurrentRegion()
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
       call      qword ptr [7FFBDAF51330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAF93078]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      qword ptr [7FFBDAF51330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAF930A8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      qword ptr [7FFBDAF51330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAF930D8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFBDAF51330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAF93108]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFBDAF51330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAF93138]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      qword ptr [7FFBDAF51210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAF93198]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFBDAF511B0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAF931C8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      qword ptr [7FFBDAF51330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAF931F8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
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
       call      qword ptr [7FFBDAC37A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBDAB7F708]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L09
       mov       edx,[r13+10]
       mov       rcx,r13
       call      qword ptr [7FFBDAC37960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L09:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
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
       mov       rdx,7FFBD8FC38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBD909D810]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L08
       mov       edx,[r13+10]
       mov       rcx,r13
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L08:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      qword ptr [7FFBDAF61060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
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
       call      qword ptr [7FFBDAF69330]
       mov       r13,rax
       mov       rcx,28BEF0008B0
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFBDAF69468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF63600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF69090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFBDABD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF690A8]
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD65750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       rcx,r13
       mov       edx,esi
       call      qword ptr [7FFBDAC47918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       xor       eax,eax
       mov       [rsp+44],eax
       test      esi,esi
       jle       near ptr M01_L08
M01_L05:
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+38],rax
       call      qword ptr [7FFBDAF6BAB0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+30],rax
       call      qword ptr [7FFBDAF6B8B8]; System.Globalization.RegionInfo.get_CurrentRegion()
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
       call      qword ptr [7FFBDAF61330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA3078]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address1(System.String)
       mov       ecx,edi
       call      qword ptr [7FFBDAF61330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA30A8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Address2(System.String)
       mov       ecx,ebx
       call      qword ptr [7FFBDAF61330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA30D8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_City(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFBDAF61330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA3108]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Country(System.String)
       mov       ecx,r14d
       call      qword ptr [7FFBDAF61330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA3138]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_CountyProvince(System.String)
       call      qword ptr [7FFBDAF61210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA3198]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_Phone(System.String)
       mov       ecx,r15d
       call      qword ptr [7FFBDAF611B0]; DotNetTips.Spargine.Tester.RandomData.GenerateNumber(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA31C8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_PostalCode(System.String)
       mov       ecx,r12d
       call      qword ptr [7FFBDAF61330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+38]
       call      qword ptr [7FFBDAFA31F8]; DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord.set_State(System.String)
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
       call      qword ptr [7FFBDAC47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
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
       vmulsd    xmm0,xmm0,qword ptr [7FFBDAB6A568]
       vcvttsd2si edx,xmm0
       cmp       [r13+10],edx
       jge       short M01_L09
       mov       edx,[r13+10]
       mov       rcx,r13
       call      qword ptr [7FFBDAC47960]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].set_Capacity(Int32)
M01_L09:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.AddressRecord, DotNetTips.Spargine.6.Tester]]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,2
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
       mov       rdx,7FFBD8FA38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFBD8E14928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2C456B82F38
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
       mov       r11,7FFBD8D10340
       call      qword ptr [7FFBD8D10340]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFBD8D10348
       call      qword ptr [7FFBD8D10348]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFBD8D10350
       call      qword ptr [7FFBD8D10350]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,2
       mov       r8d,0F
       mov       r9d,19
       call      qword ptr [7FFBD56111C8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
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
       call      qword ptr [7FFBD5619330]
       mov       r12,rax
       mov       rcx,186E1C04888
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBD5619468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBD5486B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBD5486B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBD5613600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBD5619090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBD5619528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBD53EFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBD5283510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBD56190A8]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFBD5619528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBD5415750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,186DFC01F70
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
       call      qword ptr [7FFBD5611120]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      qword ptr [7FFBD561BAB0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      qword ptr [7FFBD5611B40]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBD5473918]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      qword ptr [7FFBD5493750]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [7FFBD5611180]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       call      qword ptr [7FFBD5473450]; System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
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
       call      qword ptr [7FFBD5493048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      qword ptr [7FFBD5611AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      qword ptr [7FFBD5611330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBD5611B70]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      qword ptr [7FFBD5611210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBD5611BA0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFBD5611330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBD5611C00]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      qword ptr [7FFBD5611210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBD5611B10]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      qword ptr [7FFBD5611060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFBD50408B0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFBD50408B8
       call      qword ptr [r11]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFBD50408C0
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
       call      qword ptr [7FFBD5471180]
       int       3
M01_L08:
       xor       ecx,ecx
       call      qword ptr [7FFBD54711E0]
       int       3
M01_L09:
       call      qword ptr [7FFBD5447678]
       int       3
M01_L10:
       mov       ecx,7
       call      qword ptr [7FFBD54478E8]
       int       3
; Total bytes of code 1308
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,2
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
       mov       rdx,7FFBD8FA38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFBD8E14928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,20CA7E52F38
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
       mov       r11,7FFBD8D10340
       call      qword ptr [7FFBD8D10340]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFBD8D10348
       call      qword ptr [7FFBD8D10348]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFBD8D10350
       call      qword ptr [7FFBD8D10350]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,2
       mov       r8d,0F
       mov       r9d,19
       call      qword ptr [7FFBD69611C8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
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
       call      qword ptr [7FFBD6969330]
       mov       r12,rax
       mov       rcx,21DD0C008B0
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBD6969468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBD67D6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBD67D6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBD6963600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBD6969090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBD6969528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBD673FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBD65D3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBD69690A8]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFBD6969528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBD6765750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,21DCEC01F70
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
       call      qword ptr [7FFBD6961120]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      qword ptr [7FFBD696BAB0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      qword ptr [7FFBD6961B40]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBD67C3918]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      qword ptr [7FFBD67E3750]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [7FFBD6961180]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       call      qword ptr [7FFBD67C3450]; System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
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
       call      qword ptr [7FFBD67E3048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      qword ptr [7FFBD6961AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      qword ptr [7FFBD6961330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBD6961B70]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      qword ptr [7FFBD6961210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBD6961BA0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFBD6961330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBD6961C00]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      qword ptr [7FFBD6961210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBD6961B10]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      qword ptr [7FFBD6961060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFBD63908B0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFBD63908B8
       call      qword ptr [r11]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFBD63908C0
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
       call      qword ptr [7FFBD67C1180]
       int       3
M01_L08:
       xor       ecx,ecx
       call      qword ptr [7FFBD67C11E0]
       int       3
M01_L09:
       call      qword ptr [7FFBD6797678]
       int       3
M01_L10:
       mov       ecx,7
       call      qword ptr [7FFBD67978E8]
       int       3
; Total bytes of code 1308
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,2
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
       mov       rdx,7FFBD8FB38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFBD8E24928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,181AFB12F38
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
       mov       r11,7FFBD8D20340
       call      qword ptr [7FFBD8D20340]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFBD8D20348
       call      qword ptr [7FFBD8D20348]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFBD8D20350
       call      qword ptr [7FFBD8D20350]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,2
       mov       r8d,0F
       mov       r9d,19
       call      qword ptr [7FFBDAE911C8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
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
       call      qword ptr [7FFBDAE99330]
       mov       r12,rax
       mov       rcx,1A998C08478
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAE99468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDAD06B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDAD06B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAE93600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAE99090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAE99528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAC6FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDAB03510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAE990A8]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFBDAE99528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAC95750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,1A998C01F70
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
       call      qword ptr [7FFBDAE91120]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      qword ptr [7FFBDAE9BAB0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      qword ptr [7FFBDAE91B40]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBDACF3918]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      qword ptr [7FFBDAD13750]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [7FFBDAE91180]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       call      qword ptr [7FFBDACF3450]; System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
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
       call      qword ptr [7FFBDAD13048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      qword ptr [7FFBDAE91AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      qword ptr [7FFBDAE91330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAE91B70]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      qword ptr [7FFBDAE91210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAE91BA0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFBDAE91330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAE91C00]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      qword ptr [7FFBDAE91210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAE91B10]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      qword ptr [7FFBDAE91060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFBDA8C08B0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFBDA8C08B8
       call      qword ptr [r11]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFBDA8C08C0
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
       call      qword ptr [7FFBDACF1180]
       int       3
M01_L08:
       xor       ecx,ecx
       call      qword ptr [7FFBDACF11E0]
       int       3
M01_L09:
       call      qword ptr [7FFBDACC7678]
       int       3
M01_L10:
       mov       ecx,7
       call      qword ptr [7FFBDACC78E8]
       int       3
; Total bytes of code 1308
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,2
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
       mov       rdx,7FFBD8FA38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFBD8E14928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,208865E2F38
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
       mov       r11,7FFBD8D10340
       call      qword ptr [7FFBD8D10340]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFBD8D10348
       call      qword ptr [7FFBD8D10348]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFBD8D10350
       call      qword ptr [7FFBD8D10350]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,2
       mov       r8d,0F
       mov       r9d,19
       call      qword ptr [7FFBDAF311C8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
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
       call      qword ptr [7FFBDAF39330]
       mov       r12,rax
       mov       rcx,1F1FE000098
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF39468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADA6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADA6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF33600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF39090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF39528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD0FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF390A8]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFBDAF39528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD35750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,1F1FC001F70
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
       call      qword ptr [7FFBDAF31120]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      qword ptr [7FFBDAF3BAB0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      qword ptr [7FFBDAF31B40]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBDAD93918]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      qword ptr [7FFBDADB3750]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [7FFBDAF31180]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       call      qword ptr [7FFBDAD93450]; System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
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
       call      qword ptr [7FFBDADB3048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      qword ptr [7FFBDAF31AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      qword ptr [7FFBDAF31330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF31B70]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      qword ptr [7FFBDAF31210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF31BA0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFBDAF31330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF31C00]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      qword ptr [7FFBDAF31210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF31B10]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      qword ptr [7FFBDAF31060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFBDA9608B0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFBDA9608B8
       call      qword ptr [r11]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFBDA9608C0
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
       call      qword ptr [7FFBDAD91180]
       int       3
M01_L08:
       xor       ecx,ecx
       call      qword ptr [7FFBDAD911E0]
       int       3
M01_L09:
       call      qword ptr [7FFBDAD67678]
       int       3
M01_L10:
       mov       ecx,7
       call      qword ptr [7FFBDAD678E8]
       int       3
; Total bytes of code 1308
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,2
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
       mov       rdx,7FFBD8FA38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFBD8E14928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1641A532F38
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
       mov       r11,7FFBD8D10340
       call      qword ptr [7FFBD8D10340]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFBD8D10348
       call      qword ptr [7FFBD8D10348]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFBD8D10350
       call      qword ptr [7FFBD8D10350]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,2
       mov       r8d,0F
       mov       r9d,19
       call      qword ptr [7FFBDAF411C8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
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
       call      qword ptr [7FFBDAF49330]
       mov       r12,rax
       mov       rcx,293D9C04888
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF49468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADB6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADB6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF43600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF49090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF49528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD1FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF490A8]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFBDAF49528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD45750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,293D7C01F70
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
       call      qword ptr [7FFBDAF41120]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      qword ptr [7FFBDAF4BAB0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      qword ptr [7FFBDAF41B40]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBDADA3918]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      qword ptr [7FFBDADC3750]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [7FFBDAF41180]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       call      qword ptr [7FFBDADA3450]; System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
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
       call      qword ptr [7FFBDADC3048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      qword ptr [7FFBDAF41AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      qword ptr [7FFBDAF41330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF41B70]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      qword ptr [7FFBDAF41210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF41BA0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFBDAF41330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF41C00]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      qword ptr [7FFBDAF41210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF41B10]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      qword ptr [7FFBDAF41060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFBDA9708B0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFBDA9708B8
       call      qword ptr [r11]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFBDA9708C0
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
       call      qword ptr [7FFBDADA1180]
       int       3
M01_L08:
       xor       ecx,ecx
       call      qword ptr [7FFBDADA11E0]
       int       3
M01_L09:
       call      qword ptr [7FFBDAD77678]
       int       3
M01_L10:
       mov       ecx,7
       call      qword ptr [7FFBDAD778E8]
       int       3
; Total bytes of code 1308
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,2
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
       mov       rdx,7FFBD8FC38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFBD8E34928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,16B54DE2F38
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
       mov       r11,7FFBD8D30340
       call      qword ptr [7FFBD8D30340]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFBD8D30348
       call      qword ptr [7FFBD8D30348]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFBD8D30350
       call      qword ptr [7FFBD8D30350]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,2
       mov       r8d,0F
       mov       r9d,19
       call      qword ptr [7FFBDAF311C8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
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
       call      qword ptr [7FFBDAF39330]
       mov       r12,rax
       mov       rcx,2A77D400098
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF39468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADA6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADA6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF33600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF39090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF39528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD0FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF390A8]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFBDAF39528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD35750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,2A77B401F70
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
       call      qword ptr [7FFBDAF31120]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      qword ptr [7FFBDAF3BAB0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      qword ptr [7FFBDAF31B40]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBDAD93918]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      qword ptr [7FFBDADB3750]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [7FFBDAF31180]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       call      qword ptr [7FFBDAD93450]; System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
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
       call      qword ptr [7FFBDADB3048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      qword ptr [7FFBDAF31AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      qword ptr [7FFBDAF31330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF31B70]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      qword ptr [7FFBDAF31210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF31BA0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFBDAF31330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF31C00]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      qword ptr [7FFBDAF31210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF31B10]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      qword ptr [7FFBDAF31060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFBDA9608B0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFBDA9608B8
       call      qword ptr [r11]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFBDA9608C0
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
       call      qword ptr [7FFBDAD91180]
       int       3
M01_L08:
       xor       ecx,ecx
       call      qword ptr [7FFBDAD911E0]
       int       3
M01_L09:
       call      qword ptr [7FFBDAD67678]
       int       3
M01_L10:
       mov       ecx,7
       call      qword ptr [7FFBDAD678E8]
       int       3
; Total bytes of code 1308
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,2
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
       mov       rdx,7FFBD8FA38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFBD8E14928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,22D4C5A2F38
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
       mov       r11,7FFBD8D10340
       call      qword ptr [7FFBD8D10340]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFBD8D10348
       call      qword ptr [7FFBD8D10348]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFBD8D10350
       call      qword ptr [7FFBD8D10350]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,2
       mov       r8d,0F
       mov       r9d,19
       call      qword ptr [7FFBDAF711C8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
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
       call      qword ptr [7FFBDAF79330]
       mov       r12,rax
       mov       rcx,1EFBA800098
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF79468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADE6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADE6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF73600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF79090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF79528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD4FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF790A8]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFBDAF79528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD75750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,1EFBC801F70
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
       call      qword ptr [7FFBDAF71120]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      qword ptr [7FFBDAF7BAB0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      qword ptr [7FFBDAF71B40]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBDADD3918]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      qword ptr [7FFBDADF3750]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [7FFBDAF71180]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       call      qword ptr [7FFBDADD3450]; System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
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
       call      qword ptr [7FFBDADF3048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      qword ptr [7FFBDAF71AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      qword ptr [7FFBDAF71330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF71B70]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      qword ptr [7FFBDAF71210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF71BA0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFBDAF71330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF71C00]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      qword ptr [7FFBDAF71210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF71B10]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      qword ptr [7FFBDAF71060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFBDA9A09C8
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFBDA9A09D0
       call      qword ptr [r11]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFBDA9A09D8
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
       call      qword ptr [7FFBDADD1180]
       int       3
M01_L08:
       xor       ecx,ecx
       call      qword ptr [7FFBDADD11E0]
       int       3
M01_L09:
       call      qword ptr [7FFBDADA7678]
       int       3
M01_L10:
       mov       ecx,7
       call      qword ptr [7FFBDADA78E8]
       int       3
; Total bytes of code 1308
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,2
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
       mov       rdx,7FFBD8FB38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L02:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rcx,7FFBD8E24928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1662E0C2F38
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
       mov       r11,7FFBD8D20340
       call      qword ptr [7FFBD8D20340]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFBD8D20348
       call      qword ptr [7FFBD8D20348]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFBD8D20350
       call      qword ptr [7FFBD8D20350]
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
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
       mov       ecx,[rsi+274]
       mov       edx,2
       mov       r8d,0F
       mov       r9d,19
       call      qword ptr [7FFBDAF511C8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
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
       call      qword ptr [7FFBDAF59330]
       mov       r12,rax
       mov       rcx,12AB8C00098
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFBDAF59468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADC6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADC6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF53600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF59090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF59528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD2FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       mov       edx,3
       call      qword ptr [7FFBDABC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF590A8]
       mov       rdx,rax
       mov       rcx,r12
       call      qword ptr [7FFBDAF59528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD55750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+60],rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+48],rax
       mov       rdx,12ABCC01F70
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
       call      qword ptr [7FFBDAF51120]; DotNetTips.Spargine.Tester.RandomData.GenerateEmailAddress()
       mov       [rsp+58],rax
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord
       call      CORINFO_HELP_NEWSFAST
       mov       [rsp+50],rax
       call      qword ptr [7FFBDAF5BAB0]; DotNetTips.Spargine.Core.KeyGenerator.GenerateKey()
       mov       [rsp+40],rax
       mov       rcx,[rsp+50]
       mov       rdx,[rsp+58]
       call      qword ptr [7FFBDAF51B40]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_Email(System.String)
       mov       rax,[rsp+50]
       lea       rcx,[rax+38]
       mov       rdx,[rsp+40]
       call      CORINFO_HELP_ASSIGN_REF
       call      qword ptr [7FFBDADB3918]; System.DateTime.get_UtcNow()
       mov       rdx,rax
       lea       rcx,[rsp+0B0]
       mov       r8d,1
       call      qword ptr [7FFBDADD3750]; System.DateTimeOffset.ToLocalTime(System.DateTime, Boolean)
       mov       ecx,1
       mov       edx,4B
       call      qword ptr [7FFBDAF51180]; DotNetTips.Spargine.Tester.RandomData.GenerateInteger(Int32, Int32)
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
       call      qword ptr [7FFBDADB3450]; System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
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
       call      qword ptr [7FFBDADD3048]; System.DateTimeOffset..ctor(System.DateTime, System.TimeSpan)
       vmovupd   xmm0,[rsp+90]
       vmovupd   [rsp+0A0],xmm0
       vmovupd   xmm0,[rsp+0A0]
       vmovupd   [rsp+78],xmm0
       mov       rcx,[rsp+50]
       lea       rdx,[rsp+78]
       call      qword ptr [7FFBDAF51AE0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_BornOn(System.DateTimeOffset)
       mov       ecx,ebx
       call      qword ptr [7FFBDAF51330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF51B70]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_FirstName(System.String)
       call      qword ptr [7FFBDAF51210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF51BA0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_HomePhone(System.String)
       mov       ecx,ebp
       call      qword ptr [7FFBDAF51330]; DotNetTips.Spargine.Tester.RandomData.GenerateWord(Int32)
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF51C00]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_LastName(System.String)
       call      qword ptr [7FFBDAF51210]; DotNetTips.Spargine.Tester.RandomData.GeneratePhoneNumberUSA()
       mov       rdx,rax
       mov       rcx,[rsp+50]
       call      qword ptr [7FFBDAF51B10]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord.set_CellPhone(System.String)
       mov       [rsp+20],r13d
       mov       eax,[rsp+150]
       mov       [rsp+28],eax
       mov       r10d,[rsp+158]
       mov       [rsp+30],r10d
       mov       ecx,edi
       mov       edx,r14d
       mov       r8d,r15d
       mov       r9d,r12d
       call      qword ptr [7FFBDAF51060]; DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       r8,[rsp+50]
       lea       rcx,[r8+30]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rsp+50]
       mov       [rsp+68],rax
       mov       rdx,[rsp+70]
       mov       rcx,[rdx+8]
       mov       r11,7FFBDA980AA0
       call      qword ptr [r11]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FFBDA980AA8
       call      qword ptr [r11]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FFBDA980AB0
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
       call      qword ptr [7FFBDADB1180]
       int       3
M01_L08:
       xor       ecx,ecx
       call      qword ptr [7FFBDADB11E0]
       int       3
M01_L09:
       call      qword ptr [7FFBDAD87678]
       int       3
M01_L10:
       mov       ecx,7
       call      qword ptr [7FFBDAD878E8]
       int       3
; Total bytes of code 1308
```

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
       mov       rdx,7FFBD8F938E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2771B652F78
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
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFBD8D008D0
       call      qword ptr [7FFBD8D008D0]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFBD8D008D8
       call      qword ptr [7FFBD8D008D8]
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
       mov       r11,7FFBD8D008E0
       call      qword ptr [7FFBD8D008E0]
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
; Total bytes of code 490
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBD56211F8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBD58F9BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
       call      qword ptr [7FFBD5629330]
       mov       r14,rax
       mov       rcx,23D8C008C90
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFBD5629468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBD5496B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBD5496B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBD5623600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBD5629090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBD5629528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBD53FFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFBD5293510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBD56290A8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBD5629528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBD5425750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,23D8C001FB0
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
       call      qword ptr [7FFBD5621318]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFBD50508B0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[r14+8]
       mov       r11,7FFBD50508B8
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
       mov       r11,7FFBD50508C0
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
       call      qword ptr [7FFBD54578E8]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
       mov       rdx,7FFBD8FB38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1C57CC22F78
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
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFBD8D208D0
       call      qword ptr [7FFBD8D208D0]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFBD8D208D8
       call      qword ptr [7FFBD8D208D8]
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
       mov       r11,7FFBD8D208E0
       call      qword ptr [7FFBD8D208E0]
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
; Total bytes of code 490
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBD69811F8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBD6C57FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
       call      qword ptr [7FFBD6989330]
       mov       r14,rax
       mov       rcx,16B56400098
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFBD6989468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBD67F6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBD67F6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBD6983600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBD6989090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBD6989528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBD675FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFBD65F3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBD69890A8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBD6989528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBD6785750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,16B52401FB0
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
       call      qword ptr [7FFBD6981318]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFBD63B08B0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[r14+8]
       mov       r11,7FFBD63B08B8
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
       mov       r11,7FFBD63B08C0
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
       call      qword ptr [7FFBD67B78E8]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
       mov       rdx,7FFBD8FA38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,2C0212B2F78
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
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFBD8D108D0
       call      qword ptr [7FFBD8D108D0]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFBD8D108D8
       call      qword ptr [7FFBD8D108D8]
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
       mov       r11,7FFBD8D108E0
       call      qword ptr [7FFBD8D108E0]
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
; Total bytes of code 490
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBDAEB11F8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB1898A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
       call      qword ptr [7FFBDAEB9330]
       mov       r14,rax
       mov       rcx,177388008B0
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFBDAEB9468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDAD26B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDAD26B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAEB3600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAEB9090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAEB9528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAC8FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFBDAB23510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAEB90A8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAEB9528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDACB5750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,17736801FB0
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
       call      qword ptr [7FFBDAEB1318]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFBDA8E08B0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[r14+8]
       mov       r11,7FFBDA8E08B8
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
       mov       r11,7FFBDA8E08C0
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
       call      qword ptr [7FFBDACE78E8]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
       mov       rdx,7FFBD8F938E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1A4080F2F78
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
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFBD8D008D0
       call      qword ptr [7FFBD8D008D0]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFBD8D008D8
       call      qword ptr [7FFBD8D008D8]
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
       mov       r11,7FFBD8D008E0
       call      qword ptr [7FFBD8D008E0]
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
; Total bytes of code 490
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBDAF511F8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB2298A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
       call      qword ptr [7FFBDAF59330]
       mov       r14,rax
       mov       rcx,270FA404070
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFBDAF59468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADC6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADC6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF53600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF59090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF59528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD2FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFBDABC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF590A8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF59528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD55750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,270FC401FB0
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
       call      qword ptr [7FFBDAF51318]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFBDA9808B0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[r14+8]
       mov       r11,7FFBDA9808B8
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
       mov       r11,7FFBDA9808C0
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
       call      qword ptr [7FFBDAD878E8]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
       mov       rdx,7FFBD8FA38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1ED2BC52F78
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
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFBD8D108D0
       call      qword ptr [7FFBD8D108D0]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFBD8D108D8
       call      qword ptr [7FFBD8D108D8]
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
       mov       r11,7FFBD8D108E0
       call      qword ptr [7FFBD8D108E0]
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
; Total bytes of code 490
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBDB8511F8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDBB298A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
       call      qword ptr [7FFBDB859330]
       mov       r14,rax
       mov       rcx,21976C04CB8
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFBDB859468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDB6C6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDB6C6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDB853600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDB859090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDB859528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDB62FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFBDB4C3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDB8590A8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBDB859528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDB655750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,21976C01FB0
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
       call      qword ptr [7FFBDB851318]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFBDB2808B0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[r14+8]
       mov       r11,7FFBDB2808B8
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
       mov       r11,7FFBDB2808C0
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
       call      qword ptr [7FFBDB6878E8]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
       mov       rdx,7FFBD8FD38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,27F950A2F78
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
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFBD8D408D0
       call      qword ptr [7FFBD8D408D0]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFBD8D408D8
       call      qword ptr [7FFBD8D408D8]
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
       mov       r11,7FFBD8D408E0
       call      qword ptr [7FFBD8D408E0]
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
; Total bytes of code 490
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBDAF611F8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB239BA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
       call      qword ptr [7FFBDAF69330]
       mov       r14,rax
       mov       rcx,27556400098
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFBDAF69468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF63600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF69090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFBDABD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF690A8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD65750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,27558401FB0
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
       call      qword ptr [7FFBDAF61318]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFBDA9908B0
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[r14+8]
       mov       r11,7FFBDA9908B8
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
       mov       r11,7FFBDA9908C0
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
       call      qword ptr [7FFBDAD978E8]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
       mov       rdx,7FFBD8FB38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,26FEC6C2F80
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
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFBD8D208E0
       call      qword ptr [7FFBD8D208E0]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFBD8D208E8
       call      qword ptr [7FFBD8D208E8]
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
       mov       r11,7FFBD8D208F0
       call      qword ptr [7FFBD8D208F0]
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
; Total bytes of code 490
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBDAF611F8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB261FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
       call      qword ptr [7FFBDAF69330]
       mov       r14,rax
       mov       rcx,18745C00098
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFBDAF69468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADD6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF63600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF69090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD3FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFBDABD3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF690A8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF69528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD65750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,18741C01FB0
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
       call      qword ptr [7FFBDAF61318]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFBDA990968
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[r14+8]
       mov       r11,7FFBDA990970
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
       mov       r11,7FFBDA990978
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
       call      qword ptr [7FFBDAD978E8]
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

## .NET 6.0.11 (6.0.1122.52304), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
       mov       rdx,7FFBD8FA38E0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbx
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1AFE8842F80
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
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFBD8D10960
       call      qword ptr [7FFBD8D10960]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FFBD8D10968
       call      qword ptr [7FFBD8D10968]
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
       mov       r11,7FFBD8D10970
       call      qword ptr [7FFBD8D10970]
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
; Total bytes of code 490
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

## .NET 7.0.0 (7.0.22.51805), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       ecx,[rsi+274]
       call      qword ptr [7FFBDAF411F8]; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.ObjectModel.Collection`1<DotNetTips.Spargine.Tester.Models.ValueTypes.Person> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFBDB21FFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
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
       call      qword ptr [7FFBDAF49330]
       mov       r14,rax
       mov       rcx,15E8CC00098
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      qword ptr [7FFBDAF49468]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFBDADB6B50
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFBDADB6B50
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFBDAF43600]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFBDAF49090]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFBDAF49528]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFBDAD1FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L03:
       mov       edx,3
       call      qword ptr [7FFBDABB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFBDAF490A8]
       mov       rdx,rax
       mov       rcx,r14
       call      qword ptr [7FFBDAF49528]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFBDAD45750]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L04:
       mov       rcx,offset MT_System.Collections.ObjectModel.Collection`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.ValueTypes.Person, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,15E8EC01FB8
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
       call      qword ptr [7FFBDAF41318]; DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp-118]
       lea       rsi,[rbp-0A8]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FFBDA970A08
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L08
       mov       rcx,[r14+8]
       mov       r11,7FFBDA970A10
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
       mov       r11,7FFBDA970A18
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
       call      qword ptr [7FFBDAD778E8]
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

