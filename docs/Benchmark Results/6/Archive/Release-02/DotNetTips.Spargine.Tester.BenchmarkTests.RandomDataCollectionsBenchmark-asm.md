## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       rdx,7FF8945C6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894681408]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       rdx,7FF8945D6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894691408]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       rdx,7FF8945E6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF8946A1408]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       rdx,7FF8945C6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894681408]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       rdx,7FF8945C6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894681408]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       rdx,7FF8945D6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894691408]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       rdx,7FF8945B6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894671408]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.Coordinate, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       rdx,7FF8945B6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894671408]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       rdx,7FF8945C6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894682648]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       rdx,7FF8945D6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894692648]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       rdx,7FF8945B6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894672648]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       rdx,7FF8945C6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894682648]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       rdx,7FF8945D6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894692648]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       rdx,7FF8945B6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894672648]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       rdx,7FF8945D6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894692648]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateCoordinateProperCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GenerateCoordinateCollection[[DotNetTips.Spargine.Tester.Models.ValueTypes.CoordinateProper, DotNetTips.Spargine.6.Tester]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       rdx,7FF8945E6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF8946A2648]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection(Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       [rbp+0FFD0],rcx
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
       mov       rdx,7FF8945C6D08
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
       mov       rdx,7FF894771A38
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
       mov       rdx,7FF894771A78
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
       call      qword ptr [7FF8946932E0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection(Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       [rbp+0FFD0],rcx
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
       mov       rdx,7FF8945A6D08
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
       mov       rdx,7FF894751A38
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
       mov       rdx,7FF894751A78
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
       call      qword ptr [7FF8946732E0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection(Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       [rbp+0FFD0],rcx
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
       mov       rdx,7FF8945B6D08
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
       mov       rdx,7FF894761A38
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
       mov       rdx,7FF894761A78
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
       call      qword ptr [7FF8946832E0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection(Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       [rbp+0FFD0],rcx
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
       mov       rdx,7FF8945C6D08
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
       mov       rdx,7FF894771A38
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
       mov       rdx,7FF894771A78
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
       call      qword ptr [7FF8946932E0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection(Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       [rbp+0FFD0],rcx
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
       mov       rdx,7FF8945B6D08
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
       mov       rdx,7FF894761A38
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
       mov       rdx,7FF894761A78
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
       call      qword ptr [7FF8946832E0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection(Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       [rbp+0FFD0],rcx
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
       mov       rdx,7FF8945B6D08
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
       mov       rdx,7FF894761A38
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
       mov       rdx,7FF894761A78
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
       call      qword ptr [7FF8946832E0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection(Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       [rbp+0FFD0],rcx
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
       mov       rdx,7FF8945D6D08
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
       mov       rdx,7FF894781A38
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
       mov       rdx,7FF894781A78
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
       call      qword ptr [7FF8946A32E0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRefCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection(Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       [rbp+0FFD0],rcx
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
       mov       rdx,7FF8945C6D08
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
       mov       rdx,7FF894771A38
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
       mov       rdx,7FF894771A78
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
       call      qword ptr [7FF8946932E0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection(Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       [rbp+0FFD0],rcx
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
       mov       rdx,7FF8945B6D08
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
       mov       rdx,7FF894761A38
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
       mov       rdx,7FF894761A78
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
       call      qword ptr [7FF8946832E0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection(Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       [rbp+0FFD0],rcx
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
       mov       rdx,7FF8945C6D08
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
       mov       rdx,7FF894771A38
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
       mov       rdx,7FF894771A78
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
       call      qword ptr [7FF8946932E0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection(Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       [rbp+0FFD0],rcx
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
       mov       rdx,7FF8945C6D08
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
       mov       rdx,7FF894771A38
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
       mov       rdx,7FF894771A78
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
       call      qword ptr [7FF8946932E0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection(Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       [rbp+0FFD0],rcx
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
       mov       rdx,7FF8945C6D08
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
       mov       rdx,7FF894771A38
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
       mov       rdx,7FF894771A78
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
       call      qword ptr [7FF8946932E0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection(Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       [rbp+0FFD0],rcx
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
       mov       rdx,7FF8945C6D08
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
       mov       rdx,7FF894771A38
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
       mov       rdx,7FF894771A78
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
       call      qword ptr [7FF8946932E0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection(Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       [rbp+0FFD0],rcx
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
       mov       rdx,7FF8945E6D08
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
       mov       rdx,7FF894791A38
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
       mov       rdx,7FF894791A78
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
       call      qword ptr [7FF8946B32E0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection(Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       [rbp+0FFD0],rcx
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
       mov       rdx,7FF8945B6D08
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
       mov       rdx,7FF894761A38
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
       mov       rdx,7FF894761A78
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
       call      qword ptr [7FF8946832E0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonProperRefCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+2AC]
       mov       rcx,offset MD_DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection(Int32)
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRefCollection[[System.__Canon, System.Private.CoreLib]](Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
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
       mov       [rbp+0FFD0],rcx
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
       mov       rdx,7FF8945E6D08
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
       mov       rdx,7FF894791A38
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
       mov       rdx,7FF894791A78
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
       call      qword ptr [7FF8946B32E0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+2AC]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 85
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
       mov       ecx,1
       mov       rdx,7FF8945C6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894679BD0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+2AC]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 85
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
       mov       ecx,1
       mov       rdx,7FF8945D6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894689BD0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+2AC]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 85
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
       mov       ecx,1
       mov       rdx,7FF8945E6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894699BD0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+2AC]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 85
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
       mov       ecx,1
       mov       rdx,7FF8945B6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894669BD0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+2AC]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 85
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
       mov       ecx,1
       mov       rdx,7FF8945D6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894689BD0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+2AC]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 85
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
       mov       ecx,1
       mov       rdx,7FF8945B6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894669BD0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+2AC]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 85
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
       mov       ecx,1
       mov       rdx,7FF8945A6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894659BD0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GenerateAddressRecordCollection()
       push      rsi
       sub       rsp,40
       mov       rsi,rcx
       mov       dword ptr [rsp+20],14
       mov       dword ptr [rsp+28],8
       mov       dword ptr [rsp+30],0F
       mov       ecx,[rsi+2AC]
       mov       edx,19
       mov       r8d,19
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GenerateAddressRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,40
       pop       rsi
       ret
; Total bytes of code 85
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
       mov       ecx,1
       mov       rdx,7FF8945B6D08
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
       vmulsd    xmm0,xmm0,qword ptr [7FF894669BD0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+2AC]
       mov       edx,2
       mov       r8d,0F
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 116
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
       mov       ecx,1
       mov       rdx,7FF8945D6D08
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
       mov       rcx,7FF894414928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2247D9A2F38
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
       mov       rdx,46DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L06
       mov       rdx,0B923A29C779B
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
       mov       r8,0FF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,0FFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FF29406B2A1B
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
       mov       r11,7FF8943102E8
       call      qword ptr [7FF8946902E8]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FF8943102F0
       call      qword ptr [7FF8946902F0]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FF8943102F8
       call      qword ptr [7FF8946902F8]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+2AC]
       mov       edx,2
       mov       r8d,0F
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 116
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
       mov       ecx,1
       mov       rdx,7FF8945D6D08
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
       mov       rcx,7FF894414928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2476ACE2F38
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
       mov       rdx,46DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L06
       mov       rdx,0B923A29C779B
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
       mov       r8,0FF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,0FFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FF29406B2A1B
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
       mov       r11,7FF8943102E8
       call      qword ptr [7FF8946902E8]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FF8943102F0
       call      qword ptr [7FF8946902F0]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FF8943102F8
       call      qword ptr [7FF8946902F8]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+2AC]
       mov       edx,2
       mov       r8d,0F
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 116
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
       mov       ecx,1
       mov       rdx,7FF8945B6D08
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
       mov       rcx,7FF8943F4928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,25747D32F38
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
       mov       rdx,46DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L06
       mov       rdx,0B923A29C779B
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
       mov       r8,0FF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,0FFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FF29406B2A1B
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
       mov       r11,7FF8942F02E8
       call      qword ptr [7FF8946702E8]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FF8942F02F0
       call      qword ptr [7FF8946702F0]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FF8942F02F8
       call      qword ptr [7FF8946702F8]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+2AC]
       mov       edx,2
       mov       r8d,0F
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 116
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
       mov       ecx,1
       mov       rdx,7FF8945A6D08
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
       mov       rcx,7FF8943E4928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1640F3A2F38
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
       mov       rdx,46DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L06
       mov       rdx,0B923A29C779B
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
       mov       r8,0FF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,0FFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FF29406B2A1B
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
       mov       r11,7FF8942E02E8
       call      qword ptr [7FF8946602E8]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FF8942E02F0
       call      qword ptr [7FF8946602F0]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FF8942E02F8
       call      qword ptr [7FF8946602F8]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+2AC]
       mov       edx,2
       mov       r8d,0F
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 116
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
       mov       ecx,1
       mov       rdx,7FF8945D6D08
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
       mov       rcx,7FF894414928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1FF9CB22F38
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
       mov       rdx,46DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L06
       mov       rdx,0B923A29C779B
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
       mov       r8,0FF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,0FFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FF29406B2A1B
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
       mov       r11,7FF8943102E8
       call      qword ptr [7FF8946902E8]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FF8943102F0
       call      qword ptr [7FF8946902F0]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FF8943102F8
       call      qword ptr [7FF8946902F8]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+2AC]
       mov       edx,2
       mov       r8d,0F
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 116
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
       mov       ecx,1
       mov       rdx,7FF8945A6D08
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
       mov       rcx,7FF8943E4928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,27867222F38
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
       mov       rdx,46DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L06
       mov       rdx,0B923A29C779B
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
       mov       r8,0FF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,0FFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FF29406B2A1B
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
       mov       r11,7FF8942E02E8
       call      qword ptr [7FF8946602E8]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FF8942E02F0
       call      qword ptr [7FF8946602F0]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FF8942E02F8
       call      qword ptr [7FF8946602F8]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+2AC]
       mov       edx,2
       mov       r8d,0F
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 116
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
       mov       ecx,1
       mov       rdx,7FF8945E6D08
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
       mov       rcx,7FF894424928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2559AD32F38
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
       mov       rdx,46DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L06
       mov       rdx,0B923A29C779B
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
       mov       r8,0FF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,0FFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FF29406B2A1B
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
       mov       r11,7FF8943202E8
       call      qword ptr [7FF8946A02E8]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FF8943202F0
       call      qword ptr [7FF8946A02F0]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FF8943202F8
       call      qword ptr [7FF8946A02F8]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonRecordCollection()
       push      rbp
       push      rsi
       sub       rsp,58
       lea       rbp,[rsp+60]
       mov       rsi,rcx
       mov       dword ptr [rsp+20],19
       mov       dword ptr [rsp+28],19
       mov       dword ptr [rsp+30],19
       mov       dword ptr [rsp+38],14
       mov       dword ptr [rsp+40],8
       mov       dword ptr [rsp+48],0F
       mov       ecx,[rsi+2AC]
       mov       edx,2
       mov       r8d,0F
       mov       r9d,19
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonRecordCollection(Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,58
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 116
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
       mov       ecx,1
       mov       rdx,7FF8945B6D08
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
       mov       rcx,7FF8943F4928
       mov       edx,24
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,22CAF072F38
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
       mov       rdx,46DC5D638865
       cmp       rcx,rdx
       jg        near ptr M01_L06
       mov       rdx,0B923A29C779B
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
       mov       r8,0FF29406B2A1B
       cmp       rdx,r8
       jl        near ptr M01_L09
       imul      rdx,989680
       call      System.DateTime.op_Addition(System.DateTime, System.TimeSpan)
       mov       rdx,0FFFFFFFFFFFF
       and       rdx,rax
       mov       rcx,2875F4373FFF
       cmp       rdx,rcx
       ja        near ptr M01_L07
       mov       rcx,0FFFFFFFFFFFF
       and       rcx,rdx
       sub       rcx,[rsp+88]
       mov       r8,2875F4373FFF
       cmp       rcx,r8
       ja        near ptr M01_L08
       mov       r8,0
       and       rdx,r8
       or        rdx,rcx
       mov       ecx,[rsp+0B0]
       movsx     rcx,cx
       movsxd    rcx,ecx
       imul      rcx,3C
       mov       r8,0D6BF94D5E5
       cmp       rcx,r8
       jg        near ptr M01_L09
       mov       r8,0FF29406B2A1B
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
       mov       r11,7FF8942F02E8
       call      qword ptr [7FF8946702E8]
       test      eax,eax
       jne       near ptr M01_L10
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r11,7FF8942F02F0
       call      qword ptr [7FF8946702F0]
       mov       edx,eax
       mov       rax,[rsp+70]
       mov       rcx,[rax+8]
       mov       r8,[rsp+68]
       mov       r11,7FF8942F02F8
       call      qword ptr [7FF8946702F8]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       [rbp+0FE08],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
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
       mov       rdx,7FF8945D6D08
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
       mov       rdx,1F1AC4D2F88
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
       lea       rcx,[rbp+0FF58]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp+0FEE8]
       lea       rsi,[rbp+0FF58]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FF8943107C8
       call      qword ptr [7FF8948D07C8]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FF8943107D0
       call      qword ptr [7FF8948D07D0]
       mov       r12d,eax
       lea       rdi,[rbp+0FE78]
       lea       rsi,[rbp+0FEE8]
       mov       ecx,0E
       rep movsq
       mov       r13,[r14+8]
       lea       rdi,[rbp+0FE08]
       lea       rsi,[rbp+0FE78]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp+0FE08]
       mov       edx,r12d
       mov       r11,7FF8943107D8
       call      qword ptr [7FF8948D07D8]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       [rbp+0FE08],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
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
       mov       rdx,7FF8945D6D08
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
       mov       rdx,14907582F88
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
       lea       rcx,[rbp+0FF58]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp+0FEE8]
       lea       rsi,[rbp+0FF58]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FF8943107C8
       call      qword ptr [7FF8948D07C8]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FF8943107D0
       call      qword ptr [7FF8948D07D0]
       mov       r12d,eax
       lea       rdi,[rbp+0FE78]
       lea       rsi,[rbp+0FEE8]
       mov       ecx,0E
       rep movsq
       mov       r13,[r14+8]
       lea       rdi,[rbp+0FE08]
       lea       rsi,[rbp+0FE78]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp+0FE08]
       mov       edx,r12d
       mov       r11,7FF8943107D8
       call      qword ptr [7FF8948D07D8]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       [rbp+0FE08],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
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
       mov       rdx,7FF8945E6D08
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
       mov       rdx,211E97A2F88
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
       lea       rcx,[rbp+0FF58]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp+0FEE8]
       lea       rsi,[rbp+0FF58]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FF8943207C8
       call      qword ptr [7FF8948E07C8]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FF8943207D0
       call      qword ptr [7FF8948E07D0]
       mov       r12d,eax
       lea       rdi,[rbp+0FE78]
       lea       rsi,[rbp+0FEE8]
       mov       ecx,0E
       rep movsq
       mov       r13,[r14+8]
       lea       rdi,[rbp+0FE08]
       lea       rsi,[rbp+0FE78]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp+0FE08]
       mov       edx,r12d
       mov       r11,7FF8943207D8
       call      qword ptr [7FF8948E07D8]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       [rbp+0FE08],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
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
       mov       rdx,7FF8945D6D08
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
       mov       rdx,16C226F2F88
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
       lea       rcx,[rbp+0FF58]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp+0FEE8]
       lea       rsi,[rbp+0FF58]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FF8943107C8
       call      qword ptr [7FF8948D07C8]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FF8943107D0
       call      qword ptr [7FF8948D07D0]
       mov       r12d,eax
       lea       rdi,[rbp+0FE78]
       lea       rsi,[rbp+0FEE8]
       mov       ecx,0E
       rep movsq
       mov       r13,[r14+8]
       lea       rdi,[rbp+0FE08]
       lea       rsi,[rbp+0FE78]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp+0FE08]
       mov       edx,r12d
       mov       r11,7FF8943107D8
       call      qword ptr [7FF8948D07D8]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       [rbp+0FE08],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
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
       mov       rdx,7FF8945C6D08
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
       mov       rdx,1E16D422F88
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
       lea       rcx,[rbp+0FF58]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp+0FEE8]
       lea       rsi,[rbp+0FF58]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FF8943007C8
       call      qword ptr [7FF8948C07C8]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FF8943007D0
       call      qword ptr [7FF8948C07D0]
       mov       r12d,eax
       lea       rdi,[rbp+0FE78]
       lea       rsi,[rbp+0FEE8]
       mov       ecx,0E
       rep movsq
       mov       r13,[r14+8]
       lea       rdi,[rbp+0FE08]
       lea       rsi,[rbp+0FE78]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp+0FE08]
       mov       edx,r12d
       mov       r11,7FF8943007D8
       call      qword ptr [7FF8948C07D8]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       [rbp+0FE08],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
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
       mov       rdx,7FF8945C6D08
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
       mov       rdx,23312AD2F88
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
       lea       rcx,[rbp+0FF58]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp+0FEE8]
       lea       rsi,[rbp+0FF58]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FF8943007C8
       call      qword ptr [7FF8948C07C8]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FF8943007D0
       call      qword ptr [7FF8948C07D0]
       mov       r12d,eax
       lea       rdi,[rbp+0FE78]
       lea       rsi,[rbp+0FEE8]
       mov       ecx,0E
       rep movsq
       mov       r13,[r14+8]
       lea       rdi,[rbp+0FE08]
       lea       rsi,[rbp+0FE78]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp+0FE08]
       mov       edx,r12d
       mov       r11,7FF8943007D8
       call      qword ptr [7FF8948C07D8]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       [rbp+0FE08],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
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
       mov       rdx,7FF8945D6D08
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
       mov       rdx,1CEEF702F90
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
       lea       rcx,[rbp+0FF58]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp+0FEE8]
       lea       rsi,[rbp+0FF58]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FF8943107D8
       call      qword ptr [7FF8948F07D8]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FF8943107E0
       call      qword ptr [7FF8948F07E0]
       mov       r12d,eax
       lea       rdi,[rbp+0FE78]
       lea       rsi,[rbp+0FEE8]
       mov       ecx,0E
       rep movsq
       mov       r13,[r14+8]
       lea       rdi,[rbp+0FE08]
       lea       rsi,[rbp+0FE78]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp+0FE08]
       mov       edx,r12d
       mov       r11,7FF8943107E8
       call      qword ptr [7FF8948F07E8]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Tester.BenchmarkTests.RandomDataCollectionsBenchmark.GeneratePersonValCollection()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       ecx,[rsi+2AC]
       call      DotNetTips.Spargine.Tester.RandomData.GeneratePersonValCollection(Int32)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 44
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
       mov       [rbp+0FE08],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFE50
M01_L00:
       vmovdqa   xmmword ptr [rbp+rax+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFD0],xmm4
       vmovdqa   xmmword ptr [rbp+rax+0FFE0],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+0FFC0],rax
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
       mov       rdx,7FF8945C6D08
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
       mov       rdx,161E7E02F90
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
       lea       rcx,[rbp+0FF58]
       mov       edx,19
       mov       r8d,0F
       mov       r9d,0F
       call      DotNetTips.Spargine.Tester.RandomData.GenerateValPerson(Int32, Int32, Int32, Int32, Int32, Int32, Int32)
       lea       rdi,[rbp+0FEE8]
       lea       rsi,[rbp+0FF58]
       mov       ecx,0E
       rep movsq
       mov       rcx,[r14+8]
       mov       r11,7FF8943007D8
       call      qword ptr [7FF8948E07D8]
       test      eax,eax
       jne       near ptr M01_L07
       mov       rcx,[r14+8]
       mov       r11,7FF8943007E0
       call      qword ptr [7FF8948E07E0]
       mov       r12d,eax
       lea       rdi,[rbp+0FE78]
       lea       rsi,[rbp+0FEE8]
       mov       ecx,0E
       rep movsq
       mov       r13,[r14+8]
       lea       rdi,[rbp+0FE08]
       lea       rsi,[rbp+0FE78]
       mov       ecx,0E
       rep movsq
       mov       rcx,r13
       lea       r8,[rbp+0FE08]
       mov       edx,r12d
       mov       r11,7FF8943007E8
       call      qword ptr [7FF8948E07E8]
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

