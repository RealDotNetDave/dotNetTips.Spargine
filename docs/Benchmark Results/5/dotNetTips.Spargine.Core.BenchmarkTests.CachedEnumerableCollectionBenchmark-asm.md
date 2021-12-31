## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
; 			using var result = CachedEnumerable.Create(this.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1ED6E6B2D20
       mov       rdx,[rdx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFD8],rbx
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,[rbp+0FFD8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M00_L00
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
M00_L00:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 235
```
```assembly
; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       cmp       byte ptr [rsi+20],0
       jne       short M01_L01
       test      dl,dl
       je        short M01_L00
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FF85D2606E0
       call      qword ptr [7FF85D6506E0]
       xor       eax,eax
       mov       [rsi+18],rax
M01_L00:
       mov       byte ptr [rsi+20],1
M01_L01:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       push      rsi
       sub       rsp,20
       test      rcx,rcx
       je        short M02_L00
       add       rsp,20
       pop       rsi
       jmp       near ptr 00007FF8BCEC6FA0
M02_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1325
       mov       rdx,7FF85D254020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 78
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
; 			using var result = CachedEnumerable.Create(this.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1A5FD8D2D20
       mov       rdx,[rdx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFD8],rbx
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,[rbp+0FFD8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M00_L00
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
M00_L00:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 235
```
```assembly
; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       cmp       byte ptr [rsi+20],0
       jne       short M01_L01
       test      dl,dl
       je        short M01_L00
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FF85D2606E0
       call      qword ptr [7FF85D6406E0]
       xor       eax,eax
       mov       [rsi+18],rax
M01_L00:
       mov       byte ptr [rsi+20],1
M01_L01:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       push      rsi
       sub       rsp,20
       test      rcx,rcx
       je        short M02_L00
       add       rsp,20
       pop       rsi
       jmp       near ptr 00007FF8BCEC6FA0
M02_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1325
       mov       rdx,7FF85D254020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 78
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
; 			using var result = CachedEnumerable.Create(this.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1D5D3C82D20
       mov       rdx,[rdx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFD8],rbx
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,[rbp+0FFD8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M00_L00
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
M00_L00:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 235
```
```assembly
; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       cmp       byte ptr [rsi+20],0
       jne       short M01_L01
       test      dl,dl
       je        short M01_L00
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FF85D2506E0
       call      qword ptr [7FF85D6306E0]
       xor       eax,eax
       mov       [rsi+18],rax
M01_L00:
       mov       byte ptr [rsi+20],1
M01_L01:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       push      rsi
       sub       rsp,20
       test      rcx,rcx
       je        short M02_L00
       add       rsp,20
       pop       rsi
       jmp       near ptr 00007FF8BCEC6FA0
M02_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1325
       mov       rdx,7FF85D244020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 78
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
; 			using var result = CachedEnumerable.Create(this.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,125EC432D20
       mov       rdx,[rdx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFD8],rbx
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,[rbp+0FFD8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M00_L00
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
M00_L00:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 235
```
```assembly
; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       cmp       byte ptr [rsi+20],0
       jne       short M01_L01
       test      dl,dl
       je        short M01_L00
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FF85D2606E0
       call      qword ptr [7FF85D6406E0]
       xor       eax,eax
       mov       [rsi+18],rax
M01_L00:
       mov       byte ptr [rsi+20],1
M01_L01:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       push      rsi
       sub       rsp,20
       test      rcx,rcx
       je        short M02_L00
       add       rsp,20
       pop       rsi
       jmp       near ptr 00007FF8BCEC6FA0
M02_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1325
       mov       rdx,7FF85D254020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 78
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
; 			using var result = CachedEnumerable.Create(this.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,22359192D20
       mov       rdx,[rdx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFD8],rbx
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,[rbp+0FFD8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M00_L00
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
M00_L00:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 235
```
```assembly
; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       cmp       byte ptr [rsi+20],0
       jne       short M01_L01
       test      dl,dl
       je        short M01_L00
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FF85D2606E0
       call      qword ptr [7FF85D6406E0]
       xor       eax,eax
       mov       [rsi+18],rax
M01_L00:
       mov       byte ptr [rsi+20],1
M01_L01:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       push      rsi
       sub       rsp,20
       test      rcx,rcx
       je        short M02_L00
       add       rsp,20
       pop       rsi
       jmp       near ptr 00007FF8BCEC6FA0
M02_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1325
       mov       rdx,7FF85D254020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 78
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
; 			using var result = CachedEnumerable.Create(this.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,15236AB2D20
       mov       rdx,[rdx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFD8],rbx
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,[rbp+0FFD8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M00_L00
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
M00_L00:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 235
```
```assembly
; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       cmp       byte ptr [rsi+20],0
       jne       short M01_L01
       test      dl,dl
       je        short M01_L00
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FF85D2706E0
       call      qword ptr [7FF85D6506E0]
       xor       eax,eax
       mov       [rsi+18],rax
M01_L00:
       mov       byte ptr [rsi+20],1
M01_L01:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       push      rsi
       sub       rsp,20
       test      rcx,rcx
       je        short M02_L00
       add       rsp,20
       pop       rsi
       jmp       near ptr 00007FF8BCEC6FA0
M02_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1325
       mov       rdx,7FF85D264020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 78
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
; 			using var result = CachedEnumerable.Create(this.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,196DEC02D20
       mov       rdx,[rdx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFD8],rbx
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,[rbp+0FFD8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M00_L00
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
M00_L00:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 235
```
```assembly
; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       cmp       byte ptr [rsi+20],0
       jne       short M01_L01
       test      dl,dl
       je        short M01_L00
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FF85D2606E0
       call      qword ptr [7FF85D6406E0]
       xor       eax,eax
       mov       [rsi+18],rax
M01_L00:
       mov       byte ptr [rsi+20],1
M01_L01:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       push      rsi
       sub       rsp,20
       test      rcx,rcx
       je        short M02_L00
       add       rsp,20
       pop       rsi
       jmp       near ptr 00007FF8BCEC6FA0
M02_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1325
       mov       rdx,7FF85D254020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 78
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.CachedEnumerableCollectionBenchmark.CollectionCreate01()
; 			using var result = CachedEnumerable.Create(this.PersonProperList);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       rdi,[rsi+158]
       mov       rcx,offset MT_dotNetTips.Spargine.Core.CachedEnumerable`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.Collections.Generic.List`1[[dotNetTips.Spargine.Tester.Models.RefTypes.PersonProper, dotNetTips.Spargine.5.Tester]]
       call      CORINFO_HELP_NEWSFAST
       mov       r14,rax
       mov       rdx,1B052792D20
       mov       rdx,[rdx]
       lea       rcx,[r14+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+8]
       mov       rdx,r14
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       [rbp+0FFD8],rbx
       mov       rcx,[rsi+10]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,[rbp+0FFD8]
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
       nop
       lea       rsp,[rbp+0FFE0]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
       push      rbp
       push      r14
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       cmp       qword ptr [rbp+0FFD8],0
       je        short M00_L00
       mov       rcx,[rbp+0FFD8]
       mov       edx,1
       call      dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       mov       rcx,[rbp+0FFD8]
       call      System.GC.SuppressFinalize(System.Object)
M00_L00:
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r14
       pop       rbp
       ret
; Total bytes of code 235
```
```assembly
; dotNetTips.Spargine.Core.CachedEnumerable`1[[System.__Canon, System.Private.CoreLib]].Dispose(Boolean)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       cmp       byte ptr [rsi+20],0
       jne       short M01_L01
       test      dl,dl
       je        short M01_L00
       mov       rcx,[rsi+18]
       test      rcx,rcx
       je        short M01_L00
       mov       r11,7FF85D2406E8
       call      qword ptr [7FF85D6206E8]
       xor       eax,eax
       mov       [rsi+18],rax
M01_L00:
       mov       byte ptr [rsi+20],1
M01_L01:
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 59
```
```assembly
; System.GC.SuppressFinalize(System.Object)
       push      rsi
       sub       rsp,20
       test      rcx,rcx
       je        short M02_L00
       add       rsp,20
       pop       rsi
       jmp       near ptr 00007FF8BCEC6FA0
M02_L00:
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,1325
       mov       rdx,7FF85D234020
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      System.ArgumentNullException..ctor(System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 78
```

