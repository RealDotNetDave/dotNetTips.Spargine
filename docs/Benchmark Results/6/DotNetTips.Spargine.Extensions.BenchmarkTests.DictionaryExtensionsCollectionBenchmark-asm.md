## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5980CC0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C57DF518],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C5981BF8],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-38],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-40],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5D043A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L03:
       mov       r9,18D6361B6A0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,18D63613020
       mov       r9,[r9]
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-38]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-58],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5D043D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L05:
       mov       r9,18D6361BD80
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,18D63613020
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-50]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-68],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5D04698
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L07:
       mov       r9,18D6361C070
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,18D63613020
       mov       r9,[r9]
       mov       rcx,[rbp-68]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-78],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5D046C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L09:
       mov       r8,[rbp-78]
       mov       [rbp-80],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-80]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-80]
       call      qword ptr [rax]
       mov       [rbp-84],eax
       cmp       dword ptr [rbp-84],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        near ptr M02_L12
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L10
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M02_L10
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-98],rcx
       jmp       short M02_L11
M02_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5D04760
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-98],rax
M02_L11:
       mov       rcx,[rbp-98]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A0]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-0A0]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M02_L12:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       jmp       short M02_L13
M02_L13:
       mov       rax,[rbp-30]
       add       rsp,0D0
       pop       rbp
       ret
; Total bytes of code 751
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6084EF0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       rdx,rdi
       mov       r9,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C63DD138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5F20DD0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C6085E30],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-38],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-40],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63BF438
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L03:
       mov       r9,19A89408590
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,19A89402028
       mov       r9,[r9]
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-38]
       call      qword ptr [7FF9C60CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-58],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63BF470
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L05:
       mov       r9,19A89408D88
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,19A89402028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9C60CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-68],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63BF730
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L07:
       mov       r9,19A89409068
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,19A89402028
       mov       r9,[r9]
       mov       rcx,[rbp-68]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C60CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-78],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63BF758
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L09:
       mov       r8,[rbp-78]
       mov       [rbp-80],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-80]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-80]
       call      qword ptr [rax]
       mov       [rbp-84],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-84],0
       sete      cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        near ptr M02_L12
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L10
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M02_L10
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-98],rcx
       jmp       short M02_L11
M02_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63BF7F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-98],rax
M02_L11:
       mov       rcx,[rbp-98]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A0]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-0A0]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M02_L12:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0D0
       pop       rbp
       ret
; Total bytes of code 751
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5990CC0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C57EF518],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C5991BF8],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-38],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-40],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C906F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L03:
       mov       r9,1BE65253638
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1BE65243020
       mov       r9,[r9]
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-38]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-58],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90730
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L05:
       mov       r9,1BEE5241048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1BE65243020
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-50]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-68],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C909F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L07:
       mov       r9,1BEE5241338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1BE65243020
       mov       r9,[r9]
       mov       rcx,[rbp-68]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-78],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90A18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L09:
       mov       r8,[rbp-78]
       mov       [rbp-80],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-80]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-80]
       call      qword ptr [rax]
       mov       [rbp-84],eax
       cmp       dword ptr [rbp-84],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        near ptr M02_L12
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L10
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M02_L10
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-98],rcx
       jmp       short M02_L11
M02_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-98],rax
M02_L11:
       mov       rcx,[rbp-98]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A0]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-0A0]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M02_L12:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       jmp       short M02_L13
M02_L13:
       mov       rax,[rbp-30]
       add       rsp,0D0
       pop       rbp
       ret
; Total bytes of code 751
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6454EF0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       rdx,rdi
       mov       r9,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C679B138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C62F0DD0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C6455E30],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-38],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-40],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67A0F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L03:
       mov       r9,180DF012520
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,180DF002028
       mov       r9,[r9]
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-38]
       call      qword ptr [7FF9C649BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-58],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67A0FB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L05:
       mov       r9,180DD000048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,180DF002028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9C649BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-68],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67A1270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L07:
       mov       r9,180DD000328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,180DF002028
       mov       r9,[r9]
       mov       rcx,[rbp-68]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C649BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-78],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67A1298
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L09:
       mov       r8,[rbp-78]
       mov       [rbp-80],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-80]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-80]
       call      qword ptr [rax]
       mov       [rbp-84],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-84],0
       sete      cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        near ptr M02_L12
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L10
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M02_L10
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-98],rcx
       jmp       short M02_L11
M02_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67A1338
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-98],rax
M02_L11:
       mov       rcx,[rbp-98]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A0]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-0A0]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M02_L12:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0D0
       pop       rbp
       ret
; Total bytes of code 751
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C59A0CC0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C57FF518],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C59A1BF8],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-38],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-40],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA06F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L03:
       mov       r9,15C518A3638
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,15C51893020
       mov       r9,[r9]
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-38]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-58],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA0730
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L05:
       mov       r9,15C61891048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,15C51893020
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-50]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-68],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA09F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L07:
       mov       r9,15C61891338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,15C51893020
       mov       r9,[r9]
       mov       rcx,[rbp-68]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-78],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA0A18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L09:
       mov       r8,[rbp-78]
       mov       [rbp-80],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-80]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-80]
       call      qword ptr [rax]
       mov       [rbp-84],eax
       cmp       dword ptr [rbp-84],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        near ptr M02_L12
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L10
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M02_L10
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-98],rcx
       jmp       short M02_L11
M02_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA0AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-98],rax
M02_L11:
       mov       rcx,[rbp-98]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A0]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-0A0]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M02_L12:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       jmp       short M02_L13
M02_L13:
       mov       rax,[rbp-30]
       add       rsp,0D0
       pop       rbp
       ret
; Total bytes of code 751
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6084EF0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       rdx,rdi
       mov       r9,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C63DB9A8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5F20DD0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C6085E30],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-38],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-40],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63E0808
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L03:
       mov       r9,1C05C412520
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1C05C402028
       mov       r9,[r9]
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-38]
       call      qword ptr [7FF9C60CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-58],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63E0840
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L05:
       mov       r9,1C058400048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1C05C402028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9C60CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-68],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63E0B00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L07:
       mov       r9,1C058400328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1C05C402028
       mov       r9,[r9]
       mov       rcx,[rbp-68]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C60CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-78],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63E0B28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L09:
       mov       r8,[rbp-78]
       mov       [rbp-80],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-80]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-80]
       call      qword ptr [rax]
       mov       [rbp-84],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-84],0
       sete      cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        near ptr M02_L12
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L10
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M02_L10
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-98],rcx
       jmp       short M02_L11
