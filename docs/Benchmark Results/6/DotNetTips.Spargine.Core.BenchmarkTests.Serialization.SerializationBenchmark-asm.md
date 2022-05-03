## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize04()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_PersonProperJson()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+10]
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
       sub       rsp,28
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,21E909A5738
       mov       rdx,[rdx]
       mov       r8,21E909A3FE8
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
       mov       rax,21EB09A3020
       mov       rdi,[rax]
       mov       rbx,rdx
       test      rbx,rbx
       je        short M02_L01
       cmp       dword ptr [rbx+8],0
       je        short M02_L01
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       jmp       short M02_L02
M02_L01:
       mov       eax,1
       jmp       short M02_L00
M02_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rdi,rcx
M02_L04:
       mov       rdx,21E909A58D8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L06
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFF30A0D608
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 185
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize03()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_PersonRecordJson()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize(System.String)
       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+10]
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
       sub       rsp,28
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,1489C771F78
       mov       rdx,[rdx]
       mov       r8,148AC773FE8
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
       mov       rax,1487C773020
       mov       rdi,[rax]
       mov       rbx,rdx
       test      rbx,rbx
       je        short M02_L01
       cmp       dword ptr [rbx+8],0
       je        short M02_L01
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       jmp       short M02_L02
M02_L01:
       mov       eax,1
       jmp       short M02_L00
M02_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rdi,rcx
M02_L04:
       mov       rdx,1489C772118
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+10],0
       je        short M02_L06
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFF30A0D608
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       rdx,rdi
       xor       r8d,r8d
       call      System.Text.Json.JsonSerializer.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String, System.Text.Json.JsonSerializerOptions)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 185
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_PersonProperXml()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize(System.String)
       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+10]
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
       sub       rsp,28
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,2361C295F50
       mov       rdx,[rdx]
       mov       r8,2361C293FE8
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
       mov       rax,235FC293020
       mov       rdi,[rax]
       mov       rbx,rdx
       test      rbx,rbx
       je        short M02_L01
       cmp       dword ptr [rbx+8],0
       je        short M02_L01
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       jmp       short M02_L02
M02_L01:
       mov       eax,1
       jmp       short M02_L00
M02_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rdi,rcx
M02_L04:
       mov       rdx,2361C2960F0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      rdi,rdi
       je        near ptr M02_L07
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+8]
       mov       [rbx+14],ecx
       mov       rcx,rbx
       mov       [rbp+0FFB0],rcx
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
       je        short M02_L06
       mov       rcx,rax
       mov       r11,7FFF305705C0
       call      qword ptr [7FFF30B305C0]
       nop
M02_L06:
       xor       ecx,ecx
       mov       rax,[rbp+0FFB0]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       [rax+14],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFF30B2DB78]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L07:
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
       je        short M02_L08
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFF305705C0
       call      qword ptr [7FFF30B305C0]
M02_L08:
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
       je        short M02_L09
       xor       ecx,ecx
       mov       rax,[rbp+0FFB0]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       [rax+14],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFF30B2DB78]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
M02_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 567
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_PersonRecordXml()
       mov       rdx,rax
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize(System.String)
       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       mov       rcx,[rsi+10]
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
       sub       rsp,28
       call      DotNetTips.Spargine.Core.BenchmarkTests.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,1E2A09C3F70
       mov       rdx,[rdx]
       mov       r8,1E2B09C3FE8
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
       mov       rax,1E2809C1028
       mov       rdi,[rax]
       mov       rbx,rdx
       test      rbx,rbx
       je        short M02_L01
       cmp       dword ptr [rbx+8],0
       je        short M02_L01
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       jmp       short M02_L02
M02_L01:
       mov       eax,1
       jmp       short M02_L00
M02_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rdi+8],0
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rdi,rcx
M02_L04:
       mov       rdx,1E2A09C4110
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L05:
       cmp       [rbx],ebx
       mov       rcx,rbx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdi,rax
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       test      rdi,rdi
       je        near ptr M02_L07
       lea       rcx,[rbx+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       ecx,[rdi+8]
       mov       [rbx+14],ecx
       mov       rcx,rbx
       mov       [rbp+0FFB0],rcx
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
       je        short M02_L06
       mov       rcx,rax
       mov       r11,7FFF30580608
       call      qword ptr [7FFF30B30608]
       nop
M02_L06:
       xor       ecx,ecx
       mov       rax,[rbp+0FFB0]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       [rax+14],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFF30B2DB78]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       add       rsp,68
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M02_L07:
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
       je        short M02_L08
       mov       rcx,[rbp+0FFA8]
       mov       r11,7FFF30580608
       call      qword ptr [7FFF30B30608]
