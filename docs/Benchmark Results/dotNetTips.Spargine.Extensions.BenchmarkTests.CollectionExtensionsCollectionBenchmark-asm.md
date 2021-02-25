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
       mov       rdx,1CAAAF02D58
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+0A0]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0D0]
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
       mov       rdx,7FFB17224828
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
       mov       rdx,7FFB172247D8
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
       mov       rdx,7FFB1720E580
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
       mov       rdx,7FFB1720E620
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
       mov       rdx,7FFB172224B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1CAAAF03060
       mov       r9,[r9]
       mov       r8,1CA8AF01760
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
       mov       rdx,7FFB172226D8
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
       mov       rdx,7FFB172228A0
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
       mov       rdx,23827752D58
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+0A0]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0D0]
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
       mov       rdx,7FFB17254828
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
       mov       rdx,7FFB172547D8
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
       mov       rdx,7FFB1723E580
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
       mov       rdx,7FFB1723E620
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
       mov       rdx,7FFB172524B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,23827753060
       mov       r9,[r9]
       mov       r8,23827753BB0
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
       mov       rdx,7FFB172526D8
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
       mov       rdx,7FFB172528A0
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
       mov       rdx,2ABDFF72D58
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+0A0]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0D0]
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
       mov       rdx,7FFB17248C38
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
       mov       rdx,7FFB17248BE8
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
       mov       rdx,7FFB1722E540
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
       mov       rdx,7FFB1722E5E0
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
       mov       rdx,7FFB172424B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,2ABDFF73060
       mov       r9,[r9]
       mov       r8,2ABDFF75BC8
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
       mov       rdx,7FFB172426D8
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
       mov       rdx,7FFB172428A0
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
       mov       rdx,17A2FFC2D58
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+0A0]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0D0]
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
       mov       rdx,7FFB17279550
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
       mov       rdx,7FFB17279500
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
       mov       rdx,7FFB1724E5F8
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
       mov       rdx,7FFB1724E698
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
       mov       rdx,7FFB172724B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,17A2FFC3060
       mov       r9,[r9]
       mov       r8,17A4FFD0350
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
       mov       rdx,7FFB172726D8
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
       mov       rdx,7FFB172728A0
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
       mov       rdx,236DBDB2D58
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+0A0]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0D0]
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
       mov       rdx,7FFB17239648
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
       mov       rdx,7FFB172395F8
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
       mov       rdx,7FFB1721E540
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
       mov       rdx,7FFB1721E5E0
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
       mov       rdx,7FFB172324B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,236DBDB3060
       mov       r9,[r9]
       mov       r8,236DBDC27A0
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
       mov       rdx,7FFB172326D8
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
       mov       rdx,7FFB172328A0
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
       mov       rdx,169EA132D58
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+0A0]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0D0]
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
       mov       rdx,7FFB17269648
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
       mov       rdx,7FFB172695F8
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
       mov       rdx,7FFB1723E5F8
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
       mov       rdx,7FFB1723E698
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
       mov       rdx,7FFB172624B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,169EA133060
       mov       r9,[r9]
       mov       r8,169EA133BB0
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
       mov       rdx,7FFB172626D8
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
       mov       rdx,7FFB172628A0
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
       mov       rdx,24143652D58
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+0A0]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0D0]
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
       mov       rdx,7FFB172395D8
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
       mov       rdx,7FFB17239588
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
       mov       rdx,7FFB1721E540
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
       mov       rdx,7FFB1721E5E0
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
       mov       rdx,7FFB172324B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,24143653060
       mov       r9,[r9]
       mov       r8,24143655BC8
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
       mov       rdx,7FFB172326D8
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
       mov       rdx,7FFB172328A0
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
       mov       rdx,22E476B2D58
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+0A0]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0D0]
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
       mov       rdx,7FFB17239570
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
       mov       rdx,7FFB17239520
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
       mov       rdx,7FFB1721E540
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
       mov       rdx,7FFB1721E5E0
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
       mov       rdx,7FFB172324B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,22E476B3060
       mov       r9,[r9]
       mov       r8,22E276B1760
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
       mov       rdx,7FFB172326D8
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
       mov       rdx,7FFB172328A0
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
       mov       rdx,16246192D58
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rsi+0A0]
       mov       edx,66666667
       mov       eax,edx
       imul      dword ptr [rsi+0D0]
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
       mov       rdx,7FFB17269AF8
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
       mov       rdx,7FFB17269AA8
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
       mov       rdx,7FFB1723E888
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
       mov       rdx,7FFB1723E928
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
       mov       rdx,7FFB172629E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L07:
       mov       rcx,rbx
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,16246193060
       mov       r9,[r9]
       mov       r8,162561A0350
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
       mov       rdx,7FFB17262C10
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
       mov       rdx,7FFB17262DD8
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
       mov       rdi,[rsi+0A0]
       mov       rcx,24DFAA8BF48
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,24DFAA8BF40
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,24DFAA8BF48
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
       mov       rdx,24E0AA811C8
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
       mov       r8,24DFAA83060
       mov       r8,[r8]
       mov       rdx,24E0AA811B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,24DFAA83060
       mov       r8,[r8]
       mov       rdx,24E0AA811C0
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
       mov       rdi,[rsi+0A0]
       mov       rcx,231C1617AE0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,231C1617AD8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,231C1617AE0
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
       mov       rdx,231D16111C8
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
       mov       r8,231E1613060
       mov       r8,[r8]
       mov       rdx,231D16111B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,231E1613060
       mov       r8,[r8]
       mov       rdx,231D16111C0
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
       mov       rdi,[rsi+0A0]
       mov       rcx,23C7DB09AF8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,23C7DB09AF0
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,23C7DB09AF8
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
       mov       rdx,23C6DB011C8
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
       mov       r8,23C5DB03060
       mov       r8,[r8]
       mov       rdx,23C6DB011B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,23C5DB03060
       mov       r8,[r8]
       mov       rdx,23C6DB011C0
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
       mov       rdi,[rsi+0A0]
       mov       rcx,204CCEF9AF8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,204CCEF9AF0
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,204CCEF9AF8
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
       mov       rdx,204CCEFFDB8
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
       mov       r8,204BCEF3060
       mov       r8,[r8]
       mov       rdx,204CCEFFDA8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,204BCEF3060
       mov       r8,[r8]
       mov       rdx,204CCEFFDB0
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
       mov       rdi,[rsi+0A0]
       mov       rcx,21913827AE0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,21913827AD8
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,21913827AE0
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
       mov       rdx,21923825630
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
       mov       r8,21923823060
       mov       r8,[r8]
       mov       rdx,21923825620
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,21923823060
       mov       r8,[r8]
       mov       rdx,21923825628
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
       mov       rdi,[rsi+0A0]
       mov       rcx,2E860E99F30
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2E860E99F28
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,2E860E99F30
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
       mov       rdx,2E840E93A18
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
       mov       r8,2E860E91048
       mov       r8,[r8]
       mov       rdx,2E840E93A08
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,2E860E91048
       mov       r8,[r8]
       mov       rdx,2E840E93A10
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
       mov       rdi,[rsi+0A0]
       mov       rcx,17427259AF8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,17427259AF0
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,17427259AF8
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
       mov       rdx,17437270600
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
       mov       r8,17417253060
       mov       r8,[r8]
       mov       rdx,174372705F0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,17417253060
       mov       r8,[r8]
       mov       rdx,174372705F8
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
       mov       rdi,[rsi+0A0]
       mov       rcx,27E427F9AF8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,27E427F9AF0
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,27E427F9AF8
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
       mov       rdx,27E327F11C8
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
       mov       r8,27E127F3060
       mov       r8,[r8]
       mov       rdx,27E327F11B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,27E127F3060
       mov       r8,[r8]
       mov       rdx,27E327F11C0
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
       mov       rdi,[rsi+0A0]
       mov       rcx,1EFF5B1BF48
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Predicate`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1EFF5B1BF40
       mov       rdx,[rdx]
       test      rdx,rdx
       je        short M00_L01
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset dotNetTips.Spargine.Extensions.BenchmarkTests.CollectionExtensionsCollectionBenchmark+<>c.<HasItems>b__1_0(dotNetTips.Spargine.Tester.Models.PersonProper)
       mov       [rbx+18],rdx
       mov       rcx,1EFF5B1BF48
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
       mov       rdx,1F015B111C8
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
       mov       r8,1EFF5B13060
       mov       r8,[r8]
       mov       rdx,1F015B111B8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       r8,1EFF5B13060
       mov       r8,[r8]
       mov       rdx,1F015B111C0
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

