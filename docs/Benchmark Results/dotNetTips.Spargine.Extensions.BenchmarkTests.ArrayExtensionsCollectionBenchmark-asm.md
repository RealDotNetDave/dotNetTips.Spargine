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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB1726A2B0
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
       mov       rdx,7FFB1726A300
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
       mov       rdx,7FFB1726A2C0
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
       mov       rdx,7FFB1726A318
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
       mov       rdx,7FFB1726A328
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
       mov       rdx,7FFB1726A2C0
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
       mov       rdx,7FFB1726A2D0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D50660
       call      qword ptr [7FFB17170660]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB1726A2E8
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
       mov       r11,7FFB16D50660
       call      qword ptr [7FFB17170660]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D50668
       call      qword ptr [7FFB17170668]
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
       mov       r11,7FFB16D50668
       call      qword ptr [7FFB17170668]
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
       mov       r8,260383D1048
       mov       r8,[r8]
       mov       rdx,260483D11B8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,260383D1048
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
       mov       rdx,260383D1438
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
       mov       rdx,7FFB1723E930
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
       mov       rdx,7FFB1723E980
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
       mov       rdx,7FFB1726B628
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
       mov       rdx,7FFB1726B6F0
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
       mov       rdx,7FFB1726B6C0
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
       mov       rdx,7FFB1723FA48
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
       mov       rdx,7FFB17263C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,260383D1048
       mov       r9,[r9]
       mov       r8,260383E0788
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
       mov       rdx,7FFB17264078
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB1725A450
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
       mov       rdx,7FFB1725A4A0
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
       mov       rdx,7FFB1725A460
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
       mov       rdx,7FFB1725A4B8
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
       mov       rdx,7FFB1725A4C8
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
       mov       rdx,7FFB1725A460
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
       mov       rdx,7FFB1725A470
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D40668
       call      qword ptr [7FFB17160668]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB1725A488
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
       mov       r11,7FFB16D40668
       call      qword ptr [7FFB17160668]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D40670
       call      qword ptr [7FFB17160670]
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
       mov       r11,7FFB16D40670
       call      qword ptr [7FFB17160670]
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
       mov       r8,231EA943060
       mov       r8,[r8]
       mov       rdx,231EA943608
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,231EA943060
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
       mov       rdx,231EA943450
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
       mov       rdx,7FFB1722E930
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
       mov       rdx,7FFB1722E980
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
       mov       rdx,7FFB1725B7C8
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
       mov       rdx,7FFB1725B890
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
       mov       rdx,7FFB1725B860
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
       mov       rdx,7FFB1722FA48
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
       mov       rdx,7FFB17253C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,231EA943060
       mov       r9,[r9]
       mov       r8,231DA949718
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
       mov       rdx,7FFB17254078
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB1724A450
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
       mov       rdx,7FFB1724A4A0
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
       mov       rdx,7FFB1724A460
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
       mov       rdx,7FFB1724A4B8
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
       mov       rdx,7FFB1724A4C8
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
       mov       rdx,7FFB1724A460
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
       mov       rdx,7FFB1724A470
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D30668
       call      qword ptr [7FFB17150668]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB1724A488
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
       mov       r11,7FFB16D30668
       call      qword ptr [7FFB17150668]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D30670
       call      qword ptr [7FFB17150670]
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
       mov       r11,7FFB16D30670
       call      qword ptr [7FFB17150670]
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
       mov       r8,2BF72D73060
       mov       r8,[r8]
       mov       rdx,2BF52D711B8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,2BF72D73060
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
       mov       rdx,2BF72D73450
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
       mov       rdx,7FFB1721E930
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
       mov       rdx,7FFB1721E980
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
       mov       rdx,7FFB1724B7C8
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
       mov       rdx,7FFB1724B890
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
       mov       rdx,7FFB1724B860
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
       mov       rdx,7FFB1721FA48
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
       mov       rdx,7FFB17243C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,2BF72D73060
       mov       r9,[r9]
       mov       r8,2BF72D75BC8
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
       mov       rdx,7FFB17244078
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB1727A450
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
       mov       rdx,7FFB1727A4A0
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
       mov       rdx,7FFB1727A460
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
       mov       rdx,7FFB1727A4B8
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
       mov       rdx,7FFB1727A4C8
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
       mov       rdx,7FFB1727A460
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
       mov       rdx,7FFB1727A470
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D60668
       call      qword ptr [7FFB17180668]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB1727A488
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
       mov       r11,7FFB16D60668
       call      qword ptr [7FFB17180668]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D60670
       call      qword ptr [7FFB17180670]
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
       mov       r11,7FFB16D60670
       call      qword ptr [7FFB17180670]
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
       mov       r8,1E32A0E3060
       mov       r8,[r8]
       mov       rdx,1E32A0E3608
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,1E32A0E3060
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
       mov       rdx,1E32A0E3450
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
       mov       rdx,7FFB1724E930
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
       mov       rdx,7FFB1724E980
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
       mov       rdx,7FFB1727B7C8
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
       mov       rdx,7FFB1727B890
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
       mov       rdx,7FFB1727B860
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
       mov       rdx,7FFB1724FA48
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
       mov       rdx,7FFB17273C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1E32A0E3060
       mov       r9,[r9]
       mov       r8,1E33A0F0350
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
       mov       rdx,7FFB17274078
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB1726A450
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
       mov       rdx,7FFB1726A4A0
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
       mov       rdx,7FFB1726A460
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
       mov       rdx,7FFB1726A4B8
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
       mov       rdx,7FFB1726A4C8
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
       mov       rdx,7FFB1726A460
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
       mov       rdx,7FFB1726A470
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D50668
       call      qword ptr [7FFB17170668]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB1726A488
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
       mov       r11,7FFB16D50668
       call      qword ptr [7FFB17170668]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D50670
       call      qword ptr [7FFB17170670]
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
       mov       r11,7FFB16D50670
       call      qword ptr [7FFB17170670]
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
       mov       r8,1EB5E2E3060
       mov       r8,[r8]
       mov       rdx,1EB6E2E11B8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,1EB5E2E3060
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
       mov       rdx,1EB5E2E3450
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
       mov       rdx,7FFB1723E930
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
       mov       rdx,7FFB1723E980
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
       mov       rdx,7FFB1726B7C8
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
       mov       rdx,7FFB1726B890
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
       mov       rdx,7FFB1726B860
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
       mov       rdx,7FFB1723FA48
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
       mov       rdx,7FFB17263C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1EB5E2E3060
       mov       r9,[r9]
       mov       r8,1EB3E2E1760
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
       mov       rdx,7FFB17264078
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB1727A450
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
       mov       rdx,7FFB1727A4A0
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
       mov       rdx,7FFB1727A460
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
       mov       rdx,7FFB1727A4B8
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
       mov       rdx,7FFB1727A4C8
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
       mov       rdx,7FFB1727A460
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
       mov       rdx,7FFB1727A470
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D60668
       call      qword ptr [7FFB17180668]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB1727A488
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
       mov       r11,7FFB16D60668
       call      qword ptr [7FFB17180668]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D60670
       call      qword ptr [7FFB17180670]
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
       mov       r11,7FFB16D60670
       call      qword ptr [7FFB17180670]
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
       mov       r8,24A53A23060
       mov       r8,[r8]
       mov       rdx,24A63A211B8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,24A53A23060
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
       mov       rdx,24A53A23450
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
       mov       rdx,7FFB1724E9E8
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
       mov       rdx,7FFB1724EA38
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
       mov       rdx,7FFB1727B7C8
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
       mov       rdx,7FFB1727B890
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
       mov       rdx,7FFB1727B860
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
       mov       rdx,7FFB1724FB00
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
       mov       rdx,7FFB17273C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,24A53A23060
       mov       r9,[r9]
       mov       r8,24A53A327A0
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
       mov       rdx,7FFB17274078
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB1727A450
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
       mov       rdx,7FFB1727A4A0
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
       mov       rdx,7FFB1727A460
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
       mov       rdx,7FFB1727A4B8
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
       mov       rdx,7FFB1727A4C8
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
       mov       rdx,7FFB1727A460
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
       mov       rdx,7FFB1727A470
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D60668
       call      qword ptr [7FFB17180668]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB1727A488
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
       mov       r11,7FFB16D60668
       call      qword ptr [7FFB17180668]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D60670
       call      qword ptr [7FFB17180670]
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
       mov       r11,7FFB16D60670
       call      qword ptr [7FFB17180670]
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
       mov       r8,28AD5B03060
       mov       r8,[r8]
       mov       rdx,28AD5B03608
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,28AD5B03060
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
       mov       rdx,28AD5B03450
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
       mov       rdx,7FFB1724EC78
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
       mov       rdx,7FFB1724ECC8
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
       mov       rdx,7FFB1727B7C8
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
       mov       rdx,7FFB1727B890
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
       mov       rdx,7FFB1727B860
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
       mov       rdx,7FFB1724FD90
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
       mov       rdx,7FFB17273C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,28AD5B03060
       mov       r9,[r9]
       mov       r8,28AE5B10350
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
       mov       rdx,7FFB17274078
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB1723A450
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
       mov       rdx,7FFB1723A4A0
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
       mov       rdx,7FFB1723A460
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
       mov       rdx,7FFB1723A4B8
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
       mov       rdx,7FFB1723A4C8
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
       mov       rdx,7FFB1723A460
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
       mov       rdx,7FFB1723A470
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D20668
       call      qword ptr [7FFB17140668]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB1723A488
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
       mov       r11,7FFB16D20668
       call      qword ptr [7FFB17140668]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D20670
       call      qword ptr [7FFB17140670]
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
       mov       r11,7FFB16D20670
       call      qword ptr [7FFB17140670]
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
       mov       r8,2172EA11048
       mov       r8,[r8]
       mov       rdx,2171EA111B8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,2172EA11048
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
       mov       rdx,2172EA11438
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
       mov       rdx,7FFB1720E930
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
       mov       rdx,7FFB1720E980
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
       mov       rdx,7FFB1723B7C8
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
       mov       rdx,7FFB1723B890
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
       mov       rdx,7FFB1723B860
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
       mov       rdx,7FFB1720FA48
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
       mov       rdx,7FFB17233C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,2172EA11048
       mov       r9,[r9]
       mov       r8,2170EA13778
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
       mov       rdx,7FFB17234078
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
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB1724A450
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
       mov       rdx,7FFB1724A4A0
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
       mov       rdx,7FFB1724A460
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
       mov       rdx,7FFB1724A4B8
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
       mov       rdx,7FFB1724A4C8
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
       mov       rdx,7FFB1724A460
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
       mov       rdx,7FFB1724A470
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D30668
       call      qword ptr [7FFB17150668]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB1724A488
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
       mov       r11,7FFB16D30668
       call      qword ptr [7FFB17150668]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D30670
       call      qword ptr [7FFB17150670]
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
       mov       r11,7FFB16D30670
       call      qword ptr [7FFB17150670]
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
       mov       r8,1E937D33060
       mov       r8,[r8]
       mov       rdx,1E947D311B8
       mov       rdx,[rdx]
       mov       rcx,rbx
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rax,1E937D33060
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
       mov       rdx,1E937D33450
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
       mov       rdx,7FFB1721E930
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
       mov       rdx,7FFB1721E980
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
       mov       rdx,7FFB1724B7C8
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
       mov       rdx,7FFB1724B890
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
       mov       rdx,7FFB1724B860
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
       mov       rdx,7FFB1721FA48
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
       mov       rdx,7FFB17243C78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1E937D33060
       mov       r9,[r9]
       mov       r8,1E917D31760
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
       mov       rdx,7FFB17244078
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
       mov       rdx,[rsi+0A0]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB172485F0
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
       mov       rdx,7FFB17248640
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
       mov       rdx,7FFB17248600
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
       mov       rdx,7FFB17248658
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
       mov       rdx,7FFB17248668
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
       mov       rdx,7FFB17248600
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
       mov       rdx,7FFB17248610
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D40630
       call      qword ptr [7FFB17160630]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB17248628
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
       mov       r11,7FFB16D40630
       call      qword ptr [7FFB17160630]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D40638
       call      qword ptr [7FFB17160638]
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
       mov       r11,7FFB16D40638
       call      qword ptr [7FFB17160638]
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
       mov       rdx,7FFB17249020
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
       mov       rdx,7FFB172492B0
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
       mov       rdx,7FFB172496C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7FFB16E30020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L06
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,7FFB17249600
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB16E30020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L10
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L10:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,7FFB17249298
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
       mov       rdx,7FFB172497D0
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
       mov       rdx,7FFB17249898
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
       mov       rdx,7FFB17249868
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
       mov       rdx,7FFB1722E2C8
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
       mov       rdx,7FFB172424B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1D0D5D23060
       mov       r9,[r9]
       mov       r8,1D0B5D21760
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
       mov       rdx,7FFB172428B0
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
       mov       rdx,[rsi+0A0]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17238650
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
       mov       rdx,7FFB172386A0
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
       mov       rdx,7FFB17238660
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
       mov       rdx,7FFB172386B8
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
       mov       rdx,7FFB172386C8
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
       mov       rdx,7FFB17238660
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
       mov       rdx,7FFB17238670
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D30630
       call      qword ptr [7FFB17150630]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB17238688
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
       mov       r11,7FFB16D30630
       call      qword ptr [7FFB17150630]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D30638
       call      qword ptr [7FFB17150638]
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
       mov       r11,7FFB16D30638
       call      qword ptr [7FFB17150638]
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
       mov       rdx,7FFB17238FC8
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
       mov       rdx,7FFB17239258
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
       mov       rdx,7FFB17239668
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7FFB16E20020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L06
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,7FFB172395A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB16E20020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L10
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L10:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,7FFB17239240
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
       mov       rdx,7FFB17239778
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
       mov       rdx,7FFB17239840
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
       mov       rdx,7FFB17239810
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
       mov       rdx,7FFB1721E2C8
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
       mov       rdx,7FFB172324B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,2DC0BE43060
       mov       r9,[r9]
       mov       r8,2DC1BE43778
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
       mov       rdx,7FFB172328B0
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
       mov       rdx,[rsi+0A0]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17268650
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
       mov       rdx,7FFB172686A0
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
       mov       rdx,7FFB17268660
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
       mov       rdx,7FFB172686B8
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
       mov       rdx,7FFB172686C8
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
       mov       rdx,7FFB17268660
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
       mov       rdx,7FFB17268670
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D60630
       call      qword ptr [7FFB17180630]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB17268688
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
       mov       r11,7FFB16D60630
       call      qword ptr [7FFB17180630]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D60638
       call      qword ptr [7FFB17180638]
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
       mov       r11,7FFB16D60638
       call      qword ptr [7FFB17180638]
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
       mov       rdx,7FFB17268FC8
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
       mov       rdx,7FFB17269258
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
       mov       rdx,7FFB17269668
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7FFB16E50020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L06
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,7FFB172695A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB16E50020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L10
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L10:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,7FFB17269240
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
       mov       rdx,7FFB17269778
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
       mov       rdx,7FFB17269840
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
       mov       rdx,7FFB17269810
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
       mov       rdx,7FFB1724E2C8
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
       mov       rdx,7FFB172624B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,2A651193060
       mov       r9,[r9]
       mov       r8,2A661191760
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
       mov       rdx,7FFB172628B0
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
       mov       rdx,[rsi+0A0]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17258650
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
       mov       rdx,7FFB172586A0
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
       mov       rdx,7FFB17258660
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
       mov       rdx,7FFB172586B8
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
       mov       rdx,7FFB172586C8
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
       mov       rdx,7FFB17258660
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
       mov       rdx,7FFB17258670
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D50630
       call      qword ptr [7FFB17170630]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB17258688
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
       mov       r11,7FFB16D50630
       call      qword ptr [7FFB17170630]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D50638
       call      qword ptr [7FFB17170638]
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
       mov       r11,7FFB16D50638
       call      qword ptr [7FFB17170638]
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
       mov       rdx,7FFB17258FC8
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
       mov       rdx,7FFB17259258
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
       mov       rdx,7FFB17259668
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7FFB16E40020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L06
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,7FFB172595A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB16E40020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L10
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L10:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,7FFB17259240
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
       mov       rdx,7FFB17259778
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
       mov       rdx,7FFB17259840
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
       mov       rdx,7FFB17259810
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
       mov       rdx,7FFB1723E380
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
       mov       rdx,7FFB172524B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,2097E623060
       mov       r9,[r9]
       mov       r8,2095E621760
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
       mov       rdx,7FFB172528B0
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
       mov       rdx,[rsi+0A0]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17268650
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
       mov       rdx,7FFB172686A0
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
       mov       rdx,7FFB17268660
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
       mov       rdx,7FFB172686B8
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
       mov       rdx,7FFB172686C8
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
       mov       rdx,7FFB17268660
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
       mov       rdx,7FFB17268670
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D60630
       call      qword ptr [7FFB17180630]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB17268688
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
       mov       r11,7FFB16D60630
       call      qword ptr [7FFB17180630]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D60638
       call      qword ptr [7FFB17180638]
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
       mov       r11,7FFB16D60638
       call      qword ptr [7FFB17180638]
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
       mov       rdx,7FFB17268FC8
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
       mov       rdx,7FFB17269258
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
       mov       rdx,7FFB17269668
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7FFB16E50020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L06
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,7FFB172695A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB16E50020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L10
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L10:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,7FFB17269240
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
       mov       rdx,7FFB17269778
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
       mov       rdx,7FFB17269840
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
       mov       rdx,7FFB17269810
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
       mov       rdx,7FFB1724E450
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
       mov       rdx,7FFB172624B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,24DF6B91048
       mov       r9,[r9]
       mov       r8,24E06B91760
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
       mov       rdx,7FFB172628B0
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
       mov       rdx,[rsi+0A0]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17258650
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
       mov       rdx,7FFB172586A0
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
       mov       rdx,7FFB17258660
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
       mov       rdx,7FFB172586B8
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
       mov       rdx,7FFB172586C8
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
       mov       rdx,7FFB17258660
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
       mov       rdx,7FFB17258670
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D40630
       call      qword ptr [7FFB17160630]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB17258688
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
       mov       r11,7FFB16D40630
       call      qword ptr [7FFB17160630]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D40638
       call      qword ptr [7FFB17160638]
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
       mov       r11,7FFB16D40638
       call      qword ptr [7FFB17160638]
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
       mov       rdx,7FFB17258FC8
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
       mov       rdx,7FFB17259258
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
       mov       rdx,7FFB17259668
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7FFB16E30020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L06
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,7FFB172595A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB16E30020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L10
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L10:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,7FFB17259240
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
       mov       rdx,7FFB17259778
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
       mov       rdx,7FFB17259840
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
       mov       rdx,7FFB17259810
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
       mov       rdx,7FFB1722E610
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
       mov       rdx,7FFB172524B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,17E74913060
       mov       r9,[r9]
       mov       r8,17E749227A0
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
       mov       rdx,7FFB172528B0
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
       mov       rdx,[rsi+0A0]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17268650
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
       mov       rdx,7FFB172686A0
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
       mov       rdx,7FFB17268660
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
       mov       rdx,7FFB172686B8
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
       mov       rdx,7FFB172686C8
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
       mov       rdx,7FFB17268660
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
       mov       rdx,7FFB17268670
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D60630
       call      qword ptr [7FFB17180630]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB17268688
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
       mov       r11,7FFB16D60630
       call      qword ptr [7FFB17180630]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D60638
       call      qword ptr [7FFB17180638]
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
       mov       r11,7FFB16D60638
       call      qword ptr [7FFB17180638]
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
       mov       rdx,7FFB17268FC8
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
       mov       rdx,7FFB17269258
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
       mov       rdx,7FFB17269668
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7FFB16E50020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L06
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,7FFB172695A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB16E50020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L10
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L10:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,7FFB17269240
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
       mov       rdx,7FFB17269778
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
       mov       rdx,7FFB17269840
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
       mov       rdx,7FFB17269810
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
       mov       rdx,7FFB1724E450
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
       mov       rdx,7FFB172624B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1DC2CB33060
       mov       r9,[r9]
       mov       r8,1DC2CB33BB0
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
       mov       rdx,7FFB172628B0
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
       mov       rdx,[rsi+0A0]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17248650
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
       mov       rdx,7FFB172486A0
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
       mov       rdx,7FFB17248660
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
       mov       rdx,7FFB172486B8
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
       mov       rdx,7FFB172486C8
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
       mov       rdx,7FFB17248660
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
       mov       rdx,7FFB17248670
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D30630
       call      qword ptr [7FFB17150630]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB17248688
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
       mov       r11,7FFB16D30630
       call      qword ptr [7FFB17150630]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D30638
       call      qword ptr [7FFB17150638]
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
       mov       r11,7FFB16D30638
       call      qword ptr [7FFB17150638]
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
       mov       rdx,7FFB17248FC8
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
       mov       rdx,7FFB17249258
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
       mov       rdx,7FFB17249668
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7FFB16E20020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L06
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,7FFB172495A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB16E20020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L10
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L10:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,7FFB17249240
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
       mov       rdx,7FFB17249778
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
       mov       rdx,7FFB17249840
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
       mov       rdx,7FFB17249810
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
       mov       rdx,7FFB1721E610
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
       mov       rdx,7FFB172424B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1993EFA3060
       mov       r9,[r9]
       mov       r8,1991EFA1760
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
       mov       rdx,7FFB172428B0
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
       mov       rdx,[rsi+0A0]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,[rsi+0A0]
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
       mov       rdx,7FFB17258650
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
       mov       rdx,7FFB172586A0
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
       mov       rdx,7FFB17258660
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
       mov       rdx,7FFB172586B8
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
       mov       rdx,7FFB172586C8
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
       mov       rdx,7FFB17258660
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
       mov       rdx,7FFB17258670
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D40630
       call      qword ptr [7FFB17160630]
       test      eax,eax
       je        short M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFB17258688
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
       mov       r11,7FFB16D40630
       call      qword ptr [7FFB17160630]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFB16D40638
       call      qword ptr [7FFB17160638]
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
       mov       r11,7FFB16D40638
       call      qword ptr [7FFB17160638]
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
       mov       rdx,7FFB17258FC8
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
       mov       rdx,7FFB17259258
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
       mov       rdx,7FFB17259668
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L05:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rcx,7FFB16E30020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L06
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L06:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,7FFB172595A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,7FFB16E30020
       mov       edx,26C
       call      CORINFO_HELP_GETSHARED_GCTHREADSTATIC_BASE
       mov       rcx,[rax+18]
       test      rcx,rcx
       jne       short M02_L10
       call      System.Threading.Thread.InitializeCurrentThread()
       mov       rcx,rax