M02_L08:
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
       je        short M02_L09
       xor       ecx,ecx
       mov       rax,[rbp+0FFB0]
       mov       [rax+8],rcx
       mov       [rax+10],ecx
       mov       [rax+14],ecx
       mov       rcx,rax
       mov       edx,1
       call      qword ptr [7FFF30B2DB78]
       mov       rcx,[rbp+0FFB0]
       call      System.GC.SuppressFinalize(System.Object)
M02_L09:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 567
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+18]
       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       mov       rcx,[rsi+10]
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,1F129F63020
       mov       rsi,[rax]
       mov       rdi,rcx
       mov       rax,1F149F61588
       mov       rbx,[rax]
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rbp,rax
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       mov       r14d,[rbx+8]
       lea       ecx,[r14+2]
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       mov       r8d,[rbx+8]
       cmp       r8d,[r15+8]
       jg        near ptr M01_L12
       lea       rcx,[r15+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,r14d
       cmp       ecx,2
       jl        near ptr M01_L13
       lea       rcx,[r15+0C]
       movsxd    rdx,r14d
       lea       rcx,[rcx+rdx*2]
       mov       rdx,1F129F63090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r15
M01_L00:
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       mov       rcx,1F129F63090
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L02:
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       jmp       short M01_L04
M01_L03:
       mov       rdx,rbp
       call      System.String.Concat(System.String, System.String)
M01_L04:
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L05:
       mov       [rsp+20],rdi
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,1F159F64D30
       cmp       rax,[rcx]
       jne       short M01_L06
       cmp       qword ptr [rsp+20],0
       je        short M01_L06
       mov       rcx,[rsp+20]
       call      System.Object.GetType()
M01_L06:
       mov       rsi,rax
       mov       rcx,1F159F64C00
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       jne       short M01_L07
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializerOptions.InitializeForReflectionSerializer()
M01_L07:
       mov       rbx,[rdi+20]
       test      rbx,rbx
       je        short M01_L11
       mov       rcx,[rbx+80]
M01_L08:
       mov       rdx,rsi
       call      System.Type.op_Inequality(System.Type, System.Type)
       test      eax,eax
       jne       short M01_L10
M01_L09:
       mov       r8,rbx
       lea       rdx,[rsp+20]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      System.Text.Json.JsonSerializer.WriteStringUsingSerializer[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L10:
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.Json.JsonSerializerOptions.GetOrAddClass(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L09
M01_L11:
       xor       ecx,ecx
       jmp       short M01_L08
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
       int       3
; Total bytes of code 488
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize03()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+30]
       call      DotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       mov       rcx,[rsi+10]
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
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rax,27F7C9C3020
       mov       rsi,[rax]
       mov       rdi,rcx
       mov       rax,27F7C9C9968
       mov       rbx,[rax]
       test      rdi,rdi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       rbp,rax
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       mov       r14d,[rbx+8]
       lea       ecx,[r14+2]
       call      System.String.FastAllocateString(Int32)
       mov       r15,rax
       mov       r8d,[rbx+8]
       cmp       r8d,[r15+8]
       jg        near ptr M01_L12
       lea       rcx,[r15+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r15+8]
       sub       ecx,r14d
       cmp       ecx,2
       jl        near ptr M01_L13
       lea       rcx,[r15+0C]
       movsxd    rdx,r14d
       lea       rcx,[rcx+rdx*2]
       mov       rdx,27F7C9C3090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r15
M01_L00:
       cmp       dword ptr [rsi+8],0
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       mov       rcx,27F7C9C3090
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L02:
       mov       rdx,rsi
       call      System.String.Concat(System.String, System.String)
       jmp       short M01_L04
M01_L03:
       mov       rdx,rbp
       call      System.String.Concat(System.String, System.String)
M01_L04:
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L05:
       mov       [rsp+20],rdi
       mov       rcx,offset MT_System.Object
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,27F7C9C9138
       cmp       rax,[rcx]
       jne       short M01_L06
       cmp       qword ptr [rsp+20],0
       je        short M01_L06
       mov       rcx,[rsp+20]
       call      System.Object.GetType()
M01_L06:
       mov       rsi,rax
       mov       rcx,27F7C9C9008
       mov       rdi,[rcx]
       cmp       byte ptr [rdi+85],0
       jne       short M01_L07
       mov       rcx,rdi
       call      System.Text.Json.JsonSerializerOptions.InitializeForReflectionSerializer()
M01_L07:
       mov       rbx,[rdi+20]
       test      rbx,rbx
       je        short M01_L11
       mov       rcx,[rbx+80]
M01_L08:
       mov       rdx,rsi
       call      System.Type.op_Inequality(System.Type, System.Type)
       test      eax,eax
       jne       short M01_L10
M01_L09:
       mov       r8,rbx
       lea       rdx,[rsp+20]
       mov       rcx,offset MD_System.Text.Json.JsonSerializer.WriteStringUsingSerializer(!!0 ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       call      System.Text.Json.JsonSerializer.WriteStringUsingSerializer[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef, System.Text.Json.Serialization.Metadata.JsonTypeInfo)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M01_L10:
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.Text.Json.JsonSerializerOptions.GetOrAddClass(System.Type)
       mov       rbx,rax
       lea       rcx,[rdi+20]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       jmp       short M01_L09
M01_L11:
       xor       ecx,ecx
       jmp       short M01_L08
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
       int       3
; Total bytes of code 488
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+18]
       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.Serialize(System.Object)
       mov       rcx,[rsi+10]
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
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp+0FFC8],rax
       mov       [rbp+0FFB0],rsp
       mov       rsi,rcx
       mov       rax,2307E163020
       mov       rdi,[rax]
       mov       rax,2309E161588
       mov       rbx,[rax]
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L05
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r14,rax
       cmp       dword ptr [rbx+8],0
       je        short M01_L01
       mov       r15d,[rbx+8]
       lea       ecx,[r15+2]
       call      System.String.FastAllocateString(Int32)
       mov       r12,rax
       mov       r8d,[rbx+8]
       cmp       r8d,[r12+8]
       jg        near ptr M01_L07
       lea       rcx,[r12+0C]
       lea       rdx,[rbx+0C]
       mov       r8d,[rbx+8]
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[r12+8]
       sub       ecx,r15d
       cmp       ecx,2
       jl        near ptr M01_L08
       lea       rcx,[r12+0C]
       movsxd    rdx,r15d
       lea       rcx,[rcx+rdx*2]
       mov       rdx,2307E163090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,r12
M01_L00:
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       jmp       short M01_L02
M01_L01:
       mov       rcx,2307E163090
       mov       rcx,[rcx]
       jmp       short M01_L00
M01_L02:
       mov       rdx,rdi
       call      System.String.Concat(System.String, System.String)
       jmp       short M01_L04
M01_L03:
       mov       rdx,r14
       call      System.String.Concat(System.String, System.String)
M01_L04:
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
M01_L05:
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.IO.StringWriter..ctor()
       mov       rcx,rdi
       mov       [rbp+0FFC8],rcx
       call      System.Xml.XmlWriter.Create(System.IO.TextWriter)
       mov       [rbp+0FFC0],rax
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
       mov       rdx,[rbp+0FFC0]
       mov       r8,rsi
       xor       r9d,r9d
       call      System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       mov       rcx,[rbp+0FFC8]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF30B22E80]
       mov       rdi,rax
       mov       rdx,[rbp+0FFC0]
       test      rdx,rdx
       je        short M01_L06
       mov       rcx,rdx
       mov       r11,7FFF30570618
       call      qword ptr [7FFF30B20618]
       nop
