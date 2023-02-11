## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize04()
; 			var result = JsonSerialization.Deserialize<PersonRecord>(Resources.PersonProperJson);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_PersonProperJson()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+20]
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
       mov       rdx,2824478AD00
       mov       rdx,[rdx]
       mov       r8,28244788318
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        short M02_L02
       cmp       dword ptr [rdi+8],0
       je        short M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,2824478AD78
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L01:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L02:
       mov       eax,1
       jmp       short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFED0C3D620
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize03()
; 			var result = JsonSerialization.Deserialize<PersonRecord>(Resources.PersonRecordJson);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_PersonRecordJson()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+20]
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
       mov       rdx,1CB3CD66528
       mov       rdx,[rdx]
       mov       r8,1CB6CD63F10
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
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        short M02_L02
       cmp       dword ptr [rdi+8],0
       je        short M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,1CB3CD665A0
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L01:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L03
       jmp       short M02_L04
M02_L02:
       mov       eax,1
       jmp       short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       rdx,7FFED0C2D620
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L04:
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 148
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize01()
; 			var result = XmlSerialization.Deserialize<PersonProper>(Resources.PersonProperXml);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_PersonProperXml()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize(System.String)
       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+20]
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
       mov       rdx,26DD3B74530
       mov       rdx,[rdx]
       mov       r8,26E03B73F10
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
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFE0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        short M02_L02
       cmp       dword ptr [rdi+8],0
       je        short M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,26DD3B745A8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L01:
       cmp       [rdi],edi
       mov       rcx,rdi
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
       jmp       short M02_L00
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
       mov       r11,7FFED0770608
       call      qword ptr [7FFED0D40608]
       nop
M02_L04:
       xor       ecx,ecx
       mov       rax,[rbp+0FFB0]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       [rax+14],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFED0D4DB78]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       add       rsp,68
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
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M02_L06
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFED0770608
       call      qword ptr [7FFED0D40608]
M02_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB0],0
       je        short M02_L07
       xor       ecx,ecx
       mov       rax,[rbp+0FFB0]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       [rax+14],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFED0D4DB78]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
M02_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 540
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize02()
; 			var result = XmlSerialization.Deserialize<PersonRecord>(Resources.PersonRecordXml);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_PersonRecordXml()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize(System.String)
       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+20]
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
       mov       rdx,1D74F494530
       mov       rdx,[rdx]
       mov       r8,1D76F493F10
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
       sub       rsp,68
       vzeroupper
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp+0FFB0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFC0],xmm4
       vmovdqa   xmmword ptr [rbp+0FFD0],xmm4
       mov       [rbp+0FFA0],rsp
       mov       [rbp+0FFE0],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        short M02_L02
       cmp       dword ptr [rdi+8],0
       je        short M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,1D74F4945A8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L01:
       cmp       [rdi],edi
       mov       rcx,rdi
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
       jmp       short M02_L00
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
       mov       r11,7FFED0790650
       call      qword ptr [7FFED0D70650]
       nop
M02_L04:
       xor       ecx,ecx
       mov       rax,[rbp+0FFB0]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       [rax+14],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFED0D6DB78]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       add       rsp,68
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
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFA8],0
       je        short M02_L06
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFED0790650
       call      qword ptr [7FFED0D70650]
M02_L06:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       vzeroupper
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFB0],0
       je        short M02_L07
       xor       ecx,ecx
       mov       rax,[rbp+0FFB0]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       [rax+14],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFED0D6DB78]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
M02_L07:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 540
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize02()
; 			var result = JsonSerialization.Serialize(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       mov       rcx,[rsi+20]
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
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rdi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],3
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,1D717173998
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+0C]
       add       rcx,6
       mov       rdx,1D717171098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       [rsp+28],rsi
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,1D737176C60
       cmp       rax,[rcx]
       jne       short M01_L01
       cmp       qword ptr [rsp+28],0
       je        short M01_L01
       mov       rcx,[rsp+28]
       call      System.Object.GetType()
M01_L01:
       mov       rsi,rax
       mov       rcx,1D737176B30
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       jne       short M01_L02
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializerOptions.InitializeForReflectionSerializer()
M01_L02:
       mov       rbx,[rdi+20]
       test      rbx,rbx
       je        short M01_L06
       mov       rcx,[rbx+80]
M01_L03:
       mov       rdx,rsi
       call      System.Type.op_Inequality(System.Type, System.Type)
       test      eax,eax
       jne       short M01_L05