M02_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63E0BC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-98],rax
M02_L11:
       mov       rcx,[rbp-98]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A0]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-0A0]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M02_L12:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0D0
       pop       rbp
       ret
; Total bytes of code 751
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C59A0CC0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C57FF518],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C59A1BF8],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-38],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-40],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA06F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L03:
       mov       r9,22EE1E91180
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,22EA1E93020
       mov       r9,[r9]
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-38]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-58],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA0730
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L05:
       mov       r9,22E61E91048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,22EA1E93020
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-50]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-68],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA09F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L07:
       mov       r9,22E61E91338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,22EA1E93020
       mov       r9,[r9]
       mov       rcx,[rbp-68]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-78],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA0A18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L09:
       mov       r8,[rbp-78]
       mov       [rbp-80],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-80]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-80]
       call      qword ptr [rax]
       mov       [rbp-84],eax
       cmp       dword ptr [rbp-84],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        near ptr M02_L12
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L10
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M02_L10
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-98],rcx
       jmp       short M02_L11
M02_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA0AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-98],rax
M02_L11:
       mov       rcx,[rbp-98]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A0]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-0A0]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M02_L12:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       jmp       short M02_L13
M02_L13:
       mov       rax,[rbp-30]
       add       rsp,0D0
       pop       rbp
       ret
; Total bytes of code 751
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C60A4EF0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       rdx,rdi
       mov       r9,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C63FD138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5F40DD0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C60A5E30],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-38],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-40],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64013E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L03:
       mov       r9,20665010528
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,20665000030
       mov       r9,[r9]
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-38]
       call      qword ptr [7FF9C60EBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-58],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6401418
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L05:
       mov       r9,20665010D20
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,20665000030
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9C60EBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-68],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64016D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L07:
       mov       r9,20665011000
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,20665000030
       mov       r9,[r9]
       mov       rcx,[rbp-68]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C60EBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-78],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6401700
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L09:
       mov       r8,[rbp-78]
       mov       [rbp-80],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-80]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-80]
       call      qword ptr [rax]
       mov       [rbp-84],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-84],0
       sete      cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        near ptr M02_L12
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L10
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M02_L10
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-98],rcx
       jmp       short M02_L11
M02_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64017A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-98],rax
M02_L11:
       mov       rcx,[rbp-98]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A0]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-0A0]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M02_L12:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0D0
       pop       rbp
       ret
; Total bytes of code 751
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5970CC0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C57CF518],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C5971BF8],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-38],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-40],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C706F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L03:
       mov       r9,20F1DBF1180
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,20EDDBF3020
       mov       r9,[r9]
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-38]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-58],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C70730
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L05:
       mov       r9,20ECDBF1048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,20EDDBF3020
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-50]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-68],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C709F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L07:
       mov       r9,20ECDBF1338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,20EDDBF3020
       mov       r9,[r9]
       mov       rcx,[rbp-68]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-78],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C70A18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L09:
       mov       r8,[rbp-78]
       mov       [rbp-80],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-80]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-80]
       call      qword ptr [rax]
       mov       [rbp-84],eax
       cmp       dword ptr [rbp-84],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        near ptr M02_L12
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L10
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M02_L10
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-98],rcx
       jmp       short M02_L11
M02_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C70AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-98],rax
M02_L11:
       mov       rcx,[rbp-98]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A0]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-0A0]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M02_L12:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       jmp       short M02_L13
M02_L13:
       mov       rax,[rbp-30]
       add       rsp,0D0
       pop       rbp
       ret
; Total bytes of code 751
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6484EF0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       rdx,rdi
       mov       r9,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C67CB438]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C6320DD0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C6485E30],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-38],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-40],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D1870
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L03:
       mov       r9,1E4A7800068
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E4AF802028
       mov       r9,[r9]
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-38]
       call      qword ptr [7FF9C64CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-58],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D18A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L05:
       mov       r9,1E4A3800048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E4AF802028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9C64CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-68],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D1B68
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L07:
       mov       r9,1E4A3800328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E4AF802028
       mov       r9,[r9]
       mov       rcx,[rbp-68]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C64CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-78],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D1B90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L09:
       mov       r8,[rbp-78]
       mov       [rbp-80],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-80]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-80]
       call      qword ptr [rax]
       mov       [rbp-84],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-84],0
       sete      cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        near ptr M02_L12
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L10
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M02_L10
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-98],rcx
       jmp       short M02_L11
M02_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D1C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-98],rax
M02_L11:
       mov       rcx,[rbp-98]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A0]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-0A0]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M02_L12:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0D0
       pop       rbp
       ret
; Total bytes of code 751
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C59B0CC0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C580F518],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C59B1BF8],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-38],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-40],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB06F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L03:
       mov       r9,285592C1180
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,285792C3020
       mov       r9,[r9]
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-38]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-58],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB0730
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L05:
       mov       r9,285892C1048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,285792C3020
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-50]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-68],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB09F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L07:
       mov       r9,285892C1338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,285792C3020
       mov       r9,[r9]
       mov       rcx,[rbp-68]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-78],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB0A18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L09:
       mov       r8,[rbp-78]
       mov       [rbp-80],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-80]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-80]
       call      qword ptr [rax]
       mov       [rbp-84],eax
       cmp       dword ptr [rbp-84],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        near ptr M02_L12
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L10
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M02_L10
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-98],rcx
       jmp       short M02_L11
M02_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB0AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-98],rax
M02_L11:
       mov       rcx,[rbp-98]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A0]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-0A0]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M02_L12:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       jmp       short M02_L13
M02_L13:
       mov       rax,[rbp-30]
       add       rsp,0D0
       pop       rbp
       ret
; Total bytes of code 751
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6454EF0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       rdx,rdi
       mov       r9,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C679B138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C62F0DD0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C6455E30],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-38],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-40],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67A0F88
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L03:
       mov       r9,2382A412520
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2382A402028
       mov       r9,[r9]
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-38]
       call      qword ptr [7FF9C649BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-58],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67A0FC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L05:
       mov       r9,2382A412D18
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2382A402028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9C649BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-68],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67A1280
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L07:
       mov       r9,2382A412FF8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2382A402028
       mov       r9,[r9]
       mov       rcx,[rbp-68]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C649BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-78],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67A12A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L09:
       mov       r8,[rbp-78]
       mov       [rbp-80],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-80]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-80]
       call      qword ptr [rax]
       mov       [rbp-84],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-84],0
       sete      cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        near ptr M02_L12
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L10
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M02_L10
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-98],rcx
       jmp       short M02_L11