M01_L06:
       mov       rcx,[rbp+0FFC8]
       mov       byte ptr [rcx+28],0
       mov       edx,1
       call      qword ptr [7FFF30B1D038]
       mov       rcx,[rbp+0FFC8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rdi
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
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
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L09
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFF30570618
       call      qword ptr [7FFF30B20618]
M01_L09:
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
       push      rbp
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFC8],0
       je        short M01_L10
       mov       rcx,[rbp+0FFC8]
       mov       byte ptr [rcx+28],0
       mov       edx,1
       call      qword ptr [7FFF30B1D038]
       mov       rcx,[rbp+0FFC8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L10:
       nop
       add       rsp,40
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 682
```

## .NET 6.0.4 (6.0.422.16404), X64 RyuJIT
```assembly
; DotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.StringToXDocument()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.Benchmarking.Properties.Resources.get_XmlTestDataPersonProper()
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.StringToXDocument(System.String)
       mov       rcx,[rsi+10]
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
       mov       rdx,27894EA1F78
       mov       rdx,[rdx]
       mov       r8,278A4EA3FF8
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
       sub       rsp,28
       mov       rax,27874EA3020
       mov       rsi,[rax]
       mov       rdi,rcx
       test      rdi,rdi
       je        short M02_L01
       cmp       dword ptr [rdi+8],0
       je        short M02_L01
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L05
       jmp       short M02_L02
M02_L01:
       mov       eax,1
       jmp       short M02_L00
M02_L02:
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rcx,rax
       cmp       dword ptr [rsi+8],0
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rsi,rcx
M02_L04:
       mov       rdx,27894EA1408
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
M02_L05:
       cmp       [rdi],edi
       mov       rcx,rdi
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rcx,rax
       xor       edx,edx
       call      DotNetTips.Spargine.Core.Serialization.XmlSerialization.StringToXDocument(System.String, System.Xml.XmlResolver)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 129
```

