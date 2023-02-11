## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_Ref()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]](System.String)
       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ByRef)
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
       mov       ecx,60F
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
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
       mov       rdx,7FF7B9FCC0D8
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_Ref()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+190]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]](System.String)
       call      qword ptr [7FFF7F59B300]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F5C95B8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F2C7150]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF7F2C7330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
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
       call      qword ptr [7FFF7F28BEA0]
       mov       rsi,rax
       mov       ecx,60F
       mov       rdx,7FFF7F0F8CA8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFF7F0F8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0F8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F28B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F28BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F28D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F05FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EED3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFF7F5A6510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFF7F59B360]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_Record()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+198]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]](System.String)
       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ByRef)
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
       mov       ecx,60F
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FF7B9B85440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B85440
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
       mov       rdx,7FF7B9FDC0D8
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_Record()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+198]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]](System.String)
       call      qword ptr [7FFF7F58B870]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F5BBCD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F2B7150]; System.Text.Json.JsonSerializerOptions..ctor()
       mov       rcx,rbx
       mov       edx,3
       call      qword ptr [7FFF7F2B7330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
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
       call      qword ptr [7FFF7F27BEA0]
       mov       rsi,rax
       mov       ecx,60F
       mov       rdx,7FFF7F0E8CA8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFF7F0E8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0E8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F27B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F27BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F27D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F04FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M01_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M01_L04
M01_L03:
       mov       rcx,rsi
       mov       rdx,7FFF7F596510
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L04:
       mov       rdx,rdi
       mov       r8,rbx
       call      qword ptr [7FFF7F58B8D0]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Xml_Ref()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+1A0]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.String)
       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper ByRef)
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
       mov       ecx,8CB
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
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
       mov       r11,7FF7B98E07A8
       call      qword ptr [7FF7B98E07A8]
       nop
M01_L04:
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       [rax+14],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FF7B9B52620]; System.IO.TextReader.Dispose(Boolean)
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
       mov       r11,7FF7B98E07A8
       call      qword ptr [7FF7B98E07A8]
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
       call      qword ptr [7FF7B9B52620]; System.IO.TextReader.Dispose(Boolean)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Xml_Ref()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+1A0]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.String)
       call      qword ptr [7FFF7F5AB870]; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F5F3EA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F29BEA0]
       mov       rsi,rax
       mov       ecx,8CB
       mov       rdx,7FFF7F108CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7F108CA8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F108CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F29B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F29BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F29D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F06FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [7FFF7EEE3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFF7F549C90]; System.Xml.XmlReader.Create(System.IO.TextReader)
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
       call      qword ptr [7FFF7F4AD108]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
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
       call      qword ptr [7FFF7F4AD300]; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7EE4B858]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rsi,rax
       mov       rax,[rbp-58]
       test      rax,rax
       je        short M01_L03
       mov       rcx,rax
       mov       r11,7FFF7ECA0718
       call      qword ptr [r11]
       nop
M01_L03:
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFF7F0591F0]; System.IO.TextReader.Dispose(Boolean)
       mov       rcx,[rbp-50]
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
       call      qword ptr [7FFF7F0C77B0]
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
       mov       r11,7FFF7ECA0718
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
       mov       edx,1
       call      qword ptr [7FFF7F0591F0]; System.IO.TextReader.Dispose(Boolean)
       mov       rcx,[rbp-50]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 650
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Xml_Record()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+1A8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]](System.String)
       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ByRef)
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
       mov       ecx,8CB
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF7B9B75440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B75440
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
       mov       r11,7FF7B98C07E0
       call      qword ptr [7FF7B98C07E0]
       nop
M01_L04:
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       [rax+14],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FF7B9B32620]; System.IO.TextReader.Dispose(Boolean)
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
       mov       r11,7FF7B98C07E0
       call      qword ptr [7FF7B98C07E0]
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
       call      qword ptr [7FF7B9B32620]; System.IO.TextReader.Dispose(Boolean)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Xml_Record()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+1A8]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]](System.String)
       call      qword ptr [7FFF7F58B300]; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, dotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F5D37F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F27BEA0]
       mov       rsi,rax
       mov       ecx,8CB
       mov       rdx,7FFF7F0E8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0E8CA8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0E8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F27B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F27BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F27D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F04FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L02:
       cmp       [rdx],dl
       mov       rcx,rdx
       mov       edx,3
       call      qword ptr [7FFF7EEC3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
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
       call      qword ptr [7FFF7F529C90]; System.Xml.XmlReader.Create(System.IO.TextReader)
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
       call      qword ptr [7FFF7F48D108]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
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
       call      qword ptr [7FFF7F48D300]; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7EE2B858]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rsi,rax
       mov       rax,[rbp-58]
       test      rax,rax
       je        short M01_L03
       mov       rcx,rax
       mov       r11,7FFF7EC80718
       call      qword ptr [r11]
       nop
