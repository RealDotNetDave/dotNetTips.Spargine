## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.AppDataFolder()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       call      DotNetTips.Spargine.IO.DirectoryHelper.AppDataFolder()
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,8
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 38
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
       mov       [rbp+0FFC0],rcx
       mov       [rbp+0FFB8],rcx
       lea       rcx,[rbp+0FF70]
       mov       rdx,r10
       call      CORINFO_HELP_INIT_PINVOKE_FRAME
       mov       rsi,rax
       mov       rax,rsp
       mov       [rbp+0FF90],rax
       mov       rax,rbp
       mov       [rbp+0FFA0],rax
       call      System.Runtime.InteropServices.OSPlatform.get_Windows()
       mov       rcx,rax
       call      System.OperatingSystem.IsOSPlatform(System.String)
       test      al,al
       jne       short M01_L00
       mov       rcx,2382B6D23C8
       mov       rcx,[rcx]
       jmp       short M01_L01
M01_L00:
       mov       rcx,2382B6D23D0
       mov       rcx,[rcx]
M01_L01:
       call      System.Environment.GetEnvironmentVariable(System.String)
       mov       [rbp+0FFB0],rax
       cmp       byte ptr [7FFB528053B9],0
       jne       near ptr M01_L05
       xor       ecx,ecx
       mov       [rbp+0FFC0],rcx
       lea       rcx,[rbp+0FFC0]
       mov       rax,offset MD_System.Reflection.Assembly.GetEntryAssemblyNative(System.Runtime.CompilerServices.ObjectHandleOnStack)
       mov       [rbp+0FF80],rax
       lea       rax,[M01_L02]
       mov       [rbp+0FF98],rax
       lea       rax,[rbp+0FF70]
       mov       [rsi+10],rax
       mov       byte ptr [rsi+0C],0
       call      qword ptr [7FFB52801118]
M01_L02:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFB528059FC],0
       je        short M01_L03
       call      qword ptr [7FFB527F7398]
