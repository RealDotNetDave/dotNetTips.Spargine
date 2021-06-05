## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+160]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 90
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
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA7F099DD8
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
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA7F099E28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFA7F099DE8
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
       mov       rdx,[rbx+90]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFA7F099E40
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
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFA7F099E50
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
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA7F099DE8
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
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFA7F099DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB606C8
       call      qword ptr [7FFA7EF706C8]
       test      eax,eax
       je        near ptr M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFA7F099E10
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
       mov       r11,7FFA7EB606C8
       call      qword ptr [7FFA7EF706C8]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB606D0
       call      qword ptr [7FFA7EF706D0]
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
       mov       r11,7FFA7EB606D0
       call      qword ptr [7FFA7EF706D0]
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
; Total bytes of code 733
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
       je        short M02_L00
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
M02_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFA7F0908E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L02:
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
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F0945A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1810C5D3020
       mov       r9,[r9]
       mov       r8,180FC5D1798
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M02_L09
M02_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M02_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFA7F0949A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M02_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M02_L05
M02_L09:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+160]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 90
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
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA7F08A290
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
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA7F08A2E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFA7F08A2A0
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
       mov       rdx,[rbx+90]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFA7F08A2F8
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
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFA7F08A308
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
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA7F08A2A0
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
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFA7F08A2B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB506C8
       call      qword ptr [7FFA7EF606C8]
       test      eax,eax
       je        near ptr M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFA7F08A2C8
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
       mov       r11,7FFA7EB506C8
       call      qword ptr [7FFA7EF606C8]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB506D0
       call      qword ptr [7FFA7EF606D0]
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
       mov       r11,7FFA7EB506D0
       call      qword ptr [7FFA7EF606D0]
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
; Total bytes of code 733
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
       je        short M02_L00
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
M02_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFA7F080D98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L02:
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
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F084A60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1D340831028
       mov       r9,[r9]
       mov       r8,1D320833790
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M02_L09
M02_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M02_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFA7F084E60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M02_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M02_L05
M02_L09:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+160]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 90
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
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA7F08A340
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
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA7F08A390
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFA7F08A350
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
       mov       rdx,[rbx+90]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFA7F08A3A8
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
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFA7F08A3B8
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
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA7F08A350
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
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFA7F08A360
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB506D0
       call      qword ptr [7FFA7EF606D0]
       test      eax,eax
       je        near ptr M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFA7F08A378
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
       mov       r11,7FFA7EB506D0
       call      qword ptr [7FFA7EF606D0]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB506D8
       call      qword ptr [7FFA7EF606D8]
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
       mov       r11,7FFA7EB506D8
       call      qword ptr [7FFA7EF606D8]
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
; Total bytes of code 733
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
       je        short M02_L00
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
M02_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFA7F080DF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L02:
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
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F084AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1E20C443020
       mov       r9,[r9]
       mov       r8,1E1EC44D708
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M02_L09
M02_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M02_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFA7F084EB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M02_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M02_L05
M02_L09:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+160]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 90
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
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA7F0CA2F0
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
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA7F0CA340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFA7F0CA300
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
       mov       rdx,[rbx+90]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFA7F0CA358
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
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFA7F0CA368
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
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA7F0CA300
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
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFA7F0CA310
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB906C8
       call      qword ptr [7FFA7EFA06C8]
       test      eax,eax
       je        near ptr M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFA7F0CA328
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
       mov       r11,7FFA7EB906C8
       call      qword ptr [7FFA7EFA06C8]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB906D0
       call      qword ptr [7FFA7EFA06D0]
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
       mov       r11,7FFA7EB906D0
       call      qword ptr [7FFA7EFA06D0]
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
; Total bytes of code 733
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
       je        short M02_L00
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
M02_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C0DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L02:
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
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C4AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1A5B3BD3020
       mov       r9,[r9]
       mov       r8,1A5A3BDD708
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M02_L09
M02_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M02_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C4EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M02_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M02_L05
M02_L09:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+160]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 90
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
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA7F09A2E8
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
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA7F09A338
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFA7F09A2F8
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
       mov       rdx,[rbx+90]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFA7F09A350
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
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFA7F09A360
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
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA7F09A2F8
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
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFA7F09A308
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB606C8
       call      qword ptr [7FFA7EF706C8]
       test      eax,eax
       je        near ptr M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFA7F09A320
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
       mov       r11,7FFA7EB606C8
       call      qword ptr [7FFA7EF706C8]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB606D0
       call      qword ptr [7FFA7EF706D0]
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
       mov       r11,7FFA7EB606D0
       call      qword ptr [7FFA7EF706D0]
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
; Total bytes of code 733
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
       je        short M02_L00
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
M02_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFA7F090DF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L02:
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
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F094AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,25C02ED3020
       mov       r9,[r9]
       mov       r8,25BF2ED1798
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M02_L09
M02_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M02_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFA7F094EB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M02_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M02_L05
M02_L09:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+160]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 90
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
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA7F0CA2F0
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
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA7F0CA340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFA7F0CA300
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
       mov       rdx,[rbx+90]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFA7F0CA358
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
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFA7F0CA368
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
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA7F0CA300
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
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFA7F0CA310
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB906C8
       call      qword ptr [7FFA7EFA06C8]
       test      eax,eax
       je        near ptr M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFA7F0CA328
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
       mov       r11,7FFA7EB906C8
       call      qword ptr [7FFA7EFA06C8]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB906D0
       call      qword ptr [7FFA7EFA06D0]
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
       mov       r11,7FFA7EB906D0
       call      qword ptr [7FFA7EFA06D0]
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
; Total bytes of code 733
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
       je        short M02_L00
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
M02_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C0DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L02:
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
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C4AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,24C6D2E1028
       mov       r9,[r9]
       mov       r8,24C4D2E3790
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M02_L09
M02_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M02_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C4EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M02_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M02_L05
M02_L09:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists02()
; 			var people = new List<PersonProper>(base.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+160]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 90
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
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA7F08A4C0
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
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA7F08A510
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFA7F08A4D0
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
       mov       rdx,[rbx+90]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFA7F08A528
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
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFA7F08A538
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
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA7F08A4D0
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
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFA7F08A4E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB506D0
       call      qword ptr [7FFA7EF606D0]
       test      eax,eax
       je        near ptr M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFA7F08A4F8
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
       mov       r11,7FFA7EB506D0
       call      qword ptr [7FFA7EF606D0]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB506D8
       call      qword ptr [7FFA7EF606D8]
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
       mov       r11,7FFA7EB506D8
       call      qword ptr [7FFA7EF606D8]
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
; Total bytes of code 733
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
       je        short M02_L00
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
M02_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFA7F080DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L02:
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
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F084AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,14022E63020
       mov       r9,[r9]
       mov       r8,14002E61798
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M02_L09
M02_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M02_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFA7F084EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M02_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M02_L05
M02_L09:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+160]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 90
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
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA7F0B9DD8
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
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA7F0B9E28
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFA7F0B9DE8
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
       mov       rdx,[rbx+90]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFA7F0B9E40
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
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFA7F0B9E50
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
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA7F0B9DE8
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
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFA7F0B9DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB806C8
       call      qword ptr [7FFA7EF906C8]
       test      eax,eax
       je        near ptr M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFA7F0B9E10
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
       mov       r11,7FFA7EB806C8
       call      qword ptr [7FFA7EF906C8]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB806D0
       call      qword ptr [7FFA7EF906D0]
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
       mov       r11,7FFA7EB806D0
       call      qword ptr [7FFA7EF906D0]
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
; Total bytes of code 733
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
       je        short M02_L00
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
M02_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B08E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L02:
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
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B45A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,2A99E463020
       mov       r9,[r9]
       mov       r8,2A9BE46F700
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M02_L09
M02_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M02_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFA7F0B49A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M02_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M02_L05
M02_L09:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+160]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 90
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
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA7F0AA290
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
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA7F0AA2E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFA7F0AA2A0
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
       mov       rdx,[rbx+90]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFA7F0AA2F8
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
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFA7F0AA308
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
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA7F0AA2A0
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
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFA7F0AA2B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB706C8
       call      qword ptr [7FFA7EF806C8]
       test      eax,eax
       je        near ptr M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFA7F0AA2C8
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
       mov       r11,7FFA7EB706C8
       call      qword ptr [7FFA7EF806C8]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB706D0
       call      qword ptr [7FFA7EF806D0]
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
       mov       r11,7FFA7EB706D0
       call      qword ptr [7FFA7EF806D0]
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
; Total bytes of code 733
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
       je        short M02_L00
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
M02_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A0D98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L02:
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
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A4A60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,2491F7E1028
       mov       r9,[r9]
       mov       r8,2491F7EFB18
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M02_L09
M02_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M02_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A4E60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M02_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M02_L05
M02_L09:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+160]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 90
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
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA7F0AA2A8
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
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA7F0AA2F8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFA7F0AA2B8
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
       mov       rdx,[rbx+90]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFA7F0AA310
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
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFA7F0AA320
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
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA7F0AA2B8
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
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFA7F0AA2C8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB706C8
       call      qword ptr [7FFA7EF806C8]
       test      eax,eax
       je        near ptr M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFA7F0AA2E0
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
       mov       r11,7FFA7EB706C8
       call      qword ptr [7FFA7EF806C8]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB706D0
       call      qword ptr [7FFA7EF806D0]
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
       mov       r11,7FFA7EB706D0
       call      qword ptr [7FFA7EF806D0]
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
; Total bytes of code 733
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
       je        short M02_L00
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
M02_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A0DB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L02:
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
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A4A78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,26E1A423020
       mov       r9,[r9]
       mov       r8,26E1A425BA0
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M02_L09
M02_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M02_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A4E78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M02_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M02_L05
M02_L09:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+160]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 90
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
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA7F09A468
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
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA7F09A4B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFA7F09A478
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
       mov       rdx,[rbx+90]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFA7F09A4D0
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
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFA7F09A4E0
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
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA7F09A478
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
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFA7F09A488
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB606C8
       call      qword ptr [7FFA7EF706C8]
       test      eax,eax
       je        near ptr M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFA7F09A4A0
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
       mov       r11,7FFA7EB606C8
       call      qword ptr [7FFA7EF706C8]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB606D0
       call      qword ptr [7FFA7EF706D0]
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
       mov       r11,7FFA7EB606D0
       call      qword ptr [7FFA7EF706D0]
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
; Total bytes of code 733
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
       je        short M02_L00
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
M02_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFA7F090DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L02:
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
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F094AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1BBE93F3020
       mov       r9,[r9]
       mov       r8,1BBE9401B10
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M02_L09
M02_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M02_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFA7F094EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M02_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M02_L05
M02_L09:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+160]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 90
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
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA7F0CA268
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
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA7F0CA2B8
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFA7F0CA278
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
       mov       rdx,[rbx+90]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFA7F0CA2D0
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
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFA7F0CA2E0
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
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA7F0CA278
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
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFA7F0CA288
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB906C8
       call      qword ptr [7FFA7EFA06C8]
       test      eax,eax
       je        near ptr M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFA7F0CA2A0
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
       mov       r11,7FFA7EB906C8
       call      qword ptr [7FFA7EFA06C8]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB906D0
       call      qword ptr [7FFA7EFA06D0]
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
       mov       r11,7FFA7EB906D0
       call      qword ptr [7FFA7EFA06D0]
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
; Total bytes of code 733
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
       je        short M02_L00
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
M02_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C0D70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L02:
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
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C4A38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,2BE96421028
       mov       r9,[r9]
       mov       r8,2BE76423790
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M02_L09
M02_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M02_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C4E38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M02_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M02_L05
M02_L09:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+160]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 90
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
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA7F0AA2F0
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
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA7F0AA340
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFA7F0AA300
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
       mov       rdx,[rbx+90]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFA7F0AA358
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
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFA7F0AA368
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
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA7F0AA300
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
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFA7F0AA310
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB706C8
       call      qword ptr [7FFA7EF806C8]
       test      eax,eax
       je        near ptr M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFA7F0AA328
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
       mov       r11,7FFA7EB706C8
       call      qword ptr [7FFA7EF806C8]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB706D0
       call      qword ptr [7FFA7EF806D0]
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
       mov       r11,7FFA7EB706D0
       call      qword ptr [7FFA7EF806D0]
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
; Total bytes of code 733
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
       je        short M02_L00
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
M02_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A0DF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L02:
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
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A4AC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1D544F01028
       mov       r9,[r9]
       mov       r8,1D554F0F700
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M02_L09
M02_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M02_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFA7F0A4EC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M02_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M02_L05
M02_L09:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddIfNotExists01()
; 			var people = new List<PersonProper>(base.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddIfNotExists(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,[rsi+160]
       mov       rcx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 90
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
       mov       rdx,[rbx+68]
       test      rdx,rdx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rdx,7FFA7F0CA290
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
       mov       r11,[rbx+88]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rdx,7FFA7F0CA2E0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L03:
       mov       rcx,r14
       call      qword ptr [r11]
       mov       esi,eax
       test      esi,esi
       jne       short M01_L06
       mov       rcx,rdi
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rdx,7FFA7F0CA2A0
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
       mov       rdx,[rbx+90]
       test      rdx,rdx
       je        short M01_L07
       mov       [rbp+0FFC8],rdx
       jmp       short M01_L08
M01_L07:
       mov       rdx,7FFA7F0CA2F8
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
       mov       r11,[rbx+98]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rdx,7FFA7F0CA308
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
       mov       rdx,[rbx+70]
       test      rdx,rdx
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rdx,7FFA7F0CA2A0
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
       mov       r11,[rbx+78]
       test      r11,r11
       je        short M01_L14
       jmp       short M01_L15
M01_L14:
       mov       rdx,7FFA7F0CA2B0
       call      CORINFO_HELP_RUNTIMEHANDLE_CLASS
       mov       r11,rax
M01_L15:
       mov       rcx,rsi
       call      qword ptr [r11]
       mov       [rbp+0FFC0],rax
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB906C8
       call      qword ptr [7FFA7EFA06C8]
       test      eax,eax
       je        near ptr M01_L21
M01_L16:
       mov       rcx,rdi
       mov       r11,[rbx+80]
       test      r11,r11
       je        short M01_L17
       jmp       short M01_L18
M01_L17:
       mov       rdx,7FFA7F0CA2C8
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
       mov       r11,7FFA7EB906C8
       call      qword ptr [7FFA7EFA06C8]
       test      eax,eax
       jne       short M01_L16
M01_L21:
       mov       rcx,[rbp+0FFC0]
       mov       r11,7FFA7EB906D0
       call      qword ptr [7FFA7EFA06D0]
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
       mov       r11,7FFA7EB906D0
       call      qword ptr [7FFA7EFA06D0]
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
; Total bytes of code 733
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
       je        short M02_L00
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
M02_L00:
       mov       rbx,[rdi+10]
       mov       rbp,[rbx+10]
       test      rbp,rbp
       je        short M02_L01
       jmp       short M02_L02
M02_L01:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C0D98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rbp,rax
M02_L02:
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
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C4A60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       mov       rcx,rbp
       call      qword ptr [r11]
       test      eax,eax
       sete      dl
       movzx     edx,dl
       mov       r9,1F5B5881028
       mov       r9,[r9]
       mov       r8,1F595883790
       mov       r8,[r8]
       mov       rcx,offset MD_dotNetTips.Spargine.Core.Validate.TryValidateParam(Boolean, System.String, System.String)
       call      dotNetTips.Spargine.Core.Validate.TryValidateParam[[System.__Canon, System.Private.CoreLib]](Boolean, System.String, System.String)
       xor       ebp,ebp
       mov       rcx,rsi
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        short M02_L09
       xor       r14d,r14d
       mov       r15d,[rsi+8]
       test      r15d,r15d
       jle       short M02_L09
M02_L05:
       movsxd    rcx,r14d
       mov       r12,[rsi+rcx*8+10]
       mov       rcx,r12
       test      rcx,rcx
       je        short M02_L08
       mov       rbp,[rsp+78]
       mov       rcx,[rbx+20]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rdi
       mov       rdx,7FFA7F0C4E60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L07:
       mov       rdx,rbp
       mov       r8,r12
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.AddIfNotExists[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.__Canon)
       mov       ebp,1
M02_L08:
       inc       r14d
       cmp       r15d,r14d
       jg        short M02_L05
M02_L09:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.CoordinateProperArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0E8]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.CoordinateProperArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0E8]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.CoordinateProperArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0E8]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.CoordinateProperArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0E8]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.CoordinateProperArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0E8]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.CoordinateProperArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0E8]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone03()
; 			var result = base.CoordinateProperArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0E8]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+108]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+108]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+108]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+108]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+108]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+108]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone01()
; 			var result = base.PersonProperArrayFull.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+108]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.PersonRecordArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+188]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.PersonRecordArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+188]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.PersonRecordArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+188]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.PersonRecordArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+188]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.PersonRecordArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+188]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.PersonRecordArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+188]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.Clone02()
; 			var result = base.PersonRecordArray.Clone();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+188]
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
       call      00007FFADE747A50
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
       call      00007FFADE7C0940
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.PersonProperArrayFull.Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 87
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,18D31063020
       mov       r8,[r8]
       mov       rdx,18D11061A48
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
       mov       rdx,7FFA7F0A0CA0
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
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFA7F257950
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
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFA7F257960
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
       mov       r8,18D110617C0
       mov       r8,[r8]
       mov       r9,18D31063020
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
       mov       rdx,7FFA7F2274B8
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
       call      qword ptr [7FFA7F1C6080]
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 190
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.PersonProperArrayFull.Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 87
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1B4A4243020
       mov       r8,[r8]
       mov       rdx,1B4A4251DC0
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
       mov       rdx,7FFA7F0B1100
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
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFA7F276548
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
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFA7F276558
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
       mov       r8,1B4A4251B38
       mov       r8,[r8]
       mov       r9,1B4A4243020
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
       mov       rdx,7FFA7F2374B8
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
       call      qword ptr [7FFA7F1D6080]
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 190
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.PersonProperArrayFull.Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 87
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,2EE13173020
       mov       r8,[r8]
       mov       rdx,2EE131815A8
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
       mov       rdx,7FFA7F0C1180
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
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFA7F286900
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
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFA7F286910
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
       mov       r8,2EDF31717C0
       mov       r8,[r8]
       mov       r9,2EE13173020
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
       mov       rdx,7FFA7F2474B8
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
       call      qword ptr [7FFA7F1E6080]
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 190
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.PersonProperArrayFull.Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 87
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,238DB861028
       mov       r8,[r8]
       mov       rdx,238CB861230
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
       mov       rdx,7FFA7F0A1188
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
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFA7F266880
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
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFA7F266890
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
       mov       r8,238DB86FB40
       mov       r8,[r8]
       mov       r9,238DB861028
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
       mov       rdx,7FFA7F2274B8
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
       call      qword ptr [7FFA7F1C6080]
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 190
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.PersonProperArrayFull.Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 87
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1A5CBFD1028
       mov       r8,[r8]
       mov       rdx,1A5BBFD1A48
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
       mov       rdx,7FFA7F0A1140
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
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFA7F2669B8
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
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFA7F2669C8
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
       mov       r8,1A5BBFD17C0
       mov       r8,[r8]
       mov       r9,1A5CBFD1028
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
       mov       rdx,7FFA7F2274B8
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
       call      qword ptr [7FFA7F1C6080]
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 190
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.PersonProperArrayFull.Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 87
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,1E0B2F81028
       mov       r8,[r8]
       mov       rdx,1E0C2F81230
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
       mov       rdx,7FFA7F0B1140
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
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFA7F276A78
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
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFA7F276A88
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
       mov       r8,1E092F837B8
       mov       r8,[r8]
       mov       r9,1E0B2F81028
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
       mov       rdx,7FFA7F237530
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
       call      qword ptr [7FFA7F1D6080]
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 190
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddFirst01()
; 			var people = this.PersonProperArrayFull.Clone<List<PersonProper>>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.ToArray().AddFirst(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ObjectExtensions.Clone(System.Object)
       call      dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       mov       rcx,rax
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddFirst[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 87
```
```assembly
; dotNetTips.Spargine.Extensions.ObjectExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       r8,264B6923020
       mov       r8,[r8]
       mov       rdx,264B6925E50
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
       mov       rdx,7FFA7F0C1188
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
       mov       rdx,[rdx+50]
       test      rdx,rdx
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rdx,7FFA7F2872C0
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
       mov       rdx,[rdx+58]
       test      rdx,rdx
       je        short M02_L03
       mov       [rsp+20],rdx
       jmp       short M02_L04
M02_L03:
       mov       rdx,7FFA7F2872D0
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
       mov       r8,264B6925BC8
       mov       r8,[r8]
       mov       r9,264B6923020
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
       mov       rdx,7FFA7F247530
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
       call      qword ptr [7FFA7F1E6080]
       mov       rax,rdi
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 190
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
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
       mov       r8,2000F073020
       mov       r8,[r8]
       mov       rdx,2000F073BD0
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
       mov       rdx,7FFA7F080A68
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
       mov       r8,2000F073BD0
       mov       r8,[r8]
       mov       r9,2000F073020
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
       mov       rdx,7FFA7F080BF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFA7EF56080]
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
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
       mov       r8,2C1884B1028
       mov       r8,[r8]
       mov       rdx,2C1884B3BD0
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
       mov       rdx,7FFA7F0A0F80
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
       mov       r8,2C1884B3BD0
       mov       r8,[r8]
       mov       r9,2C1884B1028
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
       mov       rdx,7FFA7F0A1110
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFA7EF76080]
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
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
       mov       r8,1D0DE7C3020
       mov       r8,[r8]
       mov       rdx,1D0BE7C17C0
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
       mov       rdx,7FFA7F090EE0
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
       mov       r8,1D0BE7C17C0
       mov       r8,[r8]
       mov       r9,1D0DE7C3020
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
       mov       rdx,7FFA7F091070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFA7EF66080]
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
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
       mov       r8,22BD8D93020
       mov       r8,[r8]
       mov       rdx,22BC8D9D730
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
       mov       rdx,7FFA7F080F80
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
       mov       r8,22BC8D9D730
       mov       r8,[r8]
       mov       r9,22BD8D93020
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
       mov       rdx,7FFA7F081110
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFA7EF56080]
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
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
       mov       r8,1CA6EC33020
       mov       r8,[r8]
       mov       rdx,1CA4EC317C0
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
       mov       rdx,7FFA7F090EE0
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
       mov       r8,1CA4EC317C0
       mov       r8,[r8]
       mov       r9,1CA6EC33020
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
       mov       rdx,7FFA7F091070
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFA7EF66080]
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
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
       mov       r8,1EDDF0B3020
       mov       r8,[r8]
       mov       rdx,1EDBF0B17C0
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
       mov       rdx,7FFA7F0A0F38
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
       mov       r8,1EDBF0B17C0
       mov       r8,[r8]
       mov       r9,1EDDF0B3020
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
       mov       rdx,7FFA7F0A10C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFA7EF76080]
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.AddLast01()
; 			var people = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			var result = people.AddLast(this.PersonProper01);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdx,rax
       mov       r8,[rsi+30]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast(!!0[], !!0)
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.AddLast[[System.__Canon, System.Private.CoreLib]](System.__Canon[], System.__Canon)
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 77
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
       mov       r8,16B04983020
       mov       r8,[r8]
       mov       rdx,16AE49817C0
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
       mov       rdx,7FFA7F0C0F80
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
       mov       r8,16AE49817C0
       mov       r8,[r8]
       mov       r9,16B04983020
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
       mov       rdx,7FFA7F0C1110
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M02_L02:
       movsxd    rdx,ebp
       call      CORINFO_HELP_NEWARR_1_OBJ
       mov       rdi,rax
       mov       rcx,rsi
       mov       rdx,rdi
       xor       r8d,r8d
       call      qword ptr [7FFA7EF96080]
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+108]
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
       mov       r8,24FBD653020
       mov       r8,[r8]
       mov       rdx,24FBD661B38
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
       mov       rdx,7FFA7F0C09F8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+108]
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
       mov       r8,19193EB3020
       mov       r8,[r8]
       mov       rdx,19173EB17C0
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
       mov       rdx,7FFA7F0B0A40
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+108]
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
       mov       r8,2D9EA823020
       mov       r8,[r8]
       mov       rdx,2D9EA825BC8
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
       mov       rdx,7FFA7F0A0F10
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+108]
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
       mov       r8,20C3CDE3020
       mov       r8,[r8]
       mov       rdx,20C3CDEBB68
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
       mov       rdx,7FFA7F0B0EC8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+108]
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
       mov       r8,2815E691028
       mov       r8,[r8]
       mov       rdx,2813E6917C0
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
       mov       rdx,7FFA7F0B0EC8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+108]
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
       mov       r8,257FB643020
       mov       r8,[r8]
       mov       rdx,257DB6417C0
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
       mov       rdx,7FFA7F080EC8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
       mov       rcx,offset MD_dotNetTips.Spargine.Extensions.ArrayExtensions.Clone(!!0[])
       call      dotNetTips.Spargine.Extensions.ArrayExtensions.Clone[[System.__Canon, System.Private.CoreLib]](System.__Canon[])
       mov       rdi,rax
       mov       rdx,[rsi+108]
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
       mov       r8,299B8E03020
       mov       r8,[r8]
       mov       rdx,299B8E11B38
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
       mov       rdx,7FFA7F090EB0
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.ArrayHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
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
       mov       r8,246BCA23020
       mov       r8,[r8]
       mov       rdx,246DCA217C0
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
       mov       rdx,7FFA7F0A09E8
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
       mov       r8,246BCA23020
       mov       r8,[r8]
       mov       rdx,246DCA217C0
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
       mov       rdx,7FFA7F0A0D00
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
       mov       rdx,7FFA7F0A0D00
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
       mov       rdx,7FFA7F0A1258
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
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__6_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A0D00
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
       mov       rdx,7FFA7F0A0D40
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
       mov       rdx,7FFA7F0A0D00
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
       mov       rdx,7FFA7F0A0D00
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
       mov       rdx,7FFA7F0A1098
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
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__6_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A0D00
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
       mov       rdx,7FFA7F0A0F58
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.ArrayHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
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
       mov       r8,22BAA2A1028
       mov       r8,[r8]
       mov       rdx,22BAA2AFB40
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
       mov       rdx,7FFA7F0A0A88
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
       mov       r8,22BAA2A1028
       mov       r8,[r8]
       mov       rdx,22BAA2AFB40
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
       mov       rdx,7FFA7F0A0DA0
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
       mov       rdx,7FFA7F0A0DA0
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
       mov       rdx,7FFA7F0A12F8
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
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__6_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A0DA0
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
       mov       rdx,7FFA7F0A0DE0
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
       mov       rdx,7FFA7F0A0DA0
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
       mov       rdx,7FFA7F0A0DA0
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
       mov       rdx,7FFA7F0A1138
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
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__6_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A0DA0
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
       mov       rdx,7FFA7F0A0FF8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.ArrayHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
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
       mov       r8,27350F73020
       mov       r8,[r8]
       mov       rdx,27360F717C0
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
       mov       rdx,7FFA7F0C0EF8
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
       mov       r8,27350F73020
       mov       r8,[r8]
       mov       rdx,27360F717C0
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
       mov       rdx,7FFA7F0C1210
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
       mov       rdx,7FFA7F0C1210
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
       mov       rdx,7FFA7F0C1768
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
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__6_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFA7F0C1210
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
       mov       rdx,7FFA7F0C1250
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
       mov       rdx,7FFA7F0C1210
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
       mov       rdx,7FFA7F0C1210
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
       mov       rdx,7FFA7F0C15A8
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
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__6_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFA7F0C1210
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
       mov       rdx,7FFA7F0C1468
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.ArrayHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
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
       mov       r8,2981D7B3020
       mov       r8,[r8]
       mov       rdx,2981D7B5BC8
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
       mov       rdx,7FFA7F0A0EB8
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
       mov       r8,2981D7B3020
       mov       r8,[r8]
       mov       rdx,2981D7B5BC8
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
       mov       rdx,7FFA7F0A11D0
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
       mov       rdx,7FFA7F0A11D0
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
       mov       rdx,7FFA7F0A1728
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
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__6_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A11D0
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
       mov       rdx,7FFA7F0A1210
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
       mov       rdx,7FFA7F0A11D0
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
       mov       rdx,7FFA7F0A11D0
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
       mov       rdx,7FFA7F0A1568
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
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__6_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A11D0
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
       mov       rdx,7FFA7F0A1428
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.ArrayHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
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
       mov       r8,19AA0D21028
       mov       r8,[r8]
       mov       rdx,19A80D237B8
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
       mov       rdx,7FFA7F0B0EB8
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
       mov       r8,19AA0D21028
       mov       r8,[r8]
       mov       rdx,19A80D237B8
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
       mov       rdx,7FFA7F0B11D0
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
       mov       rdx,7FFA7F0B11D0
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
       mov       rdx,7FFA7F0B1728
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
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__6_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B11D0
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
       mov       rdx,7FFA7F0B1210
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
       mov       rdx,7FFA7F0B11D0
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
       mov       rdx,7FFA7F0B11D0
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
       mov       rdx,7FFA7F0B1568
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
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__6_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B11D0
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
       mov       rdx,7FFA7F0B1428
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.ArrayHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
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
       mov       r8,1AADA183020
       mov       r8,[r8]
       mov       rdx,1AABA1817C0
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
       mov       rdx,7FFA7F0B0EF8
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
       mov       r8,1AADA183020
       mov       r8,[r8]
       mov       rdx,1AABA1817C0
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
       mov       rdx,7FFA7F0B1210
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
       mov       rdx,7FFA7F0B1210
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
       mov       rdx,7FFA7F0B1768
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
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__6_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B1210
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
       mov       rdx,7FFA7F0B1250
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
       mov       rdx,7FFA7F0B1210
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
       mov       rdx,7FFA7F0B1210
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
       mov       rdx,7FFA7F0B15A8
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
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__6_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B1210
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
       mov       rdx,7FFA7F0B1468
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ArrayHashCode01()
; 			var result = base.PersonProperArrayFull.Clone<PersonProper>();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result.ArrayHashCode());
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rdx,[rsi+108]
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
       mov       r8,1BFFC2F3020
       mov       r8,[r8]
       mov       rdx,1BFFC301B38
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
       mov       rdx,7FFA7F0A0EA0
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
       mov       r8,1BFFC2F3020
       mov       r8,[r8]
       mov       rdx,1BFFC301B38
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
       mov       rdx,7FFA7F0A11B8
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
       mov       rdx,7FFA7F0A11B8
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
       mov       rdx,7FFA7F0A1710
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
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__6_0(System.__Canon)
       mov       [rbp+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L06
       jmp       short M02_L07
M02_L06:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A11B8
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
       mov       rdx,7FFA7F0A11F8
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
       mov       rdx,7FFA7F0A11B8
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
       mov       rdx,7FFA7F0A11B8
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
       mov       rdx,7FFA7F0A1550
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
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__6`1[[System.__Canon, System.Private.CoreLib]].<ArrayHashCode>b__6_1(Int32, System.__Canon)
       mov       [r14+18],rcx
       mov       rcx,[rbx+10]
       test      rcx,rcx
       je        short M02_L17
       jmp       short M02_L18
M02_L17:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A11B8
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
       mov       rdx,7FFA7F0A1410
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString()
; 			var result = base.ByteArray.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0D8]
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
; Total bytes of code 45
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,1FD6A1F1028
       mov       r8,[r8]
       mov       rdx,1FD6A1FFB40
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
       mov       rax,1FD4A1F1508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1FD4A1F3228
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
       mov       rax,[7FFA7EF985F8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 203
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString()
; 			var result = base.ByteArray.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0D8]
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
; Total bytes of code 45
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,1D248D83020
       mov       r8,[r8]
       mov       rdx,1D248D85BC8
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
       mov       rax,1D248D81508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1D228D8D1A0
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
       mov       rax,[7FFA7EF685F8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 203
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString()
; 			var result = base.ByteArray.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0D8]
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
; Total bytes of code 45
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,1E445FF3020
       mov       r8,[r8]
       mov       rdx,1E455FF17C0
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
       mov       rax,1E445FF1508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1E445FF3640
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
       mov       rax,[7FFA7EF785F8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 203
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString()
; 			var result = base.ByteArray.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0D8]
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
; Total bytes of code 45
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,1B579D13020
       mov       r8,[r8]
       mov       rdx,1B589D117C0
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
       mov       rax,1B579D11508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,1B569D11230
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
       mov       rax,[7FFA7EF885F8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 203
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString()
; 			var result = base.ByteArray.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0D8]
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
; Total bytes of code 45
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,23614403020
       mov       r8,[r8]
       mov       rdx,235F44017C0
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
       mov       rax,23614401508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,235F4401A48
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
       mov       rax,[7FFA7EF685F8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 203
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString()
; 			var result = base.ByteArray.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0D8]
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
; Total bytes of code 45
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,29B620F3020
       mov       r8,[r8]
       mov       rdx,29B420FD730
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
       mov       rax,29B620F1508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,29B720F1230
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
       mov       rax,[7FFA7EF885F8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 203
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.BytesToString()
; 			var result = base.ByteArray.BytesToString();
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0D8]
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
; Total bytes of code 45
```
```assembly
; dotNetTips.Spargine.Extensions.ArrayExtensions.BytesToString(Byte[])
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       r8,18F4C2E3020
       mov       r8,[r8]
       mov       rdx,18F3C2ED730
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
       mov       rax,18F4C2E1508
       mov       r8,[rax]
       movzx     ecx,byte ptr [rcx]
       mov       rax,18F2C2E1230
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
       mov       rax,[7FFA7EF685F8]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       jmp       rax
; Total bytes of code 203
```

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.PersonProperArrayFull.ContainsAny(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+108]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 64
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
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A0A88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rdi,rdi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L02
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A0C40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L12
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A0C40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,rdi
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A1218
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass9_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A1258
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L11:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L12:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.PersonProperArrayFull.ContainsAny(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+108]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 64
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
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B0F18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rdi,rdi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L02
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B10D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L12
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B10D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,rdi
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B16A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass9_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B16E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L11:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L12:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.PersonProperArrayFull.ContainsAny(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+108]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 64
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
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA7F090FA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rdi,rdi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L02
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFA7F091158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L12
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFA7F091158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,rdi
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFA7F091730
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass9_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFA7F091770
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L11:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L12:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.PersonProperArrayFull.ContainsAny(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+108]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 64
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
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA7F090F40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rdi,rdi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L02
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFA7F0910F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L12
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFA7F0910F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,rdi
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFA7F0916D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass9_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFA7F091710
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L11:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L12:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.PersonProperArrayFull.ContainsAny(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+108]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 64
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
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A0F98
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rdi,rdi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L02
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A1150
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L12
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A1150
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,rdi
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A1728
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass9_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFA7F0A1768
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L11:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L12:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.PersonProperArrayFull.ContainsAny(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+108]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 64
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
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B0FA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rdi,rdi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L02
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B1158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L12
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B1158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,rdi
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B1730
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass9_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B1770
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L11:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L12:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Extensions.BenchmarkTests.ArrayExtensionsCollectionBenchmark.ContainsAny01()
; 			var result = base.PersonProperArrayFull.ContainsAny(this.PeopleToInsert);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			base.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+108]
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+48]
       call      qword ptr [rax+20]
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
; Total bytes of code 64
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
       je        short M01_L00
       mov       rcx,[rbp+10]
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B0FA0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       test      rdi,rdi
       sete      cl
       movzx     ecx,cl
       test      ecx,ecx
       jne       short M01_L02
       mov       rcx,rbx
       call      dotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       jne       short M01_L03