M02_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67A1348
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-98],rax
M02_L11:
       mov       rcx,[rbp-98]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A0]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-0A0]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M02_L12:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0D0
       pop       rbp
       ret
; Total bytes of code 751
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C59A0CC0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C57FF518],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C59A1BF8],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-38],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-40],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA06F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L03:
       mov       r9,16377193638
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,16377183020
       mov       r9,[r9]
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-38]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-58],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA0730
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L05:
       mov       r9,16387181048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,16377183020
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-50]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-68],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA09F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L07:
       mov       r9,16387181338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,16377183020
       mov       r9,[r9]
       mov       rcx,[rbp-68]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-78],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA0A18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L09:
       mov       r8,[rbp-78]
       mov       [rbp-80],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-80]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-80]
       call      qword ptr [rax]
       mov       [rbp-84],eax
       cmp       dword ptr [rbp-84],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        near ptr M02_L12
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L10
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M02_L10
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-98],rcx
       jmp       short M02_L11
M02_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA0AB8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-98],rax
M02_L11:
       mov       rcx,[rbp-98]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A0]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-0A0]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M02_L12:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       jmp       short M02_L13
M02_L13:
       mov       rax,[rbp-30]
       add       rsp,0D0
       pop       rbp
       ret
; Total bytes of code 751
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.GetOrAddDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6484EF0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       rdx,rdi
       mov       r9,[rsi+30]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C67CB138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C6320DD0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.GetOrAdd[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0D0
       lea       rbp,[rsp+0D0]
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M02_L00:
       vmovdqa   xmmword ptr [rbp+rax-10],xmm4
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       add       rax,30
       jne       short M02_L00
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C6485E30],0
       je        short M02_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L01:
       nop
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-38],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L02
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-40],rcx
       jmp       short M02_L03
M02_L02:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D13A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-40],rax
M02_L03:
       mov       r9,1D16AC10528
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1D16AC00030
       mov       r9,[r9]
       mov       rcx,[rbp-40]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-38]
       call      qword ptr [7FF9C64CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-48],rax
       mov       rcx,[rbp-48]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-20],rcx
       mov       rcx,[rbp-20]
       mov       [rbp-50],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L04
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-58],rcx
       jmp       short M02_L05
M02_L04:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D13E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L05:
       mov       r9,1D16AC10D20
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1D16AC00030
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9C64CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L06
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-68],rcx
       jmp       short M02_L07
M02_L06:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D16A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L07:
       mov       r9,1D16AC11000
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1D16AC00030
       mov       r9,[r9]
       mov       rcx,[rbp-68]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C64CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L08
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-78],rcx
       jmp       short M02_L09
M02_L08:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D16C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-78],rax
M02_L09:
       mov       r8,[rbp-78]
       mov       [rbp-80],r8
       lea       r8,[rbp-10]
       mov       rcx,[rbp+18]
       mov       r11,[rbp-80]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-80]
       call      qword ptr [rax]
       mov       [rbp-84],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-84],0
       sete      cl
       mov       [rbp-24],ecx
       cmp       dword ptr [rbp-24],0
       je        near ptr M02_L12
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-90],rcx
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L10
       mov       rcx,[rbp-90]
       cmp       qword ptr [rcx+38],0
       je        short M02_L10
       mov       rcx,[rbp-90]
       mov       rcx,[rcx+38]
       mov       [rbp-98],rcx
       jmp       short M02_L11
M02_L10:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D1768
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-98],rax
M02_L11:
       mov       rcx,[rbp-98]
       mov       [rbp-0A0],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A0]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-0A0]
       call      qword ptr [rax]
       nop
       mov       rax,[rbp+28]
       mov       [rbp-10],rax
       nop
M02_L12:
       mov       rax,[rbp-10]
       mov       [rbp-30],rax
       nop
       mov       rax,[rbp-30]
       add       rsp,0D0
       pop       rbp
       ret
; Total bytes of code 751
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,12CA168D6D0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,12CA168D6C8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,12CA168D6D0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C5CCAB70]
       vxorps    xmm1,xmm1,xmm1
       vucomisd  xmm0,xmm1
       seta      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5991BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L03
       cmp       qword ptr [rbp+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C909B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       mov       [rbp-10],eax
       jmp       short M02_L04
M02_L03:
       xor       eax,eax
       mov       [rbp-10],eax
M02_L04:
       mov       eax,[rbp-10]
       movzx     eax,al
       mov       [rbp-0C],eax
       nop
       jmp       short M02_L05
M02_L05:
       mov       eax,[rbp-0C]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 173
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1F87980C6D8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1F87980C6D0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1F87980C6D8
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9C63DD198]; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C60911C8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C6439690]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C6085E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L03
       cmp       qword ptr [rbp+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63E19B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C63DD1E0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       mov       [rbp-10],eax
       jmp       short M02_L04
M02_L03:
       xor       eax,eax
       mov       [rbp-10],eax
M02_L04:
       mov       eax,[rbp-10]
       movzx     eax,al
       mov       [rbp-0C],eax
       nop
       mov       eax,[rbp-0C]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 172
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1A40831D6D0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1A40831D6C8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1A40831D6D0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C5CAAFF0]
       vxorps    xmm1,xmm1,xmm1
       vucomisd  xmm0,xmm1
       seta      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5971BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L03
       cmp       qword ptr [rbp+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C709B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       mov       [rbp-10],eax
       jmp       short M02_L04
M02_L03:
       xor       eax,eax
       mov       [rbp-10],eax
M02_L04:
       mov       eax,[rbp-10]
       movzx     eax,al
       mov       [rbp-0C],eax
       nop
       jmp       short M02_L05
M02_L05:
       mov       eax,[rbp-0C]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 173
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,164C880C6D8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,164C880C6D0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,164C880C6D8
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9C67CB198]; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C64911C8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C6829770]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C6485E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L03
       cmp       qword ptr [rbp+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D1B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C67CB1E0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       mov       [rbp-10],eax
       jmp       short M02_L04
M02_L03:
       xor       eax,eax
       mov       [rbp-10],eax
M02_L04:
       mov       eax,[rbp-10]
       movzx     eax,al
       mov       [rbp-0C],eax
       nop
       mov       eax,[rbp-0C]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 172
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2CB252AD6D0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2CB252AD6C8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,2CB252AD6D0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C5CBAFB0]
       vxorps    xmm1,xmm1,xmm1
       vucomisd  xmm0,xmm1
       seta      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5981BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L03
       cmp       qword ptr [rbp+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C809B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       mov       [rbp-10],eax
       jmp       short M02_L04
M02_L03:
       xor       eax,eax
       mov       [rbp-10],eax
M02_L04:
       mov       eax,[rbp-10]
       movzx     eax,al
       mov       [rbp-0C],eax
       nop
       jmp       short M02_L05
M02_L05:
       mov       eax,[rbp-0C]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 173
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2550DC0C6D8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2550DC0C6D0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,2550DC0C6D8
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9C63EBD50]; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C60A11C8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C64495F0]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C6095E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L03
       cmp       qword ptr [rbp+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63F0B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C63EBD98]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       mov       [rbp-10],eax
       jmp       short M02_L04
