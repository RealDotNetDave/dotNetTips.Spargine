## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0D0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       test      edi,edi
       setge     dl
       movzx     edx,dl
       mov       r9,1E2313B3060
       mov       r9,[r9]
       mov       r8,1E2213B1720
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       edx,edi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0D0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       test      edi,edi
       setge     dl
       movzx     edx,dl
       mov       r9,1DEAC3A3060
       mov       r9,[r9]
       mov       r8,1DEDC3A1720
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       edx,edi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0D0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       test      edi,edi
       setge     dl
       movzx     edx,dl
       mov       r9,2340CA83060
       mov       r9,[r9]
       mov       r8,233ECA85718
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       edx,edi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0D0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       test      edi,edi
       setge     dl
       movzx     edx,dl
       mov       r9,1BDC1AD1048
       mov       r9,[r9]
       mov       r8,1BDB1AD9748
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       edx,edi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0D0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       test      edi,edi
       setge     dl
       movzx     edx,dl
       mov       r9,228FF013060
       mov       r9,[r9]
       mov       r8,228FF017B68
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       edx,edi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0D0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       test      edi,edi
       setge     dl
       movzx     edx,dl
       mov       r9,19EB28A3060
       mov       r9,[r9]
       mov       r8,19EC28A5718
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       edx,edi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0D0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       test      edi,edi
       setge     dl
       movzx     edx,dl
       mov       r9,2A48D563060
       mov       r9,[r9]
       mov       r8,2A48D563B70
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       edx,edi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0D0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       test      edi,edi
       setge     dl
       movzx     edx,dl
       mov       r9,2DCD9503060
       mov       r9,[r9]
       mov       r8,2DCE9501720
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       edx,edi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       edx,[rsi+0D0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       mov       rcx,[rsi+10]
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
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       edi,edx
       test      edi,edi
       setge     dl
       movzx     edx,dl
       mov       r9,1C88F653060
       mov       r9,[r9]
       mov       r8,1C88F653B70
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       mov       edx,edi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rax,rsi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       r8,17B55D61048
       mov       r8,[r8]
       mov       rdx,17B55D63BA0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB171CE900
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB171CE900
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFB171CEBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L21
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB171CE900
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFB171CE940
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFB171CE960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D405A8
       call      qword ptr [7FFB171005A8]
       test      eax,eax
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFB171CE990
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,rax
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D405A8
       call      qword ptr [7FFB171005A8]
       test      eax,eax
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D405B0
       call      qword ptr [7FFB171005B0]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L22
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D405B0
       call      qword ptr [7FFB171005B0]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 688
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       r8,1CD2F523060
       mov       r8,[r8]
       mov       rdx,1CD0F521750
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB171EE900
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB171EE900
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFB171EEBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L21
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB171EE900
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFB171EE940
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFB171EE960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D605A8
       call      qword ptr [7FFB171205A8]
       test      eax,eax
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFB171EE990
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,rax
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D605A8
       call      qword ptr [7FFB171205A8]
       test      eax,eax
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D605B0
       call      qword ptr [7FFB171205B0]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L22
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D605B0
       call      qword ptr [7FFB171205B0]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 688
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       r8,26A4FC13060
       mov       r8,[r8]
       mov       rdx,26A4FC19BB0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB171CE900
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB171CE900
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFB171CEBA0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L21
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB171CE900
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFB171CE940
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFB171CE960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D405A8
       call      qword ptr [7FFB171005A8]
       test      eax,eax
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFB171CE990
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,rax
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D405A8
       call      qword ptr [7FFB171005A8]
       test      eax,eax
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D405B0
       call      qword ptr [7FFB171005B0]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L22
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D405B0
       call      qword ptr [7FFB171005B0]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 688
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       r8,1D7CDC21048
       mov       r8,[r8]
       mov       rdx,1D7ADC23768
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB171DEA88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB171DEA88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFB171DED28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L21
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB171DEA88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFB171DEAC8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFB171DEAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505A8
       call      qword ptr [7FFB171105A8]
       test      eax,eax
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFB171DEB18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,rax
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505A8
       call      qword ptr [7FFB171105A8]
       test      eax,eax
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505B0
       call      qword ptr [7FFB171105B0]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L22
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505B0
       call      qword ptr [7FFB171105B0]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 688
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       r8,18DBE1A1048
       mov       r8,[r8]
       mov       rdx,18DBE1A1B88
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB171AE9B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB171AE9B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFB171AEC58
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L21
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB171AE9B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFB171AE9F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFB171AEA18
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D205A8
       call      qword ptr [7FFB170E05A8]
       test      eax,eax
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFB171AEA48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,rax
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D205A8
       call      qword ptr [7FFB170E05A8]
       test      eax,eax
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D205B0
       call      qword ptr [7FFB170E05B0]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L22
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D205B0
       call      qword ptr [7FFB170E05B0]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 688
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       r8,1B4BD153060
       mov       r8,[r8]
       mov       rdx,1B4BD153BA0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB171DEC48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB171DEC48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFB171DEEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L21
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB171DEC48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFB171DEC88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFB171DECA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505A8
       call      qword ptr [7FFB171105A8]
       test      eax,eax
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFB171DECD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,rax
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505A8
       call      qword ptr [7FFB171105A8]
       test      eax,eax
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505B0
       call      qword ptr [7FFB171105B0]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L22
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505B0
       call      qword ptr [7FFB171105B0]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 688
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       r8,19A45701048
       mov       r8,[r8]
       mov       rdx,19A25703768
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB171BEC48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB171BEC48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFB171BEEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L21
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB171BEC48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFB171BEC88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFB171BECA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D305A8
       call      qword ptr [7FFB170F05A8]
       test      eax,eax
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFB171BECD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,rax
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D305A8
       call      qword ptr [7FFB170F05A8]
       test      eax,eax
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D305B0
       call      qword ptr [7FFB170F05B0]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L22
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D305B0
       call      qword ptr [7FFB170F05B0]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 688
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       r8,1FD667B3060
       mov       r8,[r8]
       mov       rdx,1FD867B1750
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB171EEC48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB171EEC48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFB171EEEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L21
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB171EEC48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFB171EEC88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFB171EECA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D605A8
       call      qword ptr [7FFB171205A8]
       test      eax,eax
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFB171EECD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,rax
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D605A8
       call      qword ptr [7FFB171205A8]
       test      eax,eax
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D605B0
       call      qword ptr [7FFB171205B0]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L22
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D605B0
       call      qword ptr [7FFB171205B0]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 688
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate03()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       mov       r8d,0FFFFFFFF
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       r8,1F8BDF73060
       mov       r8,[r8]
       mov       rdx,1F8CDF73768
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB171BEC48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB171BEC48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFB171BEEE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L21
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB171BEC48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFB171BEC88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFB171BECA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D305A8
       call      qword ptr [7FFB170F05A8]
       test      eax,eax
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFB171BECD8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,rax
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D305A8
       call      qword ptr [7FFB170F05A8]
       test      eax,eax
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D305B0
       call      qword ptr [7FFB170F05B0]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L22
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D305B0
       call      qword ptr [7FFB170F05B0]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 688
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       r8,1B4C89F1048
       mov       r8,[r8]
       mov       rdx,1B4989F3768
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB171CE960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB171CE960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFB171CEC00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L21
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB171CE960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFB171CE9A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFB171CE9C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D405A8
       call      qword ptr [7FFB171005A8]
       test      eax,eax
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFB171CE9F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,rax
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D405A8
       call      qword ptr [7FFB171005A8]
       test      eax,eax
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D405B0
       call      qword ptr [7FFB171005B0]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L22
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D405B0
       call      qword ptr [7FFB171005B0]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 688
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       r8,179D9023060
       mov       r8,[r8]
       mov       rdx,179D9029BB0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB171EE960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB171EE960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFB171EEC00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L21
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB171EE960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFB171EE9A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFB171EE9C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D605A8
       call      qword ptr [7FFB171205A8]
       test      eax,eax
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFB171EE9F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,rax
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D605A8
       call      qword ptr [7FFB171205A8]
       test      eax,eax
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D605B0
       call      qword ptr [7FFB171205B0]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L22
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D605B0
       call      qword ptr [7FFB171205B0]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 688
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       r8,1CE0BAE3060
       mov       r8,[r8]
       mov       rdx,1CE0BAE9BB0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB171CE960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB171CE960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFB171CEC00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L21
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB171CE960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFB171CE9A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFB171CE9C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D405A8
       call      qword ptr [7FFB171005A8]
       test      eax,eax
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFB171CE9F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,rax
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D405A8
       call      qword ptr [7FFB171005A8]
       test      eax,eax
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D405B0
       call      qword ptr [7FFB171005B0]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L22
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D405B0
       call      qword ptr [7FFB171005B0]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 688
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       r8,26126441048
       mov       r8,[r8]
       mov       rdx,26126447B98
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB171EEAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB171EEAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFB171EED88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L21
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB171EEAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFB171EEB28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFB171EEB48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D605A8
       call      qword ptr [7FFB171205A8]
       test      eax,eax
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFB171EEB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,rax
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D605A8
       call      qword ptr [7FFB171205A8]
       test      eax,eax
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D605B0
       call      qword ptr [7FFB171205B0]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L22
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D605B0
       call      qword ptr [7FFB171205B0]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 688
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       r8,23C0BD43060
       mov       r8,[r8]
       mov       rdx,23C1BD47760
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB171BEAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB171BEAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFB171BED88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L21
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB171BEAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFB171BEB28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFB171BEB48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D305A8
       call      qword ptr [7FFB170F05A8]
       test      eax,eax
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFB171BEB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,rax
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D305A8
       call      qword ptr [7FFB170F05A8]
       test      eax,eax
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D305B0
       call      qword ptr [7FFB170F05B0]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L22
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D305B0
       call      qword ptr [7FFB170F05B0]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 688
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       r8,136B4781048
       mov       r8,[r8]
       mov       rdx,136B4787B98
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB171BEAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB171BEAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFB171BED88
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L21
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB171BEAE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFB171BEB28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFB171BEB48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D305A8
       call      qword ptr [7FFB170F05A8]
       test      eax,eax
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFB171BEB78
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,rax
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D305A8
       call      qword ptr [7FFB170F05A8]
       test      eax,eax
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D305B0
       call      qword ptr [7FFB170F05B0]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L22
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D305B0
       call      qword ptr [7FFB170F05B0]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 688
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       r8,2F0C13B3060
       mov       r8,[r8]
       mov       rdx,2F0E13B7760
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB171DECA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB171DECA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFB171DEF48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L21
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB171DECA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFB171DECE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFB171DED08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505A8
       call      qword ptr [7FFB171105A8]
       test      eax,eax
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFB171DED38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,rax
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505A8
       call      qword ptr [7FFB171105A8]
       test      eax,eax
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505B0
       call      qword ptr [7FFB171105B0]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L22
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505B0
       call      qword ptr [7FFB171105B0]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 688
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       r8,11FC3333060
       mov       r8,[r8]
       mov       rdx,11FD3333768
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB171DECA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB171DECA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFB171DEF48
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L21
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB171DECA8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFB171DECE8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFB171DED08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505A8
       call      qword ptr [7FFB171105A8]
       test      eax,eax
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFB171DED38
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,rax
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505A8
       call      qword ptr [7FFB171105A8]
       test      eax,eax
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505B0
       call      qword ptr [7FFB171105B0]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L22
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505B0
       call      qword ptr [7FFB171105B0]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 688
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CollectionCollectionBenchmark.CollectionCreate02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+0A0]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.Collections.Collection`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       xor       r8d,r8d
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 58
```
```assembly
; dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].Create(System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFC0],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       esi,r8d
       mov       r8,16B7A1F3060
       mov       r8,[r8]
       mov       rdx,16B7A1F5BB8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,r14
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor()
       mov       rcx,[rdi+30]
       mov       r15,[rcx+8]
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB171DE960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax+8]
       test      r12,r12
       jne       near ptr M01_L08
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rdi
       mov       rdx,7FFB171DE960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L03:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r12,[rax]
       mov       rcx,[r15+30]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rdi
       mov       rdx,7FFB171DEC00
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       test      r12,r12
       je        near ptr M01_L21
       lea       rcx,[r13+8]
       mov       rdx,r12
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Core.Collections.Collection`1+<>c[[System.__Canon, System.Private.CoreLib]].<Create>b__5_0(System.__Canon)
       mov       [r13+18],rcx
       mov       rcx,[r15+10]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rdi
       mov       rdx,7FFB171DE960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,r13
       call      CORINFO_HELP_ASSIGN_REF
       mov       r12,r13
