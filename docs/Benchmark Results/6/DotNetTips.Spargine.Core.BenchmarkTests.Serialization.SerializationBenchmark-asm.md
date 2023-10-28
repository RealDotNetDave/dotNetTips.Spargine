## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_JsonSerializer_Generator_PersonProper_List()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+190]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializer.Deserialize(System.String, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 116
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       cmp       dword ptr [7FF9C7895F48],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,7FF9C7896388
       mov       edx,14
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rax,182B31F8540
       mov       rax,[rax]
       mov       [rbp-8],rax
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       cmp       qword ptr [rbp-8],0
       jne       short M01_L01
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_s_defaultOptions()
       mov       [rbp-18],rax
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-18]
       call      System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,7FF9C7896388
       mov       edx,14
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,182B31F8540
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
M01_L01:
       mov       rax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 226
```
```assembly
; System.Text.Json.JsonSerializer.Deserialize(System.String, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short M02_L00
       test      rdx,rdx
       je        short M02_L01
       test      r8,r8
       je        short M02_L02
       mov       rcx,r8
       call      System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
       mov       r8,rax
       lea       rdx,[rsi+0C]
       mov       ecx,[rsi+8]
       mov       [rsp+20],rdx
       mov       [rsp+28],ecx
       lea       rdx,[rsp+20]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[System.Object, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       nop
       add       rsp,30
       pop       rsi
       ret
M02_L00:
       mov       ecx,2C1E
       mov       rdx,7FF9C7A48B80
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
       int       3
M02_L01:
       mov       ecx,2E88
       mov       rdx,7FF9C7A48B80
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
       int       3
M02_L02:
       mov       ecx,2EB8
       mov       rdx,7FF9C7A48B80
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 171
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_JsonSerializer_Generator_PersonProper_List()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+190]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rbx,rax
       call      qword ptr [7FF9CEA07120]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF9CE665708]; System.Text.Json.JsonSerializer.Deserialize(System.String, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FF9CE1FB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       cmp       dword ptr [7FF9CE4A91C8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,7FF9CE4A95C8
       mov       edx,14
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rax,189EB407548
       mov       rax,[rax]
       mov       [rbp-10],rax
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       cmp       qword ptr [rbp-10],0
       jne       short M01_L01
       call      qword ptr [7FF9CEA07108]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_s_defaultOptions()
       mov       [rbp-20],rax
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CE663168]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-28]
       call      qword ptr [7FF9CEA07168]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,7FF9CE4A95C8
       mov       edx,14
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-30]
       mov       rcx,189EB407548
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-30]
       mov       [rbp-18],rax
M01_L01:
       mov       rax,[rbp-18]
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 231
```
```assembly
; System.Text.Json.JsonSerializer.Deserialize(System.String, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short M02_L00
       test      rdx,rdx
       je        short M02_L01
       test      r8,r8
       je        short M02_L02
       mov       rcx,r8
       call      qword ptr [7FF9CE665348]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
       mov       r8,rax
       lea       rdx,[rsi+0C]
       mov       ecx,[rsi+8]
       mov       [rsp+20],rdx
       mov       [rsp+28],ecx
       lea       rdx,[rsp+20]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[System.Object, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [7FF9CEA07210]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       nop
       add       rsp,30
       pop       rsi
       ret
M02_L00:
       mov       ecx,2C1E
       mov       rdx,7FF9CE64F658
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CE75F018]
       int       3
M02_L01:
       mov       ecx,2E88
       mov       rdx,7FF9CE64F658
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CE75F018]
       int       3
M02_L02:
       mov       ecx,2EB8
       mov       rdx,7FF9CE64F658
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CE75F018]
       int       3
; Total bytes of code 176
```
```assembly
; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rax,rdx
       test      rax,rax
       je        short M03_L00
       cmp       [rax],rcx
       jne       short M03_L01
M03_L00:
       ret
M03_L01:
       mov       rdx,[rax]
       mov       rdx,[rdx+10]
