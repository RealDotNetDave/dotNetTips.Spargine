## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rcx,206FC951B28
       mov       rcx,[rcx]
       jmp       short M01_L01
M01_L00:
       mov       rcx,206FC951B30
       mov       rcx,[rcx]
M01_L01:
       call      System.Environment.GetEnvironmentVariable(System.String)
       mov       [rbp-50],rax
       cmp       byte ptr [7FFF78D453B9],0
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
       call      qword ptr [7FFF78E4E328]
M01_L02:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFFD8C36A14],0
       je        short M01_L03
       call      qword ptr [7FFFD8C28398]; CORINFO_HELP_STOP_FOR_GC
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.AppDataFolder()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       call      qword ptr [7FFF7F2D9300]; DotNetTips.Spargine.IO.DirectoryHelper.AppDataFolder()
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.String, System.Private.CoreLib]](System.String ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F2D94E0]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
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
       call      qword ptr [7FFF7F27D348]; System.Runtime.InteropServices.OSPlatform.get_Windows()
       mov       rcx,rax
       call      qword ptr [7FFF7F15FC60]; System.OperatingSystem.IsOSPlatform(System.String)
       test      eax,eax
       jne       short M01_L00
       mov       rcx,1AD0B00A828
       mov       rcx,[rcx]
       jmp       short M01_L01
M01_L00:
       mov       rcx,1AD0B00A830
       mov       rcx,[rcx]
M01_L01:
       call      qword ptr [7FFF7EEEBAE0]; System.Environment.GetEnvironmentVariable(System.String)
       mov       [rbp-50],rax
       cmp       byte ptr [7FFF7ED75711],0
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
       call      qword ptr [7FFF7EFF4098]
M01_L02:
       mov       byte ptr [rsi+0C],1
       cmp       dword ptr [7FFFDEC70EAC],0
       je        short M01_L03
       call      qword ptr [7FFFDEC63378]; CORINFO_HELP_STOP_FOR_GC
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
       call      qword ptr [7FFF7F0BBB10]; System.Attribute.GetCustomAttributes(System.Reflection.Assembly, System.Type, Boolean)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.IEnumerable`1[[System.Reflection.AssemblyCompanyAttribute, System.Private.CoreLib]]
       call      qword ptr [7FFF7EE0B858]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       lea       r8,[rbp-48]
       mov       rcx,offset MD_System.Linq.Enumerable.TryGetFirst[[System.Reflection.AssemblyCompanyAttribute, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.Reflection.AssemblyCompanyAttribute>, Boolean ByRef)
       call      qword ptr [7FFF7F09DF60]; System.Linq.Enumerable.TryGetFirst[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>, Boolean ByRef)
       mov       rcx,[rax+8]
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rdx,rax
       mov       rcx,[rbp-50]
       call      qword ptr [7FFF7F123180]; System.IO.Path.Combine(System.String, System.String)
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
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SafeDirectorySearch01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       rdx,2BF196E1B28
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
       push      rdi
       push      rsi
       sub       rsp,60
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-30],rax
       mov       [rbp-48],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       esi,r8d
       mov       r8,2BED96E1028
       mov       r8,[r8]
       mov       r9,2BF396E1550
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
       mov       rdx,7FFF7909DB08
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
       mov       rcx,offset MT_System.IO.SearchOption
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.IO.SearchOption
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [rdi+8],esi
       mov       rdx,rdi
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M01_L03
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rsi,rax
       mov       ecx,27B
       mov       rdx,7FFF7909DB08
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rsi
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M01_L03:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-38],rax
       mov       rcx,7FFF78D44928
       mov       edx,28
       call      CORINFO_HELP_CLASSINIT_SHARED_DYNAMICCLASS
       mov       rdx,2BED96E6220
       mov       rdx,[rdx]
       mov       rax,[rbp-38]
       lea       rcx,[rax+8]
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-38]
       inc       dword ptr [rax+14]
       mov       rcx,[rax+8]
       mov       edx,[rax+10]
       cmp       [rcx+8],edx
       jbe       short M01_L04
       lea       r8d,[rdx+1]
       mov       [rbp-38],rax
       mov       [rax+10],r8d
       mov       r8,[rbp+10]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L05
M01_L04:
       mov       [rbp-38],rax
       mov       rcx,rax
       mov       rdx,[rbp+10]
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L05:
       mov       rcx,[rbp-38]
       mov       [rbp-20],rcx
       mov       rcx,offset MT_System.IO.EnumerationOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.IO.EnumerationOptions..ctor()
       mov       byte ptr [rdi+1D],1
       mov       byte ptr [rdi+1E],0
       mov       byte ptr [rdi+1C],0
       mov       [rbp-28],rdi
       cmp       esi,1
       jne       short M01_L06
       mov       byte ptr [rdi+1C],1
M01_L06:
       xor       ecx,ecx
       mov       [rbp-14],ecx
       jmp       near ptr M01_L11
M01_L07:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+20],rdi
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+8]
       mov       rcx,[rbp+10]
       mov       r8,[rbp+18]
       mov       r9d,2
       call      System.IO.DirectoryInfo.InternalEnumerateInfos(System.String, System.String, System.IO.SearchTarget, System.IO.EnumerationOptions)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.IEnumerable`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_CHKCASTARRAY
       mov       rdx,rax
       mov       rcx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       ecx,[rax+8]
       cmp       [rbp-14],ecx
       jae       short M01_L08
       mov       ecx,[rbp-14]
       movsxd    rcx,ecx
       mov       rcx,[rax+rcx*8+10]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      DotNetTips.Spargine.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       mov       rsi,rax
       test      rsi,rsi
       je        short M01_L10
       mov       rcx,rsi
       call      DotNetTips.Spargine.Extensions.EnumerableExtensions.Count(System.Collections.IEnumerable)
       test      eax,eax
       setg      dl
       movzx     edx,dl
       jmp       short M01_L09
