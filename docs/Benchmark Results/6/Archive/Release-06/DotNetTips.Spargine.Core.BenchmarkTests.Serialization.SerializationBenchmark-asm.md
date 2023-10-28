## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rcx,20188F64160
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M01_L00
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,20188F64158
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,20188F64158
       mov       rdx,[rdx]
       lea       rcx,[rdi+40]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       byte ptr [rsi+84],0
       jne       short M01_L01
       cmp       byte ptr [rsi+84],0
       jne       short M01_L01
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+84],1
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,20188F64160
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rdi
M01_L00:
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rsi+20]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowInvalidOperationException_SerializerOptionsImmutable(System.Text.Json.Serialization.JsonSerializerContext)
       int       3
; Total bytes of code 212
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
       mov       rdx,7FFD67918318
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
       int       3
M02_L01:
       mov       ecx,2E88
       mov       rdx,7FFD67918318
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
       int       3
M02_L02:
       mov       ecx,2EB8
       mov       rdx,7FFD67918318
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 171
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52BA5120]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFD52805708]; System.Text.Json.JsonSerializer.Deserialize(System.String, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      qword ptr [7FFD5239B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rcx,20F6E807570
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M01_L00
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,20F6E807568
       mov       rdi,[rdx]
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD52803168]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       byte ptr [rsi+84],0
       jne       short M01_L01
       cmp       byte ptr [rsi+84],0
       jne       short M01_L01
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+84],1
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,20F6E807570
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
M01_L00:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rsi+20]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFD5239B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFD528FF810]
       int       3
; Total bytes of code 210
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
       call      qword ptr [7FFD52805348]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
       mov       r8,rax
       lea       rdx,[rsi+0C]
       mov       ecx,[rsi+8]
       mov       [rsp+20],rdx
       mov       [rsp+28],ecx
       lea       rdx,[rsp+20]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[System.Object, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [7FFD52BA5210]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       nop
       add       rsp,30
       pop       rsi
       ret
M02_L00:
       mov       ecx,2C1E
       mov       rdx,7FFD527EF118
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD528FF018]
       int       3
M02_L01:
       mov       ecx,2E88
       mov       rdx,7FFD527EF118
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD528FF018]
       int       3
M02_L02:
       mov       ecx,2EB8
       mov       rdx,7FFD527EF118
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD528FF018]
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rcx,1CF5F936158
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M01_L00
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1CF5F936150
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1CF5F936150
       mov       rdx,[rdx]
       lea       rcx,[rdi+40]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       byte ptr [rsi+84],0
       jne       short M01_L01
       cmp       byte ptr [rsi+84],0
       jne       short M01_L01
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+84],1
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1CF5F936158
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rdi
M01_L00:
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rsi+20]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowInvalidOperationException_SerializerOptionsImmutable(System.Text.Json.Serialization.JsonSerializerContext)
       int       3
; Total bytes of code 212
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
       mov       rdx,7FFD67928318
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
       int       3
M02_L01:
       mov       ecx,2E88
       mov       rdx,7FFD67928318
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
       int       3
M02_L02:
       mov       ecx,2EB8
       mov       rdx,7FFD67928318
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 171
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52B85120]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFD527E5708]; System.Text.Json.JsonSerializer.Deserialize(System.String, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rcx,1C57F407570
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M01_L00
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1C57F407568
       mov       rdi,[rdx]
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD527E3168]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       byte ptr [rsi+84],0
       jne       short M01_L01
       cmp       byte ptr [rsi+84],0
       jne       short M01_L01
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+84],1
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1C57F407570
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
M01_L00:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rsi+20]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFD5237B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFD528DF810]
       int       3
; Total bytes of code 210
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
       call      qword ptr [7FFD527E5348]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
       mov       r8,rax
       lea       rdx,[rsi+0C]
       mov       ecx,[rsi+8]
       mov       [rsp+20],rdx
       mov       [rsp+28],ecx
       lea       rdx,[rsp+20]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[System.Object, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      qword ptr [7FFD52B85210]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       nop
       add       rsp,30
       pop       rsi
       ret
M02_L00:
       mov       ecx,2C1E
       mov       rdx,7FFD527CF118
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD528DF018]
       int       3