M03_L02:
       cmp       rdx,rcx
       je        short M03_L04
       test      rdx,rdx
       je        short M03_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M03_L04
       test      rdx,rdx
       je        short M03_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M03_L04
       test      rdx,rdx
       je        short M03_L03
       mov       rdx,[rdx+10]
       cmp       rdx,rcx
       je        short M03_L04
       test      rdx,rdx
       jne       short M03_L05
M03_L03:
       xor       eax,eax
M03_L04:
       ret
M03_L05:
       mov       rdx,[rdx+10]
       jmp       short M03_L02
; Total bytes of code 82
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_JsonSerializer_Generator_PersonProper()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+1A0]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializer.Deserialize(System.String, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
       test      rax,rax
       je        short M00_L00
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper
       cmp       [rax],rdx
       je        short M00_L00
       xor       eax,eax
M00_L00:
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       cmp       dword ptr [7FF9C7895F48],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,7FF9C7896388
       mov       edx,14
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rax,25834818540
       mov       rax,[rax]
       mov       [rbp-8],rax
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       cmp       qword ptr [rbp-8],0
       jne       short M01_L01
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_s_defaultOptions()
       mov       [rbp-18],rax
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-18]
       call      System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,7FF9C7896388
       mov       edx,14
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,25834818540
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
M01_L01:
       mov       rax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 226
```
```assembly
; System.Text.Json.JsonSerializer.Deserialize(System.String, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short M02_L00
       test      rdx,rdx
       je        short M02_L01
       test      r8,r8
       je        short M02_L02
       mov       rcx,r8
       call      System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
       mov       r8,rax
       lea       rdx,[rsi+0C]
       mov       ecx,[rsi+8]
       mov       [rsp+20],rdx
       mov       [rsp+28],ecx
       lea       rdx,[rsp+20]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[System.Object, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       nop
       add       rsp,30
       pop       rsi
       ret
M02_L00:
       mov       ecx,2C1E
       mov       rdx,7FF9C7A48B80
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
       int       3
M02_L01:
       mov       ecx,2E88
       mov       rdx,7FF9C7A48B80
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
       int       3
M02_L02:
       mov       ecx,2EB8
       mov       rdx,7FF9C7A48B80
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 171
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_JsonSerializer_Generator_PersonProper()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+1A0]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rbx,rax
       call      qword ptr [7FF9CE9F5120]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF9CE655708]; System.Text.Json.JsonSerializer.Deserialize(System.String, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
       test      rax,rax
       je        short M00_L00
       mov       rdx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper
       cmp       [rax],rdx
       je        short M00_L00
       xor       eax,eax
M00_L00:
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 122
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       cmp       dword ptr [7FF9CE4991C8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,7FF9CE4995C8
       mov       edx,14
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rax,1ECCA407548
       mov       rax,[rax]
       mov       [rbp-10],rax
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       cmp       qword ptr [rbp-10],0
       jne       short M01_L01
       call      qword ptr [7FF9CE9F5108]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_s_defaultOptions()
       mov       [rbp-20],rax
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CE653168]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-28]
       call      qword ptr [7FF9CE9F5168]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,7FF9CE4995C8
       mov       edx,14
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-30]
       mov       rcx,1ECCA407548
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-30]
       mov       [rbp-18],rax
M01_L01:
       mov       rax,[rbp-18]
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 231
```
```assembly
; System.Text.Json.JsonSerializer.Deserialize(System.String, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       test      rsi,rsi
       je        short M02_L00
       test      rdx,rdx
       je        short M02_L01
       test      r8,r8
       je        short M02_L02
       mov       rcx,r8
       call      qword ptr [7FF9CE655348]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
       mov       r8,rax
       lea       rdx,[rsi+0C]
       mov       ecx,[rsi+8]
       mov       [rsp+20],rdx
       mov       [rsp+28],ecx
       lea       rdx,[rsp+20]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[System.Object, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [7FF9CE9F5210]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       nop
       add       rsp,30
       pop       rsi
       ret
M02_L00:
       mov       ecx,2C1E
       mov       rdx,7FF9CE63F658
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CE74F018]
       int       3
M02_L01:
       mov       ecx,2E88
       mov       rdx,7FF9CE63F658
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CE74F018]
       int       3
