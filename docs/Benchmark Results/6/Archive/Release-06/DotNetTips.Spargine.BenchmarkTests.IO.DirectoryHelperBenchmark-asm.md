## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.AppDataFolder()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      DotNetTips.Spargine.IO.DirectoryHelper.AppDataFolder()
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
; Total bytes of code 58
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.AppDataFolder()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rcx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rax,rsp
       mov       [rbp-70],rax
       mov       rax,rbp
       mov       [rbp-60],rax
       call      System.Runtime.InteropServices.OSPlatform.get_Windows()
       mov       rcx,rax
       call      System.OperatingSystem.IsOSPlatform(System.String)
       test      al,al
       jne       short M01_L00
       mov       rcx,197626D1DE0
       mov       rcx,[rcx]
       jmp       short M01_L01
M01_L00:
       mov       rcx,197626D1DE8
       mov       rcx,[rcx]
M01_L01:
       call      System.Environment.GetEnvironmentVariable(System.String)
       mov       [rbp-50],rax
       cmp       byte ptr [7FFD675D53C9],0
       jne       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-40],rcx
       lea       rcx,[rbp-40]
       mov       rax,offset MD_System.Reflection.Assembly.GetEntryAssemblyNative(System.Runtime.CompilerServices.ObjectHandleOnStack)
       mov       [rbp-80],rax
       lea       rax,[M01_L02]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       call      qword ptr [7FFD676CF868]
M01_L02:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFDC74C6A14],0
       je        short M01_L03
       call      qword ptr [7FFDC74B8398]; CORINFO_HELP_STOP_FOR_GC
M01_L03:
       mov       rcx,[rbp-88]
       mov       [rsi+10],rcx
       mov       rsi,[rbp-40]
       xor       ecx,ecx
       mov       [rbp-40],rcx
M01_L04:
       mov       rcx,offset MT_System.Reflection.AssemblyCompanyAttribute
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,1
       call      System.Attribute.GetCustomAttributes(System.Reflection.Assembly, System.Type, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.IEnumerable`1[[System.Reflection.AssemblyCompanyAttribute, System.Private.CoreLib]]
       call      CORINFO_HELP_CHKCASTARRAY
       mov       rdx,rax
       lea       r8,[rbp-48]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Reflection.AssemblyCompanyAttribute, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.AssemblyCompanyAttribute>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rcx,[rax+8]
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,[rbp-50]
       call      System.IO.Path.Combine(System.String, System.String)
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       xor       esi,esi
       jmp       short M01_L04
; Total bytes of code 357
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.AppDataFolder()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FFD52A4D300]; DotNetTips.Spargine.IO.DirectoryHelper.AppDataFolder()
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52A4D4B0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.AppDataFolder()
       push      rbp
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,88
       lea       rbp,[rsp+0C0]
       xor       ecx,ecx
       mov       [rbp-40],rcx
       mov       [rbp-48],rcx
       lea       rcx,[rbp-90]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rax,rsp
       mov       [rbp-70],rax
       mov       rax,rbp
       mov       [rbp-60],rax
       call      qword ptr [7FFD529FDE40]; System.Runtime.InteropServices.OSPlatform.get_Windows()
       mov       rcx,rax
       call      qword ptr [7FFD52955BB8]; System.OperatingSystem.IsOSPlatform(System.String)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,2B3A4401638
       mov       rcx,[rcx]
       jmp       short M01_L01
M01_L00:
       mov       rcx,2B3A4401640
       mov       rcx,[rcx]
M01_L01:
       call      qword ptr [7FFD5247BAE0]; System.Environment.GetEnvironmentVariable(System.String)
       mov       [rbp-50],rax
       cmp       byte ptr [7FFD52305719],0
       jne       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp-40],rcx
       lea       rcx,[rbp-40]
       mov       rax,offset MD_System.Reflection.Assembly.GetEntryAssemblyNative(System.Runtime.CompilerServices.ObjectHandleOnStack)
       mov       [rbp-80],rax
       lea       rax,[M01_L02]
       mov       [rbp-68],rax
       lea       rax,[rbp-90]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       call      qword ptr [7FFD525841C0]
M01_L02:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFDB21E2E74],0
       je        short M01_L03
       call      qword ptr [7FFDB21D5378]; CORINFO_HELP_STOP_FOR_GC
M01_L03:
       mov       rcx,[rbp-88]
       mov       [rsi+10],rcx
       mov       rsi,[rbp-40]
       xor       ecx,ecx
       mov       [rbp-40],rcx
M01_L04:
       mov       rcx,offset MT_System.Reflection.AssemblyCompanyAttribute
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rdx,rax
       mov       rcx,rsi
       mov       r8d,1
       call      qword ptr [7FFD5264BB10]; System.Attribute.GetCustomAttributes(System.Reflection.Assembly, System.Type, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.IEnumerable`1[[System.Reflection.AssemblyCompanyAttribute, System.Private.CoreLib]]
       call      qword ptr [7FFD5239B858]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       lea       r8,[rbp-48]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Reflection.AssemblyCompanyAttribute, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.AssemblyCompanyAttribute>, Boolean ByRef)
       call      qword ptr [7FFD5262DF60]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rcx,[rax+8]
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52433510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FFD526C9180]; System.IO.Path.Combine(System.String, System.String)
       nop
       add       rsp,88
       pop       rbx
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       pop       rbp
       ret
