## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       ebx,[rsi+284]
       cmp       dword ptr [rdi+8],0
       jne       short M00_L00
       xor       ebp,ebp
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,ebx
       sete      bpl
       movzx     ebp,bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFF90CB04B0
       call      qword ptr [7FFF90CB04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CB04B8
       call      qword ptr [7FFF90CB04B8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF90CB04B8
       call      qword ptr [7FFF90CB04B8]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       ebx,[rsi+284]
       cmp       dword ptr [rdi+8],0
       jne       short M00_L00
       xor       ebp,ebp
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF8F977300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebp,ebp
       cmp       eax,ebx
       sete      bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FCAF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFF8F3B0A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8F3B0A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF8F3B0A78
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       ebx,[rsi+284]
       cmp       dword ptr [rdi+8],0
       jne       short M00_L00
       xor       ebp,ebp
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,ebx
       sete      bpl
       movzx     ebp,bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFF90CB04B0
       call      qword ptr [7FFF90CB04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CB04B8
       call      qword ptr [7FFF90CB04B8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF90CB04B8
       call      qword ptr [7FFF90CB04B8]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       ebx,[rsi+284]
       cmp       dword ptr [rdi+8],0
       jne       short M00_L00
       xor       ebp,ebp
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF8F967300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebp,ebp
       cmp       eax,ebx
       sete      bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC8D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFF8F3A0A78
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8F3A0A80
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF8F3A0A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       ebx,[rsi+284]
       cmp       dword ptr [rdi+8],0
       jne       short M00_L00
       xor       ebp,ebp
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,ebx
       sete      bpl
       movzx     ebp,bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFF90CA04B0
       call      qword ptr [7FFF90CA04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CA04B8
       call      qword ptr [7FFF90CA04B8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF90CA04B8
       call      qword ptr [7FFF90CA04B8]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       ebx,[rsi+284]
       cmp       dword ptr [rdi+8],0
       jne       short M00_L00
       xor       ebp,ebp
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF8F987300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebp,ebp
       cmp       eax,ebx
       sete      bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FCAF828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFF8F3C0A78
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8F3C0A80
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF8F3C0A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       ebx,[rsi+284]
       cmp       dword ptr [rdi+8],0
       jne       short M00_L00
       xor       ebp,ebp
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,ebx
       sete      bpl
       movzx     ebp,bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFF90CA04B0
       call      qword ptr [7FFF90CA04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CA04B8
       call      qword ptr [7FFF90CA04B8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF90CA04B8
       call      qword ptr [7FFF90CA04B8]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       ebx,[rsi+284]
       cmp       dword ptr [rdi+8],0
       jne       short M00_L00
       xor       ebp,ebp
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF8F957300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebp,ebp
       cmp       eax,ebx
       sete      bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC7D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFF8F390A78
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8F390A80
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF8F390A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       ebx,[rsi+284]
       cmp       dword ptr [rdi+8],0
       jne       short M00_L00
       xor       ebp,ebp
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,ebx
       sete      bpl
       movzx     ebp,bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFF90CC04B0
       call      qword ptr [7FFF90CC04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CC04B8
       call      qword ptr [7FFF90CC04B8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF90CC04B8
       call      qword ptr [7FFF90CC04B8]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       ebx,[rsi+284]
       cmp       dword ptr [rdi+8],0
       jne       short M00_L00
       xor       ebp,ebp
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF8F957300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebp,ebp
       cmp       eax,ebx
       sete      bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC7D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFF8F390A78
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8F390A80
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF8F390A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       ebx,[rsi+284]
       cmp       dword ptr [rdi+8],0
       jne       short M00_L00
       xor       ebp,ebp
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,ebx
       sete      bpl
       movzx     ebp,bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFF90CC04B0
       call      qword ptr [7FFF90CC04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CC04B8
       call      qword ptr [7FFF90CC04B8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF90CC04B8
       call      qword ptr [7FFF90CC04B8]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       ebx,[rsi+284]
       cmp       dword ptr [rdi+8],0
       jne       short M00_L00
       xor       ebp,ebp
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF8F977300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebp,ebp
       cmp       eax,ebx
       sete      bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC9F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFF8F3B0A78
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8F3B0A80
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF8F3B0A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       ebx,[rsi+284]
       cmp       dword ptr [rdi+8],0
       jne       short M00_L00
       xor       ebp,ebp
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,ebx
       sete      bpl
       movzx     ebp,bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFF90CA04B0
       call      qword ptr [7FFF90CA04B0]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF90CA04B8
       call      qword ptr [7FFF90CA04B8]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF90CA04B8
       call      qword ptr [7FFF90CA04B8]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 107
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItemsWithCount()
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       ebx,[rsi+284]
       cmp       dword ptr [rdi+8],0
       jne       short M00_L00
       xor       ebp,ebp
       jmp       short M00_L01
M00_L00:
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFF8F957300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebp,ebp
       cmp       eax,ebx
       sete      bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC7D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 113
```
```assembly
; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       push      rdi
       push      rsi
       sub       rsp,28
       test      rcx,rcx
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       xor       esi,esi
       mov       r11,7FFF8F390A78
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFF8F390A80
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFF8F390A80
       call      qword ptr [r11]
       test      eax,eax
       jne       short M01_L01
M01_L02:
       mov       eax,esi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L03:
       call      CORINFO_HELP_OVERFLOW
       int       3
; Total bytes of code 98
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rax,[rcx+10]
       mov       rdx,[rax+10]
       cmp       dword ptr [rsi+8],0
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFF913CDDE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 108
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFF8FC8D360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC8F828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rax,[rcx+10]
       mov       rdx,[rax+10]
       cmp       dword ptr [rsi+8],0
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFF8FC6CCF8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFF8F967300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 109
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rax,[rcx+10]
       mov       rdx,[rax+10]
       cmp       dword ptr [rsi+8],0
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFF913DDA58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 108
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFF8FC9B360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC9D828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rax,[rcx+10]
       mov       rdx,[rax+10]
       cmp       dword ptr [rsi+8],0
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFF8FC7F068
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFF8F977300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 109
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rax,[rcx+10]
       mov       rdx,[rax+10]
       cmp       dword ptr [rsi+8],0
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFF913ADDE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 108
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFF8FC7B8D0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FC7F0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rax,[rcx+10]
       mov       rdx,[rax+10]
       cmp       dword ptr [rsi+8],0
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFF8FC5DDD8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFF8F957300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 109
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rax,[rcx+10]
       mov       rdx,[rax+10]
       cmp       dword ptr [rsi+8],0
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFF913BDDE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 108
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFF8FCAB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FCAD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rax,[rcx+10]
       mov       rdx,[rax+10]
       cmp       dword ptr [rsi+8],0
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFF8FC8F328
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFF8F987300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 109
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rax,[rcx+10]
       mov       rdx,[rax+10]
       cmp       dword ptr [rsi+8],0
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFF913ADDE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 108
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFF8FCAB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FCAD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rax,[rcx+10]
       mov       rdx,[rax+10]
       cmp       dword ptr [rsi+8],0
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFF8FC8E630
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFF8F987300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 109
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rax,[rcx+10]
       mov       rdx,[rax+10]
       cmp       dword ptr [rsi+8],0
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFF913CDDE0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 108
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFF8FCAB360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FCAD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rax,[rcx+10]
       mov       rdx,[rax+10]
       cmp       dword ptr [rsi+8],0
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFF8FC8E620
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFF8F987300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 109
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 6.0.26 (6.0.2623.60508), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 57
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rax,[rcx+10]
       mov       rdx,[rax+10]
       cmp       dword ptr [rsi+8],0
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFF913ADA58
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 108
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

## .NET 7.0.15 (7.0.1523.57226), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, DotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFF8FCBB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFF8FCBD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       [rsp+20],rcx
       mov       rsi,rdx
       mov       rax,[rcx+10]
       mov       rdx,[rax+10]
       cmp       dword ptr [rsi+8],0
       jne       short M01_L00
       xor       eax,eax
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M01_L00:
       test      rdx,rdx
       je        short M01_L01
       jmp       short M01_L02
M01_L01:
       mov       rdx,7FFF8FC9F4B8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       rdx,rax
M01_L02:
       mov       rcx,rdx
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rdi
       call      qword ptr [7FFF8F997300]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      al
       movzx     eax,al
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 109
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       movzx     eax,byte ptr [rdx]
       mov       [rcx+4C],al
       ret
; Total bytes of code 7
```