M02_L03:
       xor       eax,eax
       mov       [rbp-10],eax
M02_L04:
       mov       eax,[rbp-10]
       movzx     eax,al
       mov       [rbp-0C],eax
       nop
       mov       eax,[rbp-0C]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 172
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1C5B7D3D6D0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1C5B7D3D6C8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1C5B7D3D6D0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C5CBB230]
       vxorps    xmm1,xmm1,xmm1
       vucomisd  xmm0,xmm1
       seta      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5981BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L03
       cmp       qword ptr [rbp+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C809B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       mov       [rbp-10],eax
       jmp       short M02_L04
M02_L03:
       xor       eax,eax
       mov       [rbp-10],eax
M02_L04:
       mov       eax,[rbp-10]
       movzx     eax,al
       mov       [rbp-0C],eax
       nop
       jmp       short M02_L05
M02_L05:
       mov       eax,[rbp-0C]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 173
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,25CAAC0C6D8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,25CAAC0C6D0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,25CAAC0C6D8
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9C67AD4E0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C64611C8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C6809E70]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C6455E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L03
       cmp       qword ptr [rbp+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B18B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C67AD528]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       mov       [rbp-10],eax
       jmp       short M02_L04
M02_L03:
       xor       eax,eax
       mov       [rbp-10],eax
M02_L04:
       mov       eax,[rbp-10]
       movzx     eax,al
       mov       [rbp-0C],eax
       nop
       mov       eax,[rbp-0C]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 172
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,24C63AFD6D0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,24C63AFD6C8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,24C63AFD6D0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C5CBB0B0]
       vxorps    xmm1,xmm1,xmm1
       vucomisd  xmm0,xmm1
       seta      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5981BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L03
       cmp       qword ptr [rbp+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C809B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       mov       [rbp-10],eax
       jmp       short M02_L04
M02_L03:
       xor       eax,eax
       mov       [rbp-10],eax
M02_L04:
       mov       eax,[rbp-10]
       movzx     eax,al
       mov       [rbp-0C],eax
       nop
       jmp       short M02_L05
M02_L05:
       mov       eax,[rbp-0C]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 173
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,25C1F00C6D8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,25C1F00C6D0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,25C1F00C6D8
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9C67CB198]; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C64911C8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C6829D90]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C6485E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L03
       cmp       qword ptr [rbp+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D1B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C67CB1E0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       mov       [rbp-10],eax
       jmp       short M02_L04
M02_L03:
       xor       eax,eax
       mov       [rbp-10],eax
M02_L04:
       mov       eax,[rbp-10]
       movzx     eax,al
       mov       [rbp-0C],eax
       nop
       mov       eax,[rbp-0C]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 172
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,243B090B6D8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,243B090B6D0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,243B090B6D8
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C5CDB090]
       vxorps    xmm1,xmm1,xmm1
       vucomisd  xmm0,xmm1
       seta      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C59A1BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L03
       cmp       qword ptr [rbp+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA09B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       mov       [rbp-10],eax
       jmp       short M02_L04
M02_L03:
       xor       eax,eax
       mov       [rbp-10],eax
M02_L04:
       mov       eax,[rbp-10]
       movzx     eax,al
       mov       [rbp-0C],eax
       nop
       jmp       short M02_L05
M02_L05:
       mov       eax,[rbp-0C]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 173
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2865FC0C6D8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2865FC0C6D0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,2865FC0C6D8
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9C67CB4E0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C64911C8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C6829C50]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C6485E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L03
       cmp       qword ptr [rbp+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D16A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C67CB528]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       mov       [rbp-10],eax
       jmp       short M02_L04
M02_L03:
       xor       eax,eax
       mov       [rbp-10],eax
M02_L04:
       mov       eax,[rbp-10]
       movzx     eax,al
       mov       [rbp-0C],eax
       nop
       mov       eax,[rbp-0C]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 172
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,28ED773D6D0
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,28ED773D6C8
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,28ED773D6D0
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 143
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C5CBB150]
       vxorps    xmm1,xmm1,xmm1
       vucomisd  xmm0,xmm1
       seta      al
       movzx     eax,al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5981BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L03
       cmp       qword ptr [rbp+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C809B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       mov       [rbp-10],eax
       jmp       short M02_L04
M02_L03:
       xor       eax,eax
       mov       [rbp-10],eax
M02_L04:
       mov       eax,[rbp-10]
       movzx     eax,al
       mov       [rbp-0C],eax
       nop
       jmp       short M02_L05
M02_L05:
       mov       eax,[rbp-0C]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 173
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.HasItemsWithPredicateTest()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,181A3C0C6D8
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,181A3C0C6D0
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,181A3C0C6D8
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FF9C67CB4E0]; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 144
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark+<>c.<HasItemsWithPredicateTest>b__2_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       sub       rsp,28
       vzeroupper
       mov       rcx,[rdx+8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C64911C8]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Age()
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FF9C6829C50]
       vxorps    xmm1,xmm1,xmm1
       xor       eax,eax
       vucomisd  xmm0,xmm1
       seta      al
       add       rsp,28
       ret
