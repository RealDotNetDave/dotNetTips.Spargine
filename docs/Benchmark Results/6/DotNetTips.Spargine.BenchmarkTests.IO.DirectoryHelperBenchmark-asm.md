## .NET 6.0.24 (6.0.2423.51814), X64 RyuJIT AVX2
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
       sub       rsp,90
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       cmp       dword ptr [7FF9C5BE3500],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       call      System.Runtime.InteropServices.OSPlatform.get_Windows()
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       call      System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform)
       mov       [rbp-2C],eax
       cmp       dword ptr [rbp-2C],0
       jne       short M01_L02
       mov       rcx,2842BE575F8
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,2842BE57600
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
M01_L03:
       mov       rcx,[rbp-38]
       call      System.Environment.GetEnvironmentVariable(System.String)
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       [rbp-8],rax
       call      System.Reflection.Assembly.GetEntryAssembly()
       mov       [rbp-48],rax
       mov       rdx,[rbp-48]
       mov       rcx,offset MD_System.Reflection.CustomAttributeExtensions.GetCustomAttributes[[System.Reflection.AssemblyCompanyAttribute, System.Private.CoreLib]](System.Reflection.Assembly)
       call      System.Reflection.CustomAttributeExtensions.GetCustomAttributes[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)
       mov       [rbp-50],rax
       mov       rdx,[rbp-50]
       mov       rcx,offset MD_System.Linq.Enumerable.FirstOrDefault[[System.Reflection.AssemblyCompanyAttribute, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.AssemblyCompanyAttribute>)
       call      System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       cmp       [rcx],ecx
       call      System.Reflection.AssemblyCompanyAttribute.get_Company()
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       cmp       [rcx],ecx
       call      System.String.Trim()
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp-10],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       call      System.IO.Path.Combine(System.String, System.String)
       mov       [rbp-70],rax
       mov       rax,[rbp-70]
       mov       [rbp-18],rax
       mov       rax,[rbp-18]
       mov       [rbp-20],rax
       nop
       jmp       short M01_L04
M01_L04:
       mov       rax,[rbp-20]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 299
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
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.AppDataFolder()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FF9C01C3870]; DotNetTips.Spargine.IO.DirectoryHelper.AppDataFolder()
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C01C3A20]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 60
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.AppDataFolder()
       push      rbp
       sub       rsp,90
       lea       rbp,[rsp+90]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-70],xmm4
       mov       rax,0FFFFFFFFFFFFFFA0
M01_L00:
       vmovdqa   xmmword ptr [rax+rbp],xmm4
       vmovdqa   xmmword ptr [rbp+rax+10],xmm4
       vmovdqa   xmmword ptr [rbp+rax+20],xmm4
       add       rax,30
       jne       short M01_L00
       cmp       dword ptr [7FF9C01BF8E8],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       call      qword ptr [7FF9C0195E40]; System.Runtime.InteropServices.OSPlatform.get_Windows()
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       call      qword ptr [7FF9C00BB528]; System.Runtime.InteropServices.RuntimeInformation.IsOSPlatform(System.Runtime.InteropServices.OSPlatform)
       mov       [rbp-2C],eax
       cmp       dword ptr [rbp-2C],0
       jne       short M01_L02
       mov       rcx,2AE4AC00E20
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
       jmp       short M01_L03
M01_L02:
       mov       rcx,2AE4AC00E28
       mov       rcx,[rcx]
       mov       [rbp-38],rcx