M01_L03:
       xor       ecx,ecx
       mov       rax,[rbp-50]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFF7F0391F0]; System.IO.TextReader.Dispose(Boolean)
       mov       rcx,[rbp-50]
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
       call      qword ptr [7FFF7F0A77B0]
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
       mov       r11,7FFF7EC80718
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
       mov       edx,1
       call      qword ptr [7FFF7F0391F0]; System.IO.TextReader.Dispose(Boolean)
       mov       rcx,[rbp-50]
       call      System.GC._SuppressFinalize(System.Object)
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 650
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_Ref()
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
       mov       rdx,2ADF5739948
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
       mov       rdx,2ADF5733090
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
       mov       rcx,2ADF5733020
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
       mov       rcx,2AE15733248
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
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_Ref()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       call      qword ptr [7FFF7F217BE8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F56B330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F25BD80]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],3
       jl        near ptr M01_L05
       lea       rcx,[rsi+0C]
       mov       rdx,18C88008980
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rsi+12]
       mov       rdx,18C88002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,18C88002028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFF7F293318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M01_L04
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M01_L04
       mov       rdx,rax
       call      qword ptr [7FFF7EE0B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M01_L04:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFF7F361120]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       call      qword ptr [7FFF7F051C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F051C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF7F25BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0C8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0C8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F25B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 571
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_Record()
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
       mov       rdx,20862DA9948
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
       mov       rdx,20862DA3090
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
       mov       rcx,20862DA3020
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
       mov       rcx,20862DACE58
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
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF7B9BA5440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9BA5440
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_Record()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+48]
       call      qword ptr [7FFF7F217BE8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F56B8A0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F25BD80]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],3
       jl        near ptr M01_L05
       lea       rcx,[rsi+0C]
       mov       rdx,261E5C08980
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rsi+12]
       mov       rdx,261E5C02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,261E5C02028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       [rsp+28],rcx
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       xor       ecx,ecx
       call      qword ptr [7FFF7F293318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
       mov       r8,rax
       test      r8,r8
       je        short M01_L04
       mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
       cmp       [r8],rcx
       je        short M01_L04
       mov       rdx,rax
       call      qword ptr [7FFF7EE0B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
       mov       r8,rax
M01_L04:
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
       call      qword ptr [7FFF7F361120]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
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
       call      qword ptr [7FFF7F051C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F051C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF7F25BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0C8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0C8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F25B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F25D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F25BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F02FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 571
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_XML_Ref()
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
       mov       rdx,257B8211568
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
       mov       rdx,25838213090
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
       mov       rcx,25838213020
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
       call      qword ptr [7FF7B9B8AC58]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M01_L05
       mov       rcx,rdx
       mov       r11,7FF7B98E0818
       call      qword ptr [7FF7B98E0818]
       nop
M01_L05:
       mov       rcx,[rbp-20]
       mov       byte ptr [rcx+28],0
       mov       edx,1
       call      qword ptr [7FF7B9B51958]; System.IO.TextWriter.Dispose(Boolean)
       mov       rcx,[rbp-20]
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
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FF7B9B95440
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FF7B9B95440
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
       mov       r11,7FF7B98E0818
       call      qword ptr [7FF7B98E0818]
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
       mov       edx,1
       call      qword ptr [7FF7B9B51958]; System.IO.TextWriter.Dispose(Boolean)
       mov       rcx,[rbp-20]
       call      System.GC.SuppressFinalize(System.Object)
M01_L11:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 832
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
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_XML_Ref()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       call      qword ptr [7FFF7F227F78]; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Serialize(System.Object)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F57B330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F26BD80]
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L05
       lea       rcx,[rdi+0C]
       mov       rdx,2A9BEC08980
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rdi+12]
       mov       rdx,2A9BEC02090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEF99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,2A9BEC02028
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L03:
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7F479B88]; System.IO.StringWriter..ctor()
       mov       rcx,rdi
       mov       [rbp-20],rcx
       call      qword ptr [7FFF7F47B5D0]; System.Xml.XmlWriter.Create(System.IO.TextWriter)
       mov       [rbp-28],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      System.Object.GetType()
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFF7F47D108]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,[rbp-28]
       mov       r8,rsi
       xor       r9d,r9d
       call      qword ptr [7FFF7F47D240]; System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       mov       rcx,[rbp-20]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F0AF3F8]; System.Text.StringBuilder.ToString()
       mov       rsi,rax
       mov       rdx,[rbp-28]
       test      rdx,rdx
       je        short M01_L04
       mov       rcx,rdx
       mov       r11,7FFF7EC70730
       call      qword ptr [r11]
       nop
M01_L04:
       mov       rcx,[rbp-20]
       mov       byte ptr [rcx+28],0
       mov       edx,1
       call      qword ptr [7FFF7F028500]; System.IO.TextWriter.Dispose(Boolean)
       mov       rcx,[rbp-20]
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
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L08
       call      qword ptr [7FFF7F26BEA0]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0D8CA8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0D8CA8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F26B438]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F26D000]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L08:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEB3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F26BAC8]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F03FF18]
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
       mov       r11,7FFF7EC70730
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
       mov       edx,1
       call      qword ptr [7FFF7F028500]; System.IO.TextWriter.Dispose(Boolean)
       mov       rcx,[rbp-20]
       call      System.GC._SuppressFinalize(System.Object)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

