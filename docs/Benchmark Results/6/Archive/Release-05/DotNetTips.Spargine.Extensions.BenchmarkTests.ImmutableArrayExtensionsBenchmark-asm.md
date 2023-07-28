## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
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
       mov       r11,7FFA986C0480
       call      qword ptr [7FFA986C0480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986C0488
       call      qword ptr [7FFA986C0488]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA986C0488
       call      qword ptr [7FFA986C0488]
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFA975A3960]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebp,ebp
       cmp       eax,ebx
       sete      bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978BD0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFA96F50A40
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA96F50A48
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA96F50A48
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
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
       mov       r11,7FFA98690480
       call      qword ptr [7FFA98690480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA98690488
       call      qword ptr [7FFA98690488]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA98690488
       call      qword ptr [7FFA98690488]
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFA975B3960]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebp,ebp
       cmp       eax,ebx
       sete      bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978DD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFA96F60A48
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA96F60A50
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA96F60A50
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
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
       mov       r11,7FFA986D0480
       call      qword ptr [7FFA986D0480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986D0488
       call      qword ptr [7FFA986D0488]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA986D0488
       call      qword ptr [7FFA986D0488]
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFA975A3960]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebp,ebp
       cmp       eax,ebx
       sete      bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978BB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFA96F50A48
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA96F50A50
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA96F50A50
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
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
       mov       r11,7FFA986D0480
       call      qword ptr [7FFA986D0480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986D0488
       call      qword ptr [7FFA986D0488]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA986D0488
       call      qword ptr [7FFA986D0488]
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFA975B3960]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebp,ebp
       cmp       eax,ebx
       sete      bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978DD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFA96F60A48
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA96F60A50
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA96F60A50
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
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
       mov       r11,7FFA986B0480
       call      qword ptr [7FFA986B0480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986B0488
       call      qword ptr [7FFA986B0488]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA986B0488
       call      qword ptr [7FFA986B0488]
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFA975D3960]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebp,ebp
       cmp       eax,ebx
       sete      bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978ED828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFA96F80A48
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA96F80A50
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA96F80A50
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
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
       mov       r11,7FFA986D0480
       call      qword ptr [7FFA986D0480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986D0488
       call      qword ptr [7FFA986D0488]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA986D0488
       call      qword ptr [7FFA986D0488]
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFA975D3960]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebp,ebp
       cmp       eax,ebx
       sete      bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978EB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFA96F80A48
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA96F80A50
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA96F80A50
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
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
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
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
       mov       r11,7FFA986A0480
       call      qword ptr [7FFA986A0480]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA986A0488
       call      qword ptr [7FFA986A0488]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA986A0488
       call      qword ptr [7FFA986A0488]
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
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
       mov       rcx,offset MT_System.Collections.Immutable.ImmutableArray`1[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbp
       call      qword ptr [7FFA975B3960]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebp,ebp
       cmp       eax,ebx
       sete      bpl
M00_L01:
       mov       [rsp+20],bpl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978CB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       r11,7FFA96F60A48
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFA96F60A50
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFA96F60A50
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFA98E1DD28
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978E9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978EB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFA978DE8D0
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
       call      qword ptr [7FFA975D3960]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFA98E3DD28
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978F9060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978FB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFA978DDB00
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
       call      qword ptr [7FFA975D3960]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFA98E3DD28
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978DB060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978DD828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFA978BF2E0
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
       call      qword ptr [7FFA975B3960]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFA98E2DD28
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978C98D0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978CD0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFA978BE528
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
       call      qword ptr [7FFA975B3960]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFA98E1DD28
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978B9360]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978BB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFA978AE550
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
       call      qword ptr [7FFA975A3960]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFA98E1DD28
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978B9BD0]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978BD0F0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFA978ADE70
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
       call      qword ptr [7FFA975A3960]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
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
       mov       rdx,7FFA98E0DD28
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.ImmutableArrayExtensionsBenchmark.ImmutableArrayHasItems()
       push      rsi
       sub       rsp,30
       mov       rsi,rcx
       mov       rdx,[rsi+288]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]](System.Collections.Immutable.ImmutableArray`1<DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       call      qword ptr [7FFA978D9060]; DotNetTips.Spargine.Extensions.ImmutableArrayExtensions.HasItems[[System.__Canon, System.Private.CoreLib]](System.Collections.Immutable.ImmutableArray`1<System.__Canon>)
       mov       [rsp+28],al
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFA978DB828]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
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
       mov       rdx,7FFA978CEFC0
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
       call      qword ptr [7FFA975C3960]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
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

