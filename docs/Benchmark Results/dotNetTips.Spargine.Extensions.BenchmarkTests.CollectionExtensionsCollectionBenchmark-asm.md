## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
; 			var people = new List<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			CollectionExtensions.AddRange(people, base.PersonProperCollection.Take(base.Count / 10), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2315A312D58
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+98]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0C0]
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       mov       rdx,rcx
       mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        short M01_L05
       test      edi,edi
       jle       short M01_L02
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB37006BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdx,7FFB37006B78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M02_L00
       mov       rcx,[r14+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37000AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       [r15+10],ebp
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M02_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L03
M02_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       lea       rbx,[r15+8]
       mov       rbp,[r14+18]
       test      rbp,rbp
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37000B88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,rbp
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r12+8],al
       mov       rcx,r12
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbx,[r15+8]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37004850
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,2315A313060
       mov       r9,[r9]
       mov       r8,2316A31E170
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       byte ptr [r15+14],0
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L12
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37004A78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M02_L10
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37004C40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
M02_L12:
       movzx     eax,byte ptr [r15+14]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 486
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
; 			var people = new List<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			CollectionExtensions.AddRange(people, base.PersonProperCollection.Take(base.Count / 10), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,157DB172D58
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+98]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0C0]
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       mov       rdx,rcx
       mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        short M01_L05
       test      edi,edi
       jle       short M01_L02
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+28]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB37006928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdx,7FFB370068D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M02_L00
       mov       rcx,[r14+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37000B68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       [r15+10],ebp
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M02_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L03
M02_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       lea       rbx,[r15+8]
       mov       rbp,[r14+18]
       test      rbp,rbp
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37000C08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,rbp
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r12+8],al
       mov       rcx,r12
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbx,[r15+8]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB370048D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,157DB173060
       mov       r9,[r9]
       mov       r8,157BB171748
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       byte ptr [r15+14],0
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L12
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37004AF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M02_L10
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37004CC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
M02_L12:
       movzx     eax,byte ptr [r15+14]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 486
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
; 			var people = new List<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			CollectionExtensions.AddRange(people, base.PersonProperCollection.Take(base.Count / 10), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,247683D2D58
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+98]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0C0]
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       mov       rdx,rcx
       mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        short M01_L05
       test      edi,edi
       jle       short M01_L02
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB3700ADF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdx,7FFB3700ADA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M02_L00
       mov       rcx,[r14+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37000AA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       [r15+10],ebp
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M02_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L03
M02_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       lea       rbx,[r15+8]
       mov       rbp,[r14+18]
       test      rbp,rbp
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37000B48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,rbp
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r12+8],al
       mov       rcx,r12
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbx,[r15+8]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37004810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,247683D3060
       mov       r9,[r9]
       mov       r8,247783D1748
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       byte ptr [r15+14],0
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L12
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37004A38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M02_L10
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37004C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
M02_L12:
       movzx     eax,byte ptr [r15+14]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 486
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
; 			var people = new List<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			CollectionExtensions.AddRange(people, base.PersonProperCollection.Take(base.Count / 10), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,268E12E2D58
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+98]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0C0]
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       mov       rdx,rcx
       mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        short M01_L05
       test      edi,edi
       jle       short M01_L02
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB3700B6E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdx,7FFB3700B698
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M02_L00
       mov       rcx,[r14+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37000B28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       [r15+10],ebp
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M02_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L03
M02_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       lea       rbx,[r15+8]
       mov       rbp,[r14+18]
       test      rbp,rbp
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37000BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,rbp
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r12+8],al
       mov       rcx,r12
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbx,[r15+8]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37004890
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,268E12E3060
       mov       r9,[r9]
       mov       r8,268D12E9700
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       byte ptr [r15+14],0
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L12
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37004AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M02_L10
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37004C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
M02_L12:
       movzx     eax,byte ptr [r15+14]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 486
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
; 			var people = new List<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			CollectionExtensions.AddRange(people, base.PersonProperCollection.Take(base.Count / 10), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,238D8662D58
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+98]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0C0]
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       mov       rdx,rcx
       mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        short M01_L05
       test      edi,edi
       jle       short M01_L02
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB3700B9F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdx,7FFB3700B9A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M02_L00
       mov       rcx,[r14+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37000C98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       [r15+10],ebp
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M02_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L03
M02_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       lea       rbx,[r15+8]
       mov       rbp,[r14+18]
       test      rbp,rbp
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37000D38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,rbp
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r12+8],al
       mov       rcx,r12
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbx,[r15+8]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37004A00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,238D8663060
       mov       r9,[r9]
       mov       r8,238B8661748
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       byte ptr [r15+14],0
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L12
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37004C28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M02_L10
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37004DF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
M02_L12:
       movzx     eax,byte ptr [r15+14]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 486
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
; 			var people = new List<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			CollectionExtensions.AddRange(people, base.PersonProperCollection.Take(base.Count / 10), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,15F88992D58
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+98]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0C0]
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       mov       rdx,rcx
       mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        short M01_L05
       test      edi,edi
       jle       short M01_L02
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FEB810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdx,7FFB36FEB7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M02_L00
       mov       rcx,[r14+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       [r15+10],ebp
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M02_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L03
M02_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       lea       rbx,[r15+8]
       mov       rbp,[r14+18]
       test      rbp,rbp
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0BA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,rbp
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r12+8],al
       mov       rcx,r12
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbx,[r15+8]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FE4870
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,15F78991048
       mov       r9,[r9]
       mov       r8,15F68991748
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       byte ptr [r15+14],0
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L12
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FE4A98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M02_L10
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FE4C60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
M02_L12:
       movzx     eax,byte ptr [r15+14]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 486
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
; 			var people = new List<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			CollectionExtensions.AddRange(people, base.PersonProperCollection.Take(base.Count / 10), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,204504C2D58
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+98]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0C0]
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       mov       rdx,rcx
       mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        short M01_L05
       test      edi,edi
       jle       short M01_L02
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB3701BA40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdx,7FFB3701B9F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M02_L00
       mov       rcx,[r14+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37010D38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       [r15+10],ebp
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M02_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L03
M02_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       lea       rbx,[r15+8]
       mov       rbp,[r14+18]
       test      rbp,rbp
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37010DD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,rbp
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r12+8],al
       mov       rcx,r12
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbx,[r15+8]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37014AA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,204404C1048
       mov       r9,[r9]
       mov       r8,204604CE170
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       byte ptr [r15+14],0
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L12
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37014CC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M02_L10
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37014E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
M02_L12:
       movzx     eax,byte ptr [r15+14]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 486
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
; 			var people = new List<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			CollectionExtensions.AddRange(people, base.PersonProperCollection.Take(base.Count / 10), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,235A3772D58
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+98]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0C0]
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       mov       rdx,rcx
       mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        short M01_L05
       test      edi,edi
       jle       short M01_L02
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FEBB48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdx,7FFB36FEBAF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M02_L00
       mov       rcx,[r14+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0F18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       [r15+10],ebp
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M02_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L03
M02_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       lea       rbx,[r15+8]
       mov       rbp,[r14+18]
       test      rbp,rbp
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,rbp
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r12+8],al
       mov       rcx,r12
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbx,[r15+8]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FE4C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,235A3773060
       mov       r9,[r9]
       mov       r8,235A3773B98
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       byte ptr [r15+14],0
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L12
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FE4EA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M02_L10
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FE5070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
M02_L12:
       movzx     eax,byte ptr [r15+14]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 486
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.AddRange01()
; 			var people = new List<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			CollectionExtensions.AddRange(people, base.PersonProperCollection.Take(base.Count / 10), Tristate.True);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(people);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1EE8F5E2D58
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+98]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0C0]
       mov       r8d,edx
       shr       r8d,1F
       sar       edx,2
       add       r8d,edx
       mov       rdx,rcx
       mov       rcx,offset MD_System.Linq.Enumerable.Take(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       call      System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, dotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rdi
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 153
```
```assembly
; System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       edi,r8d
       test      rsi,rsi
       je        short M01_L05
       test      edi,edi
       jle       short M01_L02
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+20]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FEBB48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       mov       r8d,edi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
M01_L02:
       mov       rdx,[rcx+10]
       mov       rdx,[rdx+18]
       test      rdx,rdx
       je        short M01_L03
       jmp       short M01_L04