M02_L01:
       mov       ecx,2E88
       mov       rdx,7FFD527CF118
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD528DF018]
       int       3
M02_L02:
       mov       ecx,2EB8
       mov       rdx,7FFD527CF118
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD528DF018]
       int       3
; Total bytes of code 176
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rbx
       mov       edx,3
       call      System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L02
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,677
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M01_L04
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFD67CC36A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 341
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_PersonRecord()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+198]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](System.String)
       call      qword ptr [7FFD52B97300]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B9B798]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD527F3150]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFD527F3330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFD527FD498]
       mov       rsi,rax
       mov       ecx,99A
       mov       rdx,7FFD52639A38
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,340
       mov       rdx,7FFD52639A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52639A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD525FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52423510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFD52B7E710
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFD52B97360]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 342
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rbx
       mov       edx,3
       call      System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       mov       rcx,rdi
       test      rcx,rcx
       je        near ptr M01_L02
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,677
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M01_L04
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFD67CC36A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       mov       r8,rbx
       call      System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 341
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_PersonProper_List()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.String)
       call      qword ptr [7FFD52BC5FA8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52BC7288]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD52823150]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFD52823330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
       mov       rcx,rdi
       test      rcx,rcx
       je        short M01_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       edx,edx
M01_L01:
       test      edx,edx
       jne       near ptr M01_L02
       call      qword ptr [7FFD5282D498]
       mov       rsi,rax
       mov       ecx,99A
       mov       rdx,7FFD52669A38
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,340
       mov       rdx,7FFD52669A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52669A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD5282BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5282D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5282D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5262D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52453510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFD52BAD2F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFD52BC7018]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 342
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-68],rsp
       mov       [rbp-20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        near ptr M01_L02
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,933
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L01:
       cmp       [rdx],edx
       mov       rcx,rdx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      rdi,rdi
       je        near ptr M01_L05
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+8]
       mov       [rbx+14],ecx
       mov       rcx,rbx
       mov       [rbp-50],rcx
       jmp       short M01_L03
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L03:
       call      System.Xml.XmlReader.Create(System.IO.TextReader)
       mov       [rbp-58],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       mov       rsi,[rsi]
       mov       rcx,rdi
       mov       rax,[rbp-58]
       mov       rdx,rax
       vmovdqu   xmm0,xmmword ptr [rdi+38]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       vmovdqu   xmm0,xmmword ptr [rdi+48]
       vmovdqu   xmmword ptr [rbp-38],xmm0
       mov       r9,[rdi+58]
       mov       [rbp-28],r9
       lea       r9,[rbp-48]
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHKCASTARRAY
       mov       rsi,rax
       mov       rax,[rbp-58]
       test      rax,rax
       je        short M01_L04
       mov       rcx,rax
       mov       r11,7FFD674C0A50
       call      qword ptr [7FFD674C0A50]
       nop
M01_L04:
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       [rax+14],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFD67722F00]; System.IO.TextReader.Dispose(Boolean)
       mov       rcx,[rbp-50]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       ecx,11
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-58],0
       je        short M01_L06
       mov       rcx,[rbp-58]
       mov       r11,7FFD674C0A50
       call      qword ptr [7FFD674C0A50]
M01_L06:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-50],0
       je        short M01_L07
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       [rax+14],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFD67722F00]; System.IO.TextReader.Dispose(Boolean)
       mov       rcx,[rbp-50]
       call      System.GC.SuppressFinalize(System.Object)
