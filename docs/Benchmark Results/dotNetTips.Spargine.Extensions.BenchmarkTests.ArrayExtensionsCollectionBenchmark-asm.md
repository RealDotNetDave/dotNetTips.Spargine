## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.PersonProperCollection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newPeople = people.Shuffle(10).ToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(newPeople);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FFC0B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L11
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFB36FFC108
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB36FFC0C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,rdi
       mov       rdx,[rbx+88]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFB36FFC120
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M01_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFB36FFC130
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFB36FFC0C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+70]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFB36FFC0D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B00640
       call      qword ptr [7FFB36F10640]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB36FFC0F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L19
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B00640
       call      qword ptr [7FFB36F10640]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B00648
       call      qword ptr [7FFB36F10648]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B00648
       call      qword ptr [7FFB36F10648]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 726
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r8,21AEEE71048
       mov       r8,[r8]
       mov       rdx,21ADEE711A0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,21AEEE71048
       mov       rbp,[rax]
       test      edi,edi
       jle       short M02_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
M02_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rcx,rax
       test      rbp,rbp
       je        short M02_L01
       cmp       dword ptr [rbp+8],0
       ja        short M02_L02
M02_L01:
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbp
M02_L03:
       mov       rdx,21AEEE71438
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L04:
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0E98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 229
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FFD430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FFD4F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FFD4C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+78],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L00
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
M04_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FF1FB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M04_L02:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdx,[rsp+78]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbp,[rsp+78]
       mov       r11,[rbx+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB36FF5C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,21AEEE71048
       mov       r9,[r9]
       mov       r8,21ACEE80188
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M04_L09
M04_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M04_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rdi
       mov       rdx,7FFB36FF6078
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M04_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M04_L05
M04_L09:
       mov       eax,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.PersonProperCollection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newPeople = people.Shuffle(10).ToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(newPeople);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FEC258
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L11
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFB36FEC2A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB36FEC268
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,rdi
       mov       rdx,[rbx+88]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFB36FEC2C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M01_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFB36FEC2D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFB36FEC268
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+70]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFB36FEC278
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0648
       call      qword ptr [7FFB36F00648]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB36FEC290
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L19
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0648
       call      qword ptr [7FFB36F00648]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0650
       call      qword ptr [7FFB36F00650]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0650
       call      qword ptr [7FFB36F00650]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 726
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r8,221D3983060
       mov       r8,[r8]
       mov       rdx,221D3992030
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,221D3983060
       mov       rbp,[rax]
       test      edi,edi
       jle       short M02_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
M02_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rcx,rax
       test      rbp,rbp
       je        short M02_L01
       cmp       dword ptr [rbp+8],0
       ja        short M02_L02
M02_L01:
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbp
M02_L03:
       mov       rdx,221D3983450
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L04:
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0E98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 229
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FED5D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FED698
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FED668
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+78],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L00
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
M04_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FE1FB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M04_L02:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdx,[rsp+78]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbp,[rsp+78]
       mov       r11,[rbx+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB36FE5C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,221D3983060
       mov       r9,[r9]
       mov       r8,221C3981748
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M04_L09
M04_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M04_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rdi
       mov       rdx,7FFB36FE6078
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M04_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M04_L05
M04_L09:
       mov       eax,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.PersonProperCollection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newPeople = people.Shuffle(10).ToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(newPeople);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FEC258
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L11
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFB36FEC2A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB36FEC268
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,rdi
       mov       rdx,[rbx+88]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFB36FEC2C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M01_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFB36FEC2D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFB36FEC268
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+70]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFB36FEC278
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0648
       call      qword ptr [7FFB36F00648]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB36FEC290
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L19
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0648
       call      qword ptr [7FFB36F00648]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0650
       call      qword ptr [7FFB36F00650]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0650
       call      qword ptr [7FFB36F00650]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 726
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r8,280D6D03060
       mov       r8,[r8]
       mov       rdx,280B6D011A0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,280D6D03060
       mov       rbp,[rax]
       test      edi,edi
       jle       short M02_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
M02_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rcx,rax
       test      rbp,rbp
       je        short M02_L01
       cmp       dword ptr [rbp+8],0
       ja        short M02_L02
M02_L01:
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbp
M02_L03:
       mov       rdx,280D6D03450
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L04:
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0E98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0EE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 229
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FED5D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FED698
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FED668
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+78],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L00
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
M04_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FE1FB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M04_L02:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdx,[rsp+78]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbp,[rsp+78]
       mov       r11,[rbx+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB36FE5C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,280D6D03060
       mov       r9,[r9]
       mov       r8,280D6D125D8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M04_L09
M04_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M04_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rdi
       mov       rdx,7FFB36FE6078
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M04_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M04_L05
M04_L09:
       mov       eax,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.PersonProperCollection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newPeople = people.Shuffle(10).ToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(newPeople);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FDC440
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L11
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFB36FDC490
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB36FDC450
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,rdi
       mov       rdx,[rbx+88]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFB36FDC4A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M01_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFB36FDC4B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFB36FDC450
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+70]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFB36FDC460
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AE0648
       call      qword ptr [7FFB36EF0648]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB36FDC478
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L19
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AE0648
       call      qword ptr [7FFB36EF0648]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AE0650
       call      qword ptr [7FFB36EF0650]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AE0650
       call      qword ptr [7FFB36EF0650]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 726
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r8,17603EB1048
       mov       r8,[r8]
       mov       rdx,175D3EB5C10
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,17603EB1048
       mov       rbp,[rax]
       test      edi,edi
       jle       short M02_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
M02_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rcx,rax
       test      rbp,rbp
       je        short M02_L01
       cmp       dword ptr [rbp+8],0
       ja        short M02_L02
M02_L01:
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbp
M02_L03:
       mov       rdx,17603EB1438
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L04:
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FD1080
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB36FD10D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 229
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FDD7B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FDD880
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FDD850
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+78],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L00
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
M04_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FD2198
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M04_L02:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdx,[rsp+78]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbp,[rsp+78]
       mov       r11,[rbx+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB36FD5E60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,17603EB1048
       mov       r9,[r9]
       mov       r8,175F3EBB718
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M04_L09
M04_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M04_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rdi
       mov       rdx,7FFB36FD6260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M04_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M04_L05
M04_L09:
       mov       eax,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.PersonProperCollection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newPeople = people.Shuffle(10).ToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(newPeople);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB3700C6C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L11
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFB3700C718
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB3700C6D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,rdi
       mov       rdx,[rbx+88]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFB3700C730
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M01_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFB3700C740
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFB3700C6D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+70]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFB3700C6E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B10648
       call      qword ptr [7FFB36F20648]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB3700C700
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L19
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B10648
       call      qword ptr [7FFB36F20648]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B10650
       call      qword ptr [7FFB36F20650]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B10650
       call      qword ptr [7FFB36F20650]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 726
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r8,23CCDF03060
       mov       r8,[r8]
       mov       rdx,23CADF011A0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,23CCDF03060
       mov       rbp,[rax]
       test      edi,edi
       jle       short M02_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
M02_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rcx,rax
       test      rbp,rbp
       je        short M02_L01
       cmp       dword ptr [rbp+8],0
       ja        short M02_L02
M02_L01:
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbp
M02_L03:
       mov       rdx,23CCDF03450
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L04:
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37001308
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB37001358
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 229
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB3700DA40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB3700DB08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB3700DAD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+78],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L00
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
M04_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37002420
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M04_L02:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdx,[rsp+78]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbp,[rsp+78]
       mov       r11,[rbx+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB370060E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,23CCDF03060
       mov       r9,[r9]
       mov       r8,23CDDF03760
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M04_L09
M04_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M04_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rdi
       mov       rdx,7FFB370064E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M04_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M04_L05
M04_L09:
       mov       eax,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.PersonProperCollection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newPeople = people.Shuffle(10).ToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(newPeople);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FEC4E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L11
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFB36FEC538
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB36FEC4F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,rdi
       mov       rdx,[rbx+88]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFB36FEC550
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M01_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFB36FEC560
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFB36FEC4F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+70]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFB36FEC508
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0648
       call      qword ptr [7FFB36F00648]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB36FEC520
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L19
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0648
       call      qword ptr [7FFB36F00648]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0650
       call      qword ptr [7FFB36F00650]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0650
       call      qword ptr [7FFB36F00650]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 726
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r8,24663DC3060
       mov       r8,[r8]
       mov       rdx,24643DC11A0
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,24663DC3060
       mov       rbp,[rax]
       test      edi,edi
       jle       short M02_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
M02_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rcx,rax
       test      rbp,rbp
       je        short M02_L01
       cmp       dword ptr [rbp+8],0
       ja        short M02_L02
M02_L01:
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbp
M02_L03:
       mov       rdx,24663DC3450
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L04:
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1128
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1178
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 229
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FED860
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FED928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FED8F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+78],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L00
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
M04_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FE2240
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M04_L02:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdx,[rsp+78]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbp,[rsp+78]
       mov       r11,[rbx+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB36FE5F08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,24663DC3060
       mov       r9,[r9]
       mov       r8,24663DCA620
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M04_L09
M04_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M04_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rdi
       mov       rdx,7FFB36FE6308
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M04_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M04_L05
M04_L09:
       mov       eax,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.PersonProperCollection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newPeople = people.Shuffle(10).ToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(newPeople);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB3700C2B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L11
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFB3700C308
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB3700C2C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,rdi
       mov       rdx,[rbx+88]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFB3700C320
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M01_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFB3700C330
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFB3700C2C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+70]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFB3700C2D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B10648
       call      qword ptr [7FFB36F20648]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB3700C2F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L19
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B10648
       call      qword ptr [7FFB36F20648]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B10650
       call      qword ptr [7FFB36F20650]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B10650
       call      qword ptr [7FFB36F20650]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 726
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r8,2ABBE271048
       mov       r8,[r8]
       mov       rdx,2ABAE29D000
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,2ABBE271048
       mov       rbp,[rax]
       test      edi,edi
       jle       short M02_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
M02_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rcx,rax
       test      rbp,rbp
       je        short M02_L01
       cmp       dword ptr [rbp+8],0
       ja        short M02_L02
M02_L01:
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbp
M02_L03:
       mov       rdx,2ABBE271438
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L04:
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37000EF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB37000F48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 229
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB3700D630
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB3700D6F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB3700D6C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+78],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L00
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
M04_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37002010
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M04_L02:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdx,[rsp+78]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbp,[rsp+78]
       mov       r11,[rbx+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB37005CD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,2ABBE271048
       mov       r9,[r9]
       mov       r8,2AB8E273760
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M04_L09
M04_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M04_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rdi
       mov       rdx,7FFB370060D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M04_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M04_L05
M04_L09:
       mov       eax,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.PersonProperCollection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newPeople = people.Shuffle(10).ToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(newPeople);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB3700C440
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L11
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFB3700C490
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB3700C450
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,rdi
       mov       rdx,[rbx+88]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFB3700C4A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M01_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFB3700C4B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFB3700C450
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+70]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFB3700C460
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B10648
       call      qword ptr [7FFB36F20648]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB3700C478
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L19
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B10648
       call      qword ptr [7FFB36F20648]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B10650
       call      qword ptr [7FFB36F20650]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B10650
       call      qword ptr [7FFB36F20650]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 726
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r8,23908A01048
       mov       r8,[r8]
       mov       rdx,238F8A09158
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,23908A01048
       mov       rbp,[rax]
       test      edi,edi
       jle       short M02_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
M02_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rcx,rax
       test      rbp,rbp
       je        short M02_L01
       cmp       dword ptr [rbp+8],0
       ja        short M02_L02
