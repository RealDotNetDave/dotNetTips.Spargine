## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.EnsureTrailingSlash()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      System.Environment.get_ProcessPath()
       mov       rcx,rax
       call      DotNetTips.Spargine.IO.PathHelper.EnsureTrailingSlash(System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 66
```
```assembly
; System.Environment.get_ProcessPath()
       sub       rsp,28
       mov       rax,2529D0310A8
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L01
M01_L00:
       cmp       dword ptr [rax+8],0
       je        short M01_L03
       add       rsp,28
       ret
M01_L01:
       call      System.Environment.GetProcessPath()
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L04
M01_L02:
       mov       rcx,2529D0310A8
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,2529D0310A8
       mov       rax,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       add       rsp,28
       ret
M01_L04:
       mov       rax,2529D033020
       mov       rdx,[rax]
       jmp       short M01_L02
; Total bytes of code 101
```
```assembly
; DotNetTips.Spargine.IO.PathHelper.EnsureTrailingSlash(System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,48
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+20],xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       xor       eax,eax
       mov       [rsp+40],rax
       mov       rsi,rcx
       mov       rcx,rsi
       test      rcx,rcx
       je        short M02_L02
       cmp       dword ptr [rcx+8],0
       je        short M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,1AF
       mov       rdx,7FFA98D27D78
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       edi,[rsi+8]
       lea       eax,[rdi-1]
       cmp       eax,edi
       jae       near ptr M02_L09
       movsxd    rax,eax
       cmp       word ptr [rsi+rax*2+0C],5C
       jne       short M02_L03
       mov       rax,rsi
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       eax,1
       jmp       short M02_L00
M02_L03:
       xor       ecx,ecx
       mov       [rsp+20],rcx
       mov       rcx,2529D032F60
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFA9894F508]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       lea       rbx,[rsp+20]
       mov       [rsp+28],rax
       test      rax,rax
       je        near ptr M02_L07
       lea       r9,[rax+10]
       mov       ebp,[rax+8]
M02_L04:
       add       rbx,18
       mov       [rbx],r9
       mov       [rbx+8],ebp
       xor       r8d,r8d
       mov       [rsp+30],r8d
       mov       byte ptr [rsp+34],0
       cmp       byte ptr [rsp+34],0
       jne       short M02_L06
       mov       r8d,[rsp+30]
       cmp       r8d,[rsp+40]
       ja        short M02_L08
       mov       rcx,[rsp+38]
       mov       edx,[rsp+40]
       sub       edx,r8d
       mov       r8d,r8d
       lea       rcx,[rcx+r8*2]
       mov       r8d,edi
       cmp       r8d,edx
       ja        short M02_L06
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       edi,[rsp+30]
       mov       [rsp+30],edi
M02_L05:
       lea       rcx,[rsp+20]
       mov       edx,5C
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rsp+20]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
       add       rsp,48
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L06:
       lea       rcx,[rsp+20]
       mov       rdx,rsi
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormattedSlow(System.String)
       jmp       short M02_L05
M02_L07:
       xor       r9d,r9d
       xor       ebp,ebp
       jmp       near ptr M02_L04
M02_L08:
       call      System.ThrowHelper.ThrowArgumentOutOfRangeException()
       int       3
M02_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 382
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

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.EnsureTrailingSlash()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FFA971DBC00]; System.Environment.get_ProcessPath()
       mov       rcx,rax
       call      qword ptr [7FFA977998D0]; DotNetTips.Spargine.IO.PathHelper.EnsureTrailingSlash(System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFA977999D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; System.Environment.get_ProcessPath()
       sub       rsp,28
       mov       rax,2313A0000D0
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L01
M01_L00:
       cmp       dword ptr [rax+8],0
       je        short M01_L03
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FFA971DBE88]; System.Environment.GetProcessPath()
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L04
M01_L02:
       mov       rcx,2313A0000D0
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,2313A0000D0
       mov       rax,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       add       rsp,28
       ret
M01_L04:
       mov       rax,2313A002028
       mov       rdx,[rax]
       jmp       short M01_L02
; Total bytes of code 102
```
```assembly
; DotNetTips.Spargine.IO.PathHelper.EnsureTrailingSlash(System.String)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,58
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rsp+30],xmm4
       vmovdqa   xmmword ptr [rsp+40],xmm4
       xor       eax,eax
       mov       [rsp+50],rax
       mov       rsi,rcx
       mov       rcx,rsi
       test      rcx,rcx
       je        short M02_L00
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M02_L01
       jmp       short M02_L01
