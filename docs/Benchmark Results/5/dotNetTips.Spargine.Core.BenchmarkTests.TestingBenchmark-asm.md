## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest02()
; 			var result = WIPTests.TryValidateNullAgressive(this._person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rcx+0A8]
       test      rax,rax
       sete      al
       movzx     eax,al
       mov       rdx,[rcx+10]
       mov       [rdx+54],al
       ret
; Total bytes of code 24
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest01()
; 			var result = WIPTests.TryValidateNull(this._person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rcx+0A8]
       test      rax,rax
       sete      al
       movzx     eax,al
       mov       rdx,[rcx+10]
       mov       [rdx+54],al
       ret
; Total bytes of code 24
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest03()
; 			var result = WIPTests.TryValidateNullNoInlining(this._person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0A8]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.BenchmarkTests.WIPTests.TryValidateNullNoInlining(System.Object, Boolean)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.WIPTests.TryValidateNullNoInlining(System.Object, Boolean)
; 			var result = value is null;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (result && throwException)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				ExceptionThrower.ThrowInvalidValueException("Failed", value);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return result;
; 			^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       test      rcx,rcx
       sete      sil
       movzx     esi,sil
       movzx     edx,dl
       test      edx,esi
       je        short M01_L00
       mov       rdx,20F622820D8
       mov       rdx,[rdx]
       mov       r8,rcx
       mov       rcx,offset MD_dotNetTips.Spargine.Core.ExceptionThrower.ThrowInvalidValueException(System.String, !!0)
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowInvalidValueException[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon)
M01_L00:
       mov       eax,esi
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 62
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest04()
; 			var result = WIPTests.TryValidateNullNoOptimization(this._person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rcx+0A8]
       test      rax,rax
       sete      al
       movzx     eax,al
       mov       rdx,[rcx+10]
       mov       [rdx+54],al
       ret
; Total bytes of code 24
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest05()
; 			var result = WIPTests.TryValidateNullPreserveSig(this._person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       mov       rax,[rcx+0A8]
       test      rax,rax
       sete      al
       movzx     eax,al
       mov       rdx,[rcx+10]
       mov       [rdx+54],al
       ret
; Total bytes of code 24
```

## .NET 5.0.13 (5.0.1321.56516), X64 RyuJIT
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.TestingBenchmark.WIPTest06()
; 			var result = WIPTests.TryValidateNullSynchronized(this._person);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			this.Consumer.Consume(result);
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+0A8]
       xor       edx,edx
       call      dotNetTips.Spargine.Core.BenchmarkTests.WIPTests.TryValidateNullSynchronized(System.Object, Boolean)
       mov       rdx,[rsi+10]
       mov       [rdx+54],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 35
```
```assembly
; dotNetTips.Spargine.Core.BenchmarkTests.WIPTests.TryValidateNullSynchronized(System.Object, Boolean)
; 			var result = value is null;
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			if (result && throwException)
; 			^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 				ExceptionThrower.ThrowInvalidValueException("Failed", value);
; 				^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
; 			return result;
; 			^^^^^^^^^^^^^^
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       lea       rbp,[rsp+50]
       mov       [rbp+0FFD0],rsp
       mov       rsi,rcx
       mov       edi,edx
       xor       edx,edx
       mov       [rbp+0FFE0],edx
       lea       rdx,[rbp+0FFE0]
       mov       rcx,1D078239198
       call      CORINFO_HELP_MON_ENTER_STATIC
       test      rsi,rsi
       sete      bl
       movzx     ebx,bl
       movzx     edx,dil
       test      edx,ebx
       je        short M01_L00
       mov       rdx,1D4B9A940D0
       mov       rdx,[rdx]
       mov       r8,rsi
       mov       rcx,offset MD_dotNetTips.Spargine.Core.ExceptionThrower.ThrowInvalidValueException(System.String, !!0)
       call      dotNetTips.Spargine.Core.ExceptionThrower.ThrowInvalidValueException[[System.__Canon, System.Private.CoreLib]](System.String, System.__Canon)
M01_L00:
       lea       rdx,[rbp+0FFE0]
       mov       rcx,1D078239198
       call      CORINFO_HELP_MON_EXIT_STATIC
       movzx     eax,bl
       movzx     eax,al
       lea       rsp,[rbp+0FFE8]
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,28
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+50]
       lea       rdx,[rbp+0FFE0]
       mov       rcx,1D078239198
       call      CORINFO_HELP_MON_EXIT_STATIC
       nop
       add       rsp,28
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 178
```