M02_L01:
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbp
M02_L03:
       mov       rdx,23908A01438
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L04:
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37001080
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB370010D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 229
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB3700D7B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB3700D880
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB3700D850
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+78],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L00
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
M04_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37002198
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M04_L02:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdx,[rsp+78]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbp,[rsp+78]
       mov       r11,[rbx+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB37005E60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,23908A01048
       mov       r9,[r9]
       mov       r8,238E8A061B8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M04_L09
M04_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M04_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rdi
       mov       rdx,7FFB37006260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M04_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M04_L05
M04_L09:
       mov       eax,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.PersonProperCollection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newPeople = people.Shuffle(10).ToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(newPeople);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 119
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FFC2D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L11
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFB36FFC328
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB36FFC2E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,rdi
       mov       rdx,[rbx+88]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFB36FFC340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M01_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFB36FFC350
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFB36FFC2E8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+70]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFB36FFC2F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B00648
       call      qword ptr [7FFB36F10648]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB36FFC310
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L19
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B00648
       call      qword ptr [7FFB36F10648]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B00650
       call      qword ptr [7FFB36F10650]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B00650
       call      qword ptr [7FFB36F10650]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 726
```
```assembly
; dotNetTips.Spargine.Extensions.EnumerableExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rbx,rdx
       mov       edi,r8d
       mov       r8,20D73C23060
       mov       r8,[r8]
       mov       rdx,20D73C25E40
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,20D73C23060
       mov       rbp,[rax]
       test      edi,edi
       jle       short M02_L00
       cmp       edi,7FFFFFFF
       setle     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
M02_L00:
       call      dotNetTips.Spargine.Core.Properties.Resources.get_NumberNotInRange()
       mov       rcx,rax
       test      rbp,rbp
       je        short M02_L01
       cmp       dword ptr [rbp+8],0
       ja        short M02_L02
M02_L01:
       jmp       short M02_L03
M02_L02:
       mov       rcx,rbp
M02_L03:
       mov       rdx,20D73C23450
       mov       rdx,[rdx]
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
M02_L04:
       mov       rbp,[rsi+10]
       mov       rcx,[rbp+10]
       test      rcx,rcx
       je        short M02_L05
       jmp       short M02_L06
M02_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0F18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L06:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.Shuffle[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rbx,rax
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M02_L07
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0F68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L08:
       mov       rdx,rbx
       mov       r8d,edi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       near ptr System.Linq.Enumerable.Take[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
; Total bytes of code 229
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FFD650
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FFD718
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FFD6E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+78],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L00
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
M04_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FF2030
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M04_L02:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdx,[rsp+78]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbp,[rsp+78]
       mov       r11,[rbx+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB36FF5CF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,20D73C23060
       mov       r9,[r9]
       mov       r8,20D73C25BB0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M04_L09
M04_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M04_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rdi
       mov       rdx,7FFB36FF60F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M04_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M04_L05
M04_L09:
       mov       eax,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.PersonProperCollection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newPeople = new List<PersonProper>(base.PersonProperCollection).Take(10).ToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(newPeople);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+98]
       mov       rcx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.TakeIterator(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FEA440
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L11
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFB36FEA490
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB36FEA450
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,rdi
       mov       rdx,[rbx+88]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFB36FEA4A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M01_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFB36FEA4B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFB36FEA450
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+70]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFB36FEA460
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0610
       call      qword ptr [7FFB36F00610]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB36FEA478
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L19
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0610
       call      qword ptr [7FFB36F00610]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0618
       call      qword ptr [7FFB36F00618]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0618
       call      qword ptr [7FFB36F00618]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 726
```
```assembly
; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L00
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FEAEC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M02_L11
       mov       rbp,[rsi+10]
       mov       rcx,rbp
       mov       r14,[rcx+8]
       cmp       r14,38
       jle       short M02_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB150
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       jne       near ptr M02_L07
       cmp       r14,48
       jle       short M02_L04
       mov       rcx,[rbp+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB560
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7FFB36BE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L06
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+28],eax
       dec       ebx
       mov       [r14+2C],ebx
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       mov       rcx,rbp
       cmp       r14,40
       jle       short M02_L08
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB4A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB36BE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L10
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L10:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+20],eax
       lea       eax,[rbx+0FFFF]
       mov       [rsi+24],eax
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L11:
       mov       rcx,[rsi+10]
       mov       r14,rcx
       mov       rcx,r14
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M02_L12
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB138
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rbp
       mov       edx,ebx
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 500
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB620
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB6E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB6B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+78],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L00
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
M04_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0830
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M04_L02:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdx,[rsp+78]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbp,[rsp+78]
       mov       r11,[rbx+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB36FE44F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1DC2F941048
       mov       r9,[r9]
       mov       r8,1DBFF941748
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M04_L09
M04_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M04_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rdi
       mov       rdx,7FFB36FE48F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M04_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M04_L05
M04_L09:
       mov       eax,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.PersonProperCollection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newPeople = new List<PersonProper>(base.PersonProperCollection).Take(10).ToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(newPeople);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+98]
       mov       rcx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.TakeIterator(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FEA4A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L11
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFB36FEA4F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB36FEA4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,rdi
       mov       rdx,[rbx+88]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFB36FEA508
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M01_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFB36FEA518
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFB36FEA4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+70]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFB36FEA4C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0610
       call      qword ptr [7FFB36F00610]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB36FEA4D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L19
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0610
       call      qword ptr [7FFB36F00610]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0618
       call      qword ptr [7FFB36F00618]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0618
       call      qword ptr [7FFB36F00618]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 726
```
```assembly
; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L00
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FEAE18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M02_L11
       mov       rbp,[rsi+10]
       mov       rcx,rbp
       mov       r14,[rcx+8]
       cmp       r14,38
       jle       short M02_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB0A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       jne       near ptr M02_L07
       cmp       r14,48
       jle       short M02_L04
       mov       rcx,[rbp+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB4B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7FFB36BE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L06
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+28],eax
       dec       ebx
       mov       [r14+2C],ebx
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       mov       rcx,rbp
       cmp       r14,40
       jle       short M02_L08
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB3F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB36BE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L10
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L10:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+20],eax
       lea       eax,[rbx+0FFFF]
       mov       [rsi+24],eax
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L11:
       mov       rcx,[rsi+10]
       mov       r14,rcx
       mov       rcx,r14
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M02_L12
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rbp
       mov       edx,ebx
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 500
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB5C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB690
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB660
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+78],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L00
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
M04_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0830
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M04_L02:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdx,[rsp+78]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbp,[rsp+78]
       mov       r11,[rbx+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB36FE44F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1BDBE943060
       mov       r9,[r9]
       mov       r8,1BDBE94DB68
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M04_L09
M04_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M04_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rdi
       mov       rdx,7FFB36FE48F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M04_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M04_L05
M04_L09:
       mov       eax,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.PersonProperCollection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newPeople = new List<PersonProper>(base.PersonProperCollection).Take(10).ToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(newPeople);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+98]
       mov       rcx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.TakeIterator(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FEA4A0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L11
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFB36FEA4F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB36FEA4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,rdi
       mov       rdx,[rbx+88]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFB36FEA508
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M01_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFB36FEA518
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFB36FEA4B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+70]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFB36FEA4C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0610
       call      qword ptr [7FFB36F00610]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB36FEA4D8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L19
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0610
       call      qword ptr [7FFB36F00610]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0618
       call      qword ptr [7FFB36F00618]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0618
       call      qword ptr [7FFB36F00618]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 726
```
```assembly
; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L00
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FEAE18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M02_L11
       mov       rbp,[rsi+10]
       mov       rcx,rbp
       mov       r14,[rcx+8]
       cmp       r14,38
       jle       short M02_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB0A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       jne       near ptr M02_L07
       cmp       r14,48
       jle       short M02_L04
       mov       rcx,[rbp+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB4B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7FFB36BE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L06
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+28],eax
       dec       ebx
       mov       [r14+2C],ebx
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       mov       rcx,rbp
       cmp       r14,40
       jle       short M02_L08
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB3F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB36BE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L10
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L10:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+20],eax
       lea       eax,[rbx+0FFFF]
       mov       [rsi+24],eax
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L11:
       mov       rcx,[rsi+10]
       mov       r14,rcx
       mov       rcx,r14
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M02_L12
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB090
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rbp
       mov       edx,ebx
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 500
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB5C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB690
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB660
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+78],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L00
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
M04_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0830
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M04_L02:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdx,[rsp+78]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbp,[rsp+78]
       mov       r11,[rbx+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB36FE44F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1ABE9573060
       mov       r9,[r9]
       mov       r8,1AC09571748
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M04_L09
M04_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M04_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rdi
       mov       rdx,7FFB36FE48F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M04_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M04_L05
M04_L09:
       mov       eax,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.PersonProperCollection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newPeople = new List<PersonProper>(base.PersonProperCollection).Take(10).ToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(newPeople);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+98]
       mov       rcx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.TakeIterator(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FEA730
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L11
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFB36FEA780
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB36FEA740
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,rdi
       mov       rdx,[rbx+88]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFB36FEA798
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M01_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFB36FEA7A8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFB36FEA740
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+70]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFB36FEA750
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0610
       call      qword ptr [7FFB36F00610]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB36FEA768
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L19
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0610
       call      qword ptr [7FFB36F00610]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0618
       call      qword ptr [7FFB36F00618]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0618
       call      qword ptr [7FFB36F00618]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 726
```
```assembly
; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L00
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB0A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M02_L11
       mov       rbp,[rsi+10]
       mov       rcx,rbp
       mov       r14,[rcx+8]
       cmp       r14,38
       jle       short M02_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB338
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       jne       near ptr M02_L07
       cmp       r14,48
       jle       short M02_L04
       mov       rcx,[rbp+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB748
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7FFB36BE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L06
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+28],eax
       dec       ebx
       mov       [r14+2C],ebx
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       mov       rcx,rbp
       cmp       r14,40
       jle       short M02_L08
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB688
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB36BE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L10
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L10:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+20],eax
       lea       eax,[rbx+0FFFF]
       mov       [rsi+24],eax
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L11:
       mov       rcx,[rsi+10]
       mov       r14,rcx
       mov       rcx,r14
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M02_L12
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB320
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rbp
       mov       edx,ebx
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 500
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB858
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB920
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB8F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+78],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L00
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
M04_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M04_L02:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdx,[rsp+78]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbp,[rsp+78]
       mov       r11,[rbx+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB36FE4788
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1EB2E693060
       mov       r9,[r9]
       mov       r8,1EB1E6961B8
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M04_L09
M04_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M04_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rdi
       mov       rdx,7FFB36FE4B88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M04_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M04_L05
M04_L09:
       mov       eax,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.PersonProperCollection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newPeople = new List<PersonProper>(base.PersonProperCollection).Take(10).ToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(newPeople);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+98]
       mov       rcx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.TakeIterator(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB3701A910
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L11
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFB3701A960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB3701A920
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,rdi
       mov       rdx,[rbx+88]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFB3701A978
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M01_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFB3701A988
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFB3701A920
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+70]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFB3701A930
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B20610
       call      qword ptr [7FFB36F30610]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB3701A948
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L19
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B20610
       call      qword ptr [7FFB36F30610]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B20618
       call      qword ptr [7FFB36F30618]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B20618
       call      qword ptr [7FFB36F30618]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 726