M01_L04:
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
M01_L05:
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.Json.JsonSerializerOptions.GetOrAddClass(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L04
M01_L06:
       xor       ecx,ecx
       jmp       short M01_L03
M01_L07:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 414
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize03()
; 			var result = JsonSerialization.Serialize(this.PersonRecord02);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+40]
       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       mov       rcx,[rsi+20]
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
       mov       rsi,rcx
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rdi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],3
       jl        near ptr M01_L07
       lea       rcx,[rbx+0C]
       mov       rdx,16D1ACD5990
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[rbx+0C]
       add       rcx,6
       mov       rdx,16D1ACD3090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
       mov       [rsp+28],rsi
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,16D3ACD4C68
       cmp       rax,[rcx]
       jne       short M01_L01
       cmp       qword ptr [rsp+28],0
       je        short M01_L01
       mov       rcx,[rsp+28]
       call      System.Object.GetType()
M01_L01:
       mov       rsi,rax
       mov       rcx,16D3ACD4B38
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       jne       short M01_L02
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializerOptions.InitializeForReflectionSerializer()
M01_L02:
       mov       rbx,[rdi+20]
       test      rbx,rbx
       je        short M01_L06
       mov       rcx,[rbx+80]
M01_L03:
       mov       rdx,rsi
       call      System.Type.op_Inequality(System.Type, System.Type)
       test      eax,eax
       jne       short M01_L05
M01_L04:
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
M01_L05:
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.Json.JsonSerializerOptions.GetOrAddClass(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L04
M01_L06:
       xor       ecx,ecx
       jmp       short M01_L03
M01_L07:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L08:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 414
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize01()
; 			var result = XmlSerialization.Serialize(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+28]
       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.Serialize(System.Object)
       mov       rcx,[rsi+20]
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
       jne       near ptr M01_L00
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rdi,rax
       mov       ecx,5
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],3
       jl        near ptr M01_L02
       lea       rcx,[rbx+0C]
       mov       rdx,1A761D35990
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,6
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,3
       cmp       ecx,2
       jl        near ptr M01_L03
       lea       rcx,[rbx+0C]
       add       rcx,6
       mov       rdx,1A761D33090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.String.Concat(System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L00:
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
       call      qword ptr [7FFED0D62E80]
       mov       rsi,rax
       mov       rdx,[rbp+0FFD8]
       test      rdx,rdx
       je        short M01_L01
       mov       rcx,rdx
       mov       r11,7FFED0780618
       call      qword ptr [7FFED0D60618]
       nop
M01_L01:
       mov       rcx,[rbp+0FFE0]
       mov       byte ptr [rcx+28],0
       mov       edx,1
       call      qword ptr [7FFED0D6D038]
       mov       rcx,[rbp+0FFE0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       add       rsp,48
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L02:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L03:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      System.IndexOutOfRangeException..ctor()
       mov       rcx,rsi
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
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L04
       mov       rcx,[rbp+0FFD8]
       mov       r11,7FFED0780618
       call      qword ptr [7FFED0D60618]
M01_L04:
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
       je        short M01_L05
       mov       rcx,[rbp+0FFE0]
       mov       byte ptr [rcx+28],0
       mov       edx,1
       call      qword ptr [7FFED0D6D038]
       mov       rcx,[rbp+0FFE0]
       call      System.GC.SuppressFinalize(System.Object)
M01_L05:
       nop
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 569
```

## .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.StringToXDocument()
; 			var result = XmlSerialization.StringToXDocument(this.XmlTestDataPersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Benchmarking.Properties.Resources.get_XmlTestDataPersonProper()
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.StringToXDocument(System.String)
       mov       rcx,[rsi+20]
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
       mov       rdx,27B08131908
       mov       rdx,[rdx]
       mov       r8,27AD8138328
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
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       test      rsi,rsi
       je        short M02_L02
       cmp       dword ptr [rsi+8],0
       je        short M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       mov       rdx,27AD81397E8
       mov       rdx,[rdx]
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L01:
       cmp       [rsi],esi
       mov       rcx,rsi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       xor       edx,edx
       add       rsp,20
       pop       rsi
       jmp       near ptr DotNetTips.Spargine.Core.Serialization.XmlSerialization.StringToXDocument(System.String, System.Xml.XmlResolver)
M02_L02:
       mov       eax,1
       jmp       short M02_L00
; Total bytes of code 96
```