M01_L03:
       mov       rdx,7FFB36FEBAF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L04:
       mov       rcx,rdx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Empty[[System.__Canon, System.Private.CoreLib]]()
M01_L05:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, dotNetTips.Spargine.Core.Tristate)
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       rdi,r8
       mov       ebp,r9d
       mov       r14,[rsi+10]
       cmp       qword ptr [r14+10],0
       je        short M02_L00
       mov       rcx,[r14+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0F18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r15,rax
       mov       [r15+10],ebp
       lea       rcx,[r15+8]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       test      rdi,rdi
       je        short M02_L02
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L03
M02_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
M02_L03:
       lea       rbx,[r15+8]
       mov       rbp,[r14+18]
       test      rbp,rbp
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L05:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r12,rax
       mov       rcx,rbp
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r12+8],al
       mov       rcx,r12
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbx,[r15+8]
       mov       r11,[r14+20]
       test      r11,r11
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FE4C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1EE8F5E3060
       mov       r9,[r9]
       mov       r8,1EE9F5E1748
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       byte ptr [r15+14],0
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      cl
       movzx     ecx,cl
       test      ecx,ecx
       je        near ptr M02_L12
       mov       rcx,[r14+28]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FE4EA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       mov       rbx,[rsi+10]
       mov       rdx,rdi
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdi,rax
       cmp       qword ptr [rbx+8],30
       jle       short M02_L10
       mov       rcx,[rbx+30]
       test      rcx,rcx
       je        short M02_L10
       jmp       short M02_L11