M01_L03:
       mov       rcx,[rbp-38]
       call      qword ptr [7FF9BFBEBAE0]; System.Environment.GetEnvironmentVariable(System.String)
       mov       [rbp-40],rax
       mov       rax,[rbp-40]
       mov       [rbp-8],rax
       call      qword ptr [7FF9BFD13C78]; System.Reflection.Assembly.GetEntryAssembly()
       mov       [rbp-48],rax
       mov       rdx,[rbp-48]
       mov       rcx,offset MD_System.Reflection.CustomAttributeExtensions.GetCustomAttributes[[System.Reflection.AssemblyCompanyAttribute, System.Private.CoreLib]](System.Reflection.Assembly)
       call      qword ptr [7FF9C01C39C0]; System.Reflection.CustomAttributeExtensions.GetCustomAttributes[[System.__Canon, System.Private.CoreLib]](System.Reflection.Assembly)
       mov       [rbp-50],rax
       mov       rdx,[rbp-50]
       mov       rcx,offset MD_System.Linq.Enumerable.FirstOrDefault[[System.Reflection.AssemblyCompanyAttribute, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.AssemblyCompanyAttribute>)
       call      qword ptr [7FF9BFD135E8]; System.Linq.Enumerable.FirstOrDefault[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       [rbp-58],rax
       mov       rcx,[rbp-58]
       cmp       [rcx],ecx
       call      qword ptr [7FF9BFEBDF00]; System.Reflection.AssemblyCompanyAttribute.get_Company()
       mov       [rbp-60],rax
       mov       rcx,[rbp-60]
       cmp       [rcx],ecx
       call      qword ptr [7FF9BFBA3438]; System.String.Trim()
       mov       [rbp-68],rax
       mov       rcx,[rbp-68]
       mov       [rbp-10],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp-10]
       call      qword ptr [7FF9BFE1B180]; System.IO.Path.Combine(System.String, System.String)
       mov       [rbp-70],rax
       mov       rax,[rbp-70]
       mov       [rbp-18],rax
       mov       rax,[rbp-18]
       mov       [rbp-20],rax
       nop
       mov       rax,[rbp-20]
       add       rsp,90
       pop       rbp
       ret
; Total bytes of code 306
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
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SafeDirectorySearch01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       rdx,2E7F8E11DF0
       mov       rdx,[rdx]
       xor       r8d,r8d
       call      DotNetTips.Spargine.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.IO.DirectoryInfo, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       push      rbp
       sub       rsp,30
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-8],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C5BAEB70],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<SafeDirectorySearch>d__8
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-8],rax
       mov       rcx,[rbp-8]
       mov       edx,0FFFFFFFE
       call      DotNetTips.Spargine.IO.DirectoryHelper+<SafeDirectorySearch>d__8..ctor(Int32)
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+18]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-8]
       lea       rcx,[rdx+28]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-8]
       mov       edx,[rbp+20]
       mov       [rax+6C],edx
       mov       rax,[rbp-8]
       add       rsp,30
       pop       rbp
       ret
; Total bytes of code 129
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
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SafeDirectorySearch01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       rdx,1BFEE000E20
       mov       rdx,[rdx]
       xor       r8d,r8d
       call      qword ptr [7FF9C01630C0]; DotNetTips.Spargine.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.IO.DirectoryInfo, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0163228]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       push      rbp
       push      rdi
       sub       rsp,28
       lea       rbp,[rsp+30]
       xor       eax,eax
       mov       [rbp-10],rax
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C0154ED8],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       mov       rcx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<SafeDirectorySearch>d__8
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-10],rax
       mov       rcx,[rbp-10]
       mov       edx,0FFFFFFFE
       call      qword ptr [7FF9C0163150]; DotNetTips.Spargine.IO.DirectoryHelper+<SafeDirectorySearch>d__8..ctor(Int32)
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+18]
       mov       rdx,[rbp+10]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rdx,[rbp-10]
       lea       rcx,[rdx+28]
       mov       rdx,[rbp+18]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-10]
       mov       edx,[rbp+20]
       mov       [rax+6C],edx
       mov       rax,[rbp-10]
       add       rsp,28
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 132
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
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SafeFileSearch01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       rdx,14CB59A1DF0
       mov       rdx,[rdx]
       xor       r8d,r8d
       call      DotNetTips.Spargine.IO.DirectoryHelper.SafeFileSearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.IO.FileInfo, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.IO.FileInfo> ByRef)
       cmp       [rcx],ecx
       call      BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 81
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.SafeFileSearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C5BAEE90],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       edx,1
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9C5722160]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+18]
       mov       r8d,[rbp+20]
       call      DotNetTips.Spargine.IO.DirectoryHelper.SafeFileSearch(System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>, System.String, System.IO.SearchOption)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       nop
       jmp       short M01_L01