M01_L05:
       xor       esi,esi
       jmp       near ptr M01_L04
; Total bytes of code 368
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SafeDirectorySearch01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+190]
       mov       rcx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<SafeDirectorySearch>d__8
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+48],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+4C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,1A0C7AE1DE0
       mov       rdx,[rdx]
       lea       rcx,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+54],ecx
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.IO.DirectoryInfo, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 136
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SafeDirectorySearch01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+190]
       mov       rcx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<SafeDirectorySearch>d__8
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       dword ptr [rbx+48],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rbx+4C],eax
       lea       rcx,[rbx+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,200BD000E20
       mov       rdx,[rdx]
       lea       rcx,[rbx+28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rbx+54],ecx
       mov       [rsp+28],rbx
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.IO.DirectoryInfo, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD529F3528]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 137
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SafeFileSearch01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+190]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.IO.DirectoryInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rcx,[rbx+8]
       mov       edx,[rbx+10]
       cmp       [rcx+8],edx
       jbe       short M00_L00
       lea       r8d,[rdx+1]
       mov       [rbx+10],r8d
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L01
M00_L00:
       mov       rcx,rbx
       mov       rdx,rdi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rcx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<SafeFileSearch>d__10
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+48],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+4C],eax
       lea       rcx,[rdi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,20CF0551DE0
       mov       rdx,[rdx]
       lea       rcx,[rdi+28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+54],ecx
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.IO.FileInfo, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.IO.FileInfo> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 230
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       rcx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       edx,ebx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       nop
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 57
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

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SafeFileSearch01()
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rdi,[rsi+190]
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,offset MT_System.IO.DirectoryInfo[]
       mov       edx,1
       call      CORINFO_HELP_NEWARR_1_OBJ
       lea       rcx,[rbx+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       inc       dword ptr [rbx+14]
       mov       rcx,[rbx+8]
       mov       edx,[rbx+10]
       cmp       [rcx+8],edx
       jbe       short M00_L00
       lea       r8d,[rdx+1]
       mov       [rbx+10],r8d
       movsxd    rdx,edx
       mov       r8,rdi
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M00_L01
M00_L00:
       mov       rcx,rbx
       mov       rdx,rdi
       call      qword ptr [7FFD52497A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rcx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<SafeFileSearch>d__10
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       dword ptr [rdi+48],0FFFFFFFE
       call      CORINFO_HELP_GETCURRENTMANAGEDTHREADID
       mov       [rdi+4C],eax
       lea       rcx,[rdi+18]
       mov       rdx,rbx
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,14102400E20
       mov       rdx,[rdx]
       lea       rcx,[rdi+28]
       call      CORINFO_HELP_ASSIGN_REF
       xor       ecx,ecx
       mov       [rdi+54],ecx
       mov       [rsp+28],rdi
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.IO.FileInfo, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.IO.FileInfo> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFD52A03798]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 235
```
```assembly
; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rdi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rsi
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbp
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       push      rbx
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       sub       rsp,28
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rsi,rcx
       mov       rdi,rdx
       mov       rdi,rdx
       mov       rdi,rdx
       mov       rdi,rdx
       mov       rdi,rdx
       mov       rdi,rdx
       mov       rdi,rdx
       mov       rdi,rdx
       mov       rdi,rdx
       mov       rdi,rdx
       mov       rdi,rdx
       mov       rdi,rdx
       mov       rdi,rdx
       mov       rdi,rdx
       mov       rdi,rdx
       mov       rdi,rdx
       mov       rdi,rdx
       mov       rdi,rdx
       mov       ebx,[rsi+10]
       mov       ebx,[rsi+10]
       mov       ebx,[rsi+10]
       mov       ebx,[rsi+10]
       mov       ebx,[rsi+10]
       mov       ebx,[rsi+10]
       mov       ebx,[rsi+10]
       mov       ebx,[rsi+10]
       mov       ebx,[rsi+10]
       mov       ebx,[rsi+10]
       mov       ebx,[rsi+10]
       mov       ebx,[rsi+10]
       mov       ebx,[rsi+10]
       mov       ebx,[rsi+10]
       mov       ebx,[rsi+10]
       mov       ebx,[rsi+10]
       mov       ebx,[rsi+10]
       mov       ebx,[rsi+10]
       lea       ebp,[rbx+1]
       lea       ebp,[rbx+1]
       lea       ebp,[rbx+1]
       lea       ebp,[rbx+1]
       lea       ebp,[rbx+1]
       lea       ebp,[rbx+1]
       lea       ebp,[rbx+1]
       lea       ebp,[rbx+1]
       lea       ebp,[rbx+1]
       lea       ebp,[rbx+1]
       lea       ebp,[rbx+1]
       lea       ebp,[rbx+1]
       lea       ebp,[rbx+1]
       lea       ebp,[rbx+1]
       lea       ebp,[rbx+1]
       lea       ebp,[rbx+1]
       lea       ebp,[rbx+1]
       lea       ebp,[rbx+1]
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       edx,ebp
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       mov       rcx,rsi
       call      qword ptr [7FFD8D315828]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFD8D315828]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFD8D315828]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFD8D315828]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFD8D315828]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFD8D315828]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFD8D315828]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFD8D315828]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFD8D315828]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFD8D315828]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFD8D315828]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFD8D315828]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFD8D315828]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFD8D315828]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFD8D315828]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFD8D315828]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFD8D315828]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFD8D315828]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       mov       [rsi+10],ebp
       mov       [rsi+10],ebp
       mov       [rsi+10],ebp
       mov       [rsi+10],ebp
       mov       [rsi+10],ebp
       mov       [rsi+10],ebp
       mov       [rsi+10],ebp
       mov       [rsi+10],ebp
       mov       [rsi+10],ebp
       mov       [rsi+10],ebp
       mov       [rsi+10],ebp
       mov       [rsi+10],ebp
       mov       [rsi+10],ebp
       mov       [rsi+10],ebp
       mov       [rsi+10],ebp
       mov       [rsi+10],ebp
       mov       [rsi+10],ebp
       mov       [rsi+10],ebp
       mov       rcx,[rsi+8]
       mov       rcx,[rsi+8]
       mov       rcx,[rsi+8]
       mov       rcx,[rsi+8]
       mov       rcx,[rsi+8]
       mov       rcx,[rsi+8]
       mov       rcx,[rsi+8]
       mov       rcx,[rsi+8]
       mov       rcx,[rsi+8]
       mov       rcx,[rsi+8]
       mov       rcx,[rsi+8]
       mov       rcx,[rsi+8]
       mov       rcx,[rsi+8]
       mov       rcx,[rsi+8]
       mov       rcx,[rsi+8]
       mov       rcx,[rsi+8]
       mov       rcx,[rsi+8]
       mov       rcx,[rsi+8]
       movsxd    rdx,ebx
       movsxd    rdx,ebx
       movsxd    rdx,ebx
       movsxd    rdx,ebx
       movsxd    rdx,ebx
       movsxd    rdx,ebx
       movsxd    rdx,ebx
       movsxd    rdx,ebx
       movsxd    rdx,ebx
       movsxd    rdx,ebx
       movsxd    rdx,ebx
       movsxd    rdx,ebx
       movsxd    rdx,ebx
       movsxd    rdx,ebx
       movsxd    rdx,ebx
       movsxd    rdx,ebx
       movsxd    rdx,ebx
       movsxd    rdx,ebx
       mov       r8,rdi
       mov       r8,rdi
       mov       r8,rdi
       mov       r8,rdi
       mov       r8,rdi
       mov       r8,rdi
       mov       r8,rdi
       mov       r8,rdi
       mov       r8,rdi
       mov       r8,rdi
       mov       r8,rdi
       mov       r8,rdi
       mov       r8,rdi
       mov       r8,rdi
       mov       r8,rdi
       mov       r8,rdi
       mov       r8,rdi
       mov       r8,rdi
       call      qword ptr [7FFD8D2F97C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFD8D2F97C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFD8D2F97C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFD8D2F97C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFD8D2F97C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFD8D2F97C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFD8D2F97C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFD8D2F97C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFD8D2F97C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFD8D2F97C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFD8D2F97C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFD8D2F97C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFD8D2F97C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFD8D2F97C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFD8D2F97C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFD8D2F97C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFD8D2F97C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFD8D2F97C0]; CORINFO_HELP_ARRADDR_ST
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       nop
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       add       rsp,28
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbx
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rbp
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rsi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       pop       rdi
       ret
       ret
       ret
       ret
       ret
       ret
       ret
       ret
       ret
       ret
       ret
       ret
       ret
       ret
       ret
       ret
       ret
       ret