M02_L02:
       mov       ecx,2EB8
       mov       rdx,7FF9CE63F658
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CE74F018]
       int       3
; Total bytes of code 176
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_PersonRecord()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+198]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](System.String)
       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C7886D08],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       call      System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,[rbp-28]
       mov       edx,3
       cmp       [rcx],ecx
       call      System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       nop
       mov       r9,[rbp-28]
       mov       [rbp-10],r9
       mov       r9,28988393350
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,28928393020
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7DE36A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M01_L02:
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-30]
       mov       r8,[rbp-10]
       call      System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       [rbp-18],rax
       mov       rax,[rbp-18]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L03
M01_L03:
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 273
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_PersonRecord()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+198]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](System.String)
       call      qword ptr [7FF9CEEE3FA8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEEE9798]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9CE989F50],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       call      qword ptr [7FF9CEB43150]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,[rbp-28]
       mov       edx,3
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEB43330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       nop
       mov       r9,[rbp-28]
       mov       [rbp-10],r9
       mov       r9,14B2B0091F0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,14B25002028
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CEB4BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEECE328
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M01_L02:
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-30]
       mov       r8,[rbp-10]
       call      qword ptr [7FF9CEEE5018]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       [rbp-18],rax
       mov       rax,[rbp-18]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 275
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_PersonProper_List()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.String)
       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C7866D08],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       call      System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,[rbp-28]
       mov       edx,3
       cmp       [rcx],ecx
       call      System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       nop
       mov       r9,[rbp-28]
       mov       [rbp-10],r9
       mov       r9,228C8F01338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,228E8F03020
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C7DC36A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M01_L02:
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-30]
       mov       r8,[rbp-10]
       call      System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       [rbp-18],rax
       mov       rax,[rbp-18]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L03
M01_L03:
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 273
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_PersonProper_List()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.String)
       call      qword ptr [7FF9CEEE7300]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEEE75D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9CE989F50],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       call      qword ptr [7FF9CEB43150]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,[rbp-28]
       mov       edx,3
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEB43330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       nop
       mov       r9,[rbp-28]
       mov       [rbp-10],r9
       mov       r9,2BA76400240
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2BA6C402028
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CEB4BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+10]
       mov       [rbp-38],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9CEECE4F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-38],rax
M01_L02:
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-30]
       mov       r8,[rbp-10]
       call      qword ptr [7FF9CEEE7360]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       [rbp-18],rax
       mov       rax,[rbp-18]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 275
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Xml_Ref_PersonProper()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+1B8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.String)
       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       mov       [rbp-68],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C7876D08],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,21C1D4A19C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21C2D4A3020
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-28]
       call      System.IO.StringReader..ctor(System.String)
       mov       rcx,[rbp-30]
       mov       [rbp-10],rcx
       nop
       mov       rcx,[rbp-10]
       call      System.Xml.XmlReader.Create(System.IO.TextReader)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-18],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
       mov       [rbp-48],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-48]
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type)
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-18]
       call      System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader)
       mov       [rbp-58],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHKCASTARRAY
       mov       [rbp-20],rax
       nop
       jmp       short M01_L01
M01_L01:
       mov       rcx,rsp
       call      M01_L02
       nop
       mov       rcx,rsp
       call      M01_L04
       nop
       mov       rax,[rbp-20]
       add       rsp,90
       pop       rbp
       ret
M01_L02:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-18],0
       je        short M01_L03
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75C0838
       call      qword ptr [7FF9C75C0838]
       nop
M01_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L04:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-10],0
       je        short M01_L05
       mov       rcx,[rbp-10]
       mov       r11,7FF9C75C0840
       call      qword ptr [7FF9C75C0840]
       nop