M01_L08:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L09:
       test      edx,edx
       je        short M01_L10
       mov       rcx,[rbp-20]
       mov       edx,[rcx+10]
       mov       r8,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].InsertRange(Int32, System.Collections.Generic.IEnumerable`1<System.__Canon>)
       nop
M01_L10:
       mov       eax,[rbp-14]
       add       eax,1
       jo        short M01_L12
       mov       [rbp-14],eax
       mov       rdi,[rbp-28]
M01_L11:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       [rsp+20],rdi
       mov       rdx,[rbp+10]
       mov       rdx,[rdx+8]
       mov       rcx,[rbp+10]
       mov       r8,[rbp+18]
       mov       r9d,2
       call      System.IO.DirectoryInfo.InternalEnumerateInfos(System.String, System.String, System.IO.SearchTarget, System.IO.EnumerationOptions)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.IEnumerable`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_CHKCASTARRAY
       mov       rdx,rax
       mov       rcx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,rsi
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       mov       ecx,[rax+8]
       cmp       ecx,[rbp-14]
       jg        near ptr M01_L07
       mov       rax,[rbp-20]
       add       rsp,60
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L12:
       call      CORINFO_HELP_OVERFLOW
       int       3
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+70]
       mov       rcx,offset MT_System.Exception
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       mov       rdx,rax
       test      rdx,rdx
       jne       short M01_L13
       xor       eax,eax
       jmp       short M01_L16
M01_L13:
       mov       [rbp-30],rdx
       mov       rcx,offset MT_System.ArgumentException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M01_L14
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.IO.DirectoryNotFoundException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       jne       short M01_L14
       mov       rdx,[rbp-30]
       mov       rcx,offset MT_System.UnauthorizedAccessException
       call      CORINFO_HELP_ISINSTANCEOFCLASS
       test      rax,rax
       setne     al
       movzx     eax,al
       jmp       short M01_L15
M01_L14:
       mov       eax,1
M01_L15:
       test      eax,eax
       setne     al
       movzx     eax,al
M01_L16:
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       sub       rsp,30
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+70]
       mov       rcx,[rbp-30]
       mov       rax,[rbp-30]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      System.Diagnostics.Trace.WriteLine(System.String)
       lea       rax,[M01_L10]
       add       rsp,30
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 959
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SafeDirectorySearch01()
       push      rsi
       sub       rsp,30
       xor       eax,eax
       mov       [rsp+28],rax
       mov       rsi,rcx
       mov       rcx,[rsi+190]
       mov       rdx,29431400C18
       mov       rdx,[rdx]
       xor       r8d,r8d
       call      qword ptr [7FFF7F2D90C0]; DotNetTips.Spargine.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.IO.DirectoryInfo, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F2DBF90]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rsi
       ret
; Total bytes of code 83
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.SafeDirectorySearch(System.IO.DirectoryInfo, System.String, System.IO.SearchOption)
M01_L00:
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,58
       lea       rbp,[rsp+70]
       xor       eax,eax
       mov       [rbp-38],rax
       mov       [rbp-48],rsp
       mov       [rbp+10],rcx
       mov       [rbp+18],rdx
       mov       esi,r8d
       mov       rdi,[rbp+10]
       cmp       qword ptr [rbp+10],0
       jne       near ptr M01_L04
       call      qword ptr [7FFF7F24F900]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       rbx,rax
       cmp       dword ptr [rbx+8],4
       jl        near ptr M01_L20
       lea       rcx,[rbx+0C]
       mov       rdx,29425402560
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rbx+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M01_L21
       lea       rcx,[rbx+14]
       mov       rdx,2942D400098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rbx+8],0
       je        short M01_L03
       mov       rcx,rbx
