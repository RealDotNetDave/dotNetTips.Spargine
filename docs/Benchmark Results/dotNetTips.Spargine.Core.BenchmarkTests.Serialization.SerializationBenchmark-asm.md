## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      dotNetTips.Spargine.Benchmarking.Properties.Resources.get_XmlTestDataPersonProper()
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
; dotNetTips.Spargine.Benchmarking.Properties.Resources.get_XmlTestDataPersonProper()
       sub       rsp,28
       call      dotNetTips.Spargine.Benchmarking.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,21DDCF110E0
       mov       rdx,[rdx]
       mov       r8,21DBCF159A8
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
       mov       r8,21DBCF13060
       mov       r8,[r8]
       mov       rdx,21DDCF11128
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
; dotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Deserialize02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      dotNetTips.Spargine.Benchmarking.Properties.Resources.get_XmlTestDataPersonProper()
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
; dotNetTips.Spargine.Benchmarking.Properties.Resources.get_XmlTestDataPersonProper()
       sub       rsp,28
       call      dotNetTips.Spargine.Benchmarking.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,2A2FCA53530
       mov       rdx,[rdx]
       mov       r8,2A30CA55570
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
       mov       r8,2A2FCA51048
       mov       r8,[r8]
       mov       rdx,2A2FCA53578
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
; dotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize02()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      dotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
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
; dotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       mov       r9,20820B93060
       mov       r9,[r9]
       mov       r8,20850B910E0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       call      System.IO.MemoryStream..ctor(Int32)
       mov       [rbp+0FFD8],rdi
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      00007FFE9FDE23C0
       mov       rbx,rax
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializerImpl
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [rsp+20],7FFFFFFF
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],ecx
       mov       [rsp+38],ecx
       mov       [rsp+40],rcx
       mov       [rsp+48],ecx
       mov       rcx,r14
       mov       rdx,rbx
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.Runtime.Serialization.Json.DataContractJsonSerializerImpl.Initialize(System.Type, System.Xml.XmlDictionaryString, System.Collections.Generic.IEnumerable`1<System.Type>, Int32, Boolean, System.Runtime.Serialization.EmitTypeInformation, Boolean, System.Runtime.Serialization.DateTimeFormat, Boolean)
       lea       rcx,[rdi+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+28]
       mov       rdx,[rbp+0FFD8]
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE40573278]
       mov       rcx,20820B91AF8
       mov       rsi,[rcx]
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFE4056FA38]
       mov       rdi,rax
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFE4056FA38]
       mov       r9d,[rax+8]
       mov       rdx,rdi
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE4056BF08]
       mov       rsi,rax
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      qword ptr [7FFE4056F968]
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       mov       rbp,[rcx+50]
       mov       [rsp+50],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L00
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      qword ptr [7FFE4056F968]
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L00:
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 400
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize03()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       mov       rcx,rax
       call      dotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
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
; dotNetTips.Spargine.Core.Serialization.JsonSerialization.Serialize(System.Object)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       test      rsi,rsi
       setne     dl
       movzx     edx,dl
       mov       r9,134926E1048
       mov       r9,[r9]
       mov       r8,134A26E70F0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       rcx,offset MT_System.IO.MemoryStream
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       xor       edx,edx
       call      System.IO.MemoryStream..ctor(Int32)
       mov       [rbp+0FFD8],rdi
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializer
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rsi
       call      00007FFE9FDE23C0
       mov       rbx,rax
       mov       rcx,offset MT_System.Runtime.Serialization.Json.DataContractJsonSerializerImpl
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       dword ptr [rsp+20],7FFFFFFF
       xor       ecx,ecx
       mov       [rsp+28],ecx
       mov       [rsp+30],ecx
       mov       [rsp+38],ecx
       mov       [rsp+40],rcx
       mov       [rsp+48],ecx
       mov       rcx,r14
       mov       rdx,rbx
       xor       r8d,r8d
       xor       r9d,r9d
       call      System.Runtime.Serialization.Json.DataContractJsonSerializerImpl.Initialize(System.Type, System.Xml.XmlDictionaryString, System.Collections.Generic.IEnumerable`1<System.Type>, Int32, Boolean, System.Runtime.Serialization.EmitTypeInformation, Boolean, System.Runtime.Serialization.DateTimeFormat, Boolean)
       lea       rcx,[rdi+28]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rdi+28]
       mov       rdx,[rbp+0FFD8]
       mov       r8,rsi
       cmp       [rcx],ecx
       call      qword ptr [7FFE40553278]
       mov       rcx,134826E1AF8
       mov       rsi,[rcx]
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFE4054FA38]
       mov       rdi,rax
       mov       rcx,[rbp+0FFD8]
       call      qword ptr [7FFE4054FA38]
       mov       r9d,[rax+8]
       mov       rdx,rdi
       mov       rcx,rsi
       xor       r8d,r8d
       cmp       [rcx],ecx
       call      qword ptr [7FFE4054BF08]
       mov       rsi,rax
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      qword ptr [7FFE4054F968]
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
       mov       rax,rsi
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       mov       rbp,[rcx+50]
       mov       [rsp+50],rbp
       lea       rbp,[rbp+80]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M01_L00
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      qword ptr [7FFE4054F968]
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
M01_L00:
       nop
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 400
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.Serialize01()
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
       mov       r9,1B8C2893060
       mov       r9,[r9]
       mov       r8,1B8F28910E0
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
       call      00007FFE9FDE23C0
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
       call      qword ptr [7FFE405731E8]
       mov       rsi,rax
       cmp       qword ptr [rbp+0FFE0],0
       je        short M01_L00
       mov       rcx,[rbp+0FFE0]
       mov       r11,7FFE40190690
       call      qword ptr [7FFE40570690]
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
       mov       r11,7FFE40190690
       call      qword ptr [7FFE40570690]
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
; dotNetTips.Spargine.Core.BenchmarkTests.Serialization.SerializationBenchmark.StringToXDocument()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      dotNetTips.Spargine.Benchmarking.Properties.Resources.get_XmlTestDataPersonProper()
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
; dotNetTips.Spargine.Benchmarking.Properties.Resources.get_XmlTestDataPersonProper()
       sub       rsp,28
       call      dotNetTips.Spargine.Benchmarking.Properties.Resources.get_ResourceManager()
       mov       rcx,rax
       mov       rdx,1C7DF9470F0
       mov       rdx,[rdx]
       mov       r8,1C7DF945570
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
       mov       r8,1C7CF943060
       mov       r8,[r8]
       mov       rdx,1C7EF9411B8
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
       mov       rdx,1C7CF943060
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
       mov       r11,7FFE40190528
       call      qword ptr [7FFE40560528]
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
       mov       r11,7FFE40190528
       call      qword ptr [7FFE40560528]
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