M01_L07:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 683
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Xml_Ref_PersonProper()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+1B8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.String)
       call      qword ptr [7FFD52B97300]; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52BBDEA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-68],rsp
       mov       [rbp-20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rdx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rdx+8],0
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFD527FD498]
       mov       rsi,rax
       mov       ecx,0C56
       mov       rdx,7FFD52639A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,340
       mov       rdx,7FFD52639A38
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,6D0
       mov       rdx,7FFD52639A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD525FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [7FFD52423510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      rdi,rdi
       je        near ptr M01_L04
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       mov       [rbp-50],rcx
       call      qword ptr [7FFD52B31C90]; System.Xml.XmlReader.Create(System.IO.TextReader)
       mov       [rbp-58],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFD52A89108]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       mov       rsi,[rsi]
       mov       rcx,rdi
       mov       rax,[rbp-58]
       mov       rdx,rax
       vmovdqu   ymm0,ymmword ptr [rcx+38]
       vmovdqu   ymmword ptr [rbp-48],ymm0
       mov       r9,[rcx+58]
       mov       [rbp-28],r9
       lea       r9,[rbp-48]
       xor       r8d,r8d
       call      qword ptr [7FFD52A89300]; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5238B858]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rsi,rax
       mov       rax,[rbp-58]
       test      rax,rax
       je        short M01_L03
       mov       rcx,rax
       mov       r11,7FFD521E09A0
       call      qword ptr [r11]
       nop
M01_L03:
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       rcx,rax
       call      System.GC._SuppressFinalize(System.Object)
       mov       rax,rsi
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFD525F77B0]
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-58],0
       je        short M01_L05
       mov       rcx,[rbp-58]
       mov       r11,7FFD521E09A0
       call      qword ptr [r11]
M01_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+90]
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       rcx,rax
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 620
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-68],rsp
       mov       [rbp-20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        near ptr M01_L02
       cmp       dword ptr [rdx+8],0
       je        near ptr M01_L02
       xor       eax,eax
M01_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,933
       mov       rdx,7FFD677861A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFD677861A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFD677861A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L01:
       cmp       [rdx],edx
       mov       rcx,rdx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      rdi,rdi
       je        near ptr M01_L05
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+8]
       mov       [rbx+14],ecx
       mov       rcx,rbx
       mov       [rbp-50],rcx
       jmp       short M01_L03
M01_L02:
       mov       eax,1
       jmp       near ptr M01_L00
M01_L03:
       call      System.Xml.XmlReader.Create(System.IO.TextReader)
       mov       [rbp-58],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       mov       rsi,[rsi]
       mov       rcx,rdi
       mov       rax,[rbp-58]
       mov       rdx,rax
       vmovdqu   xmm0,xmmword ptr [rdi+38]
       vmovdqu   xmmword ptr [rbp-48],xmm0
       vmovdqu   xmm0,xmmword ptr [rdi+48]
       vmovdqu   xmmword ptr [rbp-38],xmm0
       mov       r9,[rdi+58]
       mov       [rbp-28],r9
       lea       r9,[rbp-48]
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHKCASTARRAY
       mov       rsi,rax
       mov       rax,[rbp-58]
       test      rax,rax
       je        short M01_L04
       mov       rcx,rax
       mov       r11,7FFD674E0A88
       call      qword ptr [7FFD674E0A88]
       nop
M01_L04:
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       [rax+14],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFD67742F00]; System.IO.TextReader.Dispose(Boolean)
       mov       rcx,[rbp-50]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       ecx,11
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-58],0
       je        short M01_L06
       mov       rcx,[rbp-58]
       mov       r11,7FFD674E0A88
       call      qword ptr [7FFD674E0A88]
M01_L06:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-50],0
       je        short M01_L07
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       [rax+14],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFD67742F00]; System.IO.TextReader.Dispose(Boolean)
       mov       rcx,[rbp-50]
       call      System.GC.SuppressFinalize(System.Object)
M01_L07:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 683
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Xml_PersonRecord()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+1B0]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](System.String)
       call      qword ptr [7FFD52BB7300]; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52BDF7F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,78
       vzeroupper
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       mov       [rbp-68],rsp
       mov       [rbp-20],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        short M01_L00
       xor       eax,eax
       cmp       dword ptr [rdx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rdx+8],0
       jne       short M01_L01
       jmp       short M01_L01
M01_L00:
       xor       eax,eax
