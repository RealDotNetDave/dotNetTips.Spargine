## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF9C57D55D0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5981668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,2BBE7FE15C0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2BBE7FD1028
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       r9,[rbp-10]
       mov       [rbp+18],r9
       mov       r9,2BC37FD1C28
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2BBE7FD1028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rdx,2BC37FD1C30
       mov       rdx,[rdx]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-4],eax
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rax,[rbp+18]
       mov       edx,[rbp-4]
       cmp       edx,[rax+8]
       jb        short M01_L02
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,2BC37FD1C38
       mov       rax,[rax]
       mov       [rbp-38],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-4]
       add       ecx,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-4],ecx
M01_L04:
       mov       eax,[rbp-4]
       mov       rdx,[rbp+18]
       cmp       eax,[rdx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-8],eax
       cmp       dword ptr [rbp-8],0
       jne       near ptr M01_L01
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,2BBE7FD1028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      qword ptr [7FF9C68B7018]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF9C63A7D30]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68B7138]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C65358C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,25D228125B8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,25D22802028
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C657BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       r9,[rbp-10]
       mov       [rbp+18],r9
       mov       r9,25D32800C78
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,25D22802028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C657BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rdx,25D32800C80
       mov       rdx,[rdx]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63BB288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-4],eax
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rax,[rbp+18]
       mov       edx,[rbp-4]
       cmp       edx,[rax+8]
       jb        short M01_L02
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,25D32800C88
       mov       rax,[rax]
       mov       [rbp-38],rax
       call      qword ptr [7FF9C6319990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C6049288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63BB288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-4]
       add       ecx,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-4],ecx
M01_L04:
       mov       eax,[rbp-4]
       mov       rdx,[rbp+18]
       cmp       eax,[rdx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-8],eax
       cmp       dword ptr [rbp-8],0
       jne       near ptr M01_L01
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63BB3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 428
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,25D22802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C615D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6365750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF9C57E55D0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5991668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,1B2CBDCD4A0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1B2CBDC3020
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       r9,[rbp-10]
       mov       [rbp+18],r9
       mov       r9,1B33BDC1C28
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1B2CBDC3020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rdx,1B33BDC1C30
       mov       rdx,[rdx]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-4],eax
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rax,[rbp+18]
       mov       edx,[rbp-4]
       cmp       edx,[rax+8]
       jb        short M01_L02
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,1B33BDC1C38
       mov       rax,[rax]
       mov       [rbp-38],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-4]
       add       ecx,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-4],ecx
M01_L04:
       mov       eax,[rbp-4]
       mov       rdx,[rbp+18]
       cmp       eax,[rdx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-8],eax
       cmp       dword ptr [rbp-8],0
       jne       near ptr M01_L01
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1B2CBDC3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      qword ptr [7FF9C6899018]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF9C6377D30]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6899138]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C65058C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,12B488125B8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,12B48802028
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C654BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       r9,[rbp-10]
       mov       [rbp+18],r9
       mov       r9,12B4C800C78
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,12B48802028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C654BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rdx,12B4C800C80
       mov       rdx,[rdx]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-4],eax
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rax,[rbp+18]
       mov       edx,[rbp-4]
       cmp       edx,[rax+8]
       jb        short M01_L02
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,12B4C800C88
       mov       rax,[rax]
       mov       [rbp-38],rax
       call      qword ptr [7FF9C62E9990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C6019288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-4]
       add       ecx,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-4],ecx
M01_L04:
       mov       eax,[rbp-4]
       mov       rdx,[rbp+18]
       cmp       eax,[rdx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-8],eax
       cmp       dword ptr [rbp-8],0
       jne       near ptr M01_L01
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 428
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,12B48802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C612D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6335750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF9C58055D0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C59B1668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,26BED2F35B8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,26BED2E3020
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       r9,[rbp-10]
       mov       [rbp+18],r9
       mov       r9,26C5D2E1C28
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,26BED2E3020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rdx,26C5D2E1C30
       mov       rdx,[rdx]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-4],eax
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rax,[rbp+18]
       mov       edx,[rbp-4]
       cmp       edx,[rax+8]
       jb        short M01_L02
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,26C5D2E1C38
       mov       rax,[rax]
       mov       [rbp-38],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-4]
       add       ecx,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-4],ecx
M01_L04:
       mov       eax,[rbp-4]
       mov       rdx,[rbp+18]
       cmp       eax,[rdx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-8],eax
       cmp       dword ptr [rbp-8],0
       jne       near ptr M01_L01
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,26BED2E3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      qword ptr [7FF9C68B7018]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF9C63A7D30]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68B7138]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C65358C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,1CEF2C125B8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1CEF2C02028
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C657BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       r9,[rbp-10]
       mov       [rbp+18],r9
       mov       r9,1CF02C00C78
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1CEF2C02028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C657BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rdx,1CF02C00C80
       mov       rdx,[rdx]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63BB288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-4],eax
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rax,[rbp+18]
       mov       edx,[rbp-4]
       cmp       edx,[rax+8]
       jb        short M01_L02
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,1CF02C00C88
       mov       rax,[rax]
       mov       [rbp-38],rax
       call      qword ptr [7FF9C6319990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C6049288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63BB288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-4]
       add       ecx,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-4],ecx
M01_L04:
       mov       eax,[rbp-4]
       mov       rdx,[rbp+18]
       cmp       eax,[rdx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-8],eax
       cmp       dword ptr [rbp-8],0
       jne       near ptr M01_L01
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63BB3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 428
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1CEF2C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C615D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6365750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF9C57D55D0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5981668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,1EDF8A335B8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1EDF8A23020
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       r9,[rbp-10]
       mov       [rbp+18],r9
       mov       r9,1EE58A21C28
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1EDF8A23020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rdx,1EE58A21C30
       mov       rdx,[rdx]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-4],eax
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rax,[rbp+18]
       mov       edx,[rbp-4]
       cmp       edx,[rax+8]
       jb        short M01_L02
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,1EE58A21C38
       mov       rax,[rax]
       mov       [rbp-38],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-4]
       add       ecx,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-4],ecx
M01_L04:
       mov       eax,[rbp-4]
       mov       rdx,[rbp+18]
       cmp       eax,[rdx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-8],eax
       cmp       dword ptr [rbp-8],0
       jne       near ptr M01_L01
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1EDF8A23020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      qword ptr [7FF9C68D7018]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF9C63B7D30]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68D7138]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C65458C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,216330125B8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21633002028
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C658BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       r9,[rbp-10]
       mov       [rbp+18],r9
       mov       r9,2163F000C78
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21633002028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C658BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rdx,2163F000C80
       mov       rdx,[rdx]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63CB288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-4],eax
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rax,[rbp+18]
       mov       edx,[rbp-4]
       cmp       edx,[rax+8]
       jb        short M01_L02
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,2163F000C88
       mov       rax,[rax]
       mov       [rbp-38],rax
       call      qword ptr [7FF9C6329990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C6059288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63CB288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-4]
       add       ecx,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-4],ecx
M01_L04:
       mov       eax,[rbp-4]
       mov       rdx,[rbp+18]
       cmp       eax,[rdx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-8],eax
       cmp       dword ptr [rbp-8],0
       jne       near ptr M01_L01
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63CB3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 428
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61899F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,21633002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EF4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EF4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C616D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6375750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF9C57D55D0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5981668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,1C0CB7735B8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1C0CB763020
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       r9,[rbp-10]
       mov       [rbp+18],r9
       mov       r9,1C13B761C28
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1C0CB763020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rdx,1C13B761C30
       mov       rdx,[rdx]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-4],eax
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rax,[rbp+18]
       mov       edx,[rbp-4]
       cmp       edx,[rax+8]
       jb        short M01_L02
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,1C13B761C38
       mov       rax,[rax]
       mov       [rbp-38],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-4]
       add       ecx,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-4],ecx
M01_L04:
       mov       eax,[rbp-4]
       mov       rdx,[rbp+18]
       cmp       eax,[rdx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-8],eax
       cmp       dword ptr [rbp-8],0
       jne       near ptr M01_L01
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1C0CB763020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      qword ptr [7FF9C6895B88]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF9C6387D30]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6895CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C65158C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,11AD3000100
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,11AD7002028
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C655BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       r9,[rbp-10]
       mov       [rbp+18],r9
       mov       r9,11AE5000C78
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,11AD7002028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C655BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rdx,11AE5000C80
       mov       rdx,[rdx]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-4],eax
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rax,[rbp+18]
       mov       edx,[rbp-4]
       cmp       edx,[rax+8]
       jb        short M01_L02
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,11AE5000C88
       mov       rax,[rax]
       mov       [rbp-38],rax
       call      qword ptr [7FF9C62F9990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C6029288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-4]
       add       ecx,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-4],ecx
M01_L04:
       mov       eax,[rbp-4]
       mov       rdx,[rbp+18]
       cmp       eax,[rdx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-8],eax
       cmp       dword ptr [rbp-8],0
       jne       near ptr M01_L01
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 428
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,11AD7002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EC4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EC4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C613D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6345750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF9C57D55D0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C5981668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,1E12E4515C0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E12E443020
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       r9,[rbp-10]
       mov       [rbp+18],r9
       mov       r9,1E17E441C28
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E12E443020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rdx,1E17E441C30
       mov       rdx,[rdx]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-4],eax
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rax,[rbp+18]
       mov       edx,[rbp-4]
       cmp       edx,[rax+8]
       jb        short M01_L02
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,1E17E441C38
       mov       rax,[rax]
       mov       [rbp-38],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-4]
       add       ecx,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-4],ecx
M01_L04:
       mov       eax,[rbp-4]
       mov       rdx,[rbp+18]
       cmp       eax,[rdx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-8],eax
       cmp       dword ptr [rbp-8],0
       jne       near ptr M01_L01
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1E12E443020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      qword ptr [7FF9C6899018]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF9C6377D30]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6899138]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C65058C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,19F8B0125B8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,19F8B002028
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C654BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       r9,[rbp-10]
       mov       [rbp+18],r9
       mov       r9,19F93000C78
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,19F8B002028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C654BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rdx,19F93000C80
       mov       rdx,[rdx]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-4],eax
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rax,[rbp+18]
       mov       edx,[rbp-4]
       cmp       edx,[rax+8]
       jb        short M01_L02
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,19F93000C88
       mov       rax,[rax]
       mov       [rbp-38],rax
       call      qword ptr [7FF9C62E9990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C6019288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-4]
       add       ecx,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-4],ecx
