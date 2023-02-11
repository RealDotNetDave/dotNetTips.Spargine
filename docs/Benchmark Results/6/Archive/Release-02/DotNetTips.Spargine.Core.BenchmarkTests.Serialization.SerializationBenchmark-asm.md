## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize04()
; 			PersonRecord result = JsonSerialization.Deserialize<PersonRecord>(Resources.PersonProperJson);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_PersonProperJson()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_PersonProperJson()
;                 return ResourceManager.GetString("PersonProperJson", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,21323843928
       mov       rdx,[rdx]
       mov       r8,21313845D68
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        near ptr M02_L02
       cmp       dword ptr [rdx+8],0
       je        near ptr M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,609
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
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
M02_L01:
       cmp       [rdx],edx
       mov       rcx,rdx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M02_L04
M02_L02:
       mov       eax,1
       jmp       near ptr M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB52CEEAB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 299
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize03()
; 			PersonRecord result = JsonSerialization.Deserialize<PersonRecord>(Resources.PersonRecordJson);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_PersonRecordJson()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_PersonRecordJson()
;                 return ResourceManager.GetString("PersonRecordJson", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,15CB81F1930
       mov       rdx,[rdx]
       mov       r8,15C981F7D60
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        near ptr M02_L02
       cmp       dword ptr [rdx+8],0
       je        near ptr M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,609
       mov       rdx,7FFB52B078E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B078E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B078E8
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
M02_L01:
       cmp       [rdx],edx
       mov       rcx,rdx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L03
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M02_L04
M02_L02:
       mov       eax,1
       jmp       near ptr M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFB52CCEAB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 299
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize01()
; 			PersonProper result = XmlSerialization.Deserialize<PersonProper>(Resources.PersonProperXml);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_PersonProperXml()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize(System.String)
       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_PersonProperXml()
;                 return ResourceManager.GetString("PersonProperXml", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,12EE0691930
       mov       rdx,[rdx]
       mov       r8,12EF0693958
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
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
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF98],rsp
       mov       [rbp+0FFE0],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        near ptr M02_L02
       cmp       dword ptr [rdx+8],0
       je        near ptr M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B378E8
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
M02_L01:
       cmp       [rdx],edx
       mov       rcx,rdx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      rdi,rdi
       je        near ptr M02_L05
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+8]
       mov       [rbx+14],ecx
       mov       rcx,rbx
       mov       [rbp+0FFB0],rcx
       jmp       short M02_L03
M02_L02:
       mov       eax,1
       jmp       near ptr M02_L00
M02_L03:
       call      System.Xml.XmlReader.Create(System.IO.TextReader)
       mov       [rbp+0FFA8],rax
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
       mov       rax,[rbp+0FFA8]
       mov       rdx,rax
       vmovdqu   xmm0,xmmword ptr [rdi+38]
       vmovdqu   xmmword ptr [rbp+0FFB8],xmm0
       vmovdqu   xmm0,xmmword ptr [rdi+48]
       vmovdqu   xmmword ptr [rbp+0FFC8],xmm0
       mov       r9,[rdi+58]
       mov       [rbp+0FFD8],r9
       lea       r9,[rbp+0FFB8]
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHKCASTARRAY
       mov       rsi,rax
       mov       rax,[rbp+0FFA8]
       test      rax,rax
       je        short M02_L04
       mov       rcx,rax
       mov       r11,7FFB52870670
       call      qword ptr [7FFB52E30670]
       nop
M02_L04:
       xor       ecx,ecx
       mov       rax,[rbp+0FFB0]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       [rax+14],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFB52E2CDC0]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L05:
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
       cmp       qword ptr [rbp+0FFA8],0
       je        short M02_L06
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB52870670
       call      qword ptr [7FFB52E30670]
M02_L06:
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
       cmp       qword ptr [rbp+0FFB0],0
       je        short M02_L07
       xor       ecx,ecx
       mov       rax,[rbp+0FFB0]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       [rax+14],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFB52E2CDC0]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
M02_L07:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 683
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize02()
; 			PersonRecord result = XmlSerialization.Deserialize<PersonRecord>(Resources.PersonRecordXml);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_PersonRecordXml()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize(System.String)
       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_PersonRecordXml()