M01_L05:
       nop
       add       rsp,30
       pop       rbp
       ret
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Xml_Ref_PersonProper()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+1B8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.String)
       call      qword ptr [7FF9CEED5FA8]; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEF0DEA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       mov       [rbp-68],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9CE979F50],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,221F7400A28
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,221E5402028
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CEB3BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-28]
       call      qword ptr [7FF9CEED7018]; System.IO.StringReader..ctor(System.String)
       mov       rcx,[rbp-30]
       mov       [rbp-10],rcx
       nop
       mov       rcx,[rbp-10]
       call      qword ptr [7FF9CEE71C90]; System.Xml.XmlReader.Create(System.IO.TextReader)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-18],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9CE6430C0]; System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
       mov       [rbp-48],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-48]
       call      qword ptr [7FF9CEDC90F0]; System.Xml.Serialization.XmlSerializer..ctor(System.Type)
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-18]
       call      qword ptr [7FF9CEDC92B8]; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader)
       mov       [rbp-58],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx]
       mov       rdx,[rbp-58]
       call      qword ptr [7FF9CE6CB858]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       [rbp-20],rax
       nop
       mov       rcx,rsp
       call      M01_L01
       nop
       mov       rcx,rsp
       call      M01_L03
       nop
       mov       rax,[rbp-20]
       add       rsp,90
       pop       rbp
       ret
M01_L01:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-18],0
       je        short M01_L02
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE520760
       call      qword ptr [r11]
       nop
M01_L02:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L03:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-10],0
       je        short M01_L04
       mov       rcx,[rbp-10]
       mov       r11,7FF9CE520768
       call      qword ptr [r11]
       nop
M01_L04:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 447
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Xml_PersonRecord()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+1B0]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](System.String)
       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       mov       [rbp-68],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,2068F7D19C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2062F7D3020
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-28]
       call      System.IO.StringReader..ctor(System.String)
       mov       rcx,[rbp-30]
       mov       [rbp-10],rcx
       nop
       mov       rcx,[rbp-10]
       call      System.Xml.XmlReader.Create(System.IO.TextReader)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-18],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
       mov       [rbp-48],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-48]
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type)
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-18]
       call      System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader)
       mov       [rbp-58],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHKCASTARRAY
       mov       [rbp-20],rax
       nop
       jmp       short M01_L01
M01_L01:
       mov       rcx,rsp
       call      M01_L02
       nop
       mov       rcx,rsp
       call      M01_L04
       nop
       mov       rax,[rbp-20]
       add       rsp,90
       pop       rbp
       ret
M01_L02:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-18],0
       je        short M01_L03
       mov       rcx,[rbp-18]
       mov       r11,7FF9C75E0838
       call      qword ptr [7FF9C75E0838]
       nop
M01_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L04:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-10],0
       je        short M01_L05
       mov       rcx,[rbp-10]
       mov       r11,7FF9C75E0840
       call      qword ptr [7FF9C75E0840]
       nop
M01_L05:
       nop
       add       rsp,30
       pop       rbp
       ret
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Xml_PersonRecord()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+1B0]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](System.String)
       call      qword ptr [7FF9CEEF3FA8]; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEF1D7F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
       mov       [rbp-68],rsp
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9CE999F50],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,2C6E2000A28
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2C6D2002028
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9CEB5BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-28]
       call      qword ptr [7FF9CEEF5018]; System.IO.StringReader..ctor(System.String)
       mov       rcx,[rbp-30]
       mov       [rbp-10],rcx
       nop
       mov       rcx,[rbp-10]
       call      qword ptr [7FF9CEE6FC90]; System.Xml.XmlReader.Create(System.IO.TextReader)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-18],rcx
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       call      qword ptr [7FF9CE6630C0]; System.Type.GetTypeFromHandle(System.RuntimeTypeHandle)
       mov       [rbp-48],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-48]
       call      qword ptr [7FF9CEDE71B0]; System.Xml.Serialization.XmlSerializer..ctor(System.Type)
       mov       rcx,[rbp-50]
       mov       rdx,[rbp-18]
       call      qword ptr [7FF9CEDE7378]; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader)
       mov       [rbp-58],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx]
       mov       rdx,[rbp-58]
       call      qword ptr [7FF9CE6EB858]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       [rbp-20],rax
       nop
       mov       rcx,rsp
       call      M01_L01
       nop
       mov       rcx,rsp
       call      M01_L03
       nop
       mov       rax,[rbp-20]
       add       rsp,90
       pop       rbp
       ret