M01_L02:
       xor       eax,eax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L03:
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L04
       jmp       short M01_L05
M01_L04:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B1158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L05:
       mov       rdx,rbx
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       lea       rcx,[r14+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,[r14+8]
       call      dotNetTips.Spargine.Extensions.CollectionExtensions.HasItems(System.Collections.ICollection)
       test      eax,eax
       je        near ptr M01_L12
       mov       rcx,[rbp+18]
       test      rcx,rcx
       je        short M01_L06
       jmp       short M01_L07
M01_L06:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B1158
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L07:
       mov       rdx,rdi
       call      dotNetTips.Spargine.Extensions.ListExtensions.ToReadOnlyCollection[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IList`1<System.__Canon>)
       mov       rdi,rax
       mov       rcx,[rbp+20]
       test      rcx,rcx
       je        short M01_L08
       jmp       short M01_L09
M01_L08:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B1730
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L09:
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset dotNetTips.Spargine.Extensions.ArrayExtensions+<>c__DisplayClass9_0`1[[System.__Canon, System.Private.CoreLib]].<ContainsAny>b__0(System.__Canon)
       mov       [rbx+18],rcx
       mov       rcx,[rbp+28]
       test      rcx,rcx
       je        short M01_L10
       jmp       short M01_L11
M01_L10:
       mov       rcx,rsi
       mov       rdx,7FFA7F0B1770
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L11:
       mov       rdx,rdi
       mov       r8,rbx
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       jmp       near ptr System.Linq.Enumerable.Any[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Func`2<System.__Canon,Boolean>)
M01_L12:
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
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
       mov       r8,192E5483020
       mov       r8,[r8]
       mov       rdx,192C54817C0
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
       mov       rdx,7FFA7F090AD8
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
       mov       r8,192E5483020
       mov       r8,[r8]
       mov       rdx,192C54817C0
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
       mov       rdx,7FFA7F090B68
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
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
       mov       r8,1E33DA21028
       mov       r8,[r8]
       mov       rdx,1E31DA237B8
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
       mov       rdx,7FFA7F080F60
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
       mov       r8,1E33DA21028
       mov       r8,[r8]
       mov       rdx,1E31DA237B8
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
       mov       rdx,7FFA7F080FF0
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
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
       mov       r8,2813F0C3020
       mov       r8,[r8]
       mov       rdx,2813F0D1B38
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
       mov       rdx,7FFA7F090F08
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
       mov       r8,2813F0C3020
       mov       r8,[r8]
       mov       rdx,2813F0D1B38
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
       mov       rdx,7FFA7F090F98
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
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
       mov       r8,243A92A3020
       mov       r8,[r8]
       mov       rdx,243A92A5BC8
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
       mov       rdx,7FFA7F090F68
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
       mov       r8,243A92A3020
       mov       r8,[r8]
       mov       rdx,243A92A5BC8
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
       mov       rdx,7FFA7F090FF8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
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
       mov       r8,24A7A831028
       mov       r8,[r8]
       mov       rdx,24A7A83FB40
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
       mov       rdx,7FFA7F0B0F68
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
       mov       r8,24A7A831028
       mov       r8,[r8]
       mov       rdx,24A7A83FB40
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
       mov       rdx,7FFA7F0B0FF8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
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
       mov       r8,2785E553020
       mov       r8,[r8]
       mov       rdx,2783E5517C0
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
       mov       rdx,7FFA7F0A0F60
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
       mov       r8,2785E553020
       mov       r8,[r8]
       mov       rdx,2783E5517C0
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
       mov       rdx,7FFA7F0A0FF0
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
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
       mov       r8,27B99883020
       mov       r8,[r8]
       mov       rdx,27B99891B38
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
       mov       rdx,7FFA7F090F20
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
       mov       r8,27B99883020
       mov       r8,[r8]
       mov       rdx,27B99891B38
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
       mov       rdx,7FFA7F090FB0
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
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
       mov       r8,2D69EC11028
       mov       r8,[r8]
       mov       rdx,2D67EC137B8
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
       mov       rdx,7FFA7F0A0AD8
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
       mov       r8,2D69EC11028
       mov       r8,[r8]
       mov       rdx,2D67EC137B8
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
       mov       rdx,7FFA7F0A0B68
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
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
       mov       r8,2B8B1833020
       mov       r8,[r8]
       mov       rdx,2B891839758
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
       mov       rdx,7FFA7F0C0F68
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
       mov       r8,2B8B1833020
       mov       r8,[r8]
       mov       rdx,2B891839758
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
       mov       rdx,7FFA7F0C0FF8
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
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
       mov       r8,28886F83020
       mov       r8,[r8]
       mov       rdx,28876F817C0
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
       mov       rdx,7FFA7F090F08
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
       mov       r8,28886F83020
       mov       r8,[r8]
       mov       rdx,28876F817C0
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
       mov       rdx,7FFA7F090F98
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
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
       mov       r8,1CEDBBF3020
       mov       r8,[r8]
       mov       rdx,1CEEBBF17C0
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
       mov       rdx,7FFA7F0A0F08
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
       mov       r8,1CEDBBF3020
       mov       r8,[r8]
       mov       rdx,1CEEBBF17C0
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
       mov       rdx,7FFA7F0A0F98
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
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
       mov       r8,20AF9673020
       mov       r8,[r8]
       mov       rdx,20AF9675BC8
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
       mov       rdx,7FFA7F0B0F20
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
       mov       r8,20AF9673020
       mov       r8,[r8]
       mov       rdx,20AF9675BC8
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
       mov       rdx,7FFA7F0B0FB0
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
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
       mov       r8,2C7209C3020
       mov       r8,[r8]
       mov       rdx,2C7009C17C0
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
       mov       rdx,7FFA7F0C0F20
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
       mov       r8,2C7209C3020
       mov       r8,[r8]
       mov       rdx,2C7009C17C0
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
       mov       rdx,7FFA7F0C0FB0
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

## .NET 5.0.6 (5.0.621.22011), X64 RyuJIT
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
       mov       rdx,[rsi+108]
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
       mov       r8,1A7FF951028
       mov       r8,[r8]
       mov       rdx,1A7EF9517C0
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
       mov       rdx,7FFA7F0C0F68
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
       mov       r8,1A7FF951028
       mov       r8,[r8]
       mov       rdx,1A7EF9517C0
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
       mov       rdx,7FFA7F0C0FF8
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