; Total bytes of code 1080
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

## .NET 6.0.20 (6.0.2023.32017), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SetFileAttributesToNormal01()
       mov       rcx,[rcx+190]
       jmp       near ptr DotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.IO.DirectoryInfo)
; Total bytes of code 12
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.IO.DirectoryInfo)
       push      r14
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,20
       mov       rsi,rcx
       mov       r8,1C6568B3020
       mov       r8,[r8]
       mov       r9,1C6568B9DC8
       mov       r9,[r9]
       mov       rcx,rsi
       xor       edx,edx
       call      DotNetTips.Spargine.Core.Validator.ArgumentExists(System.IO.DirectoryInfo, System.IO.DirectoryInfo, System.String, System.String)
       mov       rsi,rax
       mov       rcx,rsi
       cmp       [rcx],ecx
       call      System.IO.DirectoryInfo.GetDirectories()
       mov       rdi,rax
       xor       ebx,ebx
       mov       rcx,rsi
       call      System.IO.DirectoryInfo.GetDirectories()
       cmp       dword ptr [rax+8],0
       jle       short M01_L01
       mov       r14d,[rdi+8]
M01_L00:
       cmp       ebx,r14d
       jae       short M01_L05
       movsxd    rcx,ebx
       mov       rcx,[rdi+rcx*8+10]
       call      DotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.IO.DirectoryInfo)
       add       ebx,1
       jo        short M01_L04
       mov       rcx,rsi
       call      System.IO.DirectoryInfo.GetDirectories()
       cmp       [rax+8],ebx
       jg        short M01_L00
