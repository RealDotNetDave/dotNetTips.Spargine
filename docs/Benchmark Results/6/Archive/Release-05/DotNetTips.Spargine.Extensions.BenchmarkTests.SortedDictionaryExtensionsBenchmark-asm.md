## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       mov       edi,[rsi+284]
       test      rcx,rcx
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      bl
       movzx     ebx,bl
M00_L01:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 74
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       mov       edi,[rsi+284]
       test      rcx,rcx
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB13F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebx,ebx
       cmp       eax,edi
       sete      bl
M00_L01:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4D51F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 75
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
       mov       r11,7FFAAAB20A68
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB20A70
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB20A70
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       mov       edi,[rsi+284]
       test      rcx,rcx
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      bl
       movzx     ebx,bl
M00_L01:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 74
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       mov       edi,[rsi+284]
       test      rcx,rcx
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB12F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebx,ebx
       cmp       eax,edi
       sete      bl
M00_L01:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4A38D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 75
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
       mov       r11,7FFAAAB10A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB10A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB10A78
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       mov       edi,[rsi+284]
       test      rcx,rcx
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      bl
       movzx     ebx,bl
M00_L01:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 74
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       mov       edi,[rsi+284]
       test      rcx,rcx
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB13F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebx,ebx
       cmp       eax,edi
       sete      bl
M00_L01:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4E53C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 75
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
       mov       r11,7FFAAAB20A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB20A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB20A78
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       mov       edi,[rsi+284]
       test      rcx,rcx
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      bl
       movzx     ebx,bl
M00_L01:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 74
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       mov       edi,[rsi+284]
       test      rcx,rcx
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB14F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebx,ebx
       cmp       eax,edi
       sete      bl
M00_L01:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4C73C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 75
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
       mov       r11,7FFAAAB30A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB30A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB30A78
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       mov       edi,[rsi+284]
       test      rcx,rcx
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      bl
       movzx     ebx,bl
M00_L01:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 74
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       mov       edi,[rsi+284]
       test      rcx,rcx
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB14F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebx,ebx
       cmp       eax,edi
       sete      bl
M00_L01:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4D38D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 75
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
       mov       r11,7FFAAAB30A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB30A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB30A78
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       mov       edi,[rsi+284]
       test      rcx,rcx
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      bl
       movzx     ebx,bl
M00_L01:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 74
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       mov       edi,[rsi+284]
       test      rcx,rcx
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB13F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebx,ebx
       cmp       eax,edi
       sete      bl
M00_L01:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4C38D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 75
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
       mov       r11,7FFAAAB20A10
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB20A18
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB20A18
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       mov       edi,[rsi+284]
       test      rcx,rcx
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       cmp       eax,edi
       sete      bl
       movzx     ebx,bl
M00_L01:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 74
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithCount()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       mov       edi,[rsi+284]
       test      rcx,rcx
       jne       short M00_L00
       xor       ebx,ebx
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB12F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       ebx,ebx
       cmp       eax,edi
       sete      bl
