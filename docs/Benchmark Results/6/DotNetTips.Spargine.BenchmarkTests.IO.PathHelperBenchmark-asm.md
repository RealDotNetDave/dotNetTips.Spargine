## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       mov       rax,1D2675710A8
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
       mov       rcx,1D2675710A8
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,1D2675710A8
       mov       rax,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       add       rsp,28
       ret
M01_L04:
       mov       rax,1D267573020
       mov       rdx,[rax]
       jmp       short M01_L02
; Total bytes of code 101
```
```assembly
; DotNetTips.Spargine.IO.PathHelper.EnsureTrailingSlash(System.String)
       push      rbp
       push      rsi
       sub       rsp,88
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5BAB080],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       r9,1D267579790
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1D267573020
       mov       r9,[r9]
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       [rbp-48],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.String.get_Length()
       mov       [rbp-4C],eax
       mov       edx,[rbp-4C]
       dec       edx
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      System.String.get_Chars(Int32)
       mov       [rbp-50],eax
       mov       esi,[rbp-50]
       mov       rcx,7FF9C5634938
       mov       edx,725
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       movzx     ecx,word ptr [7FF9C56353CC]
       cmp       esi,ecx
       jne       short M02_L01
       mov       rcx,[rbp+10]
       mov       [rbp-58],rcx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rbp-30]
       xor       edx,edx
       mov       r8d,2
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-30]
       mov       rdx,[rbp+10]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       nop
       mov       rcx,7FF9C5634938
       mov       edx,725
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       movzx     edx,word ptr [7FF9C56353CC]
       mov       [rbp-5C],edx
       mov       edx,[rbp-5C]
       lea       rcx,[rbp-30]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       nop
       lea       rcx,[rbp-30]
       call      System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       [rbp-58],rax
M02_L02:
       mov       rax,[rbp-58]
       mov       [rbp-38],rax
       nop
       jmp       short M02_L03
M02_L03:
       mov       rax,[rbp-38]
       add       rsp,88
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 327
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
; DotNetTips.Spargine.BenchmarkTests.IO.PathHelperBenchmark.EnsureTrailingSlash()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FF9BFC0BC00]; System.Environment.get_ProcessPath()
       mov       rcx,rax
       call      qword ptr [7FF9C01C9360]; DotNetTips.Spargine.IO.PathHelper.EnsureTrailingSlash(System.String)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C01C9468]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 69
```
```assembly
; System.Environment.get_ProcessPath()
       sub       rsp,28
       mov       rax,2916E8000D0
       mov       rax,[rax]
       test      rax,rax
       je        short M01_L01
M01_L00:
       cmp       dword ptr [rax+8],0
       je        short M01_L03
       add       rsp,28
       ret
M01_L01:
       call      qword ptr [7FF9BFC0BE88]; System.Environment.GetProcessPath()
       mov       rdx,rax
       test      rdx,rdx
       je        short M01_L04
M01_L02:
       mov       rcx,2916E8000D0
       xor       r8d,r8d
       call      System.Threading.Interlocked.CompareExchange(System.Object ByRef, System.Object, System.Object)
       mov       rax,2916E8000D0
       mov       rax,[rax]
       jmp       short M01_L00
M01_L03:
       xor       eax,eax
       add       rsp,28
       ret
M01_L04:
       mov       rax,2916E802028
       mov       rdx,[rax]
       jmp       short M01_L02
; Total bytes of code 102
```
```assembly
; DotNetTips.Spargine.IO.PathHelper.EnsureTrailingSlash(System.String)
       push      rbp
       push      rsi
       sub       rsp,88
       lea       rbp,[rsp+90]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C01D5058],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       r9,2916E8087C8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2916E802028
       mov       r9,[r9]
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9BFF8BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-40],rax
       mov       rcx,[rbp-40]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       mov       [rbp-48],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9BFBC1BA0]; System.String.get_Length()
       mov       [rbp-4C],eax
       mov       edx,[rbp-4C]
       dec       edx
       mov       rcx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9BFBC1B88]; System.String.get_Chars(Int32)
       mov       [rbp-50],eax
       mov       esi,[rbp-50]
       mov       rcx,7FF9BFA94C10
       mov       edx,76E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       movzx     ecx,word ptr [7FF9BFA95728]
       cmp       esi,ecx
       jne       short M02_L01
       mov       rcx,[rbp+10]
       mov       [rbp-58],rcx
       jmp       short M02_L02