M02_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FE5070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L11:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       lea       rcx,[rsi+8]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.CollectionExtensions+<>c__DisplayClass3_0`1[[System.__Canon, System.Private.CoreLib]].<AddRange>b__0(System.__Canon)
       mov       [rsi+18],rcx
       mov       rcx,rdi
       mov       rdx,rsi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
M02_L12:
       movzx     eax,byte ptr [r15+14]
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 486
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
; 			var result = base.PersonProperCollection.HasItems(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,15794DDBD98
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,15794DDBD90
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,15794DDBD98
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.HasItems(p => p.City.Contains("SAN"));
; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,157A4DD11B0
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       mov       rdi,r8
       mov       r8,15794DD3060
       mov       r8,[r8]
       mov       rdx,157A4DD11A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,15794DD3060
       mov       r8,[r8]
       mov       rdx,157A4DD11A8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
; Total bytes of code 99
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
; 			var result = base.PersonProperCollection.HasItems(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1D7C9837328
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1D7C9837320
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1D7C9837328
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.HasItems(p => p.City.Contains("SAN"));
; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,1D7C983D5D0
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       mov       rdi,r8
       mov       r8,1D7C9833060
       mov       r8,[r8]
       mov       rdx,1D7C983D5C0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,1D7C9833060
       mov       r8,[r8]
       mov       rdx,1D7C983D5C8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
; Total bytes of code 99
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
; 			var result = base.PersonProperCollection.HasItems(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1E4D9D94ED8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E4D9D94ED0
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1E4D9D94ED8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.HasItems(p => p.City.Contains("SAN"));
; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,1E509D911B0
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       mov       rdi,r8
       mov       r8,1E4E9D91048
       mov       r8,[r8]
       mov       rdx,1E509D911A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,1E4E9D91048
       mov       r8,[r8]
       mov       rdx,1E509D911A8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
; Total bytes of code 99
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
; 			var result = base.PersonProperCollection.HasItems(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1CC49AD2EC0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1CC49AD2EB8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1CC49AD2EC0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.HasItems(p => p.City.Contains("SAN"));
; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,1CC39AD11B0
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       mov       rdi,r8
       mov       r8,1CC59AD3060
       mov       r8,[r8]
       mov       rdx,1CC39AD11A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,1CC59AD3060
       mov       r8,[r8]
       mov       rdx,1CC39AD11A8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
; Total bytes of code 99
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
; 			var result = base.PersonProperCollection.HasItems(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,233EC527930
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,233EC527928
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,233EC527930
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.HasItems(p => p.City.Contains("SAN"));
; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,233DC525618
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       mov       rdi,r8
       mov       r8,233DC523060
       mov       r8,[r8]
       mov       rdx,233DC525608
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,233DC523060
       mov       r8,[r8]
       mov       rdx,233DC525610
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
; Total bytes of code 99
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
; 			var result = base.PersonProperCollection.HasItems(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1F3690D5310
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F3690D5308
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1F3690D5310
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.HasItems(p => p.City.Contains("SAN"));
; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,1F3890D5C20
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       mov       rdi,r8
       mov       r8,1F3690D3060
       mov       r8,[r8]
       mov       rdx,1F3890D5C10
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,1F3690D3060
       mov       r8,[r8]
       mov       rdx,1F3890D5C18
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
; Total bytes of code 99
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
; 			var result = base.PersonProperCollection.HasItems(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1CECDEF7328
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1CECDEF7320
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1CECDEF7328
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.HasItems(p => p.City.Contains("SAN"));
; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,1CEADEF11B0
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       mov       rdi,r8
       mov       r8,1CECDEF3060
       mov       r8,[r8]
       mov       rdx,1CEADEF11A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,1CECDEF3060
       mov       r8,[r8]
       mov       rdx,1CEADEF11A8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
; Total bytes of code 99
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
; 			var result = base.PersonProperCollection.HasItems(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1C710F59D80
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C710F59D78
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1C710F59D80
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.HasItems(p => p.City.Contains("SAN"));
; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,1C720F511B0
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       mov       rdi,r8
       mov       r8,1C710F51048
       mov       r8,[r8]
       mov       rdx,1C720F511A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,1C710F51048
       mov       r8,[r8]
       mov       rdx,1C720F511A8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
; Total bytes of code 99
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark.HasItems()
; 			var result = base.PersonProperCollection.HasItems(p => p.City.Contains("SAN"));
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+98]
       mov       rcx,1FBABCA9948
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1FBABCA9940
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1FBABCA9948
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ListExtensions.HasItems(System.Collections.Generic.List`1<!!0>, System.Predicate`1<!!0>)
       call      dotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M00_L01:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 154
```
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
; 			var result = base.PersonProperCollection.HasItems(p => p.City.Contains("SAN"));
; 			                                                       ^^^^^^^^^^^^^^^^^^^^^^
       sub       rsp,28
       mov       rcx,[rdx+20]
       cmp       [rcx],ecx
       mov       rdx,1FBBBCA11B0
       mov       r8,[rdx]
       test      r8,r8
       je        short M01_L00
       lea       rdx,[rcx+0C]
       mov       r9d,[rcx+8]
       cmp       [r8],r8d
       add       r8,0C
       mov       rcx,rdx
       mov       edx,r9d
       mov       r9d,3
       call      System.SpanHelpers.IndexOf(Char ByRef, Int32, Char ByRef, Int32)
       test      eax,eax
       setge     al
       movzx     eax,al
       add       rsp,28
       ret
M01_L00:
       mov       ecx,7
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
; Total bytes of code 84
```
```assembly
; dotNetTips.Spargine.Extensions.ListExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.List`1<System.__Canon>, System.Predicate`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       mov       rdi,r8
       mov       r8,1FB9BCA3060
       mov       r8,[r8]
       mov       rdx,1FBBBCA11A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,1FB9BCA3060
       mov       r8,[r8]
       mov       rdx,1FBBBCA11A8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].TrueForAll(System.Predicate`1<System.__Canon>)
; Total bytes of code 99
```
**Method was not JITted yet.**
System.MulticastDelegate.ThrowNullThisInDelegateToInstance()