M01_L03:
       mov       rcx,[rbp+0FF78]
       mov       [rsi+10],rcx
       mov       rsi,[rbp+0FFC0]
       xor       ecx,ecx
       mov       [rbp+0FFC0],rcx
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
       lea       r8,[rbp+0FFB8]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst(System.Collections.Generic.IEnumerable`1<!!0>, Boolean ByRef)
       call      System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rcx,[rax+8]
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,[rbp+0FFB0]
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

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SafeDirectorySearch01()
       push      rsi
       sub       rsp,20
       mov       rsi,rcx
       mov       rcx,[rsi+1C8]
       mov       rdx,1BB6F859F90
       mov       rdx,[rdx]
       xor       r8d,r8d
       call      DotNetTips.Spargine.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       mov       rcx,[rsi+18]
       cmp       [rcx],ecx
       add       rcx,10
       mov       rdx,rax
       call      CORINFO_HELP_CHECKED_ASSIGN_REF
       nop
       add       rsp,20
       pop       rsi
       ret
; Total bytes of code 61
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,50
       lea       rbp,[rsp+60]
       xor       eax,eax
       mov       [rbp+0FFD8],rax
       mov       [rbp+0FFC0],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       [rbp+20],r8d
       mov       r8,1BB6F853020
       mov       r8,[r8]
       mov       r9,1BB4F8514F0
       mov       r9,[r9]
       mov       rcx,[rbp+10]
       xor       edx,edx
       call      DotNetTips.Spargine.Core.Validator.ArgumentExists(System.IO.DirectoryInfo, System.IO.DirectoryInfo, System.String, System.String)
       mov       [rbp+10],rax
       mov       rcx,[rbp+18]
       cmp       qword ptr [rbp+18],0
       je        short M01_L00
       cmp       dword ptr [rcx+8],0
       je        short M01_L00
       xor       eax,eax
       jmp       short M01_L01
M01_L00:
       mov       eax,1
M01_L01:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M01_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rsi,rax
       mov       ecx,2B3
       mov       rdx,7FFB528CC4C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M01_L02:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       [rbp+18],rax
       mov       esi,[rbp+20]
       mov       rcx,offset MT_System.IO.SearchOption
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.IO.SearchOption
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       edx,[rbp+20]
       mov       [rdi+8],edx
       mov       rdx,rdi
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       ecx,27B
       mov       rdx,7FFB528CC4C8
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       [rbp+20],esi
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp+0FFD0],rax
       mov       rcx,7FFB52554928
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,1BB6F852FC8
       mov       rdx,[rdx]
       mov       rax,[rbp+0FFD0]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp+0FFD0]
       inc       dword ptr [rax+14]
       mov       rcx,[rax+8]
       mov       edx,[rax+10]
       cmp       [rcx+8],edx
       jbe       short M01_L04
       lea       r8d,[rdx+1]
       mov       [rbp+0FFD0],rax
       mov       [rax+10],r8d
       mov       r8,[rbp+10]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L05
M01_L04:
       mov       [rbp+0FFD0],rax
       mov       rcx,rax
       mov       rdx,[rbp+10]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L05:
       mov       rax,[rbp+0FFD0]
       mov       [rbp+0FFE0],rax
       xor       ecx,ecx
       mov       [rbp+0FFEC],ecx
       mov       rcx,[rbp+10]
       cmp       [rcx],ecx
       mov       ecx,[rbp+20]
       call      System.IO.EnumerationOptions.FromSearchOption(System.IO.SearchOption)
       mov       r8,rax
       mov       rdx,[rbp+18]
       mov       rcx,[rbp+10]
       call      System.IO.DirectoryInfo.GetDirectories(System.String, System.IO.EnumerationOptions)
       cmp       dword ptr [rax+8],0
       jle       near ptr M01_L10
M01_L06:
       mov       ecx,[rbp+20]
       call      System.IO.EnumerationOptions.FromSearchOption(System.IO.SearchOption)
       mov       r8,rax
       mov       rdx,[rbp+18]
       mov       rcx,[rbp+10]
       call      System.IO.DirectoryInfo.GetDirectories(System.String, System.IO.EnumerationOptions)
       mov       ecx,[rax+8]
       cmp       [rbp+0FFEC],ecx
       jae       short M01_L07
       mov       ecx,[rbp+0FFEC]
       movsxd    rcx,ecx
       mov       rcx,[rax+rcx*8+10]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       mov       rsi,rax
       test      rsi,rsi
       je        short M01_L09
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      r8b
       movzx     r8d,r8b
       jmp       short M01_L08
M01_L07:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L08:
       test      r8d,r8d
       je        short M01_L09
       mov       r8,rsi
       mov       rdx,[rbp+0FFE0]
       mov       rcx,offset MD_DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange(System.Collections.Generic.ICollection`1<!!0>, System.Collections.Generic.IEnumerable`1<!!0>, DotNetTips.Spargine.Core.Tristate)
       mov       r9d,0FFFFFFFF
       call      DotNetTips.Spargine.Extensions.CollectionExtensions.AddRange[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.ICollection`1<System.__Canon>, System.Collections.Generic.IEnumerable`1<System.__Canon>, DotNetTips.Spargine.Core.Tristate)
       nop
M01_L09:
       mov       ecx,[rbp+0FFEC]
       add       ecx,1
       jo        short M01_L11
       mov       [rbp+0FFEC],ecx
       mov       ecx,[rbp+20]
       call      System.IO.EnumerationOptions.FromSearchOption(System.IO.SearchOption)
       mov       r8,rax
       mov       rdx,[rbp+18]
       mov       rcx,[rbp+10]
       call      System.IO.DirectoryInfo.GetDirectories(System.String, System.IO.EnumerationOptions)
       mov       eax,[rax+8]
       cmp       eax,[rbp+0FFEC]
       jg        near ptr M01_L06
M01_L10:
       mov       rax,[rbp+0FFE0]
       add       rsp,50
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L11:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rdx,rax
       test      rdx,rdx
       jne       short M01_L12
       xor       eax,eax
       jmp       short M01_L15
M01_L12:
       mov       [rbp+0FFD8],rdx
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M01_L13
       mov       rdx,[rbp+0FFD8]
       mov       rcx,offset MT_System.IO.DirectoryNotFoundException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M01_L13
       mov       rdx,[rbp+0FFD8]
       mov       rcx,offset MT_System.UnauthorizedAccessException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       setne     al
       movzx     eax,al
       jmp       short M01_L14
M01_L13:
       mov       eax,1
M01_L14:
       test      eax,eax
       setne     al
       movzx     eax,al
M01_L15:
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+20]
       mov       [rsp+20],rbp
       lea       rbp,[rbp+60]
       mov       rcx,[rbp+0FFD8]
       mov       rax,[rbp+0FFD8]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      System.Diagnostics.Trace.WriteLine(System.String)
       lea       rax,[7FFB527EFFF7]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 839
```

## .NET 6.0.7 (6.0.722.32202), X64 RyuJIT
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SetFileAttributesToNormal01()
       mov       rcx,[rcx+1C8]
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
       mov       r8,1DB606A3020
       mov       r8,[r8]
       mov       r9,1DB806A14F0
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

