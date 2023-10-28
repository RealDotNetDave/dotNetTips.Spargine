## DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark-20230721-181001
**Diff for CheckItemsExists_NoValidation method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_NoValidation()
        sub       rsp,28
        mov       r8,[rcx+190]
        mov       [rsp+20],r8
        mov       rcx,[rcx+18]
        lea       r8,[rsp+20]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFD529FF390]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,28
        ret
-; Total bytes of code 48
+; Total bytes of code 49
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for CheckItemsExists_Validation_Inlining method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_Validation_Inlining()
        push      rdi
        push      rsi
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rsi,rcx
        mov       rdi,[rsi+190]
        test      rdi,rdi
        je        short M00_L00
        mov       rcx,rdi
-       call      DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFD528FDA68]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
 M00_L00:
        mov       [rsp+20],rdi
        mov       rcx,[rsi+18]
        lea       r8,[rsp+20]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFD52A0F048]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 75
+; Total bytes of code 77
 ; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rdx,rsi
        mov       rcx,offset MT_System.Collections.ICollection
-       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
+       call      qword ptr [7FFD523AB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        je        short M01_L00
        mov       rcx,rax
-       mov       r11,7FFD674A0310
-       mov       rax,[7FFD674A0310]
+       mov       r11,7FFD52200698
        add       rsp,28
        pop       rsi
        pop       rdi
-       jmp       rax
+       jmp       qword ptr [r11]
 M01_L00:
        xor       edi,edi
        mov       rcx,rsi
-       mov       r11,7FFD674A0300
-       call      qword ptr [7FFD674A0300]
+       mov       r11,7FFD52200688
+       call      qword ptr [r11]
        mov       rsi,rax
        mov       rcx,rsi
-       mov       r11,7FFD674A0308
-       call      qword ptr [7FFD674A0308]
+       mov       r11,7FFD52200690
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       edi,1
        jo        short M01_L03
        mov       rcx,rsi
-       mov       r11,7FFD674A0308
-       call      qword ptr [7FFD674A0308]
+       mov       r11,7FFD52200690
+       call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
 M01_L02:
        mov       eax,edi
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        call      CORINFO_HELP_OVERFLOW
        int       3
-; Total bytes of code 151
+; Total bytes of code 136
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for CheckItemsExists_Validation method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.CheckItemsExists_Validation()
        push      rdi
        push      rsi
        sub       rsp,28
        xor       eax,eax
        mov       [rsp+20],rax
        mov       rsi,rcx
        mov       rdi,[rsi+190]
        test      rdi,rdi
        je        short M00_L00
        mov       rcx,rdi
-       call      DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
+       call      qword ptr [7FFD528FDA68]; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
 M00_L00:
        mov       [rsp+20],rdi
        mov       rcx,[rsi+18]
        lea       r8,[rsp+20]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFD52A0F078]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
-; Total bytes of code 75
+; Total bytes of code 77
 ; DotNetTips.Spargine.Core.Extensions.Count(System.Collections.IEnumerable)
        push      rdi
        push      rsi
        sub       rsp,28
        mov       rsi,rcx
        mov       rdx,rsi
        mov       rcx,offset MT_System.Collections.ICollection