```
```assembly
; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L00
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB3701B288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M02_L11
       mov       rbp,[rsi+10]
       mov       rcx,rbp
       mov       r14,[rcx+8]
       cmp       r14,38
       jle       short M02_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB3701B518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       jne       near ptr M02_L07
       cmp       r14,48
       jle       short M02_L04
       mov       rcx,[rbp+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB3701B928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7FFB36C10020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L06
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+28],eax
       dec       ebx
       mov       [r14+2C],ebx
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       mov       rcx,rbp
       cmp       r14,40
       jle       short M02_L08
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB3701B868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB36C10020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L10
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L10:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+20],eax
       lea       eax,[rbx+0FFFF]
       mov       [rsi+24],eax
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L11:
       mov       rcx,[rsi+10]
       mov       r14,rcx
       mov       rcx,r14
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M02_L12
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFB3701B500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rbp
       mov       edx,ebx
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 500
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB3701BA38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB3701BB00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB3701BAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+78],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L00
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
M04_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37010CA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M04_L02:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdx,[rsp+78]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbp,[rsp+78]
       mov       r11,[rbx+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB37014968
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,2AF3BAD3060
       mov       r9,[r9]
       mov       r8,2AF4BAD1748
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M04_L09
M04_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M04_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rdi
       mov       rdx,7FFB37014D68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M04_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M04_L05
M04_L09:
       mov       eax,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.PersonProperCollection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newPeople = new List<PersonProper>(base.PersonProperCollection).Take(10).ToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(newPeople);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+98]
       mov       rcx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.TakeIterator(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FEA910
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L11
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFB36FEA960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB36FEA920
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,rdi
       mov       rdx,[rbx+88]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFB36FEA978
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M01_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFB36FEA988
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFB36FEA920
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+70]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFB36FEA930
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0610
       call      qword ptr [7FFB36F00610]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB36FEA948
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L19
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0610
       call      qword ptr [7FFB36F00610]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0618
       call      qword ptr [7FFB36F00618]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0618
       call      qword ptr [7FFB36F00618]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 726
```
```assembly
; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L00
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M02_L11
       mov       rbp,[rsi+10]
       mov       rcx,rbp
       mov       r14,[rcx+8]
       cmp       r14,38
       jle       short M02_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       jne       near ptr M02_L07
       cmp       r14,48
       jle       short M02_L04
       mov       rcx,[rbp+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7FFB36BE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L06
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+28],eax
       dec       ebx
       mov       [r14+2C],ebx
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       mov       rcx,rbp
       cmp       r14,40
       jle       short M02_L08
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB36BE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L10
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L10:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+20],eax
       lea       eax,[rbx+0FFFF]
       mov       [rsi+24],eax
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L11:
       mov       rcx,[rsi+10]
       mov       r14,rcx
       mov       rcx,r14
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M02_L12
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rbp
       mov       edx,ebx
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 500
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FEBA38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FEBB00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FEBAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+78],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L00
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
M04_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0CA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M04_L02:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdx,[rsp+78]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbp,[rsp+78]
       mov       r11,[rbx+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB36FE4968
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,16D981C1048
       mov       r9,[r9]
       mov       r8,16D981C3B98
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M04_L09
M04_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M04_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rdi
       mov       rdx,7FFB36FE4D68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M04_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M04_L05
M04_L09:
       mov       eax,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.PersonProperCollection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newPeople = new List<PersonProper>(base.PersonProperCollection).Take(10).ToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(newPeople);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+98]
       mov       rcx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.TakeIterator(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FEA910
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L11
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFB36FEA960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB36FEA920
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,rdi
       mov       rdx,[rbx+88]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFB36FEA978
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M01_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFB36FEA988
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFB36FEA920
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+70]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFB36FEA930
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0610
       call      qword ptr [7FFB36F00610]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB36FEA948
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L19
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0610
       call      qword ptr [7FFB36F00610]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0618
       call      qword ptr [7FFB36F00618]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0618
       call      qword ptr [7FFB36F00618]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 726
```
```assembly
; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L00
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB1E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M02_L11
       mov       rbp,[rsi+10]
       mov       rcx,rbp
       mov       r14,[rcx+8]
       cmp       r14,38
       jle       short M02_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB478
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       jne       near ptr M02_L07
       cmp       r14,48
       jle       short M02_L04
       mov       rcx,[rbp+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB888
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7FFB36BE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L06
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+28],eax
       dec       ebx
       mov       [r14+2C],ebx
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       mov       rcx,rbp
       cmp       r14,40
       jle       short M02_L08
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB7C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB36BE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L10
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L10:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+20],eax
       lea       eax,[rbx+0FFFF]
       mov       [rsi+24],eax
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L11:
       mov       rcx,[rsi+10]
       mov       r14,rcx
       mov       rcx,r14
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M02_L12
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rbp
       mov       edx,ebx
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 500
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB998
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FEBA60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FEBA30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+78],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L00
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
M04_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0CA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M04_L02:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdx,[rsp+78]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbp,[rsp+78]
       mov       r11,[rbx+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB36FE4968
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,19156521048
       mov       r9,[r9]
       mov       r8,191465281D0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M04_L09
M04_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M04_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rdi
       mov       rdx,7FFB36FE4D68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M04_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M04_L05
M04_L09:
       mov       eax,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.PersonProperCollection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newPeople = new List<PersonProper>(base.PersonProperCollection).Take(10).ToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(newPeople);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+98]
       mov       rcx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.TakeIterator(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB36FEA910
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L11
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFB36FEA960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB36FEA920
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,rdi
       mov       rdx,[rbx+88]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFB36FEA978
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M01_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFB36FEA988
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFB36FEA920
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+70]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFB36FEA930
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0610
       call      qword ptr [7FFB36F00610]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB36FEA948
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L19
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0610
       call      qword ptr [7FFB36F00610]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0618
       call      qword ptr [7FFB36F00618]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36AF0618
       call      qword ptr [7FFB36F00618]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 726
```
```assembly
; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L00
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M02_L11
       mov       rbp,[rsi+10]
       mov       rcx,rbp
       mov       r14,[rcx+8]
       cmp       r14,38
       jle       short M02_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       jne       near ptr M02_L07
       cmp       r14,48
       jle       short M02_L04
       mov       rcx,[rbp+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7FFB36BE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L06
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+28],eax
       dec       ebx
       mov       [r14+2C],ebx
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       mov       rcx,rbp
       cmp       r14,40
       jle       short M02_L08
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB36BE0020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L10
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L10:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+20],eax
       lea       eax,[rbx+0FFFF]
       mov       [rsi+24],eax
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L11:
       mov       rcx,[rsi+10]
       mov       r14,rcx
       mov       rcx,r14
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M02_L12
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFB36FEB500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rbp
       mov       edx,ebx
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 500
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FEBA38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FEBB00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FEBAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+78],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L00
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
M04_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0CA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M04_L02:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdx,[rsp+78]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbp,[rsp+78]
       mov       r11,[rbx+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB36FE4968
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,17F0B3F1048
       mov       r9,[r9]
       mov       r8,17F1B3FB718
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M04_L09
M04_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M04_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rdi
       mov       rdx,7FFB36FE4D68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M04_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M04_L05
M04_L09:
       mov       eax,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.PersonProperCollection);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var newPeople = new List<PersonProper>(base.PersonProperCollection).Take(10).ToArray();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(newPeople);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+98]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+98]
       mov       rcx,rbx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rdx,rbx
       mov       rcx,offset MD_System.Linq.Enumerable.TakeIterator(System.Collections.Generic.IEnumerable`1<!!0>, Int32)
       mov       r8d,0A
       call      System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       mov       rdx,rax
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists(System.Collections.Generic.ICollection`1<!!0>, !!0[])
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 154
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,48
       lea       rbp,[rsp+70]
       mov       [rbp+0FFB0],rsp
       mov       [rbp+0FFD0],rcx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       test      rsi,rsi
       je        near ptr M01_L22
       mov       rcx,[rbp+10]
       mov       rdi,[rcx]
       mov       rcx,rdi
       mov       rdx,[rcx+30]
       mov       rbx,[rdx]
       mov       rdx,[rbx+60]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFB3701A910
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L01:
       mov       rcx,rdx
       mov       rdx,rsi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r14,rax
       test      r14,r14
       je        near ptr M01_L11
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFB3701A960
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFB3701A920
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L05:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L06:
       mov       rcx,rdi
       mov       rdx,[rbx+88]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFB3701A978
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rbp+0FFC8],rax
M01_L08:
       movsxd    rdx,esi
       mov       rcx,[rbp+0FFC8]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdx,[rbp+10]
       lea       rcx,[rdx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[rbp+10]
       mov       r15,[rcx+8]
       mov       rcx,rdi
       mov       r11,[rbx+90]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFB3701A988
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L10:
       mov       rcx,r14
       mov       rdx,r15
       xor       r8d,r8d
       call      qword ptr [r11]
       mov       rcx,[rbp+10]
       mov       [rcx+10],esi
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       rcx,rdi
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFB3701A920
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M01_L13:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rdx,[rax]
       mov       rcx,[rbp+10]
       lea       rcx,[rcx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       mov       r11,[rbx+70]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFB3701A930
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B20610
       call      qword ptr [7FFB36F30610]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB3701A948
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L18:
       mov       rcx,[rbp+0FFC0]
       call      qword ptr [r11]
       mov       r8,rax
       mov       rcx,[rbp+10]
       inc       dword ptr [rcx+14]
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+8]
       mov       rdx,[rbp+10]
       mov       edx,[rdx+10]
       cmp       [rcx+8],edx
       jbe       short M01_L19
       lea       eax,[rdx+1]
       mov       r9,[rbp+10]
       mov       [r9+10],eax
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L20
M01_L19:
       mov       rcx,[rbp+10]
       mov       rdx,r8
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L20:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B20610
       call      qword ptr [7FFB36F30610]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B20618
       call      qword ptr [7FFB36F30618]
       nop
       lea       rsp,[rbp+0FFD8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L22:
       mov       ecx,17
       call      System.ThrowHelper.ThrowArgumentNullException(System.ExceptionArgument)
       int       3
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+70]
       cmp       qword ptr [rbp+0FFC0],0
       je        short M01_L23
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB36B20618
       call      qword ptr [7FFB36F30618]
M01_L23:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 726
```
```assembly
; System.Linq.Enumerable.TakeIterator[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32)
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L00
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB3701B288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbp,rax
       test      rbp,rbp
       jne       near ptr M02_L11
       mov       rbp,[rsi+10]
       mov       rcx,rbp
       mov       r14,[rcx+8]
       cmp       r14,38
       jle       short M02_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB3701B518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       jne       near ptr M02_L07
       cmp       r14,48
       jle       short M02_L04
       mov       rcx,[rbp+48]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB3701B928
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7FFB36C10020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L06
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [r14+10],eax
       lea       rcx,[r14+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [r14+28],eax
       dec       ebx
       mov       [r14+2C],ebx
       mov       rax,r14
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L07:
       mov       rcx,rbp
       cmp       r14,40
       jle       short M02_L08
       mov       rcx,[rcx+40]
       test      rcx,rcx
       je        short M02_L08
       jmp       short M02_L09
M02_L08:
       mov       rcx,rsi
       mov       rdx,7FFB3701B868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB36C10020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L10
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L10:
       cmp       [rcx],ecx
       call      00007FFB96762F50
       mov       [rsi+10],eax
       lea       rcx,[rsi+18]
       mov       rdx,r15
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+20],eax
       lea       eax,[rbx+0FFFF]
       mov       [rsi+24],eax
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
M02_L11:
       mov       rcx,[rsi+10]
       mov       r14,rcx
       mov       rcx,r14
       mov       r14,[rcx+8]
       cmp       r14,30
       jle       short M02_L12
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M02_L12
       jmp       short M02_L13
M02_L12:
       mov       rcx,rsi
       mov       rdx,7FFB3701B500
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L13:
       mov       rcx,rbp
       mov       edx,ebx
       call      qword ptr [r11]
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       ret
; Total bytes of code 500
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB3701BA38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB3701BB00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB3701BAD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon[])
       push      r15
       push      r14
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       [rsp+78],rdx
       mov       rdi,rcx
       mov       rsi,r8
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.DoesNotHaveItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L00
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
M04_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M04_L01
       jmp       short M04_L02