; Total bytes of code 54
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.HasItems[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       xor       eax,eax
       mov       [rbp-0C],eax
       mov       [rbp-10],eax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C6485E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       cmp       qword ptr [rbp+18],0
       je        short M02_L03
       cmp       qword ptr [rbp+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D1720
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M02_L02:
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       mov       r8,[rbp+20]
       call      qword ptr [7FF9C67CB528]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       [rbp-1C],eax
       mov       eax,[rbp-1C]
       mov       [rbp-10],eax
       jmp       short M02_L04
M02_L03:
       xor       eax,eax
       mov       [rbp-10],eax
M02_L04:
       mov       eax,[rbp-10]
       movzx     eax,al
       mov       [rbp-0C],eax
       nop
       mov       eax,[rbp-0C]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 172
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5990CC0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C57EF518],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C5991BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C906F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,17A57523FF0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,17A57513020
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90728
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,17A57523D18
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,17A57513020
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C909E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,17A57524008
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,17A57513020
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90AC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 831
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6094EF0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C63ED138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5F30DD0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C6095E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63F1818
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,22098000310
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,22088002028
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      qword ptr [7FF9C60DBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63F1850
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,22098000048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,22088002028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C60DBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63F1B10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,22098000328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,22088002028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C60DBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63F1B38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63F1BF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63F1BD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 834
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5980CC0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C57DF518],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C5981BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C806F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,2378FC91320
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2375FC93020
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C80728
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,2378FC91048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2375FC93020
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C809E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,2378FC91338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2375FC93020
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C80A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C80AC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C80AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 831
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6454EF0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C67AB438]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C62F0DD0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C6455E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B0610
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,1F818800310
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1F816802028
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      qword ptr [7FF9C649BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B0648
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,1F818800048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1F816802028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C649BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B0908
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,1F818800328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1F816802028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C649BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B0930
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B09E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B09D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 834
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5980CC0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C57DF518],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C5981BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C806F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,1799E811320
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1795E813020
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C80728
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,1799E811048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1795E813020
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C809E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,1799E811338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1795E813020
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C80A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C80AC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C80AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 831
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C60B4EF0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C63FB138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5F50DD0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C60B5E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64012E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,1910C400310
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,19106400030
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      qword ptr [7FF9C60FBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6401320
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,1910C400048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,19106400030
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C60FBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64015E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,1910C400328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,19106400030
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C60FBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6401608
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64016C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C64016A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 834
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5990CC0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C57EF518],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C5991BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C906F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,2DD725C3FF0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2DD725B3020
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90728
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,2DD725C3D18
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2DD725B3020
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C909E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,2DD725C4008
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2DD725B3020
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90AC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 831
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6454EF0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C67AB438]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C62F0DD0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C6455E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B0810
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,23F16C00310
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,23F10C02028
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      qword ptr [7FF9C649BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B0848
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,23F16C00048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,23F10C02028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C649BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B0B08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,23F16C00328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,23F10C02028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C649BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B0B30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B0BE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B0BD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 834
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5990CC0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C57EF518],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C5991BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C906F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,2636DAE1320
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2632DAE3020
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90728
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,2636DAE1048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2632DAE3020
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C909E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,2636DAE1338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2632DAE3020
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90AC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C90AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 831
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6474EF0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C67BB438]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C6310DD0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C6475E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C0F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,23F7D400310
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,23F79402028
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      qword ptr [7FF9C64BBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C0FB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,23F7D400048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,23F79402028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C64BBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C1270
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,23F7D400328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,23F79402028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C64BBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C1298
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C1350
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C1338
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 834
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C59B0CC0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C580F518],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C59B1BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB06F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,27DFCB03318
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,27DBCB01028
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB0728
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,27DFCB03040
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,27DBCB01028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB09E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,27DFCB03330
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,27DBCB01028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB0A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB0AC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB0AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 831
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6484EF0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C67CB438]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C6320DD0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C6485E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D14B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,1F512000310
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1F510002028
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      qword ptr [7FF9C64CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D14F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,1F512000048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1F510002028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C64CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D17B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,1F512000328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1F510002028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C64CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D17D8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D1890
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D1878
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 834
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5980CC0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 96
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       sub       rsp,20
       lea       rbp,[rsp+20]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C57DF518],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,20
       pop       rbp
       ret
; Total bytes of code 42
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C5981BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C806F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,1EF2DE71320
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1EF3DE71028
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C80728
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,1EF2DE71048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1EF3DE71028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C809E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,1EF2DE71338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1EF3DE71028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C80A10
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C80AC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C80AB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 831
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,[rsi+30]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6484EF0]; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       mov       r8,rax
       mov       r9,[rsi+30]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C67DB438]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+20],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+20]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 97
```
```assembly
; DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper.get_Id()
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C6320DD0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rax,[rbp+10]
       mov       rax,[rax+48]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 44
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C6485E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67E0A40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,2614E000310
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2613C002028
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      qword ptr [7FF9C64CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67E0A78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,2614E000048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2613C002028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C64CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67E0D38
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,2614E000328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2613C002028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C64CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67E0D60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67E0E18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67E0E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 834
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5981BF8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C81370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       r9,1A456A91338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1A466A91028
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C81460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       nop
       jmp       short M01_L05
M01_L05:
       mov       rax,[rbp-10]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C63FDCA8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C64352D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C60B5E30],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6411D50
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       r9,1CA67C12FF8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1CA67C02028
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C60FBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C6411E40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9C63FD798]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       nop
       mov       rax,[rbp-10]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5981BF8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C81370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       r9,29C58A34008
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,29C58A23020
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C81460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       nop
       jmp       short M01_L05
M01_L05:
       mov       rax,[rbp-10]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C67BB9A8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C67E32D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6465E30],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C17C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       r9,27011812FF8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,27011802028
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C64ABE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C18B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9C67BB498]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       nop
       mov       rax,[rbp-10]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5981BF8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C81370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       r9,2DFC6C51338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2DF56C53020
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C81460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       nop
       jmp       short M01_L05
M01_L05:
       mov       rax,[rbp-10]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C63CB9A8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63F32D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6085E30],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63D2210
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       r9,2297F000328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2297D002028
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C60CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63D2300
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9C63CB498]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       nop
       mov       rax,[rbp-10]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C59A1BF8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA1370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       r9,2450ADF1338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,244EADF3020
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA1460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       nop
       jmp       short M01_L05
M01_L05:
       mov       rax,[rbp-10]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C67CB9A8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C67F32D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6485E30],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D22D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       r9,28FC9400328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,28FBF400030
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C64CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67D23C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9C67CB498]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       nop
       mov       rax,[rbp-10]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C59A1BF8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA1370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       r9,1E6DBEB1338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E6FBEB3020
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CA1460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       nop
       jmp       short M01_L05
M01_L05:
       mov       rax,[rbp-10]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C679B9A8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C67C32D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6455E30],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67A2480
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       r9,22B12C00328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,22B10C02028
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C649BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67A2570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9C679B498]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       nop
       mov       rax,[rbp-10]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5991BF8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       r9,1BC22591338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1BBA2593020
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       nop
       jmp       short M01_L05
M01_L05:
       mov       rax,[rbp-10]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C679B9A8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C67C32D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6455E30],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67A2000
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       r9,1C02F000328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1C033002028
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C649BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67A20F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9C679B498]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       nop
       mov       rax,[rbp-10]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 75
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5981BF8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C81370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       r9,28400181338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,283C0183020
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C81460
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       nop
       jmp       short M01_L05