M02_L01:
       lea       rcx,[rbp-30]
       xor       edx,edx
       mov       r8d,2
       call      qword ptr [7FF9BFC3D8A0]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler..ctor(Int32, Int32)
       lea       rcx,[rbp-30]
       mov       rdx,[rbp+10]
       call      qword ptr [7FF9BFC3DA38]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted(System.String)
       nop
       mov       rcx,7FF9BFA94C10
       mov       edx,76E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       movzx     edx,word ptr [7FF9BFA95728]
       mov       [rbp-5C],edx
       mov       edx,[rbp-5C]
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9C01C9450]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.AppendFormatted[[System.Char, System.Private.CoreLib]](Char)
       nop
       lea       rcx,[rbp-30]
       call      qword ptr [7FF9BFC3D930]; System.Runtime.CompilerServices.DefaultInterpolatedStringHandler.ToStringAndClear()
       mov       [rbp-58],rax
M02_L02:
       mov       rax,[rbp-58]
       mov       [rbp-38],rax
       nop
       mov       rax,[rbp-38]
       add       rsp,88
       pop       rsi
       pop       rbp
       ret
; Total bytes of code 332
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
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5BBAFC8],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       r9,29BA4381B78
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,29BB4383020
       mov       r9,[r9]
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-10],rax
       mov       rax,[rbp-10]
       mov       [rbp+10],rax
       mov       rax,[rbp+10]
       mov       [rbp-18],rax
       call      DotNetTips.Spargine.IO.PathHelper.InvalidFilterChars()
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       call      System.Linq.Enumerable.ToArray[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>)
       mov       [rbp-28],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      System.String.IndexOfAny(Char[])
       mov       [rbp-2C],eax
       cmp       dword ptr [rbp-2C],0FFFFFFFF
       setne     al
       movzx     eax,al
       mov       [rbp-4],eax
       nop
       jmp       short M02_L01
M02_L01:
       mov       eax,[rbp-4]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 182
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9BFBB1BE8]; System.String.Concat(System.Object, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9C01BB378]; DotNetTips.Spargine.IO.PathHelper.HasInvalidFilterChars(System.String)
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
       jmp       qword ptr [7FF9BFBB1C60]; System.String.Concat(System.String, System.String)
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.IO.PathHelper.HasInvalidFilterChars(System.String)
       push      rbp
       sub       rsp,60
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp-28],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C01C72B0],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       r9,1B8AC000BB0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1B8B0002028
       mov       r9,[r9]
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9BFF7BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-10],rax
       mov       rax,[rbp-10]
       mov       [rbp+10],rax
       mov       rax,[rbp+10]
       mov       [rbp-18],rax
       call      qword ptr [7FF9C01BB3C0]; DotNetTips.Spargine.IO.PathHelper.InvalidFilterChars()
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       call      qword ptr [7FF9C01BB438]; System.Linq.Enumerable.ToArray[[System.Char, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<Char>)
       mov       [rbp-28],rax
       mov       rcx,[rbp-18]
       mov       rdx,[rbp-28]
       cmp       [rcx],ecx
       call      qword ptr [7FF9BFBB3630]; System.String.IndexOfAny(Char[])
       mov       [rbp-2C],eax
       xor       eax,eax
       cmp       dword ptr [rbp-2C],0FFFFFFFF
       setne     al
       mov       [rbp-4],eax
       nop
       mov       eax,[rbp-4]
       add       rsp,60
       pop       rbp
       ret
; Total bytes of code 183
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-24],eax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5BDB080],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       r9,264EBEF9790
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,264EBEF3020
       mov       r9,[r9]
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       jne       short M02_L01
       mov       dword ptr [rbp-18],1
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       edx,2A
       mov       r8d,4
       call      System.String.IndexOf(Char, System.StringComparison)
       mov       [rbp-14],eax
       cmp       dword ptr [rbp-14],0FFFFFFFF
       setne     cl
       movzx     ecx,cl
       mov       [rbp-18],ecx