M01_L01:
       test      rcx,rcx
       jne       short M01_L02
       mov       eax,1
       jmp       near ptr M01_L22
M01_L02:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M01_L22
M01_L03:
       mov       rcx,2942D400030
       mov       rcx,[rcx]
       jmp       short M01_L01
M01_L04:
       mov       rcx,rdi
       call      qword ptr [7FFF7F0E5658]; System.IO.FileSystemInfo.get_Exists()
       test      eax,eax
       jne       near ptr M01_L10
       call      qword ptr [7FFF7F24F9F0]
       mov       rcx,rax
       mov       r8,[rdi+8]
       mov       rdx,29431400C30
       mov       rdx,[rdx]
       call      qword ptr [7FFF7EEA1C78]; System.String.Concat(System.String, System.String, System.String)
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       rsi,rax
       cmp       dword ptr [rsi+8],4
       jl        near ptr M01_L24
       lea       rcx,[rsi+0C]
       mov       rdx,29425402560
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rsi+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M01_L25
       lea       rcx,[rsi+14]
       mov       rdx,2942D400098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EEE99F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rsi
       mov       rdx,2942D400030
       mov       rdx,[rdx]
       call      qword ptr [7FFF7EEA1C60]; System.String.Concat(System.String, System.String)
       mov       rsi,rax
       call      qword ptr [7FFF7F24FA08]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F24FD98]
       mov       rsi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.DirectoryNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7EEA5C00]
       lea       rcx,[rbx+10]
       mov       rdx,rsi
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbx+88]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
M01_L05:
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8,rdi
       call      qword ptr [7FFF7F123BD0]; System.IO.DirectoryInfo.GetDirectories(System.String, System.IO.EnumerationOptions)
       mov       ecx,[rax+8]
       cmp       [rbp-1C],ecx
       jae       short M01_L06
       mov       ecx,[rbp-1C]
       mov       rcx,[rax+rcx*8+10]
       mov       rdx,[rbp+18]
       xor       r8d,r8d
       call      qword ptr [7FFF7F2D90C0]
       mov       rsi,rax
       test      rsi,rsi
       je        short M01_L08
       mov       rcx,rsi
       call      qword ptr [7FFF7F24BC60]
       xor       edx,edx
       test      eax,eax
       setg      dl
       jmp       short M01_L07
M01_L06:
       call      CORINFO_HELP_RNGCHKFAIL
M01_L07:
       test      edx,edx
       je        short M01_L08
       mov       rax,[rbp-28]
       mov       edx,[rax+10]
       mov       rcx,rax
       mov       r8,rsi
       call      qword ptr [7FFF7EF17E28]
       nop
M01_L08:
       mov       ecx,[rbp-1C]
       add       ecx,1
       jo        near ptr M01_L19
       mov       [rbp-1C],ecx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8,[rbp-30]
       call      qword ptr [7FFF7F123BD0]; System.IO.DirectoryInfo.GetDirectories(System.String, System.IO.EnumerationOptions)
       mov       ecx,[rax+8]
       cmp       ecx,[rbp-1C]
       mov       rdi,[rbp-30]
       jg        near ptr M01_L05
M01_L09:
       mov       rax,[rbp-28]
       add       rsp,58
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
M01_L10:
       mov       [rbp+10],rdi
       mov       rcx,[rbp+18]
       cmp       qword ptr [rbp+18],0
       je        short M01_L11
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M01_L12
       jmp       short M01_L12
M01_L11:
       xor       eax,eax