-       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
+       call      qword ptr [7FFD523AB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
        test      rax,rax
        je        short M01_L00
        mov       rcx,rax
-       mov       r11,7FFD674D0310
-       mov       rax,[7FFD674D0310]
+       mov       r11,7FFD52200698
        add       rsp,28
        pop       rsi
        pop       rdi
-       jmp       rax
+       jmp       qword ptr [r11]
 M01_L00:
        xor       edi,edi
        mov       rcx,rsi
-       mov       r11,7FFD674D0300
-       call      qword ptr [7FFD674D0300]
+       mov       r11,7FFD52200688
+       call      qword ptr [r11]
        mov       rsi,rax
        mov       rcx,rsi
-       mov       r11,7FFD674D0308
-       call      qword ptr [7FFD674D0308]
+       mov       r11,7FFD52200690
+       call      qword ptr [r11]
        test      eax,eax
        je        short M01_L02
 M01_L01:
        add       edi,1
        jo        short M01_L03
        mov       rcx,rsi
-       mov       r11,7FFD674D0308
-       call      qword ptr [7FFD674D0308]
+       mov       r11,7FFD52200690
+       call      qword ptr [r11]
        test      eax,eax
        jne       short M01_L01
 M01_L02:
        mov       eax,edi
        add       rsp,28
        pop       rsi
        pop       rdi
        ret
 M01_L03:
        call      CORINFO_HELP_OVERFLOW
        int       3
-; Total bytes of code 151
+; Total bytes of code 136
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for ArgumentNotNullOrEmpty_NoValidation method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_NoValidation()
        sub       rsp,28
-       mov       r8,25AEABE2B88
+       mov       r8,2B9E4C12758
        mov       r8,[r8]
        mov       [rsp+20],r8
        mov       rcx,[rcx+18]
        lea       r8,[rsp+20]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFD529DF330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
        add       rsp,28
        ret
-; Total bytes of code 54
+; Total bytes of code 55
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
```
**Diff for ArgumentNotNullOrEmpty_Validation_Inlining method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_Validation_Inlining()
        push      rdi
        push      rsi
-       sub       rsp,28
+       push      rbx
+       sub       rsp,30
        xor       eax,eax
-       mov       [rsp+20],rax
+       mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rax,21A74C42B88
+       mov       rax,1EECD012758
        mov       rdi,[rax]
        mov       rcx,rdi
-       cmp       dword ptr [rcx+8],0
-       je        short M00_L02
        xor       eax,eax
-M00_L00:
+       cmp       dword ptr [rcx+8],0
+       sete      al
        test      eax,eax
        sete      al
        movzx     eax,al
+       mov       edx,[rcx+8]
        test      eax,eax
-       jne       short M00_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
+       jne       near ptr M00_L00
+       call      qword ptr [7FFD52719498]
        mov       rdi,rax
        mov       ecx,43
-       mov       rdx,7FFD677742A0
+       mov       rdx,7FFD52637BD0
+       call      CORINFO_HELP_STRCNS
+       mov       rsi,rax
+       mov       ecx,340
+       mov       rdx,7FFD52639A38
+       call      CORINFO_HELP_STRCNS
+       mov       rbx,rax
+       mov       ecx,6D0
+       mov       rdx,7FFD52639A38
        call      CORINFO_HELP_STRCNS
+       mov       rcx,rsi
+       mov       r9,rbx
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFD526BB270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFD52719078]
        mov       rdx,rax
        mov       rcx,rdi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
-M00_L01:
+       call      qword ptr [7FFD52719558]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rbx
+       call      qword ptr [7FFD525FD8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M00_L00:
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
-       mov       [rsp+20],rdi
+       call      qword ptr [7FFD52423510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       [rsp+28],rdi
        mov       rcx,[rsi+18]
-       lea       r8,[rsp+20]
+       lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFD529EDFD8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
-       add       rsp,28
+       add       rsp,30
+       pop       rbx
        pop       rsi
        pop       rdi
        ret
-M00_L02:
-       mov       eax,1
-       jmp       short M00_L00
-; Total bytes of code 148
+; Total bytes of code 275
+; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       push      rbp
+       sub       rsp,40
+       lea       rbp,[rsp+40]
+       vxorps    xmm4,xmm4,xmm4
+       vmovdqu   xmmword ptr [rbp-18],xmm4
+       xor       eax,eax
+       mov       [rbp-8],rax
+       mov       [rbp+10],rcx
+       mov       [rbp+18],edx
+       mov       [rbp+20],r8
+       mov       [rbp+28],r9
+       mov       rcx,[rbp+10]
+       call      qword ptr [7FFD52421810]; System.String.IsNullOrEmpty(System.String)
+       xor       ecx,ecx
+       test      eax,eax
+       sete      cl
+       mov       [rbp-4],ecx
+       cmp       dword ptr [rbp-4],0
+       jne       short M01_L00
+       mov       rcx,[rbp+20]
+       call      qword ptr [7FFD52421810]; System.String.IsNullOrEmpty(System.String)
+       test      eax,eax
+       jne       short M01_L00
+       mov       rax,[rbp+20]
+       mov       [rbp+10],rax
+       jmp       short M01_L01
+M01_L00:
+       cmp       dword ptr [rbp-4],0
+       jne       short M01_L01
+       call      qword ptr [7FFD52719498]
+       mov       [rbp-10],rax
+       mov       rdx,[rbp-10]
+       mov       rcx,[rbp+28]
+       call      qword ptr [7FFD526BB2B8]
+       mov       [rbp-18],rax
+       mov       rcx,[rbp-18]
+       mov       rdx,[rbp+30]
+       call      qword ptr [7FFD527195E8]
+M01_L01:
+       mov       eax,[rbp+18]
+       movzx     eax,al
+       test      eax,eax
+       jne       short M01_L02
+       mov       rax,[rbp+10]
+       add       rsp,40
+       pop       rbp
+       ret
+M01_L02:
+       mov       rcx,[rbp+10]
+       cmp       [rcx],ecx
+       call      qword ptr [7FFD52423438]; System.String.Trim()
+       nop
+       add       rsp,40
+       pop       rbp
+       ret
+; Total bytes of code 177
 ; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        push      r15
        push      r14
-       push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,20
+       sub       rsp,28
        mov       rsi,rcx
        mov       edi,edx
        mov       ebx,[rsi+8]
        lea       ebp,[rbx-1]
        mov       r14d,ebp
        xor       r15d,r15d
        test      dil,1
-       je        short M01_L03
+       je        short M02_L03
        xor       r15d,r15d
        test      ebx,ebx
-       jle       short M01_L03
-M01_L00:
-       movsxd    rcx,r15d
+       jle       short M02_L03
+M02_L00:
+       mov       ecx,r15d
        movzx     ecx,word ptr [rsi+rcx*2+0C]
        cmp       ecx,100
-       jae       short M01_L01
-       cmp       ecx,100
-       jae       near ptr M01_L11
-       movsxd    rcx,ecx
-       mov       rax,7FFD98051420
+       jae       short M02_L01
+       mov       ecx,ecx
+       mov       rax,7FFD8D31D830
        test      byte ptr [rcx+rax],80
-       setne     r12b
-       movzx     r12d,r12b
-       test      r12d,r12d
-       je        short M01_L03
-       jmp       short M01_L02
-M01_L01:
-       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
-       movzx     r12d,al
-       test      r12d,r12d
-       je        short M01_L03
-M01_L02:
+       je        short M02_L03
+       jmp       short M02_L02
+M02_L01:
+       call      qword ptr [7FFD52A258E8]
+       test      eax,eax
+       je        short M02_L03
+M02_L02:
        inc       r15d
        cmp       ebx,r15d
-       jg        short M01_L00
-M01_L03:
+       jg        short M02_L00
+M02_L03:
        test      dil,2
-       je        short M01_L07
+       je        near ptr M02_L10
        mov       r14d,ebp
        cmp       r14d,r15d
-       jl        short M01_L07
-M01_L04:
-       cmp       r14d,ebx
-       jae       near ptr M01_L11
-       movsxd    rcx,r14d
+       jl        near ptr M02_L10
+       test      r14d,r14d
+       jl        short M02_L07
+       test      r15d,r15d
+       jl        short M02_L07
+       cmp       ebx,r14d
+       jle       short M02_L07
+M02_L04:
+       mov       ecx,r14d
        movzx     ecx,word ptr [rsi+rcx*2+0C]
        cmp       ecx,100
-       jae       short M01_L05
+       jae       short M02_L05
+       mov       ecx,ecx
+       mov       rax,7FFD8D31D830
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L06
+M02_L05:
+       call      qword ptr [7FFD52A258E8]
+       test      eax,eax
+       je        short M02_L10
+M02_L06:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L04
+       jmp       short M02_L10
+M02_L07:
+       cmp       r14d,ebx
+       jae       short M02_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
        cmp       ecx,100
-       jae       near ptr M01_L11
-       movsxd    rcx,ecx
-       mov       rax,7FFD98051420
+       jae       short M02_L08
+       mov       ecx,ecx
+       mov       rax,7FFD8D31D830
        test      byte ptr [rcx+rax],80
-       setne     dil
-       movzx     edi,dil
-       test      edi,edi
-       je        short M01_L07
-       jmp       short M01_L06
-M01_L05:
-       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
-       movzx     edi,al
-       test      edi,edi
-       je        short M01_L07
-M01_L06:
+       je        short M02_L10
+       jmp       short M02_L09
+M02_L08:
+       call      qword ptr [7FFD52A258E8]
+       test      eax,eax
+       je        short M02_L10
+M02_L09:
        dec       r14d
        cmp       r14d,r15d
-       jge       short M01_L04
-M01_L07:
-       sub       r14d,r15d
-       lea       ecx,[r14+1]
-       cmp       ebx,ecx
-       jne       short M01_L09
+       jge       short M02_L07
+M02_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M02_L12
        mov       rax,rsi
-M01_L08:
-       add       rsp,20
+M02_L11:
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r12
        pop       r14
        pop       r15
        ret
-M01_L09:
-       test      ecx,ecx
-       je        short M01_L10
-       call      System.String.FastAllocateString(Int32)
-       mov       rbx,rax
-       mov       r8d,[rbx+8]
-       lea       rcx,[rbx+0C]
-       lea       rdx,[rsi+0C]
-       mov       eax,r15d
-       lea       rdx,[rdx+rax*2]
-       add       r8,r8
-       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
-       mov       rax,rbx
-       jmp       short M01_L08
-M01_L10:
-       mov       rax,21A04C43020
+M02_L12:
+       test      r8d,r8d
+       je        short M02_L13
+       mov       rcx,rsi
+       mov       edx,r15d
+       call      qword ptr [7FFD52423390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M02_L11
+M02_L13:
+       mov       rax,1EECD002028
        mov       rax,[rax]
-       jmp       short M01_L08
-M01_L11:
+       jmp       short M02_L11
+M02_L14:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 323
+; Total bytes of code 318
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
-**Method was not JITted yet.**
-DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
```
**Diff for ArgumentNotNullOrEmpty_Validation method between:**
.NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
.NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```diff
; DotNetTips.Spargine.Core.BenchmarkTests.ValidatorBenchmark.ArgumentNotNullOrEmpty_Validation()
        push      rdi
        push      rsi
-       sub       rsp,28
+       push      rbx
+       sub       rsp,30
        xor       eax,eax
-       mov       [rsp+20],rax
+       mov       [rsp+28],rax
        mov       rsi,rcx
-       mov       rax,20332D92B88
+       mov       rax,26C97812758
        mov       rdi,[rax]
        mov       rcx,rdi
-       cmp       dword ptr [rcx+8],0
-       je        short M00_L02
        xor       eax,eax
-M00_L00:
+       cmp       dword ptr [rcx+8],0
+       sete      al
        test      eax,eax
        sete      al
        movzx     eax,al
+       mov       edx,[rcx+8]
        test      eax,eax
-       jne       short M00_L01
-       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
+       jne       near ptr M00_L00
+       call      qword ptr [7FFD52729498]
        mov       rdi,rax
        mov       ecx,43
-       mov       rdx,7FFD677542A0
+       mov       rdx,7FFD52647BD0
+       call      CORINFO_HELP_STRCNS
+       mov       rsi,rax
+       mov       ecx,340
+       mov       rdx,7FFD52649A38
+       call      CORINFO_HELP_STRCNS
+       mov       rbx,rax
+       mov       ecx,6D0
+       mov       rdx,7FFD52649A38
        call      CORINFO_HELP_STRCNS
+       mov       rcx,rsi
+       mov       r9,rbx
+       mov       [rsp+20],rax
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFD526CB270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+       mov       rsi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFD52729078]
        mov       rdx,rax
        mov       rcx,rdi
-       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
-       int       3
-M00_L01:
+       call      qword ptr [7FFD52729558]
+       mov       r8,rax
+       mov       rdx,rsi
+       mov       rcx,rbx
+       call      qword ptr [7FFD5260D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M00_L00:
        mov       edx,3
-       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
-       mov       [rsp+20],rdi
+       call      qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+       mov       [rsp+28],rdi
        mov       rcx,[rsi+18]
-       lea       r8,[rsp+20]
+       lea       r8,[rsp+28]
        mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
        cmp       [rcx],ecx
-       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
+       call      qword ptr [7FFD529FF330]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        nop
-       add       rsp,28
+       add       rsp,30
+       pop       rbx
        pop       rsi
        pop       rdi
        ret
-M00_L02:
-       mov       eax,1
-       jmp       short M00_L00
-; Total bytes of code 148
+; Total bytes of code 275
+; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
+M01_L00:
+       push      rdi
+       push      rsi
+       push      rbx
+       sub       rsp,30
+       mov       rsi,r9
+       test      rcx,rcx
+       je        short M01_L01
+       mov       eax,[rcx+8]
+       xor       r9d,r9d
+       test      eax,eax
+       sete      r9b
+       test      r9d,r9d
+       sete      r9b
+       movzx     r9d,r9b
+       test      eax,eax
+       jne       short M01_L03
+       jmp       short M01_L02
+M01_L01:
+       xor       r9d,r9d
+M01_L02:
+       test      r8,r8
+       je        short M01_L03
+       cmp       dword ptr [r8+8],0
+       je        short M01_L03
+       mov       rcx,r8
+       jmp       near ptr M01_L06
+M01_L03:
+       test      r9d,r9d
+       jne       near ptr M01_L06
+       call      qword ptr [7FFD52729498]
+       mov       rdi,rax
+       test      rsi,rsi
+       je        short M01_L04
+       cmp       dword ptr [rsi+8],0
+       je        short M01_L04
+       jmp       short M01_L05
+M01_L04:
+       mov       rsi,rdi
+M01_L05:
+       mov       ecx,340
+       mov       rdx,7FFD52649A38
+       call      CORINFO_HELP_STRCNS
+       mov       rdi,rax
+       mov       ecx,6D0
+       mov       rdx,7FFD52649A38
+       call      CORINFO_HELP_STRCNS
+       mov       r9,rdi
+       mov       [rsp+20],rax
+       mov       rcx,[rsp+70]
+       mov       edx,1
+       xor       r8d,r8d
+       call      qword ptr [7FFD526CB270]
+       mov       rdi,rax
+       mov       rcx,offset MT_System.ArgumentNullException
+       call      CORINFO_HELP_NEWSFAST
+       mov       rbx,rax
+       call      qword ptr [7FFD52729078]
+       mov       rdx,rax
+       mov       rcx,rsi
+       call      qword ptr [7FFD52729558]
+       mov       r8,rax
+       mov       rdx,rdi
+       mov       rcx,rbx
+       call      qword ptr [7FFD5260D8E8]
+       mov       rcx,rbx
+       call      CORINFO_HELP_THROW
+M01_L06:
+       test      dl,dl
+       jne       short M01_L07
+       mov       rax,rcx
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       ret
+M01_L07:
+       cmp       [rcx],cl
+       mov       edx,3
+       add       rsp,30
+       pop       rbx
+       pop       rsi
+       pop       rdi
+       jmp       qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
+; Total bytes of code 268
 ; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
        push      r15
        push      r14
-       push      r12
        push      rdi
        push      rsi
        push      rbp
        push      rbx
-       sub       rsp,20
+       sub       rsp,28
        mov       rsi,rcx
        mov       edi,edx
        mov       ebx,[rsi+8]
        lea       ebp,[rbx-1]
        mov       r14d,ebp
        xor       r15d,r15d
        test      dil,1
-       je        short M01_L03
+       je        short M02_L03
        xor       r15d,r15d
        test      ebx,ebx
-       jle       short M01_L03
-M01_L00:
-       movsxd    rcx,r15d
+       jle       short M02_L03
+M02_L00:
+       mov       ecx,r15d
        movzx     ecx,word ptr [rsi+rcx*2+0C]
        cmp       ecx,100
-       jae       short M01_L01
-       cmp       ecx,100
-       jae       near ptr M01_L11
-       movsxd    rcx,ecx
-       mov       rax,7FFD98051420
+       jae       short M02_L01
+       mov       ecx,ecx
+       mov       rax,7FFD8D31D830
        test      byte ptr [rcx+rax],80
-       setne     r12b
-       movzx     r12d,r12b
-       test      r12d,r12d
-       je        short M01_L03
-       jmp       short M01_L02
-M01_L01:
-       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
-       movzx     r12d,al
-       test      r12d,r12d
-       je        short M01_L03
-M01_L02:
+       je        short M02_L03
+       jmp       short M02_L02
+M02_L01:
+       call      qword ptr [7FFD52A35C48]
+       test      eax,eax
+       je        short M02_L03
+M02_L02:
        inc       r15d
        cmp       ebx,r15d
-       jg        short M01_L00
-M01_L03:
+       jg        short M02_L00
+M02_L03:
        test      dil,2
-       je        short M01_L07
+       je        near ptr M02_L10
        mov       r14d,ebp
        cmp       r14d,r15d
-       jl        short M01_L07
-M01_L04:
-       cmp       r14d,ebx
-       jae       near ptr M01_L11
-       movsxd    rcx,r14d
+       jl        near ptr M02_L10
+       test      r14d,r14d
+       jl        short M02_L07
+       test      r15d,r15d
+       jl        short M02_L07
+       cmp       ebx,r14d
+       jle       short M02_L07
+M02_L04:
+       mov       ecx,r14d
        movzx     ecx,word ptr [rsi+rcx*2+0C]
        cmp       ecx,100
-       jae       short M01_L05
+       jae       short M02_L05
+       mov       ecx,ecx
+       mov       rax,7FFD8D31D830
+       test      byte ptr [rcx+rax],80
+       je        short M02_L10
+       jmp       short M02_L06
+M02_L05:
+       call      qword ptr [7FFD52A35C48]
+       test      eax,eax
+       je        short M02_L10
+M02_L06:
+       dec       r14d
+       cmp       r14d,r15d
+       jge       short M02_L04
+       jmp       short M02_L10
+M02_L07:
+       cmp       r14d,ebx
+       jae       short M02_L14
+       mov       ecx,r14d
+       movzx     ecx,word ptr [rsi+rcx*2+0C]
        cmp       ecx,100
-       jae       near ptr M01_L11
-       movsxd    rcx,ecx
-       mov       rax,7FFD98051420
+       jae       short M02_L08
+       mov       ecx,ecx
+       mov       rax,7FFD8D31D830
        test      byte ptr [rcx+rax],80
-       setne     dil
-       movzx     edi,dil
-       test      edi,edi
-       je        short M01_L07
-       jmp       short M01_L06
-M01_L05:
-       call      System.Globalization.CharUnicodeInfo.GetIsWhiteSpace(Char)
-       movzx     edi,al
-       test      edi,edi
-       je        short M01_L07
-M01_L06:
+       je        short M02_L10
+       jmp       short M02_L09
+M02_L08:
+       call      qword ptr [7FFD52A35C48]
+       test      eax,eax
+       je        short M02_L10
+M02_L09:
        dec       r14d
        cmp       r14d,r15d
-       jge       short M01_L04
-M01_L07:
-       sub       r14d,r15d
-       lea       ecx,[r14+1]
-       cmp       ebx,ecx
-       jne       short M01_L09
+       jge       short M02_L07
+M02_L10:
+       mov       r8d,r14d
+       sub       r8d,r15d
+       inc       r8d
+       cmp       ebx,r8d
+       jne       short M02_L12
        mov       rax,rsi
-M01_L08:
-       add       rsp,20
+M02_L11:
+       add       rsp,28
        pop       rbx
        pop       rbp
        pop       rsi
        pop       rdi
-       pop       r12
        pop       r14
        pop       r15
        ret
-M01_L09:
-       test      ecx,ecx
-       je        short M01_L10
-       call      System.String.FastAllocateString(Int32)
-       mov       rbx,rax
-       mov       r8d,[rbx+8]
-       lea       rcx,[rbx+0C]
-       lea       rdx,[rsi+0C]
-       mov       eax,r15d
-       lea       rdx,[rdx+rax*2]
-       add       r8,r8
-       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
-       mov       rax,rbx
-       jmp       short M01_L08
-M01_L10:
-       mov       rax,202C2D93020
+M02_L12:
+       test      r8d,r8d
+       je        short M02_L13
+       mov       rcx,rsi
+       mov       edx,r15d
+       call      qword ptr [7FFD52433390]; System.String.InternalSubString(Int32, Int32)
+       jmp       short M02_L11
+M02_L13:
+       mov       rax,26C97802028
        mov       rax,[rax]
-       jmp       short M01_L08
-M01_L11:
+       jmp       short M02_L11
+M02_L14:
        call      CORINFO_HELP_RNGCHKFAIL
        int       3
-; Total bytes of code 323
+; Total bytes of code 318
 ; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
        push      rsi
        mov       rsi,rcx
        mov       rdx,[r8]
        lea       rcx,[rsi+8]
        call      CORINFO_HELP_ASSIGN_REF
        xor       eax,eax
        mov       [rsi+8],rax
        pop       rsi
        ret
 ; Total bytes of code 24
-**Method was not JITted yet.**
-DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
```