M01_L01:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-18],0
       je        short M01_L02
       mov       rcx,[rbp-18]
       mov       r11,7FF9CE540760
       call      qword ptr [r11]
       nop
M01_L02:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L03:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-10],0
       je        short M01_L04
       mov       rcx,[rbp-10]
       mov       r11,7FF9CE540768
       call      qword ptr [r11]
       nop
M01_L04:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 447
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_JsonSerializer_Generator_PersonProper_List()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+1A8]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializer.Serialize(System.Object, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 98
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       cmp       dword ptr [7FF9C7895F48],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,7FF9C7896388
       mov       edx,14
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rax,29CEDD28540
       mov       rax,[rax]
       mov       [rbp-8],rax
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       cmp       qword ptr [rbp-8],0
       jne       short M01_L01
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_s_defaultOptions()
       mov       [rbp-18],rax
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-18]
       call      System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,7FF9C7896388
       mov       edx,14
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,29CEDD28540
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
M01_L01:
       mov       rax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 226
```
```assembly
; System.Text.Json.JsonSerializer.Serialize(System.Object, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rbx,rbx
       je        short M02_L00
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.Json.JsonSerializer.ValidateInputType(System.Object, System.Type)
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
       mov       rdx,rax
       mov       rcx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
M02_L00:
       mov       ecx,2EB8
       mov       rdx,7FF9C7A48B80
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 90
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_JsonSerializer_Generator_PersonProper_List()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+1A8]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rbx,rax
       call      qword ptr [7FF9CEA05120]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF9CE665A68]; System.Text.Json.JsonSerializer.Serialize(System.Object, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 100
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       cmp       dword ptr [7FF9CE4A91C8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,7FF9CE4A95C8
       mov       edx,14
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rax,15C99807548
       mov       rax,[rax]
       mov       [rbp-10],rax
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       cmp       qword ptr [rbp-10],0
       jne       short M01_L01
       call      qword ptr [7FF9CEA05108]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_s_defaultOptions()
       mov       [rbp-20],rax
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CE663168]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-28]
       call      qword ptr [7FF9CEA05168]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,7FF9CE4A95C8
       mov       edx,14
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-30]
       mov       rcx,15C99807548
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-30]
       mov       [rbp-18],rax
M01_L01:
       mov       rax,[rbp-18]
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 231
```
```assembly
; System.Text.Json.JsonSerializer.Serialize(System.Object, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rbx,rbx
       je        short M02_L00
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF9CE665918]; System.Text.Json.JsonSerializer.ValidateInputType(System.Object, System.Type)
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF9CE665348]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
       mov       rdx,rax
       mov       rcx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CE665A98]; System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
M02_L00:
       mov       ecx,2EB8
       mov       rdx,7FF9CE64F658
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CE75F018]
       int       3