M01_L01:
       mov       rax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 151
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
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SafeFileSearch01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       rdx,22A67000E20
       mov       rdx,[rdx]
       xor       r8d,r8d
       call      qword ptr [7FF9C0183348]; DotNetTips.Spargine.IO.DirectoryHelper.SafeFileSearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.IO.FileInfo, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.IO.FileInfo> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FF9C0183498]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.SafeFileSearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       push      rbp
       sub       rsp,40
       lea       rbp,[rsp+40]
       vxorps    xmm4,xmm4,xmm4
       vmovdqa   xmmword ptr [rbp-20],xmm4
       vmovdqa   xmmword ptr [rbp-10],xmm4
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       cmp       dword ptr [7FF9C0175310],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-18],rax
       mov       rcx,[rbp-18]
       mov       edx,1
       call      qword ptr [7FF9BFC17918]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(Int32)
       mov       rcx,[rbp-18]
       mov       rdx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9BFC07098]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Add(System.__Canon)
       nop
       mov       rcx,[rbp-18]
       mov       [rbp-8],rcx
       mov       rcx,[rbp-8]
       mov       rdx,[rbp+18]
       mov       r8d,[rbp+20]
       call      qword ptr [7FF9C0183360]; DotNetTips.Spargine.IO.DirectoryHelper.SafeFileSearch(System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>, System.String, System.IO.SearchOption)
       mov       [rbp-20],rax
       mov       rax,[rbp-20]
       mov       [rbp-10],rax
       nop
       mov       rax,[rbp-10]
       add       rsp,40
       pop       rbp
       ret
; Total bytes of code 151
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
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SetFileAttributesToNormal01()
       mov       rcx,[rcx+190]
       jmp       near ptr DotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.IO.DirectoryInfo)
; Total bytes of code 12
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.IO.DirectoryInfo)
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
       cmp       dword ptr [7FF9C5BDEAF0],0
       je        short M01_L00
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L00:
       nop
       mov       r8,1C54ECB3020
       mov       r8,[r8]
       mov       r9,1C52ECB59D0
       mov       r9,[r9]
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      DotNetTips.Spargine.Core.Validator.ArgumentExists(System.IO.DirectoryInfo, System.IO.DirectoryInfo, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.IO.DirectoryInfo.GetDirectories()
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M01_L04
M01_L01:
       nop
       mov       rcx,[rbp-8]
       mov       eax,[rbp-0C]
       cmp       eax,[rcx+8]
       jb        short M01_L02
       call      CORINFO_HELP_RNGCHKFAIL
M01_L02:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       call      DotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.IO.DirectoryInfo)
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M01_L03
       call      CORINFO_HELP_OVERFLOW
M01_L03:
       mov       [rbp-0C],ecx
M01_L04:
       mov       ecx,[rbp-0C]
       mov       [rbp-2C],ecx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.IO.DirectoryInfo.GetDirectories()
       mov       [rbp-38],rax
       mov       ecx,[rbp-2C]
       mov       rax,[rbp-38]
       cmp       ecx,[rax+8]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-10],ecx
       cmp       dword ptr [rbp-10],0
       jne       short M01_L01
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       short M01_L08
M01_L05:
       nop
       mov       rcx,[rbp-8]
       mov       eax,[rbp-14]
       cmp       eax,[rcx+8]
       jb        short M01_L06
       call      CORINFO_HELP_RNGCHKFAIL
M01_L06:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-58]
       mov       rax,[rbp-58]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       edx,80
       call      System.IO.File.SetAttributes(System.String, System.IO.FileAttributes)
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M01_L07
       call      CORINFO_HELP_OVERFLOW
M01_L07:
       mov       [rbp-14],eax