M01_L01:
       test      eax,eax
       jne       near ptr M01_L02
       call      qword ptr [7FFD5281D498]
       mov       rsi,rax
       mov       ecx,0C56
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,340
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,6D0
       mov       rdx,7FFD52659A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD5281BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5281D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5281D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5261D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [7FFD52443510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      rdi,rdi
       je        near ptr M01_L04
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       mov       [rbp-50],rcx
       call      qword ptr [7FFD52B53C90]; System.Xml.XmlReader.Create(System.IO.TextReader)
       mov       [rbp-58],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rsi,[rsi+10]
       mov       rcx,[rsi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFD52A4B1C8]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       mov       rsi,[rsi]
       mov       rcx,rdi
       mov       rax,[rbp-58]
       mov       rdx,rax
       vmovdqu   ymm0,ymmword ptr [rcx+38]
       vmovdqu   ymmword ptr [rbp-48],ymm0
       mov       r9,[rcx+58]
       mov       [rbp-28],r9
       lea       r9,[rbp-48]
       xor       r8d,r8d
       call      qword ptr [7FFD52A4B3C0]; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD523AB858]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rsi,rax
       mov       rax,[rbp-58]
       test      rax,rax
       je        short M01_L03
       mov       rcx,rax
       mov       r11,7FFD522009D8
       call      qword ptr [r11]
       nop
M01_L03:
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       rcx,rax
       call      System.GC._SuppressFinalize(System.Object)
       mov       rax,rsi
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L04:
       mov       ecx,11
       call      qword ptr [7FFD526177B0]
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+90]
       cmp       qword ptr [rbp-58],0
       je        short M01_L05
       mov       rcx,[rbp-58]
       mov       r11,7FFD522009D8
       call      qword ptr [r11]
M01_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       vzeroupper
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+90]
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       rcx,rax
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 620
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rcx,16AAF118568
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M01_L00
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,16AAF118560
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,16AAF118560
       mov       rdx,[rdx]
       lea       rcx,[rdi+40]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       byte ptr [rsi+84],0
       jne       short M01_L01
       cmp       byte ptr [rsi+84],0
       jne       short M01_L01
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+84],1
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,16AAF118568
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rdi
M01_L00:
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rsi+20]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowInvalidOperationException_SerializerOptionsImmutable(System.Text.Json.Serialization.JsonSerializerContext)
       int       3
; Total bytes of code 212
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
       mov       rdx,7FFD67908318
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 90
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52BC5420]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFD52825A68]; System.Text.Json.JsonSerializer.Serialize(System.Object, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rcx,26437803168
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M01_L00
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,26437803160
       mov       rdi,[rdx]
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD52823168]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       byte ptr [rsi+84],0
       jne       short M01_L01
       cmp       byte ptr [rsi+84],0
       jne       short M01_L01
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+84],1
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,26437803168
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
M01_L00:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rsi+20]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFD523BB828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFD5291F810]
       int       3
; Total bytes of code 210
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
       call      qword ptr [7FFD52825918]; System.Text.Json.JsonSerializer.ValidateInputType(System.Object, System.Type)
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFD52825348]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
       mov       rdx,rax
       mov       rcx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFD52825A98]; System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
M02_L00:
       mov       ecx,2EB8
       mov       rdx,7FFD5280F118
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD5291F018]
       int       3
; Total bytes of code 94
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rcx,1BD0AD26570
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M01_L00
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1BD0AD26568
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1BD0AD26568
       mov       rdx,[rdx]
       lea       rcx,[rdi+40]
       call      CORINFO_HELP_ASSIGN_REF
       cmp       byte ptr [rsi+84],0
       jne       short M01_L01
       cmp       byte ptr [rsi+84],0
       jne       short M01_L01
       lea       rcx,[rsi+20]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+84],1
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1BD0AD26570
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,rdi
M01_L00:
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rsi+20]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowInvalidOperationException_SerializerOptionsImmutable(System.Text.Json.Serialization.JsonSerializerContext)
       int       3