M01_L01:
       xor       ebp,ebp
       mov       rcx,rsi
       call      System.IO.DirectoryInfo.GetDirectories()
       cmp       dword ptr [rax+8],0
       jle       short M01_L03
       mov       r14d,[rdi+8]
M01_L02:
       cmp       ebp,r14d
       jae       short M01_L05
       movsxd    rcx,ebp
       mov       rcx,[rdi+rcx*8+10]
       mov       rcx,[rcx+8]
       call      System.IO.Path.GetFullPath(System.String)
       mov       rcx,rax
       mov       edx,80
       call      System.IO.FileSystem.SetAttributes(System.String, System.IO.FileAttributes)
       add       ebp,1
       jo        short M01_L04
       mov       rcx,rsi
       call      System.IO.DirectoryInfo.GetDirectories()
       cmp       [rax+8],ebp
       jg        short M01_L02
M01_L03:
       add       rsp,20
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r14
       ret
M01_L04:
       call      CORINFO_HELP_OVERFLOW
       int       3
M01_L05:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 217
```

## .NET 7.0.9 (7.0.923.32018), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SetFileAttributesToNormal01()
       mov       rcx,[rcx+190]
       jmp       qword ptr [7FFD52A03108]; DotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.IO.DirectoryInfo)
; Total bytes of code 13
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.IO.DirectoryInfo)
M01_L00:
       push      r15
       push      r14
       push      r13
       push      r12
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       test      rsi,rsi
       jne       near ptr M01_L08
       call      qword ptr [7FFD527390F0]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],4
       jl        near ptr M01_L16
       lea       rcx,[rdi+0C]
       mov       rdx,197E2408E48
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M01_L17
       lea       rcx,[rdi+14]
       mov       rdx,197E2402090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rdi+8],0
       je        short M01_L03
       mov       rcx,rdi
M01_L01:
       test      rcx,rcx
       jne       short M01_L02
       mov       eax,1
       jmp       near ptr M01_L18
M01_L02:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L18
M01_L03:
       mov       rcx,197E2402028
       mov       rcx,[rcx]
       jmp       short M01_L01
M01_L04:
       mov       r12d,[rdi+8]
       cmp       ebx,r12d
       jae       near ptr M01_L26
       mov       ecx,ebx
       mov       rcx,[rdi+rcx*8+10]
       call      qword ptr [7FFD52A03108]
       add       ebx,1
       jo        near ptr M01_L15
M01_L05:
       mov       r12,rbp
       mov       rcx,r14
       call      CORINFO_HELP_NEWSFAST
       mov       r13,rax
       mov       [rsp+20],r12
       mov       rdx,[rsi+8]
       mov       r8,r15
       mov       rcx,rsi
       mov       r9d,2
       call      qword ptr [7FFD526A9D08]; System.IO.DirectoryInfo.InternalEnumerateInfos(System.String, System.String, System.IO.SearchTarget, System.IO.EnumerationOptions)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.IEnumerable`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       call      qword ptr [7FFD5238B858]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFD52497930]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,r13
       call      qword ptr [7FFD52497F90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       cmp       [rax+8],ebx
       jg        short M01_L04
       xor       ebx,ebx
       mov       rcx,rsi
       call      qword ptr [7FFD526A9B88]; System.IO.DirectoryInfo.GetDirectories()
       cmp       dword ptr [rax+8],0
       jle       short M01_L07
       mov       r12d,[rdi+8]
M01_L06:
       cmp       ebx,r12d
       jae       near ptr M01_L26
       mov       ecx,ebx
       mov       rcx,[rdi+rcx*8+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FFD526A9450]; System.IO.Path.GetFullPath(System.String)
       mov       rcx,rax
       mov       edx,80
       call      qword ptr [7FFD52931618]
       add       ebx,1
       jo        near ptr M01_L15
       mov       rcx,rsi
       call      qword ptr [7FFD526A9B88]; System.IO.DirectoryInfo.GetDirectories()
       cmp       [rax+8],ebx
       jg        short M01_L06
M01_L07:
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       pop       r12
       pop       r13
       pop       r14
       pop       r15
       ret
M01_L08:
       mov       rcx,rsi
       call      qword ptr [7FFD5267B258]; System.IO.FileSystemInfo.get_Exists()
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FFD527391E0]
       mov       rdi,rax
       mov       rbx,[rsi+8]
       test      rdi,rdi
       je        short M01_L09
       cmp       dword ptr [rdi+8],0
       je        short M01_L09
       test      rbx,rbx
       je        near ptr M01_L12
       jmp       short M01_L10