M00_L01:
       mov       [rsp+28],bl
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+28]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4B38D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 75
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
       mov       r11,7FFAAAB10A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB10A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB10A78
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,19CC1F1D458
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,19CC1F1D450
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,19CC1F1D458
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFA98E8E2E8]
       vucomisd  xmm0,qword ptr [7FFA98E8E2F0]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98E52488
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FFA986B0968
       call      qword ptr [7FFA986B0968]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA98E52560
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FFA986B0968
       call      qword ptr [7FFA986B0968]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFA986B0970
       call      qword ptr [7FFA986B0970]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FFA986B0970
       call      qword ptr [7FFA986B0970]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 400
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,16A92C0C460
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,16A92C0C458
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,16A92C0C460
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FFAAB4D1CF0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 163
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],sil
       call      qword ptr [7FFAAAFC3918]; System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAAB528248]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FFAAB528250]
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 191
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAB4A24F8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FFAAAB10A88
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAB4A25D0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rcx,[rsi+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FFAAAB10A88
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFAAAB10A90
       call      qword ptr [r11]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      qword ptr [7FFAAAF8B780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FFAAAF8B780]
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FFAAAB10A90
       call      qword ptr [r11]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 387
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,28278BED458
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,28278BED450
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,28278BED458
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFA98E7F178]
       vucomisd  xmm0,qword ptr [7FFA98E7F180]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98E42518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FFA986A0968
       call      qword ptr [7FFA986A0968]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA98E425F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FFA986A0968
       call      qword ptr [7FFA986A0968]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFA986A0970
       call      qword ptr [7FFA986A0970]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FFA986A0970
       call      qword ptr [7FFA986A0970]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 400
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1639400C460
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1639400C458
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1639400C460
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FFAAB4E19F0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 163
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],sil
       call      qword ptr [7FFAAAFE3918]; System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAAB538E28]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FFAAB538E30]
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 191
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAB4B2430
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FFAAAB30A90
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAB4B2508
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rcx,[rsi+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FFAAAB30A90
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFAAAB30A98
       call      qword ptr [r11]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      qword ptr [7FFAAAFAB780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FFAAAFAB780]
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FFAAAB30A98
       call      qword ptr [r11]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 387
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,262D00BD458
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,262D00BD450
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,262D00BD458
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFA98EAEF68]
       vucomisd  xmm0,qword ptr [7FFA98EAEF70]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98E72518
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FFA986D0968
       call      qword ptr [7FFA986D0968]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA98E725F0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FFA986D0968
       call      qword ptr [7FFA986D0968]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFA986D0970
       call      qword ptr [7FFA986D0970]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FFA986D0970
       call      qword ptr [7FFA986D0970]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 400
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1795140C460
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1795140C458
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1795140C460
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FFAAB4D19F0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 163
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],sil
       call      qword ptr [7FFAAAFC3918]; System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAAB528228]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FFAAB528230]
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 191
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAB4A1C48
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FFAAAB10A90
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAB4A1D20
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rcx,[rsi+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FFAAAB10A90
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFAAAB10A98
       call      qword ptr [r11]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      qword ptr [7FFAAAF8B780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FFAAAF8B780]
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FFAAAB10A98
       call      qword ptr [r11]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 387
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1A628B9D458
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1A628B9D450
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1A628B9D458
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFA98E7F368]
       vucomisd  xmm0,qword ptr [7FFA98E7F370]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98E42548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FFA986A0968
       call      qword ptr [7FFA986A0968]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA98E42620
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FFA986A0968
       call      qword ptr [7FFA986A0968]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFA986A0970
       call      qword ptr [7FFA986A0970]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FFA986A0970
       call      qword ptr [7FFA986A0970]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 400
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,17B16C0C460
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,17B16C0C458
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,17B16C0C460
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FFAAB4E3480]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 163
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],sil
       call      qword ptr [7FFAAAFF3918]; System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAAB549348]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FFAAB549350]
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 191
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAB4C2BF0
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FFAAAB40A90
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAB4C2CC8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rcx,[rsi+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FFAAAB40A90
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFAAAB40A98
       call      qword ptr [r11]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      qword ptr [7FFAAAFBB780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FFAAAFBB780]
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FFAAAB40A98
       call      qword ptr [r11]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 387
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2B1B6CED458
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2B1B6CED450
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,2B1B6CED458
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFA98E8F458]
       vucomisd  xmm0,qword ptr [7FFA98E8F460]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98E52548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FFA986B0968
       call      qword ptr [7FFA986B0968]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA98E52620
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FFA986B0968
       call      qword ptr [7FFA986B0968]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFA986B0970
       call      qword ptr [7FFA986B0970]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FFA986B0970
       call      qword ptr [7FFA986B0970]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 400
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2E83740C460
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2E83740C458
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,2E83740C460
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FFAAB4C1138]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 163
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],sil
       call      qword ptr [7FFAAAFD3918]; System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAAB5292A8]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FFAAB5292B0]
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 191
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAB4A2C30
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FFAAAB20A90
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAB4A2D08
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rcx,[rsi+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FFAAAB20A90
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFAAAB20A98
       call      qword ptr [r11]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      qword ptr [7FFAAAF9B780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FFAAAF9B780]
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FFAAAB20A98
       call      qword ptr [r11]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 387
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,20E55ACD458
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,20E55ACD450
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,20E55ACD458
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFA98E7F328]
       vucomisd  xmm0,qword ptr [7FFA98E7F330]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98E42548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FFA986A0968
       call      qword ptr [7FFA986A0968]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA98E42620
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FFA986A0968
       call      qword ptr [7FFA986A0968]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFA986A0970
       call      qword ptr [7FFA986A0970]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FFA986A0970
       call      qword ptr [7FFA986A0970]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 400
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,23827C08058
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,23827C08050
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,23827C08058
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FFAAB4B3CF0]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 163
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],sil
       call      qword ptr [7FFAAAFD3918]; System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAAB5292A8]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FFAAB5292B0]
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 191
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAB4A2730
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FFAAAB20A90
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAB4A2808
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rcx,[rsi+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FFAAAB20A90
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFAAAB20A98
       call      qword ptr [r11]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      qword ptr [7FFAAAF9B780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FFAAAF9B780]
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FFAAAB20A98
       call      qword ptr [r11]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 387
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,2433649D458
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,2433649D450
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,2433649D458
       mov       rdx,rbx
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 162
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],esi
       call      System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFA98E8F388]
       vucomisd  xmm0,qword ptr [7FFA98E8F390]
       seta      al
       movzx     eax,al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 190
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFA98E52548
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FFA986B0968
       call      qword ptr [7FFA986B0968]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFA98E52620
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rax,rsi
       mov       rcx,[rax+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rax+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FFA986B0968
       call      qword ptr [7FFA986B0968]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFA986B0970
       call      qword ptr [7FFA986B0970]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L10:
       mov       ecx,0C
       call      System.Linq.ThrowHelper.ThrowArgumentNullException(System.Linq.ExceptionArgument)
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FFA986B0970
       call      qword ptr [7FFA986B0970]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 400
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItemsWithPredicate()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       rdi,[rsi+288]
       mov       rcx,1E82180C460
       mov       r8,[rcx]
       test      r8,r8
       jne       short M00_L00
       mov       rcx,offset MT_System.Func`2[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib],[System.Boolean, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rdx,1E82180C458
       mov       rdx,[rdx]
       lea       rcx,[rbx+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,offset DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       mov       [rbx+18],rdx
       mov       rcx,1E82180C460
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       r8,rbx
M00_L00:
       test      rdi,rdi
       je        short M00_L01
       test      r8,r8
       jne       short M00_L02
M00_L01:
       mov       ebx,1
       jmp       short M00_L03
M00_L02:
       mov       rdx,rdi
       mov       rcx,offset MD_System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.String, System.Private.CoreLib],[DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.6.Tester]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>,Boolean>)
       call      qword ptr [7FFAAB4C1138]; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       mov       ebx,eax
M00_L03:
       mov       rax,[rsi+18]
       mov       [rax+4C],bl
       add       rsp,20
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 163
```
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark+<>c.<HaveItemsWithPredicate>b__4_0(System.Collections.Generic.KeyValuePair`2<System.String,DotNetTips.Spargine.Tester.Models.RefTypes.PersonProper>)
       push      rsi
       sub       rsp,60
       vzeroupper
       xor       eax,eax
       mov       [rsp+30],rax
       mov       [rsp+38],rax
       mov       rsi,[rdx+8]
       cmp       [rsi],sil
       call      qword ptr [7FFAAAFC3918]; System.DateTime.get_UtcNow()
       mov       [rsp+38],rax
       mov       word ptr [rsp+30],0
       vmovupd   xmm0,[rsp+30]
       vmovupd   [rsp+50],xmm0
       vmovupd   xmm0,[rsi+68]
       vmovupd   [rsp+40],xmm0
       vmovupd   xmm0,[rsp+40]
       vmovupd   [rsp+20],xmm0
       mov       rax,3FFFFFFFFFFFFFFF
       and       rax,[rsp+58]
       mov       rdx,4000000000000000
       or        rax,rdx
       mov       rdx,3FFFFFFFFFFFFFFF
       and       rdx,[rsp+28]
       mov       rcx,4000000000000000
       or        rdx,rcx
       mov       rcx,3FFFFFFFFFFFFFFF
       and       rax,rcx
       and       rdx,rcx
       sub       rax,rdx
       vxorps    xmm0,xmm0,xmm0
       vcvtsi2sd xmm0,xmm0,rax
       vdivsd    xmm0,xmm0,[7FFAAB519448]
       xor       eax,eax
       vucomisd  xmm0,qword ptr [7FFAAB519450]
       seta      al
       add       rsp,60
       pop       rsi
       ret
; Total bytes of code 191
```
```assembly
; System.Linq.Enumerable.Any[[System.Collections.Generic.KeyValuePair`2[[System.__Canon, System.Private.CoreLib],[System.__Canon, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>>, System.Func`2<System.Collections.Generic.KeyValuePair`2<System.__Canon,System.__Canon>,Boolean>)
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,60
       lea       rbp,[rsp+80]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-60],rsp
       mov       [rbp-28],rcx
       mov       rdi,rcx
       mov       rbx,rdx
       mov       rsi,r8
       test      rbx,rbx
       je        near ptr M02_L09
       test      rsi,rsi
       je        near ptr M02_L10
       mov       r14,[rdi+10]
       mov       r11,[r14+10]
       test      r11,r11
       je        short M02_L00
       jmp       short M02_L01
M02_L00:
       mov       rcx,rdi
       mov       rdx,7FFAAB492E00
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L01:
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rbx,rax
       mov       [rbp-58],rbx
       mov       rcx,rbx
       mov       r11,7FFAAAB10A90
       call      qword ptr [r11]
       test      eax,eax
       je        short M02_L06
M02_L02:
       mov       r11,[r14+18]
       test      r11,r11
       je        short M02_L03
       jmp       short M02_L04
M02_L03:
       mov       rcx,rdi
       mov       rdx,7FFAAB492ED8
       call      CORINFO_HELP_RUNTIMEHANDLE_METHOD
       mov       r11,rax
M02_L04:
       lea       rdx,[rbp-38]
       mov       rcx,rbx
       call      qword ptr [r11]
       mov       rcx,[rbp-38]
       mov       [rbp-50],rcx
       mov       rcx,[rbp-30]
       mov       [rbp-48],rcx
       mov       rcx,[rsi+8]
       lea       rdx,[rbp-50]
       call      qword ptr [rsi+18]
       test      eax,eax
       jne       short M02_L05
       mov       rcx,rbx
       mov       r11,7FFAAAB10A90
       call      qword ptr [r11]
       test      eax,eax
       jne       short M02_L02
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-3C],1
       jmp       short M02_L07
M02_L06:
       mov       rcx,rbx
       mov       r11,7FFAAAB10A98
       call      qword ptr [r11]
       jmp       short M02_L08
M02_L07:
       mov       rcx,rsp
       call      M02_L11
       nop
       mov       eax,[rbp-3C]
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L08:
       xor       eax,eax
       add       rsp,60
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
M02_L09:
       mov       ecx,10
       call      qword ptr [7FFAAAF8B780]
       int       3
M02_L10:
       mov       ecx,0C
       call      qword ptr [7FFAAAF8B780]
       int       3
M02_L11:
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+80]
       mov       rbx,[rbp-58]
       test      rbx,rbx
       je        short M02_L12
       mov       rcx,rbx
       mov       r11,7FFAAAB10A98
       call      qword ptr [r11]