;                 return ResourceManager.GetString("PersonRecordXml", resourceCulture);
;                 ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,1EB6F882148
       mov       rdx,[rdx]
       mov       r8,1EB5F883958
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
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
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FF98],rsp
       mov       [rbp+0FFE0],rcx
       mov       rsi,rcx
       test      rdx,rdx
       je        near ptr M02_L02
       cmp       dword ptr [rdx+8],0
       je        near ptr M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,899
       mov       rdx,7FFB52B078E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B078E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B078E8
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
M02_L01:
       cmp       [rdx],edx
       mov       rcx,rdx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      rdi,rdi
       je        near ptr M02_L05
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+8]
       mov       [rbx+14],ecx
       mov       rcx,rbx
       mov       [rbp+0FFB0],rcx
       jmp       short M02_L03
M02_L02:
       mov       eax,1
       jmp       near ptr M02_L00
M02_L03:
       call      System.Xml.XmlReader.Create(System.IO.TextReader)
       mov       [rbp+0FFA8],rax
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
       mov       rax,[rbp+0FFA8]
       mov       rdx,rax
       vmovdqu   xmm0,xmmword ptr [rdi+38]
       vmovdqu   xmmword ptr [rbp+0FFB8],xmm0
       vmovdqu   xmm0,xmmword ptr [rdi+48]
       vmovdqu   xmmword ptr [rbp+0FFC8],xmm0
       mov       r9,[rdi+58]
       mov       [rbp+0FFD8],r9
       lea       r9,[rbp+0FFB8]
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer.Deserialize(System.Xml.XmlReader, System.String, System.Xml.Serialization.XmlDeserializationEvents)
       mov       rdx,rax
       mov       rcx,rsi
       call      CORINFO_HELP_CHKCASTARRAY
       mov       rsi,rax
       mov       rax,[rbp+0FFA8]
       test      rax,rax
       je        short M02_L04
       mov       rcx,rax
       mov       r11,7FFB52840660
       call      qword ptr [7FFB52E10660]
       nop
M02_L04:
       xor       ecx,ecx
       mov       rax,[rbp+0FFB0]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       [rax+14],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFB52E0CDC0]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       add       rsp,78
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L05:
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
       cmp       qword ptr [rbp+0FFA8],0
       je        short M02_L06
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFB52840660
       call      qword ptr [7FFB52E10660]
M02_L06:
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
       cmp       qword ptr [rbp+0FFB0],0
       je        short M02_L07
       xor       ecx,ecx
       mov       rax,[rbp+0FFB0]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       [rax+14],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFB52E0CDC0]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