; Total bytes of code 212
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
       mov       rdx,7FFD67908318
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 90
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
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
       call      qword ptr [7FFD52B87420]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
       mov       r8,rax
       mov       rdx,rbx
       mov       rcx,rdi
       call      qword ptr [7FFD527E5A68]; System.Text.Json.JsonSerializer.Serialize(System.Object, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rcx,1DAF2407570
       mov       rax,[rcx]
       test      rax,rax
       jne       near ptr M01_L00
       mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdx,1DAF2407568
       mov       rdi,[rdx]
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FFD527E3168]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
       mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+40]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       byte ptr [rsi+84],0
       jne       short M01_L01
       cmp       byte ptr [rsi+84],0
       jne       short M01_L01
       lea       rcx,[rsi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       byte ptr [rsi+84],1
       lea       rcx,[rbx+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,1DAF2407570
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,rbx
M01_L00:
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L01:
       mov       rdx,[rsi+20]
       mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
       call      qword ptr [7FFD5237B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFD528DF810]
       int       3
; Total bytes of code 210
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
       call      qword ptr [7FFD527E5918]; System.Text.Json.JsonSerializer.ValidateInputType(System.Object, System.Type)
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFD527E5348]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
       mov       rdx,rax
       mov       rcx,rsi
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFD527E5A98]; System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
M02_L00:
       mov       ecx,2EB8
       mov       rdx,7FFD527CF118
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFD528DF018]
       int       3