M01_L04:
       mov       eax,[rbp-4]
       mov       rdx,[rbp+18]
       cmp       eax,[rdx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-8],eax
       cmp       dword ptr [rbp-8],0
       jne       near ptr M01_L01
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 428
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,19F8B002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C612D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6335750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF9C57F55D0]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C59A1668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,1E47EAC35B8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E47EAB3020
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       r9,[rbp-10]
       mov       [rbp+18],r9
       mov       r9,1E4EEAB1C28
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E47EAB3020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rdx,1E4EEAB1C30
       mov       rdx,[rdx]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-4],eax
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rax,[rbp+18]
       mov       edx,[rbp-4]
       cmp       edx,[rax+8]
       jb        short M01_L02
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,1E4EEAB1C38
       mov       rax,[rax]
       mov       [rbp-38],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-4]
       add       ecx,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-4],ecx
M01_L04:
       mov       eax,[rbp-4]
       mov       rdx,[rbp+18]
       cmp       eax,[rdx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-8],eax
       cmp       dword ptr [rbp-8],0
       jne       near ptr M01_L01
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 421
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1E47EAB3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54D4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       rdx,[rsi+298]
       mov       rcx,rdi
       call      qword ptr [7FF9C68B5B88]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       mov       rcx,rdi
       call      qword ptr [7FF9C63A7D30]; System.Text.StringBuilder.ToString()
       mov       [rsp+20],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+20]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68B5CA8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 138
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendBytes(System.Text.StringBuilder, Byte[])
       push      rbp
       sub       rsp,80
       lea       rbp,[rsp+80]
       xor       eax,eax
       mov       [rbp-58],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-50],xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       cmp       dword ptr [7FF9C65358C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r9,204984125B8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,20498402028
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Byte[], System.Private.CoreLib]](Byte[], Byte[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C657BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-10],rax
       mov       r9,[rbp-10]
       mov       [rbp+18],r9
       mov       r9,204AA400C78
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,20498402028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C657BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-18],rax
       mov       rdx,204AA400C80
       mov       rdx,[rdx]
       mov       rcx,[rbp-18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63BB288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp+10],rax
       xor       eax,eax
       mov       [rbp-4],eax
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rax,[rbp+18]
       mov       edx,[rbp-4]
       cmp       edx,[rax+8]
       jb        short M01_L02
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-28],rax
       mov       rax,[rbp+10]
       mov       [rbp-30],rax
       mov       rax,204AA400C88
       mov       rax,[rax]
       mov       [rbp-38],rax
       call      qword ptr [7FF9C6319990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-40],rax
       mov       rcx,[rbp-28]
       mov       rdx,[rbp-38]
       mov       r8,[rbp-40]
       call      qword ptr [7FF9C6049288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-48],rax
       mov       rcx,[rbp-30]
       mov       rdx,[rbp-48]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63BB288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-50],rax
       nop
       nop
       mov       ecx,[rbp-4]
       add       ecx,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-4],ecx