M04_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37010CA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M04_L02:
       mov       rcx,offset MT_System.Boolean
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       lea       rdx,[rsp+78]
       mov       rcx,rbp
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.CreateCollectionIfNull[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon> ByRef)
       mov       [r14+8],al
       mov       rcx,r14
       call      System.Diagnostics.TraceInternal.WriteLine(System.Object)
       mov       rbp,[rsp+78]
       mov       r11,[rbx+18]
       test      r11,r11
       je        short M04_L03
       jmp       short M04_L04
M04_L03:
       mov       rcx,rdi
       mov       rdx,7FFB37014968
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1BC2A2C3060
       mov       r9,[r9]
       mov       r8,1BC0A2C1748
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M04_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M04_L09
M04_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M04_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rdi
       mov       rdx,7FFB37014D68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M04_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M04_L05
M04_L09:
       mov       eax,ebp
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r14
       pop       r15
       ret
; Total bytes of code 350
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.PersonProperArrayFull.Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 104
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1939B281048
       mov       r8,[r8]
       mov       rdx,193BB287C28
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37010C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr dotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 112
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       jne       short M02_L02
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+48]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB371DAEF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFB371DAF08
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L00:
       cmp       [rsi],esi
       mov       r8,1939B283BC0
       mov       r8,[r8]
       mov       r9,1939B281048
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37136B78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,1
       call      qword ptr [7FFB37166080]
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 190
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.PersonProperArrayFull.Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 104
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,25CBB173060
       mov       r8,[r8]
       mov       rdx,25CAB1731B8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0C60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr dotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 112
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       jne       short M02_L02
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+48]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB371C92D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFB371C92E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L00:
       cmp       [rsi],esi
       mov       r8,25CBB1805E8
       mov       r8,[r8]
       mov       r9,25CBB173060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37116B78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,1
       call      qword ptr [7FFB37156080]
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 190
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.PersonProperArrayFull.Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 104
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1F9D22A3060
       mov       r8,[r8]
       mov       rdx,1F9D22A5608
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr dotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 112
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       jne       short M02_L02
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+48]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB371B81D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFB371B81E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L00:
       cmp       [rsi],esi
       mov       r8,1F9B22A61E0
       mov       r8,[r8]
       mov       r9,1F9D22A3060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37106B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,1
       call      qword ptr [7FFB37146080]
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 190
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.PersonProperArrayFull.Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 104
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1B7586E3060
       mov       r8,[r8]
       mov       rdx,1B7586E5608
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37000C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr dotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 112
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       jne       short M02_L02
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+48]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB371D8128
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFB371D8138
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L00:
       cmp       [rsi],esi
       mov       r8,1B7486E61E0
       mov       r8,[r8]
       mov       r9,1B7586E3060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37126B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,1
       call      qword ptr [7FFB37166080]
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 190
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.PersonProperArrayFull.Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 104
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2045CDA3060
       mov       r8,[r8]
       mov       rdx,2043CDA11A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr dotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 112
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       jne       short M02_L02
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+48]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB371C80C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFB371C80D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L00:
       cmp       [rsi],esi
       mov       r8,2044CDA1770
       mov       r8,[r8]
       mov       r9,2045CDA3060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37116B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,1
       call      qword ptr [7FFB37156080]
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 190
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.PersonProperArrayFull.Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 104
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1F386073060
       mov       r8,[r8]
       mov       rdx,1F386075608
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr dotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 112
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       jne       short M02_L02
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+48]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB371B80C0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFB371B80D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L00:
       cmp       [rsi],esi
       mov       r8,1F366071770
       mov       r8,[r8]
       mov       r9,1F386073060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37106B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,1
       call      qword ptr [7FFB37146080]
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 190
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.PersonProperArrayFull.Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 104
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,25131473060
       mov       r8,[r8]
       mov       rdx,25141475C10
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37001070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr dotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 112
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       jne       short M02_L02
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+48]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB371D85E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFB371D85F0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L00:
       cmp       [rsi],esi
       mov       r8,2513147DB90
       mov       r8,[r8]
       mov       r9,25131473060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37126B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,1
       call      qword ptr [7FFB37166080]
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 190
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.PersonProperArrayFull.Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 104
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1F26C331048
       mov       r8,[r8]
       mov       rdx,1F25C3311A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr dotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 112
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       jne       short M02_L02
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+48]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB371C8710
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFB371C8720
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L00:
       cmp       [rsi],esi
       mov       r8,1F26C33BB78
       mov       r8,[r8]
       mov       r9,1F26C331048
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37116B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,1
       call      qword ptr [7FFB37156080]
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 190
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.PersonProperArrayFull.Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 104
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1C1D4C71048
       mov       r8,[r8]
       mov       rdx,1C1E4C711A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateNullParam(System.Object, System.String, System.String)
       mov       rcx,rdi
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.ToJson(System.Object)
       mov       rdi,rax
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF0E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr dotNetTips.Spargine.Extensions.ObjectExtensions.FromJson[[System.__Canon, System.Private.CoreLib]](System.String)
; Total bytes of code 112
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       edi,[rsi+10]
       test      edi,edi
       jne       short M02_L02
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+48]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFB371C8900
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       rdx,rax
M02_L01:
       mov       rcx,rdx
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rax,[rax]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       ebx,edi
       mov       rcx,[rsi]
       mov       rdx,[rcx+30]
       mov       rdx,[rdx]
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFB371C8910
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       [rsp+20],rax
M02_L04:
       movsxd    rdx,ebx
       mov       rcx,[rsp+20]
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rbx,rax
       mov       rcx,[rsi+8]
       mov       r8d,edi
       mov       rdx,rbx
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rbx
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 170
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       sete      al
       movzx     eax,al
       test      eax,eax
       je        short M03_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M03_L00:
       cmp       [rsi],esi
       mov       r8,1C1F4C71770
       mov       r8,[r8]
       mov       r9,1C1D4C71048
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M03_L01
       jmp       short M03_L02
M03_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37116B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rdi
       mov       r8,rbx
       xor       edx,edx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rcx,rsi
       mov       rdx,rdi
       mov       r8d,1
       call      qword ptr [7FFB37166080]
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 190
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1F614763060
       mov       r8,[r8]
       mov       rdx,1F6247661E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB370109F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,1F6247661E0
       mov       r8,[r8]
       mov       r9,1F614763060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37010D28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F36080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,116F2C63060
       mov       r8,[r8]
       mov       rdx,116D2C661E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010BE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,116D2C661E0
       mov       r8,[r8]
       mov       r9,116F2C63060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37010F10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F36080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1D5612D3060
       mov       r8,[r8]
       mov       rdx,1D5512D1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0A58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,1D5512D1770
       mov       r8,[r8]
       mov       r9,1D5612D3060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0D88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F16080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,22C13B43060
       mov       r8,[r8]
       mov       rdx,22C13B4A648
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37000A58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,22C13B4A648
       mov       r8,[r8]
       mov       r9,22C13B43060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37000D88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F26080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,2248C3E3060
       mov       r8,[r8]
       mov       rdx,2249C3EE198
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0C88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,2249C3EE198
       mov       r8,[r8]
       mov       r9,2248C3E3060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0FB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F06080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1EA961D3060
       mov       r8,[r8]
       mov       rdx,1EA761D1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,1EA761D1770
       mov       r8,[r8]
       mov       r9,1EA961D3060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0F18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F16080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1564A3F1048
       mov       r8,[r8]
       mov       rdx,1564A3F3BC0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,1564A3F3BC0
       mov       r8,[r8]
       mov       r9,1564A3F1048
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37011198
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F36080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,18091CE3060
       mov       r8,[r8]
       mov       rdx,180A1CE1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37000E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,180A1CE1770
       mov       r8,[r8]
       mov       r9,18091CE3060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37001198
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F26080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 94
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,25023A23060
       mov       r8,[r8]
       mov       rdx,25013A23788
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE09F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,25013A23788
       mov       r8,[r8]
       mov       r9,25023A23060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0D28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F06080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,266F7151048
       mov       r8,[r8]
       mov       rdx,266D7153788
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L07
M02_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M02_L03
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L04
M02_L03:
       xor       edx,edx
       mov       [rbp+0FFD0],rdx
       mov       rdx,[rbp+18]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFD0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp+0FFD0]
       mov       [rbp+0FFC8],rdx
M02_L04:
       mov       rdx,[rbp+0FFC8]
       mov       [rbp+0FFF0],rdx
       cmp       qword ptr [rbp+20],0
       jne       short M02_L05
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFB8],rdx
       jmp       short M02_L06
M02_L05:
       xor       edx,edx
       mov       [rbp+0FFC0],rdx
       mov       rdx,[rbp+20]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFC0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp+0FFC0]
       mov       [rbp+0FFB8],rcx
M02_L06:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFE8],rcx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp+0FFB4],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       cmp       eax,[rbp+0FFB4]
       sete      cl
       movzx     ecx,cl
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       mov       [rbp+0FFAC],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       cmp       eax,[rbp+0FFAC]
       sete      al
       movzx     eax,al
       and       eax,[rbp+0FFB0]
       test      eax,eax
       jne       short M02_L08
M02_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L08:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFDC],ecx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFDC]
       cmp       edx,[rcx+8]
       jae       short M02_L11
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+0FFA0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFDC]
       cmp       eax,[rdx+8]
       jae       short M02_L11
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFA0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFDC]
       inc       eax
       mov       [rbp+0FFDC],eax
M02_L10:
       mov       ecx,[rbp+0FFDC]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M02_L09
       mov       eax,[rbp+0FFFC]
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 465
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1626AA31048
       mov       r8,[r8]
       mov       rdx,1625AA401B0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L07
M02_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M02_L03
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L04
M02_L03:
       xor       edx,edx
       mov       [rbp+0FFD0],rdx
       mov       rdx,[rbp+18]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFD0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp+0FFD0]
       mov       [rbp+0FFC8],rdx
M02_L04:
       mov       rdx,[rbp+0FFC8]
       mov       [rbp+0FFF0],rdx
       cmp       qword ptr [rbp+20],0
       jne       short M02_L05
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFB8],rdx
       jmp       short M02_L06
M02_L05:
       xor       edx,edx
       mov       [rbp+0FFC0],rdx
       mov       rdx,[rbp+20]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFC0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp+0FFC0]
       mov       [rbp+0FFB8],rcx
M02_L06:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFE8],rcx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp+0FFB4],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       cmp       eax,[rbp+0FFB4]
       sete      cl
       movzx     ecx,cl
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       mov       [rbp+0FFAC],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       cmp       eax,[rbp+0FFAC]
       sete      al
       movzx     eax,al
       and       eax,[rbp+0FFB0]
       test      eax,eax
       jne       short M02_L08
M02_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L08:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFDC],ecx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFDC]
       cmp       edx,[rcx+8]
       jae       short M02_L11
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+0FFA0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFDC]
       cmp       eax,[rdx+8]
       jae       short M02_L11
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFA0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFDC]
       inc       eax
       mov       [rbp+0FFDC],eax