M01_L05:
       mov       rax,[rbp-10]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
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

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.ToSortedDictionaryTest()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.Dictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FF9C67BB9A8]; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.SortedDictionary`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Collections]](System.Collections.Generic.SortedDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C67E32D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 77
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.ToSortedDictionary[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.Dictionary`2<System.__Canon,System.__Canon>)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C6475E30],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M01_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-18],rcx
       jmp       short M01_L02
M01_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C21B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-18],rax
M01_L02:
       mov       r9,1A391800328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1A393802028
       mov       r9,[r9]
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C64BBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M01_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-30],rcx
       jmp       short M01_L04
M01_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C22A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M01_L04:
       mov       rcx,[rbp-30]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-20]
       call      qword ptr [7FF9C67BB498]; System.Collections.Generic.SortedDictionary`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>)
       mov       rax,[rbp-28]
       mov       [rbp-10],rax
       nop
       mov       rax,[rbp-10]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 266
```
```assembly
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

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 143
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB08F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB0DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB0AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB0D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB0DA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB0C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9C54F0950
       call      qword ptr [7FF9C54F0950]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB0C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9C54F0958
       call      qword ptr [7FF9C54F0958]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9C54F0960
       call      qword ptr [7FF9C54F0960]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9C54F0960
       call      qword ptr [7FF9C54F0960]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 728
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C59B1BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB1078
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,1C0169A5728
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1C0169A3020
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB10B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,1C0169A5450
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1C0169A3020
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB1370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,1C0169A5740
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1C0169A3020
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB1398
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB1450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB1438
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 831
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      qword ptr [7FF9C63DB198]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C63DB138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9C5ECB7E0]
       int       3
; Total bytes of code 146
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9C63E0A90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF9C5BEB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9C63E0F58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9C63E0C80
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF9C5BEB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9C63E0F28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9C63E0F40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9C63E0DB0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9C5A40A48
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9C63E0DC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9C5A40A50
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9C5A40A58
       call      qword ptr [r11]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       mov       ecx,10
       call      qword ptr [7FF9C5ECB780]
       int       3
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9C5A40A58
       call      qword ptr [r11]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 719
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C6085E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63E1228
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,29F42000310
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,29F4A002028
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      qword ptr [7FF9C60CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63E1260
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,29F42000048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,29F4A002028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C60CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63E1520
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,29F42000328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,29F4A002028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C60CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63E1548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63E1600
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63E15E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 834
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 143
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB08F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB0DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB0AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB0D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB0DA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB0C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9C54F0950
       call      qword ptr [7FF9C54F0950]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB0C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9C54F0958
       call      qword ptr [7FF9C54F0958]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9C54F0960
       call      qword ptr [7FF9C54F0960]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9C54F0960
       call      qword ptr [7FF9C54F0960]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 728
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C59B1BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB1078
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,17869173730
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,17869173020
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB10B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,17869173458
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,17869173020
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB1370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,17869173748
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,17869173020
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB1398
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB1450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB1438
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 831
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      qword ptr [7FF9C67BB198]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C67BB138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9C62BB7E0]
       int       3
; Total bytes of code 146
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9C67C1AE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF9C5FDB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9C67C1FA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9C67C1CD0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF9C5FDB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9C67C1F78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9C67C1F90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9C67C1E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9C5E30A50
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9C67C1E18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9C5E30A58
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9C5E30A60
       call      qword ptr [r11]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       mov       ecx,10
       call      qword ptr [7FF9C62BB780]
       int       3
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9C5E30A60
       call      qword ptr [r11]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 719
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C6475E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C2278
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,28E7A000310
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,28E6A002028
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      qword ptr [7FF9C64BBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C22B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,28E7A000048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,28E6A002028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C64BBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C2570
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,28E7A000328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,28E6A002028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C64BBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C2598
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C2650
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C2638
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 834
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 143
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9C5C908F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90DA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9C54D0950
       call      qword ptr [7FF9C54D0950]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9C54D0958
       call      qword ptr [7FF9C54D0958]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9C54D0960
       call      qword ptr [7FF9C54D0960]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9C54D0960
       call      qword ptr [7FF9C54D0960]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 728
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C5991BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91078
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,28FDF511320
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,28FEF513020
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C910B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,28FDF511048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,28FEF513020
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,28FDF511338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,28FEF513020
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91398
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91438
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 831
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      qword ptr [7FF9C63CB198]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C63CB138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9C5ECB7E0]
       int       3
; Total bytes of code 146
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9C63D1690
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF9C5BEB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9C63D1B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9C63D1880
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF9C5BEB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9C63D1B28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9C63D1B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9C63D19B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9C5A40A50
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9C63D19C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9C5A40A58
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9C5A40A60
       call      qword ptr [r11]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       mov       ecx,10
       call      qword ptr [7FF9C5ECB780]
       int       3
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9C5A40A60
       call      qword ptr [r11]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 719
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C6085E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63D1E28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,289CCC00310
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,289CAC02028
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      qword ptr [7FF9C60CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63D1E60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,289CCC00048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,289CAC02028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C60CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63D2120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,289CCC00328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,289CAC02028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C60CBE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63D2148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63D2200
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C63D21E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 834
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 143
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9C5C908F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90DA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9C54D0950
       call      qword ptr [7FF9C54D0950]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9C54D0958
       call      qword ptr [7FF9C54D0958]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9C54D0960
       call      qword ptr [7FF9C54D0960]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9C54D0960
       call      qword ptr [7FF9C54D0960]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 728
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C5991BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91078
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,1DD65953FF0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1DD65943020
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C910B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,1DD65953D18
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1DD65943020
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,1DD65954008
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1DD65943020
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91398
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91438
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 831
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      qword ptr [7FF9C67AD4C8]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C67AD468]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9C62AB7E0]
       int       3
; Total bytes of code 146
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9C67B1690
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF9C5FCB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9C67B1B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9C67B1880
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF9C5FCB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9C67B1B28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9C67B1B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9C67B19B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9C5E20A50
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9C67B19C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9C5E20A58
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9C5E20A60
       call      qword ptr [r11]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       mov       ecx,10
       call      qword ptr [7FF9C62AB780]
       int       3
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9C5E20A60
       call      qword ptr [r11]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 719
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C6465E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B1E28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,1CB81812FE0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1CB81802028
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      qword ptr [7FF9C64ABE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B1E60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,1CB81812D18
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1CB81802028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C64ABE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B2120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,1CB81812FF8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1CB81802028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C64ABE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B2148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B2200
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B21E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 834
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 143
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9C5C908F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90DA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9C54D0950
       call      qword ptr [7FF9C54D0950]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9C54D0958
       call      qword ptr [7FF9C54D0958]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9C54D0960
       call      qword ptr [7FF9C54D0960]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9C54D0960
       call      qword ptr [7FF9C54D0960]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 728
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C5991BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91078
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,1E8F6851320
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E8E6851028
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C910B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,1E8F6851048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E8E6851028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,1E8F6851338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E8E6851028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91398
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91438
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 831
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      qword ptr [7FF9C67AB4C8]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C67AB468]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9C62AB7E0]
       int       3
; Total bytes of code 146
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9C67B1690
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF9C5FCB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9C67B1B58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9C67B1880
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF9C5FCB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9C67B1B28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9C67B1B40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9C67B19B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9C5E20A50
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9C67B19C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9C5E20A58
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9C5E20A60
       call      qword ptr [r11]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       mov       ecx,10
       call      qword ptr [7FF9C62AB780]
       int       3
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9C5E20A60
       call      qword ptr [r11]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 719
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C6465E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B1E28
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,21C76800310
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21C74802028
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      qword ptr [7FF9C64ABE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B1E60
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,21C76800048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21C74802028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C64ABE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B2120
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,21C76800328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21C74802028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C64ABE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B2148
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B2200
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B21E8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 834
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 143
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9C5C908F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90DA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9C54D0950
       call      qword ptr [7FF9C54D0950]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9C5C90C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9C54D0958
       call      qword ptr [7FF9C54D0958]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9C54D0960
       call      qword ptr [7FF9C54D0960]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9C54D0960
       call      qword ptr [7FF9C54D0960]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 728
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C5991BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91078
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,1D6E6BB1320
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1D6D6BB3020
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C910B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,1D6E6BB1048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1D6D6BB3020
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,1D6E6BB1338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1D6D6BB3020
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91398
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5C91438
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 831
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      qword ptr [7FF9C67AB4C8]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C67AB468]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9C62AB7E0]
       int       3
; Total bytes of code 146
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9C67B0DF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF9C5FCB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9C67B12B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9C67B0FE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF9C5FCB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9C67B1288
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9C67B12A0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9C67B1110
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9C5E20A50
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9C67B1128
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9C5E20A58
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9C5E20A60
       call      qword ptr [r11]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       mov       ecx,10
       call      qword ptr [7FF9C62AB780]
       int       3
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9C5E20A60
       call      qword ptr [r11]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 719
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C6465E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B1588
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,21F05400310
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21F09402028
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      qword ptr [7FF9C64ABE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B15C0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,21F05400048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21F09402028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C64ABE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B1880
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,21F05400328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21F09402028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C64ABE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B18A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B1960
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67B1948
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 834
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      System.Linq.ThrowHelper.ThrowNoElementsException()
       int       3
; Total bytes of code 143
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB08F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB0DC0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB0AE8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      CORINFO_HELP_ISINSTANCEOFINTERFACE
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB0D90
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB0DA8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB0C18
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9C54F0950
       call      qword ptr [7FF9C54F0950]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9C5CB0C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9C54F0958
       call      qword ptr [7FF9C54F0958]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9C54F0960
       call      qword ptr [7FF9C54F0960]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9C54F0960
       call      qword ptr [7FF9C54F0960]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 728
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C59B1BF8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB1078
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,24F670A1320
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,24EE70A3020
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB10B0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,24F670A1048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,24EE70A3020
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB1370
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,24F670A1338
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,24EE70A3020
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB1398
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB1450
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C5CB1438
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 831
```
**Method was not JITted yet.**
System.Linq.ThrowHelper.ThrowNoElementsException()

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.DictionaryExtensionsCollectionBenchmark.UpsertDictionary01()
       push      rdi
       push      rsi
       sub       rsp,48
       xor       eax,eax
       mov       [rsp+28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       lea       rcx,[rsp+30]
       lea       r9,[rsp+40]
       mov       r8,rdi
       mov       rdx,offset MD_System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, Boolean ByRef)
       call      qword ptr [7FF9C67BD198]; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       cmp       byte ptr [rsp+40],0
       je        short M00_L00
       mov       r8,[rsp+30]
       mov       r9,[rsp+38]
       mov       rdx,rdi
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Generic.IDictionary`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>, System.String, DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper)
       call      qword ptr [7FF9C67BD138]; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       mov       [rsp+28],rdi
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,48
       pop       rsi
       pop       rdi
       ret
M00_L00:
       call      qword ptr [7FF9C62AB7E0]
       int       3
; Total bytes of code 146
```
```assembly
; System.Linq.Enumerable.TryGetLast[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, Boolean ByRef)
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       mov       [rbp-60],rsp
       mov       [rbp-30],rdx
       mov       [rbp+10],rcx
       mov       rsi,rdx
       mov       rdi,r8
       mov       rbx,r9
       test      rdi,rdi
       je        near ptr M01_L20
       mov       r14,[rsi+10]
       mov       rcx,[r14+10]
       test      rcx,rcx
       je        short M01_L00
       jmp       short M01_L01
M01_L00:
       mov       rcx,rsi
       mov       rdx,7FF9C67C15A8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L01:
       mov       rdx,rdi
       call      qword ptr [7FF9C5FCB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        short M01_L04
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],40
       jle       short M01_L02
       mov       r11,[rcx+40]
       test      r11,r11
       je        short M01_L02
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rdx,7FF9C67C1A70
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L03:
       mov       rcx,r15
       mov       rdx,[rbp+10]
       mov       r8,rbx
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L04:
       mov       rcx,[r14+18]
       test      rcx,rcx
       je        short M01_L05
       jmp       short M01_L06
M01_L05:
       mov       rcx,rsi
       mov       rdx,7FF9C67C1798
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rcx,rax
M01_L06:
       mov       rdx,rdi
       call      qword ptr [7FF9C5FCB810]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfInterface(Void*, System.Object)
       mov       r15,rax
       test      r15,r15
       je        near ptr M01_L11
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],30
       jle       short M01_L07
       mov       r11,[rcx+30]
       test      r11,r11
       je        short M01_L07
       jmp       short M01_L08
M01_L07:
       mov       rcx,rsi
       mov       rdx,7FF9C67C1A40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L08:
       mov       rcx,r15
       call      qword ptr [r11]
       mov       r14d,eax
       test      r14d,r14d
       jle       near ptr M01_L19
       mov       byte ptr [rbx],1
       mov       rcx,[rsi+10]
       cmp       qword ptr [rcx+8],38
       jle       short M01_L09
       mov       r11,[rcx+38]
       test      r11,r11
       je        short M01_L09
       jmp       short M01_L10
M01_L09:
       mov       rcx,rsi
       mov       rdx,7FF9C67C1A58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L10:
       lea       r8d,[r14-1]
       mov       rcx,r15
       mov       rdx,[rbp+10]
       call      qword ptr [r11]
       mov       rax,[rbp+10]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L11:
       mov       r11,[r14+20]
       test      r11,r11
       je        short M01_L12
       jmp       short M01_L13
M01_L12:
       mov       rcx,rsi
       mov       rdx,7FF9C67C18C8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L13:
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rdi,rax
       mov       [rbp-48],rdi
       mov       rcx,rdi
       mov       r11,7FF9C5E20A50
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L17
M01_L14:
       mov       r11,[r14+28]
       test      r11,r11
       je        short M01_L15
       jmp       short M01_L16
M01_L15:
       mov       rcx,rsi
       mov       rdx,7FF9C67C18E0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M01_L16:
       lea       rdx,[rbp-40]
       mov       rcx,rdi
       call      qword ptr [r11]
       mov       rcx,rdi
       mov       r11,7FF9C5E20A58
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L14
       mov       byte ptr [rbx],1
       mov       rdx,[rbp-40]
       mov       [rbp-50],rdx
       mov       rcx,[rbp-38]
       mov       [rbp-58],rcx
       jmp       short M01_L18
M01_L17:
       mov       rcx,rdi
       mov       r11,7FF9C5E20A60
       call      qword ptr [r11]
       jmp       short M01_L19
M01_L18:
       mov       rcx,rsp
       call      M01_L21
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp-50]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r15,[rbp+10]
       lea       rcx,[r15+8]
       mov       rdx,[rbp-58]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L19:
       mov       byte ptr [rbx],0
       xor       eax,eax
       mov       r15,[rbp+10]
       mov       [r15],rax
       mov       [r15+8],rax
       mov       rax,r15
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L20:
       mov       ecx,10
       call      qword ptr [7FF9C62AB780]
       int       3
M01_L21:
       push      rbp
       push      r15
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rdi,[rbp-48]
       test      rdi,rdi
       je        short M01_L22
       mov       rcx,rdi
       mov       r11,7FF9C5E20A60
       call      qword ptr [r11]
M01_L22:
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       r15
       pop       rbp
       ret
; Total bytes of code 719
```
```assembly
; DotNetTips.Spargine.Extensions.DictionaryExtensions.Upsert[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IDictionary`2<System.__Canon,System.__Canon>, System.__Canon, System.__Canon)
       push      rbp
       sub       rsp,0E0
       lea       rbp,[rsp+0E0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-60],xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp-8],rcx
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9
       cmp       dword ptr [7FF9C6465E30],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       xor       ecx,ecx
       mov       [rbp-10],rcx
       mov       rcx,[rbp-10]
       mov       [rbp-28],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+18],0
       je        short M02_L01
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+18]
       mov       [rbp-30],rcx
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C1D40
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-30],rax
M02_L02:
       mov       r9,19862C00310
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,19860C02028
       mov       r9,[r9]
       mov       rcx,[rbp-30]
       mov       rdx,[rbp+28]
       mov       r8,[rbp-28]
       call      qword ptr [7FF9C64ABE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+28],rcx
       xor       ecx,ecx
       mov       [rbp-18],rcx
       mov       rcx,[rbp-18]
       mov       [rbp-40],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+20],0
       je        short M02_L03
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+20]
       mov       [rbp-48],rcx
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C1D78
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-48],rax
M02_L04:
       mov       r9,19862C00048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,19860C02028
       mov       r9,[r9]
       mov       rcx,[rbp-48]
       mov       rdx,[rbp+20]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C64ABE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+28],0
       je        short M02_L05
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+28]
       mov       [rbp-58],rcx
       jmp       short M02_L06