M01_L08:
       mov       rcx,[r15+18]
       test      rcx,rcx
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       mov       rdx,7FFB171DE9A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rcx,rax
M01_L10:
       mov       rdx,rbx
       mov       r8,r12
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rbx,rax
       mov       r11,[r15+20]
       test      r11,r11
       je        short M01_L11
       jmp       short M01_L12
M01_L11:
       mov       rcx,rdi
       mov       rdx,7FFB171DE9C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L12:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       [rbp+0FFB8],rax
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505A8
       call      qword ptr [7FFB171105A8]
       test      eax,eax
       je        near ptr M01_L20
M01_L13:
       mov       r11,[r15+28]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rcx,rdi
       mov       rdx,7FFB171DE9F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,[rbp+0FFB8]
       call      qword ptr [r11]
       cmp       esi,0FFFFFFFF
       je        short M01_L16
       cmp       esi,0FFFFFFFE
       jne       short M01_L17
M01_L16:
       mov       rcx,r14
       mov       rdx,rax
       call      dotNetTips.Spargine.Core.Collections.Collection`1[[System.__Canon, System.Private.CoreLib]].AddIfNotExists(System.__Canon)
       jmp       short M01_L19
M01_L17:
       inc       dword ptr [r14+14]
       mov       rcx,[r14+8]
       mov       edx,[r14+10]
       cmp       [rcx+8],edx
       jbe       short M01_L18
       lea       r8d,[rdx+1]
       mov       [r14+10],r8d
       mov       r8,rax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L19
M01_L18:
       mov       rcx,r14
       mov       rdx,rax
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L19:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505A8
       call      qword ptr [7FFB171105A8]
       test      eax,eax
       jne       near ptr M01_L13
M01_L20:
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505B0
       call      qword ptr [7FFB171105B0]
       mov       rax,r14
       lea       rsp,[rbp+0FFC8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L21:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFB8],0
       je        short M01_L22
       mov       rcx,[rbp+0FFB8]
       mov       r11,7FFB16D505B0
       call      qword ptr [7FFB171105B0]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 688
```