M02_L10:
       mov       ecx,[rbp+0FFDC]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M02_L09
       mov       eax,[rbp+0FFFC]
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 465
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,2C4C85B3060
       mov       r8,[r8]
       mov       rdx,2C4E85B9728
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010B78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L07
M02_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M02_L03
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L04
M02_L03:
       xor       edx,edx
       mov       [rbp+0FFD0],rdx
       mov       rdx,[rbp+18]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFD0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp+0FFD0]
       mov       [rbp+0FFC8],rdx
M02_L04:
       mov       rdx,[rbp+0FFC8]
       mov       [rbp+0FFF0],rdx
       cmp       qword ptr [rbp+20],0
       jne       short M02_L05
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFB8],rdx
       jmp       short M02_L06
M02_L05:
       xor       edx,edx
       mov       [rbp+0FFC0],rdx
       mov       rdx,[rbp+20]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFC0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp+0FFC0]
       mov       [rbp+0FFB8],rcx
M02_L06:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFE8],rcx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp+0FFB4],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       cmp       eax,[rbp+0FFB4]
       sete      cl
       movzx     ecx,cl
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       mov       [rbp+0FFAC],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       cmp       eax,[rbp+0FFAC]
       sete      al
       movzx     eax,al
       and       eax,[rbp+0FFB0]
       test      eax,eax
       jne       short M02_L08
M02_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L08:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFDC],ecx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFDC]
       cmp       edx,[rcx+8]
       jae       short M02_L11
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+0FFA0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFDC]
       cmp       eax,[rdx+8]
       jae       short M02_L11
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFA0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFDC]
       inc       eax
       mov       [rbp+0FFDC],eax
M02_L10:
       mov       ecx,[rbp+0FFDC]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M02_L09
       mov       eax,[rbp+0FFFC]
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 465
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,2167D743060
       mov       r8,[r8]
       mov       rdx,2168D741770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37000A08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L07
M02_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M02_L03
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L04
M02_L03:
       xor       edx,edx
       mov       [rbp+0FFD0],rdx
       mov       rdx,[rbp+18]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFD0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp+0FFD0]
       mov       [rbp+0FFC8],rdx
M02_L04:
       mov       rdx,[rbp+0FFC8]
       mov       [rbp+0FFF0],rdx
       cmp       qword ptr [rbp+20],0
       jne       short M02_L05
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFB8],rdx
       jmp       short M02_L06
M02_L05:
       xor       edx,edx
       mov       [rbp+0FFC0],rdx
       mov       rdx,[rbp+20]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFC0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp+0FFC0]
       mov       [rbp+0FFB8],rcx
M02_L06:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFE8],rcx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp+0FFB4],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       cmp       eax,[rbp+0FFB4]
       sete      cl
       movzx     ecx,cl
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       mov       [rbp+0FFAC],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       cmp       eax,[rbp+0FFAC]
       sete      al
       movzx     eax,al
       and       eax,[rbp+0FFB0]
       test      eax,eax
       jne       short M02_L08
M02_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L08:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFDC],ecx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFDC]
       cmp       edx,[rcx+8]
       jae       short M02_L11
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+0FFA0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFDC]
       cmp       eax,[rdx+8]
       jae       short M02_L11
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFA0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFDC]
       inc       eax
       mov       [rbp+0FFDC],eax
M02_L10:
       mov       ecx,[rbp+0FFDC]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M02_L09
       mov       eax,[rbp+0FFFC]
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 465
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1E354BB1048
       mov       r8,[r8]
       mov       rdx,1E344BB9728
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FD0DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L07
M02_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M02_L03
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L04
M02_L03:
       xor       edx,edx
       mov       [rbp+0FFD0],rdx
       mov       rdx,[rbp+18]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFD0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp+0FFD0]
       mov       [rbp+0FFC8],rdx
M02_L04:
       mov       rdx,[rbp+0FFC8]
       mov       [rbp+0FFF0],rdx
       cmp       qword ptr [rbp+20],0
       jne       short M02_L05
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFB8],rdx
       jmp       short M02_L06
M02_L05:
       xor       edx,edx
       mov       [rbp+0FFC0],rdx
       mov       rdx,[rbp+20]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFC0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp+0FFC0]
       mov       [rbp+0FFB8],rcx
M02_L06:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFE8],rcx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp+0FFB4],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       cmp       eax,[rbp+0FFB4]
       sete      cl
       movzx     ecx,cl
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       mov       [rbp+0FFAC],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       cmp       eax,[rbp+0FFAC]
       sete      al
       movzx     eax,al
       and       eax,[rbp+0FFB0]
       test      eax,eax
       jne       short M02_L08
M02_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L08:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFDC],ecx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFDC]
       cmp       edx,[rcx+8]
       jae       short M02_L11
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+0FFA0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFDC]
       cmp       eax,[rdx+8]
       jae       short M02_L11
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFA0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFDC]
       inc       eax
       mov       [rbp+0FFDC],eax
M02_L10:
       mov       ecx,[rbp+0FFDC]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M02_L09
       mov       eax,[rbp+0FFFC]
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 465
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1F2948D3060
       mov       r8,[r8]
       mov       rdx,1F2C48E01B0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L07
M02_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M02_L03
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L04
M02_L03:
       xor       edx,edx
       mov       [rbp+0FFD0],rdx
       mov       rdx,[rbp+18]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFD0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp+0FFD0]
       mov       [rbp+0FFC8],rdx
M02_L04:
       mov       rdx,[rbp+0FFC8]
       mov       [rbp+0FFF0],rdx
       cmp       qword ptr [rbp+20],0
       jne       short M02_L05
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFB8],rdx
       jmp       short M02_L06
M02_L05:
       xor       edx,edx
       mov       [rbp+0FFC0],rdx
       mov       rdx,[rbp+20]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFC0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp+0FFC0]
       mov       [rbp+0FFB8],rcx
M02_L06:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFE8],rcx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp+0FFB4],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       cmp       eax,[rbp+0FFB4]
       sete      cl
       movzx     ecx,cl
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       mov       [rbp+0FFAC],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       cmp       eax,[rbp+0FFAC]
       sete      al
       movzx     eax,al
       and       eax,[rbp+0FFB0]
       test      eax,eax
       jne       short M02_L08
M02_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L08:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFDC],ecx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFDC]
       cmp       edx,[rcx+8]
       jae       short M02_L11
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+0FFA0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFDC]
       cmp       eax,[rdx+8]
       jae       short M02_L11
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFA0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFDC]
       inc       eax
       mov       [rbp+0FFDC],eax
M02_L10:
       mov       ecx,[rbp+0FFDC]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M02_L09
       mov       eax,[rbp+0FFFC]
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 465
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,16B78D33060
       mov       r8,[r8]
       mov       rdx,16B68D31770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0988
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L07
M02_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M02_L03
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L04
M02_L03:
       xor       edx,edx
       mov       [rbp+0FFD0],rdx
       mov       rdx,[rbp+18]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFD0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp+0FFD0]
       mov       [rbp+0FFC8],rdx
M02_L04:
       mov       rdx,[rbp+0FFC8]
       mov       [rbp+0FFF0],rdx
       cmp       qword ptr [rbp+20],0
       jne       short M02_L05
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFB8],rdx
       jmp       short M02_L06
M02_L05:
       xor       edx,edx
       mov       [rbp+0FFC0],rdx
       mov       rdx,[rbp+20]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFC0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp+0FFC0]
       mov       [rbp+0FFB8],rcx
M02_L06:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFE8],rcx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp+0FFB4],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       cmp       eax,[rbp+0FFB4]
       sete      cl
       movzx     ecx,cl
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       mov       [rbp+0FFAC],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       cmp       eax,[rbp+0FFAC]
       sete      al
       movzx     eax,al
       and       eax,[rbp+0FFB0]
       test      eax,eax
       jne       short M02_L08
M02_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L08:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFDC],ecx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFDC]
       cmp       edx,[rcx+8]
       jae       short M02_L11
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+0FFA0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFDC]
       cmp       eax,[rdx+8]
       jae       short M02_L11
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFA0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFDC]
       inc       eax
       mov       [rbp+0FFDC],eax
M02_L10:
       mov       ecx,[rbp+0FFDC]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M02_L09
       mov       eax,[rbp+0FFFC]
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 465
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,2191E471048
       mov       r8,[r8]
       mov       rdx,2191E47BB78
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L07
M02_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M02_L03
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L04
M02_L03:
       xor       edx,edx
       mov       [rbp+0FFD0],rdx
       mov       rdx,[rbp+18]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFD0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp+0FFD0]
       mov       [rbp+0FFC8],rdx
M02_L04:
       mov       rdx,[rbp+0FFC8]
       mov       [rbp+0FFF0],rdx
       cmp       qword ptr [rbp+20],0
       jne       short M02_L05
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFB8],rdx
       jmp       short M02_L06
M02_L05:
       xor       edx,edx
       mov       [rbp+0FFC0],rdx
       mov       rdx,[rbp+20]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFC0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp+0FFC0]
       mov       [rbp+0FFB8],rcx
M02_L06:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFE8],rcx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp+0FFB4],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       cmp       eax,[rbp+0FFB4]
       sete      cl
       movzx     ecx,cl
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       mov       [rbp+0FFAC],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       cmp       eax,[rbp+0FFAC]
       sete      al
       movzx     eax,al
       and       eax,[rbp+0FFB0]
       test      eax,eax
       jne       short M02_L08
M02_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L08:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFDC],ecx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFDC]
       cmp       edx,[rcx+8]
       jae       short M02_L11
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+0FFA0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFDC]
       cmp       eax,[rdx+8]
       jae       short M02_L11
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFA0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFDC]
       inc       eax
       mov       [rbp+0FFDC],eax
M02_L10:
       mov       ecx,[rbp+0FFDC]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M02_L09
       mov       eax,[rbp+0FFFC]
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 465
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AreEqual01()
; 			var people1 = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var people2 = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people1.AreEqual(people2);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 91
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1B018543060
       mov       r8,[r8]
       mov       rdx,1B028543788
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AreEqual[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L01
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L01
       mov       eax,1
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L01:
       mov       rcx,[rbp+18]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       je        short M02_L02
       mov       rcx,[rbp+20]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.Validate.TryValidateNull(System.Object, Boolean)
       test      eax,eax
       jne       near ptr M02_L07
M02_L02:
       cmp       qword ptr [rbp+18],0
       jne       short M02_L03
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFC8],rdx
       jmp       short M02_L04
M02_L03:
       xor       edx,edx
       mov       [rbp+0FFD0],rdx
       mov       rdx,[rbp+18]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFD0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rdx,[rbp+0FFD0]
       mov       [rbp+0FFC8],rdx
M02_L04:
       mov       rdx,[rbp+0FFC8]
       mov       [rbp+0FFF0],rdx
       cmp       qword ptr [rbp+20],0
       jne       short M02_L05
       xor       edx,edx
       mov       [rbp+0FFE0],rdx
       mov       rdx,[rbp+0FFE0]
       mov       [rbp+0FFB8],rdx
       jmp       short M02_L06
M02_L05:
       xor       edx,edx
       mov       [rbp+0FFC0],rdx
       mov       rdx,[rbp+20]
       mov       edx,[rdx+8]
       lea       rcx,[rbp+0FFC0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp+0FFC0]
       mov       [rbp+0FFB8],rcx