M02_L05:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C2038
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-58],rax
M02_L06:
       mov       r9,19862C00328
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,19860C02028
       mov       r9,[r9]
       mov       rcx,[rbp-58]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FF9C64ABE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       mov       [rbp+18],rcx
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       cmp       qword ptr [rcx+30],0
       je        short M02_L07
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       rcx,[rcx+30]
       mov       [rbp-68],rcx
       jmp       short M02_L08
M02_L07:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C2060
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-68],rax
M02_L08:
       mov       rcx,[rbp-68]
       mov       [rbp-70],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-70]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-70]
       call      qword ptr [rax]
       mov       [rbp-74],eax
       mov       ecx,[rbp-74]
       movzx     ecx,cl
       mov       [rbp-1C],ecx
       cmp       dword ptr [rbp-1C],0
       je        near ptr M02_L11
       nop
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-98],rcx
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+10],40
       jle       short M02_L09
       mov       rcx,[rbp-98]
       cmp       qword ptr [rcx+40],0
       je        short M02_L09
       mov       rcx,[rbp-98]
       mov       rcx,[rcx+40]
       mov       [rbp-0A0],rcx
       jmp       short M02_L10
M02_L09:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C2118
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-0A0],rax
M02_L10:
       mov       rcx,[rbp-0A0]
       mov       [rbp-0A8],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-0A8]
       mov       rdx,[rbp+20]
       mov       rax,[rbp-0A8]
       call      qword ptr [rax]
       mov       [rbp-0AC],eax
       nop
       nop
M02_L11:
       mov       rcx,[rbp+10]
       mov       rcx,[rcx+10]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+10],38
       jle       short M02_L12
       mov       rcx,[rbp-80]
       cmp       qword ptr [rcx+38],0
       je        short M02_L12
       mov       rcx,[rbp-80]
       mov       rcx,[rcx+38]
       mov       [rbp-88],rcx
       jmp       short M02_L13
M02_L12:
       mov       rcx,[rbp+10]
       mov       rdx,7FF9C67C2100
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       [rbp-88],rax
M02_L13:
       mov       rcx,[rbp-88]
       mov       [rbp-90],rcx
       mov       rcx,[rbp+18]
       mov       r11,[rbp-90]
       mov       rdx,[rbp+20]
       mov       r8,[rbp+28]
       mov       rax,[rbp-90]
       call      qword ptr [rax]
       nop
       nop
       add       rsp,0E0
       pop       rbp
       ret
; Total bytes of code 834
```