; Total bytes of code 94
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_JsonSerializer_Generator_PersonProper()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+30]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rbx,rax
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializer.Serialize(System.Object, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 95
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       cmp       dword ptr [7FF9C7895F48],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,7FF9C7896388
       mov       edx,14
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rax,1DDFD258540
       mov       rax,[rax]
       mov       [rbp-8],rax
       mov       rax,[rbp-8]
       mov       [rbp-10],rax
       cmp       qword ptr [rbp-8],0
       jne       short M01_L01
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_s_defaultOptions()
       mov       [rbp-18],rax
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       rdx,[rbp-18]
       call      System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,7FF9C7896388
       mov       edx,14
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1DDFD258540
       mov       rdx,[rbp-28]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
M01_L01:
       mov       rax,[rbp-10]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 226
```
```assembly
; System.Text.Json.JsonSerializer.Serialize(System.Object, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rbx,rbx
       je        short M02_L00
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Text.Json.JsonSerializer.ValidateInputType(System.Object, System.Type)
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
       mov       rdx,rax
       mov       rcx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
M02_L00:
       mov       ecx,2EB8
       mov       rdx,7FF9C7A48B80
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 90
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_JsonSerializer_Generator_PersonProper()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+30]
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rbx,rax
       call      qword ptr [7FF9CE9F5120]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FF9CE655A68]; System.Text.Json.JsonSerializer.Serialize(System.Object, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       push      rbp
       push      rdi
       sub       rsp,48
       lea       rbp,[rsp+50]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       cmp       dword ptr [7FF9CE4991C8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,7FF9CE4995C8
       mov       edx,14
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rax,16CCBC05550
       mov       rax,[rax]
       mov       [rbp-10],rax
       mov       rax,[rbp-10]
       mov       [rbp-18],rax
       cmp       qword ptr [rbp-10],0
       jne       short M01_L01
       call      qword ptr [7FF9CE9F5108]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_s_defaultOptions()
       mov       [rbp-20],rax
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9CE653168]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-28]
       call      qword ptr [7FF9CE9F5168]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,7FF9CE4995C8
       mov       edx,14
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,[rbp-30]
       mov       rcx,16CCBC05550
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-30]
       mov       [rbp-18],rax
M01_L01:
       mov       rax,[rbp-18]
       add       rsp,48
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 231
```
```assembly
; System.Text.Json.JsonSerializer.Serialize(System.Object, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       test      rbx,rbx
       je        short M02_L00
       mov       rcx,rsi
       mov       rdx,rdi
       call      qword ptr [7FF9CE655918]; System.Text.Json.JsonSerializer.ValidateInputType(System.Object, System.Type)
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FF9CE655348]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
       mov       rdx,rax
       mov       rcx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FF9CE655A98]; System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
M02_L00:
       mov       ecx,2EB8
       mov       rdx,7FF9CE63F658
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9CE74F018]
       int       3
; Total bytes of code 94
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_Ref_PersonProper()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 62
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7876D08],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       r9,1DFF1CA9948
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1DFF1CA3020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-8],rax
       mov       rdx,[rbp-8]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.Serialize[[System.Object, System.Private.CoreLib]](System.Object, System.Text.Json.JsonSerializerOptions)
       xor       r8d,r8d
       call      System.Text.Json.JsonSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Text.Json.JsonSerializerOptions)
       mov       [rbp-10],rax
       mov       rax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 131
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_Ref_PersonProper()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       call      qword ptr [7FF9CEAE9C00]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEEF5FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE999F50],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       r9,28B22808980
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,28B22802028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9CEB5BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.Serialize[[System.Object, System.Private.CoreLib]](System.Object, System.Text.Json.JsonSerializerOptions)
       xor       r8d,r8d
       call      qword ptr [7FF9CED537C8]; System.Text.Json.JsonSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Text.Json.JsonSerializerOptions)
       mov       [rbp-18],rax
       mov       rax,[rbp-18]
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 135
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_PersonRecord()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+48]
       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 62
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7866D08],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       r9,1CE22059948
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1CE22053020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-8],rax
       mov       rdx,[rbp-8]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.Serialize[[System.Object, System.Private.CoreLib]](System.Object, System.Text.Json.JsonSerializerOptions)
       xor       r8d,r8d
       call      System.Text.Json.JsonSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Text.Json.JsonSerializerOptions)
       mov       [rbp-10],rax
       mov       rax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 131
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_PersonRecord()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+48]
       call      qword ptr [7FF9CEAE9C00]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEEF5FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE999F50],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       r9,26A98C08980
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,26A98C02028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9CEB5BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.Serialize[[System.Object, System.Private.CoreLib]](System.Object, System.Text.Json.JsonSerializerOptions)
       xor       r8d,r8d
       call      qword ptr [7FF9CED53750]; System.Text.Json.JsonSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Text.Json.JsonSerializerOptions)
       mov       [rbp-18],rax
       mov       rax,[rbp-18]
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 135
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_PersonProper_List()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A8]
       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7896D08],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       r9,2E218EF1568
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2E1F8EF3020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-8],rax
       mov       rdx,[rbp-8]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.Serialize[[System.Object, System.Private.CoreLib]](System.Object, System.Text.Json.JsonSerializerOptions)
       xor       r8d,r8d
       call      System.Text.Json.JsonSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Text.Json.JsonSerializerOptions)
       mov       [rbp-10],rax
       mov       rax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 131
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_PersonProper_List()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A8]
       call      qword ptr [7FF9CEAF9C00]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEF070A8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       push      rbp
       push      rdi
       sub       rsp,38
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-18],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE9A9F50],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       r9,1D7BC008980
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1D7BC002028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9CEB6BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       rdx,[rbp-10]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.Serialize[[System.Object, System.Private.CoreLib]](System.Object, System.Text.Json.JsonSerializerOptions)
       xor       r8d,r8d
       call      qword ptr [7FF9CED65750]; System.Text.Json.JsonSerializer.Serialize[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.Text.Json.JsonSerializerOptions)
       mov       [rbp-18],rax
       mov       rax,[rbp-18]
       add       rsp,38
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 135
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_XML_Ref_PersonProper()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.Serialize(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 62
```
```assembly
; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Serialize(System.Object)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-58],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C7876D08],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,25037B69948
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,25037B63020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+10],rcx
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       call      System.IO.StringWriter..ctor()
       mov       rcx,[rbp-30]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       call      System.Xml.XmlWriter.Create(System.IO.TextWriter)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       nop
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-40],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       rdx,[rbp-40]
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type)
       mov       rcx,[rbp-48]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-10]
       mov       r8,[rbp+10]
       cmp       [rcx],ecx
       call      System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object)
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp-20],rcx
       nop
       jmp       short M01_L01