M02_L00:
       xor       eax,eax
M02_L01:
       test      eax,eax
       jne       near ptr M02_L02
       call      qword ptr [7FFA9757B450]
       mov       rsi,rax
       mov       ecx,1AF
       mov       rdx,7FFA977A5BC0
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,32C
       mov       rdx,7FFA973962D8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,6D0
       mov       rdx,7FFA973962D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA97579C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9757B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9757B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA972FFF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA97193510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       edi,[rsi+8]
       lea       eax,[rdi-1]
       cmp       eax,edi
       jae       near ptr M02_L09
       mov       eax,eax
       cmp       word ptr [rsi+rax*2+0C],5C
       jne       short M02_L03
       mov       rax,rsi
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L03:
       xor       ecx,ecx
       mov       [rsp+30],rcx
       mov       rcx,2313A001F88
       mov       rcx,[rcx]
       mov       edx,100
       call      qword ptr [7FFA97391030]; System.Buffers.TlsOverPerCoreLockedStacksArrayPool`1[[System.Char, System.Private.CoreLib]].Rent(Int32)
       mov       [rsp+38],rax
       test      rax,rax
       je        near ptr M02_L07
       lea       rbx,[rax+10]
       mov       ebp,[rax+8]
M02_L04:
       mov       [rsp+48],rbx
       mov       [rsp+50],ebp
       xor       r8d,r8d
       mov       [rsp+40],r8d
       mov       byte ptr [rsp+44],0
       cmp       byte ptr [rsp+44],0
       jne       short M02_L06
       mov       r8d,[rsp+40]
       cmp       r8d,[rsp+50]
       ja        short M02_L08
       mov       rcx,[rsp+48]
       mov       edx,r8d
       lea       rcx,[rcx+rdx*2]
       mov       edx,[rsp+50]
       sub       edx,r8d
       cmp       edi,edx
       ja        short M02_L06
       lea       rdx,[rsi+0C]
       mov       r8d,edi
       add       r8,r8
       call      qword ptr [7FFA971D99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       add       edi,[rsp+40]
       mov       [rsp+40],edi
M02_L05:
       lea       rcx,[rsp+30]
       mov       edx,5C
       call      qword ptr [7FFA977999C0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       lea       rcx,[rsp+30]
       call      qword ptr [7FFA9720D930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       nop
       add       rsp,58
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L06:
       lea       rcx,[rsp+30]
       mov       rdx,rsi
       call      qword ptr [7FFA9720DA50]
       jmp       short M02_L05
M02_L07:
       xor       ebx,ebx
       xor       ebp,ebp
       jmp       near ptr M02_L04
M02_L08:
       call      qword ptr [7FFA97357498]
       int       3
M02_L09:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 506
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

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.HasInvalidFilterChars()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,[rsi+28]
       mov       word ptr [rax+8],5C
       mov       rdx,rax
       call      System.String.Concat(System.Object, System.Object)
       mov       rcx,rax
       call      DotNetTips.Spargine.IO.PathHelper.HasInvalidFilterChars(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 62
```
```assembly
; System.String.Concat(System.Object, System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       test      rcx,rcx
       jne       short M01_L00
       xor       edi,edi
       jmp       short M01_L01
M01_L00:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdi,rax
M01_L01:
       test      rsi,rsi
       jne       short M01_L02
       xor       edx,edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdx,rax
M01_L03:
       mov       rcx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.Concat(System.String, System.String)
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.IO.PathHelper.HasInvalidFilterChars(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       test      rcx,rcx
       je        near ptr M02_L02
       cmp       dword ptr [rcx+8],0
       je        short M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,3DF
       mov       rdx,7FFA98D17F80
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,156D3174DE8
       mov       rcx,[rcx]
       call      System.Collections.Generic.EnumerableHelpers.ToArray[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>)
       mov       rdx,rax
       mov       r9d,[rsi+8]
       mov       rcx,rsi
       xor       r8d,r8d
       call      System.String.IndexOfAny(Char[], Int32, Int32)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,20
       pop       rsi
       ret
M02_L02:
       mov       eax,1
       jmp       short M02_L00
; Total bytes of code 153
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.HasInvalidFilterChars()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,[rsi+28]
       mov       word ptr [rax+8],5C
       mov       rdx,rax
       call      qword ptr [7FFA971A1BE8]; System.String.Concat(System.Object, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFA977AB078]; DotNetTips.Spargine.IO.PathHelper.HasInvalidFilterChars(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; System.String.Concat(System.Object, System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       test      rcx,rcx
       jne       short M01_L00
       xor       edi,edi
       jmp       short M01_L01
M01_L00:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdi,rax
M01_L01:
       test      rsi,rsi
       jne       short M01_L02
       xor       edx,edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdx,rax
M01_L03:
       mov       rcx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFA971A1C60]; System.String.Concat(System.String, System.String)
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.IO.PathHelper.HasInvalidFilterChars(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,50
       mov       rsi,rcx
M02_L00:
       mov       rcx,rsi
       test      rcx,rcx
       je        short M02_L01
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M02_L02
       jmp       short M02_L02
M02_L01:
       xor       eax,eax
M02_L02:
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FFA9758B450]
       mov       rsi,rax
       mov       ecx,3DF
       mov       rdx,7FFA977B6818
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,32C
       mov       rdx,7FFA973A62D8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,6D0
       mov       rdx,7FFA973A62D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA97589C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9758B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9758B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9730FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L03:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971A3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,1EA14804CC0
       mov       rcx,[rcx]
       call      qword ptr [7FFA977ABCC0]; System.Collections.Generic.EnumerableHelpers.ToArray[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>)
       cmp       [rsi],sil
       test      rax,rax
       je        near ptr M02_L06
       lea       rcx,[rsi+0C]
       mov       r8d,[rsi+8]
       lea       rdx,[rax+10]
       mov       r9d,[rax+8]
       mov       [rsp+4C],r8d
       mov       [rsp+40],rdx
       cmp       r9d,5
       ja        near ptr M02_L04
       mov       eax,r9d
       lea       r9,[7FFA9715FC60]
       mov       r9d,[r9+rax*4]
       lea       r10,[M02_L00]
       add       r9,r10
       jmp       r9
       mov       eax,0FFFFFFFF
       jmp       near ptr M02_L05
       mov       rdx,[rsp+40]
       movsx     rdx,word ptr [rdx]
       call      qword ptr [7FFA97455AF8]; System.SpanHelpers.IndexOfValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int32)
       jmp       near ptr M02_L05
       mov       rdx,[rsp+40]
       movsx     r9,word ptr [rdx]
       movsx     rax,word ptr [rdx+2]
       mov       edx,r9d
       mov       r8d,eax
       mov       r9d,[rsp+4C]
       call      qword ptr [7FFA977E58A0]
       jmp       near ptr M02_L05
       mov       rdx,[rsp+40]
       movsx     r9,word ptr [rdx]
       movsx     rax,word ptr [rdx+2]
       movsx     r10,word ptr [rdx+4]
       mov       [rsp+20],r8d
       mov       edx,r9d
       mov       r8d,eax
       mov       r9d,r10d
       call      qword ptr [7FFA97451C78]; System.SpanHelpers.IndexOfAnyValueType[[System.Int16, System.Private.CoreLib],[System.SpanHelpers+DontNegate`1[[System.Int16, System.Private.CoreLib]], System.Private.CoreLib]](Int16 ByRef, Int16, Int16, Int16, Int32)
       jmp       short M02_L05
       mov       rdx,[rsp+40]
       movsx     r9,word ptr [rdx]
       movsx     rax,word ptr [rdx+2]
       movsx     r10,word ptr [rdx+4]
       movsx     rdx,word ptr [rdx+6]
       mov       [rsp+20],edx
       mov       [rsp+28],r8d
       mov       edx,r9d
       mov       r8d,eax
       mov       r9d,r10d
       call      qword ptr [7FFA977E7150]
       jmp       short M02_L05
       mov       rdx,[rsp+40]
       movsx     r9,word ptr [rdx]
       movsx     rax,word ptr [rdx+2]
       movsx     r10,word ptr [rdx+4]
       movsx     r11,word ptr [rdx+6]
       movsx     rdx,word ptr [rdx+8]
       mov       [rsp+20],r11d
       mov       [rsp+28],edx
       mov       [rsp+30],r8d
       mov       edx,r9d
       mov       r8d,eax
       mov       r9d,r10d
       call      qword ptr [7FFA977E3D68]
       jmp       short M02_L05