M01_L12:
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FFF7F24FCD8]
       mov       rsi,rax
       mov       ecx,2B3
       mov       rdx,7FFF7F2E49B8
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0A6190
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0A6190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rdi
       mov       r9,rbx
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F24F270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F24F900]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F24FD98]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F00FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L13:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       [rbp+18],rax
       mov       rcx,offset MT_System.IO.SearchOption
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.IO.SearchOption
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [rdi+8],esi
       mov       rdx,rdi
       call      qword ptr [7FFF7ED81708]; System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       near ptr M01_L15
       call      qword ptr [7FFF7F24FA20]
       mov       rdi,rax
       mov       rcx,29431400C28
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L14
       call      qword ptr [7FFF7F24FCD8]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0A6190
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0A6190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F24F270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F24F900]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F24FD98]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F00FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L14:
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F24F918]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7F24FD98]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7F035750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L15:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       [rbp-40],rax
       mov       rdx,2942D405930
       mov       rdi,[rdx]
       lea       rcx,[rax+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rax,[rbp-40]
       inc       dword ptr [rax+14]
       mov       rcx,rdi
       mov       edx,[rax+10]
       cmp       [rcx+8],edx
       jbe       short M01_L16
       lea       r8d,[rdx+1]
       mov       [rax+10],r8d
       movsxd    rdx,edx
       mov       r8,[rbp+10]
       call      CORINFO_HELP_ARRADDR_ST
       jmp       short M01_L17
M01_L16:
       mov       rcx,rax
       mov       rdx,[rbp+10]
       call      qword ptr [7FFF7EF17A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M01_L17:
       mov       rcx,[rbp-40]
       mov       [rbp-28],rcx
       mov       rcx,offset MT_System.IO.EnumerationOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7F2D9198]; System.IO.EnumerationOptions..ctor()
       mov       byte ptr [rdi+1D],1
       mov       byte ptr [rdi+1E],0
       mov       byte ptr [rdi+1C],0
       mov       [rbp-30],rdi
       cmp       esi,1
       jne       short M01_L18
       mov       byte ptr [rdi+1C],1
M01_L18:
       xor       ecx,ecx
       mov       [rbp-1C],ecx
       mov       rcx,[rbp+10]
       mov       rdx,[rbp+18]
       mov       r8,rdi
       call      qword ptr [7FFF7F123BD0]; System.IO.DirectoryInfo.GetDirectories(System.String, System.IO.EnumerationOptions)
       cmp       dword ptr [rax+8],0
       jle       near ptr M01_L09
       jmp       near ptr M01_L05
M01_L19:
       call      CORINFO_HELP_OVERFLOW
M01_L20:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F031C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F031C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L22:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L23
       call      qword ptr [7FFF7F24FCD8]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0A6190
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0A6190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F24F270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F24F900]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F24FD98]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F00FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L23:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EEA3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F24F900]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F00FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L24:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F031C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F031C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+70]
       mov       rcx,offset MT_System.Exception
       call      qword ptr [7FFF7EE0B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       mov       rdx,rax
       test      rdx,rdx
       jne       short M01_L26
       xor       eax,eax
       jmp       short M01_L29
M01_L26:
       mov       [rbp-38],rdx
       mov       rcx,offset MT_System.ArgumentException
       call      qword ptr [7FFF7EE0B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M01_L27
       mov       rdx,[rbp-38]
       mov       rcx,offset MT_System.IO.DirectoryNotFoundException
       call      qword ptr [7FFF7EE0B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       jne       short M01_L27
       mov       rdx,[rbp-38]
       mov       rcx,offset MT_System.UnauthorizedAccessException
       call      qword ptr [7FFF7EE0B828]; System.Runtime.CompilerServices.CastHelpers.IsInstanceOfClass(Void*, System.Object)
       test      rax,rax
       setne     al
       movzx     eax,al
       jmp       short M01_L28
M01_L27:
       mov       eax,1
M01_L28:
       test      eax,eax
       setne     al
       movzx     eax,al
M01_L29:
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
       push      rbp
       push      rdi
       push      rsi
       push      rbx
       sub       rsp,38
       mov       rbp,[rcx+28]
       mov       [rsp+28],rbp
       lea       rbp,[rbp+70]
       mov       rcx,[rbp-38]
       mov       rax,[rbp-38]
       mov       rax,[rax]
       mov       rax,[rax+40]
       call      qword ptr [rax+20]
       mov       rcx,rax
       call      qword ptr [7FFF7F2D96C0]
       lea       rax,[M01_L08]
       add       rsp,38
       pop       rbx
       pop       rsi
       pop       rdi
       pop       rbp
       ret
; Total bytes of code 1955
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       rdx,2A79C9D6318
       mov       rdx,[rdx]
       mov       rcx,rbx
       xor       r8d,r8d
       call      DotNetTips.Spargine.IO.DirectoryHelper.SafeFileSearch(System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>, System.String, System.IO.SearchOption)
       mov       [rsp+28],rax
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
; Total bytes of code 182
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
       call      qword ptr [7FFFD8737F00]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFD8737F00]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFD8737F00]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFD8737F00]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFD8737F00]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFD8737F00]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFD8737F00]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFD8737F00]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFD8737F00]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFD8737F00]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFD8737F00]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFD8737F00]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
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
       mov       edx,ebx
       mov       edx,ebx
       mov       edx,ebx
       mov       edx,ebx
       mov       edx,ebx
       mov       edx,ebx
       mov       edx,ebx
       mov       edx,ebx
       mov       edx,ebx
       mov       edx,ebx
       mov       edx,ebx
       mov       edx,ebx
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
       call      qword ptr [7FFFD87205A0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFD87205A0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFD87205A0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFD87205A0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFD87205A0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFD87205A0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFD87205A0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFD87205A0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFD87205A0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFD87205A0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFD87205A0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFD87205A0]; CORINFO_HELP_ARRADDR_ST
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
; Total bytes of code 708
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.SafeFileSearch(System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>, System.String, System.IO.SearchOption)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       setne     al
       movzx     eax,al
       test      eax,eax
       je        near ptr M02_L05
       mov       rcx,[rbp+8]
       test      rcx,rcx
       je        near ptr M02_L04
       cmp       dword ptr [rcx+8],0
       je        near ptr M02_L04
       xor       eax,eax