M01_L01:
       mov       rcx,rsp
       call      M01_L02
       nop
       mov       rcx,rsp
       call      M01_L04
       nop
       mov       rax,[rbp-20]
       add       rsp,80
       pop       rbp
       ret
M01_L02:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-10],0
       je        short M01_L03
       mov       rcx,[rbp-10]
       mov       r11,7FF9C75C0578
       call      qword ptr [7FF9C75C0578]
       nop
M01_L03:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L04:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-8],0
       je        short M01_L05
       mov       rcx,[rbp-8]
       mov       r11,7FF9C75C0580
       call      qword ptr [7FF9C75C0580]
       nop
M01_L05:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 443
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_XML_Ref_PersonProper()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       call      qword ptr [7FF9CEAE9F90]; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Serialize(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEEF3FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Serialize(System.Object)
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp-58],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9CE999F50],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,1494B008980
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1494B002028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Object, System.Private.CoreLib]](System.Object, System.Object, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9CEB5BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+10],rcx
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       call      qword ptr [7FF9CEDE5348]; System.IO.StringWriter..ctor()
       mov       rcx,[rbp-30]
       mov       [rbp-8],rcx
       nop
       mov       rcx,[rbp-8]
       call      qword ptr [7FF9CEDE5BA0]; System.Xml.XmlWriter.Create(System.IO.TextWriter)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp-10],rcx
       nop
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Object.GetType()
       mov       [rbp-40],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       rdx,[rbp-40]
       call      qword ptr [7FF9CEDE71B0]; System.Xml.Serialization.XmlSerializer..ctor(System.Type)
       mov       rcx,[rbp-48]
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-10]
       mov       r8,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9CEDE72B8]; System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object)
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp-20],rcx
       nop
       mov       rcx,rsp
       call      M01_L01
       nop
       mov       rcx,rsp
       call      M01_L03
       nop
       mov       rax,[rbp-20]
       add       rsp,80
       pop       rbp
       ret
M01_L01:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-10],0
       je        short M01_L02
       mov       rcx,[rbp-10]
       mov       r11,7FF9CE540498
       call      qword ptr [r11]
       nop
M01_L02:
       nop
       add       rsp,30
       pop       rbp
       ret
M01_L03:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp-8],0
       je        short M01_L04
       mov       rcx,[rbp-8]
       mov       r11,7FF9CE5404A0
       call      qword ptr [r11]
       nop
M01_L04:
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 440
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