M02_L04:
       mov       edx,r8d
       mov       r8,[rsp+40]
       call      qword ptr [7FFA9745FD50]; System.MemoryExtensions.IndexOfAnyProbabilistic(Char ByRef, Int32, Char ByRef, Int32)
M02_L05:
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,50
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L06:
       mov       ecx,60
       call      qword ptr [7FFA973677B0]
       int       3
; Total bytes of code 585
```

## .NET 6.0.16 (6.0.1623.17311), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.PathContainsWildcard()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,[rsi+28]
       mov       word ptr [rax+8],2A
       mov       rdx,rax
       call      System.String.Concat(System.Object, System.Object)
       mov       rcx,rax
       call      DotNetTips.Spargine.IO.PathHelper.PathContainsWildcard(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 62
```
```assembly
; System.String.Concat(System.Object, System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       test      rcx,rcx
       jne       short M01_L00
       xor       edi,edi
       jmp       short M01_L01
M01_L00:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdi,rax
M01_L01:
       test      rsi,rsi
       jne       short M01_L02
       xor       edx,edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdx,rax
M01_L03:
       mov       rcx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       near ptr System.String.Concat(System.String, System.String)
; Total bytes of code 70
```
```assembly
; DotNetTips.Spargine.IO.PathHelper.PathContainsWildcard(System.String)
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,rsi
       test      rcx,rcx
       je        short M02_L02
       cmp       dword ptr [rcx+8],0
       je        short M02_L02
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,1AF
       mov       rdx,7FFA98D277B0
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       test      rsi,rsi
       je        short M02_L04
       mov       rcx,rsi
       mov       edx,2A
       mov       r8d,4
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L04
       jmp       short M02_L03
M02_L02:
       mov       eax,1
       jmp       short M02_L00
M02_L03:
       mov       rcx,rsi
       mov       edx,3F
       mov       r8d,4
       call      System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,20
       pop       rsi
       ret
M02_L04:
       mov       eax,1
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 182
```