M02_L12:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 387
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 72
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB11F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setle     dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4A38D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 72
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
       mov       r11,7FFAAAB00A68
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB00A70
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB00A70
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 72
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB14F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setle     dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4C3B10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 72
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
       mov       r11,7FFAAAB30A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB30A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB30A78
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 72
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB13F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setle     dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4D38D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 72
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
       mov       r11,7FFAAAB20A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB20A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB20A78
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 72
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB12F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setle     dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4B38D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 72
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
       mov       r11,7FFAAAB10A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB10A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB10A78
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 72
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB12F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setle     dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4C3B10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 72
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
       mov       r11,7FFAAAB10A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB10A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB10A78
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 72
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB12F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setle     dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4B3B10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 72
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
       mov       r11,7FFAAAB10A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB10A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB10A78
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setle     dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 72
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.DoesNotHaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       mov       edi,1
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB15F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setle     dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4E3B10]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 72
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
       mov       r11,7FFAAAB40A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB40A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB40A78
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB12F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4C38D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
       mov       r11,7FFAAAB10A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB10A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB10A78
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB15F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4E58D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
       mov       r11,7FFAAAB40A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB40A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB40A78
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB15F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4F38D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
       mov       r11,7FFAAAB40A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB40A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB40A78
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB13F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4C58D0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
       mov       r11,7FFAAAB20A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB20A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB20A78
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB14F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4F53C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
       mov       r11,7FFAAAB30A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB30A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB30A78
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB12F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4C51F8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
       mov       r11,7FFAAAB10A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB10A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB10A78
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dil
       movzx     edi,dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.SortedDictionaryExtensionsBenchmark.HaveItems()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       rcx,[rsi+288]
       test      rcx,rcx
       jne       short M00_L00
       xor       edi,edi
       jmp       short M00_L01
M00_L00:
       call      qword ptr [7FFAAB12F4E0]; DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       xor       edi,edi
       test      eax,eax
       setg      dil
M00_L01:
       mov       [rsp+20],dil
       mov       rcx,[rsi+18]
       lea       rdx,[rsp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FFAAB4B53C0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.Boolean, System.Private.CoreLib]](Boolean ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 69
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
       mov       r11,7FFAAAB10A70
       call      qword ptr [r11]
       mov       rdi,rax
       mov       rcx,rdi
       mov       r11,7FFAAAB10A78
       call      qword ptr [r11]
       test      eax,eax
       je        short M01_L02
M01_L01:
       add       esi,1
       jo        short M01_L03
       mov       rcx,rdi
       mov       r11,7FFAAAB10A78
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