M02_L06:
       mov       rcx,[rbp+0FFB8]
       mov       [rbp+0FFE8],rcx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       mov       [rbp+0FFB4],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].GetValueOrDefault()
       cmp       eax,[rbp+0FFB4]
       sete      cl
       movzx     ecx,cl
       mov       [rbp+0FFB0],ecx
       lea       rcx,[rbp+0FFF0]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       mov       [rbp+0FFAC],eax
       lea       rcx,[rbp+0FFE8]
       call      System.Nullable`1[[System.Int32, System.Private.CoreLib]].get_HasValue()
       cmp       eax,[rbp+0FFAC]
       sete      al
       movzx     eax,al
       and       eax,[rbp+0FFB0]
       test      eax,eax
       jne       short M02_L08
M02_L07:
       xor       eax,eax
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L08:
       mov       dword ptr [rbp+0FFFC],1
       xor       ecx,ecx
       mov       [rbp+0FFDC],ecx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+18]
       mov       edx,[rbp+0FFDC]
       cmp       edx,[rcx+8]
       jae       short M02_L11
       mov       eax,edx
       lea       rcx,[rcx+rax*8+10]
       mov       rcx,[rcx]
       mov       [rbp+0FFA0],rcx
       mov       rcx,[rbp+0FFA0]
       mov       rdx,[rbp+20]
       mov       eax,[rbp+0FFDC]
       cmp       eax,[rdx+8]
       jae       short M02_L11
       mov       r8d,eax
       lea       rdx,[rdx+r8*8+10]
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFA0]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+10]
       and       eax,[rbp+0FFFC]
       movzx     eax,al
       mov       [rbp+0FFFC],eax
       mov       eax,[rbp+0FFDC]
       inc       eax
       mov       [rbp+0FFDC],eax
M02_L10:
       mov       ecx,[rbp+0FFDC]
       mov       rdx,[rbp+18]
       cmp       ecx,[rdx+8]
       jl        short M02_L09
       mov       eax,[rbp+0FFFC]
       lea       rsp,[rbp]
       pop       rbp
       ret
M02_L11:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 465
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.ArrayHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       [rsi+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1CCBCFF1048
       mov       r8,[r8]
       mov       rdx,1CC9CFF1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010978
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1CCBCFF1048
       mov       r8,[r8]
       mov       rdx,1CC9CFF1770
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M02_L00
       mov       rcx,[rbx+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37010E30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M02_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37010E30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rbp,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax]
       cmp       qword ptr [rbp+8],30
       jle       short M02_L04
       mov       rcx,[rbp+30]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37011388
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      r14,r14
       je        near ptr M02_L22
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37010E30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M02_L08:
       cmp       qword ptr [rbx+18],0
       je        short M02_L09
       mov       rcx,[rbx+18]
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFB37010E70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L10:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+10],0
       je        short M02_L11
       mov       rcx,[rbx+10]
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB37010E30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L12:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+10]
       test      rbp,rbp
       jne       near ptr M02_L19
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFB37010E30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFB370111C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M02_L22
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFB37010E30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M02_L19:
       cmp       qword ptr [rbx+20],0
       je        short M02_L20
       mov       rcx,[rbx+20]
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,7FFB37011088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L21:
       mov       rdx,rdi
       mov       r8d,1997
       mov       r9,rbp
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L22:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 622
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.ArrayHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       [rsi+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,18CA3773060
       mov       r8,[r8]
       mov       rdx,18CB3771770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB370009F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,18CA3773060
       mov       r8,[r8]
       mov       rdx,18CB3771770
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M02_L00
       mov       rcx,[rbx+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37000EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M02_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37000EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rbp,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax]
       cmp       qword ptr [rbp+8],30
       jle       short M02_L04
       mov       rcx,[rbp+30]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37001408
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      r14,r14
       je        near ptr M02_L22
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37000EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M02_L08:
       cmp       qword ptr [rbx+18],0
       je        short M02_L09
       mov       rcx,[rbx+18]
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFB37000EF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L10:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+10],0
       je        short M02_L11
       mov       rcx,[rbx+10]
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB37000EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L12:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+10]
       test      rbp,rbp
       jne       near ptr M02_L19
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFB37000EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFB37001248
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M02_L22
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFB37000EB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M02_L19:
       cmp       qword ptr [rbx+20],0
       je        short M02_L20
       mov       rcx,[rbx+20]
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,7FFB37001108
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L21:
       mov       rdx,rdi
       mov       r8d,1997
       mov       r9,rbp
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L22:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 622
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.ArrayHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       [rsi+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,27E3C781048
       mov       r8,[r8]
       mov       rdx,27E4C781770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0978
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,27E3C781048
       mov       r8,[r8]
       mov       rdx,27E4C781770
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M02_L00
       mov       rcx,[rbx+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0E30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M02_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0E30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rbp,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax]
       cmp       qword ptr [rbp+8],30
       jle       short M02_L04
       mov       rcx,[rbp+30]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1388
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      r14,r14
       je        near ptr M02_L22
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0E30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M02_L08:
       cmp       qword ptr [rbx+18],0
       je        short M02_L09
       mov       rcx,[rbx+18]
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0E70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L10:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+10],0
       je        short M02_L11
       mov       rcx,[rbx+10]
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0E30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L12:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+10]
       test      rbp,rbp
       jne       near ptr M02_L19
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0E30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FE11C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M02_L22
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0E30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M02_L19:
       cmp       qword ptr [rbx+20],0
       je        short M02_L20
       mov       rcx,[rbx+20]
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1088
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L21:
       mov       rdx,rdi
       mov       r8d,1997
       mov       r9,rbp
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L22:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 622
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.ArrayHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       [rsi+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1670CA23060
       mov       r8,[r8]
       mov       rdx,1670CA2DB90
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE09D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1670CA23060
       mov       r8,[r8]
       mov       rdx,1670CA2DB90
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M02_L00
       mov       rcx,[rbx+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M02_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rbp,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax]
       cmp       qword ptr [rbp+8],30
       jle       short M02_L04
       mov       rcx,[rbp+30]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE13E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      r14,r14
       je        near ptr M02_L22
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M02_L08:
       cmp       qword ptr [rbx+18],0
       je        short M02_L09
       mov       rcx,[rbx+18]
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0ED0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L10:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+10],0
       je        short M02_L11
       mov       rcx,[rbx+10]
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L12:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+10]
       test      rbp,rbp
       jne       near ptr M02_L19
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M02_L22
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FE0E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M02_L19:
       cmp       qword ptr [rbx+20],0
       je        short M02_L20
       mov       rcx,[rbx+20]
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,7FFB36FE10E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L21:
       mov       rdx,rdi
       mov       r8d,1997
       mov       r9,rbp
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L22:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 622
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.ArrayHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       [rsi+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,24EFC7E3060
       mov       r8,[r8]
       mov       rdx,24EEC7E1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010DE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,24EFC7E3060
       mov       r8,[r8]
       mov       rdx,24EEC7E1770
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M02_L00
       mov       rcx,[rbx+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB370112A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M02_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB370112A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rbp,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax]
       cmp       qword ptr [rbp+8],30
       jle       short M02_L04
       mov       rcx,[rbp+30]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB370117F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      r14,r14
       je        near ptr M02_L22
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB370112A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M02_L08:
       cmp       qword ptr [rbx+18],0
       je        short M02_L09
       mov       rcx,[rbx+18]
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFB370112E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L10:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+10],0
       je        short M02_L11
       mov       rcx,[rbx+10]
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB370112A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L12:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+10]
       test      rbp,rbp
       jne       near ptr M02_L19
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFB370112A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFB37011638
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M02_L22
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFB370112A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M02_L19:
       cmp       qword ptr [rbx+20],0
       je        short M02_L20
       mov       rcx,[rbx+20]
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,7FFB370114F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L21:
       mov       rdx,rdi
       mov       r8d,1997
       mov       r9,rbp
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L22:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 622
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.ArrayHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       [rsi+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1BDE6F03060
       mov       r8,[r8]
       mov       rdx,1BDF6F09728
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0DE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1BDE6F03060
       mov       r8,[r8]
       mov       rdx,1BDF6F09728
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M02_L00
       mov       rcx,[rbx+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M02_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rbp,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax]
       cmp       qword ptr [rbp+8],30
       jle       short M02_L04
       mov       rcx,[rbp+30]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF17F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      r14,r14
       je        near ptr M02_L22
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M02_L08:
       cmp       qword ptr [rbx+18],0
       je        short M02_L09
       mov       rcx,[rbx+18]
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L10:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+10],0
       je        short M02_L11
       mov       rcx,[rbx+10]
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L12:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+10]
       test      rbp,rbp
       jne       near ptr M02_L19
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1638
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M02_L22
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M02_L19:
       cmp       qword ptr [rbx+20],0
       je        short M02_L20
       mov       rcx,[rbx+20]
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,7FFB36FF14F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L21:
       mov       rdx,rdi
       mov       r8d,1997
       mov       r9,rbp
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L22:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 622
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.ArrayHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       [rsi+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1F5A45D3060
       mov       r8,[r8]
       mov       rdx,1F5B45D1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0DE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1F5A45D3060
       mov       r8,[r8]
       mov       rdx,1F5B45D1770
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M02_L00
       mov       rcx,[rbx+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M02_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rbp,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax]
       cmp       qword ptr [rbp+8],30
       jle       short M02_L04
       mov       rcx,[rbp+30]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF17F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      r14,r14
       je        near ptr M02_L22
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M02_L08:
       cmp       qword ptr [rbx+18],0
       je        short M02_L09
       mov       rcx,[rbx+18]
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L10:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+10],0
       je        short M02_L11
       mov       rcx,[rbx+10]
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L12:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+10]
       test      rbp,rbp
       jne       near ptr M02_L19
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1638
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M02_L22
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FF12A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M02_L19:
       cmp       qword ptr [rbx+20],0
       je        short M02_L20
       mov       rcx,[rbx+20]
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,7FFB36FF14F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L21:
       mov       rdx,rdi
       mov       r8d,1997
       mov       r9,rbp
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L22:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 622
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.ArrayHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       [rsi+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1CBB2063060
       mov       r8,[r8]
       mov       rdx,1CBD2061770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FD0B68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1CBB2063060
       mov       r8,[r8]
       mov       rdx,1CBD2061770
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M02_L00
       mov       rcx,[rbx+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FD1020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M02_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FD1020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rbp,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax]
       cmp       qword ptr [rbp+8],30
       jle       short M02_L04
       mov       rcx,[rbp+30]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FD1578
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      r14,r14
       je        near ptr M02_L22
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FD1020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M02_L08:
       cmp       qword ptr [rbx+18],0
       je        short M02_L09
       mov       rcx,[rbx+18]
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFB36FD1060
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L10:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+10],0
       je        short M02_L11
       mov       rcx,[rbx+10]
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB36FD1020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L12:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+10]
       test      rbp,rbp
       jne       near ptr M02_L19
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFB36FD1020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFB36FD13B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M02_L22
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFB36FD1020
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M02_L19:
       cmp       qword ptr [rbx+20],0
       je        short M02_L20
       mov       rcx,[rbx+20]
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,7FFB36FD1278
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L21:
       mov       rdx,rdi
       mov       r8d,1997
       mov       r9,rbp
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L22:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 622
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.ArrayHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rsi,[rsi+10]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       [rsi+30],eax
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1DF21873060
       mov       r8,[r8]
       mov       rdx,1DF41871770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB370109D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ArrayHashCode[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1DF21873060
       mov       r8,[r8]
       mov       rdx,1DF41871770
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rbx,[rsi+10]
       cmp       qword ptr [rbx+10],0
       je        short M02_L00
       mov       rcx,[rbx+10]
       jmp       short M02_L01
M02_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37010E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+8]
       test      rbp,rbp
       jne       near ptr M02_L08
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L02
       jmp       short M02_L03
M02_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37010E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L03:
       mov       rbp,[rsi+10]
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       r14,[rax]
       cmp       qword ptr [rbp+8],30
       jle       short M02_L04
       mov       rcx,[rbp+30]
       test      rcx,rcx
       je        short M02_L04
       jmp       short M02_L05
M02_L04:
       mov       rcx,rsi
       mov       rdx,7FFB370113E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       test      r14,r14
       je        near ptr M02_L22
       lea       rcx,[rbp+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37010E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
M02_L08:
       cmp       qword ptr [rbx+18],0
       je        short M02_L09
       mov       rcx,[rbx+18]
       jmp       short M02_L10
M02_L09:
       mov       rcx,rsi
       mov       rdx,7FFB37010ED0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L10:
       mov       rdx,rdi
       mov       r8,rbp
       call      System.Linq.Enumerable.Where[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
       mov       rdi,rax
       cmp       qword ptr [rbx+10],0
       je        short M02_L11
       mov       rcx,[rbx+10]
       jmp       short M02_L12
M02_L11:
       mov       rcx,rsi
       mov       rdx,7FFB37010E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L12:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax+10]
       test      rbp,rbp
       jne       near ptr M02_L19
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L13
       jmp       short M02_L14
M02_L13:
       mov       rcx,rsi
       mov       rdx,7FFB37010E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L14:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       mov       rbp,[rax]
       mov       rcx,[rbx+28]
       test      rcx,rcx
       je        short M02_L15
       jmp       short M02_L16
M02_L15:
       mov       rcx,rsi
       mov       rdx,7FFB37011228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L16:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rbp,rbp
       je        near ptr M02_L22
       lea       rcx,[r14+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__4`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__4_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFB37010E90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L18:
       call      CORINFO_HELP_GETGENERICS_GCSTATIC_BASE
       lea       rcx,[rax+10]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rbp,r14