## .NET 7.0.5 (7.0.523.17405), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.PathContainsWildcard()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,offset MT_System.Char
       call      CORINFO_HELP_NEWSFAST
       mov       rcx,[rsi+28]
       mov       word ptr [rax+8],2A
       mov       rdx,rax
       call      qword ptr [7FFA971B1BE8]; System.String.Concat(System.Object, System.Object)
       mov       rcx,rax
       call      qword ptr [7FFA977A9390]; DotNetTips.Spargine.IO.PathHelper.PathContainsWildcard(System.String)
       mov       rdx,[rsi+18]
       mov       [rdx+4C],al
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 64
```
```assembly
; System.String.Concat(System.Object, System.Object)
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rdx
       test      rcx,rcx
       jne       short M01_L00
       xor       edi,edi
       jmp       short M01_L01
M01_L00:
       mov       rax,[rcx]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdi,rax
M01_L01:
       test      rsi,rsi
       jne       short M01_L02
       xor       edx,edx
       jmp       short M01_L03
M01_L02:
       mov       rcx,rsi
       mov       rax,[rsi]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       rdx,rax
M01_L03:
       mov       rcx,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       jmp       qword ptr [7FFA971B1C60]; System.String.Concat(System.String, System.String)
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.IO.PathHelper.PathContainsWildcard(System.String)
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       mov       rsi,rcx
       mov       rcx,rsi
       test      rcx,rcx
       je        short M02_L00
       mov       eax,[rcx+8]
       xor       edx,edx
       test      eax,eax
       sete      dl
       test      edx,edx
       sete      dl
       movzx     edx,dl
       test      eax,eax
       jne       short M02_L01
       jmp       short M02_L01
M02_L00:
       xor       edx,edx
M02_L01:
       test      edx,edx
       jne       near ptr M02_L02
       call      qword ptr [7FFA9759B450]
       mov       rsi,rax
       mov       ecx,1AF
       mov       rdx,7FFA977C4A38
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,32C
       mov       rdx,7FFA973B62D8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,6D0
       mov       rdx,7FFA973B62D8
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFA97599C48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFA9759B078]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFA9759B510]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFA9731FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L02:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFA971B3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       test      rsi,rsi
       je        short M02_L03
       mov       rcx,rsi
       mov       edx,2A
       mov       r8d,4
       call      qword ptr [7FFA971B35E8]; System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       jne       short M02_L03
       mov       rcx,rsi
       mov       edx,3F
       mov       r8d,4
       call      qword ptr [7FFA971B35E8]; System.String.IndexOf(Char, System.StringComparison)
       cmp       eax,0FFFFFFFF
       setne     al
       movzx     eax,al
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       eax,1
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 310
```