M02_L00:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       short M02_L01
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorStringIsNullOrEmpty()
       mov       rbp,rax
       mov       ecx,2B3
       mov       rdx,7FFF790ADE28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String, System.String)
       int       3
M02_L01:
       cmp       [rcx],ecx
       mov       edx,3
       call      System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.SearchOption
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.IO.SearchOption
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       rcx,rax
       mov       [rdi+8],ebx
       mov       rdx,rdi
       call      System.Enum.IsDefined(System.Type, System.Object)
       test      eax,eax
       jne       short M02_L02
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorEnumNotDefined()
       mov       rbp,rax
       mov       ecx,27B
       mov       rdx,7FFF790ADE28
       call      CORINFO_HELP_STRCNS
       mov       rdx,rax
       mov       rcx,rbp
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentOutOfRangeException(System.String, System.String)
       int       3
M02_L02:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.FileInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,2A79C9D3DD8
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.EnumerationOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      System.IO.EnumerationOptions..ctor()
       mov       byte ptr [rdi+1D],1
       mov       byte ptr [rdi+1E],0
       mov       byte ptr [rdi+1C],0
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       ebx,1
       jne       short M02_L03
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+1C],1
M02_L03:
       mov       rcx,offset MT_System.Action`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToList[[System.IO.DirectoryInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>)
       call      System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset DotNetTips.Spargine.IO.DirectoryHelper+<>c__DisplayClass10_0.<SafeFileSearch>b__0(System.IO.DirectoryInfo)
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rax,[rbp+18]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L04:
       mov       eax,1
       jmp       near ptr M02_L00
M02_L05:
       mov       ecx,1
       mov       rdx,7FFF790ADE28
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,2CF
       mov       rdx,7FFF790ADE28
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       call      DotNetTips.Spargine.Core.Properties.Resources.get_ErrorObjectCannotBeNull()
       mov       r8,rax
       mov       rcx,rsi
       mov       rdx,rdi
       call      DotNetTips.Spargine.Core.Validator.CreateParamExceptionMessage(System.String, System.String, System.String)
       mov       rcx,rax
       call      DotNetTips.Spargine.Core.ExceptionThrower.ThrowArgumentNullException(System.String)
       int       3
; Total bytes of code 546
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
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
       call      qword ptr [7FFF7EF47A98]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].AddWithResize(System.__Canon)
M00_L01:
       mov       rdx,1F6E800A828
       mov       rdx,[rdx]
       mov       rcx,rbx
       xor       r8d,r8d
       call      qword ptr [7FFF7F309360]; DotNetTips.Spargine.IO.DirectoryHelper.SafeFileSearch(System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>, System.String, System.IO.SearchOption)
       mov       [rsp+28],rax
       mov       rcx,[rsi+18]
       lea       r8,[rsp+28]
       mov       rdx,offset MD_BenchmarkDotNet.Engines.Consumer.Consume[[System.Collections.Generic.IEnumerable`1[[System.IO.FileInfo, System.Private.CoreLib]], System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.IO.FileInfo> ByRef)
       cmp       [rcx],ecx
       call      qword ptr [7FFF7F30FC78]; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       nop
       add       rsp,30
       pop       rbx
       pop       rsi
       pop       rdi
       ret
; Total bytes of code 188
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
       call      qword ptr [7FFFDD7C4818]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFDD7C4818]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFDD7C4818]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFDD7C4818]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFDD7C4818]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFDD7C4818]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFDD7C4818]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFDD7C4818]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFDD7C4818]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFDD7C4818]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFDD7C4818]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFDD7C4818]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
       call      qword ptr [7FFFDD7C4818]; Precode of System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].Grow(Int32)
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
       call      qword ptr [7FFFDD7A87C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFDD7A87C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFDD7A87C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFDD7A87C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFDD7A87C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFDD7A87C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFDD7A87C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFDD7A87C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFDD7A87C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFDD7A87C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFDD7A87C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFDD7A87C0]; CORINFO_HELP_ARRADDR_ST
       call      qword ptr [7FFFDD7A87C0]; CORINFO_HELP_ARRADDR_ST
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
; Total bytes of code 780
```
```assembly
; DotNetTips.Spargine.IO.DirectoryHelper.SafeFileSearch(System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>, System.String, System.IO.SearchOption)
       push      rdi
       push      rsi
       push      rbp
       push      rbx
       sub       rsp,28
       mov       rsi,rcx
       mov       rdi,rdx
       mov       ebx,r8d
       mov       rcx,offset MT_DotNetTips.Spargine.IO.DirectoryHelper+<>c__DisplayClass10_0
       call      CORINFO_HELP_NEWSFAST
       mov       rbp,rax
       lea       rcx,[rbp+8]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       test      rsi,rsi
       jne       near ptr M02_L06
       call      qword ptr [7FFF7F27FBB8]
       mov       ecx,0D
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],0B
       jl        near ptr M02_L11
       lea       rcx,[rdi+0C]
       mov       rdx,1F6E800A830
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,16
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,0B
       cmp       ecx,2
       jl        near ptr M02_L12
       lea       rcx,[rdi+22]
       mov       rdx,1F6E8002090
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       cmp       dword ptr [rdi+8],0
       je        short M02_L02
       mov       rcx,rdi