M02_L02:
       cmp       dword ptr [rbp-18],0
       jne       short M02_L05
       cmp       qword ptr [rbp+10],0
       jne       short M02_L03
       mov       dword ptr [rbp-24],1
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       edx,3F
       mov       r8d,4
       call      System.String.IndexOf(Char, System.StringComparison)
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0FFFFFFFF
       setne     al
       movzx     eax,al
       mov       [rbp-24],eax
M02_L04:
       mov       eax,[rbp-24]
       mov       [rbp-1C],eax
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-1C],1
M02_L06:
       mov       eax,[rbp-1C]
       movzx     eax,al
       mov       [rbp-4],eax
       nop
       jmp       short M02_L07
M02_L07:
       mov       eax,[rbp-4]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 254
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
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
       call      qword ptr [7FF9BFBA1BE8]; System.String.Concat(System.Object, System.Object)
       mov       rcx,rax
       call      qword ptr [7FF9C01A9090]; DotNetTips.Spargine.IO.PathHelper.PathContainsWildcard(System.String)
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
       jmp       qword ptr [7FF9BFBA1C60]; System.String.Concat(System.String, System.String)
; Total bytes of code 71
```
```assembly
; DotNetTips.Spargine.IO.PathHelper.PathContainsWildcard(System.String)
       push      rbp
       sub       rsp,50
       lea       rbp,[rsp+50]
       xor       eax,eax
       mov       [rbp-24],eax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C01B5658],0
       je        short M02_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M02_L00:
       nop
       mov       r9,1594B4003E8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1594F402028
       mov       r9,[r9]
       mov       rcx,[rbp+10]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9BFF6BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       [rbp+10],rcx
       cmp       qword ptr [rbp+10],0
       jne       short M02_L01
       mov       dword ptr [rbp-18],1
       jmp       short M02_L02
M02_L01:
       mov       rcx,[rbp+10]
       mov       edx,2A
       mov       r8d,4
       call      qword ptr [7FF9BFBA35E8]; System.String.IndexOf(Char, System.StringComparison)
       mov       [rbp-14],eax
       xor       ecx,ecx
       cmp       dword ptr [rbp-14],0FFFFFFFF
       setne     cl
       mov       [rbp-18],ecx
M02_L02:
       cmp       dword ptr [rbp-18],0
       jne       short M02_L05
       cmp       qword ptr [rbp+10],0
       jne       short M02_L03
       mov       dword ptr [rbp-24],1
       jmp       short M02_L04
M02_L03:
       mov       rcx,[rbp+10]
       mov       edx,3F
       mov       r8d,4
       call      qword ptr [7FF9BFBA35E8]; System.String.IndexOf(Char, System.StringComparison)
       mov       [rbp-20],eax
       xor       eax,eax
       cmp       dword ptr [rbp-20],0FFFFFFFF
       setne     al
       mov       [rbp-24],eax
M02_L04:
       mov       eax,[rbp-24]
       mov       [rbp-1C],eax
       jmp       short M02_L06
M02_L05:
       mov       dword ptr [rbp-1C],1
M02_L06:
       mov       eax,[rbp-1C]
       movzx     eax,al
       mov       [rbp-4],eax
       nop
       mov       eax,[rbp-4]
       add       rsp,50
       pop       rbp
       ret
; Total bytes of code 253
```