M01_L08:
       mov       ecx,[rbp-14]
       mov       [rbp-3C],ecx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      System.IO.DirectoryInfo.GetDirectories()
       mov       [rbp-48],rax
       mov       ecx,[rbp-3C]
       mov       rax,[rbp-48]
       cmp       ecx,[rax+8]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       jne       near ptr M01_L05
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 401
```

## .NET 7.0.13 (7.0.1323.51816), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SetFileAttributesToNormal01()
       mov       rcx,[rcx+190]
       jmp       qword ptr [7FF9C0173408]; DotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.IO.DirectoryInfo)
; Total bytes of code 13
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.IO.DirectoryInfo)
M01_L00:
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
       cmp       dword ptr [7FF9C0164F70],0
       je        short M01_L01
       call      CORINFO_HELP_DBG_IS_JUST_MY_CODE
M01_L01:
       nop
       mov       r8,2C9FEC02028
       mov       r8,[r8]
       mov       r9,2C9FEC08E48
       mov       r9,[r9]
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      qword ptr [7FF9BFEA7A80]; DotNetTips.Spargine.Core.Validator.ArgumentExists(System.IO.DirectoryInfo, System.IO.DirectoryInfo, System.String, System.String)
       mov       [rbp-20],rax
       mov       rcx,[rbp-20]
       mov       [rbp+10],rcx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9BFE19B88]; System.IO.DirectoryInfo.GetDirectories()
       mov       [rbp-28],rax
       mov       rcx,[rbp-28]
       mov       [rbp-8],rcx
       xor       ecx,ecx
       mov       [rbp-0C],ecx
       nop
       jmp       short M01_L05
M01_L02:
       nop
       mov       rcx,[rbp-8]
       mov       eax,[rbp-0C]
       cmp       eax,[rcx+8]
       jb        short M01_L03
       call      CORINFO_HELP_RNGCHKFAIL
M01_L03:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       call      qword ptr [7FF9C0173408]
       nop
       nop
       mov       ecx,[rbp-0C]
       add       ecx,1
       jno       short M01_L04
       call      CORINFO_HELP_OVERFLOW
M01_L04:
       mov       [rbp-0C],ecx
M01_L05:
       mov       ecx,[rbp-0C]
       mov       [rbp-2C],ecx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9BFE19B88]; System.IO.DirectoryInfo.GetDirectories()
       mov       [rbp-38],rax
       mov       ecx,[rbp-2C]
       mov       rax,[rbp-38]
       cmp       ecx,[rax+8]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-10],ecx
       cmp       dword ptr [rbp-10],0
       jne       short M01_L02
       xor       ecx,ecx
       mov       [rbp-14],ecx
       nop
       jmp       short M01_L09
M01_L06:
       nop
       mov       rcx,[rbp-8]
       mov       eax,[rbp-14]
       cmp       eax,[rcx+8]
       jb        short M01_L07
       call      CORINFO_HELP_RNGCHKFAIL
M01_L07:
       mov       edx,eax
       lea       rcx,[rcx+rdx*8+10]
       mov       rcx,[rcx]
       mov       [rbp-58],rcx
       mov       rcx,[rbp-58]
       mov       rax,[rbp-58]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+30]
       mov       [rbp-50],rax
       mov       rcx,[rbp-50]
       mov       edx,80
       call      qword ptr [7FF9C006FA50]
       nop
       nop
       mov       eax,[rbp-14]
       add       eax,1
       jno       short M01_L08
       call      CORINFO_HELP_OVERFLOW
M01_L08:
       mov       [rbp-14],eax
M01_L09:
       mov       ecx,[rbp-14]
       mov       [rbp-3C],ecx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       call      qword ptr [7FF9BFE19B88]; System.IO.DirectoryInfo.GetDirectories()
       mov       [rbp-48],rax
       mov       ecx,[rbp-3C]
       mov       rax,[rbp-48]
       cmp       ecx,[rax+8]
       setl      cl
       movzx     ecx,cl
       mov       [rbp-18],ecx
       cmp       dword ptr [rbp-18],0
       jne       near ptr M01_L06
       nop
       add       rsp,80
       pop       rbp
       ret
; Total bytes of code 407
```