M02_L00:
       test      rcx,rcx
       jne       short M02_L01
       mov       eax,1
       jmp       near ptr M02_L04
M02_L01:
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       jmp       near ptr M02_L04
M02_L02:
       mov       rax,1F6E8002028
       mov       rcx,[rax]
       jmp       short M02_L00
M02_L03:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EED3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       lea       rcx,[rbp+8]
       mov       rdx,rax
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.SearchOption
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,offset MT_System.IO.SearchOption
       call      CORINFO_HELP_TYPEHANDLE_TO_RUNTIMETYPE
       mov       [rdi+8],ebx
       test      rax,rax
       je        near ptr M02_L13
       mov       rdx,rdi
       mov       rcx,rax
       call      qword ptr [7FFF7EDA8CE8]; System.RuntimeType.IsEnumDefined(System.Object)
       test      eax,eax
       jne       near ptr M02_L09
       call      qword ptr [7FFF7F27FA20]
       mov       rdi,rax
       mov       rcx,1F6E800A840
       mov       rcx,[rcx]
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L15
       jmp       near ptr M02_L14
M02_L04:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M02_L05
       call      qword ptr [7FFF7F27FCD8]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0D6190
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0D6190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F27F270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F27F900]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F27FD98]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L05:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EED3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F27F900]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L06:
       mov       rcx,[rbp+8]
       test      rcx,rcx
       je        short M02_L07
       xor       eax,eax
       cmp       dword ptr [rcx+8],0
       sete      al
       test      eax,eax
       sete      al
       movzx     eax,al
       cmp       dword ptr [rcx+8],0
       jne       short M02_L08
       jmp       short M02_L08
M02_L07:
       xor       eax,eax
