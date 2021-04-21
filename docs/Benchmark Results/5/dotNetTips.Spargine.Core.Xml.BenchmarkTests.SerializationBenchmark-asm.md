## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.Xml.BenchmarkTests.SerializationBenchmark.Deserialize01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      dotNetTips.Spargine.Benchmarking.Properties.Resources.get_XmlTestData()
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize(System.String)
       call      dotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
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
; dotNetTips.Spargine.Benchmarking.Properties.Resources.get_XmlTestData()
       sub       rsp,28
       call      dotNetTips.Spargine.Benchmarking.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,29E0CEE1900
       mov       rdx,[rdx]
       mov       r8,29E1CEE36A8
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; dotNetTips.Spargine.Core.Serialization.XmlSerialization.Deserialize[[System.__Canon, System.Private.CoreLib]](System.String)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       [rbp+0FFE0],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,29E2CEE3060
       mov       r8,[r8]
       mov       rdx,29E0CEE1948
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       mov       rdx,rsi
       call      System.IO.StringReader..ctor(System.String)
       mov       [rbp+0FFD8],rbx
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rdi,[rdi+10]
       mov       rcx,[rdi]
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       mov       rcx,rsi
       mov       rdx,[rbp+0FFD8]
       call      System.Xml.Serialization.XmlSerializer.Deserialize(System.IO.TextReader)
       mov       rdx,rax
       mov       rcx,[rdi]
       call      CORINFO_HELP_CHKCASTARRAY
       mov       rsi,rax
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rcx,[rbp+0FFD8]
       mov       [rcx+10],eax
       mov       rcx,[rbp+0FFD8]
       mov       [rcx+14],eax
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
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
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M02_L00
       mov       rcx,[rbp+0FFD8]
       xor       eax,eax
       mov       [rcx+8],rax
       mov       rcx,[rbp+0FFD8]
       mov       [rcx+10],eax
       mov       rcx,[rbp+0FFD8]
       mov       [rcx+14],eax
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
M02_L00:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 280
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.Xml.BenchmarkTests.SerializationBenchmark.Serialize()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Core.Serialization.XmlSerialization.Serialize(System.Object)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 54
```
```assembly
; dotNetTips.Spargine.Core.Serialization.XmlSerialization.Serialize(System.Object)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFE8],rax
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       mov       r9,1FB322F3060
       mov       r9,[r9]
       mov       r8,1FB222F10C8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,offset MT_System.IO.StringWriter
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.IO.StringWriter..ctor()
       mov       [rbp+0FFE8],rdi
       mov       rcx,[rbp+0FFE8]
       call      System.Xml.XmlWriter.Create(System.IO.TextWriter)
       mov       [rbp+0FFE0],rax
       mov       rcx,offset MT_System.Xml.Serialization.XmlSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      00007FFB967623C0
       mov       rdx,rax
       mov       rcx,rdi
       xor       r8d,r8d
       call      System.Xml.Serialization.XmlSerializer..ctor(System.Type, System.String)
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       [rsp+28],rcx
       mov       rcx,rdi
       mov       rdx,[rbp+0FFE0]
       mov       r8,rsi
       xor       r9d,r9d
       call      System.Xml.Serialization.XmlSerializer.Serialize(System.Xml.XmlWriter, System.Object, System.Xml.Serialization.XmlSerializerNamespaces, System.String, System.String)
       mov       rcx,[rbp+0FFE8]
       mov       rcx,[rcx+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFB36ED31E8]
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFB36B00638
       call      qword ptr [7FFB36EE0638]
       nop
M01_L00:
       mov       rcx,[rbp+0FFE8]
       mov       byte ptr [rcx+28],0
       mov       rcx,[rbp+0FFE8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFF0]
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L01
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFB36B00638
       call      qword ptr [7FFB36EE0638]
M01_L01:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,40
       mov       rbp,[rcx+30]
       mov       [rsp+30],rbp
       lea       rbp,[rbp+60]
       cmp       qword ptr [rbp+0FFE8],0
       je        short M01_L02
       mov       rcx,[rbp+0FFE8]
       mov       byte ptr [rcx+28],0
       mov       rcx,[rbp+0FFE8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L02:
       nop
       add       rsp,40
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 372
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.Xml.BenchmarkTests.SerializationBenchmark.StringToXDocument()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      dotNetTips.Spargine.Benchmarking.Properties.Resources.get_XmlTestData()
       mov       rcx,rax
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Serialization.XmlSerialization.StringToXDocument(System.String, System.Xml.XmlResolver)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 48
```
```assembly
; dotNetTips.Spargine.Benchmarking.Properties.Resources.get_XmlTestData()
       sub       rsp,28
       call      dotNetTips.Spargine.Benchmarking.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,24FC87C10C8
       mov       rdx,[rdx]
       mov       r8,24FD87C7B10
       mov       r8,[r8]
       mov       rax,[rax]
       mov       rax,[rax+48]
       mov       rax,[rax+28]
       add       rsp,28
       jmp       rax
; Total bytes of code 56
```
```assembly
; dotNetTips.Spargine.Core.Serialization.XmlSerialization.StringToXDocument(System.String, System.Xml.XmlResolver)
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,24FD87C3060
       mov       r8,[r8]
       mov       rdx,24FD87C9618
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.String, System.String, System.String)
       mov       rcx,offset MT_System.Xml.XmlReaderSettings
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       xor       edx,edx
       call      System.Xml.XmlReaderSettings.Initialize(System.Xml.XmlResolver)
       mov       rcx,rbx
       xor       edx,edx
       call      System.Xml.XmlReaderSettings.set_DtdProcessing(System.Xml.DtdProcessing)
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Xml.XmlReaderSettings.set_XmlResolver(System.Xml.XmlResolver)
       mov       rcx,offset MT_System.IO.StringReader
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       mov       rdx,rsi
       call      System.IO.StringReader..ctor(System.String)
       mov       rcx,rbx
       mov       rdx,24FD87C3060
       mov       r8,[rdx]
       mov       rdx,rdi
       xor       r9d,r9d
       cmp       [rcx],ecx
       call      System.Xml.XmlReaderSettings.CreateReader(System.IO.TextReader, System.String, System.Xml.XmlParserContext)
       mov       [rbp+0FFE0],rax
       mov       rcx,[rbp+0FFE0]
       xor       edx,edx
       call      System.Xml.Linq.XDocument.Load(System.Xml.XmlReader, System.Xml.Linq.LoadOptions)
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFB36B004F8
       call      qword ptr [7FFB36ED04F8]
M02_L00:
       mov       rax,rsi
       lea       rsp,[rbp+0FFE8]
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
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFE0],0
       je        short M02_L01
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFB36B004F8
       call      qword ptr [7FFB36ED04F8]
M02_L01:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 279
```