M02_L19:
       cmp       qword ptr [rbx+20],0
       je        short M02_L20
       mov       rcx,[rbx+20]
       jmp       short M02_L21
M02_L20:
       mov       rcx,rsi
       mov       rdx,7FFB370110E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L21:
       mov       rdx,rdi
       mov       r8d,1997
       mov       r9,rbp
       call      System.Linq.Enumerable.Aggregate[[System.__Canon, System.Private.CoreLib],[System.Int32, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Int32, System.Func`3<Int32,System.__Canon,Int32>)
       nop
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M02_L22:
       call      System.MulticastDelegate.ThrowNullThisInDelegateToInstance()
       int       3
; Total bytes of code 622
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString()
; 			var result = base.ByteArray.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+68]
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
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
; dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,19DEBB01048
       mov       r8,[r8]
       mov       rdx,19DDBB101B0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       call      dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,19DDBB01528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,19DDBB10418
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB36EF9498]
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 158
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString()
; 			var result = base.ByteArray.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+68]
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
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
; dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,1BE73C83060
       mov       r8,[r8]
       mov       rdx,1BE63C81770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       call      dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,1BE73C81528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1BE53C85C10
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB36EF9498]
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 158
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString()
; 			var result = base.ByteArray.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+68]
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
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
; dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,1BCF1063060
       mov       r8,[r8]
       mov       rdx,1BD01061770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       call      dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,1BCF1061528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1BD010619D8
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB36F29498]
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 158
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString()
; 			var result = base.ByteArray.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+68]
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
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
; dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,1DCA49C1048
       mov       r8,[r8]
       mov       rdx,1DC949C1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       call      dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,1DCB49C1528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1DC949C19D8
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB36F09498]
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 158
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString()
; 			var result = base.ByteArray.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+68]
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
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
; dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,263FAA93060
       mov       r8,[r8]
       mov       rdx,2640AA99728
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       call      dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,263FAA91528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,263EAA95C10
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB36F19498]
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 158
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString()
; 			var result = base.ByteArray.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+68]
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
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
; dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,2999EA03060
       mov       r8,[r8]
       mov       rdx,299AEA061E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       call      dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,2999EA01528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,2999EA05608
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB36F29498]
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 158
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString()
; 			var result = base.ByteArray.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+68]
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
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
; dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,241E50A3060
       mov       r8,[r8]
       mov       rdx,241F50AE198
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       call      dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,241E50A1528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,241E50A5608
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB36F09498]
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 158
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString()
; 			var result = base.ByteArray.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+68]
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
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
; dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,258299A3060
       mov       r8,[r8]
       mov       rdx,258199A61E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       call      dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,258299A1528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,258199A6448
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB36F09498]
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 158
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString()
; 			var result = base.ByteArray.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+68]
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
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
; dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,13F58433060
       mov       r8,[r8]
       mov       rdx,13F48431770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       call      dotNetTips.Spargine.Core.TypeHelper.CreateStringBuilder()
       mov       rdi,rax
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,13F58431528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,13F484319D8
       mov       rdx,[rax]
       test      rdx,rdx
       jne       short M01_L01
       call      System.Number.UInt32ToDecStr(UInt32)
       jmp       short M01_L02
M01_L01:
       call      System.Number.<FormatUInt32>g__FormatUInt32Slow|40_0(UInt32, System.String, System.IFormatProvider)
M01_L02:
       mov       rcx,rdi
       mov       rdx,rax
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB36F09498]
       cmp       [rcx],ecx
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 158
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,24BEF3A3060
       mov       r8,[r8]
       mov       rdx,24BDF3A1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1EA070F3060
       mov       r8,[r8]
       mov       rdx,1EA070F3BC0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FD0960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,19EC9123060
       mov       r8,[r8]
       mov       rdx,19EC9125BD8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF09C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1FE4E0E3060
       mov       r8,[r8]
       mov       rdx,1FE5E0E1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0DD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,163127A3060
       mov       r8,[r8]
       mov       rdx,162F27A1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0B48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1F60AB73060
       mov       r8,[r8]
       mov       rdx,1F5DAB71770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0B48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,2C08B401048
       mov       r8,[r8]
       mov       rdx,2C0AB4081F8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37000DD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1636B351048
       mov       r8,[r8]
       mov       rdx,1636B35BB78
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0BF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 55
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1D7452D3060
       mov       r8,[r8]
       mov       rdx,1D7352D1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0BF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>().AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperArrayFull.ContainsAny(people.ToArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rdx,rax
       mov       rdi,[rsi+88]
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1D767971048
       mov       r8,[r8]
       mov       rdx,1D767978630
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0CA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,1D767978630
       mov       r8,[r8]
       mov       r9,1D767971048
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0FD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F16080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF5110
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF51D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FF51A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M04_L00
       mov       rcx,[rbp+10]
       jmp       short M04_L01
M04_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF13A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rdi,rdi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M04_L02
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M04_L03
M04_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M04_L04
       jmp       short M04_L05
M04_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2098
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L05:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M04_L12
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2098
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rdi
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2390
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass7_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M04_L10
       jmp       short M04_L11
M04_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FF23D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L11:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M04_L12:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 352
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>().AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperArrayFull.ContainsAny(people.ToArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rdx,rax
       mov       rdi,[rsi+88]
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,2BC6FDD3060
       mov       r8,[r8]
       mov       rdx,2BC4FDD1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37000A70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,2BC4FDD1770
       mov       r8,[r8]
       mov       r9,2BC6FDD3060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37000DA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F26080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB370063C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37006488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37006458
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M04_L00
       mov       rcx,[rbp+10]
       jmp       short M04_L01
M04_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37001170
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rdi,rdi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M04_L02
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M04_L03
M04_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M04_L04
       jmp       short M04_L05
M04_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37001E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L05:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M04_L12
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37001E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rdi
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37002160
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass7_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M04_L10
       jmp       short M04_L11
M04_L10:
       mov       rcx,rsi
       mov       rdx,7FFB370021A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L11:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M04_L12:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 352
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>().AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperArrayFull.ContainsAny(people.ToArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rdx,rax
       mov       rdi,[rsi+88]
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1A84EB81048
       mov       r8,[r8]
       mov       rdx,1A83EB81770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,1A83EB81770
       mov       r8,[r8]
       mov       r9,1A84EB81048
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0D40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F06080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE6360
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FE6428
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FE63F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M04_L00
       mov       rcx,[rbp+10]
       jmp       short M04_L01
M04_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1110
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rdi,rdi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M04_L02
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M04_L03
M04_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M04_L04
       jmp       short M04_L05
M04_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1E08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L05:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M04_L12
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1E08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rdi
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FE2100
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass7_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M04_L10
       jmp       short M04_L11
M04_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FE2140
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L11:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M04_L12:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 352
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>().AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperArrayFull.ContainsAny(people.ToArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rdx,rax
       mov       rdi,[rsi+88]
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,20E23353060
       mov       r8,[r8]
       mov       rdx,20E23355BD8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010C00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,20E23355BD8
       mov       r8,[r8]
       mov       r9,20E23353060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37010F30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F36080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37016550
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37016618
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB370165E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M04_L00
       mov       rcx,[rbp+10]
       jmp       short M04_L01
M04_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37011300
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rdi,rdi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M04_L02
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M04_L03
M04_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M04_L04
       jmp       short M04_L05
M04_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37011FF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L05:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M04_L12
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37011FF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rdi
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rsi
       mov       rdx,7FFB370122F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass7_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M04_L10
       jmp       short M04_L11
M04_L10:
       mov       rcx,rsi
       mov       rdx,7FFB37012330
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L11:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M04_L12:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 352
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>().AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperArrayFull.ContainsAny(people.ToArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rdx,rax
       mov       rdi,[rsi+88]
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,14C42F43060
       mov       r8,[r8]
       mov       rdx,14C32F41770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0E80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,14C32F41770
       mov       r8,[r8]
       mov       r9,14C42F43060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FF11B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F16080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF67D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF6898
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FF6868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M04_L00
       mov       rcx,[rbp+10]
       jmp       short M04_L01
M04_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rdi,rdi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M04_L02
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M04_L03
M04_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M04_L04
       jmp       short M04_L05
M04_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2278
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L05:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M04_L12
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2278
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rdi
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass7_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M04_L10
       jmp       short M04_L11
M04_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FF25B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L11:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M04_L12:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 352
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>().AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperArrayFull.ContainsAny(people.ToArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rdx,rax
       mov       rdi,[rsi+88]
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1FDC9671048
       mov       r8,[r8]
       mov       rdx,1FDA9673788
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010E80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,1FDA9673788
       mov       r8,[r8]
       mov       r9,1FDC9671048
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB370111B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F36080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB370167D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37016898
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB37016868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M04_L00
       mov       rcx,[rbp+10]
       jmp       short M04_L01
M04_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37011580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rdi,rdi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M04_L02
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M04_L03
M04_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M04_L04
       jmp       short M04_L05
M04_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37012278
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L05:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M04_L12
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37012278
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rdi
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37012570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass7_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M04_L10
       jmp       short M04_L11
M04_L10:
       mov       rcx,rsi
       mov       rdx,7FFB370125B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L11:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M04_L12:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 352
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>().AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperArrayFull.ContainsAny(people.ToArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rdx,rax
       mov       rdi,[rsi+88]
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1C9EFBE3060
       mov       r8,[r8]
       mov       rdx,1C9DFBE1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0A70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,1C9DFBE1770
       mov       r8,[r8]
       mov       r9,1C9EFBE3060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0DA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F16080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF63C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FF6488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FF6458
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M04_L00
       mov       rcx,[rbp+10]
       jmp       short M04_L01
M04_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1170
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rdi,rdi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M04_L02
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M04_L03
M04_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M04_L04
       jmp       short M04_L05
M04_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L05:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M04_L12
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FF1E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rdi
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FF2160
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass7_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M04_L10
       jmp       short M04_L11
M04_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FF21A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L11:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M04_L12:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 352
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>().AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperArrayFull.ContainsAny(people.ToArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rdx,rax
       mov       rdi,[rsi+88]
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,25BE0ED1048
       mov       r8,[r8]
       mov       rdx,25BF0ED61E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0E80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,25BF0ED61E0
       mov       r8,[r8]
       mov       r9,25BE0ED1048
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB36FE11B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F06080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE67D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB36FE6898
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB36FE6868
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M04_L00
       mov       rcx,[rbp+10]
       jmp       short M04_L01
M04_L00:
       mov       rcx,rsi
       mov       rdx,7FFB36FE1580
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rdi,rdi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M04_L02
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M04_L03
M04_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M04_L04
       jmp       short M04_L05
M04_L04:
       mov       rcx,rsi
       mov       rdx,7FFB36FE2278
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L05:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M04_L12
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rsi
       mov       rdx,7FFB36FE2278
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rdi
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rsi
       mov       rdx,7FFB36FE2570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass7_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M04_L10
       jmp       short M04_L11
M04_L10:
       mov       rcx,rsi
       mov       rdx,7FFB36FE25B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L11:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M04_L12:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 352
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>().AddLast(this.PersonProper);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = base.PersonProperArrayFull.ContainsAny(people.ToArray());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rdx,rax
       mov       rdi,[rsi+88]
       mov       rcx,offset MD_System.Linq.Enumerable.ToArray(System.Collections.Generic.IEnumerable`1<!!0>)
       call      System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny(!!0[], !!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       mov       rdx,[rsi+10]
       mov       [rdx+44],al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 128
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,288BD803060
       mov       r8,[r8]
       mov       rdx,288BD80A648
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010A70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       rbx,r8
       test      rbx,rbx
       jne       short M02_L00
       mov       rax,rsi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L00:
       cmp       [rsi],esi
       mov       r8,288BD80A648
       mov       r8,[r8]
       mov       r9,288BD803060
       mov       r9,[r9]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       mov       edx,1
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       mov       ebp,[rsi+8]
       inc       ebp
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFB37010DA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB36F36080]
       mov       edx,[rsi+8]
       mov       rcx,rdi
       mov       r8,rbx
       call      CORINFO_HELP_ARRADDR_ST
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 180
```
```assembly
; System.Linq.Enumerable.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       test      rdi,rdi
       je        near ptr M03_L07
       mov       rcx,[rsi+10]
       mov       rcx,[rcx+28]
       test      rcx,rcx
       je        short M03_L00
       jmp       short M03_L01
M03_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37016648
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       rbx,rax
       test      rbx,rbx
       jne       short M03_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M03_L02
       mov       rcx,[rcx+38]
       test      rcx,rcx
       je        short M03_L02
       jmp       short M03_L03
M03_L02:
       mov       rcx,rsi
       mov       rdx,7FFB37016710
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M03_L03:
       mov       rdx,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       near ptr System.Collections.Generic.EnumerableHelpers.ToArray[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
M03_L04:
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M03_L05
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M03_L05
       jmp       short M03_L06
M03_L05:
       mov       rcx,rsi
       mov       rdx,7FFB370166E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M03_L06:
       mov       rcx,rbx
       mov       rax,[r11]
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       jmp       rax
M03_L07:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
; Total bytes of code 207
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.ContainsAny[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon[])
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rbx,r8
       mov       rbp,[rsi+10]
       cmp       qword ptr [rbp+10],0
       je        short M04_L00
       mov       rcx,[rbp+10]
       jmp       short M04_L01
M04_L00:
       mov       rcx,rsi
       mov       rdx,7FFB37011170
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rdi,rdi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M04_L02
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M04_L03
M04_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M04_L03:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M04_L04
       jmp       short M04_L05
M04_L04:
       mov       rcx,rsi
       mov       rdx,7FFB37011E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L05:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M04_L12
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M04_L06
       jmp       short M04_L07
M04_L06:
       mov       rcx,rsi
       mov       rdx,7FFB37011E68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L07:
       mov       rdx,rdi
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M04_L08
       jmp       short M04_L09
M04_L08:
       mov       rcx,rsi
       mov       rdx,7FFB37012160
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass7_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M04_L10
       jmp       short M04_L11
M04_L10:
       mov       rcx,rsi
       mov       rdx,7FFB370121A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M04_L11:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M04_L12:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 352
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveDuplicates01()
       ret
; Total bytes of code 1
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveDuplicates01()
       ret
; Total bytes of code 1
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveDuplicates01()
       ret
; Total bytes of code 1
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveDuplicates01()
       ret
; Total bytes of code 1
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveDuplicates01()
       ret
; Total bytes of code 1
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveDuplicates01()
       ret
; Total bytes of code 1
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveDuplicates01()
       ret
; Total bytes of code 1
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveDuplicates01()
       ret
; Total bytes of code 1
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveDuplicates01()
       ret
; Total bytes of code 1
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveFirst()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.RemoveFirst();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,17AEEDA1048
       mov       r8,[r8]
       mov       rdx,17AFEDAB740
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB370109E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,17AEEDA1048
       mov       r8,[r8]
       mov       rdx,17AFEDAB740
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       dec       ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010C10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       ecx,[rdi+8]
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       edx,1
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveFirst()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.RemoveFirst();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,195B4CE3060
       mov       r8,[r8]
       mov       rdx,195A4CEE198
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0A40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,195B4CE3060
       mov       r8,[r8]
       mov       rdx,195A4CEE198
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       dec       ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0C70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       ecx,[rdi+8]
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       edx,1
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveFirst()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.RemoveFirst();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1DFE82D3060
       mov       r8,[r8]
       mov       rdx,1DFC82D1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1DFE82D3060
       mov       r8,[r8]
       mov       rdx,1DFC82D1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       dec       ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       ecx,[rdi+8]
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       edx,1
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveFirst()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.RemoveFirst();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,27649D01048
       mov       r8,[r8]
       mov       rdx,27669D03788
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0A40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,27649D01048
       mov       r8,[r8]
       mov       rdx,27669D03788
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       dec       ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0C70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       ecx,[rdi+8]
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       edx,1
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveFirst()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.RemoveFirst();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,20BCAA51048
       mov       r8,[r8]
       mov       rdx,20BBAA53788
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,20BCAA51048
       mov       r8,[r8]
       mov       rdx,20BBAA53788
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       dec       ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF1080
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       ecx,[rdi+8]
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       edx,1
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveFirst()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.RemoveFirst();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,2266AEA1048
       mov       r8,[r8]
       mov       rdx,2264AEA61E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB370109E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,2266AEA1048
       mov       r8,[r8]
       mov       rdx,2264AEA61E0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       dec       ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010C10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       ecx,[rdi+8]
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       edx,1
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveFirst()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.RemoveFirst();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,2878F131048
       mov       r8,[r8]
       mov       rdx,2877F131770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010A60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,2878F131048
       mov       r8,[r8]
       mov       rdx,2877F131770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       dec       ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010C90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       ecx,[rdi+8]
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       edx,1
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveFirst()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.RemoveFirst();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1FB5C6D1048
       mov       r8,[r8]
       mov       rdx,1FB6C6D3788
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1FB5C6D1048
       mov       r8,[r8]
       mov       rdx,1FB6C6D3788
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       dec       ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF1080
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       ecx,[rdi+8]
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       edx,1
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveFirst()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.RemoveFirst();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1DE7B2C3060
       mov       r8,[r8]
       mov       rdx,1DE7B2D2600
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0A40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1DE7B2C3060
       mov       r8,[r8]
       mov       rdx,1DE7B2D2600
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       dec       ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0C70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       ecx,[rdi+8]
       mov       [rsp+20],ecx
       mov       rcx,rsi
       mov       r8,rdi
       mov       edx,1
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 141
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveLast()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.RemoveLast();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1A1BE553060
       mov       r8,[r8]
       mov       rdx,1A1BE562600
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF09E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1A1BE553060
       mov       r8,[r8]
       mov       rdx,1A1BE562600
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       dec       ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0C10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       r8d,[rdi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 130
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveLast()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.RemoveLast();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1C08DC31048
       mov       r8,[r8]
       mov       rdx,1C0ADC39728
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37000A40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1C08DC31048
       mov       r8,[r8]
       mov       rdx,1C0ADC39728
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       dec       ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37000C70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       r8d,[rdi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 130
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveLast()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.RemoveLast();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1F0D3FC3060
       mov       r8,[r8]
       mov       rdx,1F0C3FC1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010BD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1F0D3FC3060
       mov       r8,[r8]
       mov       rdx,1F0C3FC1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       dec       ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       r8d,[rdi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 130
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveLast()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.RemoveLast();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,225E7CC1048
       mov       r8,[r8]
       mov       rdx,225C7CC1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB370009E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,225E7CC1048
       mov       r8,[r8]
       mov       rdx,225C7CC1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       dec       ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37000C10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       r8d,[rdi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 130
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveLast()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.RemoveLast();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,15F6B7D3060
       mov       r8,[r8]
       mov       rdx,15F4B7D1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF0E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,15F6B7D3060
       mov       r8,[r8]
       mov       rdx,15F4B7D1770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       dec       ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FF1080
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       r8d,[rdi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 130
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveLast()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.RemoveLast();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1D18A433060
       mov       r8,[r8]
       mov       rdx,1D19A431770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37000E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,1D18A433060
       mov       r8,[r8]
       mov       rdx,1D19A431770
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       dec       ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37001080
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       r8d,[rdi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 130
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveLast()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.RemoveLast();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,130DC0C1048
       mov       r8,[r8]
       mov       rdx,130EC0C3788
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37000E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,130DC0C1048
       mov       r8,[r8]
       mov       rdx,130EC0C3788
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       dec       ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37001080
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       r8d,[rdi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 130
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveLast()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.RemoveLast();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,17B40871048
       mov       r8,[r8]
       mov       rdx,17B40878630
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010BD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,17B40871048
       mov       r8,[r8]
       mov       rdx,17B40878630
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       dec       ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB37010E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       r8d,[rdi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 130
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.RemoveLast()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.RemoveLast();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+88]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 73
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,38
       mov       [rsp+30],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,205C6ED1048
       mov       r8,[r8]
       mov       rdx,205C6EDBB78
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       mov       ebp,ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE0E50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       [rsp+20],ebx
       mov       rcx,rsi
       mov       r8,rdi
       xor       edx,edx
       xor       r9d,r9d
       call      System.Array.Copy(System.Array, Int32, System.Array, Int32, Int32)
       mov       rax,rdi
       add       rsp,38
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.RemoveLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       [rsp+28],rcx
       mov       rdi,rcx
       mov       rsi,rdx
       mov       r8,205C6ED1048
       mov       r8,[r8]
       mov       rdx,205C6EDBB78
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       ebx,[rsi+8]
       dec       ebx
       mov       rcx,[rdi+10]
       mov       rcx,[rcx+10]
       test      rcx,rcx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFB36FE1080
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L01:
       movsxd    rdx,ebx
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       r8d,[rdi+8]
       mov       rcx,rsi
       mov       rdx,rdi
       call      System.Array.Copy(System.Array, System.Array, Int32)
       mov       rax,rdi
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 130
```