M02_L08:
       test      eax,eax
       jne       near ptr M02_L03
       call      qword ptr [7FFF7F27FCD8]
       mov       rbp,rax
       mov       ecx,2B3
       mov       rdx,7FFF7F314CD8
       call      CORINFO_HELP_STRCNS
       mov       rbx,rax
       mov       ecx,9
       mov       rdx,7FFF7F0D6190
       call      CORINFO_HELP_STRCNS
       mov       rsi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0D6190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rbx
       mov       r9,rsi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F27F270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F27F900]
       mov       rdx,rax
       mov       rcx,rbp
       call      qword ptr [7FFF7F27FD98]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M02_L09:
       mov       rcx,offset MT_System.Collections.Generic.List`1[[System.IO.FileInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,1F6E80078D8
       mov       rdx,[rdx]
       lea       rcx,[rdi+8]
       call      CORINFO_HELP_ASSIGN_REF
       lea       rcx,[rbp+18]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,offset MT_System.IO.EnumerationOptions
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7F309468]; System.IO.EnumerationOptions..ctor()
       mov       byte ptr [rdi+1D],1
       mov       byte ptr [rdi+1E],0
       mov       byte ptr [rdi+1C],0
       lea       rcx,[rbp+10]
       mov       rdx,rdi
       call      CORINFO_HELP_ASSIGN_REF
       cmp       ebx,1
       jne       short M02_L10
       mov       rcx,[rbp+10]
       mov       byte ptr [rcx+1C],1
M02_L10:
       mov       rcx,offset MT_System.Action`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       mov       rdx,rsi
       mov       rcx,offset MD_System.Linq.Enumerable.ToList[[System.IO.DirectoryInfo, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.IO.DirectoryInfo>)
       call      qword ptr [7FFF7F309630]; System.Linq.Enumerable.ToList[[System.__Canon, System.Private.CoreLib]](System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rsi,rax
       lea       rcx,[rdi+8]
       mov       rdx,rbp
       call      CORINFO_HELP_ASSIGN_REF
       mov       rcx,7FFF7F3083D8
       mov       [rdi+18],rcx
       mov       rcx,rsi
       mov       rdx,rdi
       cmp       [rcx],ecx
       call      qword ptr [7FFF7EF47D20]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ForEach(System.Action`1<System.__Canon>)
       mov       rax,[rbp+18]
       add       rsp,28
       pop       rbx
       pop       rbp
       pop       rsi
       pop       rdi
       ret
M02_L11:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L12:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M02_L13:
       mov       ecx,2E7
       mov       rdx,7FFF7EC84000
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       call      qword ptr [7FFF7F03FF90]
       int       3
M02_L14:
       call      qword ptr [7FFF7F27FCD8]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0D6190
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0D6190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F27F270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F27F900]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F27FD98]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M02_L15:
       mov       edx,3
       call      qword ptr [7FFF7EED3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F27F918]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7F27FD98]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rbx
       call      qword ptr [7FFF7F065750]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
       int       3
; Total bytes of code 1307
```
```assembly
; BenchmarkDotNet.Engines.Consumer.Consume[[System.__Canon, System.Private.CoreLib]](System.__Canon ByRef)
       mov       rdx,[r8]
       lea       rcx,[rcx+10]
       call      CORINFO_HELP_ASSIGN_REF
       nop
       ret
; Total bytes of code 14
```

## .NET 6.0.13 (6.0.1322.58009), X64 RyuJIT AVX2
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
       mov       r8,2108F5E3020
       mov       r8,[r8]
       mov       r9,2108F5E9930
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

## .NET 7.0.2 (7.0.222.60605), X64 RyuJIT AVX2
```assembly
; DotNetTips.Spargine.BenchmarkTests.IO.DirectoryHelperBenchmark.SetFileAttributesToNormal01()
       mov       rcx,[rcx+190]
       jmp       qword ptr [7FFF7F309108]; DotNetTips.Spargine.IO.DirectoryHelper.SetFileAttributesToNormal(System.IO.DirectoryInfo)
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
       call      qword ptr [7FFF7F27F900]
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],4
       jl        near ptr M01_L16
       lea       rcx,[rdi+0C]
       mov       rdx,19E4EC06950
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       sub       ecx,4
       cmp       ecx,2
       jl        near ptr M01_L17
       lea       rcx,[rdi+14]
       mov       rdx,19E4EC00098
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,4
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
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
       mov       rcx,19E4EC00030
       mov       rcx,[rcx]
       jmp       short M01_L01
M01_L04:
       mov       r12d,[rdi+8]
       cmp       ebx,r12d
       jae       near ptr M01_L26
       mov       ecx,ebx
       mov       rcx,[rdi+rcx*8+10]
       call      qword ptr [7FFF7F309108]
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
       call      qword ptr [7FFF7F153D08]; System.IO.DirectoryInfo.InternalEnumerateInfos(System.String, System.String, System.IO.SearchTarget, System.IO.EnumerationOptions)
       mov       rdx,rax
       mov       rcx,offset MT_System.Collections.Generic.IEnumerable`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       call      qword ptr [7FFF7EE3B858]; System.Runtime.CompilerServices.CastHelpers.ChkCastAny(Void*, System.Object)
       mov       rdx,rax
       mov       rcx,r13
       call      qword ptr [7FFF7EF47930]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]]..ctor(System.Collections.Generic.IEnumerable`1<System.__Canon>)
       mov       rcx,r13
       call      qword ptr [7FFF7EF47F90]; System.Collections.Generic.List`1[[System.__Canon, System.Private.CoreLib]].ToArray()
       cmp       [rax+8],ebx
       jg        short M01_L04
       xor       ebx,ebx
       mov       rcx,rsi
       call      qword ptr [7FFF7F153B88]; System.IO.DirectoryInfo.GetDirectories()
       cmp       dword ptr [rax+8],0
       jle       short M01_L07
       mov       r12d,[rdi+8]
M01_L06:
       cmp       ebx,r12d
       jae       near ptr M01_L26
       mov       ecx,ebx
       mov       rcx,[rdi+rcx*8+10]
       mov       rcx,[rcx+8]
       call      qword ptr [7FFF7F153450]; System.IO.Path.GetFullPath(System.String)
       mov       rcx,rax
       mov       edx,80
       call      qword ptr [7FFF7F1CD618]
       add       ebx,1
       jo        near ptr M01_L15
       mov       rcx,rsi
       call      qword ptr [7FFF7F153B88]; System.IO.DirectoryInfo.GetDirectories()
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
       call      qword ptr [7FFF7F115658]; System.IO.FileSystemInfo.get_Exists()
       test      eax,eax
       jne       near ptr M01_L13
       call      qword ptr [7FFF7F27F9F0]
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
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       ecx,[rdi+8]
       mov       edx,[rbp+8]
       sub       edx,ecx
       cmp       edx,0B
       jl        near ptr M01_L23
       movsxd    rcx,ecx
       lea       rcx,[rbp+rcx*2+0C]
       mov       rdx,19E52C00C18
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,16
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       edx,[rdi+8]
       add       edx,0B
       mov       rcx,rbp
       mov       r8,rbx
       call      qword ptr [7FFF7EED1BB8]; System.String.FillStringChecked(System.String, Int32, System.String)
M01_L11:
       mov       ecx,6
       call      System.String.FastAllocateString(Int32)
       mov       rdi,rax
       cmp       dword ptr [rdi+8],4
       jl        near ptr M01_L24
       lea       rcx,[rdi+0C]
       mov       rdx,19E4EC06950
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,8
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       r8,19E4EC00098
       mov       r8,[r8]
       mov       rcx,rdi
       mov       edx,4
       call      qword ptr [7FFF7EED1BB8]; System.String.FillStringChecked(System.String, Int32, System.String)
       mov       rcx,rdi
       mov       rdx,19E4EC00030
       mov       rdx,[rdx]
       call      qword ptr [7FFF7EED1C60]; System.String.Concat(System.String, System.String)
       mov       rdi,rax
       call      qword ptr [7FFF7F27FA08]
       mov       rdx,rax
       mov       rcx,rdi
       call      qword ptr [7FFF7F27FD98]
       mov       rdi,rax
       mov       rcx,offset MT_DotNetTips.Spargine.Core.DirectoryNotFoundException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       mov       rcx,rbx
       call      qword ptr [7FFF7EED5C00]
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
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       sub       ebp,ebx
       cmp       ebp,0B
       jl        near ptr M01_L21
       movsxd    rcx,ebx
       lea       rcx,[r14+rcx*2]
       mov       rdx,19E52C00C18
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,16
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       jmp       near ptr M01_L11
M01_L13:
       mov       rcx,rsi
       call      qword ptr [7FFF7F153B88]; System.IO.DirectoryInfo.GetDirectories()
       mov       rdi,rax
       xor       ebx,ebx
       mov       rcx,19E50C01590
       mov       rbp,[rcx]
       mov       r14,offset MT_System.Collections.Generic.List`1[[System.IO.DirectoryInfo, System.Private.CoreLib]]
       mov       rcx,19E4EC003E0
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
       mov       rdx,19E52C00C18
       mov       rdx,[rdx]
       add       rdx,0C
       mov       r8d,16
       call      qword ptr [7FFF7EF199F0]; System.Buffer.Memmove(Byte ByRef, Byte ByRef, UIntPtr)
       mov       rcx,rdi
       mov       edx,0B
       mov       r8,rbx
       call      qword ptr [7FFF7EED1BB8]; System.String.FillStringChecked(System.String, Int32, System.String)
       jmp       near ptr M01_L11
M01_L15:
       call      CORINFO_HELP_OVERFLOW
M01_L16:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L17:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L18:
       test      eax,eax
       sete      al
       movzx     eax,al
       test      eax,eax
       jne       near ptr M01_L19
       call      qword ptr [7FFF7F27FCD8]
       mov       rsi,rax
       mov       ecx,9
       mov       rdx,7FFF7F0D6190
       call      CORINFO_HELP_STRCNS
       mov       rdi,rax
       mov       ecx,3AD
       mov       rdx,7FFF7F0D6190
       call      CORINFO_HELP_STRCNS
       mov       rcx,rax
       mov       r9,rdi
       mov       [rsp+20],rax
       mov       edx,1
       xor       r8d,r8d
       call      qword ptr [7FFF7F27F270]; DotNetTips.Spargine.Core.Validator.ArgumentNotNullOrEmpty(System.String, Boolean, System.String, System.String, System.String)
       mov       rdi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rbx,rax
       call      qword ptr [7FFF7F27F900]
       mov       rdx,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F27FD98]
       mov       r8,rax
       mov       rdx,rdi
       mov       rcx,rbx
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rbx
       call      CORINFO_HELP_THROW
M01_L19:
       cmp       [rcx],cl
       mov       edx,3
       call      qword ptr [7FFF7EED3510]; System.String.TrimWhiteSpaceHelper(System.Text.TrimType)
       mov       rsi,rax
       mov       rcx,offset MT_System.ArgumentNullException
       call      CORINFO_HELP_NEWSFAST
       mov       rdi,rax
       call      qword ptr [7FFF7F27F900]
       mov       r8,rax
       mov       rdx,rsi
       mov       rcx,rdi
       call      qword ptr [7FFF7F03FF18]
       mov       rcx,rdi
       call      CORINFO_HELP_THROW
M01_L20:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L21:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L22:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L23:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L24:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
M01_L25:
       mov       rcx,offset MT_System.IndexOutOfRangeException
       call      CORINFO_HELP_NEWSFAST
       mov       rsi,rax
       mov       rcx,rsi
       call      qword ptr [7FFF7F061C78]
       mov       rcx,rsi
       call      CORINFO_HELP_THROW
       int       3
M01_L26:
       call      CORINFO_HELP_RNGCHKFAIL
       int       3
; Total bytes of code 1572
```