; Total bytes of code 94
```

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],3
       jl        near ptr M01_L12
       lea       rcx,[rsi+0C]
       mov       rdx,22C4A849948
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L13
       lea       rcx,[rsi+0C]
       add       rcx,6
       mov       rdx,22C4A843090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       mov       rcx,rsi
M01_L00:
       test      rcx,rcx
       jne       short M01_L02
M01_L01:
       mov       eax,1
       jmp       near ptr M01_L14
M01_L02:
       cmp       dword ptr [rcx+8],0
       je        short M01_L01
       xor       eax,eax
       jmp       near ptr M01_L14
M01_L03:
       mov       rcx,22C4A843020
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L04:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rsi,rax
       call      System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rdi,rax
       cmp       byte ptr [rdi+85],0
       jne       short M01_L05
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializerOptions.InitializeForReflectionSerializer()
M01_L05:
       mov       rcx,22C4A84B0E0
       cmp       rsi,[rcx]
       je        short M01_L09
       mov       rbx,[rdi+10]
       test      rbx,rbx
       jne       short M01_L06
       xor       ecx,ecx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbx+0C0]
M01_L07:
       cmp       rcx,rsi
       je        short M01_L08
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,1
       xor       r9d,r9d
       call      System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, Boolean)
       mov       rbx,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rdx,rbx
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       rdx,rax
M01_L10:
       mov       r8,rdx
       test      r8,r8
       je        short M01_L11
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M01_L11
       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
       mov       r8,rax
M01_L11:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFD677461A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFD677461A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFD677461A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 695
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_Ref_PersonProper()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       call      qword ptr [7FFD527B9C00]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52BC7330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr M01_L03
       call      qword ptr [7FFD5282D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],3
       jl        near ptr M01_L05
       lea       rcx,[rsi+0C]
       mov       rdx,29F420005A0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFD524999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rsi+12]
       mov       rdx,29F46002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524999F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rsi+8],0
       je        short M01_L02
       mov       rcx,rsi
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,29F46002028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFD52825318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M01_L04
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M01_L04
       mov       rdx,rax
       call      qword ptr [7FFD523BB8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M01_L04:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFD52A25738]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525F1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFD5282D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52669A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52669A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD5282BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5282D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5282D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5262D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52453510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD5282D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD5262D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 571
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],3
       jl        near ptr M01_L12
       lea       rcx,[rsi+0C]
       mov       rdx,1A8AFC39948
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L13
       lea       rcx,[rsi+0C]
       add       rcx,6
       mov       rdx,1A8AFC33090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       mov       rcx,rsi
M01_L00:
       test      rcx,rcx
       jne       short M01_L02
M01_L01:
       mov       eax,1
       jmp       near ptr M01_L14
M01_L02:
       cmp       dword ptr [rcx+8],0
       je        short M01_L01
       xor       eax,eax
       jmp       near ptr M01_L14
M01_L03:
       mov       rcx,1A8AFC33020
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L04:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rsi,rax
       call      System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rdi,rax
       cmp       byte ptr [rdi+85],0
       jne       short M01_L05
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializerOptions.InitializeForReflectionSerializer()
M01_L05:
       mov       rcx,1A8AFC3A0C8
       cmp       rsi,[rcx]
       je        short M01_L09
       mov       rbx,[rdi+10]
       test      rbx,rbx
       jne       short M01_L06
       xor       ecx,ecx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbx+0C0]
M01_L07:
       cmp       rcx,rsi
       je        short M01_L08
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,1
       xor       r9d,r9d
       call      System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, Boolean)
       mov       rbx,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rdx,rbx
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       rdx,rax
M01_L10:
       mov       r8,rdx
       test      r8,r8
       je        short M01_L11
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M01_L11
       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
       mov       r8,rax
M01_L11:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFD677561A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 695
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_PersonRecord()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+48]
       call      qword ptr [7FFD52799C00]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52BA7330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr M01_L03
       call      qword ptr [7FFD5280D378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],3
       jl        near ptr M01_L05
       lea       rcx,[rsi+0C]
       mov       rdx,1E006808980
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rsi+12]
       mov       rdx,1E006802090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rsi+8],0
       je        short M01_L02
       mov       rcx,rsi
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,1E006802028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFD52805318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M01_L04
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M01_L04
       mov       rdx,rax
       call      qword ptr [7FFD5239B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M01_L04:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFD52A05738]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525D1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFD5280D498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52649A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD5280BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD5280D078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD5280D558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD5280D078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD5260D8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 571
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],3
       jl        near ptr M01_L12
       lea       rcx,[rsi+0C]
       mov       rdx,241F7889948
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L13
       lea       rcx,[rsi+0C]
       add       rcx,6
       mov       rdx,241F7883090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       mov       rcx,rsi
M01_L00:
       test      rcx,rcx
       jne       short M01_L02
M01_L01:
       mov       eax,1
       jmp       near ptr M01_L14
M01_L02:
       cmp       dword ptr [rcx+8],0
       je        short M01_L01
       xor       eax,eax
       jmp       near ptr M01_L14
M01_L03:
       mov       rcx,241F7883020
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L04:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rsi,rax
       call      System.Text.Json.JsonSerializerOptions.get_Default()
       mov       rdi,rax
       cmp       byte ptr [rdi+85],0
       jne       short M01_L05
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializerOptions.InitializeForReflectionSerializer()
M01_L05:
       mov       rcx,241F788B0E0
       cmp       rsi,[rcx]
       je        short M01_L09
       mov       rbx,[rdi+10]
       test      rbx,rbx
       jne       short M01_L06
       xor       ecx,ecx
       jmp       short M01_L07
M01_L06:
       mov       rcx,[rbx+0C0]
M01_L07:
       cmp       rcx,rsi
       je        short M01_L08
       mov       rcx,rdi
       mov       rdx,rsi
       mov       r8d,1
       xor       r9d,r9d
       call      System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, Boolean)
       mov       rbx,rax
       lea       rcx,[rdi+10]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
M01_L08:
       mov       rdx,rbx
       jmp       short M01_L10
M01_L09:
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
       mov       rdx,rax
M01_L10:
       mov       r8,rdx
       test      r8,r8
       je        short M01_L11
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M01_L11
       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
       mov       r8,rax
M01_L11:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L13:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L14:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L15
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFD677661A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 695
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_PersonProper_List()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+1A8]
       call      qword ptr [7FFD52789C00]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B953D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       test      rcx,rcx
       jne       near ptr M01_L03
       call      qword ptr [7FFD527FD378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],3
       jl        near ptr M01_L05
       lea       rcx,[rsi+0C]
       mov       rdx,19EDD404578
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rsi+12]
       mov       rdx,19EE1402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rsi+8],0
       je        short M01_L02
       mov       rcx,rsi
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,19EE1402028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFD527F5318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M01_L04
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M01_L04
       mov       rdx,rax
       call      qword ptr [7FFD5238B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M01_L04:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFD529F79F0]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525C1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFD527FD498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52639A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52639A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527FD078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527FD558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD525FD8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52423510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527FD078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525FD8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 571
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-30],rsp
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L04
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L06
       lea       rcx,[rdi+0C]
       mov       rdx,1EDDE2F9948
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L07
       lea       rcx,[rdi+0C]
       add       rcx,6
       mov       rdx,1EDDE2F3090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       mov       rcx,rdi
M01_L00:
       test      rcx,rcx
       jne       short M01_L02
M01_L01:
       mov       eax,1
       jmp       near ptr M01_L08
M01_L02:
       cmp       dword ptr [rcx+8],0
       je        short M01_L01
       xor       eax,eax
       jmp       near ptr M01_L08
M01_L03:
       mov       rcx,1EDDE2F3020
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L04:
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.IO.StringWriter..ctor()
       mov       rcx,rdi
       mov       [rbp-20],rcx
       call      System.Xml.XmlWriter.Create(System.IO.TextWriter)
       mov       [rbp-28],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,[rbp-28]
       mov       r8,rsi
       xor       r9d,r9d
       call      System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       mov       rcx,[rbp-20]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD6776B6B8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M01_L05
       mov       rcx,rdx
       mov       r11,7FFD674D0A70
       call      qword ptr [7FFD674D0A70]
       nop
M01_L05:
       mov       rcx,[rbp-20]
       mov       byte ptr [rcx+28],0
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L09
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFD677761A8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFD677761A8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFD677761A8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L09:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      System.ArgumentNullException..ctor(System.String, System.String)
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-28],0
       je        short M01_L10
       mov       rcx,[rbp-28]
       mov       r11,7FFD674D0A70
       call      qword ptr [7FFD674D0A70]
M01_L10:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-20],0
       je        short M01_L11
       mov       rcx,[rbp-20]
       mov       byte ptr [rcx+28],0
       call      System.GC.SuppressFinalize(System.Object)
M01_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 802
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_XML_Ref_PersonProper()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       call      qword ptr [7FFD52779F90]; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Serialize(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52B83FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Serialize(System.Object)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-20],rax
       mov       [rbp-30],rsp
       mov       rsi,rcx
       test      rsi,rsi
       jne       near ptr M01_L03
       call      qword ptr [7FFD527ED378]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L05
       lea       rcx,[rdi+0C]
       mov       rdx,28D840005A0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFD524599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rdi+12]
       mov       rdx,28D88002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rdi+8],0
       je        short M01_L02
       mov       rcx,rdi
M01_L00:
       test      rcx,rcx
       jne       short M01_L01
       mov       eax,1
       jmp       near ptr M01_L07
M01_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,28D88002028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFD52A75348]; System.IO.StringWriter..ctor()
       mov       rcx,rdi
       mov       [rbp-20],rcx
       call      qword ptr [7FFD52A75BA0]; System.Xml.XmlWriter.Create(System.IO.TextWriter)
       mov       [rbp-28],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFD52A771C8]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,[rbp-28]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFD52A77300]; System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       mov       rcx,[rbp-20]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFD52620080]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M01_L04
       mov       rcx,rdx
       mov       r11,7FFD521D09C0
       call      qword ptr [r11]
       nop
M01_L04:
       mov       rcx,[rbp-20]
       mov       byte ptr [rcx+28],0
       call      System.GC._SuppressFinalize(System.Object)
       mov       rax,rsi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L05:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFD527ED498]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52629A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52629A38
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD527EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527ED078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527ED558]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD525ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52413510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527ED078]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525ED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp-28],0
       je        short M01_L09
       mov       rcx,[rbp-28]
       mov       r11,7FFD521D09C0
       call      qword ptr [r11]
M01_L09:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp-20]
       mov       byte ptr [rcx+28],0
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 772
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       push      rsi
       mov       rsi,rcx
       mov       rdx,[r8]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       pop       rsi
       ret
; Total bytes of code 24
```