M02_L07:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 683
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize02()
; 			var result = JsonSerialization.Serialize(this.PersonProperRef01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
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
       jne       near ptr M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L09
       lea       rcx,[rdi+0C]
       mov       rdx,2632E3115B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L10
       lea       rcx,[rdi+0C]
       add       rcx,6
       mov       rdx,2630E313090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L11
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B378E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B378E8
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
M01_L02:
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
M01_L03:
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      System.Text.Json.JsonSerializer.GetRuntimeType[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rsi,rax
       mov       rcx,2630E3189A8
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       jne       short M01_L04
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializerOptions.InitializeForReflectionSerializer()
M01_L04:
       mov       rbx,[rdi+20]
       test      rbx,rbx
       je        short M01_L08
       mov       rcx,[rbx+80]
M01_L05:
       mov       rdx,rsi
       call      System.Type.op_Inequality(System.Type, System.Type)
       test      eax,eax
       jne       short M01_L07
M01_L06:
       mov       r8,rbx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      System.Text.Json.JsonSerializer.WriteStringUsingSerializer[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.Json.JsonSerializerOptions.GetOrAddClass(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L06
M01_L08:
       xor       ecx,ecx
       jmp       short M01_L05
M01_L09:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L00
       xor       eax,eax
       jmp       near ptr M01_L01
; Total bytes of code 641
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize03()
; 			var result = JsonSerialization.Serialize(this.PersonRecord02);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+50]
       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
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
       jne       near ptr M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L09
       lea       rcx,[rdi+0C]
       mov       rdx,23934B715B8
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L10
       lea       rcx,[rdi+0C]
       add       rcx,6
       mov       rdx,23954B73090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L11
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B478E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B478E8
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
M01_L02:
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
M01_L03:
       mov       [rsp+28],rcx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.GetRuntimeType(!!0 ByRef)
       call      System.Text.Json.JsonSerializer.GetRuntimeType[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rsi,rax
       mov       rcx,23954B789A8
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       jne       short M01_L04
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializerOptions.InitializeForReflectionSerializer()
M01_L04:
       mov       rbx,[rdi+20]
       test      rbx,rbx
       je        short M01_L08
       mov       rcx,[rbx+80]
M01_L05:
       mov       rdx,rsi
       call      System.Type.op_Inequality(System.Type, System.Type)
       test      eax,eax
       jne       short M01_L07
M01_L06:
       mov       r8,rbx
       lea       rdx,[rsp+28]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      System.Text.Json.JsonSerializer.WriteStringUsingSerializer[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M01_L07:
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.Json.JsonSerializerOptions.GetOrAddClass(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L06
M01_L08:
       xor       ecx,ecx
       jmp       short M01_L05
M01_L09:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L10:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L11:
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L00
       xor       eax,eax
       jmp       near ptr M01_L01
; Total bytes of code 641
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize01()
; 			var result = XmlSerialization.Serialize(this.PersonProperRef01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+38]
       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.Serialize(System.Object)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 42
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
       mov       [rbp+0FFE0],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rsi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],3
       jl        near ptr M01_L05
       lea       rcx,[rdi+0C]
       mov       rdx,2BF2E7779A0
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L06
       lea       rcx,[rdi+0C]
       add       rcx,6
       mov       rdx,2BF2E771098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       test      rcx,rcx
       jne       near ptr M01_L07
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B178E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B178E8
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
M01_L02:
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
M01_L03:
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.IO.StringWriter..ctor()
       mov       rcx,rdi
       mov       [rbp+0FFE0],rcx
       call      System.Xml.XmlWriter.Create(System.IO.TextWriter)
       mov       [rbp+0FFD8],rax
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
       mov       rdx,[rbp+0FFD8]
       mov       r8,rsi
       xor       r9d,r9d
       call      System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       mov       rcx,[rbp+0FFE0]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFB52E12180]
       mov       rsi,rax
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M01_L04
       mov       rcx,rdx
       mov       r11,7FFB52850628
       call      qword ptr [7FFB52E10628]
       nop
M01_L04:
       mov       rcx,[rbp+0FFE0]
       mov       byte ptr [rcx+28],0
       mov       edx,1
       call      qword ptr [7FFB52E1C280]
       mov       rcx,[rbp+0FFE0]
       call      System.GC.SuppressFinalize(System.Object)
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
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L06:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L07:
       cmp       dword ptr [rcx+8],0
       je        near ptr M01_L00
       xor       eax,eax
       jmp       near ptr M01_L01
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L08
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFB52850628
       call      qword ptr [7FFB52E10628]
M01_L08:
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
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L09
       mov       rcx,[rbp+0FFE0]
       mov       byte ptr [rcx+28],0
       mov       edx,1
       call      qword ptr [7FFB52E1C280]
       mov       rcx,[rbp+0FFE0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L09:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 827
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.StringToXDocument()
; 			System.Xml.Linq.XDocument result = XmlSerialization.StringToXDocument(this.XmlTestDataPersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Benchmarking.Properties.Resources.get_XmlTestDataPersonProper()
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.StringToXDocument(System.String)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 46
```
```assembly
; DotNetTips.Spargine.Benchmarking.Properties.Resources.get_XmlTestDataPersonProper()
       sub       rsp,28
       call      DotNetTips.Spargine.Benchmarking.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,200E9504940
       mov       rdx,[rdx]
       mov       r8,20119505D78
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; DotNetTips.Spargine.Core.Serialization.XmlSerialization.StringToXDocument(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       test      rcx,rcx
       je        near ptr M02_L02
       cmp       dword ptr [rcx+8],0
       je        near ptr M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,43B
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFB52B278E8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3A5
       mov       rdx,7FFB52B278E8
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
M02_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       xor       edx,edx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr DotNetTips.Spargine.Core.Serialization.XmlSerialization.StringToXDocument(System.String, System.Xml.XmlResolver)
M02_L02:
       mov       eax,1
       jmp       near ptr M02_L00
; Total bytes of code 240
```