M01_L09:
       test      rbx,rbx
       je        near ptr M01_L11
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L11
       jmp       near ptr M01_L14
M01_L10:
       cmp       dword ptr [rbx+8],0
       je        near ptr M01_L12
       mov       ecx,[rdi+8]
       mov       eax,[rbx+8]
       lea       ecx,[rcx+rax+0B]
       call      System.String.FastAllocateString(Int32)
       mov       rbp,rax
       mov       r8d,[rdi+8]
       cmp       r8d,[rbp+8]
       jg        near ptr M01_L22
       lea       rcx,[rbp+0C]
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8,r8
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       mov       edx,[rbp+8]
       sub       edx,ecx
       cmp       edx,0B
       jl        near ptr M01_L23
       movsxd    rcx,ecx
       lea       rcx,[rbp+rcx*2+0C]
       mov       rdx,197DE400E20
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,16
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rdi+8]
       add       edx,0B
       mov       rcx,rbp
       mov       r8,rbx
       call      qword ptr [7FFD52421BB8]; System.String.FillStringChecked(System.String, Int32, System.String)
M01_L11:
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],4
       jl        near ptr M01_L24
       lea       rcx,[rdi+0C]
       mov       rdx,197E2408E48
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8,197E2402090
       mov       r8,[r8]
       mov       rcx,rdi
       mov       edx,4
       call      qword ptr [7FFD52421BB8]; System.String.FillStringChecked(System.String, Int32, System.String)
       mov       rcx,rdi
       mov       rdx,197E2402028
       mov       rdx,[rdx]
       call      qword ptr [7FFD52421C60]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       call      qword ptr [7FFD527391F8]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFD527395D0]
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.DirectoryNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFD52425C00]
       lea       rcx,[rbx+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+88]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L12:
       cmp       dword ptr [rdi+8],0
       je        near ptr M01_L11
       mov       ebx,[rdi+8]
       lea       ecx,[rbx+0B]
       call      System.String.FastAllocateString(Int32)
       mov       r8d,[rdi+8]
       mov       ebp,[rax+8]
       cmp       r8d,ebp
       jg        near ptr M01_L20
       lea       r14,[rax+0C]
       mov       rcx,r14
       lea       rdx,[rdi+0C]
       mov       r8d,[rdi+8]
       add       r8,r8
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       sub       ebp,ebx
       cmp       ebp,0B
       jl        near ptr M01_L21
       movsxd    rcx,ebx
       lea       rcx,[r14+rcx*2]
       mov       rdx,197DE400E20
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,16
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L11
M01_L13:
       mov       rcx,rsi
       call      qword ptr [7FFD526A9B88]; System.IO.DirectoryInfo.GetDirectories()
       mov       rdi,rax
       xor       ebx,ebx
       mov       rcx,197E2401590
       mov       rbp,[rcx]
       mov       r14,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       mov       rcx,197E24023D8
       mov       r15,[rcx]
       jmp       near ptr M01_L05
M01_L14:
       mov       ecx,[rbx+8]
       add       ecx,0B
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],0B
       jl        near ptr M01_L25
       lea       rcx,[rdi+0C]
       mov       rdx,197DE400E20
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,16
       call      qword ptr [7FFD524699F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       edx,0B
       mov       r8,rbx
       call      qword ptr [7FFD52421BB8]; System.String.FillStringChecked(System.String, Int32, System.String)
       jmp       near ptr M01_L11
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L19
       call      qword ptr [7FFD52739510]
       mov       rsi,rax
       mov       ecx,340
       mov       rdx,7FFD52626430
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,6D0
       mov       rdx,7FFD52626430
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFD52737CA8]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFD527390F0]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFD527395D0]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFD525ED8E8]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L19:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFD52423510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFD527390F0]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFD525ED8E8]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L24:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFD525B1C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1572
```