M01_L04:
       mov       eax,[rbp-4]
       mov       rdx,[rbp+18]
       cmp       eax,[rdx+8]
       setl      al
       movzx     eax,al
       mov       [rbp-8],eax
       cmp       dword ptr [rbp-8],0
       jne       near ptr M01_L01
       mov       rcx,[rbp+10]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63BB3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-58],rax
       nop
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 428
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,20498402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C615D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6365750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+288]
       mov       rdx,260B7593B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF9C57D55D0]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5981668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,260B7595910
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,260B7583020
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,260B7595918
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,260B7583020
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String[], System.Private.CoreLib]](System.String[], System.String[], System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 384
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,260B7583020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+288]
       mov       rdx,20C404006A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9C6887060]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF9C6377D30]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C65058C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FF9C6887108]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,20C44414148
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,20C44402028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C654BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,20C44414150
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,20C44402028
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String[], System.Private.CoreLib]](System.String[], System.String[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C654BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6887000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FF9C6886120
       call      qword ptr [7FF9C606B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF9C6887168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 390
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,20C44402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C612D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6335750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+288]
       mov       rdx,2B3B9CD16A8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF9C57F55D0]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C59A1668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,2B3E9CD1C28
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,2B399CD3020
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,2B3E9CD1C30
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2B399CD3020
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String[], System.Private.CoreLib]](System.String[], System.String[], System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 384
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,2B399CD3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54D4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+288]
       mov       rdx,210E0412B58
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9C68B7060]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF9C6397D30]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C65258C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FF9C68B7108]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,210EA400C78
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,210E0402028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C656BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,210EA400C80
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,210E0402028
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String[], System.Private.CoreLib]](System.String[], System.String[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C656BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C68B7000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FF9C68B6120
       call      qword ptr [7FF9C608B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF9C68B7168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 390
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,210E0402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C614D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6355750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+288]
       mov       rdx,1AFEA613B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF9C57E55D0]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5991668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,1B03A601C28
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,1AFEA603020
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,1B03A601C30
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1AFEA603020
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String[], System.Private.CoreLib]](System.String[], System.String[], System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 384
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1AFEA603020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+288]
       mov       rdx,22524C12B58
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9C68B7060]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF9C63A7D30]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C65358C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FF9C68B7108]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,22536C00C78
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,22524C02028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C657BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,22536C00C80
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,22524C02028
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String[], System.Private.CoreLib]](System.String[], System.String[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C657BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C68B7000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FF9C68B6120
       call      qword ptr [7FF9C609B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF9C68B7168]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 390
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,22524C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C615D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6365750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+288]
       mov       rdx,239FC9D3B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF9C58055D0]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C59B1668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,23A5C9C1C28
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,239FC9C3020
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,23A5C9C1C30
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,239FC9C3020
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String[], System.Private.CoreLib]](System.String[], System.String[], System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 384
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,239FC9C3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+288]
       mov       rdx,1FEC1010B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9C6897360]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF9C6377D30]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C65058C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FF9C6897408]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,1FEBD001C90
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,1FEC1000030
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C654BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,1FEBD001C98
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1FEC1000030
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String[], System.Private.CoreLib]](System.String[], System.String[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C654BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6897300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FF9C6896420
       call      qword ptr [7FF9C606B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF9C6897468]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 390
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1FEC1000030
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C612D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6335750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+288]
       mov       rdx,25159D43B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF9C57E55D0]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5991668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,251C9D31C28
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,25159D33020
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,251C9D31C30
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,25159D33020
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String[], System.Private.CoreLib]](System.String[], System.String[], System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 384
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,25159D33020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+288]
       mov       rdx,171034006A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9C68A5BD0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF9C6397D30]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C65258C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FF9C68A5C78]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,1710B400C78
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,170FB400030
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C656BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,1710B400C80
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,170FB400030
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String[], System.Private.CoreLib]](System.String[], System.String[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C656BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C68A5B70]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FF9C68A4C90
       call      qword ptr [7FF9C608B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF9C68A5CD8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 390
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,170FB400030
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C614D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6355750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+288]
       mov       rdx,210F30F3B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF9C57F55D0]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C59A1668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,210E30E1C28
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,210F30E3020
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,210E30E1C30
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,210F30E3020
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String[], System.Private.CoreLib]](System.String[], System.String[], System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 384
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,210F30E3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54D4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54D4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+288]
       mov       rdx,12BCDC10B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9C68B5BD0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF9C63A7D30]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C65358C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FF9C68B5C78]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,12BD5C00C78
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,12BCDC00030
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C657BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,12BD5C00C80
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,12BCDC00030
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String[], System.Private.CoreLib]](System.String[], System.String[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C657BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C68B5B70]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FF9C68B4C90
       call      qword ptr [7FF9C609B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF9C68B5CD8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 390
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,12BCDC00030
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C615D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6365750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+288]
       mov       rdx,1B4F5153B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF9C58055D0]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C59B1668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,1B4F5155910
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,1B4F5143020
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,1B4F5155918
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1B4F5143020
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String[], System.Private.CoreLib]](System.String[], System.String[], System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0.<AppendValues>b__0(System.String)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 384
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1B4F5143020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues01()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+288]
       mov       rdx,26909C12B58
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9C68B5BD0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       mov       rcx,rdi
       call      qword ptr [7FF9C63A7D30]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.String[])
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C65358C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FF9C68B5C78]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass5_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,2691BC00C78
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,26909C02028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C657BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,2691BC00C80
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,26909C02028
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String[], System.Private.CoreLib]](System.String[], System.String[], System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C657BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C68B5B70]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-40],rcx
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-8]
       mov       r8,7FF9C68B4C90
       call      qword ptr [7FF9C609B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-38]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-40]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF9C68B5CD8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 390
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,26909C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C615D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6365750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+290]
       mov       rdx,1DB65CF3B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF9C57D55D0]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5981668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,1DBD5CE1C28
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,1DB65CE3020
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,1DBD5CE1C30
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1DB65CE3020
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+18],r9
       mov       r9,1DBD5CE1C38
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1DB65CE3020
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, System.Collections.Generic.IEnumerable`1<System.String>, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-8]
       mov       r8,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-48]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 455
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1DB65CE3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+290]
       mov       rdx,22653012B58
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9C68C9348]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF9C63A7D30]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C65358C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FF9C68C9408]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,22653013948
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,22653002028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C657BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,22653013950
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,22653002028
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C657BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+18],r9
       mov       r9,22653013958
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,22653002028
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, System.Collections.Generic.IEnumerable`1<System.String>, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C657BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C68C9300]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-8]
       mov       r8,7FF9C68C8420
       call      qword ptr [7FF9C609B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-48]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF9C68C9480]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 462
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,22653002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C615D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6365750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+290]
       mov       rdx,2918CB93B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF9C57E55D0]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5991668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,2917CB81C28
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,2918CB83020
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,2917CB81C30
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2918CB83020
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+18],r9
       mov       r9,2917CB81C38
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2918CB83020
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, System.Collections.Generic.IEnumerable`1<System.String>, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-8]
       mov       r8,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-48]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 455
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,2918CB83020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+290]
       mov       rdx,21004012B58
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9C68A7048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF9C6387D30]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C65158C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FF9C68A7108]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,21014000C78
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,21004002028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C655BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,21014000C80
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21004002028
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C655BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+18],r9
       mov       r9,21014000C88
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21004002028
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, System.Collections.Generic.IEnumerable`1<System.String>, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C655BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C68A7000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-8]
       mov       r8,7FF9C68A6120
       call      qword ptr [7FF9C607B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-48]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF9C68A7180]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 462
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,21004002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EC4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EC4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C613D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6345750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+290]
       mov       rdx,1E8DD1A1750
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF9C58055D0]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C59B1668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,1E8DD1A24E8
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,1E8FD191028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,1E8DD1A24F0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E8FD191028
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+18],r9
       mov       r9,1E8DD1A24F8
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E8FD191028
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, System.Collections.Generic.IEnumerable`1<System.String>, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-8]
       mov       r8,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-48]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 455
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1E8FD191028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+290]
       mov       rdx,24C2C412B58
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9C68A5BB8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF9C6397D30]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C65258C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FF9C68A5C78]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,24C3E400C78
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,24C2C402028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C656BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,24C3E400C80
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,24C2C402028
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C656BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+18],r9
       mov       r9,24C3E400C88
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,24C2C402028
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, System.Collections.Generic.IEnumerable`1<System.String>, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C656BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C68A5B70]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-8]
       mov       r8,7FF9C68A4C90
       call      qword ptr [7FF9C608B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-48]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF9C68A5CF0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 462
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,24C2C402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C614D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6355750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+290]
       mov       rdx,24089CF3B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF9C57D55D0]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5981668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,240E9CE1C28
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,24089CE3020
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,240E9CE1C30
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,24089CE3020
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+18],r9
       mov       r9,240E9CE1C38
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,24089CE3020
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, System.Collections.Generic.IEnumerable`1<System.String>, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-8]
       mov       r8,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-48]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 455
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,24089CE3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+290]
       mov       rdx,243474006A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9C6897048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF9C6377D30]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C65058C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FF9C6897108]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,24355400C78
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,2434B402028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C654BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,24355400C80
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2434B402028
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C654BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+18],r9
       mov       r9,24355400C88
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2434B402028
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, System.Collections.Generic.IEnumerable`1<System.String>, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C654BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6897000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-8]
       mov       r8,7FF9C6896120
       call      qword ptr [7FF9C606B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-48]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF9C6897180]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 462
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,2434B402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C612D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6335750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+290]
       mov       rdx,2AC85F9DA48
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF9C57D55D0]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5981668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,2ACE5F91C28
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,2AC85F93020
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,2ACE5F91C30
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2AC85F93020
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+18],r9
       mov       r9,2ACE5F91C38
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2AC85F93020
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, System.Collections.Generic.IEnumerable`1<System.String>, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-8]
       mov       r8,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-48]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 455
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,2AC85F93020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+290]
       mov       rdx,2AB6D810B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9C68A7048]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF9C6397D30]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C65258C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FF9C68A7108]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,2AB77800C78
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,2AB6D800030
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C656BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,2AB77800C80
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2AB6D800030
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C656BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+18],r9
       mov       r9,2AB77800C88
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2AB6D800030
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, System.Collections.Generic.IEnumerable`1<System.String>, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C656BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C68A7000]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-8]
       mov       r8,7FF9C68A6120
       call      qword ptr [7FF9C608B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-48]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF9C68A7180]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 462
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,2AB6D800030
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C614D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6355750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+290]
       mov       rdx,1E2874C3B60
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF9C57D55D0]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5981668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,1E2E74B1C28
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,1E2874B3020
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,1E2E74B1C30
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E2874B3020
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+18],r9
       mov       r9,1E2E74B1C38
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E2874B3020
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, System.Collections.Generic.IEnumerable`1<System.String>, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-8]
       mov       r8,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-48]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 455
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1E2874B3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+290]
       mov       rdx,208BE812B58
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9C68A5BB8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF9C6397D30]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C65258C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FF9C68A5C78]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,208D0800C78
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,208BE802028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C656BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,208D0800C80
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,208BE802028
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C656BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+18],r9
       mov       r9,208D0800C88
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,208BE802028
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, System.Collections.Generic.IEnumerable`1<System.String>, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C656BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C68A5B70]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-8]
       mov       r8,7FF9C68A4C90
       call      qword ptr [7FF9C608B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-48]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF9C68A5CF0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 462
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,208BE802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C614D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6355750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+290]
       mov       rdx,200B5EDBBC8
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF9C57D55D0]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 146
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C5981668],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,20115ED1C28
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,200B5ED3020
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,20115ED1C30
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,200B5ED3020
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+18],r9
       mov       r9,20115ED1C38
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,200B5ED3020
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, System.Collections.Generic.IEnumerable`1<System.String>, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-8]
       mov       r8,offset DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0.<AppendValues>b__0(System.String)
       call      System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-48]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 455
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,200B5ED3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendValues02()
       push      rdi
       push      rsi
       sub       rsp,28
       xor       eax,eax
       mov       [rsp+20],rax
       mov       rsi,rcx
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
       mov       r8,[rsi+290]
       mov       rdx,23E1C8006A0
       mov       rdx,[rdx]
       mov       rcx,rdi
       call      qword ptr [7FF9C68978B8]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       mov       rcx,rdi
       call      qword ptr [7FF9C6377D30]; System.Text.StringBuilder.ToString()
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
; Total bytes of code 147
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues(System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>)
       push      rbp
       sub       rsp,70
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-48],rax
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-40],xmm4
       vmovdqa   xmmword ptr [rbp-30],xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       cmp       dword ptr [7FF9C65058C0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       call      qword ptr [7FF9C6897978]; DotNetTips.Spargine.Extensions.StringBuilderExtensions+<>c__DisplayClass4_0..ctor()
       mov       rdx,[rbp-10]
       mov       [rbp-8],rdx
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       mov       rdx,[rbp-8]
       mov       [rbp-18],rdx
       mov       rdx,23E24801C90
       mov       rdx,[rdx]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-8]
       mov       rdx,[rdx+8]
       mov       r9,23E20802028
       mov       r9,[r9]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C654BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-20],rax
       mov       rdx,[rbp-18]
       lea       rcx,[rdx+8]
       mov       rdx,[rbp-20]
       call      CORINFO_HELP_ASSIGN_REF
       mov       r9,23E24801C98
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,23E20802028
       mov       r9,[r9]
       mov       rdx,[rbp+18]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.String, System.Private.CoreLib]](System.String, System.String, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C654BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+18],r9
       mov       r9,23E24801CA0
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,23E20802028
       mov       r9,[r9]
       mov       rdx,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Collections.Generic.IEnumerable`1[[System.String, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.String>, System.Collections.Generic.IEnumerable`1<System.String>, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C654BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-30],rax
       mov       rcx,[rbp-30]
       mov       [rbp+20],rcx
       mov       rcx,[rbp+18]
       call      qword ptr [7FF9C6897870]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.SetSeparator(System.String)
       mov       [rbp-38],rax
       mov       rcx,[rbp-38]
       mov       [rbp+18],rcx
       mov       rcx,offset MT_System.Action`1[[System.String, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rcx,[rbp-8]
       mov       rcx,[rcx+8]
       mov       [rbp-48],rcx
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-8]
       mov       r8,7FF9C6896990
       call      qword ptr [7FF9C606B648]; System.MulticastDelegate.CtorClosed(System.Object, IntPtr)
       mov       rdx,[rbp-40]
       mov       [rsp+20],rdx
       mov       rdx,[rbp-48]
       mov       r8,[rbp+18]
       mov       r9,[rbp+20]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.String, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.String>, System.Action`1<System.String>)
       call      qword ptr [7FF9C68979F0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendValues[[System.__Canon, System.Private.CoreLib]](System.Text.StringBuilder, System.String, System.Collections.Generic.IEnumerable`1<System.__Canon>, System.Action`1<System.__Canon>)
       nop
       nop
       add       rsp,70
       pop       rbp
       ret
; Total bytes of code 462
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,23E20802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C612D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6335750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5820340],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,1A6AD413020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L08
M01_L02:
       mov       rcx,7FF9C5820990
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A6AD417930
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,1A70D411C28
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,1A70D411C30
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       movsxd    rax,eax
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       jmp       short M01_L07
M01_L07:
       mov       rcx,rsp
       call      M01_L09
       nop
M01_L08:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L09:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C5820990
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1A6AD417930
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 563
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FF9C68B7870]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68B7948]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C63C1B58],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,1C948002028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF9C63C2318
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C94800CAE0
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,1C94A001C90
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63AB288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,1C94A001C98
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      qword ptr [7FF9C6309990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9C6039288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63AB288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       cdqe
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63AB3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C63C2318
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1C94800CAE0
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 564
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C57F0340],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,15C49AE3020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L08
M01_L02:
       mov       rcx,7FF9C57F0990
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,15C49AEDA48
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,15C99AE1C28
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,15C99AE1C30
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       movsxd    rax,eax
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       jmp       short M01_L07
M01_L07:
       mov       rcx,rsp
       call      M01_L09
       nop
M01_L08:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L09:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C57F0990
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,15C49AEDA48
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 563
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FF9C6897000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68970D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C63A1B58],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,20A59402028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF9C63A2318
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20A5940CAE0
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,20A5B401C90
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,20A5B401C98
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      qword ptr [7FF9C62E9990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9C6019288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       cdqe
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C63A2318
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,20A5940CAE0
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 564
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5810340],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,1FD7BF83020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L08
M01_L02:
       mov       rcx,7FF9C5810990
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FD7BF8DA48
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,1FDDBF81C28
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,1FDDBF81C30
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       movsxd    rax,eax
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       jmp       short M01_L07
M01_L07:
       mov       rcx,rsp
       call      M01_L09
       nop
M01_L08:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L09:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C5810990
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FD7BF8DA48
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 563
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FF9C6897000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68970D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C63B1B58],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,2355A802028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF9C63B2318
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2355A80CAE0
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,2356A800C78
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,2356A800C80
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      qword ptr [7FF9C62F9990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9C6029288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       cdqe
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C63B2318
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2355A80CAE0
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 564
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5800340],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,21ABF563020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L08
M01_L02:
       mov       rcx,7FF9C5800990
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21ABF56DA48
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,21B2F561C28
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,21B2F561C30
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       movsxd    rax,eax
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       jmp       short M01_L07
M01_L07:
       mov       rcx,rsp
       call      M01_L09
       nop
M01_L08:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L09:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C5800990
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21ABF56DA48
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 563
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FF9C6887000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68870D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C63A1B58],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,19C12002028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF9C63A2318
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,19C1200CAE0
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,19C10001C90
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,19C10001C98
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      qword ptr [7FF9C62E9990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9C6019288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       cdqe
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C63A2318
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,19C1200CAE0
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 564
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5820340],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,1D3E1E73020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L08
M01_L02:
       mov       rcx,7FF9C5820990
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D3E1E7DA48
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,1D441E71C28
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,1D441E71C30
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       movsxd    rax,eax
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       jmp       short M01_L07
M01_L07:
       mov       rcx,rsp
       call      M01_L09
       nop
M01_L08:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L09:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C5820990
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1D3E1E7DA48
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 563
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FF9C6897000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68970D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C63B1B58],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,1620F402028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF9C63B2318
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1620F40CAE0
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,1620F413948
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,1620F413950
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      qword ptr [7FF9C62F9990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9C6029288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       cdqe
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C63B2318
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1620F40CAE0
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 564
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C5820340],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,24429641028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L08
M01_L02:
       mov       rcx,7FF9C5820990
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24409645520
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,24469641C28
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,24469641C30
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       movsxd    rax,eax
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       jmp       short M01_L07
M01_L07:
       mov       rcx,rsp
       call      M01_L09
       nop
M01_L08:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L09:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C5820990
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,24409645520
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 563
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FF9C68C7000]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68C70D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C63E1B58],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,21E4A802028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF9C63E2318
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21E4A80CAE0
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,21E56800C78
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63CB288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,21E56800C80
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      qword ptr [7FF9C6329990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9C6059288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63CB288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       cdqe
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63CB3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C63E2318
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,21E4A80CAE0
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 564
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
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
; Total bytes of code 65
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C57F0340],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       cmp       qword ptr [rbp+10],0
       sete      cl
       movzx     ecx,cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,1FA770B3020
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L08
M01_L02:
       mov       rcx,7FF9C57F0990
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FA770BDA48
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,1FAE70B1C28
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,1FAE70B1C30
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       movsxd    rax,eax
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       jmp       short M01_L07
M01_L07:
       mov       rcx,rsp
       call      M01_L09
       nop
M01_L08:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L09:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C57F0990
       mov       edx,1D
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,1FA770BDA48
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 563
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendBytes03()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+298]
       call      qword ptr [7FF9C68A7300]; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C68A73D8]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 67
```
```assembly
; DotNetTips.Spargine.Core.FastStringBuilder.BytesToString(Byte[])
       push      rbp
       sub       rsp,0B0
       lea       rbp,[rsp+0B0]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-80],xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp-90],rsp
       mov       [rbp+10],rcx
       cmp       dword ptr [7FF9C63B1B58],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       xor       ecx,ecx
       cmp       qword ptr [rbp+10],0
       sete      cl
       mov       [rbp-0C],ecx
       cmp       dword ptr [rbp-0C],0
       je        short M01_L02
       nop
       mov       rcx,26440C02028
       mov       rcx,[rcx]
       mov       [rbp-18],rcx
       nop
       jmp       near ptr M01_L07
M01_L02:
       mov       rcx,7FF9C63B2318
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2643CC086D8
       mov       rcx,[rcx]
       mov       [rbp-78],rcx
       mov       rcx,[rbp-78]
       mov       rax,[rbp-78]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       [rbp-28],rax
       mov       rdx,[rbp-28]
       mov       [rbp-8],rdx
       nop
       mov       rdx,26442C01C90
       mov       rdx,[rdx]
       mov       rcx,[rbp-8]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-30],rax
       nop
       xor       eax,eax
       mov       [rbp-1C],eax
       nop
       jmp       short M01_L06
M01_L03:
       nop
       mov       rax,[rbp+10]
       mov       edx,[rbp-1C]
       cmp       edx,[rax+8]
       jb        short M01_L04
       call      CORINFO_HELP_RNGCHKFAIL
M01_L04:
       mov       ecx,edx
       lea       rax,[rax+rcx+10]
       mov       [rbp-38],rax
       mov       rax,[rbp-8]
       mov       [rbp-40],rax
       mov       rax,26442C01C98
       mov       rax,[rax]
       mov       [rbp-48],rax
       call      qword ptr [7FF9C62F9990]; System.Globalization.CultureInfo.get_InvariantCulture()
       mov       [rbp-50],rax
       mov       rcx,[rbp-38]
       mov       rdx,[rbp-48]
       mov       r8,[rbp-50]
       call      qword ptr [7FF9C6029288]; System.Byte.ToString(System.String, System.IFormatProvider)
       mov       [rbp-58],rax
       mov       rcx,[rbp-40]
       mov       rdx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
       mov       ecx,[rbp-1C]
       add       ecx,1
       jno       short M01_L05
       call      CORINFO_HELP_OVERFLOW
M01_L05:
       mov       [rbp-1C],ecx
M01_L06:
       mov       eax,[rbp-1C]
       cdqe
       mov       rdx,[rbp+10]
       mov       edx,[rdx+8]
       movsxd    rdx,edx
       cmp       rax,rdx
       setl      al
       movzx     eax,al
       mov       [rbp-20],eax
       cmp       dword ptr [rbp-20],0
       jne       near ptr M01_L03
       mov       rcx,[rbp-8]
       mov       edx,27
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       mov       rcx,[rbp-8]
       mov       rax,[rbp-8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+8]
       mov       [rbp-70],rax
       mov       rcx,[rbp-70]
       mov       [rbp-18],rcx
       nop
       mov       rcx,rsp
       call      M01_L08
       nop
M01_L07:
       mov       rax,[rbp-18]
       add       rsp,0B0
       pop       rbp
       ret
M01_L08:
       push      rbp
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+0B0]
       nop
       mov       rcx,7FF9C63B2318
       mov       edx,2E
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rcx,2643CC086D8
       mov       rcx,[rcx]
       mov       [rbp-80],rcx
       mov       rcx,[rbp-80]
       mov       rdx,[rbp-8]
       mov       rax,[rbp-80]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+28]
       nop
       nop
       nop
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 564
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
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
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
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9C58055D0]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C59B1668],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       r9,21449F41C28
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,213E9F43020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+10],r9
       mov       r9,213E9F53D18
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,213E9F43020
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       [rbp+18],r9
       mov       r9,213E9F53638
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,213E9F43020
       mov       r9,[r9]
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-38],rax
       mov       r8,[rbp-38]
       mov       [rbp+20],r8
       mov       r8,21449F41C30
       mov       r8,[r8]
       mov       rdx,213E9F43020
       mov       rdx,[rdx]
       mov       ecx,[rbp+28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-3C],eax
       mov       r8d,[rbp-3C]
       mov       [rbp+28],r8d
       mov       r8,21449F41C38
       mov       r8,[r8]
       mov       rdx,213E9F43020
       mov       rdx,[rdx]
       mov       ecx,[rbp+30]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+30],ecx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-50],rax
       nop
       mov       ecx,[rbp+28]
       add       ecx,2
       cmp       ecx,1
       jbe       short M01_L02
       nop
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L04
M01_L03:
       xor       ecx,ecx
       mov       [rbp-4],ecx
M01_L04:
       mov       ecx,[rbp-4]
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L11
M01_L05:
       nop
       mov       rcx,7FF9C59B1B98
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,213E9F4E350
       mov       rdx,[rdx]
       mov       [rbp-0C8],rdx
       mov       rdx,[rbp-0C8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-6C],eax
       mov       r9d,[rbp-6C]
       mov       [rbp-10],r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       movzx     r9d,r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L08
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-0A0],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-0A8],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      System.String.get_Chars(Int32)
       mov       [rbp-0B4],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-0C0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-80],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-84],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      System.String.get_Length()
       mov       [rbp-88],eax
       mov       r9d,[rbp-88]
       sub       r9d,[rbp-0C]
       jno       short M01_L09
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-80]
       mov       r8d,[rbp-84]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       nop
       jmp       short M01_L12
M01_L10:
       nop
M01_L11:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       nop
       nop
       jmp       short M01_L14
M01_L13:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
M01_L14:
       mov       edx,[rbp+30]
       add       edx,2
       cmp       edx,1
       jbe       short M01_L15
       nop
       jmp       short M01_L16
M01_L15:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L17
M01_L16:
       xor       edx,edx
       mov       [rbp-4],edx
M01_L17:
       mov       edx,[rbp-4]
       mov       [rbp-1C],edx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L18
       nop
       mov       rdx,213E9F53B60
       mov       rdx,[rdx]
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
M01_L18:
       nop
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 971
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,213E9F43020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
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
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9C68A7030]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9C6397D30]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C65258C0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       r9,215A1800C78
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21591802028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C656BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+10],r9
       mov       r9,2158F800048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21591802028
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9C656BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       [rbp+18],r9
       mov       r9,21591812520
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,21591802028
       mov       r9,[r9]
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9C656BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-38],rax
       mov       r8,[rbp-38]
       mov       [rbp+20],r8
       mov       r8,215A1800C80
       mov       r8,[r8]
       mov       rdx,21591802028
       mov       rdx,[rdx]
       mov       ecx,[rbp+28]
       call      qword ptr [7FF9C68A7120]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-3C],eax
       mov       r8d,[rbp-3C]
       mov       [rbp+28],r8d
       mov       r8,215A1800C88
       mov       r8,[r8]
       mov       rdx,21591802028
       mov       rdx,[rdx]
       mov       ecx,[rbp+30]
       call      qword ptr [7FF9C68A7120]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+30],ecx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63AB288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63AB3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-50],rax
       nop
       mov       ecx,[rbp+28]
       add       ecx,2
       cmp       ecx,1
       jbe       short M01_L02
       nop
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L04
M01_L03:
       xor       ecx,ecx
       mov       [rbp-4],ecx
M01_L04:
       mov       ecx,[rbp-4]
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63AB3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L11
M01_L05:
       nop
       mov       rcx,7FF9C6525DB0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,2159180D618
       mov       rdx,[rdx]
       mov       [rbp-0C8],rdx
       mov       rdx,[rbp-0C8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6123648]; System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-6C],eax
       mov       r9d,[rbp-6C]
       mov       [rbp-10],r9d
       xor       r9d,r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L08
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63AB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-0A0],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63AB3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0A8],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6121B88]; System.String.get_Chars(Int32)
       mov       [rbp-0B4],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63AB3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0C0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-80],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-84],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6121BA0]; System.String.get_Length()
       mov       [rbp-88],eax
       mov       r9d,[rbp-88]
       sub       r9d,[rbp-0C]
       jno       short M01_L09
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-80]
       mov       r8d,[rbp-84]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63AB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       nop
       jmp       short M01_L12
M01_L10:
       nop
M01_L11:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63AB3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       nop
       nop
       jmp       short M01_L14
M01_L13:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63AB288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
M01_L14:
       mov       edx,[rbp+30]
       add       edx,2
       cmp       edx,1
       jbe       short M01_L15
       nop
       jmp       short M01_L16
M01_L15:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L17
M01_L16:
       xor       edx,edx
       mov       [rbp-4],edx
M01_L17:
       mov       edx,[rbp-4]
       mov       [rbp-1C],edx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L18
       nop
       mov       rdx,21591812B58
       mov       rdx,[rdx]
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63AB288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
M01_L18:
       nop
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 988
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,21591802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5ED4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C614D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6355750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
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
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9C57C55D0]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C5971668],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       r9,1F1A15D1C28
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1F1315D3020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+10],r9
       mov       r9,1F1315E3D18
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1F1315D3020
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       [rbp+18],r9
       mov       r9,1F1315E3638
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1F1315D3020
       mov       r9,[r9]
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-38],rax
       mov       r8,[rbp-38]
       mov       [rbp+20],r8
       mov       r8,1F1A15D1C30
       mov       r8,[r8]
       mov       rdx,1F1315D3020
       mov       rdx,[rdx]
       mov       ecx,[rbp+28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-3C],eax
       mov       r8d,[rbp-3C]
       mov       [rbp+28],r8d
       mov       r8,1F1A15D1C38
       mov       r8,[r8]
       mov       rdx,1F1315D3020
       mov       rdx,[rdx]
       mov       ecx,[rbp+30]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+30],ecx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-50],rax
       nop
       mov       ecx,[rbp+28]
       add       ecx,2
       cmp       ecx,1
       jbe       short M01_L02
       nop
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L04
M01_L03:
       xor       ecx,ecx
       mov       [rbp-4],ecx
M01_L04:
       mov       ecx,[rbp-4]
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L11
M01_L05:
       nop
       mov       rcx,7FF9C5971B98
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1F1315DE350
       mov       rdx,[rdx]
       mov       [rbp-0C8],rdx
       mov       rdx,[rbp-0C8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-6C],eax
       mov       r9d,[rbp-6C]
       mov       [rbp-10],r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       movzx     r9d,r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L08
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-0A0],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-0A8],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      System.String.get_Chars(Int32)
       mov       [rbp-0B4],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-0C0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-80],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-84],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      System.String.get_Length()
       mov       [rbp-88],eax
       mov       r9d,[rbp-88]
       sub       r9d,[rbp-0C]
       jno       short M01_L09
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-80]
       mov       r8d,[rbp-84]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       nop
       jmp       short M01_L12
M01_L10:
       nop
M01_L11:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       nop
       nop
       jmp       short M01_L14
M01_L13:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
M01_L14:
       mov       edx,[rbp+30]
       add       edx,2
       cmp       edx,1
       jbe       short M01_L15
       nop
       jmp       short M01_L16
M01_L15:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L17
M01_L16:
       xor       edx,edx
       mov       [rbp-4],edx
M01_L17:
       mov       edx,[rbp-4]
       mov       [rbp-1C],edx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L18
       nop
       mov       rdx,1F1315E3B60
       mov       rdx,[rdx]
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
M01_L18:
       nop
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 971
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1F1315D3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
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
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9C6885BA0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9C6377D30]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C65058C0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       r9,275B6400C78
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,275A4402028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C654BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+10],r9
       mov       r9,275A0400048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,275A4402028
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9C654BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       [rbp+18],r9
       mov       r9,275A4412520
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,275A4402028
       mov       r9,[r9]
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9C654BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-38],rax
       mov       r8,[rbp-38]
       mov       [rbp+20],r8
       mov       r8,275B6400C80
       mov       r8,[r8]
       mov       rdx,275A4402028
       mov       rdx,[rdx]
       mov       ecx,[rbp+28]
       call      qword ptr [7FF9C6885C90]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-3C],eax
       mov       r8d,[rbp-3C]
       mov       [rbp+28],r8d
       mov       r8,275B6400C88
       mov       r8,[r8]
       mov       rdx,275A4402028
       mov       rdx,[rdx]
       mov       ecx,[rbp+30]
       call      qword ptr [7FF9C6885C90]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+30],ecx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-50],rax
       nop
       mov       ecx,[rbp+28]
       add       ecx,2
       cmp       ecx,1
       jbe       short M01_L02
       nop
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L04
M01_L03:
       xor       ecx,ecx
       mov       [rbp-4],ecx
M01_L04:
       mov       ecx,[rbp-4]
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L11
M01_L05:
       nop
       mov       rcx,7FF9C6505DB0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,275A440D618
       mov       rdx,[rdx]
       mov       [rbp-0C8],rdx
       mov       rdx,[rbp-0C8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6103648]; System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-6C],eax
       mov       r9d,[rbp-6C]
       mov       [rbp-10],r9d
       xor       r9d,r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L08
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-0A0],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0A8],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6101B88]; System.String.get_Chars(Int32)
       mov       [rbp-0B4],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0C0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-80],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-84],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6101BA0]; System.String.get_Length()
       mov       [rbp-88],eax
       mov       r9d,[rbp-88]
       sub       r9d,[rbp-0C]
       jno       short M01_L09
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-80]
       mov       r8d,[rbp-84]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       nop
       jmp       short M01_L12
M01_L10:
       nop
M01_L11:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       nop
       nop
       jmp       short M01_L14
M01_L13:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
M01_L14:
       mov       edx,[rbp+30]
       add       edx,2
       cmp       edx,1
       jbe       short M01_L15
       nop
       jmp       short M01_L16
M01_L15:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L17
M01_L16:
       xor       edx,edx
       mov       [rbp-4],edx
M01_L17:
       mov       edx,[rbp-4]
       mov       [rbp-1C],edx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L18
       nop
       mov       rdx,275A4412B58
       mov       rdx,[rdx]
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
M01_L18:
       nop
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 988
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,275A4402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C612D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6335750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
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
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9C57C55D0]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C5971668],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       r9,1DFC78C1C28
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1DF678C3020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+10],r9
       mov       r9,1DF678D3D18
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1DF678C3020
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       [rbp+18],r9
       mov       r9,1DF678D3638
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1DF678C3020
       mov       r9,[r9]
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-38],rax
       mov       r8,[rbp-38]
       mov       [rbp+20],r8
       mov       r8,1DFC78C1C30
       mov       r8,[r8]
       mov       rdx,1DF678C3020
       mov       rdx,[rdx]
       mov       ecx,[rbp+28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-3C],eax
       mov       r8d,[rbp-3C]
       mov       [rbp+28],r8d
       mov       r8,1DFC78C1C38
       mov       r8,[r8]
       mov       rdx,1DF678C3020
       mov       rdx,[rdx]
       mov       ecx,[rbp+30]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+30],ecx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-50],rax
       nop
       mov       ecx,[rbp+28]
       add       ecx,2
       cmp       ecx,1
       jbe       short M01_L02
       nop
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L04
M01_L03:
       xor       ecx,ecx
       mov       [rbp-4],ecx
M01_L04:
       mov       ecx,[rbp-4]
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L11
M01_L05:
       nop
       mov       rcx,7FF9C5971B98
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1DF678CE350
       mov       rdx,[rdx]
       mov       [rbp-0C8],rdx
       mov       rdx,[rbp-0C8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-6C],eax
       mov       r9d,[rbp-6C]
       mov       [rbp-10],r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       movzx     r9d,r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L08
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-0A0],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-0A8],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      System.String.get_Chars(Int32)
       mov       [rbp-0B4],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-0C0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-80],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-84],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      System.String.get_Length()
       mov       [rbp-88],eax
       mov       r9d,[rbp-88]
       sub       r9d,[rbp-0C]
       jno       short M01_L09
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-80]
       mov       r8d,[rbp-84]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       nop
       jmp       short M01_L12
M01_L10:
       nop
M01_L11:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       nop
       nop
       jmp       short M01_L14
M01_L13:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
M01_L14:
       mov       edx,[rbp+30]
       add       edx,2
       cmp       edx,1
       jbe       short M01_L15
       nop
       jmp       short M01_L16
M01_L15:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L17
M01_L16:
       xor       edx,edx
       mov       [rbp-4],edx
M01_L17:
       mov       edx,[rbp-4]
       mov       [rbp-1C],edx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L18
       nop
       mov       rdx,1DF678D3B60
       mov       rdx,[rdx]
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
M01_L18:
       nop
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 971
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1DF678C3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54A4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54A4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
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
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9C6895BA0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9C6387D30]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C65158C0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       r9,29710000C78
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,29700002028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C655BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+10],r9
       mov       r9,29708000048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,29700002028
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9C655BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       [rbp+18],r9
       mov       r9,29700012520
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,29700002028
       mov       r9,[r9]
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9C655BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-38],rax
       mov       r8,[rbp-38]
       mov       [rbp+20],r8
       mov       r8,29710000C80
       mov       r8,[r8]
       mov       rdx,29700002028
       mov       rdx,[rdx]
       mov       ecx,[rbp+28]
       call      qword ptr [7FF9C6895C90]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-3C],eax
       mov       r8d,[rbp-3C]
       mov       [rbp+28],r8d
       mov       r8,29710000C88
       mov       r8,[r8]
       mov       rdx,29700002028
       mov       rdx,[rdx]
       mov       ecx,[rbp+30]
       call      qword ptr [7FF9C6895C90]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+30],ecx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-50],rax
       nop
       mov       ecx,[rbp+28]
       add       ecx,2
       cmp       ecx,1
       jbe       short M01_L02
       nop
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L04
M01_L03:
       xor       ecx,ecx
       mov       [rbp-4],ecx
M01_L04:
       mov       ecx,[rbp-4]
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L11
M01_L05:
       nop
       mov       rcx,7FF9C6515DB0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,2970000D618
       mov       rdx,[rdx]
       mov       [rbp-0C8],rdx
       mov       rdx,[rbp-0C8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6113648]; System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-6C],eax
       mov       r9d,[rbp-6C]
       mov       [rbp-10],r9d
       xor       r9d,r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L08
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-0A0],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0A8],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6111B88]; System.String.get_Chars(Int32)
       mov       [rbp-0B4],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0C0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-80],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-84],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6111BA0]; System.String.get_Length()
       mov       [rbp-88],eax
       mov       r9d,[rbp-88]
       sub       r9d,[rbp-0C]
       jno       short M01_L09
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-80]
       mov       r8d,[rbp-84]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       nop
       jmp       short M01_L12
M01_L10:
       nop
M01_L11:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       nop
       nop
       jmp       short M01_L14
M01_L13:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
M01_L14:
       mov       edx,[rbp+30]
       add       edx,2
       cmp       edx,1
       jbe       short M01_L15
       nop
       jmp       short M01_L16
M01_L15:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L17
M01_L16:
       xor       edx,edx
       mov       [rbp-4],edx
M01_L17:
       mov       edx,[rbp-4]
       mov       [rbp-1C],edx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L18
       nop
       mov       rdx,29700012B58
       mov       rdx,[rdx]
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
M01_L18:
       nop
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 988
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,29700002028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EC4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EC4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C613D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6345750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
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
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9C57E55D0]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C5991668],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       r9,1E091D01C28
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E021D03020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+10],r9
       mov       r9,1E021D13D18
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E021D03020
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       [rbp+18],r9
       mov       r9,1E021D13638
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E021D03020
       mov       r9,[r9]
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-38],rax
       mov       r8,[rbp-38]
       mov       [rbp+20],r8
       mov       r8,1E091D01C30
       mov       r8,[r8]
       mov       rdx,1E021D03020
       mov       rdx,[rdx]
       mov       ecx,[rbp+28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-3C],eax
       mov       r8d,[rbp-3C]
       mov       [rbp+28],r8d
       mov       r8,1E091D01C38
       mov       r8,[r8]
       mov       rdx,1E021D03020
       mov       rdx,[rdx]
       mov       ecx,[rbp+30]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+30],ecx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-50],rax
       nop
       mov       ecx,[rbp+28]
       add       ecx,2
       cmp       ecx,1
       jbe       short M01_L02
       nop
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L04
M01_L03:
       xor       ecx,ecx
       mov       [rbp-4],ecx
M01_L04:
       mov       ecx,[rbp-4]
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L11
M01_L05:
       nop
       mov       rcx,7FF9C5991B98
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1E021D0E350
       mov       rdx,[rdx]
       mov       [rbp-0C8],rdx
       mov       rdx,[rbp-0C8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-6C],eax
       mov       r9d,[rbp-6C]
       mov       [rbp-10],r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       movzx     r9d,r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L08
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-0A0],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-0A8],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      System.String.get_Chars(Int32)
       mov       [rbp-0B4],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-0C0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-80],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-84],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      System.String.get_Length()
       mov       [rbp-88],eax
       mov       r9d,[rbp-88]
       sub       r9d,[rbp-0C]
       jno       short M01_L09
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-80]
       mov       r8d,[rbp-84]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       nop
       jmp       short M01_L12
M01_L10:
       nop
M01_L11:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       nop
       nop
       jmp       short M01_L14
M01_L13:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
M01_L14:
       mov       edx,[rbp+30]
       add       edx,2
       cmp       edx,1
       jbe       short M01_L15
       nop
       jmp       short M01_L16
M01_L15:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L17
M01_L16:
       xor       edx,edx
       mov       [rbp-4],edx
M01_L17:
       mov       edx,[rbp-4]
       mov       [rbp-1C],edx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L18
       nop
       mov       rdx,1E021D13B60
       mov       rdx,[rdx]
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
M01_L18:
       nop
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 971
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1E021D03020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54C4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54C4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
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
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9C6897030]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9C6387D30]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C65158C0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       r9,1982E400C78
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1981C402028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C655BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+10],r9
       mov       r9,19818400048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1981C402028
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9C655BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       [rbp+18],r9
       mov       r9,1981C412520
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1981C402028
       mov       r9,[r9]
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9C655BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-38],rax
       mov       r8,[rbp-38]
       mov       [rbp+20],r8
       mov       r8,1982E400C80
       mov       r8,[r8]
       mov       rdx,1981C402028
       mov       rdx,[rdx]
       mov       ecx,[rbp+28]
       call      qword ptr [7FF9C6897120]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-3C],eax
       mov       r8d,[rbp-3C]
       mov       [rbp+28],r8d
       mov       r8,1982E400C88
       mov       r8,[r8]
       mov       rdx,1981C402028
       mov       rdx,[rdx]
       mov       ecx,[rbp+30]
       call      qword ptr [7FF9C6897120]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+30],ecx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-50],rax
       nop
       mov       ecx,[rbp+28]
       add       ecx,2
       cmp       ecx,1
       jbe       short M01_L02
       nop
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L04
M01_L03:
       xor       ecx,ecx
       mov       [rbp-4],ecx
M01_L04:
       mov       ecx,[rbp-4]
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L11
M01_L05:
       nop
       mov       rcx,7FF9C6515DB0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1981C40D618
       mov       rdx,[rdx]
       mov       [rbp-0C8],rdx
       mov       rdx,[rbp-0C8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6113648]; System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-6C],eax
       mov       r9d,[rbp-6C]
       mov       [rbp-10],r9d
       xor       r9d,r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L08
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-0A0],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0A8],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6111B88]; System.String.get_Chars(Int32)
       mov       [rbp-0B4],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0C0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-80],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-84],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6111BA0]; System.String.get_Length()
       mov       [rbp-88],eax
       mov       r9d,[rbp-88]
       sub       r9d,[rbp-0C]
       jno       short M01_L09
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-80]
       mov       r8d,[rbp-84]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       nop
       jmp       short M01_L12
M01_L10:
       nop
M01_L11:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       nop
       nop
       jmp       short M01_L14
M01_L13:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
M01_L14:
       mov       edx,[rbp+30]
       add       edx,2
       cmp       edx,1
       jbe       short M01_L15
       nop
       jmp       short M01_L16
M01_L15:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L17
M01_L16:
       xor       edx,edx
       mov       [rbp-4],edx
M01_L17:
       mov       edx,[rbp-4]
       mov       [rbp-1C],edx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L18
       nop
       mov       rdx,1981C412B58
       mov       rdx,[rdx]
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C639B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
M01_L18:
       nop
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 988
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61599F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1981C402028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EC4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EC4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C613D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6345750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
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
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9C58055D0]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C59B1668],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       r9,1E55C6D1C28
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E4FC6D3020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+10],r9
       mov       r9,1E4FC6E3D18
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E4FC6D3020
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       [rbp+18],r9
       mov       r9,1E4FC6E3638
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1E4FC6D3020
       mov       r9,[r9]
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-38],rax
       mov       r8,[rbp-38]
       mov       [rbp+20],r8
       mov       r8,1E55C6D1C30
       mov       r8,[r8]
       mov       rdx,1E4FC6D3020
       mov       rdx,[rdx]
       mov       ecx,[rbp+28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-3C],eax
       mov       r8d,[rbp-3C]
       mov       [rbp+28],r8d
       mov       r8,1E55C6D1C38
       mov       r8,[r8]
       mov       rdx,1E4FC6D3020
       mov       rdx,[rdx]
       mov       ecx,[rbp+30]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+30],ecx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-50],rax
       nop
       mov       ecx,[rbp+28]
       add       ecx,2
       cmp       ecx,1
       jbe       short M01_L02
       nop
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L04
M01_L03:
       xor       ecx,ecx
       mov       [rbp-4],ecx
M01_L04:
       mov       ecx,[rbp-4]
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L11
M01_L05:
       nop
       mov       rcx,7FF9C59B1B98
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1E4FC6DE350
       mov       rdx,[rdx]
       mov       [rbp-0C8],rdx
       mov       rdx,[rbp-0C8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-6C],eax
       mov       r9d,[rbp-6C]
       mov       [rbp-10],r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       movzx     r9d,r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L08
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-0A0],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-0A8],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      System.String.get_Chars(Int32)
       mov       [rbp-0B4],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-0C0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-80],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-84],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      System.String.get_Length()
       mov       [rbp-88],eax
       mov       r9d,[rbp-88]
       sub       r9d,[rbp-0C]
       jno       short M01_L09
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-80]
       mov       r8d,[rbp-84]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       nop
       jmp       short M01_L12
M01_L10:
       nop
M01_L11:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       nop
       nop
       jmp       short M01_L14
M01_L13:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
M01_L14:
       mov       edx,[rbp+30]
       add       edx,2
       cmp       edx,1
       jbe       short M01_L15
       nop
       jmp       short M01_L16
M01_L15:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L17
M01_L16:
       xor       edx,edx
       mov       [rbp-4],edx
M01_L17:
       mov       edx,[rbp-4]
       mov       [rbp-1C],edx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L18
       nop
       mov       rdx,1E4FC6E3B60
       mov       rdx,[rdx]
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
M01_L18:
       nop
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 971
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1E4FC6D3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54E4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54E4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
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
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9C68C7030]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9C63A7D30]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C65358C0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       r9,27F6C800C78
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,27F5C802028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C657BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+10],r9
       mov       r9,27F58800048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,27F5C802028
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9C657BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       [rbp+18],r9
       mov       r9,27F5C812520
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,27F5C802028
       mov       r9,[r9]
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9C657BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-38],rax
       mov       r8,[rbp-38]
       mov       [rbp+20],r8
       mov       r8,27F6C800C80
       mov       r8,[r8]
       mov       rdx,27F5C802028
       mov       rdx,[rdx]
       mov       ecx,[rbp+28]
       call      qword ptr [7FF9C68C7120]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-3C],eax
       mov       r8d,[rbp-3C]
       mov       [rbp+28],r8d
       mov       r8,27F6C800C88
       mov       r8,[r8]
       mov       rdx,27F5C802028
       mov       rdx,[rdx]
       mov       ecx,[rbp+30]
       call      qword ptr [7FF9C68C7120]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+30],ecx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63BB288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63BB3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-50],rax
       nop
       mov       ecx,[rbp+28]
       add       ecx,2
       cmp       ecx,1
       jbe       short M01_L02
       nop
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L04
M01_L03:
       xor       ecx,ecx
       mov       [rbp-4],ecx
M01_L04:
       mov       ecx,[rbp-4]
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63BB3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L11
M01_L05:
       nop
       mov       rcx,7FF9C6535DB0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,27F5C80D618
       mov       rdx,[rdx]
       mov       [rbp-0C8],rdx
       mov       rdx,[rbp-0C8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6133648]; System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-6C],eax
       mov       r9d,[rbp-6C]
       mov       [rbp-10],r9d
       xor       r9d,r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L08
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63BB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-0A0],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63BB3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0A8],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6131B88]; System.String.get_Chars(Int32)
       mov       [rbp-0B4],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63BB3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0C0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-80],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-84],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6131BA0]; System.String.get_Length()
       mov       [rbp-88],eax
       mov       r9d,[rbp-88]
       sub       r9d,[rbp-0C]
       jno       short M01_L09
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-80]
       mov       r8d,[rbp-84]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63BB2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       nop
       jmp       short M01_L12
M01_L10:
       nop
M01_L11:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63BB3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       nop
       nop
       jmp       short M01_L14
M01_L13:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63BB288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
M01_L14:
       mov       edx,[rbp+30]
       add       edx,2
       cmp       edx,1
       jbe       short M01_L15
       nop
       jmp       short M01_L16
M01_L15:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L17
M01_L16:
       xor       edx,edx
       mov       [rbp-4],edx
M01_L17:
       mov       edx,[rbp-4]
       mov       [rbp-1C],edx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L18
       nop
       mov       rdx,27F5C812B58
       mov       rdx,[rdx]
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C63BB288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
M01_L18:
       nop
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 988
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61799F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,27F5C802028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EE4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EE4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C615D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6365750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
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
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9C57D55D0]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C5981668],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       r9,2D2F0C01C28
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2D290C03020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+10],r9
       mov       r9,2D290C13D18
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2D290C03020
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       [rbp+18],r9
       mov       r9,2D290C13638
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,2D290C03020
       mov       r9,[r9]
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-38],rax
       mov       r8,[rbp-38]
       mov       [rbp+20],r8
       mov       r8,2D2F0C01C30
       mov       r8,[r8]
       mov       rdx,2D290C03020
       mov       rdx,[rdx]
       mov       ecx,[rbp+28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-3C],eax
       mov       r8d,[rbp-3C]
       mov       [rbp+28],r8d
       mov       r8,2D2F0C01C38
       mov       r8,[r8]
       mov       rdx,2D290C03020
       mov       rdx,[rdx]
       mov       ecx,[rbp+30]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+30],ecx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-50],rax
       nop
       mov       ecx,[rbp+28]
       add       ecx,2
       cmp       ecx,1
       jbe       short M01_L02
       nop
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L04
M01_L03:
       xor       ecx,ecx
       mov       [rbp-4],ecx
M01_L04:
       mov       ecx,[rbp-4]
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L11
M01_L05:
       nop
       mov       rcx,7FF9C5981B98
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,2D290C0E350
       mov       rdx,[rdx]
       mov       [rbp-0C8],rdx
       mov       rdx,[rbp-0C8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-6C],eax
       mov       r9d,[rbp-6C]
       mov       [rbp-10],r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       movzx     r9d,r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L08
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-0A0],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-0A8],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      System.String.get_Chars(Int32)
       mov       [rbp-0B4],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-0C0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-80],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-84],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      System.String.get_Length()
       mov       [rbp-88],eax
       mov       r9d,[rbp-88]
       sub       r9d,[rbp-0C]
       jno       short M01_L09
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-80]
       mov       r8d,[rbp-84]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       nop
       jmp       short M01_L12
M01_L10:
       nop
M01_L11:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       nop
       nop
       jmp       short M01_L14
M01_L13:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
M01_L14:
       mov       edx,[rbp+30]
       add       edx,2
       cmp       edx,1
       jbe       short M01_L15
       nop
       jmp       short M01_L16
M01_L15:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L17
M01_L16:
       xor       edx,edx
       mov       [rbp-4],edx
M01_L17:
       mov       edx,[rbp-4]
       mov       [rbp-1C],edx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L18
       nop
       mov       rdx,2D290C13B60
       mov       rdx,[rdx]
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
M01_L18:
       nop
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 971
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,2D290C03020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
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
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9C6897030]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9C6377D30]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C65058C0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       r9,174E4800C78
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,174D4800030
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C654BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+10],r9
       mov       r9,174D0800048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,174D4800030
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9C654BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       [rbp+18],r9
       mov       r9,174D4810528
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,174D4800030
       mov       r9,[r9]
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9C654BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-38],rax
       mov       r8,[rbp-38]
       mov       [rbp+20],r8
       mov       r8,174E4800C80
       mov       r8,[r8]
       mov       rdx,174D4800030
       mov       rdx,[rdx]
       mov       ecx,[rbp+28]
       call      qword ptr [7FF9C6897120]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-3C],eax
       mov       r8d,[rbp-3C]
       mov       [rbp+28],r8d
       mov       r8,174E4800C88
       mov       r8,[r8]
       mov       rdx,174D4800030
       mov       rdx,[rdx]
       mov       ecx,[rbp+30]
       call      qword ptr [7FF9C6897120]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+30],ecx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-50],rax
       nop
       mov       ecx,[rbp+28]
       add       ecx,2
       cmp       ecx,1
       jbe       short M01_L02
       nop
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L04
M01_L03:
       xor       ecx,ecx
       mov       [rbp-4],ecx
M01_L04:
       mov       ecx,[rbp-4]
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L11
M01_L05:
       nop
       mov       rcx,7FF9C6505DB0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,174D480B620
       mov       rdx,[rdx]
       mov       [rbp-0C8],rdx
       mov       rdx,[rbp-0C8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6103648]; System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-6C],eax
       mov       r9d,[rbp-6C]
       mov       [rbp-10],r9d
       xor       r9d,r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L08
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-0A0],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0A8],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6101B88]; System.String.get_Chars(Int32)
       mov       [rbp-0B4],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0C0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-80],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-84],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6101BA0]; System.String.get_Length()
       mov       [rbp-88],eax
       mov       r9d,[rbp-88]
       sub       r9d,[rbp-0C]
       jno       short M01_L09
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-80]
       mov       r8d,[rbp-84]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       nop
       jmp       short M01_L12
M01_L10:
       nop
M01_L11:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       nop
       nop
       jmp       short M01_L14
M01_L13:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
M01_L14:
       mov       edx,[rbp+30]
       add       edx,2
       cmp       edx,1
       jbe       short M01_L15
       nop
       jmp       short M01_L16
M01_L15:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L17
M01_L16:
       xor       edx,edx
       mov       [rbp-4],edx
M01_L17:
       mov       edx,[rbp-4]
       mov       [rbp-1C],edx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L18
       nop
       mov       rdx,174D4810B60
       mov       rdx,[rdx]
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
M01_L18:
       nop
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 988
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,174D4800030
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C612D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6335750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
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
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       movsxd    rcx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9C57D55D0]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C5981668],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       r9,1BC568B1C28
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1BBF68B3020
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+10],r9
       mov       r9,1BBF68C3D18
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1BBF68B3020
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       [rbp+18],r9
       mov       r9,1BBF68C3638
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,1BBF68B3020
       mov       r9,[r9]
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       call      DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-38],rax
       mov       r8,[rbp-38]
       mov       [rbp+20],r8
       mov       r8,1BC568B1C30
       mov       r8,[r8]
       mov       rdx,1BBF68B3020
       mov       rdx,[rdx]
       mov       ecx,[rbp+28]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-3C],eax
       mov       r8d,[rbp-3C]
       mov       [rbp+28],r8d
       mov       r8,1BC568B1C38
       mov       r8,[r8]
       mov       rdx,1BBF68B3020
       mov       rdx,[rdx]
       mov       ecx,[rbp+30]
       call      DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+30],ecx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-50],rax
       nop
       mov       ecx,[rbp+28]
       add       ecx,2
       cmp       ecx,1
       jbe       short M01_L02
       nop
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L04
M01_L03:
       xor       ecx,ecx
       mov       [rbp-4],ecx
M01_L04:
       mov       ecx,[rbp-4]
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L11
M01_L05:
       nop
       mov       rcx,7FF9C5981B98
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,1BBF68BE350
       mov       rdx,[rdx]
       mov       [rbp-0C8],rdx
       mov       rdx,[rbp-0C8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-6C],eax
       mov       r9d,[rbp-6C]
       mov       [rbp-10],r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       movzx     r9d,r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L08
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-0A0],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-0A8],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      System.String.get_Chars(Int32)
       mov       [rbp-0B4],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-0C0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-80],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-84],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      System.String.get_Length()
       mov       [rbp-88],eax
       mov       r9d,[rbp-88]
       sub       r9d,[rbp-0C]
       jno       short M01_L09
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-80]
       mov       r8d,[rbp-84]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       nop
       jmp       short M01_L12
M01_L10:
       nop
M01_L11:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       nop
       nop
       jmp       short M01_L14
M01_L13:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
M01_L14:
       mov       edx,[rbp+30]
       add       edx,2
       cmp       edx,1
       jbe       short M01_L15
       nop
       jmp       short M01_L16
M01_L15:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L17
M01_L16:
       xor       edx,edx
       mov       [rbp-4],edx
M01_L17:
       mov       edx,[rbp-4]
       mov       [rbp-1C],edx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L18
       nop
       mov       rdx,1BBF68C3B60
       mov       rdx,[rdx]
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
M01_L18:
       nop
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 971
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       lea       rax,[rdi+0C]
       movsxd    rcx,ecx
       lea       rcx,[rax+rcx*2]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,1BBF68B3020
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17491
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9E29
       mov       rdx,7FF9C54B4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      System.SR.GetResourceString(System.String)
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      System.ArgumentOutOfRangeException..ctor(System.String, System.String)
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.Extensions.BenchmarkTests.StringBuilderExtensionsCounterBenchmark.AppendKeyValue1()
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
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
       mov       rbx,[rsi+288]
       xor       ebp,ebp
       mov       r14d,[rbx+8]
       test      r14d,r14d
       jle       short M00_L01
M00_L00:
       mov       ecx,ebp
       mov       r8,[rbx+rcx*8+10]
       mov       dword ptr [rsp+20],0FFFFFFFF
       mov       rcx,rdi
       mov       rdx,r8
       mov       r9d,0FFFFFFFF
       call      qword ptr [7FF9C6897BA0]; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       inc       ebp
       cmp       r14d,ebp
       jg        short M00_L00
M00_L01:
       mov       rcx,rdi
       call      qword ptr [7FF9C6377D30]; System.Text.StringBuilder.ToString()
       mov       [rsp+28],rax
       mov       rsi,[rsi+18]
       mov       rdx,[rsp+28]
       lea       rcx,[rsi+8]
       call      CORINFO_HELP_ASSIGN_REF
       xor       eax,eax
       mov       [rsi+8],rax
       add       rsp,30
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
; Total bytes of code 184
```
```assembly
; DotNetTips.Spargine.Extensions.StringBuilderExtensions.AppendKeyValue(System.Text.StringBuilder, System.String, System.String, DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.Core.Tristate)
       push      rbp
       sub       rsp,0F0
       lea       rbp,[rsp+0F0]
       xor       eax,eax
       mov       [rbp-0C8],rax
       vxorps    xmm4,xmm4,xmm4
       mov       rax,0FFFFFFFFFFFFFF40
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8
       mov       [rbp+28],r9d
       cmp       dword ptr [7FF9C65058C0],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       r9,279CDC00C78
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,279C1C02028
       mov       r9,[r9]
       mov       rdx,[rbp+10]
       mov       rcx,offset MD_DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.Text.StringBuilder, System.Private.CoreLib]](System.Text.StringBuilder, System.Text.StringBuilder, System.String, System.String)
       xor       r8d,r8d
       call      qword ptr [7FF9C654BE40]; DotNetTips.Spargine.Core.Validator.ArgumentNotNull[[System.__Canon, System.Private.CoreLib]](System.__Canon, System.__Canon, System.String, System.String)
       mov       [rbp-28],rax
       mov       r9,[rbp-28]
       mov       [rbp+10],r9
       mov       r9,279B9C00048
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,279C1C02028
       mov       r9,[r9]
       mov       rcx,[rbp+18]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9C654BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-30],rax
       mov       r9,[rbp-30]
       mov       [rbp+18],r9
       mov       r9,279BDC00068
       mov       r9,[r9]
       mov       [rsp+20],r9
       mov       r9,279C1C02028
       mov       r9,[r9]
       mov       rcx,[rbp+20]
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FF9C654BC48]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       [rbp-38],rax
       mov       r8,[rbp-38]
       mov       [rbp+20],r8
       mov       r8,279CDC00C80
       mov       r8,[r8]
       mov       rdx,279C1C02028
       mov       rdx,[rdx]
       mov       ecx,[rbp+28]
       call      qword ptr [7FF9C6897C90]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-3C],eax
       mov       r8d,[rbp-3C]
       mov       [rbp+28],r8d
       mov       r8,279CDC00C88
       mov       r8,[r8]
       mov       rdx,279C1C02028
       mov       rdx,[rdx]
       mov       ecx,[rbp+30]
       call      qword ptr [7FF9C6897C90]; DotNetTips.Spargine.Core.Validator.ArgumentDefined[[DotNetTips.Spargine.Core.Tristate, DotNetTips.Spargine.6.Core]](DotNetTips.Spargine.Core.Tristate, System.String, System.String)
       mov       [rbp-40],eax
       mov       ecx,[rbp-40]
       mov       [rbp+30],ecx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-48],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,3D
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-50],rax
       nop
       mov       ecx,[rbp+28]
       add       ecx,2
       cmp       ecx,1
       jbe       short M01_L02
       nop
       jmp       short M01_L03
M01_L02:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L04
M01_L03:
       xor       ecx,ecx
       mov       [rbp-4],ecx
M01_L04:
       mov       ecx,[rbp-4]
       mov       [rbp-8],ecx
       cmp       dword ptr [rbp-8],0
       je        near ptr M01_L13
       nop
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-68],rax
       nop
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       near ptr M01_L11
M01_L05:
       nop
       mov       rcx,7FF9C6505DB0
       mov       edx,2C
       call      CORINFO_HELP_GETSHARED_NONGCSTATIC_BASE
       mov       rdx,279C1C0D618
       mov       rdx,[rdx]
       mov       [rbp-0C8],rdx
       mov       rdx,[rbp-0C8]
       mov       rcx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6103648]; System.String.IndexOfAny(Char[], Int32)
       mov       [rbp-6C],eax
       mov       r9d,[rbp-6C]
       mov       [rbp-10],r9d
       xor       r9d,r9d
       cmp       dword ptr [rbp-10],0
       setge     r9b
       mov       [rbp-14],r9d
       cmp       dword ptr [rbp-14],0
       je        near ptr M01_L08
       nop
       mov       r9d,[rbp-10]
       sub       r9d,[rbp-0C]
       jno       short M01_L06
       call      CORINFO_HELP_OVERFLOW
M01_L06:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       mov       r8d,[rbp-0C]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-0A0],rax
       nop
       mov       rcx,[rbp+10]
       mov       edx,5C
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0A8],rax
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-0B0],rcx
       mov       rcx,[rbp+20]
       mov       edx,[rbp-10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6101B88]; System.String.get_Chars(Int32)
       mov       [rbp-0B4],eax
       mov       rcx,[rbp-0B0]
       mov       edx,[rbp-0B4]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-0C0],rax
       nop
       mov       ecx,[rbp-10]
       add       ecx,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       [rbp-0C],ecx
       nop
       nop
       jmp       short M01_L10
M01_L08:
       nop
       mov       rcx,[rbp+10]
       mov       [rbp-78],rcx
       mov       rcx,[rbp+20]
       mov       [rbp-80],rcx
       mov       ecx,[rbp-0C]
       mov       [rbp-84],ecx
       mov       rcx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C6101BA0]; System.String.get_Length()
       mov       [rbp-88],eax
       mov       r9d,[rbp-88]
       sub       r9d,[rbp-0C]
       jno       short M01_L09
       call      CORINFO_HELP_OVERFLOW
M01_L09:
       mov       rcx,[rbp-78]
       mov       rdx,[rbp-80]
       mov       r8d,[rbp-84]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B2A0]; System.Text.StringBuilder.Append(System.String, Int32, Int32)
       mov       [rbp-90],rax
       nop
       nop
       jmp       short M01_L12
M01_L10:
       nop
M01_L11:
       mov       dword ptr [rbp-18],1
       nop
       jmp       near ptr M01_L05
M01_L12:
       mov       rcx,[rbp+10]
       mov       edx,22
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B3C0]; System.Text.StringBuilder.Append(Char)
       mov       [rbp-98],rax
       nop
       nop
       nop
       jmp       short M01_L14
M01_L13:
       nop
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+20]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-58],rax
       nop
       nop
M01_L14:
       mov       edx,[rbp+30]
       add       edx,2
       cmp       edx,1
       jbe       short M01_L15
       nop
       jmp       short M01_L16
M01_L15:
       mov       dword ptr [rbp-4],1
       nop
       jmp       short M01_L17
M01_L16:
       xor       edx,edx
       mov       [rbp-4],edx
M01_L17:
       mov       edx,[rbp-4]
       mov       [rbp-1C],edx
       cmp       dword ptr [rbp-1C],0
       je        short M01_L18
       nop
       mov       rdx,279BDC006A0
       mov       rdx,[rdx]
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C638B288]; System.Text.StringBuilder.Append(System.String)
       mov       [rbp-60],rax
       nop
       nop
M01_L18:
       nop
       add       rsp,0F0
       pop       rbp
       ret
; Total bytes of code 988
```
```assembly
; System.Text.StringBuilder.ToString()
       push      rdi
       push      rsi
       sub       rsp,28
       mov       rsi,rcx
       mov       ecx,[rsi+1C]
       add       ecx,[rsi+18]
       je        short M02_L02
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
M02_L00:
       mov       r8d,[rsi+18]
       test      r8d,r8d
       jle       short M02_L01
       mov       rdx,[rsi+8]
       mov       ecx,[rsi+1C]
       lea       eax,[r8+rcx]
       cmp       eax,[rdi+8]
       ja        short M02_L03
       cmp       [rdx+8],r8d
       jb        short M02_L03
       movsxd    rcx,ecx
       lea       rcx,[rdi+rcx*2+0C]
       add       rdx,10
       movsxd    r8,r8d
       add       r8,r8
       call      qword ptr [7FF9C61499F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
M02_L01:
       mov       rsi,[rsi+10]
       test      rsi,rsi
       jne       short M02_L00
       mov       rax,rdi
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L02:
       mov       rax,279C1C02028
       mov       rax,[rax]
       add       rsp,28
       pop       rsi
       pop       rdi
       ret
M02_L03:
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       ecx,17911
       mov       rdx,7FF9C5EB4000
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9A9B
       mov       rdx,7FF9C5EB4000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FF9C612D030]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rsi
       call      qword ptr [7FF9C6335750]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 213
```

