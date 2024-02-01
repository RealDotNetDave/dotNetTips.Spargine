## DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark-20240129-213123
**Diff for Deserialize_Json_JsonSerializer_Generator_PersonProper_List method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
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
-       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
+       call      qword ptr [7FF9CF795420]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rdi
-       call      System.Text.Json.JsonSerializer.Deserialize(System.String, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
+       call      qword ptr [7FF9CF3F5708]; System.Text.Json.JsonSerializer.Deserialize(System.String, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
        mov       rdx,rax
        mov       rcx,offset MT_System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
-       call      CORINFO_HELP_ISINSTANCEOFCLASS
+       call      qword ptr [7FF9CEF8B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
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
-; Total bytes of code 116
+; Total bytes of code 119
 ; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
        push      rdi
        push      rsi
-       sub       rsp,28
-       mov       rcx,264BC714168
+       push      rbx
+       sub       rsp,20
+       mov       rcx,1DB90007578
        mov       rax,[rcx]
        test      rax,rax
        jne       near ptr M01_L00
        mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,264BC714160
-       mov       rdx,[rdx]
+       mov       rdx,1DB90007570
+       mov       rdi,[rdx]
+       mov       rdx,rdi
        mov       rcx,rsi
-       call      System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
+       call      qword ptr [7FF9CF3F3168]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
        call      CORINFO_HELP_NEWSFAST
-       mov       rdi,rax
-       mov       rdx,264BC714160
-       mov       rdx,[rdx]
-       lea       rcx,[rdi+40]
+       mov       rbx,rax
+       lea       rcx,[rbx+40]
+       mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       byte ptr [rsi+84],0
        jne       short M01_L01
        cmp       byte ptr [rsi+84],0
        jne       short M01_L01
        lea       rcx,[rsi+20]
-       mov       rdx,rdi
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       byte ptr [rsi+84],1
-       lea       rcx,[rdi+8]
+       lea       rcx,[rbx+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,264BC714168
-       mov       rdx,rdi
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
-       mov       rax,rdi
+       mov       rcx,1DB90007578
+       mov       rdx,rbx
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rax,rbx
 M01_L00:
-       add       rsp,28
+       add       rsp,20
+       pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rdx,[rsi+20]
        mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
-       call      CORINFO_HELP_ISINSTANCEOFCLASS
+       call      qword ptr [7FF9CEF8B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       rcx,rax
-       call      System.Text.Json.ThrowHelper.ThrowInvalidOperationException_SerializerOptionsImmutable(System.Text.Json.Serialization.JsonSerializerContext)
+       call      qword ptr [7FF9CF4EF810]
        int       3
-; Total bytes of code 212
+; Total bytes of code 210
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
-       call      System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
+       call      qword ptr [7FF9CF3F5348]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
        mov       r8,rax
        lea       rdx,[rsi+0C]
        mov       ecx,[rsi+8]
        mov       [rsp+20],rdx
        mov       [rsp+28],ecx
        lea       rdx,[rsp+20]
        mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[System.Object, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
-       call      System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
+       call      qword ptr [7FF9CF795510]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
        nop
        add       rsp,30
        pop       rsi
        ret
 M02_L00:
        mov       ecx,2C1E
-       mov       rdx,7FF9DB988B80
+       mov       rdx,7FF9CF3DF730
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
+       call      qword ptr [7FF9CF4EF018]
        int       3
 M02_L01:
        mov       ecx,2E88
-       mov       rdx,7FF9DB988B80
+       mov       rdx,7FF9CF3DF730
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
+       call      qword ptr [7FF9CF4EF018]
        int       3
 M02_L02:
        mov       ecx,2EB8
-       mov       rdx,7FF9DB988B80
+       mov       rdx,7FF9CF3DF730
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
+       call      qword ptr [7FF9CF4EF018]
        int       3
-; Total bytes of code 171
+; Total bytes of code 176
+; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
+       mov       rax,rdx
+       test      rax,rax
+       je        short M03_L00
+       cmp       [rax],rcx
+       jne       short M03_L01
+M03_L00:
+       ret
+M03_L01:
+       mov       rdx,[rax]
+       mov       rdx,[rdx+10]
+M03_L02:
+       cmp       rdx,rcx
+       je        short M03_L04
+       test      rdx,rdx
+       je        short M03_L03
+       mov       rdx,[rdx+10]
+       cmp       rdx,rcx
+       je        short M03_L04
+       test      rdx,rdx
+       je        short M03_L03
+       mov       rdx,[rdx+10]
+       cmp       rdx,rcx
+       je        short M03_L04
+       test      rdx,rdx
+       je        short M03_L03
+       mov       rdx,[rdx+10]
+       cmp       rdx,rcx
+       je        short M03_L04
+       test      rdx,rdx
+       jne       short M03_L05
+M03_L03:
+       xor       eax,eax
+M03_L04:
+       ret
+M03_L05:
+       mov       rdx,[rdx+10]
+       jmp       short M03_L02
+; Total bytes of code 82
```
**Diff for Deserialize_Json_JsonSerializer_Generator_PersonProper method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
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
-       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
+       call      qword ptr [7FF9CF787120]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rdi
-       call      System.Text.Json.JsonSerializer.Deserialize(System.String, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
+       call      qword ptr [7FF9CF3E5708]; System.Text.Json.JsonSerializer.Deserialize(System.String, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
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
-; Total bytes of code 120
+; Total bytes of code 122
 ; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
        push      rdi
        push      rsi
-       sub       rsp,28
-       mov       rcx,16701528570
+       push      rbx
+       sub       rsp,20
+       mov       rcx,19B47407578
        mov       rax,[rcx]
        test      rax,rax
        jne       near ptr M01_L00
        mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,16701528568
-       mov       rdx,[rdx]
+       mov       rdx,19B47407570
+       mov       rdi,[rdx]
+       mov       rdx,rdi
        mov       rcx,rsi
-       call      System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
+       call      qword ptr [7FF9CF3E3168]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
        call      CORINFO_HELP_NEWSFAST
-       mov       rdi,rax
-       mov       rdx,16701528568
-       mov       rdx,[rdx]
-       lea       rcx,[rdi+40]
+       mov       rbx,rax
+       lea       rcx,[rbx+40]
+       mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       byte ptr [rsi+84],0
        jne       short M01_L01
        cmp       byte ptr [rsi+84],0
        jne       short M01_L01
        lea       rcx,[rsi+20]
-       mov       rdx,rdi
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       byte ptr [rsi+84],1
-       lea       rcx,[rdi+8]
+       lea       rcx,[rbx+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,16701528570
-       mov       rdx,rdi
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
-       mov       rax,rdi
+       mov       rcx,19B47407578
+       mov       rdx,rbx
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rax,rbx
 M01_L00:
-       add       rsp,28
+       add       rsp,20
+       pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rdx,[rsi+20]
        mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
-       call      CORINFO_HELP_ISINSTANCEOFCLASS
+       call      qword ptr [7FF9CEF7B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       rcx,rax
-       call      System.Text.Json.ThrowHelper.ThrowInvalidOperationException_SerializerOptionsImmutable(System.Text.Json.Serialization.JsonSerializerContext)
+       call      qword ptr [7FF9CF4DF810]
        int       3
-; Total bytes of code 212
+; Total bytes of code 210
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
-       call      System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
+       call      qword ptr [7FF9CF3E5348]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
        mov       r8,rax
        lea       rdx,[rsi+0C]
        mov       ecx,[rsi+8]
        mov       [rsp+20],rdx
        mov       [rsp+28],ecx
        lea       rdx,[rsp+20]
        mov       rcx,offset MD_System.Text.Json.JsonSerializer.ReadFromSpan[[System.Object, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
-       call      System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
+       call      qword ptr [7FF9CF787210]; System.Text.Json.JsonSerializer.ReadFromSpan[[System.__Canon, System.Private.CoreLib]](System.ReadOnlySpan`1<Char>, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
        nop
        add       rsp,30
        pop       rsi
        ret
 M02_L00:
        mov       ecx,2C1E
-       mov       rdx,7FF9DB978B80
+       mov       rdx,7FF9CF3CF730
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
+       call      qword ptr [7FF9CF4DF018]
        int       3
 M02_L01:
        mov       ecx,2E88
-       mov       rdx,7FF9DB978B80
+       mov       rdx,7FF9CF3CF730
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
+       call      qword ptr [7FF9CF4DF018]
        int       3
 M02_L02:
        mov       ecx,2EB8
-       mov       rdx,7FF9DB978B80
+       mov       rdx,7FF9CF3CF730
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
+       call      qword ptr [7FF9CF4DF018]
        int       3
-; Total bytes of code 171
+; Total bytes of code 176
```
**Diff for Deserialize_Json_PersonRecord method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_PersonRecord()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+198]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](System.String)
-       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
+       call      qword ptr [7FF9CF785300]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9CF789798]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 75
+; Total bytes of code 77
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
-       call      System.Text.Json.JsonSerializerOptions..ctor()
+       call      qword ptr [7FF9CF3E3150]; System.Text.Json.JsonSerializerOptions..ctor()
        mov       rcx,rbx
        mov       edx,3
-       call      System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
+       call      qword ptr [7FF9CF3E3330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
        mov       rcx,rdi
        test      rcx,rcx
-       je        near ptr M01_L02
-       cmp       dword ptr [rcx+8],0
-       je        near ptr M01_L02
-       xor       eax,eax
-M01_L00:
+       je        short M01_L00
+       mov       eax,[rcx+8]
+       xor       edx,edx
        test      eax,eax
-       sete      al
-       movzx     eax,al
+       sete      dl
+       test      edx,edx
+       sete      dl
+       movzx     edx,dl
        test      eax,eax
-       jne       near ptr M01_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
+       jne       short M01_L01
+       jmp       short M01_L01
+M01_L00:
+       xor       edx,edx
+M01_L01:
+       test      edx,edx
+       jne       near ptr M01_L02
+       call      qword ptr [7FF9CF3ED498]
        mov       rsi,rax
-       mov       ecx,637
-       mov       rdx,7FF9DB7A6A60
+       mov       ecx,0B50
+       mov       rdx,7FF9CF229CC8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
-       mov       ecx,9
-       mov       rdx,7FF9DB7A6A60
+       mov       ecx,536
+       mov       rdx,7FF9CF229CC8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
-       mov       ecx,3A1
-       mov       rdx,7FF9DB7A6A60
+       mov       ecx,8BA
+       mov       rdx,7FF9CF229CC8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rbx
        mov       r9,rdi
        mov       [rsp+20],rax
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9CF3EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       rdi,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
+       call      qword ptr [7FF9CF3ED078]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
+       call      qword ptr [7FF9CF3ED600]
        mov       r8,rax
        mov       rdx,rdi
        mov       rcx,rbx
-       call      System.ArgumentNullException..ctor(System.String, System.String)
+       call      qword ptr [7FF9CF1ED8E8]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
-M01_L01:
-       cmp       [rcx],ecx
+M01_L02:
+       cmp       [rcx],cl
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        mov       rdi,rax
        mov       rcx,[rsi+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L03
        mov       rcx,[rsi+10]
        mov       rcx,[rcx+10]
        jmp       short M01_L04
-M01_L02:
-       mov       eax,1
-       jmp       near ptr M01_L00
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FF9DBD136F8
+       mov       rdx,7FF9CF76E118
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L04:
        mov       rdx,rdi
        mov       r8,rbx
-       call      System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
+       call      qword ptr [7FF9CF785360]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
        nop
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 341
+; Total bytes of code 342
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for Deserialize_Json_PersonProper_List method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Json_PersonProper_List()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+190]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.String)
-       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
+       call      qword ptr [7FF9CF7A3FA8]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.List`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.List`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9CF7A5288]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 75
+; Total bytes of code 77
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
-       call      System.Text.Json.JsonSerializerOptions..ctor()
+       call      qword ptr [7FF9CF403150]; System.Text.Json.JsonSerializerOptions..ctor()
        mov       rcx,rbx
        mov       edx,3
-       call      System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
+       call      qword ptr [7FF9CF403330]; System.Text.Json.JsonSerializerOptions.set_NumberHandling(System.Text.Json.Serialization.JsonNumberHandling)
        mov       rcx,rdi
        test      rcx,rcx
-       je        near ptr M01_L02
-       cmp       dword ptr [rcx+8],0
-       je        near ptr M01_L02
-       xor       eax,eax
-M01_L00:
+       je        short M01_L00
+       mov       eax,[rcx+8]
+       xor       edx,edx
        test      eax,eax
-       sete      al
-       movzx     eax,al
+       sete      dl
+       test      edx,edx
+       sete      dl
+       movzx     edx,dl
        test      eax,eax
-       jne       near ptr M01_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
+       jne       short M01_L01
+       jmp       short M01_L01
+M01_L00:
+       xor       edx,edx
+M01_L01:
+       test      edx,edx
+       jne       near ptr M01_L02
+       call      qword ptr [7FF9CF40D498]
        mov       rsi,rax
-       mov       ecx,637
-       mov       rdx,7FF9DB7C6A60
+       mov       ecx,0B50
+       mov       rdx,7FF9CF249CC8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
-       mov       ecx,9
-       mov       rdx,7FF9DB7C6A60
+       mov       ecx,536
+       mov       rdx,7FF9CF249CC8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
-       mov       ecx,3A1
-       mov       rdx,7FF9DB7C6A60
+       mov       ecx,8BA
+       mov       rdx,7FF9CF249CC8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rbx
        mov       r9,rdi
        mov       [rsp+20],rax
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9CF40BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       rdi,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
+       call      qword ptr [7FF9CF40D078]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
+       call      qword ptr [7FF9CF40D600]
        mov       r8,rax
        mov       rdx,rdi
        mov       rcx,rbx
-       call      System.ArgumentNullException..ctor(System.String, System.String)
+       call      qword ptr [7FF9CF20D8E8]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
-M01_L01:
-       cmp       [rcx],ecx
+M01_L02:
+       cmp       [rcx],cl
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       call      qword ptr [7FF9CF033510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        mov       rdi,rax
        mov       rcx,[rsi+10]
        cmp       qword ptr [rcx+10],0
        je        short M01_L03
        mov       rcx,[rsi+10]
        mov       rcx,[rcx+10]
        jmp       short M01_L04
-M01_L02:
-       mov       eax,1
-       jmp       near ptr M01_L00
 M01_L03:
        mov       rcx,rsi
-       mov       rdx,7FF9DBD32A20
+       mov       rdx,7FF9CF78D9E8
        call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
        mov       rcx,rax
 M01_L04:
        mov       rdx,rdi
        mov       r8,rbx
-       call      System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
+       call      qword ptr [7FF9CF7A5018]; System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
        nop
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 341
+; Total bytes of code 342
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for Deserialize_Xml_Ref_PersonProper method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Xml_Ref_PersonProper()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+1B8]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.String)
-       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
+       call      qword ptr [7FF9CF7A7300]; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9CF7CDEA0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 75
+; Total bytes of code 77
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
-       je        near ptr M01_L02
-       cmp       dword ptr [rdx+8],0
-       je        near ptr M01_L02
+       je        short M01_L00
        xor       eax,eax
-M01_L00:
+       cmp       dword ptr [rdx+8],0
+       sete      al
        test      eax,eax
        sete      al
        movzx     eax,al
+       cmp       dword ptr [rdx+8],0
+       jne       short M01_L01
+       jmp       short M01_L01
+M01_L00:
+       xor       eax,eax
+M01_L01:
        test      eax,eax
-       jne       near ptr M01_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
+       jne       near ptr M01_L02
+       call      qword ptr [7FF9CF40D498]
        mov       rsi,rax
-       mov       ecx,897
-       mov       rdx,7FF9DB7C6A60
+       mov       ecx,0DB0
+       mov       rdx,7FF9CF249CC8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
-       mov       ecx,9
-       mov       rdx,7FF9DB7C6A60
+       mov       ecx,536
+       mov       rdx,7FF9CF249CC8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
-       mov       ecx,3A1
-       mov       rdx,7FF9DB7C6A60
+       mov       ecx,8BA
+       mov       rdx,7FF9CF249CC8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rdi
        mov       r9,rbx
        mov       [rsp+20],rax
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9CF40BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       rdi,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
+       call      qword ptr [7FF9CF40D078]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
+       call      qword ptr [7FF9CF40D600]
        mov       r8,rax
        mov       rdx,rdi
        mov       rcx,rbx
-       call      System.ArgumentNullException..ctor(System.String, System.String)
+       call      qword ptr [7FF9CF20D8E8]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
-M01_L01:
-       cmp       [rdx],edx
+M01_L02:
+       cmp       [rdx],dl
        mov       rcx,rdx
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       call      qword ptr [7FF9CF033510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        mov       rdi,rax
        mov       rcx,offset MT_System.IO.StringReader
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        test      rdi,rdi
-       je        near ptr M01_L05
+       je        near ptr M01_L04
        lea       rcx,[rbx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
-       mov       ecx,[rdi+8]
-       mov       [rbx+14],ecx
        mov       rcx,rbx
        mov       [rbp-50],rcx
-       jmp       short M01_L03
-M01_L02:
-       mov       eax,1
-       jmp       near ptr M01_L00
-M01_L03:
-       call      System.Xml.XmlReader.Create(System.IO.TextReader)
+       call      qword ptr [7FF9CF741C90]; System.Xml.XmlReader.Create(System.IO.TextReader)
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
-       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
+       call      qword ptr [7FF9CF6891C8]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
        mov       rsi,[rsi]
        mov       rcx,rdi
        mov       rax,[rbp-58]
        mov       rdx,rax
-       vmovdqu   xmm0,xmmword ptr [rdi+38]
-       vmovdqu   xmmword ptr [rbp-48],xmm0
-       vmovdqu   xmm0,xmmword ptr [rdi+48]
-       vmovdqu   xmmword ptr [rbp-38],xmm0
-       mov       r9,[rdi+58]
+       vmovdqu   ymm0,ymmword ptr [rcx+38]
+       vmovdqu   ymmword ptr [rbp-48],ymm0
+       mov       r9,[rcx+58]
        mov       [rbp-28],r9
        lea       r9,[rbp-48]
        xor       r8d,r8d
-       call      System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
+       call      qword ptr [7FF9CF6893C0]; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
        mov       rdx,rax
        mov       rcx,rsi
-       call      CORINFO_HELP_CHKCASTARRAY
+       call      qword ptr [7FF9CEF9B858]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
        mov       rsi,rax
        mov       rax,[rbp-58]
        test      rax,rax
-       je        short M01_L04
+       je        short M01_L03
        mov       rcx,rax
-       mov       r11,7FF9DB510A50
-       call      qword ptr [7FF9DB510A50]
+       mov       r11,7FF9CEDF09E0
+       call      qword ptr [r11]
        nop
-M01_L04:
+M01_L03:
        xor       ecx,ecx
        mov       rax,[rbp-50]
        mov       [rax+8],rcx
        mov       [rax+10],ecx
-       mov       [rax+14],ecx
        mov       rcx,rax
        mov       edx,1
-       call      qword ptr [7FF9DB773740]; System.IO.TextReader.Dispose(Boolean)
+       call      qword ptr [7FF9CF19A070]; System.IO.TextReader.Dispose(Boolean)
        mov       rcx,[rbp-50]
-       call      System.GC.SuppressFinalize(System.Object)
+       call      System.GC._SuppressFinalize(System.Object)
        mov       rax,rsi
        add       rsp,78
        pop       rbx
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-M01_L05:
+M01_L04:
        mov       ecx,11
-       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
+       call      qword ptr [7FF9CF2077B0]
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
-       je        short M01_L06
+       je        short M01_L05
        mov       rcx,[rbp-58]
-       mov       r11,7FF9DB510A50
-       call      qword ptr [7FF9DB510A50]
-M01_L06:
+       mov       r11,7FF9CEDF09E0
+       call      qword ptr [r11]
+M01_L05:
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
-       cmp       qword ptr [rbp-50],0
-       je        short M01_L07
        xor       ecx,ecx
        mov       rax,[rbp-50]
        mov       [rax+8],rcx
        mov       [rax+10],ecx
-       mov       [rax+14],ecx
        mov       rcx,rax
        mov       edx,1
-       call      qword ptr [7FF9DB773740]; System.IO.TextReader.Dispose(Boolean)
+       call      qword ptr [7FF9CF19A070]; System.IO.TextReader.Dispose(Boolean)
        mov       rcx,[rbp-50]
-       call      System.GC.SuppressFinalize(System.Object)
-M01_L07:
+       call      System.GC._SuppressFinalize(System.Object)
        nop
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 683
+; Total bytes of code 650
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for Deserialize_Xml_PersonRecord method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize_Xml_PersonRecord()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rdx,[rsi+1B0]
        mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](System.String)
-       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
+       call      qword ptr [7FF9CF765300]; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord, DotNetTips.Spargine.6.Tester]](DotNetTips.Spargine.Tester.Models.RefTypes.PersonRecord ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9CF78D7F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 75
+; Total bytes of code 77
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
-       je        near ptr M01_L02
-       cmp       dword ptr [rdx+8],0
-       je        near ptr M01_L02
+       je        short M01_L00
        xor       eax,eax
-M01_L00:
+       cmp       dword ptr [rdx+8],0
+       sete      al
        test      eax,eax
        sete      al
        movzx     eax,al
+       cmp       dword ptr [rdx+8],0
+       jne       short M01_L01
+       jmp       short M01_L01
+M01_L00:
+       xor       eax,eax
+M01_L01:
        test      eax,eax
-       jne       near ptr M01_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
+       jne       near ptr M01_L02
+       call      qword ptr [7FF9CF3CD498]
        mov       rsi,rax
-       mov       ecx,897
-       mov       rdx,7FF9DB7C6A60
+       mov       ecx,0DB0
+       mov       rdx,7FF9CF209CC8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
-       mov       ecx,9
-       mov       rdx,7FF9DB7C6A60
+       mov       ecx,536
+       mov       rdx,7FF9CF209CC8
        call      CORINFO_HELP_STRCNS
        mov       rbx,rax
-       mov       ecx,3A1
-       mov       rdx,7FF9DB7C6A60
+       mov       ecx,8BA
+       mov       rdx,7FF9CF209CC8
        call      CORINFO_HELP_STRCNS
        mov       rcx,rdi
        mov       r9,rbx
        mov       [rsp+20],rax
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9CF3CBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       rdi,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
+       call      qword ptr [7FF9CF3CD078]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
+       call      qword ptr [7FF9CF3CD600]
        mov       r8,rax
        mov       rdx,rdi
        mov       rcx,rbx
-       call      System.ArgumentNullException..ctor(System.String, System.String)
+       call      qword ptr [7FF9CF1CD8E8]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
-M01_L01:
-       cmp       [rdx],edx
+M01_L02:
+       cmp       [rdx],dl
        mov       rcx,rdx
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       call      qword ptr [7FF9CEFF3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        mov       rdi,rax
        mov       rcx,offset MT_System.IO.StringReader
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
        test      rdi,rdi
-       je        near ptr M01_L05
+       je        near ptr M01_L04
        lea       rcx,[rbx+8]
        mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
-       mov       ecx,[rdi+8]
-       mov       [rbx+14],ecx
        mov       rcx,rbx
        mov       [rbp-50],rcx
-       jmp       short M01_L03
-M01_L02:
-       mov       eax,1
-       jmp       near ptr M01_L00
-M01_L03:
-       call      System.Xml.XmlReader.Create(System.IO.TextReader)
+       call      qword ptr [7FF9CF701C90]; System.Xml.XmlReader.Create(System.IO.TextReader)
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
-       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
+       call      qword ptr [7FF9CF6491C8]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
        mov       rsi,[rsi]
        mov       rcx,rdi
        mov       rax,[rbp-58]
        mov       rdx,rax
-       vmovdqu   xmm0,xmmword ptr [rdi+38]
-       vmovdqu   xmmword ptr [rbp-48],xmm0
-       vmovdqu   xmm0,xmmword ptr [rdi+48]
-       vmovdqu   xmmword ptr [rbp-38],xmm0
-       mov       r9,[rdi+58]
+       vmovdqu   ymm0,ymmword ptr [rcx+38]
+       vmovdqu   ymmword ptr [rbp-48],ymm0
+       mov       r9,[rcx+58]
        mov       [rbp-28],r9
        lea       r9,[rbp-48]
        xor       r8d,r8d
-       call      System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
+       call      qword ptr [7FF9CF6493C0]; System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
        mov       rdx,rax
        mov       rcx,rsi
-       call      CORINFO_HELP_CHKCASTARRAY
+       call      qword ptr [7FF9CEF5B858]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
        mov       rsi,rax
        mov       rax,[rbp-58]
        test      rax,rax
-       je        short M01_L04
+       je        short M01_L03
        mov       rcx,rax
-       mov       r11,7FF9DB510A88
-       call      qword ptr [7FF9DB510A88]
+       mov       r11,7FF9CEDB09D8
+       call      qword ptr [r11]
        nop
-M01_L04:
+M01_L03:
        xor       ecx,ecx
        mov       rax,[rbp-50]
        mov       [rax+8],rcx
        mov       [rax+10],ecx
-       mov       [rax+14],ecx
        mov       rcx,rax
        mov       edx,1
-       call      qword ptr [7FF9DB773740]; System.IO.TextReader.Dispose(Boolean)
+       call      qword ptr [7FF9CF15A070]; System.IO.TextReader.Dispose(Boolean)
        mov       rcx,[rbp-50]
-       call      System.GC.SuppressFinalize(System.Object)
+       call      System.GC._SuppressFinalize(System.Object)
        mov       rax,rsi
        add       rsp,78
        pop       rbx
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-M01_L05:
+M01_L04:
        mov       ecx,11
-       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
+       call      qword ptr [7FF9CF1C77B0]
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
-       je        short M01_L06
+       je        short M01_L05
        mov       rcx,[rbp-58]
-       mov       r11,7FF9DB510A88
-       call      qword ptr [7FF9DB510A88]
-M01_L06:
+       mov       r11,7FF9CEDB09D8
+       call      qword ptr [r11]
+M01_L05:
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
-       cmp       qword ptr [rbp-50],0
-       je        short M01_L07
        xor       ecx,ecx
        mov       rax,[rbp-50]
        mov       [rax+8],rcx
        mov       [rax+10],ecx
-       mov       [rax+14],ecx
        mov       rcx,rax
        mov       edx,1
-       call      qword ptr [7FF9DB773740]; System.IO.TextReader.Dispose(Boolean)
+       call      qword ptr [7FF9CF15A070]; System.IO.TextReader.Dispose(Boolean)
        mov       rcx,[rbp-50]
-       call      System.GC.SuppressFinalize(System.Object)
-M01_L07:
+       call      System.GC._SuppressFinalize(System.Object)
        nop
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 683
+; Total bytes of code 650
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for Serialize_Json_JsonSerializer_Generator_PersonProper_List method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
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
-       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
+       call      qword ptr [7FF9CF777120]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rdi
-       call      System.Text.Json.JsonSerializer.Serialize(System.Object, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
+       call      qword ptr [7FF9CF3D5A68]; System.Text.Json.JsonSerializer.Serialize(System.Object, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
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
-; Total bytes of code 98
+; Total bytes of code 100
 ; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
        push      rdi
        push      rsi
-       sub       rsp,28
-       mov       rcx,272E6966160
+       push      rbx
+       sub       rsp,20
+       mov       rcx,20D7D807578
        mov       rax,[rcx]
        test      rax,rax
        jne       near ptr M01_L00
        mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,272E6966158
-       mov       rdx,[rdx]
+       mov       rdx,20D7D807570
+       mov       rdi,[rdx]
+       mov       rdx,rdi
        mov       rcx,rsi
-       call      System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
+       call      qword ptr [7FF9CF3D3168]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
        call      CORINFO_HELP_NEWSFAST
-       mov       rdi,rax
-       mov       rdx,272E6966158
-       mov       rdx,[rdx]
-       lea       rcx,[rdi+40]
+       mov       rbx,rax
+       lea       rcx,[rbx+40]
+       mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       byte ptr [rsi+84],0
        jne       short M01_L01
        cmp       byte ptr [rsi+84],0
        jne       short M01_L01
        lea       rcx,[rsi+20]
-       mov       rdx,rdi
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       byte ptr [rsi+84],1
-       lea       rcx,[rdi+8]
+       lea       rcx,[rbx+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,272E6966160
-       mov       rdx,rdi
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
-       mov       rax,rdi
+       mov       rcx,20D7D807578
+       mov       rdx,rbx
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rax,rbx
 M01_L00:
-       add       rsp,28
+       add       rsp,20
+       pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rdx,[rsi+20]
        mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
-       call      CORINFO_HELP_ISINSTANCEOFCLASS
+       call      qword ptr [7FF9CEF6B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       rcx,rax
-       call      System.Text.Json.ThrowHelper.ThrowInvalidOperationException_SerializerOptionsImmutable(System.Text.Json.Serialization.JsonSerializerContext)
+       call      qword ptr [7FF9CF4CF810]
        int       3
-; Total bytes of code 212
+; Total bytes of code 210
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
-       call      System.Text.Json.JsonSerializer.ValidateInputType(System.Object, System.Type)
+       call      qword ptr [7FF9CF3D5918]; System.Text.Json.JsonSerializer.ValidateInputType(System.Object, System.Type)
        mov       rcx,rbx
        mov       rdx,rdi
-       call      System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
+       call      qword ptr [7FF9CF3D5348]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
        mov       rdx,rax
        mov       rcx,rsi
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       near ptr System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
+       jmp       qword ptr [7FF9CF3D5A98]; System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
 M02_L00:
        mov       ecx,2EB8
-       mov       rdx,7FF9DB958B80
+       mov       rdx,7FF9CF3BF730
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
+       call      qword ptr [7FF9CF4CF018]
        int       3
-; Total bytes of code 90
+; Total bytes of code 94
```
**Diff for Serialize_Json_JsonSerializer_Generator_PersonProper method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
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
-       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
+       call      qword ptr [7FF9CF785120]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
        mov       r8,rax
        mov       rdx,rbx
        mov       rcx,rdi
-       call      System.Text.Json.JsonSerializer.Serialize(System.Object, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
+       call      qword ptr [7FF9CF3E5A68]; System.Text.Json.JsonSerializer.Serialize(System.Object, System.Type, System.Text.Json.Serialization.JsonSerializerContext)
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
-; Total bytes of code 95
+; Total bytes of code 97
 ; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext.get_Default()
        push      rdi
        push      rsi
-       sub       rsp,28
-       mov       rcx,1A4BCA54168
+       push      rbx
+       sub       rsp,20
+       mov       rcx,207D1007578
        mov       rax,[rcx]
        test      rax,rax
        jne       near ptr M01_L00
        mov       rcx,offset MT_System.Text.Json.JsonSerializerOptions
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
-       mov       rdx,1A4BCA54160
-       mov       rdx,[rdx]
+       mov       rdx,207D1007570
+       mov       rdi,[rdx]
+       mov       rdx,rdi
        mov       rcx,rsi
-       call      System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
+       call      qword ptr [7FF9CF3E3168]; System.Text.Json.JsonSerializerOptions..ctor(System.Text.Json.JsonSerializerOptions)
        mov       rcx,offset MT_DotNetTips.Spargine.Tester.Models.RefTypes.PersonProperJsonSerializerContext
        call      CORINFO_HELP_NEWSFAST
-       mov       rdi,rax
-       mov       rdx,1A4BCA54160
-       mov       rdx,[rdx]
-       lea       rcx,[rdi+40]
+       mov       rbx,rax
+       lea       rcx,[rbx+40]
+       mov       rdx,rdi
        call      CORINFO_HELP_ASSIGN_REF
        cmp       byte ptr [rsi+84],0
        jne       short M01_L01
        cmp       byte ptr [rsi+84],0
        jne       short M01_L01
        lea       rcx,[rsi+20]
-       mov       rdx,rdi
+       mov       rdx,rbx
        call      CORINFO_HELP_ASSIGN_REF
        mov       byte ptr [rsi+84],1
-       lea       rcx,[rdi+8]
+       lea       rcx,[rbx+8]
        mov       rdx,rsi
        call      CORINFO_HELP_ASSIGN_REF
-       mov       rcx,1A4BCA54168
-       mov       rdx,rdi
-       call      CORINFO_HELP_CHECKED_ASSIGN_REF
-       mov       rax,rdi
+       mov       rcx,207D1007578
+       mov       rdx,rbx
+       call      CORINFO_HELP_ASSIGN_REF
+       mov       rax,rbx
 M01_L00:
-       add       rsp,28
+       add       rsp,20
+       pop       rbx
        pop       rsi
        pop       rdi
        ret
 M01_L01:
        mov       rdx,[rsi+20]
        mov       rcx,offset MT_System.Text.Json.Serialization.JsonSerializerContext
-       call      CORINFO_HELP_ISINSTANCEOFCLASS
+       call      qword ptr [7FF9CEF7B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
        mov       rcx,rax
-       call      System.Text.Json.ThrowHelper.ThrowInvalidOperationException_SerializerOptionsImmutable(System.Text.Json.Serialization.JsonSerializerContext)
+       call      qword ptr [7FF9CF4DF810]
        int       3
-; Total bytes of code 212
+; Total bytes of code 210
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
-       call      System.Text.Json.JsonSerializer.ValidateInputType(System.Object, System.Type)
+       call      qword ptr [7FF9CF3E5918]; System.Text.Json.JsonSerializer.ValidateInputType(System.Object, System.Type)
        mov       rcx,rbx
        mov       rdx,rdi
-       call      System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
+       call      qword ptr [7FF9CF3E5348]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.Serialization.JsonSerializerContext, System.Type)
        mov       rdx,rax
        mov       rcx,rsi
        add       rsp,20
        pop       rbx
        pop       rsi
        pop       rdi
-       jmp       near ptr System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
+       jmp       qword ptr [7FF9CF3E5A98]; System.Text.Json.JsonSerializer.WriteStringAsObject(System.Object, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
 M02_L00:
        mov       ecx,2EB8
-       mov       rdx,7FF9DB958B80
+       mov       rdx,7FF9CF3CF730
        call      CORINFO_HELP_STRCNS
        mov       rcx,rax
-       call      System.Text.Json.ThrowHelper.ThrowArgumentNullException(System.String)
+       call      qword ptr [7FF9CF4DF018]
        int       3
-; Total bytes of code 90
+; Total bytes of code 94
```
**Diff for Serialize_Json_Ref_PersonProper method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_Ref_PersonProper()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+30]
-       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
+       call      qword ptr [7FF9CF379C00]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9CF785330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 62
+; Total bytes of code 64
 ; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        test      rcx,rcx
-       setne     al
-       movzx     eax,al
-       test      eax,eax
-       jne       near ptr M01_L04
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
+       jne       near ptr M01_L03
+       call      qword ptr [7FF9CF3ED378]
        mov       ecx,5
        call      System.String.FastAllocateString(Int32)
        mov       rsi,rax
        cmp       dword ptr [rsi+8],3
-       jl        near ptr M01_L12
+       jl        near ptr M01_L05
        lea       rcx,[rsi+0C]
-       mov       rdx,243D9289958
+       mov       rdx,2EBCF008990
        mov       rdx,[rdx]
        add       rdx,0C
        mov       r8d,6
-       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9CF0599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,[rsi+8]
        sub       ecx,3
        cmp       ecx,2
-       jl        near ptr M01_L13
-       lea       rcx,[rsi+0C]
-       add       rcx,6
-       mov       rdx,243D9283090
+       jl        near ptr M01_L06
+       lea       rcx,[rsi+12]
+       mov       rdx,2EBCF002090
        mov       rdx,[rdx]
        add       rdx,0C
        mov       r8d,4
-       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9CF0599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        cmp       dword ptr [rsi+8],0
-       je        short M01_L03
+       je        short M01_L02
        mov       rcx,rsi
 M01_L00:
        test      rcx,rcx
-       jne       short M01_L02
-M01_L01:
+       jne       short M01_L01
        mov       eax,1
-       jmp       near ptr M01_L14
-M01_L02:
-       cmp       dword ptr [rcx+8],0
-       je        short M01_L01
+       jmp       near ptr M01_L07
+M01_L01:
        xor       eax,eax
-       jmp       near ptr M01_L14
-M01_L03:
-       mov       rcx,243D9283020
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       jmp       near ptr M01_L07
+M01_L02:
+       mov       rcx,2EBCF002028
        mov       rcx,[rcx]
        jmp       short M01_L00
-M01_L04:
+M01_L03:
        mov       [rsp+28],rcx
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
-       mov       rsi,rax
-       call      System.Text.Json.JsonSerializerOptions.get_Default()
-       mov       rdi,rax
-       cmp       byte ptr [rdi+85],0
-       jne       short M01_L05
-       mov       rcx,rdi
-       call      System.Text.Json.JsonSerializerOptions.InitializeForReflectionSerializer()
-M01_L05:
-       mov       rcx,243D928A0C8
-       cmp       rsi,[rcx]
-       je        short M01_L09
-       mov       rbx,[rdi+10]
-       test      rbx,rbx
-       jne       short M01_L06
-       xor       ecx,ecx
-       jmp       short M01_L07
-M01_L06:
-       mov       rcx,[rbx+0C0]
-M01_L07:
-       cmp       rcx,rsi
-       je        short M01_L08
-       mov       rcx,rdi
-       mov       rdx,rsi
-       mov       r8d,1
-       xor       r9d,r9d
-       call      System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, Boolean)
-       mov       rbx,rax
-       lea       rcx,[rdi+10]
-       mov       rdx,rbx
-       call      CORINFO_HELP_ASSIGN_REF
-M01_L08:
-       mov       rdx,rbx
-       jmp       short M01_L10
-M01_L09:
-       mov       rcx,rdi
-       call      System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
        mov       rdx,rax
-M01_L10:
-       mov       r8,rdx
+       xor       ecx,ecx
+       call      qword ptr [7FF9CF3E5318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
+       mov       r8,rax
        test      r8,r8
-       je        short M01_L11
+       je        short M01_L04
        mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
        cmp       [r8],rcx
-       je        short M01_L11
-       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
+       je        short M01_L04
+       mov       rdx,rax
+       call      qword ptr [7FF9CEF7B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
        mov       r8,rax
-M01_L11:
+M01_L04:
        lea       rdx,[rsp+28]
        mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
-       call      System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
+       call      qword ptr [7FF9CF5E5E70]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
        nop
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
-M01_L12:
+M01_L05:
        mov       rcx,offset MT_System.IndexOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       call      System.IndexOutOfRangeException..ctor()
+       call      qword ptr [7FF9CF1C1C78]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-M01_L13:
+M01_L06:
        mov       rcx,offset MT_System.IndexOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       call      System.IndexOutOfRangeException..ctor()
+       call      qword ptr [7FF9CF1C1C78]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-M01_L14:
+M01_L07:
        test      eax,eax
        sete      al
        movzx     eax,al
        test      eax,eax
-       jne       near ptr M01_L15
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
+       jne       near ptr M01_L08
+       call      qword ptr [7FF9CF3ED498]
        mov       rsi,rax
-       mov       ecx,3A1
-       mov       rdx,7FF9DB7C6A60
+       mov       ecx,536
+       mov       rdx,7FF9CF229CC8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
-       mov       ecx,9
-       mov       rdx,7FF9DB7C6A60
+       mov       ecx,8BA
+       mov       rdx,7FF9CF229CC8
        call      CORINFO_HELP_STRCNS
-       mov       rbx,rax
-       mov       ecx,3A1
-       mov       rdx,7FF9DB7C6A60
-       call      CORINFO_HELP_STRCNS
-       mov       rcx,rdi
-       mov       r9,rbx
+       mov       rcx,rax
+       mov       r9,rdi
        mov       [rsp+20],rax
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9CF3EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       rdi,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
+       call      qword ptr [7FF9CF3ED078]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
+       call      qword ptr [7FF9CF3ED600]
        mov       r8,rax
        mov       rdx,rdi
        mov       rcx,rbx
-       call      System.ArgumentNullException..ctor(System.String, System.String)
+       call      qword ptr [7FF9CF1ED8E8]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
-M01_L15:
-       cmp       [rcx],ecx
+M01_L08:
+       cmp       [rcx],cl
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        mov       rsi,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
+       call      qword ptr [7FF9CF3ED078]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,rdi
-       call      System.ArgumentNullException..ctor(System.String, System.String)
+       call      qword ptr [7FF9CF1ED8E8]
        mov       rcx,rdi
        call      CORINFO_HELP_THROW
        int       3
-; Total bytes of code 695
+; Total bytes of code 571
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for Serialize_Json_PersonRecord method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_PersonRecord()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+48]
-       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
+       call      qword ptr [7FF9CF399C00]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9CF7A7330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 62
+; Total bytes of code 64
 ; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        test      rcx,rcx
-       setne     al
-       movzx     eax,al
-       test      eax,eax
-       jne       near ptr M01_L04
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
+       jne       near ptr M01_L03
+       call      qword ptr [7FF9CF40D378]
        mov       ecx,5
        call      System.String.FastAllocateString(Int32)
        mov       rsi,rax
        cmp       dword ptr [rsi+8],3
-       jl        near ptr M01_L12
+       jl        near ptr M01_L05
        lea       rcx,[rsi+0C]
-       mov       rdx,18EE8729958
+       mov       rdx,1516CC04588
        mov       rdx,[rdx]
        add       rdx,0C
        mov       r8d,6
-       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9CF0799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,[rsi+8]
        sub       ecx,3
        cmp       ecx,2
-       jl        near ptr M01_L13
-       lea       rcx,[rsi+0C]
-       add       rcx,6
-       mov       rdx,18EE8723090
+       jl        near ptr M01_L06
+       lea       rcx,[rsi+12]
+       mov       rdx,15170C02090
        mov       rdx,[rdx]
        add       rdx,0C
        mov       r8d,4
-       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9CF0799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        cmp       dword ptr [rsi+8],0
-       je        short M01_L03
+       je        short M01_L02
        mov       rcx,rsi
 M01_L00:
        test      rcx,rcx
-       jne       short M01_L02
-M01_L01:
+       jne       short M01_L01
        mov       eax,1
-       jmp       near ptr M01_L14
-M01_L02:
-       cmp       dword ptr [rcx+8],0
-       je        short M01_L01
+       jmp       near ptr M01_L07
+M01_L01:
        xor       eax,eax
-       jmp       near ptr M01_L14
-M01_L03:
-       mov       rcx,18EE8723020
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       jmp       near ptr M01_L07
+M01_L02:
+       mov       rcx,15170C02028
        mov       rcx,[rcx]
        jmp       short M01_L00
-M01_L04:
+M01_L03:
        mov       [rsp+28],rcx
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
-       mov       rsi,rax
-       call      System.Text.Json.JsonSerializerOptions.get_Default()
-       mov       rdi,rax
-       cmp       byte ptr [rdi+85],0
-       jne       short M01_L05
-       mov       rcx,rdi
-       call      System.Text.Json.JsonSerializerOptions.InitializeForReflectionSerializer()
-M01_L05:
-       mov       rcx,18EE872A0C8
-       cmp       rsi,[rcx]
-       je        short M01_L09
-       mov       rbx,[rdi+10]
-       test      rbx,rbx
-       jne       short M01_L06
-       xor       ecx,ecx
-       jmp       short M01_L07
-M01_L06:
-       mov       rcx,[rbx+0C0]
-M01_L07:
-       cmp       rcx,rsi
-       je        short M01_L08
-       mov       rcx,rdi
-       mov       rdx,rsi
-       mov       r8d,1
-       xor       r9d,r9d
-       call      System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, Boolean)
-       mov       rbx,rax
-       lea       rcx,[rdi+10]
-       mov       rdx,rbx
-       call      CORINFO_HELP_ASSIGN_REF
-M01_L08:
-       mov       rdx,rbx
-       jmp       short M01_L10
-M01_L09:
-       mov       rcx,rdi
-       call      System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
        mov       rdx,rax
-M01_L10:
-       mov       r8,rdx
+       xor       ecx,ecx
+       call      qword ptr [7FF9CF405318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
+       mov       r8,rax
        test      r8,r8
-       je        short M01_L11
+       je        short M01_L04
        mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
        cmp       [r8],rcx
-       je        short M01_L11
-       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
+       je        short M01_L04
+       mov       rdx,rax
+       call      qword ptr [7FF9CEF9B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
        mov       r8,rax
-M01_L11:
+M01_L04:
        lea       rdx,[rsp+28]
        mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
-       call      System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
+       call      qword ptr [7FF9CF6099F0]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
        nop
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
-M01_L12:
+M01_L05:
        mov       rcx,offset MT_System.IndexOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       call      System.IndexOutOfRangeException..ctor()
+       call      qword ptr [7FF9CF1E1C78]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-M01_L13:
+M01_L06:
        mov       rcx,offset MT_System.IndexOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       call      System.IndexOutOfRangeException..ctor()
+       call      qword ptr [7FF9CF1E1C78]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-M01_L14:
+M01_L07:
        test      eax,eax
        sete      al
        movzx     eax,al
        test      eax,eax
-       jne       near ptr M01_L15
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
+       jne       near ptr M01_L08
+       call      qword ptr [7FF9CF40D498]
        mov       rsi,rax
-       mov       ecx,3A1
-       mov       rdx,7FF9DB7D6A60
+       mov       ecx,536
+       mov       rdx,7FF9CF249CC8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
-       mov       ecx,9
-       mov       rdx,7FF9DB7D6A60
+       mov       ecx,8BA
+       mov       rdx,7FF9CF249CC8
        call      CORINFO_HELP_STRCNS
-       mov       rbx,rax
-       mov       ecx,3A1
-       mov       rdx,7FF9DB7D6A60
-       call      CORINFO_HELP_STRCNS
-       mov       rcx,rdi
-       mov       r9,rbx
+       mov       rcx,rax
+       mov       r9,rdi
        mov       [rsp+20],rax
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9CF40BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       rdi,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
+       call      qword ptr [7FF9CF40D078]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
+       call      qword ptr [7FF9CF40D600]
        mov       r8,rax
        mov       rdx,rdi
        mov       rcx,rbx
-       call      System.ArgumentNullException..ctor(System.String, System.String)
+       call      qword ptr [7FF9CF20D8E8]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
-M01_L15:
-       cmp       [rcx],ecx
+M01_L08:
+       cmp       [rcx],cl
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       call      qword ptr [7FF9CF033510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        mov       rsi,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
+       call      qword ptr [7FF9CF40D078]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,rdi
-       call      System.ArgumentNullException..ctor(System.String, System.String)
+       call      qword ptr [7FF9CF20D8E8]
        mov       rcx,rdi
        call      CORINFO_HELP_THROW
        int       3
-; Total bytes of code 695
+; Total bytes of code 571
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for Serialize_Json_PersonProper_List method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_Json_PersonProper_List()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+1A8]
-       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
+       call      qword ptr [7FF9CF379C00]; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9CF7873D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 65
+; Total bytes of code 67
 ; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
        push      rdi
        push      rsi
        push      rbx
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        test      rcx,rcx
-       setne     al
-       movzx     eax,al
-       test      eax,eax
-       jne       near ptr M01_L04
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
+       jne       near ptr M01_L03
+       call      qword ptr [7FF9CF3ED378]
        mov       ecx,5
        call      System.String.FastAllocateString(Int32)
        mov       rsi,rax
        cmp       dword ptr [rsi+8],3
-       jl        near ptr M01_L12
+       jl        near ptr M01_L05
        lea       rcx,[rsi+0C]
-       mov       rdx,28B8EC79958
+       mov       rdx,1EBA1408990
        mov       rdx,[rdx]
        add       rdx,0C
        mov       r8d,6
-       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9CF0599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,[rsi+8]
        sub       ecx,3
        cmp       ecx,2
-       jl        near ptr M01_L13
-       lea       rcx,[rsi+0C]
-       add       rcx,6
-       mov       rdx,28B8EC73090
+       jl        near ptr M01_L06
+       lea       rcx,[rsi+12]
+       mov       rdx,1EBA1402090
        mov       rdx,[rdx]
        add       rdx,0C
        mov       r8d,4
-       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9CF0599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        cmp       dword ptr [rsi+8],0
-       je        short M01_L03
+       je        short M01_L02
        mov       rcx,rsi
 M01_L00:
        test      rcx,rcx
-       jne       short M01_L02
-M01_L01:
+       jne       short M01_L01
        mov       eax,1
-       jmp       near ptr M01_L14
-M01_L02:
-       cmp       dword ptr [rcx+8],0
-       je        short M01_L01
+       jmp       near ptr M01_L07
+M01_L01:
        xor       eax,eax
-       jmp       near ptr M01_L14
-M01_L03:
-       mov       rcx,28B8EC73020
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       jmp       near ptr M01_L07
+M01_L02:
+       mov       rcx,1EBA1402028
        mov       rcx,[rcx]
        jmp       short M01_L00
-M01_L04:
+M01_L03:
        mov       [rsp+28],rcx
        mov       rcx,offset MT_System.Object
        call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
-       mov       rsi,rax
-       call      System.Text.Json.JsonSerializerOptions.get_Default()
-       mov       rdi,rax
-       cmp       byte ptr [rdi+85],0
-       jne       short M01_L05
-       mov       rcx,rdi
-       call      System.Text.Json.JsonSerializerOptions.InitializeForReflectionSerializer()
-M01_L05:
-       mov       rcx,28B8EC7A0C8
-       cmp       rsi,[rcx]
-       je        short M01_L09
-       mov       rbx,[rdi+10]
-       test      rbx,rbx
-       jne       short M01_L06
-       xor       ecx,ecx
-       jmp       short M01_L07
-M01_L06:
-       mov       rcx,[rbx+0C0]
-M01_L07:
-       cmp       rcx,rsi
-       je        short M01_L08
-       mov       rcx,rdi
-       mov       rdx,rsi
-       mov       r8d,1
-       xor       r9d,r9d
-       call      System.Text.Json.JsonSerializerOptions.GetTypeInfoInternal(System.Type, Boolean, Boolean)
-       mov       rbx,rax
-       lea       rcx,[rdi+10]
-       mov       rdx,rbx
-       call      CORINFO_HELP_ASSIGN_REF
-M01_L08:
-       mov       rdx,rbx
-       jmp       short M01_L10
-M01_L09:
-       mov       rcx,rdi
-       call      System.Text.Json.JsonSerializerOptions.get_ObjectTypeInfo()
        mov       rdx,rax
-M01_L10:
-       mov       r8,rdx
+       xor       ecx,ecx
+       call      qword ptr [7FF9CF3E5318]; System.Text.Json.JsonSerializer.GetTypeInfo(System.Text.Json.JsonSerializerOptions, System.Type)
+       mov       r8,rax
        test      r8,r8
-       je        short M01_L11
+       je        short M01_L04
        mov       rcx,offset MT_System.Text.Json.Serialization.Metadata.JsonTypeInfo`1[[System.Object, System.Private.CoreLib]]
        cmp       [r8],rcx
-       je        short M01_L11
-       call      CORINFO_HELP_CHKCASTCLASS_SPECIAL
+       je        short M01_L04
+       mov       rdx,rax
+       call      qword ptr [7FF9CEF7B8B8]; System.Runtime.CompilerServices.CastHelpers.ChkCastClassSpecial(Void*, System.Object)
        mov       r8,rax
-M01_L11:
+M01_L04:
        lea       rdx,[rsp+28]
        mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteString[[System.Object, System.Private.CoreLib]](System.Object ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.Object>)
-       call      System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
+       call      qword ptr [7FF9CF5E79F0]; System.Text.Json.JsonSerializer.WriteString[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo`1<System.__Canon>)
        nop
        add       rsp,30
        pop       rbx
        pop       rsi
        pop       rdi
        ret
-M01_L12:
+M01_L05:
        mov       rcx,offset MT_System.IndexOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       call      System.IndexOutOfRangeException..ctor()
+       call      qword ptr [7FF9CF1C1C78]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-M01_L13:
+M01_L06:
        mov       rcx,offset MT_System.IndexOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       call      System.IndexOutOfRangeException..ctor()
+       call      qword ptr [7FF9CF1C1C78]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-M01_L14:
+M01_L07:
        test      eax,eax
        sete      al
        movzx     eax,al
        test      eax,eax
-       jne       near ptr M01_L15
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
+       jne       near ptr M01_L08
+       call      qword ptr [7FF9CF3ED498]
        mov       rsi,rax
-       mov       ecx,3A1
-       mov       rdx,7FF9DB7A6A60
+       mov       ecx,536
+       mov       rdx,7FF9CF229CC8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
-       mov       ecx,9
-       mov       rdx,7FF9DB7A6A60
+       mov       ecx,8BA
+       mov       rdx,7FF9CF229CC8
        call      CORINFO_HELP_STRCNS
-       mov       rbx,rax
-       mov       ecx,3A1
-       mov       rdx,7FF9DB7A6A60
-       call      CORINFO_HELP_STRCNS
-       mov       rcx,rdi
-       mov       r9,rbx
+       mov       rcx,rax
+       mov       r9,rdi
        mov       [rsp+20],rax
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9CF3EBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       rdi,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
+       call      qword ptr [7FF9CF3ED078]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
+       call      qword ptr [7FF9CF3ED600]
        mov       r8,rax
        mov       rdx,rdi
        mov       rcx,rbx
-       call      System.ArgumentNullException..ctor(System.String, System.String)
+       call      qword ptr [7FF9CF1ED8E8]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
-M01_L15:
-       cmp       [rcx],ecx
+M01_L08:
+       cmp       [rcx],cl
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       call      qword ptr [7FF9CF013510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        mov       rsi,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
+       call      qword ptr [7FF9CF3ED078]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,rdi
-       call      System.ArgumentNullException..ctor(System.String, System.String)
+       call      qword ptr [7FF9CF1ED8E8]
        mov       rcx,rdi
        call      CORINFO_HELP_THROW
        int       3
-; Total bytes of code 695
+; Total bytes of code 571
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for Serialize_XML_Ref_PersonProper method between:**
.NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
.NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize_XML_Ref_PersonProper()
        push      rsi
        sub       rsp,30
        xor       eax,eax
        mov       [rsp+28],rax
        mov       rsi,rcx
        mov       rcx,[rsi+30]
-       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.Serialize(System.Object)
+       call      qword ptr [7FF9CF389F90]; DotNetTips.Spargine.Core.Serialization.XmlSerialization.Serialize(System.Object)
        mov       [rsp+28],rax
        mov       rcx,[rsi+18]
        lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FF9CF793FD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,30
        pop       rsi
        ret
-; Total bytes of code 62
+; Total bytes of code 64
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
-       setne     al
-       movzx     eax,al
-       test      eax,eax
-       jne       near ptr M01_L04
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
+       jne       near ptr M01_L03
+       call      qword ptr [7FF9CF3FD378]
        mov       ecx,5
        call      System.String.FastAllocateString(Int32)
        mov       rdi,rax
        cmp       dword ptr [rdi+8],3
-       jl        near ptr M01_L06
+       jl        near ptr M01_L05
        lea       rcx,[rdi+0C]
-       mov       rdx,18B9BC89958
+       mov       rdx,18565408990
        mov       rdx,[rdx]
        add       rdx,0C
        mov       r8d,6
-       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        mov       ecx,[rdi+8]
        sub       ecx,3
        cmp       ecx,2
-       jl        near ptr M01_L07
-       lea       rcx,[rdi+0C]
-       add       rcx,6
-       mov       rdx,18B9BC83090
+       jl        near ptr M01_L06
+       lea       rcx,[rdi+12]
+       mov       rdx,18565402090
        mov       rdx,[rdx]
        add       rdx,0C
        mov       r8d,4
-       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
+       call      qword ptr [7FF9CF0699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
        cmp       dword ptr [rdi+8],0
-       je        short M01_L03
+       je        short M01_L02
        mov       rcx,rdi
 M01_L00:
        test      rcx,rcx
-       jne       short M01_L02
-M01_L01:
+       jne       short M01_L01
        mov       eax,1
-       jmp       near ptr M01_L08
-M01_L02:
-       cmp       dword ptr [rcx+8],0
-       je        short M01_L01
+       jmp       near ptr M01_L07
+M01_L01:
        xor       eax,eax
-       jmp       near ptr M01_L08
-M01_L03:
-       mov       rcx,18B9BC83020
+       cmp       dword ptr [rcx+8],0
+       sete      al
+       jmp       near ptr M01_L07
+M01_L02:
+       mov       rcx,18565402028
        mov       rcx,[rcx]
        jmp       short M01_L00
-M01_L04:
+M01_L03:
        mov       rcx,offset MT_System.IO.StringWriter
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rdi
-       call      System.IO.StringWriter..ctor()
+       call      qword ptr [7FF9CF677348]; System.IO.StringWriter..ctor()
        mov       rcx,rdi
        mov       [rbp-20],rcx
-       call      System.Xml.XmlWriter.Create(System.IO.TextWriter)
+       call      qword ptr [7FF9CF677BA0]; System.Xml.XmlWriter.Create(System.IO.TextWriter)
        mov       [rbp-28],rax
        mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
        mov       rcx,rsi
        call      System.Object.GetType()
        mov       rdx,rax
        mov       rcx,rdi
        xor       r8d,r8d
-       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
+       call      qword ptr [7FF9CF6791C8]; System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
        xor       ecx,ecx
        mov       [rsp+20],rcx
        mov       [rsp+28],rcx
        mov       rcx,rdi
        mov       rdx,[rbp-28]
        mov       r8,rsi
        xor       r9d,r9d
-       call      System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
+       call      qword ptr [7FF9CF679300]; System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
        mov       rcx,[rbp-20]
        mov       rcx,[rcx+20]
        cmp       [rcx],ecx
-       call      qword ptr [7FF9DB78BC48]; System.Text.StringBuilder.ToString()
+       call      qword ptr [7FF9CF20FE70]; System.Text.StringBuilder.ToString()
        mov       rsi,rax
        mov       rdx,[rbp-28]
        test      rdx,rdx
-       je        short M01_L05
+       je        short M01_L04
        mov       rcx,rdx
-       mov       r11,7FF9DB4F0A70
-       call      qword ptr [7FF9DB4F0A70]
+       mov       r11,7FF9CEDE09C0
+       call      qword ptr [r11]
        nop
-M01_L05:
+M01_L04:
        mov       rcx,[rbp-20]
        mov       byte ptr [rcx+28],0
-       call      System.GC.SuppressFinalize(System.Object)
+       call      System.GC._SuppressFinalize(System.Object)
        mov       rax,rsi
        add       rsp,48
        pop       rbx
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-M01_L06:
+M01_L05:
        mov       rcx,offset MT_System.IndexOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       call      System.IndexOutOfRangeException..ctor()
+       call      qword ptr [7FF9CF1D1C78]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-M01_L07:
+M01_L06:
        mov       rcx,offset MT_System.IndexOutOfRangeException
        call      CORINFO_HELP_NEWSFAST
        mov       rsi,rax
        mov       rcx,rsi
-       call      System.IndexOutOfRangeException..ctor()
+       call      qword ptr [7FF9CF1D1C78]
        mov       rcx,rsi
        call      CORINFO_HELP_THROW
-M01_L08:
+M01_L07:
        test      eax,eax
        sete      al
        movzx     eax,al
        test      eax,eax
-       jne       near ptr M01_L09
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
+       jne       near ptr M01_L08
+       call      qword ptr [7FF9CF3FD498]
        mov       rsi,rax
-       mov       ecx,3A1
-       mov       rdx,7FF9DB7A6A60
+       mov       ecx,536
+       mov       rdx,7FF9CF239CC8
        call      CORINFO_HELP_STRCNS
        mov       rdi,rax
-       mov       ecx,9
-       mov       rdx,7FF9DB7A6A60
+       mov       ecx,8BA
+       mov       rdx,7FF9CF239CC8
        call      CORINFO_HELP_STRCNS
-       mov       rbx,rax
-       mov       ecx,3A1
-       mov       rdx,7FF9DB7A6A60
-       call      CORINFO_HELP_STRCNS
-       mov       rcx,rdi
-       mov       r9,rbx
+       mov       rcx,rax
+       mov       r9,rdi
        mov       [rsp+20],rax
        mov       edx,1
        xor       r8d,r8d
-       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       call      qword ptr [7FF9CF3FBC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
        mov       rdi,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rbx,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
+       call      qword ptr [7FF9CF3FD078]
        mov       rdx,rax
        mov       rcx,rsi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.DefaultIfNull(System.String, System.String)
+       call      qword ptr [7FF9CF3FD600]
        mov       r8,rax
        mov       rdx,rdi
        mov       rcx,rbx
-       call      System.ArgumentNullException..ctor(System.String, System.String)
+       call      qword ptr [7FF9CF1FD8E8]
        mov       rcx,rbx
        call      CORINFO_HELP_THROW
-M01_L09:
-       cmp       [rcx],ecx
+M01_L08:
+       cmp       [rcx],cl
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       call      qword ptr [7FF9CF023510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        mov       rsi,rax
        mov       rcx,offset MT_System.ArgumentNullException
        call      CORINFO_HELP_NEWSFAST
        mov       rdi,rax
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorArgumentNull()
+       call      qword ptr [7FF9CF3FD078]
        mov       r8,rax
        mov       rdx,rsi
        mov       rcx,rdi
-       call      System.ArgumentNullException..ctor(System.String, System.String)
+       call      qword ptr [7FF9CF1FD8E8]
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
-       je        short M01_L10
+       je        short M01_L09
        mov       rcx,[rbp-28]
-       mov       r11,7FF9DB4F0A70
-       call      qword ptr [7FF9DB4F0A70]
-M01_L10:
+       mov       r11,7FF9CEDE09C0
+       call      qword ptr [r11]
+M01_L09:
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
-       cmp       qword ptr [rbp-20],0
-       je        short M01_L11
        mov       rcx,[rbp-20]
        mov       byte ptr [rcx+28],0
-       call      System.GC.SuppressFinalize(System.Object)
-M01_L11:
+       call      System.GC._SuppressFinalize(System.Object)
        nop
        add       rsp,38
        pop       rbx
        pop       rsi
        pop       rdi
        pop       rbp
        ret
-; Total bytes of code 802
+; Total bytes of code 772
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