M02_L10:
       cmp       [rcx],ecx
       call      00007FFB769A2F50
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
       mov       rdx,7FFB17259240
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
       mov       rdx,7FFB17259778
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
       mov       rdx,7FFB17259840
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
       mov       rdx,7FFB17259810
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
       mov       rdx,7FFB1722E610
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
       mov       rdx,7FFB172524B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M04_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1C6A1553060
       mov       r9,[r9]
       mov       r8,1C6C1560350
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
       mov       rdx,7FFB172528B0
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
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.CoordinateProperArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+80]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.CoordinateProperArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+80]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.CoordinateProperArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+80]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.CoordinateProperArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+80]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.CoordinateProperArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+80]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.CoordinateProperArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+80]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.CoordinateProperArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+80]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.CoordinateProperArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+80]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.CoordinateProperArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+80]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+90]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+90]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+90]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+90]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+90]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+90]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+90]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+90]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+90]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.PersonRecordArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0B8]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.PersonRecordArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0B8]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.PersonRecordArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0B8]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.PersonRecordArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0B8]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.PersonRecordArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0B8]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.PersonRecordArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0B8]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.PersonRecordArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0B8]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.PersonRecordArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0B8]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
```

## .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.PersonRecordArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0B8]
       cmp       [rcx],ecx
       call      System.Object.MemberwiseClone()
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 47
```
```assembly
; System.Object.MemberwiseClone()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,rsi
       call      00007FFB76934810
       mov       rdi,rax
       mov       rcx,[rdi]
       mov       rdx,rcx
       mov       r8d,[rdx+4]
       add       r8,0FFFFFFFFFFFFFFF0
       test      dword ptr [rdx],80000000
       je        short M01_L00
       mov       eax,[rdi+8]
       movzx     edx,word ptr [rdx]
       imul      rdx,rax
       add       r8,rdx
M01_L00:
       cmp       [rsi],esi
       lea       rdx,[rsi+8]
       lea       rax,[rdi+8]
       test      dword ptr [rcx],1000000
       je        short M01_L02
       cmp       r8,4000
       ja        short M01_L01
       mov       rcx,rax
       call      00007FFB7698F8B0
       jmp       short M01_L03
M01_L01:
       mov       rcx,rax
       call      System.Buffer._BulkMoveWithWriteBarrier(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       short M01_L03
M01_L02:
       mov       rcx,rax
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M01_L03:
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 120
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
       mov       rdx,[rsi+90]
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
       mov       r8,1FF37EE3060
       mov       r8,[r8]
       mov       rdx,1FF17EE19F0
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
       mov       rdx,7FFB1724E698
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
       mov       rdx,7FFB1742A220
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
       mov       rdx,7FFB1742A230
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
       mov       r8,1FF17EE1788
       mov       r8,[r8]
       mov       r9,1FF37EE3060
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
       mov       rdx,7FFB17386B78
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
       call      qword ptr [7FFB173B6080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,22A83433060
       mov       r8,[r8]
       mov       rdx,22A934311B8
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
       mov       rdx,7FFB1723E698
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
       mov       rdx,7FFB174291C0
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
       mov       rdx,7FFB174291D0
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
       mov       r8,22A63431788
       mov       r8,[r8]
       mov       r9,22A83433060
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
       mov       rdx,7FFB17376B78
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
       call      qword ptr [7FFB173B6080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,12C696D3060
       mov       r8,[r8]
       mov       rdx,12C696E21F8
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
       mov       rdx,7FFB1723E698
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
       mov       rdx,7FFB17428230
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
       mov       rdx,7FFB17428240
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
       mov       r8,12C896D1788
       mov       r8,[r8]
       mov       r9,12C696D3060
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
       mov       rdx,7FFB17376B78
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
       call      qword ptr [7FFB173B6080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,1F7677F3060
       mov       r8,[r8]
       mov       rdx,1F7977F11B8
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
       mov       rdx,7FFB1721E750
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
       mov       rdx,7FFB17408028
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
       mov       rdx,7FFB17408038
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
       mov       r8,1F7877F37A0
       mov       r8,[r8]
       mov       r9,1F7677F3060
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
       mov       rdx,7FFB17356B78
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
       call      qword ptr [7FFB17396080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,17F0F153060
       mov       r8,[r8]
       mov       rdx,17F1F15FDA8
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
       mov       rdx,7FFB1722E9E0
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
       mov       rdx,7FFB17417FC0
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
       mov       rdx,7FFB17417FD0
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
       mov       r8,17F0F153BD8
       mov       r8,[r8]
       mov       r9,17F0F153060
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
       mov       rdx,7FFB17366B78
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
       call      qword ptr [7FFB173A6080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,1B2877E3060
       mov       r8,[r8]
       mov       rdx,1B2B77E11B8
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
       mov       rdx,7FFB1724E750
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
       mov       rdx,7FFB17437FE8
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
       mov       rdx,7FFB17437FF8
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
       mov       r8,1B2877E3BD8
       mov       r8,[r8]
       mov       r9,1B2877E3060
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
       mov       rdx,7FFB17386B90
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
       call      qword ptr [7FFB173C6080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,161FF6D3060
       mov       r8,[r8]
       mov       rdx,1621F6F05F0
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
       mov       rdx,7FFB1724E750
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
       mov       rdx,7FFB17437FC8
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
       mov       rdx,7FFB17437FD8
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
       mov       r8,1620F6E0378
       mov       r8,[r8]
       mov       r9,161FF6D3060
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
       mov       rdx,7FFB17386B90
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
       call      qword ptr [7FFB173C6080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,21765293060
       mov       r8,[r8]
       mov       rdx,217552919F0
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
       mov       rdx,7FFB1723E750
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
       mov       rdx,7FFB17428150
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
       mov       rdx,7FFB17428160
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
       mov       r8,21755291788
       mov       r8,[r8]
       mov       r9,21765293060
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
       mov       rdx,7FFB17376B90
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
       call      qword ptr [7FFB173B6080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,22B1BC53060
       mov       r8,[r8]
       mov       rdx,22B2BC5FDA8
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
       mov       rdx,7FFB1721E9E0
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
       mov       rdx,7FFB17408910
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
       mov       rdx,7FFB17408920
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
       mov       r8,22B0BC51788
       mov       r8,[r8]
       mov       r9,22B1BC53060
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
       mov       rdx,7FFB17356B90
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
       call      qword ptr [7FFB17396080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,2224D3D3060
       mov       r8,[r8]
       mov       rdx,2225D3D1788
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
       mov       rdx,7FFB1723E490
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
       mov       r8,2225D3D1788
       mov       r8,[r8]
       mov       r9,2224D3D3060
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
       mov       rdx,7FFB1723E7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17176080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,1F33A883060
       mov       r8,[r8]
       mov       rdx,1F35A890378
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
       mov       rdx,7FFB1722E490
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
       mov       r8,1F35A890378
       mov       r8,[r8]
       mov       r9,1F33A883060
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
       mov       rdx,7FFB1722E7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17166080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,1EBAA773060
       mov       r8,[r8]
       mov       rdx,1EBAA773BD8
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
       mov       rdx,7FFB1721E490
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
       mov       r8,1EBAA773BD8
       mov       r8,[r8]
       mov       r9,1EBAA773060
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
       mov       rdx,7FFB1721E7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17156080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,2D39BFA3060
       mov       r8,[r8]
       mov       rdx,2D39BFA3BD8
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
       mov       rdx,7FFB1724E490
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
       mov       r8,2D39BFA3BD8
       mov       r8,[r8]
       mov       r9,2D39BFA3060
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
       mov       rdx,7FFB1724E7C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17186080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,210C55A3060
       mov       r8,[r8]
       mov       rdx,210E55AE360
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
       mov       rdx,7FFB1724E618
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
       mov       r8,210E55AE360
       mov       r8,[r8]
       mov       r9,210C55A3060
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
       mov       rdx,7FFB1724E948
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17186080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,2DD2DB73060
       mov       r8,[r8]
       mov       rdx,2DD2DB73BD8
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
       mov       rdx,7FFB1724E548
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
       mov       r8,2DD2DB73BD8
       mov       r8,[r8]
       mov       r9,2DD2DB73060
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
       mov       rdx,7FFB1724E878
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17186080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,164793D3060
       mov       r8,[r8]
       mov       rdx,164993E0378
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
       mov       rdx,7FFB1723E7D8
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
       mov       r8,164993E0378
       mov       r8,[r8]
       mov       r9,164793D3060
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
       mov       rdx,7FFB1723EB08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17176080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,2BADDF33060
       mov       r8,[r8]
       mov       rdx,2BADDF33BD8
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
       mov       rdx,7FFB1721E7D8
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
       mov       r8,2BADDF33BD8
       mov       r8,[r8]
       mov       r9,2BADDF33060
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
       mov       rdx,7FFB1721EB08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17156080]
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
       mov       rdx,[rsi+90]
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
       mov       r8,159F40E3060
       mov       r8,[r8]
       mov       rdx,159D40E1788
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
       mov       rdx,7FFB1723E7D8
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
       mov       r8,159D40E1788
       mov       r8,[r8]
       mov       r9,159F40E3060
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
       mov       rdx,7FFB1723EB08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17176080]
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
       mov       rdx,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+90]
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
       mov       r8,24250F63060
       mov       r8,[r8]
       mov       rdx,24250F727C8
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
       mov       rdx,7FFB1723E420
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
       mov       rdx,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+90]
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
       mov       r8,1DBEBFB3060
       mov       r8,[r8]
       mov       rdx,1DC0BFC0378
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
       mov       rdx,7FFB1722E420
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
       mov       rdx,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+90]
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
       mov       r8,24D54C01048
       mov       r8,[r8]
       mov       rdx,24D54C03BD8
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
       mov       rdx,7FFB1724E420
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
       mov       rdx,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+90]
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
       mov       r8,26E9CFD1048
       mov       r8,[r8]
       mov       rdx,26E7CFD37A0
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
       mov       rdx,7FFB1723E5A8
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
       mov       rdx,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+90]
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
       mov       r8,1C7DB653060
       mov       r8,[r8]
       mov       rdx,1C7FB651788
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
       mov       rdx,7FFB1721E420
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
       mov       rdx,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+90]
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
       mov       r8,218D1AA3060
       mov       r8,[r8]
       mov       rdx,218D1AA5BF0
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
       mov       rdx,7FFB1724E768
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
       mov       rdx,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+90]
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
       mov       r8,27E8CB73060
       mov       r8,[r8]
       mov       rdx,27E5CB71788
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
       mov       rdx,7FFB1724E768
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
       mov       rdx,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+90]
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
       mov       r8,1C3EFEC1048
       mov       r8,[r8]
       mov       rdx,1C3CFEC1788
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
       mov       rdx,7FFB1720E5A8
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
       mov       rdx,[rsi+90]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+90]
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
       mov       r8,164C4C73060
       mov       r8,[r8]
       mov       rdx,164E4C71788
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
       mov       rdx,7FFB1723E768
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
       mov       rdx,[rsi+90]
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
       mov       r8,297A5CF3060
       mov       r8,[r8]
       mov       rdx,297C5D00378
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
       mov       rdx,7FFB1723E410
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
       mov       r8,297A5CF3060
       mov       r8,[r8]
       mov       rdx,297C5D00378
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
       mov       rdx,7FFB1723E8C8
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
       mov       rdx,7FFB1723E8C8
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
       mov       rdx,7FFB1723EE20
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
       mov       rdx,7FFB1723E8C8
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
       mov       rdx,7FFB1723E908
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
       mov       rdx,7FFB1723E8C8
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
       mov       rdx,7FFB1723E8C8
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
       mov       rdx,7FFB1723EC60
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
       mov       rdx,7FFB1723E8C8
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
       mov       rdx,7FFB1723EB20
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
       mov       rdx,[rsi+90]
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
       mov       r8,20F29ED3060
       mov       r8,[r8]
       mov       rdx,20F49ED1788
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
       mov       rdx,7FFB1724E410
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
       mov       r8,20F29ED3060
       mov       r8,[r8]
       mov       rdx,20F49ED1788
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
       mov       rdx,7FFB1724E8C8
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
       mov       rdx,7FFB1724E8C8
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
       mov       rdx,7FFB1724EE20
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
       mov       rdx,7FFB1724E8C8
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
       mov       rdx,7FFB1724E908
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
       mov       rdx,7FFB1724E8C8
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
       mov       rdx,7FFB1724E8C8
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
       mov       rdx,7FFB1724EC60
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
       mov       rdx,7FFB1724E8C8
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
       mov       rdx,7FFB1724EB20
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
       mov       rdx,[rsi+90]
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
       mov       r8,2476C613060
       mov       r8,[r8]
       mov       rdx,2477C611788
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
       mov       rdx,7FFB1724E410
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
       mov       r8,2476C613060
       mov       r8,[r8]
       mov       rdx,2477C611788
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
       mov       rdx,7FFB1724E8C8
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
       mov       rdx,7FFB1724E8C8
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
       mov       rdx,7FFB1724EE20
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
       mov       rdx,7FFB1724E8C8
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
       mov       rdx,7FFB1724E908
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
       mov       rdx,7FFB1724E8C8
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
       mov       rdx,7FFB1724E8C8
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
       mov       rdx,7FFB1724EC60
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
       mov       rdx,7FFB1724E8C8
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
       mov       rdx,7FFB1724EB20
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
       mov       rdx,[rsi+90]
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
       mov       r8,263E4341048
       mov       r8,[r8]
       mov       rdx,263E43507B0
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
       mov       rdx,7FFB1723E598
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
       mov       r8,263E4341048
       mov       r8,[r8]
       mov       rdx,263E43507B0
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
       mov       rdx,7FFB1723EA50
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
       mov       rdx,7FFB1723EA50
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
       mov       rdx,7FFB1723EFA8
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
       mov       rdx,7FFB1723EA50
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
       mov       rdx,7FFB1723EA90
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
       mov       rdx,7FFB1723EA50
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
       mov       rdx,7FFB1723EA50
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
       mov       rdx,7FFB1723EDE8
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
       mov       rdx,7FFB1723EA50
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
       mov       rdx,7FFB1723ECA8
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
       mov       rdx,[rsi+90]
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
       mov       r8,22CDC6B3060
       mov       r8,[r8]
       mov       rdx,22CBC6B1788
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
       mov       rdx,7FFB1722E758
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
       mov       r8,22CDC6B3060
       mov       r8,[r8]
       mov       rdx,22CBC6B1788
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
       mov       rdx,7FFB1722EC10
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
       mov       rdx,7FFB1722EC10
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
       mov       rdx,7FFB1722F168
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
       mov       rdx,7FFB1722EC10
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
       mov       rdx,7FFB1722EC50
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
       mov       rdx,7FFB1722EC10
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
       mov       rdx,7FFB1722EC10
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
       mov       rdx,7FFB1722EFA8
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
       mov       rdx,7FFB1722EC10
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
       mov       rdx,7FFB1722EE68
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
       mov       rdx,[rsi+90]
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
       mov       r8,286988C1048
       mov       r8,[r8]
       mov       rdx,286788C37A0
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
       mov       rdx,7FFB1722E410
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
       mov       r8,286988C1048
       mov       r8,[r8]
       mov       rdx,286788C37A0
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
       mov       rdx,7FFB1722E8C8
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
       mov       rdx,7FFB1722E8C8
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
       mov       rdx,7FFB1722EE20
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
       mov       rdx,7FFB1722E8C8
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
       mov       rdx,7FFB1722E908
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
       mov       rdx,7FFB1722E8C8
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
       mov       rdx,7FFB1722E8C8
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
       mov       rdx,7FFB1722EC60
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
       mov       rdx,7FFB1722E8C8
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
       mov       rdx,7FFB1722EB20
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
       mov       rdx,[rsi+90]
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
       mov       r8,1C28A493060
       mov       r8,[r8]
       mov       rdx,1C28A493BD8
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
       mov       rdx,7FFB1724E758
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
       mov       r8,1C28A493060
       mov       r8,[r8]
       mov       rdx,1C28A493BD8
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
       mov       rdx,7FFB1724EC10
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
       mov       rdx,7FFB1724EC10
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
       mov       rdx,7FFB1724F168
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
       mov       rdx,7FFB1724EC10
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
       mov       rdx,7FFB1724EC50
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
       mov       rdx,7FFB1724EC10
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
       mov       rdx,7FFB1724EC10
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
       mov       rdx,7FFB1724EFA8
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
       mov       rdx,7FFB1724EC10
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
       mov       rdx,7FFB1724EE68
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
       mov       rdx,[rsi+90]
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
       mov       r8,15E411C3060
       mov       r8,[r8]
       mov       rdx,15E511C1788
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
       mov       rdx,7FFB1721E758
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
       mov       r8,15E411C3060
       mov       r8,[r8]
       mov       rdx,15E511C1788
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
       mov       rdx,7FFB1721EC10
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
       mov       rdx,7FFB1721EC10
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
       mov       rdx,7FFB1721F168
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
       mov       rdx,7FFB1721EC10
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
       mov       rdx,7FFB1721EC50
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
       mov       rdx,7FFB1721EC10
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
       mov       rdx,7FFB1721EC10
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
       mov       rdx,7FFB1721EFA8
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
       mov       rdx,7FFB1721EC10
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
       mov       rdx,7FFB1721EE68
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
       mov       rdx,[rsi+90]
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
       mov       r8,1FA30261048
       mov       r8,[r8]
       mov       rdx,1FA20261788
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
       mov       rdx,7FFB1723E598
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
       mov       r8,1FA30261048
       mov       r8,[r8]
       mov       rdx,1FA20261788
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
       mov       rdx,7FFB1723EA50
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
       mov       rdx,7FFB1723EA50
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
       mov       rdx,7FFB1723EFA8
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
       mov       rdx,7FFB1723EA50
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
       mov       rdx,7FFB1723EA90
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
       mov       rdx,7FFB1723EA50
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
       mov       rdx,7FFB1723EA50
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
       mov       rdx,7FFB1723EDE8
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
       mov       rdx,7FFB1723EA50
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
       mov       rdx,7FFB1723ECA8
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
       mov       rcx,[rsi+70]
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
       mov       r8,23C44E13060
       mov       r8,[r8]
       mov       rdx,23C54E20378
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,23C44E11528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,23C64E111B8
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
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB17169498]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 203
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
       mov       rcx,[rsi+70]
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
       mov       r8,1DBF8FE3060
       mov       r8,[r8]
       mov       rdx,1DBE8FE1788
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,1DBF8FE1528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1DBE8FE19F0
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
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB17159498]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 203
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
       mov       rcx,[rsi+70]
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
       mov       r8,27AD43A3060
       mov       r8,[r8]
       mov       rdx,27AF43A37A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,27AD43A1528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,27AE43ADD90
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
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB17149498]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 203
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
       mov       rcx,[rsi+70]
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
       mov       r8,1B4BCD83060
       mov       r8,[r8]
       mov       rdx,1B4BCD83BD8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,1B4BCD81528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1B4DCD8FDA8
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
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB17149498]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 203
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
       mov       rcx,[rsi+70]
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
       mov       r8,1BAB8843060
       mov       r8,[r8]
       mov       rdx,1BAD88437A0
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,1BAB8841528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1BAE88411B8
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
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB17149498]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 203
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
       mov       rcx,[rsi+70]
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
       mov       r8,20AE7121048
       mov       r8,[r8]
       mov       rdx,20AC7121788
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,20AD7121528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,20AC71219F0
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
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB17159498]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 203
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
       mov       rcx,[rsi+70]
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
       mov       r8,172FF4F3060
       mov       r8,[r8]
       mov       rdx,172FF5027C8
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,172FF4F1528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,172DF4F11B8
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
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB17179498]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 203
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
       mov       rcx,[rsi+70]
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
       mov       r8,1A8BCA33060
       mov       r8,[r8]
       mov       rdx,1A8CCA31788
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,1A8BCA31528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1A8CCA319F0
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
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB17149498]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 203
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
       mov       rcx,[rsi+70]
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
       mov       r8,233B7B23060
       mov       r8,[r8]
       mov       rdx,233A7B21788
       mov       rdx,[rdx]
       mov       rcx,rsi
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam(System.Collections.IEnumerable, System.String, System.String)
       mov       rcx,offset MT_System.Text.StringBuilder
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+20],7FFFFFFF
       mov       rcx,offset MT_System.Char[]
       mov       edx,10
       call      CORINFO_HELP_NEWARR_1_VC
       lea       rcx,[rdi+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       xor       ebx,ebx
       mov       ebp,[rsi+8]
       test      ebp,ebp
       jle       short M01_L03
M01_L00:
       movsxd    rcx,ebx
       lea       rcx,[rsi+rcx+10]
       mov       rax,233B7B21528
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,233A7B219F0
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
       call      System.Text.StringBuilder.Append(System.String)
       inc       ebx
       cmp       ebp,ebx
       jg        short M01_L00
M01_L03:
       mov       rcx,rdi
       mov       rax,[7FFB17149498]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 203
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
       mov       rdx,[rsi+90]
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
       mov       rdi,[rsi+90]
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
       mov       r8,1AF6E3F3060
       mov       r8,[r8]
       mov       rdx,1AF6E4027C8
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
       mov       rdx,7FFB1722E4A8
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
       mov       r8,1AF6E4027C8
       mov       r8,[r8]
       mov       r9,1AF6E3F3060
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
       mov       rdx,7FFB1722E7D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17166080]
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
       mov       rdx,7FFB17253E00
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
       mov       rdx,7FFB17253EC8
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
       mov       rdx,7FFB17253E98
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
       mov       rdx,7FFB1722EBA8
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
       mov       rdx,7FFB1722F8A0
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
       mov       rdx,7FFB1722F8A0
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
       mov       rdx,7FFB1722FB98
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
       mov       rdx,7FFB1722FBD8
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
       mov       rdx,[rsi+90]
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
       mov       rdi,[rsi+90]
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
       mov       r8,2066B723060
       mov       r8,[r8]
       mov       rdx,2068B730378
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
       mov       rdx,7FFB1722E4A8
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
       mov       r8,2068B730378
       mov       r8,[r8]
       mov       r9,2066B723060
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
       mov       rdx,7FFB1722E7D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17166080]
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
       mov       rdx,7FFB17253E00
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
       mov       rdx,7FFB17253EC8
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
       mov       rdx,7FFB17253E98
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
       mov       rdx,7FFB1722EBA8
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
       mov       rdx,7FFB1722F8A0
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
       mov       rdx,7FFB1722F8A0
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
       mov       rdx,7FFB1722FB98
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
       mov       rdx,7FFB1722FBD8
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
       mov       rdx,[rsi+90]
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
       mov       rdi,[rsi+90]
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
       mov       r8,21A50933060
       mov       r8,[r8]
       mov       rdx,21A50933BD8
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
       mov       rdx,7FFB1723E4A8
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
       mov       r8,21A50933BD8
       mov       r8,[r8]
       mov       r9,21A50933060
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
       mov       rdx,7FFB1723E7D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17176080]
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
       mov       rdx,7FFB17263E00
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
       mov       rdx,7FFB17263EC8
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
       mov       rdx,7FFB17263E98
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
       mov       rdx,7FFB1723EBA8
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
       mov       rdx,7FFB1723F8A0
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
       mov       rdx,7FFB1723F8A0
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
       mov       rdx,7FFB1723FB98
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
       mov       rdx,7FFB1723FBD8
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
       mov       rdx,[rsi+90]
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
       mov       rdi,[rsi+90]
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
       mov       r8,15857513060
       mov       r8,[r8]
       mov       rdx,15867520378
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
       mov       rdx,7FFB1721E630
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
       mov       r8,15867520378
       mov       r8,[r8]
       mov       r9,15857513060
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
       mov       rdx,7FFB1721E960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17156080]
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
       mov       rdx,7FFB17243F50
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
       mov       rdx,7FFB17244018
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
       mov       rdx,7FFB17243FE8
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
       mov       rdx,7FFB1721ED30
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
       mov       rdx,7FFB1721FA28
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
       mov       rdx,7FFB1721FA28
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
       mov       rdx,7FFB1721FD20
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
       mov       rdx,7FFB1721FD60
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
       mov       rdx,[rsi+90]
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
       mov       rdi,[rsi+90]
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
       mov       r8,1F87C0C1048
       mov       r8,[r8]
       mov       rdx,1F85C0C1788
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
       mov       rdx,7FFB1723E630
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
       mov       r8,1F85C0C1788
       mov       r8,[r8]
       mov       r9,1F87C0C1048
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
       mov       rdx,7FFB1723E960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17176080]
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
       mov       rdx,7FFB17263F50
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
       mov       rdx,7FFB17264018
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
       mov       rdx,7FFB17263FE8
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
       mov       rdx,7FFB1723ED30
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
       mov       rdx,7FFB1723FA28
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
       mov       rdx,7FFB1723FA28
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
       mov       rdx,7FFB1723FD20
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
       mov       rdx,7FFB1723FD60
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
       mov       rdx,[rsi+90]
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
       mov       rdi,[rsi+90]
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
       mov       r8,1D276633060
       mov       r8,[r8]
       mov       rdx,1D286640378
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
       mov       rdx,7FFB1722E7F0
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
       mov       r8,1D286640378
       mov       r8,[r8]
       mov       r9,1D276633060
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
       mov       rdx,7FFB1722EB20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17166080]
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
       mov       rdx,7FFB17254108
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
       mov       rdx,7FFB172541D0
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
       mov       rdx,7FFB172541A0
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
       mov       rdx,7FFB1722EEF0
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
       mov       rdx,7FFB1722FBE8
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
       mov       rdx,7FFB1722FBE8
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
       mov       rdx,7FFB1722FEE0
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
       mov       rdx,7FFB1722FF20
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
       mov       rdx,[rsi+90]
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
       mov       rdi,[rsi+90]
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
       mov       r8,16462D93060
       mov       r8,[r8]
       mov       rdx,16472DA0378
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
       mov       rdx,7FFB1723E7F0
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
       mov       r8,16472DA0378
       mov       r8,[r8]
       mov       r9,16462D93060
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
       mov       rdx,7FFB1723EB20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17176080]
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
       mov       rdx,7FFB17264108
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
       mov       rdx,7FFB172641D0
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
       mov       rdx,7FFB172641A0
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
       mov       rdx,7FFB1723EEF0
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
       mov       rdx,7FFB1723FBE8
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
       mov       rdx,7FFB1723FBE8
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
       mov       rdx,7FFB1723FEE0
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
       mov       rdx,7FFB1723FF20
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
       mov       rdx,[rsi+90]
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
       mov       rdi,[rsi+90]
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
       mov       r8,248E4223060
       mov       r8,[r8]
       mov       rdx,248C4221788
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
       mov       rdx,7FFB1724E560
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
       mov       r8,248C4221788
       mov       r8,[r8]
       mov       r9,248E4223060
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
       mov       rdx,7FFB1724E890
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17186080]
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
       mov       rdx,7FFB17273EC0
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
       mov       rdx,7FFB17273F88
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
       mov       rdx,7FFB17273F58
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
       mov       rdx,7FFB1724EC60
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
       mov       rdx,7FFB1724F958
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
       mov       rdx,7FFB1724F958
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
       mov       rdx,7FFB1724FC50
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
       mov       rdx,7FFB1724FC90
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
       mov       rdx,[rsi+90]
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
       mov       rdi,[rsi+90]
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
       mov       r8,1AA09473060
       mov       r8,[r8]
       mov       rdx,1A9E9471788
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
       mov       rdx,7FFB1721E4A8
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
       mov       r8,1A9E9471788
       mov       r8,[r8]
       mov       r9,1AA09473060
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
       mov       rdx,7FFB1721E7D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFB17156080]
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
       mov       rdx,7FFB172429C0
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
       mov       rdx,7FFB17242A88
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
       mov       rdx,7FFB17242A58
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
       mov       rdx,7FFB1721EBA8
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
       mov       rdx,7FFB1721F8A0
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
       mov       rdx,7FFB1721F8A0
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
       mov       rdx,7FFB1721FB98
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
       mov       rdx,7FFB1721FBD8
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
       mov       rdx,[rsi+90]
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
       mov       r8,135805D3060
       mov       r8,[r8]
       mov       rdx,135705DE360
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
       mov       rdx,7FFB1722E478
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
       mov       r8,135805D3060
       mov       r8,[r8]
       mov       rdx,135705DE360
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
       mov       rdx,7FFB1722E6A8
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
       mov       rdx,[rsi+90]
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
       mov       r8,24AA68F1048
       mov       r8,[r8]
       mov       rdx,24AC68F1788
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
       mov       rdx,7FFB1721E478
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
       mov       r8,24AA68F1048
       mov       r8,[r8]
       mov       rdx,24AC68F1788
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
       mov       rdx,7FFB1721E6A8
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
       mov       rdx,[rsi+90]
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
       mov       r8,2B9D6993060
       mov       r8,[r8]
       mov       rdx,2B9E69A0378
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
       mov       rdx,7FFB1723E530
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
       mov       r8,2B9D6993060
       mov       r8,[r8]
       mov       rdx,2B9E69A0378
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
       mov       rdx,7FFB1723E760
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
       mov       rdx,[rsi+90]
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
       mov       r8,2052D423060
       mov       r8,[r8]
       mov       rdx,2051D42E360
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
       mov       rdx,7FFB1724E478
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
       mov       r8,2052D423060
       mov       r8,[r8]
       mov       rdx,2051D42E360
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
       mov       rdx,7FFB1724E6A8
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
       mov       rdx,[rsi+90]
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
       mov       r8,1BF855B1048
       mov       r8,[r8]
       mov       rdx,1BF855C07B0
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
       mov       rdx,7FFB1723E600
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
       mov       r8,1BF855B1048
       mov       r8,[r8]
       mov       rdx,1BF855C07B0
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
       mov       rdx,7FFB1723E830
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
       mov       rdx,[rsi+90]
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
       mov       r8,1D459AB3060
       mov       r8,[r8]
       mov       rdx,1D439AB1788
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
       mov       rdx,7FFB1722E7C0
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
       mov       r8,1D459AB3060
       mov       r8,[r8]
       mov       rdx,1D439AB1788
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
       mov       rdx,7FFB1722E9F0
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
       mov       rdx,[rsi+90]
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
       mov       r8,200E3633060
       mov       r8,[r8]
       mov       rdx,200E3635BF0
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
       mov       rdx,7FFB1724E7C0
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
       mov       r8,200E3633060
       mov       r8,[r8]
       mov       rdx,200E3635BF0
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
       mov       rdx,7FFB1724E9F0
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
       mov       rdx,[rsi+90]
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
       mov       r8,1EB456F3060
       mov       r8,[r8]
       mov       rdx,1EB456F3BD8
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
       mov       rdx,7FFB1724E7C0
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
       mov       r8,1EB456F3060
       mov       r8,[r8]
       mov       rdx,1EB456F3BD8
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
       mov       rdx,7FFB1724E9F0
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
       mov       rdx,[rsi+90]
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
       mov       r8,1CBF05C3060
       mov       r8,[r8]
       mov       rdx,1CC205C1788
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
       mov       rdx,7FFB1721E478
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
       mov       r8,1CBF05C3060
       mov       r8,[r8]
       mov       rdx,1CC205C1788
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
       mov       rdx,7FFB1721E6A8
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
       mov       rdx,[rsi+90]
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
       mov       r8,209F25B3060
       mov       r8,[r8]
       mov       rdx,209F25C27C8
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
       mov       rdx,7FFB1724E478
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
       mov       r8,209F25B3060
       mov       r8,[r8]
       mov       rdx,209F25C27C8
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
       mov       rdx,7FFB1724E6A8
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
       mov       rdx,[rsi+90]
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
       mov       r8,18BF1713060
       mov       r8,[r8]
       mov       rdx,18C01720378
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
       mov       rdx,7FFB1721E478
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
       mov       r8,18BF1713060
       mov       r8,[r8]
       mov       rdx,18C01720378
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
       mov       rdx,7FFB1721E6A8
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
       mov       rdx,[rsi+90]
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
       mov       r8,211AD481048
       mov       r8,[r8]
       mov       rdx,211AD4907B0
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
       mov       rdx,7FFB1724E478
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
       mov       r8,211AD481048
       mov       r8,[r8]
       mov       rdx,211AD4907B0
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
       mov       rdx,7FFB1724E6A8
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
       mov       rdx,[rsi+90]
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
       mov       r8,225105E3060
       mov       r8,[r8]
       mov       rdx,225105E5BF0
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
       mov       rdx,7FFB1722E478
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
       mov       r8,225105E3060
       mov       r8,[r8]
       mov       rdx,225105E5BF0
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
       mov       rdx,7FFB1722E6A8
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
       mov       rdx,[rsi+90]
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
       mov       r8,26D5DD53060
       mov       r8,[r8]
       mov       rdx,26D6DD51788
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
       mov       rdx,7FFB1721E7C0
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
       mov       r8,26D5DD53060
       mov       r8,[r8]
       mov       rdx,26D6DD51788
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
       mov       rdx,7FFB1721E9F0
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
       mov       rdx,[rsi+90]
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
       mov       r8,155871B3060
       mov       r8,[r8]
       mov       rdx,155871B3BD8
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
       mov       rdx,7FFB1720E600
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
       mov       r8,155871B3060
       mov       r8,[r8]
       mov       rdx,155871B3BD8
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
       mov       rdx,7FFB1720E830
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
       mov       rdx,[rsi+90]
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
       mov       r8,2259C343060
       mov       r8,[r8]
       mov       rdx,225AC341788
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
       mov       rdx,7FFB1721E7C0
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
       mov       r8,2259C343060
       mov       r8,[r8]
       mov       rdx,225AC341788
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
       mov       rdx,7FFB1721E9F0
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
       mov       rdx,[rsi+90]
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
       mov       r8,21D55703060
       mov       r8,[r8]
       mov       rdx,21D65710378
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
       mov       rdx,7FFB1721E7C0
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
       mov       r8,21D55703060
       mov       r8,[r8]
       mov       rdx,21D65710378
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
       mov       rdx,7FFB1721E9F0
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
       mov       rdx,[rsi+90]
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
       mov       r8,228BA483060
       mov       r8,[r8]
       mov       rdx,228CA490378
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
       mov       rdx,7FFB1723E478
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
       mov       r8,228BA483060
       mov       r8,[r8]
       mov       rdx,228CA490378
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
       mov       rdx,7FFB1723E6A8
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

